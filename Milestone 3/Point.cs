using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Point
    {
        private int row;
        private int column;
        public Point(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public int Row { get { return row; } }
        public int Column { get { return column; } }
        public override string ToString()
        {
            return $"[{row}, {column}]";
        }
    }
}
