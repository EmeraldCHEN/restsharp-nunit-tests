using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTests
{
    [TestFixture]
    public class ApiTestExample
    {
        private static string BaseUrl;
        private static RestClient Client;

        [OneTimeSetUp]
        public void TestClassInitialize()
        {
            //make sure this has the correct port!
            BaseUrl = "https://jsonplaceholder.typicode.com";
            Client = new RestClient(BaseUrl);
        }

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

