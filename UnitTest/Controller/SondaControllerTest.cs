using Desafio.Controllers;
using Desafio.Model;
using Desafio.Service;
using Desafio.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace UnitTest.Controller
{
    public class SondaControllerTest
    {
        [Fact]
        public void MoveSonda_Null()
        {
            // Arrange
            var controller = new SondaController(new MoveSondaService());
            var request = new MoveSondaRequest();

            // Act
            var response = controller.Post(request);

            // Assert
            Assert.IsType<OkObjectResult>(response);
            var result = response as OkObjectResult;
            Assert.Equal(result.StatusCode, (int)HttpStatusCode.OK);
            Assert.Null(result.Value);
        }

        [Fact]
        public void MoveSonda_Valid()
        {
            // Arrange
            var controller = new SondaController(new MoveSondaService());
            var request = new MoveSondaRequest()
            {
                Sondas = new List<Sonda>() { new Sonda() },
                Moves = new List<string>() { "RLM" },
                Limit = new Position(1, 1)
            };

            // Act
            var response = controller.Post(request);

            // Assert
            Assert.IsType<OkObjectResult>(response);
            var result = response as OkObjectResult;
            Assert.Equal(result.StatusCode, (int)HttpStatusCode.OK);
            Assert.NotNull(result.Value);
            var value = result.Value as MoveSondaResponse;
            Assert.Equal("1 0 N", value.Positions[0]);
        }

        [Fact]
        public void MoveSonda_Invalid()
        {
            // Arrange
            var controller = new SondaController(new MoveSondaService());
            var request = new MoveSondaRequest()
            {
                Sondas = new List<Sonda>() { new Sonda() },
                Moves = new List<string>() { "RLMM" },
                Limit = new Position(1, 1)
            };

            // Act
            var response = controller.Post(request);

            // Assert
            Assert.IsType<OkObjectResult>(response);
            var result = response as OkObjectResult;
            Assert.Equal(result.StatusCode, (int)HttpStatusCode.OK);
            Assert.NotNull(result.Value);
            var value = result.Value as MoveSondaResponse;
            Assert.Equal("Invalid", value.Positions[0]);
        }
    }
}
