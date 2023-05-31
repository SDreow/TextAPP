// řetězec, který chceme analyzovat
string s = "Mount Everest";
Console.WriteLine(s);
s = s.ToLower();

// inicializace počítadel
int pocetSamohlsek = 0;
int pocetSouhlasek = 0;

// definice typů znaků
string samohlasky = "aeiouyáéěíóúůý";
string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";

// hlavní cyklus
foreach (char c in s)
{
    if (samohlasky.Contains(c))
        pocetSamohlsek++;
    else
    if (souhlasky.Contains(c))
        pocetSouhlasek++;

}
Console.WriteLine("Samohlásek: {0}", pocetSamohlsek);
Console.WriteLine("Souhlásek: {0}", pocetSouhlasek);
Console.WriteLine("Nepísemných znaků: {0}", s.Length - (pocetSamohlsek + pocetSouhlasek));

Console.ReadKey(); 