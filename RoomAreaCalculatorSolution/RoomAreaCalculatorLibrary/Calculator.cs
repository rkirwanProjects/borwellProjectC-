using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomAreaCalculatorLibrary
{
    public class Calculator
    {
        public static double CalculateFloorArea(double width, double length)
        {
            return width * length;
        }

        public static double CalculateRoomVolume(double width, double length, double height)
        {
            return width * length * height;
        }

        public static double CalculatePaintRequired(double width, double length, double height)
        {
            return (height * width * 2) + (height * length * 2);
        }
    }
}
