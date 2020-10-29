using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            this.dao = auctionDao;
        }

        //[HttpGet]
        //public List<Auction> GetAuctions()
        //{
        //    return this.dao.List();
        //}

        [HttpGet("{id}")]
        public Auction GetAuctionByID(int id)
        {
           
            Auction auction = this.dao.Get(id);
            if(auction != null)
            {
                return auction;
            }
            return null;
        }

        [HttpGet]

        public List<Auction> GetAuctions(string title_like = "", double currentBid_lte = 0.00)
        {
            if(!string.IsNullOrEmpty(title_like) && currentBid_lte != 0.00)
            {
                return this.dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }

            if (!string.IsNullOrEmpty(title_like))
            {
                return this.dao.SearchByTitle(title_like);
            }
           
            if( currentBid_lte != 0.00)
            {
                return this.dao.SearchByPrice(currentBid_lte);
            }
            return this.dao.List();

            
        }

        
    }
}
