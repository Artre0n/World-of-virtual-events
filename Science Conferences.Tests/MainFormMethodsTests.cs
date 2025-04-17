namespace Science_Conferences.Tests
{
    public class MainFormMethodsTests
    {
        [Fact]
        public void GetStringFromTimeSpan_CorrectTimeResult()
        {
            // Arrange
            MainForm mainForm = new MainForm();


            // Act
            string strTime = mainForm.GetStringFromTimeSpan(new TimeSpan(12, 12, 33));

            // Assert
            Assert.Equal(strTime, "12:12:33");
        }

        [Fact]
        public void GetStringFromTimeSpan_IncorrectTimeResult()
        {
            // Arrange
            MainForm mainForm = new MainForm();


            // Act
            string strTime = mainForm.GetStringFromTimeSpan(new TimeSpan(11, 11, 33));

            // Assert
            Assert.NotEqual(strTime, "12:12:33");
        }
    }
}