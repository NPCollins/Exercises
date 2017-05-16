using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherWebsite;
using WeatherWebsite.Controllers;

namespace WeatherWebsite.Tests
{
    [TestClass]
    public class SurveyControllerTests
    {
        [TestMethod]
        public void Survey()
        {
            // Arrange
            SurveyController controller = new SurveyController();

            // Act
            ViewResult result = controller.Survey() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void UpdateSurveyTable()
        {
            // Arrange
            SurveyController controller = new SurveyController();

            // Act
            ViewResult result = controller.UpdateSurveyTable() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Ranking()
        {
            // Arrange
            SurveyController controller = new SurveyController();

            // Act
            ViewResult result = controller.Ranking() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}