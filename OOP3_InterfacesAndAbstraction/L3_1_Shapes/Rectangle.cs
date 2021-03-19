using System;
using System.Collections.Generic;
using System.Text;

namespace L3_1_Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Draw()
        {
            DrawLine(width, "*", "*");
            for (int i = 1; i < height - 1; i++)
            {
                DrawLine(width, "*", " ");
            }
            DrawLine(width, "*", "*");
        }

        private void DrawLine(int width, string side, string mid)
        {
            Console.Write(side);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(side);
            Console.WriteLine();
        }
    }
}
