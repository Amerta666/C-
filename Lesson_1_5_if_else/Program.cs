Console.WriteLine("Введите имя пользователя");
string nameuser = Console.ReadLine();
if (nameuser.ToLower() == "миша") 
{
    Console.WriteLine("Привет пидор!");
}
else
{
    Console.Write("Привет! ");
    Console.Write(nameuser);
}