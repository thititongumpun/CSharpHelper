using imdbx;
using imdbx.Controllers;
using imdbx.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace imdbxTests
{
  public class MoviesTest
  {
    [Fact]
    public void mockSomething()
    {
      var mock = new Movies()
      {
        Id = Guid.NewGuid(),
        Name = "John Wick",
        Rating = 8.5,
        MovieType = MovieType.Action
      };

      var mockService = new Mock<IMovieService>();
      mockService.Setup(repo => repo.AddMovie(It.IsAny<Movies>()));
      var controller = new MovieListController(mockService.Object);

      var actionResult = controller.AddMovie(mock);

      var result = actionResult.Result;
      Assert.IsType<OkObjectResult>(result);
    }
  }
}