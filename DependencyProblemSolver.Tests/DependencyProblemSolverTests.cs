namespace DependencyProblemSolver.Tests
{
    public class DependencyProblemSolverTests
    {

        string expectedOutput = "left sock,right sock,t-shirt\r\ndress shirt\r\npants,tie\r\nbelt\r\nsuit jacket\r\nleft shoe,right shoe,sun glasses\r\novercoat\r\n";

        [Fact]
        public void SolveDependecy_Should_Return_Desired_Result()
        {
            //Arrange
            var input = GetTestSampleInput();

            //Act
            var output = DependencyProblemSolver.ChangeOutputToString(DependencyProblemSolver.SolveDependecy(input));

            //Assert
            Assert.Equal(expectedOutput, output);
        }

        static string[,] GetTestSampleInput()
        {
            return new string[,]
            {
               //dependency    //item
               {"t-shirt",     "dress shirt"},
               {"dress shirt", "pants"},
               {"dress shirt", "suit jacket"},
               {"tie",         "suit jacket"},
               {"pants",       "suit jacket"},
               {"belt",        "suit jacket"},
               {"suit jacket", "overcoat"},
               {"dress shirt", "tie"},
               {"suit jacket", "sun glasses"},
               {"sun glasses", "overcoat"},
               {"left sock",   "pants"},
               {"pants",       "belt"},
               {"suit jacket", "left shoe"},
               {"suit jacket", "right shoe"},
               {"left shoe",   "overcoat"},
               {"right sock",  "pants"},
               {"right shoe",  "overcoat"},
               {"t-shirt",     "suit jacket"}
            };

        }
    }
}