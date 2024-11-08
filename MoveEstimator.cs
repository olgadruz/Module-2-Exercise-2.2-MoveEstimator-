namespace MoveEstimator;

class Program
{
    static void Main(string[] args)
    {
        const double BASE_RATE = 200;
        const double PER_HOUR = 150;
        const double PER_MILE = 2;
        Console.WriteLine("Please Enter the hours: ");
        string hours = Console.ReadLine();
        Console.WriteLine("Please Enter the miles: ");
        string miles = Console.ReadLine();
        string[] x = hours.Split(" ");
        string[] y = miles.Split(" ");
        double xresult = Convert.ToDouble(x[0]);
        double yresult = Convert.ToDouble(y[0]);
        double px = BASE_RATE + PER_HOUR * xresult + PER_MILE * yresult;
        string result = px.ToString("F2");
        Console.WriteLine("$" + result);
    }
}
