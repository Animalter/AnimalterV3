namespace AnimalterV3.Utilities.Concrete
{
    public class SuccessReasult:Result
    {
        public SuccessReasult():base(true)//sadece tru olduğunu belirtmek
        {
            
        }
        public SuccessReasult(string message):base(true,message)//true ile mesajı döndermek
        {
            
        }
    }
}
