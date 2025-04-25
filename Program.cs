
Console.Clear();

Console.Write("coloque sua senha: ");
string senhaDigitda;
senhaDigitda = Console.ReadLine()!;
string senhacorreta;
string x;
Console.Clear();
Console.Write("digite sua senha novamente para entrar: ");
x = Console.ReadLine()!;

senhacorreta = x;

if(senhaDigitda == senhacorreta)
{
    Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Olá usuario, entrada bem sucedida");


}

else

{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Senha Incorreta.");



}
Console.ResetColor();

