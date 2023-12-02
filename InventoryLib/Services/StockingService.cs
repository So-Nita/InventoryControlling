using System;
using System.Linq;
using System.Runtime.CompilerServices;
using InventoryLib.Constant;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Models;
using InventoryLib.Models.Request.Product;
using InventoryLib.Validation;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System.Numerics;
using InventoryLib.UnitOfWork;
using System.Diagnostics;

namespace InventoryLib.Services
{
    public class StockingService : IStockingService
    {
        private readonly IUnitOfWork _unitWork;
        protected int Factor = 1;

        public StockingService(IUnitOfWork unitOfWork)
        {
            _unitWork = unitOfWork;
        }

        private StockTransaction? CreateStockTransaction(StockingCreateReq req)
        {
            try
            {
                StockTransaction transaction;

                if (req.Status == StatusType.StockIn)
                {
                    transaction = new StockInTransaction(req.ProductId, req.Qty);
                }
                else if (req.Status == StatusType.StockOut)
                {
                    transaction = new StockOutTransaction(req.ProductId, req.Qty);
                }
                else
                {
                    return null;
                }

                transaction.OperateOn(this);

                return transaction;
            }
            catch
            {
                return null;
            }
        }

        public Response<string> Create(StockingCreateReq req)
        {
            try
            {
                var validationErrors = DataValidation<StockingCreateReq>.ValidateDynamicTypes(req);
                if (validationErrors.Count > 0)
                {
                    return Response<string>.Fail(data: validationErrors.First().ToString());
                }
                var product = _unitWork.GetRepository<Product>().GetById(req.ProductId);
                if (product == null)
                {
                    return Response<string>.NotFound("Product Id does not existing.");
                }
                if ((product.Qty.Equals(null) || product.Qty<req.Qty) && req.Status== StatusType.StockOut )
                {
                    return Response<string>.Fail($"Failed Product qty is Limited.");
                }
                var transaction = CreateStockTransaction(req);

                if (transaction == null) return Response<string>.Fail("Failed to create stocking product");

                product.Qty = transaction.ProductQty;

                _unitWork.GetRepository<Stocking>().Add(transaction.GetStock());
                _unitWork.GetRepository<Product>().Update(product);

                _unitWork.Save();

                return Response<string>.Success("Created Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                _unitWork.RollBackTransaction();
                return Response<string>.Fail("Failed to create stocking.");
            }
        }

        public Response<StockingResponse?> Read(Key key)
        {
            try
            {
                var stock = _unitWork.GetRepository<Product>().GetQueryable()
                            .Where(e => e.Id == key.Id && e.IsDeleted == false)
                            .Include(e=>e.Stockings)
                            .Select(e => new StockingResponse()
                             {
                                 ProductId = e.Id,
                                 ProductName = e.Name,
                                 Price = e.Price,
                                 Qty = e.Qty ?? 0,
                                 Stockings = e.Stockings.Select(s => new Stocking()
                                 {
                                     Id = s.Id,
                                     ProductId = s.ProductId,
                                     Qty = s.Qty,
                                     Status = s.Status
                                 }).ToList()
                             }).First();
                
                return Response<StockingResponse>.Success(stock)!;
            }
            catch(Exception ec)
            {
                Console.Write(ec);
                return Response<StockingResponse>.Fail(null)!;
            }
        }

        public Response<List<StockingResponse>> ReadAll()
        {
            try
            {
                var stocks = _unitWork.GetRepository<Product>().GetQueryable()
                            .Where(e => e.Stockings.Count != 0)
                            .Include(e => e.Stockings)
                            .Select(e => new StockingResponse()
                            {
                                ProductId = e.Id,
                                ProductName = e.Name,
                                Price = e.Price,
                                Qty = (int)e.Qty!,
                                Stockings = e.Stockings.OrderBy(e=>e.TransactionDate).Select(s => new Stocking()
                                {
                                    Id = s.Id,
                                    ProductId = s.ProductId,
                                    Qty = s.Qty,
                                    Status = s.Status
                                }).ToList()
                            }).ToList();
               
                return Response<List<StockingResponse>>.Success(stocks, stocks.Count())!;

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
                return Response<List<StockingResponse>>.Fail(null)!;
            }
        }

        public Response<string> Update(StockingUpdateReq req)
        {
            try
            {
                var stock = _unitWork.GetRepository<Stocking>().GetById(req.Id);
                if (stock == null) return Response<string>.NotFound("Stocking transaction not found.");
                return Response<string>.Success();
            }
            catch
            {
                return Response<string>.Fail();
            }
        }
        public Response<string> Delete(string key)
        {
            try
            {
                if (key == null) return Response<string>.Fail("Stocking Id is required.");

                var stock = _unitWork.GetRepository<Stocking>().GetById(key);
                if(stock==null) return Response<string>.Fail("Stocking Id does not existing.");

                _unitWork.GetRepository<Stocking>().Delete(stock);
                _unitWork.Save();

                return Response<string>.Success("Deleted Stocking Transaction successfully");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail();
            }
        }
    }

    
}