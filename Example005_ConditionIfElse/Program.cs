Console.WriteLine("Введите имя пользователя");
string nameA;
nameA = Console.ReadLine();
if (nameA.ToLower() =="маша") \\ перевод всех букв в нижний регистр
    {
        Console.WriteLine("URA!!! This MASHA!!!");
    }
else
    {
        Console.WriteLine("Hi");
        Console.WriteLine(nameA);
    }