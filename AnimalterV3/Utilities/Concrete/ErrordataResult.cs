namespace AnimalterV3.Utilities.Concrete
{
    public class ErrordataResult<T> : DataResult<T>
    {
        public ErrordataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrordataResult(T data) : base(data, false)
        {

        }
        public ErrordataResult(string message) : base(default, false, message)
        {

        }
        public ErrordataResult() : base(default, false)
        {

        }
    }
}
