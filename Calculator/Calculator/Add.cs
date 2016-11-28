using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Arthematic
    {
        private int x, y;
        public Arthematic(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }
        public void setX(int x)
        {
            this.x = x;
        }


        public int getY()
        {
            return this.y;

        }
        public void setY(int y)
        {
            this.y = y;
        }

        public int sub()
        {
          return  x - y;

        }

        
        public  int add()
        {
            return x + y;
        }
    }
}
