Console.WriteLine("Введите массив строк:");
string? s = Console.ReadLine();
string[] words = s.Split(' ');
string[] otvet = new string[words.Length];
int sum = 0;
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length <= 3)
    {
        otvet[sum] = words[i];
        sum++;
    }
}
Console.WriteLine("Результат: ");
Console.Write("[");
for (int i = 0; i < words.Length-1; i++)
{
    Console.Write($"\"{words[i]}\", ");
}
Console.Write($"\"{words[words.Length-1]}\"] ->");

Console.Write(" [");
for (int i = 0; i < sum - 1; i++)
{
    Console.Write($"\"{otvet[i]}\", ");
}
Console.Write($"\"{otvet[sum - 1]}\"]");

