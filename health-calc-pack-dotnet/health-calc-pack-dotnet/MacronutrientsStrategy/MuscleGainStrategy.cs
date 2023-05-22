﻿using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.MacronutrientsStrategy
{
    public class MuscleGainStrategy : IMacronutrientsStrategy
    {
        public MacronutrientsModel CalculateMacronutrients(double Weight)
        {
            return new MacronutrientsModel()
            {
                Carbohydrates = 4.0 * Weight,
                Proteins = 2.0 * Weight,
                Fat = 1.0 * Weight,
            };
        }
    }
}
