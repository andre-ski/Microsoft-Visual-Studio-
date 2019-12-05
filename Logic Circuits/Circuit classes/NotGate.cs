using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Circuits
{
    class NotGate : Gate
    {
        /// <summary>
        /// Inherit from Gate class
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public NotGate(int x, int y) : base(x, y)
        {
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
            Bitmap notImage;
            Brush brush;
            if (selected)
            {
                brush = selectedBrush;
                notImage = new Bitmap("NotGateRed.PNG");
            }
            else
            {
                brush = normalBrush;
                notImage = new Bitmap("NotGate.PNG");
                
            }
            foreach (Pin p in pins)
                p.Draw(paper);

          

            // AND is simple, so we can use a circle plus a rectange.
            // An alternative would be to use a bitmap.
            paper.DrawImage(notImage, left, top, WIDTH, HEIGHT);
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
            pins[0].Y = y + HEIGHT / 2;

            pins[1].X = x + WIDTH + GAP;
            pins[1].Y = y + HEIGHT / 2;
        }/// <summary>
         /// Override the bool evaluate method
         /// </summary>
         /// <returns></returns>
        public override bool Evaluate()
        {
            if(pins[0].InputWire.FromPin.Owner.Evaluate()==true)
            {
                on = false;
            }
            else if(pins[0].InputWire.FromPin.Owner.Evaluate()==false)
            {
                on = true;
            }
            return on;
        }   /// <summary>
            /// Override the clone method
            /// </summary>
            /// <returns></returns>
        public override Gate Clone()
        {
            Gate g1 = new NotGate(0, 0);
            return g1;
        }
    }
}
