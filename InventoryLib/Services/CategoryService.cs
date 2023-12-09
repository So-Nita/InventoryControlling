using System;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Models;
using InventoryLib.Models.Request.Category;
using InventoryLib.Models.Request.Product;
using InventoryLib.Models.Response.Category;
using InventoryLib.UnitOfWork;
using InventoryLib.Validation;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.IdentityModel.Tokens;

namespace InventoryLib.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitWork = unitOfWork;
        }

        public Response<CategoryResponse?> Read(Key key)
        {
            try
            {
                var categories = _unitWork.GetRepository<Category>().GetAll()
                                .Where(e=>e.IsDeleted.Equals(false) && e.Id==key.Id)
                                .Select(e=>new CategoryResponse()
                                {
                                    Id = e.Id,
                                    Name = e.Name,
                                    Image = e.Image,
                                    Description = e.Description
                                }).First();
                if (categories == null) return null!;

                return Response<CategoryResponse?>.Success(categories);
            }catch(ArgumentException ex)
            {
                return Response<CategoryResponse?>.Fail();
            }
        }

        public Response<List<CategoryResponse>> ReadAll()
        {
            try
            {
                var categories = _unitWork.GetRepository<Category>().GetQueryable()
                            .Where(e => e.IsDeleted.Equals(false))
                            .Select(e => new CategoryResponse()
                            {
                                Id = e.Id,
                                Name = e.Name,
                                Image = e.Image,
                                Description = e.Description
                            }).ToList();
                return Response<List<CategoryResponse>>.Success(categories, categories.Count());

            }catch(ArgumentException ex)
            {
                return Response<List<CategoryResponse>>.Fail();
            }
        }

        public Response<string> Create(CategoryCreateReq req)
        {
            try
            {
                var validationErrors = DataValidation<CategoryCreateReq>.ValidateDynamicTypes(req);
                if (validationErrors.Count > 0)
                {
                    return Response<string>.Fail(validationErrors.First().ToString());
                }
                var existCateName = ReadAll().Result!.FirstOrDefault(e => e.Name == req.Name);
                if (existCateName != null)
                {
                    return Response<string>.Conflict("Conflict Category's name is existing.");
                }
                var category = new Category()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = req.Name,
                    Image = req.Image!,
                    Description = req.Description,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                };

                _unitWork.GetRepository<Category>().Add(category);
                _unitWork.Save();

                return Response<string>.Success("Created Category Successfully.");
            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to Create Category.");
            }
        }

        public Response<string> Update(CategoryUpdateReq req)
        {
            try
            {
                var validationErrors = req.Id.IsNullOrEmpty();
                if (validationErrors)
                {
                    return Response<string>.Fail("Field Id is requried.");
                }
                var foundCate = _unitWork.GetRepository<Category>()
                                .GetQueryable().Where(e=>e.Id== req.Id&&e.IsDeleted==false).First();
                if (foundCate == null)
                {
                    return Response<string>.NotFound("Category does not existing.");
                }

                foundCate.Name = (req.Name=="") ? foundCate.Name : req.Name!;
                foundCate.Image = req.Image ?? foundCate.Image;
                foundCate.Description = req.Description ?? foundCate.Description;
               
                _unitWork.GetRepository<Category>().Update(foundCate);
                _unitWork.Save();

                return Response<string>.Success("Updated Successfully.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to Delete Category.");
            }
        }
        

        public Response<string> Delete(string key)
        {
            try
            {
                if (key == null)
                {
                    return Response<string>.Fail("Category id is required.");
                }
                var category = _unitWork.GetRepository<Category>().GetQueryable().FirstOrDefault(e => e.Id == key);
                if (category == null) return Response<string>.NotFound("Category does not existing.");

                category.IsDeleted = true;

                _unitWork.GetRepository<Category>().Delete(category);
                _unitWork.Save();

                return Response<string>.Success("Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Response<string>.Fail("Failed to delete Category.");
            }
        }
    }
}

