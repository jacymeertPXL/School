string pad = "TekstKlasseFile.Txt";

if(!File.Exist(pad)){
	// Creëert een bestand om naar te schrijven (CreateText kan samenwerken met StreamWriter,niet Create)
	{
	sw.WriteLine("Programmeren - Lector: Patricia Briers");
	sw.WriteLine("Cisco - Lector: Toni Mini");
	sw.WriteLine("OS - Lector: Stijn Jacobs");
	sw.WriteLine("Web - Lector: Bram en Pieter");
	}
}

//Rechstreeks in array 
strin[] gegevens = File.ReadAllLines(pad);

//Opent het bestand om te lezen

using (StreamReader sr = File.OpenText(pad))
{
	while (!sr.EndOfStream)
	{
		Console.WriteLine(sr.ReadLine());
	}
}