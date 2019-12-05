using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    /// <summary>
    /// Abstract class so it can be inherited from
    /// </summary>
    abstract class Card
    {
        //string name for type of card
        public string _type;
        //integer value of points for that card
        public int _points;

        /// <summary>
        /// ToString method to display the card type and its points
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
    } 
}
