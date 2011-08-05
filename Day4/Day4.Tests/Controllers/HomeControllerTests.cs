using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day4.Web.Controllers;
using Moq;
using Day4.Services.Repositories;
using Day4.DomainModel;
using System.Web.Mvc;
using Day4.Web.Views.Home;

namespace Day4.Tests.Controllers {
    [TestClass]
    public class HomeControllerTests {

        [TestMethod]
        public void TestIndex() {
            // Arrange
            var movies = new List<Movie> {
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="Star Wars II", Director="Lucas"},
                new Movie {Title="Star Wars III", Director="Lucas"}
            };
            
            
            
            var mockMovieRepository = new Mock<IMovieRepository>();
            
            
            
            mockMovieRepository.Setup(r => r.ListAllMovies()).Returns(movies);
            var controller = new HomeController(mockMovieRepository.Object);

            var vm = new List<IndexViewModel>();
            movies.ToList().ForEach(m => vm.Add(new IndexViewModel {
                Id = m.Id,
                Title = m.Title,
                Director = m.Director
            }));




            // Act
            var result = (ViewResult)controller.Index();
            var model = (List<IndexViewModel>)result.Model;

            // Assert
            Assert.AreEqual(vm[0].Title, model[0].Title);


      
        }
    }
}
