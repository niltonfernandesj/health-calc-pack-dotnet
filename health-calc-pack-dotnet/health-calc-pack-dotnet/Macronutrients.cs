using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet
{
    public class Macronutrients : IMacronutrients
    {

        public MacronutrientsModel CalculateMacronutrients(PhysicalObjectiveEnum PhysicalObjective, double Weight)
        {
            if (PhysicalObjective == PhysicalObjectiveEnum.WeigthLoss)
            {
                return new MacronutrientsModel()
                {
                    Carbohydrates = 3.0 * Weight,
                    Proteins = 4.0 * Weight,
                    Fat = 3.0 * Weight,
                };
            }
            else if (PhysicalObjective == PhysicalObjectiveEnum.WeightMaintenance)
            {
                return new MacronutrientsModel()
                {
                    Carbohydrates = 4.0 * Weight,
                    Proteins = 4.0 * Weight,
                    Fat = 2.0 * Weight,
                };
            }
            else if (PhysicalObjective == PhysicalObjectiveEnum.MuscleGain)
            {
                return new MacronutrientsModel()
                {
                    Carbohydrates = 4.0 * Weight,
                    Proteins = 2.0 * Weight,
                    Fat = 1.0 * Weight,
                };
            }
            else
            {
                throw new Exception("Objetivo físico inexistente.");
            }
        }
    }
}
