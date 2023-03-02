namespace TutorialPoint
{
    public class Program
    {
        static void Main(string[] args)
        {
            RectangleShape shape = new RectangleShape();
            shape.Width = 10;
            shape.Length = 5;
            Console.WriteLine($"The area of {nameof(shape)} is = {shape.CheckArea()}");
            Square square = new Square();
            square.Length = 5;
            Console.WriteLine($"The area of {nameof(square)} is = {square.CheckArea()}");
            Circle circle = new Circle();
            circle.radius = 10;
            Console.WriteLine($"The area of {nameof(circle)} is = {circle.CheckArea()}");

            IShape square1 = new Square();
            IShape rectangle = new RectangleShape();

            rectangle.Length = square1.Length = 10;
            rectangle.Width = 5;
            Console.WriteLine($"Area of square1 ={ square1.CheckArea()} Area of rectangle = {rectangle.CheckArea()}");




        }

        public class Shapes
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double radius { get; set; } 
           
        } 
       
       

    }
    

    
}