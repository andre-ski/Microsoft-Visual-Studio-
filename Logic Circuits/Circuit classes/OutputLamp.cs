using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Circuits
{
    class OutputLamp:Gate
    {
        /// <summary>
        /// Inherit from Gate class
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public OutputLamp(int x, int y) : base(x, y)
        {
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, false, 20));
            MoveTo(x, y); // move the gate and position the pins
        }
        /// <summary>
        /// Override draw method
        /// </summary>
        /// <param name="paper">Graphics paper</param>
        public override void Draw(Graphics paper)
        {       
            Brush brush;
            Brush onbrush = Brushes.Gold;
              
                if (this.Evaluate())
                {
                    brush = onbrush;
                }
                else
                {
                    brush = normalBrush;
                }
            

            foreach (Pin p in pins)
                p.Draw(paper);

            // AND is simple, so we can use a circle plus a rectange.
            // An alternative would be to use a bitmap.
            paper.FillEllipse(brush, left, top, WIDTH, HEIGHT / 2);

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
            pins[0].X = x - GAP;
            pins[0].Y = y + GAP;
        }
        /// <summary>
        /// Override the bool evaluate method
        /// </summary>
        /// <returns></returns>
        public override bool Evaluate()
        {
            if (pins[0].InputWire == null)
            {
                on = false;
            }
            else if (pins[0].InputWire.FromPin.Owner.Evaluate() == true)
            {
                on = true;
            }
            else
            {
                on = false;
            }
            return on;
        }   /// <summary>
            /// Override the clone method
            /// </summary>
            /// <returns></returns>
        public override Gate Clone()
        {
            Gate g1 = new OutputLamp(0, 0);
            return g1;
        }
    }
}
