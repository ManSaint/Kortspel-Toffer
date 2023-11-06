using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
	public class PlayingCard : IComparable<PlayingCard>, IPlayingCard
	{
        public PlayingCard(PlayingCardValue _pcValue, PlayingCardColor _pcColor) //WHUT
        {
            Value = _pcValue; // Nytt
            Color = _pcColor;
        }

        public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		#region IComparable Implementation
		//Need only to compare value in the project
		public int CompareTo(PlayingCard card1)
        {
			return 0;
        }
        #endregion

        #region ToString() related
        string ShortDescription => Color switch //Use switch statment or switch expression, https://en.wikipedia.org/wiki/Playing_cards_in_Unicode
        {
            PlayingCardColor.Spades => '\u2664' + Value.ToString(),
            PlayingCardColor.Hearts => '\u2661' + Value.ToString(),
            PlayingCardColor.Diamonds => '\u2662' + Value.ToString(),
            PlayingCardColor.Clubs => '\u2667' + Value.ToString(),
            _ => throw new ArgumentOutOfRangeException(nameof(Color), $"Invalid card color: {Color}")
        };

        public override string ToString() => $"{ShortDescription}";
        #endregion
    }
}
