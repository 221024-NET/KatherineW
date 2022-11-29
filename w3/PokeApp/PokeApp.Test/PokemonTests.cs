using PokeApp.Logic;

namespace PokeApp.Test
{
    public class PokemonTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Pokemon test = new Pokemon("test", 1, 1, 1, 1, 1, 1);

            // Act
            string returnValue = test.Speak();

            // Assert
            Assert.Equal("test", returnValue);
        }




    }
}