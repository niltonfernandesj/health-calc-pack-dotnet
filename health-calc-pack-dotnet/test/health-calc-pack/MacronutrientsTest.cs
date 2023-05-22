using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.MacronutrientsStrategy;
using health_calc_pack_dotnet.Models;

namespace test.health_calc_pack
{
    public class MacronutrientsTest
    {
        [Theory]
        [InlineData(PhysicalObjectiveEnum.MuscleGain, 88.8, 355.2, 177.6, 88.8)]
        [InlineData(PhysicalObjectiveEnum.WeigthLoss, 88.8, 266.4, 355.2, 266.4)]
        [InlineData(PhysicalObjectiveEnum.WeightMaintenance, 88.8, 355.2, 355.2, 177.6)]
        public void CalculateMacronutrients_WhenDataIsValid_ThenReturnMacronutrients(
            PhysicalObjectiveEnum PhysicalObjective,
            double Weight,
            double Carbohydrates,
            double Proteins,
            double Fat
        )
        {
            // Arrange
            MacronutrientsContext macronutrientsStrategy = new();

            switch (PhysicalObjective)
            {
                case PhysicalObjectiveEnum.MuscleGain:
                    macronutrientsStrategy.SetStrategy(new MuscleGainStrategy());
                    break;
                case PhysicalObjectiveEnum.WeigthLoss:
                    macronutrientsStrategy.SetStrategy(new WeightLossStrategy());
                    break;
                case PhysicalObjectiveEnum.WeightMaintenance:
                    macronutrientsStrategy.SetStrategy(new WeightMaintenenceStrategy());
                    break;
                default:
                    break;
            }
            MacronutrientsModel Expected = new()
            {
                Carbohydrates = Carbohydrates,
                Proteins = Proteins,
                Fat = Fat,
            };

            // Act
            var result = macronutrientsStrategy.ExecuteStrategy(Weight);


            // Asserts
            Assert.Equivalent(Expected, result);
        }
    }
}
