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

        //       public Response<string> Create(StockingCreateReq req)
        //       {
        //           try
        //           {
        //               var validationErrors = DataValidation<StockingCreateReq>.ValidateDynamicTypes(req);
        //               if (validationErrors.Count > 0)
        //               {
        //                   return Response<string>.Fail(data: validationErrors.First().ToString());
        //               }
        //               var stock = new Stocking()
        //               {
        //                   Id = Guid.NewGuid().ToString(),
        //                   ProductId = req.ProductId,
        //                   Qty = req.Qty,
        //                   TransactionDate = DateTime.Now
        //               };

        //               if (req.Status == StatusType.StockIn)
        //               {
        //                   //stock = AddStock(StockingCreateReq);
        //               }
        //               else if(req.Status == StatusType.StockOut)
        //               {
        //                   //stock = RemoveStock(StockingCreateReq);
        //               }


        //               _unitWork.GetRepository<Stocking>().Add(stock);
        //               _unitWork.Save();

        //               return Response<string>.Fail("Created Successfully.");
        //           }
        //           catch
        //           {
        //               return Response<string>.Fail("Failed to create stocking.");
        //           }
        //       }
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

                var transaction = CreateStockTransaction(req);
                if (transaction == null)
                {
                    return Response<string>.Fail("Failed to create stocking.");
                }

                _unitWork.GetRepository<Stocking>().Add(transaction.GetStock());
                _unitWork.Save();

                return Response<string>.Success("Created Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to create stocking.");
            }
        }

        public Response<StockingResponse?> Read(Key key)
        {
            try
            {
                var stock = _unitWork.GetRepository<Product>().GetQueryable()
                            .Where(e=>e.Id==key.Id)
                            .Include(e=>e.Stockings)
                            .Select(e=>new StockingResponse()
                            {
                                ProductId = e.Id,
                                ProductName = e.Name,
                                Price = e.Price,
                                Qty = e.Stockings.Sum(e=>e.Qty),
                                Stockings = e.Stockings.Select(s=>new Stocking()
                                {
                                    Id = s.Id,
                                    ProductId = s.ProductId,
                                    Qty = s.Qty,
                                    Status = s.Status
                                }).ToList()
                            }).First();
                return Response<StockingResponse>.Success(stock)!;
            }
            catch
            {
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
                                Qty = e.Stockings!.Sum(e => e.Qty),
                                Stockings = e.Stockings.Select(s => new Stocking()
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
                return Response<string>.Success();
            }
            catch
            {
                return Response<string>.Fail();
            }
        }
    }

    
}