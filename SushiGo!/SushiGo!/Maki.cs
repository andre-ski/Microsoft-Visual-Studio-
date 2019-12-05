using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    class Maki :Card
    {
        /// <summary>
        /// Maki card method
        /// </summary>
        /// <param name="pieces">Parse the pieces of Maki</param>
        public Maki(int pieces)
        {
            //type of card is Maki
            _type = "Maki";
            //Default points is whatever amount of pieces there are
            _points = pieces; 
        }
        /// <summary>
        /// Override string method to return card type
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (_type);
        }
    }
}
