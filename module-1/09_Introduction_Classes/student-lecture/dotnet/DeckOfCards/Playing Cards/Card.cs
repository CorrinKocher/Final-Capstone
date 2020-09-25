using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Playing_Cards
{
    /// <summary>
    /// This represents a playing card in a deck
    /// </summary>
    public class Card

     
    {
        public Card(bool isFaceUp) // default constructor looks like this but is empty.
        {
            this.IsFaceUp = isFaceUp; //Console.WriteLine("The card was created");
        }
        
        /// <summary>
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
        //public Card(bool isFaceUp)
        //{
        //    this.IsFaceUp = true; or you can put >>   = isFaceUp;
        //}


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
        public bool Flip()
        {
            this.IsFaceUp = !this.IsFaceUp;
            return this.IsFaceUp;
        }
        public void WeCanPassParemetersToMethods (int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
