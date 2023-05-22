using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.MacronutrientsStrategy
{
    public class WeightLossStrategy : IMacronutrientsStrategy
    {
        public MacronutrientsModel CalculateMacronutrients(double Weight)
        {
            return new MacronutrientsModel()
            {
                Carbohydrates = 3.0 * Weight,
                Proteins = 4.0 * Weight,
                Fat = 3.0 * Weight,
            };
        }
    }
}
