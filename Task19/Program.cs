Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int error = 0;
for (int i = 0; i < str.Length / 2 ; i++ )
{
    if (str[i] != str[str.Length - i - 1])
    {
        Console.WriteLine("Не палиндром");
        break;
    }
    else
    error = 1;
}
if (error == 1) Console.WriteLine("Палиандр");