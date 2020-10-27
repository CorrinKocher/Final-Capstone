using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {             
        private readonly RestClient client;
        private readonly string BASE_URL;
        

        public APIService ()
        {
            this.client = new RestClient();
            this.BASE_URL = "https://te-mockauction-server.azurewebsites.net/students/00162/";
        }

        

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions");
            IRestResponse<List<Auction>> response = this.client.Get<List<Auction>>(request);
            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions/" + auctionId);

            IRestResponse<Auction> response = client.Get<Auction>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions?title_like=" + searchTitle);

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);


            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions?currentBid_lte=" + searchPrice);

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }
    }
}
