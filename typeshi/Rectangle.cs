using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeshi
{
    internal class Rectangle
    {
        //1. implemntierung feld 
        private int height;

        //2. feld dessen wert nicht verändert
        private readonly int width;

        //3. 
        private int area = 0;

        //4.
        private int _area;

        public int Area
        {
            get { return _area; }
        }

        //5.
        private int _zebi;

        public int Zebi
        {
            get { return _zebi; }
            set { _zebi = value; }
        }

        //6.
        private int _volume;

        public int Volume
        {
            set { _volume = value; }
        }


        //7.
        public int Diagonal { get; } = 10;

        //8.
        public int Thickness { get; set; } = 2;

        //9.
        public int Shadow { private get; set; }

        //10.
        private int _borderRadius;

        public int BorderWidth => 3;  // Read-only
        public int BorderRadius { set => _borderRadius = value; }  // Write-only



    }
}
