namespace AnimalterV3.Utilities.Abstract
{
    public interface IUtilityResult
    {
        bool Success { get; }//başarılı mı
        string Message { get; } //olıup olmadığının mesajı
    }
}
