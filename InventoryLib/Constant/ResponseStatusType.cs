using System;
namespace InventoryLib.Constant
{
    public enum ResponseStatusType
    {
        Success = 200,
        NotFound = 404,
        Conflict = 409,
        Fail = 500
    }
    public class Response
    {
        public static List<string> Message = null!;
    }
}

