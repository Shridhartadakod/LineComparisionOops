using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionOops
{

    internal class LineComparison
    {
        public int X_One;
        public int X_Two;
        public int Y_One;
        public int Y_Two;
        public int A_One;
        public int A_Two;
        public int B_One;
        public int B_Two;
        public void length_line()
        {

            Console.WriteLine("Enter x, y co ordinates of the line 1 :");
            Console.WriteLine("Enter value X_One");
            X_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X_Two");
            X_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y_One");
            Y_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y_Two");
            Y_Two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x, y co ordinates of the line 2 :");
            Console.WriteLine("Enter value of S_One");
           A_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S_Two");
            A_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_One");
           B_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_Two");
           B_Two = Convert.ToInt32(Console.ReadLine());

            double Length_XY = Math.Sqrt(Math.Pow((X_One - X_Two), 2) + Math.Pow((Y_Two - Y_One), 2));
            Console.WriteLine("Length of Line 1 is:: " + Length_XY);

            double Length_SR = Math.Sqrt(Math.Pow((A_Two - A_One), 2) + Math.Pow((B_Two - B_One), 2));
            Console.WriteLine("Length of Line 2 is: " + Length_SR);
            Console.ReadLine();

        }
    }
}

