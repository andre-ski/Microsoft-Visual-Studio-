using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    class Nigiri :Card
    {
        /// <summary>
        /// Nigiri card method
        /// </summary>
        /// <param name="Type">Parse the Type of Nigiri it is, ie Egg, Salmon, Squid </param>
        public Nigiri(string Type)
        {
            //type of card is Type + Nigiri
            _type = Type + " Nigiri";
            if (Type == "Egg")
            {
                //if it is a Egg Type then default points is 1
                _points = 1 ;
            }
            if (Type == "Salmon")
            {
                //if it is a Salmon Type then default points is 2
                _points = 2;
            }
            if (Type == "Squid")
            {
                //if it is a Squid Type then default points is 3
                _points = 3;
            }

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
