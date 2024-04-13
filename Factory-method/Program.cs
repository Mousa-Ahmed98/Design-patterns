namespace Factory_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotDrink hotDrink;
            Console.WriteLine("Your order please...\n");
            Console.WriteLine("For tea press 1...\n");
            Console.WriteLine("For neskafe press 2...\n");
            int option = 0;
            int.TryParse(Console.ReadLine(), out option);

            hotDrink = DrinkFactory.GetDrink(option);
            hotDrink.Prepare();
        }
    }
}
