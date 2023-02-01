// Pierwsza wersja programu, przy założeniu że zmienna "płeć" może przyjąć tylko dwie wartości.

var name = "Ewa";
bool sexFemale = true;
int age = 33;

//var sex = "female";



if (!sexFemale)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
}

if (sexFemale)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta w wieku conajmniej 30 lat");
    }
}

// Druga wersja programu w przypadku zwykłej zmiennej "var sex =famel/male".

//if (sex == "female")
{
    //  if (name == "Ewa" && age == 33)
    {
        //    Console.WriteLine("Ewa, lat 33");
    }
    //else if (age < 30)
    {
        //  Console.WriteLine("Kobieta poniżej 30 lat");
    }
    //else if (age >= 30)
    {
        //  Console.WriteLine("Kobieta w wieku conajmniej 30 lat");
    }
}

//if (sex == "male")
{
    //  if (age < 18)
    {
        //    Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    //else
    {
        //  Console.WriteLine("Pełnoletni Mężczyzna");
    }
}