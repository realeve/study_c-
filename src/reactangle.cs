using System;
namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("area:{0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void test(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}