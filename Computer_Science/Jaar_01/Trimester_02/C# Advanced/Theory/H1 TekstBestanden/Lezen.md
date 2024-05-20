// LEZEN
FileStream fsRead = new FileStream("MyTest.Txt", FileMode.Open, FileAccess.Read);

StreamReader sr = new StreamReader(fsRead);

// Bestand tot einde lezen.
Console.Write(sr.ReadToEnd());

// Inlezen van bestand per regel.
while (!sr.EndOfStream)
{
TxtResultaat.AppendText(sr.ReadLine());
}

//Objecten sluiten
sr.Close();
fsRead.Close();