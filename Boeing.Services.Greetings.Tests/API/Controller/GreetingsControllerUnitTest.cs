using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;
using Boeing.Services.Greetings.Controllers;
using Boeing.Services.Greetings.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boeing.Services.Greetings.Tests.Controller
{
    [TestClass]
    public class GreetingsControllerUnitTest
    {

        private GreetingsController greetingContoller = null;
        [TestInitialize]
        public void Init()
        {
            greetingContoller = new GreetingsController();
        }

        [TestMethod]
        [Owner("Hemant Lanjewar")]
        public void Assert_GetHelloWord()
        {
            var _expectedResult = "Hello World!";
            var result = greetingContoller.GetHelloWorld() as NegotiatedContentResult<string>;
            Assert.AreEqual(result.Content.ToString(), _expectedResult);
            Assert.AreEqual(result.StatusCode, System.Net.HttpStatusCode.OK);
            
        }

        [TestMethod]
        [Owner("Hemant Lanjewar")]
        public void Assert_PostHelloWordSucess()
        {
            var userDetail = new UserDetailDto() { PersonName = "Greetings" };
            var _expectedResult = "Hello Greetings World!";
            var result = greetingContoller.Post(userDetail) as NegotiatedContentResult<string>;
            Assert.AreEqual(result.Content.ToString(), _expectedResult);
            Assert.AreEqual(result.StatusCode, System.Net.HttpStatusCode.Accepted);
        }

        [TestMethod]
        [Owner("Hemant Lanjewar")]
        public void Assert_PostHelloWordInvalidInput()
        {
            UserDetailDto userDetail = null;
            var result = greetingContoller.Post(userDetail) as NegotiatedContentResult<ModelStateDictionary>;
            Assert.AreEqual(result.StatusCode, System.Net.HttpStatusCode.BadRequest);
        }
    }
}
