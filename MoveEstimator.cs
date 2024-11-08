namespace MoveEstimator;

class Program
{
    static void Main(string[] args)
    {
        const double BASE_RATE = 200;
        const double PER_HOUR = 150;
        const double PER_MILE = 2;
        Console.WriteLine("Please Enter the hours: ");
        double hours = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please Enter the miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double px = BASE_RATE + PER_HOUR * hours + PER_MILE * miles;
        string result = px.ToString("F2");
        Console.WriteLine("$" + result);
    }
}
