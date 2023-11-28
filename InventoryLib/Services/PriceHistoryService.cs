using System;
using System.Collections.Generic;
using System.Diagnostics;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Request.PriceHistory;
using InventoryLib.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace InventoryLib.Services
{
    public class PriceHistoryService : IPriceHistoryService<PriceHistoryResponse>
    {
        private readonly IUnitOfWork _unitWork;

        public PriceHistoryService(IUnitOfWork unitOfWork)
        {
            _unitWork = unitOfWork;
        }

        public Response<PriceHistoryResponse> Read(string productId)
        {
            try
            {
                var priceHistories = _unitWork.GetRepository<PriceHistory>().GetQueryable()
                            .Where(e => e.ProductId == productId)
                            .Include(e => e.Product)
                            .OrderByDescending(e=>e.UpdateDate).ToList();
                if (priceHistories == null)
                {
                    return Response<PriceHistoryResponse>.NotFound();
                }
                var data = priceHistories!.Select(e=> new PriceHistoryResponse()
                {
                    ProductId = e.ProductId,
                    ProductName = e.Product.Name,
                    ProductCode = e.Product.Code,
                    Cost = e.Product.Cost,
                    Price = e.Product.Price,
                }).FirstOrDefault();

                var listPrices = new List<PriceHistory>();
                foreach(var item in priceHistories!)
                {
                    var price = new PriceHistory()
                    {
                        Id = item.Id,
                        OldPrice = item.OldPrice,
                        CurrentPrice = item.CurrentPrice,
                        UpdateDate = item.UpdateDate
                    };
                    listPrices.Add(price);
                }
                data!.PriceHistories = listPrices;

                return Response<PriceHistoryResponse>.Success(data);
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                return Response<PriceHistoryResponse>.Fail();
            }
        }

        public Response<List<PriceHistoryResponse>> ReadAll()
        {
            try
            {
                var priceHistories = _unitWork.GetRepository<PriceHistory>().GetQueryable()
                            .Include(e => e.Product)
                            .OrderByDescending(e => e.UpdateDate)
                            .GroupBy(e => e.ProductId)
                            .ToList();
                var resultList = priceHistories.Select(group => new PriceHistoryResponse
                {
                    ProductId = group.Key,
                    ProductName = group.First()!.Product.Name ?? "",
                    ProductCode = group.First()!.Product.Code ?? "",
                    Image = group.First()!.Product.Image,
                    Cost = group.First()!.Product.Cost,
                    Price = group.First()!.Product.Price,
                    PriceHistories = group.Select(e => new PriceHistory
                    {
                        Id = e.Id,
                        OldPrice = e.OldPrice,
                        CurrentPrice = e.CurrentPrice,
                        UpdateDate = e.UpdateDate
                    }).ToList()
                }).ToList();

                return Response<List<PriceHistoryResponse>>.Success(resultList);
            }
            catch
            {
                return Response<List<PriceHistoryResponse>>.Fail();
            }
        }


        public static Response<string> Create(IUnitOfWork unitWork, PriceHistoryCreateReq req)
        {
            try
            {
                var priceHistory = new PriceHistory()
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductId = req.ProductId,
                    OldPrice = req.OldPrice,
                    CurrentPrice = req.CurrentPrice,
                    UpdateDate = DateTime.Now
                };
                unitWork.GetRepository<PriceHistory>().Add(priceHistory);
                unitWork.Save();
                return Response<string>.Success("Created PriceHistory Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to Create PriceHistory.")!;
            }
        }

    }
}
