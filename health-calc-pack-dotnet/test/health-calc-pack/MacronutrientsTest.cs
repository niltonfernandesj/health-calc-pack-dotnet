using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace test.health_calc_pack
{
    public class MacronutrientsTest
    {
        [Theory]
        [InlineData(PhysicalObjectiveEnum.MuscleGain)]
        [InlineData(PhysicalObjectiveEnum.WeigthLoss)]
        [InlineData(PhysicalObjectiveEnum.WeightMaintenance)]
        public void CalculateMacronutrients_WhenDataIsValid_ThenReturnMacronutrients(PhysicalObjectiveEnum PhysicalObjective)
        {
            // Arrange
            IMacronutrients macronutrients = new Macronutrients();
            double Weight = 88.8;
            MacronutrientsModel Expected = new MacronutrientsModel();

            if (PhysicalObjective == PhysicalObjectiveEnum.WeigthLoss)
            {
                Expected.Carbohydrates = 266.4;
                Expected.Proteins = 355.2;
                Expected.Fat = 266.4;
            }
            else if (PhysicalObjective == PhysicalObjectiveEnum.WeightMaintenance)
            {
                Expected.Carbohydrates = 355.2;
                Expected.Proteins = 355.2;
                Expected.Fat = 177.6;
            }
            else if (PhysicalObjective == PhysicalObjectiveEnum.MuscleGain)
            {
                Expected.Carbohydrates = 355.2;
                Expected.Proteins = 177.6;
                Expected.Fat = 88.8;
            }

            // Act
            var result = macronutrients.CalculateMacronutrients(PhysicalObjective, Weight);


            // Asserts
            Assert.Equivalent(Expected, result);
        }
    }
}
