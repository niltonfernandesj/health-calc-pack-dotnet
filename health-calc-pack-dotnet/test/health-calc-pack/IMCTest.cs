using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;

namespace test.health_calc_pack
{
    public class IMCTest
    {
        [Fact]
        public void CalculateIMC_WhenDataIsValid_ThenReturnIndex()
        {
            // Arrange
            IIMC imc = new IMC();
            double Height = 1.70;
            double Weight = 88.3; 
            double ExpectedIMC = 30.55;

            // Act
            var result = imc.Calc(Height, Weight);


            // Asserts
            Assert.Equal(ExpectedIMC, result);
        }

        [Fact]
        public void ValidateIMCData_WhenDataIsInvalid_ThenReturnFalse()
        {
            // Arrange
            IIMC imc = new IMC();
            double Height = 10.0;
            double Weight = 400.0;

            // Act
            var result = imc.IsValidData(Height, Weight);


            // Asserts
            Assert.False(result);
        }

        [Theory]
        [InlineData(18, "Magreza")]
        [InlineData(19, "Normal")]
        [InlineData(26, "Sobrepeso")]
        [InlineData(35, "Obesidade")]
        [InlineData(40, "Obesidade grave")]

        public void ReturnIMCCategory_WhenIndexIsValid_ThenReturnDescription(double IMCValue, string ExpectedResult)
        {
            // Arrange
            IIMC imc = new IMC();

            // Act
            var result = imc.GetIMCCategory(IMCValue);


            // Asserts
            Assert.Equal(ExpectedResult, result);
        }
    }
}