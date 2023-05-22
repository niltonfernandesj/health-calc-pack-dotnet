using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet
{
    public class MacronutrientsContext
    {
        private IMacronutrientsStrategy? strategy;

         public void SetStrategy(IMacronutrientsStrategy strategy)
        {
            this.strategy = strategy;
        }

        public MacronutrientsModel ExecuteStrategy(double Weight)
        {
            return strategy!.CalculateMacronutrients(Weight);
        }
    }
}
