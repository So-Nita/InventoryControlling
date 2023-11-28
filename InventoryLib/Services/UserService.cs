using System;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Interface.IService;
using InventoryLib.Models;
using InventoryLib.Models.Response.User;

namespace InventoryLib.Services
{
    public class UserService : IUserService<UserResponse>
    {
        private readonly IUnitOfWork _unitWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitWork = unitOfWork;
        }
        public Response<UserResponse> Read(string Id)
        {
            try
            {
                var user = _unitWork.GetRepository<User>().GetQueryable()
                        .Where(e =>e.Id.Equals(Id)).Select(e=>new UserResponse()
                        {
                            Id = e.Id,
                            UserName = e.UserName,
                            Contact = e.Contact.ToString(),
                            Image = e.Image,
                            Password = e.Password,
                            Role = e.Role.ToString()
                        }).FirstOrDefault();
                if (user == null)
                {
                    return Response<UserResponse>.NotFound();
                }
                return Response<UserResponse>.Success(user);

            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
                return null!;
            }
        }

        public Response<List<UserResponse>> ReadAll()
        {
            try
            {
                var user = _unitWork.GetRepository<User>().GetAll()
                        .Select(e => new UserResponse()
                        {
                            Id = e.Id,
                            UserName = e.UserName,
                            Contact = e.Contact.ToString(),
                            Image = e.Image,
                            Password = e.Password,
                            Role = e.Role.ToString()
                        }).ToList();

                return Response<List<UserResponse>>.Success(user);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
                return Response<List<UserResponse>>.Fail();
            }
        }
    }
}

