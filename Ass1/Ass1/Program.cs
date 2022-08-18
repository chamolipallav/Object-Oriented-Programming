using System; 

namespace Ass1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            double height = 0; 
            double width = 0;
            double totalarea = 0;

            double input = inputData(height, width);
            double Calcarea = area(height, width);
            double DisplayData = Display(height, width, totalarea);
            
            
            
        }
        public static double inputData(double height, double width)
        {

            Console.WriteLine("enter the height of triangle ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the base of triangle");
            width = Convert.ToDouble(Console.ReadLine());
            area(height, width);
            return 0;
            
            

        }
        public static double area(double height, double width)
        {
            double totalarea;
            totalarea = (height * width) / 2;
            Display(height, width, totalarea);
            return totalarea;

        }
        public static double Display(double height, double width, double totalarea)
        {
            double h = height;
            double w = width;
            double a = totalarea;
            Console.WriteLine("height of the triangle {0}", h);
            Console.WriteLine("width of the triange {0}", w);
            Console.WriteLine("area of the triange {0}", a);
            return 0;
          
        }
    }
}
