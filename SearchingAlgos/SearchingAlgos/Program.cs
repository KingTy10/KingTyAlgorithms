namespace SearchingAlgos 
{


    public class Program
    {
        static void Main(string[] args)
        {

            Linear lin = new Linear();
           lin.printTheLinear();
            
            Binary bin = new Binary();
            bin.CallingBinarySearch();

            Interpolation inter = new Interpolation();
            inter.PutInterpolationOnThePhone();
        }
    }

}

