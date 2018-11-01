using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFour
{
    class Pizza1
    {
        public double getArea(double radius)
        {
            return radius*radius*3.14;
        }
        public double areaPer(double area, double peopleNum, double pizzasNum)
        {
            return area*pizzasNum/peopleNum;
        }
    }
}