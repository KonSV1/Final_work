/*
Итоговая проверочная работа
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3-м  символам
Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма.
При решении не рекомендуется использование коллекций, лучше обойтись исключительно массивами
*/

Console.Clear();
string[] arrey = { "Визитеры", "Мох", "Труд", "Май", "Ку", "Октябрь", "Март", "1984 Д.Оруэлл", "Мы Е.Замятин", "Дом", "36" };
int count = 0;
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i].Length < 4) count++;
}
string[] result = new string[count];
int j = 0;
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i].Length < 4)
    {
        result[j] = arrey[i];
        j++;
    }
}
Console.WriteLine(String.Join(", ", arrey));
Console.WriteLine(String.Join(", ", result));