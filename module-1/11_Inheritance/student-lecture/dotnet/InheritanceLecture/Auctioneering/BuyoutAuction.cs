using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This is an auction that can suddenly end when a BuyoutAmount is reached
    /// </summary>
    public class BuyoutAuction : Auction
    {
        public int BuyoutAmount { get; set; } = 100000;

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isHighBid = base.PlaceBid(offeredBid);
            //if the amount  >= buyout, end the auction
            if(offeredBid.BidAmount >= this.BuyoutAmount)
            {
                this.EndAuction();
                
            }
            return isHighBid;

        }

    }
}
