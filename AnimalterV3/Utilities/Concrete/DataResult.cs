using AnimalterV3.Utilities.Abstract;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnimalterV3.Utilities.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data ,bool success, string message) : base(success, message)//Base Başka sınııfn yapıcı bloğuna erişmek için
        {
            Data = data;   
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

       

        public T Data {  get;  }

    }
}
