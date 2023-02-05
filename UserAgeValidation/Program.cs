// See https://aka.ms/new-console-template for more information

//rakedus küsib sugu (m/f)
//rakendus küsib kasutaja perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmisels:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms [kasutaja perekonnanimi]

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string ehk sõne formaadis
Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
	Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
	Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
	Console.WriteLine($"Welcome, {userLastName}!");
}

