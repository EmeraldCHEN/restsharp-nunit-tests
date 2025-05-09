[Test]
public void Create_Post_ShouldReturn_Created()
{
    var client = new RestClient("https://jsonplaceholder.typicode.com");
    var request = new RestRequest("/posts", Method.Post);
    request.AddJsonBody(new { title = "New Post", body = "This is a test post", userId = 1 });

    var response = client.Execute(request);

    Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
}
