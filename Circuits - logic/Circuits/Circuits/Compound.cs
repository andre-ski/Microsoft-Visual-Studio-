using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Circuits
{
   public class Compound:Gate
    {
        //Gate list
        List<Gate> compounds = new List<Gate>();

        /// <summary>
        /// Inherit gate class
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public Compound(int x, int y):base(x, y)
        {
            
         }
        /// <summary>
        /// Adds gate to compund list
        /// </summary>
        /// <param name="gate"></param>
        public void AddGate(Gate gate)
        {
            compounds.Add(gate);
        }
        /// <summary>
        /// Override the abstract MoveTo method to move the compound gate
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public override void MoveTo(int x, int y)
        {
            //try
            try
            {
                left = x;
                top = y;
                int setleft = 2500;
                int settop = 2500;
                foreach (Gate g in compounds)
                {
                    if (setleft > g.Left)
                    {
                        setleft = g.Left;
                    }
                    if (settop > g.Top)
                    {
                        settop = g.Top;
                    }
                }
                foreach (Gate g in compounds)
                {
                    g.MoveTo(x + (g.Left - setleft), y + (g.Top - settop));
                }

            }
            //catch if error
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            }
        /// <summary>
        /// Override the draw method
        /// </summary>
        /// <param name="paper"></param>
        public override void Draw(Graphics paper)
        {
            foreach(Gate g in compounds)
            {
                g.Draw(paper);
            }

        }
        /// <summary>
        /// Call upon evaluate method 
        /// </summary>
        /// <returns></returns>
        public override bool Evaluate()
        {
            return on;
        }
        /// <summary>
        /// Call upon clone method
        /// </summary>
        /// <returns></returns>
        public override Gate Clone()
        {
            return new Compound(0, 0);
        }
        /// <summary>
        /// Is mouse on 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public override bool IsMouseOn(int x, int y)
        {
            bool holder=false;
            int setleft = 100;
            int settop = 100;
            foreach (Gate g in compounds)
            {
                if(g.Left <= x && x < g.Left + setleft + HEIGHT  && g.Top <= y && y<g.Top + settop +WIDTH)
                {
                   holder=true;
                }
                //else /*if (!(g.Left <= x && x < g.Left + setleft + HEIGHT && g.Top <= y && y < g.Top + settop + WIDTH))*/
                //{
                //    holder = false;
                //}


            }
            return holder;
        }
        public override bool Selected
        {
            get
            {
                return base.Selected;
            }

            set
            {
                base.Selected = value;
                foreach(Gate g in compounds)
                {
                    g.Selected = value;
                }
            }
        }

    }
    }


