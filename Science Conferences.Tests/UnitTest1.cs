using Microsoft.EntityFrameworkCore;
using Moq;
using ScienceConferences.Data;
using System.Collections.Generic;


namespace Science_Conferences.Tests
{
    public class ConferencesRepositoryTests
    {
        private readonly Mock<DbSet<Conference>> _mockSet;
        private readonly Mock<AppDbContext> _mockContext;
        private readonly ConferencesRepository _repository;

        public ConferencesRepositoryTests()
        {
            _mockSet = new Mock<DbSet<Conference>>();

            _mockContext = new Mock<AppDbContext>();
            _mockContext
                .Setup(x => x.Conferences)
                .Returns(_mockSet.Object);

            _repository = new ConferencesRepository(_mockContext.Object);
        }

        [Fact]
        public void AddConference_ShouldAddToContextAndSaveChanges()
        {
            // Arrange
            var conference = new Conference
            {
                Title = "Test Conference",
                Date = DateTime.Today,
                Time = TimeSpan.FromHours(10)
            };

            // Act
            _repository.AddConference(conference);

            // Assert
            _mockSet.Verify(m => m.Add(conference), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void UpdateConference_ShouldUpdateInContextAndSaveChanges()
        {
            // Arrange
            var conference = new Conference
            {
                ConferenceId = 1,
                Title = "Updated Conference"
            };

            // Act
            _repository.UpdateConference(conference);

            // Assert
            _mockSet.Verify(m => m.Update(conference), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void DeleteConference_ShouldRemoveFromContextAndSaveChanges()
        {
            // Arrange
            var conference = new Conference
            {
                ConferenceId = 1,
                Title = "To Delete"
            };

            // Act
            _repository.DeleteConference(conference);

            // Assert
            _mockSet.Verify(m => m.Remove(conference), Times.Once());
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void GetAllConferences_ShouldReturnAllConferences()
        {
            // Arrange
            var data = new List<Conference>
            {
                new Conference
                {
                    ConferenceId = 1,
                    Title = "AI Conference",
                    Date = new DateTime(2024, 6, 15),
                    Time = TimeSpan.FromHours(9),
                    Category = "Artificial Intelligence"
                },
                new Conference
                {
                    ConferenceId = 2,
                    Title = "Quantum Computing Summit",
                    Date = new DateTime(2024, 7, 20),
                    Time = TimeSpan.FromHours(14),
                    Category = "Quantum Physics"
                }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Conference>>();
            mockSet.As<IQueryable<Conference>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Conference>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Conference>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Conference>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            _mockContext.Setup(m => m.Conferences).Returns(mockSet.Object);

            // Act
            var result = _repository.GetAllConferences();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("AI Conference", result[0].Title);
            Assert.Equal("Quantum Computing Summit", result[1].Title);
            Assert.Equal("Artificial Intelligence", result[0].Category);
            Assert.Equal(new DateTime(2024, 7, 20), result[1].Date);
        }
    }
}