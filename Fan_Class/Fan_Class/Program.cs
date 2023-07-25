using System;

namespace fan_class
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed;
        private bool on;
        private double radius;
        private string color;

        public int Fan_speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool Fan_state
        {
            get { return on; }
            set { on = value; }
        }

        public double Fan_radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Fan_color
        {
            get { return color; }
            set { color = value; }
        }

        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }

        public override string ToString()
        {
            if (on)
            {
                return "Fan is on, fan speed is " + speed + ", fan color is " + color + ", fan radius is: " + radius;
            }
            else
            {
                return "Fan is off, fan color is " + color + ", fan radius is " + radius;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan_1 = new Fan();
            fan_1.Fan_speed = Fan.FAST;
            fan_1.Fan_state = true;
            fan_1.Fan_color = "yellow";
            fan_1.Fan_radius = 10;

            Fan fan_2 = new Fan();
            fan_2.Fan_speed = Fan.MEDIUM;
            fan_2.Fan_state = false;
            fan_2.Fan_color = "blue";
            fan_2.Fan_radius = 5;

            Console.WriteLine("Fan 1: " + fan_1.ToString());
            Console.WriteLine("Fan 2: " + fan_2.ToString());
        }
    }
}