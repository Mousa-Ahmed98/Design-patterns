namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateIceCream chocolateIceCream = new ChocolateIceCream();

            Console.WriteLine(chocolateIceCream.GetDescription());
            Console.WriteLine(new VanillaIceCream(chocolateIceCream).GetDescription());
            Console.WriteLine(new StrawberryIceCream(new VanillaIceCream(chocolateIceCream)).GetDescription());

            Console.WriteLine(new VanillaIceCream(new StrawberryIceCream(new VanillaIceCream(chocolateIceCream))).GetDescription());
        }
    }
}
