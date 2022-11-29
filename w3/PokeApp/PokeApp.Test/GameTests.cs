using Moq;
using PokeApp.App;
using PokeApp.Data;
using PokeApp.Logic;

namespace PokeApp.Test
{
    public class GameTests
    {
        [Fact]
        public void Game_UpdatePokemonName_UpdateName()
        {
            // Arrange
            Pokemon tmp = new Pokemon("Skyler", 1, 2, 3, 4, 5, 6);

            Mock<IRepository> mockRepo = new();

            mockRepo.Setup(x => x.UpdatePokemonName("Skylerupdate", 1)).Returns("Skylerupdate");

            Game tmpGame = new Game(mockRepo.Object);

            // Act
            bool result = tmpGame.UpdatePokemonName(tmp);

            // Assert
            Assert.Equal(true, result);
            Assert.Equal("Skylerupdate", tmp.Name);
        }
    }
}