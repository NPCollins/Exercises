using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherWebsite.Models;
using WeatherWebsite.DALs;
using WeatherWebsite.Controllers;

namespace WeatherWebsite.Tests.Models
{
    [TestClass]
    public class WeatherModelTests
    {
        [TestMethod]
        public void Weather_ReturnsCorrectView()
        {
            //Arrange
            WeatherController controller = new WeatherController();

            //Act
            ViewResult result = controller.Weather("YNP") as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}

