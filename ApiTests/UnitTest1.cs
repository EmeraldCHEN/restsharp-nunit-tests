using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTests
{
    [TestFixture]
    public class ApiTestExample
    {
        private const string BaseUrl = "https://jsonplaceholder.typicode.com";

        [Test]
        public void Get_Posts_ShouldReturn_OK()
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/posts", Method.Get);
            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}

