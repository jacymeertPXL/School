```` csharp
string.Concat("Briers - ", "Dox"); --> "Briers – Dox"
string.Compare("aa", "AA"); --> -1 (kleiner) / 0 (gelijk)
string.Compare("aa", "AA", true); --> 0 (gelijk) True: negeert hoofdletters
string.CompareOrdinal("A", "a"); -32 (vergelijkt ASCII-code : 32 kleiner) A=65 en a=97
string.Equals("abcd", "Abcd"); --> false
"abcd".Equals("Abcd"); --> false
string.Equals("A", "a",StringComparison.OrdinalIgnoreCase) (hoofdlet. en kleine letters gelijk)

"Visual CSharp".Substring(2); --> "sual CSharp"
"Visual CSharp".Substring(2,5); --> "sual "
"Visual CSharp".PadLeft(20); --> " Visual CSharp"
"Visual CSharp".PadLeft(20,'*'); --> "*******Visual CSharp"
"Visual CSharp".Contains("Visual") --> true
"Visual CSharp".Contains("Visual C#") --> false
"Visual CSharp".IndexOf("*"); --> -1 (Niet gevonden)
"Visual CSharp".IndexOf("CSh"); --> 7
" Visual CSharp ".Trim(); --> "Visual CSharp"
"Visual CSharp".Remove(4); --> "Visu"
"Visual CSharp".Remove(4,3); --> "VisuCSharp"
"Visual C#".StartsWith("Visual") --> true
"Visual CSharp".Insert(2,"PATRICIA"); --> "ViPATRICIAsual CSharp "
"Visual CSharp".Length; --> 13
"Visual CSharp".Replace ("a","o"); --> Visuol CShorp
"Visual CSharp".ToUpper(); --> VISUAL CSHARP
"Visual CSharp".ToLower(); --> visual csharp
`````

#csharp-essentials 