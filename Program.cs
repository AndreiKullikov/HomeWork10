Console.Write("Введите количество элементов массива\t");
int elementsCount = int.Parse(Console.ReadLine()!);
string[] array= new string[elementsCount];

for(int i = 0; i<array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    array[i]= (Console.ReadLine()!);
}
Console.WriteLine("Вывод массива:");


for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine();

Console.WriteLine("Вывод нового массива:");


for (int i = 0; i < array.Length; i++)
{
    if(3 >= array[i].Length)
    {
       Console.Write(array[i]+" "); 
    }
}