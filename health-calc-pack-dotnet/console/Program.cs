using health_calc_pack_dotnet;

var imc = new IMC();
var result = imc.Calc(1.85, 70.0);
var classification = imc.GetIMCCategory(result);

Console.WriteLine($"Seu IMC é de {result}, classificado como {classification}.");
