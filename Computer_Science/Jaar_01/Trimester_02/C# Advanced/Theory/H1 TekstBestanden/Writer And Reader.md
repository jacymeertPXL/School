Using System.IO; // Gebruik van maken 

// Inlezen van een bstand 
StreamWriter sw = new StreamWriter("TestBestand.Txt");  

sw.Writeline("Volgorde van getallen: ");

for (int i = 0; i < 10; i++) {0 1 2 3 4 5 6 7 8 9
sw.Write(i + " ");
}

sw.WriteLine(); // lege regel wegschrijven

sw.Close(); // einde van schrijven naar bestand

// Lezen van bestand

StreamReader sr = new StreamReader("TestBestand.Txt");

// Inlezen van bestand per record.
while (! sr.EndOfStream)
{
Console.WriteLine(sr.ReadLine());
}

// Volledig bestand inlezen.
Console.WriteLine(sr.ReadToEnd());

// Inlezen van bestand per record in List
List<string> namenLijst = new List<string>();

while (!sr.EndOfStream)
{
namenLijst.Add(sr.ReadLine());
Console.WriteLine(namenLijst[j]);
j++;
}

// Het hele bestand staat nu in namenLijst.
// Sluiten van bestand.
sr.Close();

// SCHRIJVEN
FileStream fs = new FileStream("MyTest.Txt", FileMode.Append, 
FileAccess.Write);

StreamWriter sw = new StreamWriter(fs);

sw.WriteLine(" Volgorde van getallen:");

for (int i = 0; i < 10; i++) {
sw.Write(i + " ");
}

sw.WriteLine(); // Lege regel toevoegen.

// Sluiten van bestanden.
sw.Close();
fs.Close();