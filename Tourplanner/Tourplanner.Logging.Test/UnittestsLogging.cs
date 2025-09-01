namespace Tourplanner.Logging.Test
{
    public class Tests
    {
        private const string FILE_NAME = "./tourplanner.log";
        [Test]
        public void TestLogfileExists()
        {
            FileAssert.Exists(FILE_NAME);
        }
    }
}