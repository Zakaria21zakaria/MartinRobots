namespace MartinRobots.tests
{
    public class RobotTests 
    {
        [Fact]
        public void Robot_Should_StayWithinGrid_WhenMovingSafely()
        {
            var scents = new HashSet<string>();
            var robot = new Robot(1, 1, Direction.E, 5, 3, scents);
            robot.ExecuteInstructions("RFRFRFRF");
            Assert.Equal("1 1 E", robot.ToString());
        }

        [Fact]
        public void Robot_ShouldBeLost_IfMovesOffGrid()
        {
            var scents = new HashSet<string>();
            var robot = new Robot(3, 2, Direction.N, 5, 3, scents);
            robot.ExecuteInstructions("FRRFLLFFRRFLL");
            Assert.Equal("3 3 N LOST", robot.ToString());
            Assert.Contains("3:3:N", scents);
        }

        [Fact]
        public void Robot_ShouldIgnoreMove_IfScentExists()
        {
            var scents = new HashSet<string> { "3:3:N" };
            var robot = new Robot(3, 2, Direction.N, 5, 3, scents);
            robot.ExecuteInstructions("FRRFLLFFRRFLL");
            Assert.Equal("3 2 N", robot.ToString()); // Not lost because of existing scent
        }

        [Fact]
        public void Robot_ShouldTurnCorrectly()
        {
            var robot = new Robot(0, 0, Direction.N, 5, 5, new HashSet<string>());
            robot.ExecuteInstructions("RRR");
            Assert.Equal("0 0 W", robot.ToString());

            var robot2 = new Robot(0, 0, Direction.N, 5, 5, new HashSet<string>());
            robot2.ExecuteInstructions("LLL");
            Assert.Equal("0 0 E", robot2.ToString());
        }
    }
}
