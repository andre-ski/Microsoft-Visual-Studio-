using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    class Tempura : Card
    {
        /// <summary>
        /// Tempura card method
        /// </summary>
        public Tempura()
        {
            //type of card is Tempura
            _type = "Tempura";
            //default points is zero
            _points = 0;
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
