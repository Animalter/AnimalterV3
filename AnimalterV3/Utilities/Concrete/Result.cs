






using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Utilities.Concrete
{


    public class Result : IUtilityResult
    {
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

    

        public string Message { get; }





        public Task ExecuteAsync(HttpContext httpContext)
        {
            throw new NotImplementedException();
        }
    }

}





