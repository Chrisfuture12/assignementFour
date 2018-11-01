using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFour
{
    class PizzaM
    {
        public static double getInput(string x)
        {
            string userIn;
            Console.WriteLine(x);
            userIn = Console.ReadLine();
            double userInD = double.Parse(userIn);
            return userInD;
        }
        public static void display(double pizzasNum, double share, double radius){
            Console.WriteLine("\tHere is your order summary: ");
            Console.WriteLine("\tYou ordered "+ pizzasNum + " pizza(s).");
            Console.WriteLine("\tThe share of pizza for each person is "+share+ " square inches.");
            Console.WriteLine("\tThe diameter of each pizzas is "+ radius*2+ " inches.");
            
        }

        public static void Main()
        {
            double pizzasNum = getInput("Please enter the number of pizzas to be ordered.");   
            double radius = getInput("Please enter the radius of the pizza in inches.");
            double peopleNum = getInput("Please enter the number of people that will eat.");

            Pizza1 circle1 = new Pizza1();

            double area = circle1.getArea(radius);
            double share = circle1.areaPer(area, pizzasNum, peopleNum);

            display(pizzasNum,share,radius);

            
        
                
            

            Console.ReadKey();
        }
    }
}
