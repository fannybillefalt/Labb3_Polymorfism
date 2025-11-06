namespace Labb3_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();

            List<Geometry> geometrys = new List<Geometry>();

            geometrys.Add(circle);
            geometrys.Add(square);
            geometrys.Add(rectangle);

            foreach (var item in geometrys)
            {
                Console.WriteLine($"Area of {item.GetType().Name}: {item.AreaMethod()}");
            }
        }
    }
}
