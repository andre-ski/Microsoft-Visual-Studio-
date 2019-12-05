using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo_
{
    //ANDRE OFSOSKI 1314669

    class Hand
    {
        //List for cards in hand
        public List<Card> _handList = new List<Card>();

        /// <summary>
        /// Hand method
        /// </summary>
        public Hand()
        {

        }

        /// <summary>
        /// Add card to hand list method
        /// </summary>
        /// <param name="card">Type of card</param>
        public void AddCard(Card card)
        {
            //Add thsat card to the handlist
            _handList.Add(card);
        }

        /// <summary>
        /// Calculate total method
        /// </summary>
        /// <returns></returns>
        public int Total()
        {
            //set total to zero
            int total = 0;
            //for each card in the handlist
            foreach (Card item in _handList)
            {
                //add that specific cards points to the total
                total += item._points;
            }
            //return the total
            return total;
        }
        /// <summary>
        /// Clear the input of cards in the handlist
        /// </summary>
        public void ClearCards()
        {
            _handList.Clear();
        }

    }
}
