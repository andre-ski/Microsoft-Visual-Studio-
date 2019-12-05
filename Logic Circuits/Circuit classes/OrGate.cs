using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Circuits
{
    class OrGate:Gate
    {

         /// <summary>
        /// Inherit from Gate class
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public OrGate(int x, int y) : base(x, y)
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
            Bitmap orImage;
            Brush brush;
            if (selected)
            {
                brush = selectedBrush;
                orImage = new Bitmap("OrGateRed.PNG");
            }
            else
            {
                brush = normalBrush;
                orImage = new Bitmap("OrGate.PNG");
            }
            foreach (Pin p in pins)
                p.Draw(paper);

            // AND is simple, so we can use a circle plus a rectange.
            // An alternative would be to use a bitmap.
            paper.DrawImage(orImage, left, top, WIDTH, HEIGHT);
           
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
            pins[1].X = x - GAP;
            pins[1].Y = y + HEIGHT - GAP;
            pins[2].X = x + WIDTH + GAP;
            pins[2].Y = y + HEIGHT / 2;
        }/// <summary>
         /// Override the bool evaluate method
         /// </summary>
         /// <returns></returns>
        public override bool Evaluate()
        { if (pins[0].InputWire.FromPin.Owner.Evaluate() == true)
            {
                on = true;
            }
        else if (pins[1].InputWire.FromPin.Owner.Evaluate()==true)
            {
                on = true;
            }
            else
            {
                on = false;
            }
            return on;
        }
        /// <summary>
        /// Override the clone method
        /// </summary>
        /// <returns></returns>
        public override Gate Clone()
        {
            Gate g1 = new OrGate(0, 0);
            return g1;
        }
    }
}

