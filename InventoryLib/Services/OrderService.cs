using System;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Request.Order;
using InventoryLib.Models.Response.Order;
using InventoryLib.Models.Response.OrderDetail;
using InventoryLib.Validation;
using Microsoft.EntityFrameworkCore;

namespace InventoryLib.Services
{
	public class OrderService : IOrderService
	{
        private readonly IUnitOfWork _unitWork;

		public OrderService(IUnitOfWork unitOfWork)
		{
            _unitWork = unitOfWork;
		}
        public Response<string> Create(OrderCreateReq req)
        {
            var validationErrors = DataValidation<OrderCreateReq>.ValidateDynamicTypes(req);
            if (validationErrors.Count > 0)
            {
                return Response<string>.Fail(data: validationErrors.First().ToString());
            }

            var products = _unitWork.GetRepository<Product>().GetQueryable().Where(e => e.IsDeleted.Equals(false)).ToList();

            var orderDetails = new List<OrderDetail>();
            var order = new Order()
            {
                Id = Guid.NewGuid().ToString(),
                OrderDate = DateTime.Now.Date,
            };

            foreach (var item in req.OrderDetails)
            {
                var productFound = products.Where(e => e!.Id == item.ProductId).First();

                if (productFound == null)
                {
                    return Response<string>.NotFound($"Product Id {item.ProductId} not found.");
                }

                var orderDetail = new OrderDetail()
                {
                    Id = Guid.NewGuid().ToString(),
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    Price = productFound.Price,
                    Qty = item.Qty,
                };

                orderDetails.Add(orderDetail);
            }
            var total = orderDetails.Sum(e => e.Price * e.Qty);
            order.TotalPrice = total;
            
             //_unitWork.BeginTransaction();

            try
            {
                _unitWork.GetRepository<Order>().Add(order);
                _unitWork.GetRepository<OrderDetail>().AddRange(orderDetails);

                _unitWork.Save();

                return Response<string>.Success("Created Order Successfully.");
            }
            catch (Exception ex)
            {
                _unitWork.RollBackTransaction();

                Console.WriteLine(ex);
                return Response<string>.Fail(ex.Message)!;
            }
        }


        public Response<OrderResponse?> Read(Key key)
        {
            try
            {
                var data = _unitWork.GetRepository<Order>().GetQueryable()
                            .Where(e => e.Id.Equals(key.Id))
                            .Include(e => e.OrderDetails)
                            .Select(e => new OrderResponse()
                            {
                                Id = e.Id,
                                TotalPrice = e.TotalPrice,
                                OrderDate = e.OrderDate,
                                OrderDetails = e.OrderDetails!.Select(od => new OrderDetailResponse()
                                {
                                    Id = od.Id,
                                    ProductId = od.ProductId,
                                    ProductName = od.Product!.Name,
                                    Price = od.Price,
                                    Categoryname = od.Product.Category.Name,
                                    Qty = od.Qty,
                                    GrandTotal = (od.Price * od.Qty)
                                }).ToList()
                            }).FirstOrDefault();
                if (data == null)
                {
                    return Response<OrderResponse>.NotFound()!;
                }

                return Response<OrderResponse>.Success(data)!;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Response<OrderResponse>.Fail()!;
            }
        }

        public Response<List<OrderResponse>> ReadAll()
        {
            try
            {
                var data = _unitWork.GetRepository<Order>().GetQueryable()
                            .Include(e => e.OrderDetails)
                            .Select(e => new OrderResponse()
                            {
                                Id = e.Id,
                                TotalPrice = e.TotalPrice,
                                OrderDate = e.OrderDate,
                                OrderDetails = e.OrderDetails.Select(od => new OrderDetailResponse()
                                {
                                    Id = od.Id,
                                    ProductId = od.ProductId,
                                    ProductName = od.Product.Name,
                                    Price = od.Price,
                                    Categoryname = od.Product.Category.Name,
                                    Qty = od.Qty,
                                    GrandTotal = (od.Price * od.Qty)
                                }).ToList()
                            }).ToList();
                
                return Response<List<OrderResponse>>.Success(data,data.Count())!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<List<OrderResponse>>.Fail()!;
            }
        }

        public Response<string> Update(OrderUpdateReq req)
        {
            try
            {
                var orderDetails = _unitWork.GetRepository<OrderDetail>().GetQueryable()
                            .Include(e=>e.Order)
                            .ToList();
                var orderDetFound = new List<OrderDetail>();
                foreach (var order in req.OrderDetails!)
                {
                    var data = orderDetails.FirstOrDefault(e=>e.Id.Equals(order.Id));
                    if (data != null)
                    {
                        orderDetFound.Add(data);
                        foreach (var od in orderDetFound)
                        {
                            od.Qty = (int)((order.Qty==0)? od.Qty : order.Qty)!;
                        }
                    }
                }
                if (orderDetFound == null)
                {
                    return Response<string>.NotFound("Order Deatils do not existing.");
                }
                var orders = _unitWork.GetRepository<Order>().GetById(orderDetails.First().OrderId);

                orders.TotalPrice = orders.OrderDetails.Sum(e => e.Qty * e.Price);

                _unitWork.GetRepository<OrderDetail>().UpdateRange(orderDetFound);
                _unitWork.GetRepository<Order>().Update(orders);
                _unitWork.Save();
                
                return Response<string>.Success("Updated Successfully.");
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to update order.")!;
            }   
        }

        public Response<string> Delete(string key)
        {
            try
            {
                var order = _unitWork.GetRepository<Order>().GetById(key);
                if (order == null)
                {
                    return Response<string>.NotFound("Order not found.")!;
                }
                if (order.OrderDetails != null)
                {
                    _unitWork.GetRepository<OrderDetail>().DeleteRange(order.OrderDetails!);
                }
                _unitWork.GetRepository<Order>().Delete(order);

                _unitWork.Save();

                return Response<string>.Success("Deleted Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to delete order.")!;
            }
        }

        public Response<string> DeleteDetails(ICollection<Key> keys)
        {
            try
            {
                var orderDetails = _unitWork.GetRepository<OrderDetail>().GetQueryable();
                var orderDetailList = new List<OrderDetail>();

                foreach (var key in keys)
                {
                    var data = orderDetails.FirstOrDefault(e => e.Id.Equals(key.Id));
                    if (data == null)
                        return Response<string>.NotFound($"This Order Detail Id = '{key.Id}' was not found.");
                    else
                        orderDetailList.Add(data);
                }

                _unitWork.GetRepository<OrderDetail>().DeleteRange(orderDetailList);
                _unitWork.Save();

                return Response<string>.Success("Deleted Successfully.");
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail($"Failed to Delete");
            }
        }
    }
}

