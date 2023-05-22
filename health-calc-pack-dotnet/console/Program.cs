using health_calc_pack_dotnet;
using health_calc_pack_dotnet.MacronutrientsStrategy;
using health_calc_pack_dotnet.Models;

MacronutrientsContext macronutrientsStrategy = new();
macronutrientsStrategy.SetStrategy(new MuscleGainStrategy());
MacronutrientsModel result = macronutrientsStrategy.ExecuteStrategy(84.0);

Console.WriteLine($"Para uma dieta de ganho de massa muscular, consuma: " +
    $"{result.Carbohydrates}g de carboidratos, " +
    $"{result.Proteins}g de proteínas e " +
    $"{result.Fat}g de gordura."
);
