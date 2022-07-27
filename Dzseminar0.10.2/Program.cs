// Даны две строки. Определить можно ли из символов первой строки, собрать вторую. Допускается любое количество пробелов. Регистр символов различный в любой последовательности.
// Пример:
// Строка 1. Tom Marvolo Riddle
// Строка 2. I am Lord Voldemort
// Ответ: Да
// Строка 1. Tom Marvolo Riddle
// Строка 2. Lord Voldemort
// Ответ: Нет - остались свободные символы.

using System;
using static System.Console;
Clear();

WriteLine("Введите слово: ");
string Words1 = ReadLine();

WriteLine("Введите слово для сравнения: ");
string Words2 = ReadLine();

if (Words1.Length != Words2.Length) Write("нельзя");


char[] st1 = Words1.ToCharArray();
int n = st1.Length;

char[] st2 = Words2.ToCharArray();
int s = st2.Length;

bool d = Word(st1, st2);
WriteLine(d);

bool Word(char[] st1, char[] st2)
{
    bool result = true;

    Array.Sort(st1);
    Array.Sort(st2);
    // for (int i = 0; i < st1.Length; i++)
    // {
    //     if (st1[i] != st2[i]) result = false;
    //     else result = true;
    // }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < s; j++)
        {
            if (st1[i] != st2[j]) result = false;
            else result = true;
        }
    }
return result;
}
