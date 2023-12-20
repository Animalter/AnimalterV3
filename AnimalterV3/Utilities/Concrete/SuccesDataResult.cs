namespace AnimalterV3.Utilities.Concrete
{
    public class SuccesDataResult<T>:DataResult<T>
    {
        public SuccesDataResult(T data,string message):base(data,true,message)//T türünde veri ve string türünde mesaj alır,datareslt sınııfındaki base içindekileri alır.
        {
            
        }
        public SuccesDataResult(T data):base(data,true)
        {
            
        }
        public SuccesDataResult(string message ):base(default,true,message)
        {
            
        }
        public SuccesDataResult():base(default,true) 
        {
            
        }
    }
}
