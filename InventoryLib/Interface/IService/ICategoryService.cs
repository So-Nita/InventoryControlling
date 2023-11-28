using InventoryLib.Models.Request.Category;
using InventoryLib.Models.Response.Category;

namespace InventoryLib.Services
{
    public interface ICategoryService : IService<CategoryResponse,CategoryCreateReq,CategoryUpdateReq>
    {
    }
}