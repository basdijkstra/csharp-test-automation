using ApiTesting.DataEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;

namespace ApiTesting.Exercises
{
    [TestClass]
    public class DeserializationApiTests
    {
        [TestMethod]
        public void GetLocationsForUS90210_CheckCountryAbbreviation_ShouldEqualUS()
        {
            // Exercise 1
            // Write a RestSharp test method that performs an HTTP GET on
            // base URL http://api.zippopotam.us and path us/90210
            // Deserialize the response into a new LocationResponse object
            // Check that the value of the CountryAbbreviation property equals 'US'

        }

        [TestMethod]
        public void GetLocationsForUS90210_CheckNameOfFirstPlace_ShouldEqualBeverlyHills()
        {
            // Exercise 2
            // Write a RestSharp test method that performs an HTTP GET on
            // base URL http://api.zippopotam.us and path us/90210
            // Deserialize the response into a new LocationResponse object
            // Check that the value of the first place in the list of places equals 'Beverly Hills'
            
        }

        [TestMethod]
        public void GetLocationsForUS90210_CheckNumbeOfPlaces_ShouldEqual1()
        {
            // Exercise 3
            // Write a RestSharp test method that performs an HTTP GET on
            // base URL http://api.zippopotam.us and path us/90210
            // Deserialize the response into a new LocationResponse object
            // Check that the list of places contains exactly 1 place

        }
    }
}
