using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    class Wasabi :Card
    {
        /// <summary>
        /// Wasabi card method
        /// </summary>
        public Wasabi()
        {
            //type of card is Wasabi
            _type = "Wasabi";
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
