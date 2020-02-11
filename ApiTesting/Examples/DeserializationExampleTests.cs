using ApiTesting.DataEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting.Examples
{
    [TestClass]
    public class DeserializationExampleTests
    {
        [TestMethod]
        public void RetrieveFirstPost_CheckTitle_ShouldEqualExpectedValue()
        {
            // Arrange
            RestClient client = new RestClient("http://jsonplaceholder.typicode.com/");
            RestRequest request = new RestRequest("/posts/1", Method.GET);

            // Act
            IRestResponse response = client.Execute(request);

            // Assert
            Post post = new JsonDeserializer().Deserialize<Post>(response);

            Assert.AreEqual(
                "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                post.Title
            );
        }

    }
}
