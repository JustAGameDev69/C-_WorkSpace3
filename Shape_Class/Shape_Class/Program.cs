using System;
using System.Drawing;

namespace Shape
{
    public class Shape
    {
        private String color = "green";
        private bool filled = true;

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public Shape() { }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(String color)
        {
            this.color = color;
        }

        public bool IsFilled()
        {
            return filled;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public override String ToString()
        {
            return "This is a shape with color : " + color + " and " + (IsFilled() ? "filled" : "not filled");
        }

    }

    public class Circle : Shape
    {
        private double radius = 1.0;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override String ToString()
        {
            return "A Circle with radius="
                    + getRadius()
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }

    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle()
        {
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, bool filled, String color): base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double GetWidth()
        {
            return width;
        }

        public virtual void SetWidth(double width)
        {
            this.width = width; 
        }

        public double GetLength()
        {
            return length;
        }

        public double GetArea()
        {
            return width * this.length;
        }

        public double GetPerimeter()
        {
            return (width + this.length) * 2;
        }

        public virtual void SetLength(double length)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return "A Rectangle with width = " + GetWidth() + ", with length = " + GetLength() + ", which is a subclass of " + base.ToString();
        }
    }

    public class Square : Rectangle
    {
        private double side;

        public Square() { }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, String color, bool filled) : base(side, side, filled, color)
        {
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }

        public override void SetWidth(double width)
        {
            SetSide(width);
        }

        public override void SetLength(double length)
        {
            SetSide(length);
        }

        public override string ToString()
        {
            return "A Square with side=" + GetSide() + ", which is a subclass of " + base.ToString();
        }

    }
}