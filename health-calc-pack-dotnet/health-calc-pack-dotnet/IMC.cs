using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weight)
        {
            return  Math.Round(Weight / (Height * Height), 2);
        }

        public string GetIMCCategory(double IMC)
        {
            var Result = string.Empty;

            if (IMC < 18.5)
                Result = "Magreza";
            else if (IMC >= 18.5 && IMC < 25)
                Result = "Normal";
            else if (IMC >= 25 && IMC < 30)
                Result = "Sobrepeso";
            else if (IMC >= 30 && IMC < 40)
                Result = "Obesidade";
            else if (IMC >= 40)
                Result = "Obesidade grave";

            return Result;
        }

        public bool IsValidData(double Height, double Weight)
        {
            return Height < 3.0 && Weight <= 300;
        }
    }
}