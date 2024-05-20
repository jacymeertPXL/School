// Bestand opvragen
string pad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string bestand = Path.Combine(pad, "MijnTekstbestand.Txt");

![[Pasted image 20240517163826.png]]

// Toont alle bestandsnamen
string[] bestanden = Directory.GetFiles(TxtMap.Text);
foreach (string file in bestanden)
{
	TxtBestanden.AppendText(file);
	TxtBestanden.AppendText(Environment.NewLine);
}

// Toont alle mappen
string[] mappen = Directory.GetDirectories(TxtMap.Text);
foreach (string dir in mappen)
{
	TxtMappen.AppendText(dir);
	TxtMappen.AppendText(Environment.NewLine);
}