namespace AnimalterV3.Utilities.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)//sadece false olduğunu belirtmek
        {

        }
        public ErrorResult(string message) : base(false, message)//false ile mesajı döndermek
        {

        }

    }
}
