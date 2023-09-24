namespace OurCalcLib
{
    public class SimpleCalc
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int Add()
        {
            int result = FirstNumber + SecondNumber;
            return result;
            /*return 0;*/
        }
    }
}