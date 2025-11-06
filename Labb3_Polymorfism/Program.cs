namespace Labb3_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
            //A list with the base class type containing different object after using .Add
            List<Geometry> geometrys = new List<Geometry>();

            geometrys.Add(circle);
            geometrys.Add(square);
            geometrys.Add(rectangle);

            //same method calling but different output
            foreach (var item in geometrys)
            {
                Console.WriteLine($"Area of {item.GetType().Name}: {item.AreaMethod()}");
            }
        }
    }
}
