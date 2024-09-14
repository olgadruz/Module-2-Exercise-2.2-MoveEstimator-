namespace MoveEstimator;

class Program
{
    static void Main(string[] args)
    {
        double baserate = 200;
        double perhour = 150;
        double permile = 2;
        string hours = Console.ReadLine();
        string miles = Console.ReadLine();
        string[] x = hours.Split(" ");
        string[] y = miles.Split(" ");
        double xresult = Convert.ToDouble(x[0]);
        double yresult = Convert.ToDouble(y[0]);
        double px = baserate + perhour * xresult + permile * yresult;
        string result = px.ToString("F2");
        Console.WriteLine("$" + result);
    }
}
