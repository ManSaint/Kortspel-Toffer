using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class HandOfCards : DeckOfCards, IHandOfCards
    {
        #region Pick and Add related
        public void Add(PlayingCard card)
        {
            cards.Add(card);
        }
        #endregion

        public int Count => cards.Count; // New int?

        #region Highest Card related
        public PlayingCard Highest
        {
            get
            {
                if (cards.Count == 0)
                {
                    return null;
                }

                PlayingCard highestCard = cards[0];
                for (int i = 0;  i < cards.Count; i++)
                {
                    if (cards[i].CompareTo(highestCard) > 0)
                    {
                        highestCard = cards[i];
                    }
                }
                return highestCard; 
            }
         }
        public PlayingCard Lowest
        {
            get
            {
                if (cards.Count == 0)
                {
                    return null;
                }

                PlayingCard lowestCard = cards[0];
                for (int i = 0; i < cards.Count; i++)
                {
                    if (cards[i].CompareTo(lowestCard) < 0) //?
                    {
                        lowestCard = cards[i];
                    }
                }
                return lowestCard;
            }
        }
        #endregion
    }
}
