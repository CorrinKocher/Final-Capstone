using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeographyTest
{
    [TestClass]
    public class CitySqlDAOTest
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";


        [TestMethod]
        public void AddCityTest()
        {
            //Arrange

            int countBefore = 0;
            int countAfter = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction;
                conn.Open();
                transaction = conn.BeginTransaction();

                conn.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT count(*) FROM city;", conn);

                countBefore = (int)command.ExecuteScalar();
            }
            

            CitySqlDAO dao = new CitySqlDAO(connectionString);
            City city = new City();
            city.Name = "Johntown";
            city.CountryCode = "GBR";
            city.Population = 4;
            city.District = "England";
            

            //Act

            dao.AddCity(city);

                          
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT count(*) FROM city;", conn, transaction);

                countAfter = (int)command.ExecuteScalar();
            }
            //Assert

            Assert.AreEqual(countBefore + 1, countAfter);

            transaction.rollback;
        }
    }//AddCity(City city)
}

