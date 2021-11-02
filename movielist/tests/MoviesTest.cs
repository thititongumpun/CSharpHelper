//using imdbx.Controllers;
//using imdbx.Services;
//using Moq;
//using System;
//using Xunit;

//namespace imdbxTests
//{
//    public class MoviesTest
//    {
//        public Mock<IMovieService> mock = new Mock<IMovieService>();

//        [Fact]
//        public async void GetMoviesList()
//        {
//            Guid guid = new Guid("efee5b91-5fb4-471f-bf4a-09013e37fcde");
//            mock.Setup(m => m.GetMoviesList()).Returns();
//            MovieListController movie = new MovieListController(mock.Object);
//            object result = await movie.Index();
//            Assert.Equal("")
//        }

//        [Fact]
//        public async void mockSomething()
//        {

//        }
//    }
//}