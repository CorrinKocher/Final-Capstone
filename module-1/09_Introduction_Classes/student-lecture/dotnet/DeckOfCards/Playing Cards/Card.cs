using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Playing_Cards
{
    /// <summary>
    /// This represents a playing card in a deck
    /// </summary>
    public class Card
    {/// <summary>
    /// gets or sets the numerical value of the card
    /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the suit the card has (Hearts, diamonds, Spades, Clubs)
        /// </summary>
        public string Suit { get; set; }
        /// <summary>
        /// 
        /// Gets or sets whether or not the card is face up
        /// </summary>
        public bool IsFaceUp { get; private set; }


        /// <summary>
        /// Gets a user-readable message for the card
        /// </summary>
        public string DisplayText
        {
            get
            {
                if(this.IsFaceUp)
                {
                    return this.Value + " of " + this.Suit;
                }
                else
                {
                    return "This card is face down";
                }
            }
        }
        /// <summary>
        /// Flips whether or not the card is face up
        /// </summary>
        public void Flip()
        {
            this.IsFaceUp = !this.IsFaceUp;
        }
    }
}
