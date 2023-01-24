using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Runtime.InteropServices;
using Truphone.API.Controllers;
using Truphone.Application.Interfaces;
using Truphone.Domain;

namespace Truphone.API.Tests
{
    [TestClass]
    public class DeviceControllerTests
    {
        [TestMethod]
        public void AddDevice_WithNameAndBrand_Success()
        {
            //Arrange
            var serviceMock = new Mock<ITruphoneService>();
            var repositoryMock = new Mock<ITruphoneRepository>();
            var loggerMock = new Mock<ILogger<DeviceController>>();
            var expectedValue = new OkObjectResult(true);
            serviceMock.Setup(x => x.AddDevice(It.IsAny<DeviceDto>()))
                       .Returns(true);

            var _controller = new DeviceController(serviceMock.Object, loggerMock.Object);

            //Act
            var res = _controller.AddDevice("Device1", "Brand1");
            var okResult = (OkObjectResult)res.Result;

            //Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(expectedValue.Value, okResult.Value);
        }

        [TestMethod]
        public void DeleteDevice_WithDeviceId_Success()
        {
            //Arrange
            var serviceMock = new Mock<ITruphoneService>();
            var repositoryMock = new Mock<ITruphoneRepository>();
            var loggerMock = new Mock<ILogger<DeviceController>>();
            var expectedValue = new OkObjectResult(true);
            serviceMock.Setup(x => x.DeleteDevice(It.IsAny<int>()))
                       .Returns(true);

            var _controller = new DeviceController(serviceMock.Object, loggerMock.Object);

            //Act
            var res = _controller.DeleteDevice(1);
            var okResult = (OkObjectResult)res.Result;

            //Assert
            Assert.IsNotNull(res.Result);
            Assert.AreEqual(expectedValue.Value, okResult.Value);
        }

        [TestMethod]
        public void DeleteDevice_WithInvalidDeviceId_Fail()
        {
            //Arrange
            var serviceMock = new Mock<ITruphoneService>();
            var repositoryMock = new Mock<ITruphoneRepository>();
            var loggerMock = new Mock<ILogger<DeviceController>>();
            var expectedValue = new OkObjectResult(false);
            serviceMock.Setup(x => x.DeleteDevice(It.IsAny<int>()))
                       .Returns(false);

            var _controller = new DeviceController(serviceMock.Object, loggerMock.Object);

            //Act
            var res = _controller.DeleteDevice(1);
            var okResult = (OkObjectResult)res.Result;

            //Assert
            Assert.IsNotNull(res.Result);
            Assert.AreEqual(expectedValue.Value, okResult.Value);
        }
    }
}