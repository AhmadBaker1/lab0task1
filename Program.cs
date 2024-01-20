namespace lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Variables
            Console.WriteLine("Enter a low number:");
            int lowNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a higher number");
            int highNumber = Convert.ToInt32(Console.ReadLine());

            int difference = highNumber - lowNumber;
            Console.WriteLine($"Your low number is {lowNumber} and your high number is {highNumber} and the difference between them is {difference}");

            
        }
    }

}
