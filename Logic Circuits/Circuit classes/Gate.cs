using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Circuits
{
   public abstract class Gate
    {
        // left is the left-hand edge of the main part of the gate.
        // So the input pins are further left than left.
        protected int left;

        // top is the top of the whole gate
        protected int top;

        // width and height of the main part of the gate
        protected const int WIDTH = 40;
        protected const int HEIGHT = 40;
        // length of the connector legs sticking out left and right
        protected const int GAP = 10;

        protected Brush selectedBrush = Brushes.Red;
        protected Brush normalBrush = Brushes.LightGray;


        /// <summary>
        /// This is the list of all the pins of this gate.
        /// An AND gate always has two input pins (0 and 1)
        /// and one output pin (number 2).
        /// </summary>
        protected List<Pin> pins = new List<Pin>();

        //Selected bool variables
        protected bool selected = false;
        protected bool on = false;

        /// <summary>
        /// Gate method
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public Gate(int x, int y)
        {

        }


        /// <summary>
        /// Indicates whether this gate is the current one selected.
        /// </summary>
        public virtual bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public int Left
        {
            get { return left; }
        }

        public int Top
        {
            get { return top; }
        }

        public List<Pin> Pins
        {
            get { return pins; }
        }

        /// <summary>
        /// True if the given (x,y) position is roughly
        /// on top of this gate.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public virtual bool IsMouseOn(int x, int y)
        {
            if (left <= x && x < left + WIDTH
                && top <= y && y < top + HEIGHT)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Draw method
        /// </summary>
        /// <param name="paper">Graphics paper</param>
        public abstract void Draw(Graphics paper);

        /// <summary>
        /// MoveTo method 
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public abstract void MoveTo(int x, int y);

        /// <summary>
        /// Evaluate method checks output
        /// </summary>
        /// <returns></returns>
        public abstract bool Evaluate();

        /// <summary>
        /// Clone method for the gate class
        /// </summary>
        /// <returns></returns>
        public abstract Gate Clone();
    }
}
