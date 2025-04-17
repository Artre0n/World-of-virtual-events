using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Conferences.Tests
{
    public class ConferenceTests
    {
        [Fact]
        public void Test1_CheckProps()
        {
            // Arrange
            var conf = new Conference();


            // Act
            conf.ConferenceId = 123;
            conf.Title = "Физика будущего";
            conf.Description = "Для студентов и учёных";
            conf.Date = new DateTime(2024, 10, 5);
            conf.Time = new TimeSpan(10, 0, 0);
            conf.Category = "Наука";
            conf.Participants = "МГУ";

            // Assert
            if (conf.ConferenceId != 123) throw new Exception("Ошибка ID");
            Assert.Equal("Физика будущего", conf.Title);
            Assert.True(conf.Description.Length > 5);
            Assert.Equal("Наука", conf.Category);
        }

        [Fact]
        public void Test2_ChangeData()
        {
            // Arrange
            var conf = new Conference();

            // Act
            conf.Title = "Химия";
            conf.Title = "Биология 2024";
            conf.Category = "Астрономия";
            conf.Participants = "Студенты";

            // Assert
            Assert.True(conf.Title == "Биология 2024");
            Assert.NotEqual("Химия", conf.Title);
            Assert.NotEqual("астрономия", conf.Category);
            Assert.Equal("Студенты", conf.Participants);
        }
    }
}
