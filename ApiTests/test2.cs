using NUnit.Framework;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using TodoApi.Models;


namespace TodoApiTests
{
    [TestFixture]
    public class TodoIntegrationTests
    {
        private static string _baseUrl;

        [OneTimeSetUp]
        public void TestClassInitialize()
        {
            //make sure this has the correct port!
            _baseUrl = "https://localhost:44350/api/Todo/";
        }

        [Test]
        public void VerifyGetReturns200Ok()
        {
            //Arrange
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.IsTrue(response.IsSuccessful, "Get method did not return a success status code; it returned " + response.StatusCode);
        }

        [Test]
        public void VerifyGetTodoItem1ReturnsCorrectName()
        {
            //Arrange
            var expectedName = "Walk the dog"; //we know this is what it should be from the Controller constructor
            var client = new RestClient(_baseUrl);
            var request = new RestRequest("1", Method.GET); //so our URL looks like https://localhost:44350/api/Todo/1

            //Act
            IRestResponse<TodoItem> actualTodo = client.Execute<TodoItem>(request);

            //Assert
            Assert.AreEqual(expectedName, actualTodo.Data.Name, "Expected and actual names are different. Expected " + expectedName + " but was " + actualTodo.Data.Name);
        }

        [Test]
        public void VerifyPostingTodoItemPostsTheItem()
        {
            //Arrange
            TodoItem expItem = new TodoItem
            {
                Name = "mow the lawn",
                DateDue = new DateTime(2019, 12, 31),
                IsComplete = false
            };
            var client = new RestClient(_baseUrl);
            var postRequest = new RestRequest(Method.POST);
            postRequest.RequestFormat = DataFormat.Json;
            postRequest.AddJsonBody(expItem);

            //Act
            //first we need to do the POST action, and get the new object's ID
            IRestResponse<TodoItem> postTodo = client.Execute<TodoItem>(postRequest);
            var newItemId = postTodo.Data.Id; //we need the ID to do the GET request of this item

            //now we need to do the GET action, using the new object's ID
            var getRequest = new RestRequest(newItemId.ToString(), Method.GET);
            IRestResponse<TodoItem> getTodo = client.Execute<TodoItem>(getRequest);

            //Assert
            Assert.AreEqual(expItem.Name, getTodo.Data.Name, "Item Names are not the same, expected " + expItem.Name + " but got " + getTodo.Data.Name);
            Assert.AreEqual(expItem.DateDue, getTodo.Data.DateDue, "Item DateDue are not the same, expected " + expItem.DateDue + " but got " + getTodo.Data.DateDue);
            Assert.AreEqual(expItem.IsComplete, getTodo.Data.IsComplete, "Item IsComplete are not the same, expected " + expItem.IsComplete + " but got " + getTodo.Data.IsComplete);
        }
    }   
}