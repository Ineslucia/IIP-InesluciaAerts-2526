using System;
using System.Globalization;

class Program
{
  static void Main()
  {
    const int AANTAL_DAGEN =7;
	double[] temperaturen = new double[AANTAL_DAGEN];
	
	//zorgt dat komma als decimalteken werkt
	CultureInfo.CurrentCulture = new CultureInfo("nl-BE");
	
	//Inlezen van de temperaturen
	for (int i = 0; i < AANTAL_DAGEN; i++)
	{
	  Console.Write($"Geef de temperatuur op voor dag {i +1}: ");
	  temperaturen[i] = double.Parse(Console.ReadLine());
	}
	
	//berekenen van hoogste, laagste en gemiddelde
	double hoogste = temperaturen[0];
	double laagste = temperaturen[0];
	double som = 0;
	
	
	for (int i = 0; i < AANTAL_DAGEN; i++)
	{
	   if (temperaturen[i] > hoogste)
	   hoogste = temperaturen[i];
	   
	   if (temperaturen[i] < laagste)
	   laagste = temperaturen[i];
	   
	   som += temperaturen[i];
	}
	
	double gemiddelde = som / AANTAL_DAGEN;
	
	//temperaturen van de week afdrukken
	Console.Write("\nTemperaturen deze week: ");
	foreach (double temp in temperaturen)
	{
	   Console.Write($"{temp:F1}°C ");
	}
	
	//multiline string voor samenvatting
	string samenvatting = $@"
Gemiddelde temperatuur: {gemiddelde:F1}°C
Hoogste temperatuur: {hoogste:F1}°C
Laagste temperatuur: {laagste:F1}°C";
	
	Console.WriteLine(samenvatting);
	}
}