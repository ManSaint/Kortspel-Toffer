using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class DeckOfCards : IDeckOfCards
    {
        #region cards List related
        protected const int MaxNrOfCards = 52;
        protected List<PlayingCard> cards = new List<PlayingCard>(MaxNrOfCards);

        public PlayingCard this[int idx] => cards[idx]; // Cards by index

        public int Count => cards.Count; // Cards left
        #endregion

        #region ToString() related
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < cards.Count; i++)
            {
                sRet += cards[i].ToString() + "\t";
                if ((i + 1) % 13 == 0)
                    sRet += "\n";
            }
            return sRet;
        }
        #endregion

        #region Shuffle and Sorting
        public void Shuffle() // HITTA ETT BÄTTRE SÄTT, FÖRSTÅR INTE (Har kanske hittat, se nedan)
        {
            var rnd = new Random();
            int nrCards = cards.Count;
            for (int i = 0; i < nrCards; i++)
            {
                int rndIndex = rnd.Next(i, nrCards);
                PlayingCard temp = cards[i];
                cards[i] = cards[rndIndex];
                cards[rndIndex] = temp;
            }
        }
        /*
        public void Shuffle()
        {
            var rnd = new Random();
            int nrCards = cards.Count;

            for (int i = 0; i < 1000; i++)
            {
                int rndIndex = rnd.Next(i, nrCards);

                // Swap using a tuple
                (cards[i], cards[rndIndex]) = (cards[rndIndex], cards[i]);
            }
        }
        */

        public void Sort()
        { }
        #endregion

        #region Creating a fresh Deck
        public void Clear()
        {
            for (int i = cards.Count -1; i >= 0; i--)
            {
                cards.RemoveAt(i);
            }
        }
        public void CreateFreshDeck() // BEHÖVER FÖRSTÅ
        {
            cards = new List<PlayingCard>(MaxNrOfCards);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                    cards.Add(new PlayingCard((PlayingCardValue)i, (PlayingCardColor)(i % 13)));
            }
        }

        #endregion

        #region Dealing
        public PlayingCard RemoveTopCard()
        {
            return null;
        }
        #endregion
    }
}
