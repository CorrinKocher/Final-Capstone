using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AuctionApp.Models;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;

namespace AuctionApp.Tests
{
    [TestClass]
    public class AuctionsControllerTests
    {
        protected HttpClient _client;

        [TestInitialize]
        public void Setup()
        {
            var builder = new WebHostBuilder().UseStartup<AuctionApp.Startup>();
            var server = new TestServer(builder);
            _client = server.CreateClient();
        }

        [TestMethod]
        public async Task CreateAuction_ExpectCreated()
        {
            Auction input = new Auction() { Id = null, Title = "Dragon Plush", Description = "Not a real dragon", User = "Bernice", CurrentBid = 219.50 };

            var response = await _client.PostAsync("auctions", BuildJsonContent(input));

            string responseContent = await response.Content.ReadAsStringAsync();
            Auction content = JsonConvert.DeserializeObject<Auction>(responseContent);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.Created);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(responseContent));
            Assert.IsNotNull(content);
        }

        private static StringContent BuildJsonContent(Auction input)
        {
            return new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
        }

        [TestMethod]
        public async Task CreateAuction_ExpectBadRequest()
        {
            Auction blankTitle = new Auction() { Id = null, Title = "", Description = "Not a real dragon", User = "Bernice", CurrentBid = 19.50 };
            var responseTitle = await _client.PostAsync("auctions", BuildJsonContent(blankTitle));
            Assert.IsTrue(responseTitle.StatusCode == System.Net.HttpStatusCode.BadRequest);

            Auction blankDescr = new Auction() { Id = null, Title = "Dragon Plush", Description = "", User = "Bernice", CurrentBid = 19.50 };
            var responseDescr = await _client.PostAsync("auctions", BuildJsonContent(blankDescr));
            Assert.IsTrue(responseDescr.StatusCode == System.Net.HttpStatusCode.BadRequest);

            Auction blankUser = new Auction() { Id = null, Title = "Dragon Plush", Description = "Not a real dragon", User = "", CurrentBid = 19.50 };
            var responseUser = await _client.PostAsync("auctions", BuildJsonContent(blankUser));
            Assert.IsTrue(responseUser.StatusCode == System.Net.HttpStatusCode.BadRequest);

            Auction tooLowPrice = new Auction() { Id = null, Title = "Dragon Plush", Description = "Not a real dragon", User = "Bernice", CurrentBid = 0.0 };
            var responsePrice = await _client.PostAsync("auctions", BuildJsonContent(tooLowPrice));
            Assert.IsTrue(responsePrice.StatusCode == System.Net.HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public async Task UpdateAuction_ExpectOk()
        {
            Auction input = new Auction() { Id = 2, Title = "Dragon Plush", Description = "Not a real dragon", User = "Bernice", CurrentBid = 19.50 };

            var response = await _client.PutAsync("auctions/2", BuildJsonContent(input));

            string responseContent = await response.Content.ReadAsStringAsync();
            Auction content = JsonConvert.DeserializeObject<Auction>(responseContent);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(responseContent));
            Assert.IsNotNull(content);
        }

        [TestMethod]
        public async Task UpdateAuction_ExpectBadRequest()
        {
            Auction input = new Auction() { Id = 2, Title = "", Description = "", User = "", CurrentBid = 0 };

            var response = await _client.PutAsync("auctions/2", BuildJsonContent(input));

            string responseContent = await response.Content.ReadAsStringAsync();
            Auction content = JsonConvert.DeserializeObject<Auction>(responseContent);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public async Task UpdateAuction_ExpectNotFound()
        {
            Auction input = new Auction() { Id = 23, Title = "Dragon Plush", Description = "Not a real dragon", User = "Bernice", CurrentBid = 19.50 };

            var response = await _client.PutAsync("auctions/23", BuildJsonContent(input));

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.NotFound);
        }

        [TestMethod]
        public async Task DeleteAuction_ExpectNoContent()
        {
            var response = await _client.DeleteAsync("auctions/7");

            string responseContent = await response.Content.ReadAsStringAsync();

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.NoContent);
            Assert.IsTrue(string.IsNullOrWhiteSpace(responseContent));
        }

        [TestMethod]
        public async Task DeleteAuction_ExpectNotFound()
        {
            var response = await _client.DeleteAsync("auctions/10");

            string responseContent = await response.Content.ReadAsStringAsync();

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.NotFound);
        }
    }
}
