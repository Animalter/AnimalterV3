namespace AnimalterV3.Utilities.Abstract
{
    public interface IDataResult<T> : IUtilityResult
    {
       
         T Data { get; }//başarılı olduysa gelecek veri.
        
    }
}
