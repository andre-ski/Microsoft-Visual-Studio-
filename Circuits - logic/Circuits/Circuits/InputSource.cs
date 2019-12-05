using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Circuits
{
    class InputSource : Gate
    {

        /// <summary>
        /// Inherit from Gate class
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public InputSource(int x, int y) : base(x, y)
        {
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, false, 20));
            MoveTo(x, y); // move the gate and position the pins
        }

        public override void Draw(Graphics paper)
        {
            Brush SelectedBrush = Brushes.Red;
            Brush OnBrush = Brushes.Green;
            Brush OffBrush = Brushes.LightGray;
            Brush brush;
            if(selected)
            {
               
                on = !on;
            }
           if(on==true)
            {
                brush = OnBrush;
            }
            else
            {
                brush = OffBrush;
            }

            foreach (Pin p in pins)
                p.Draw(paper);

            // AND is simple, so we can use a circle plus a rectange.
            // An alternative would be to use a bitmap.
            paper.FillRectangle(brush, left, top, WIDTH, HEIGHT / 2);

        }
        /// <summary>
        /// Override MoveTo method
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public override void MoveTo(int x, int y)
        {
            Debug.WriteLine("pins = " + pins.Count);
            left = x;
            top = y;
            // must move the pins too

            pins[1].X = x + WIDTH + GAP;
            pins[1].Y = y + HEIGHT / 4;
        }
        /// <summary>
        /// Override the bool evaluate method
        /// </summary>
        /// <returns></returns>
        public override bool Evaluate()
        {
            return on;
        }   /// <summary>
            /// Override the clone method
            /// </summary>
            /// <returns></returns>
        public override Gate Clone()
        {
            Gate g1 = new InputSource(0, 0);
            return g1;
        }
    }
}
