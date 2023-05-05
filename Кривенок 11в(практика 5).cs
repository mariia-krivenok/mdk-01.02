/******************************************************************************
Практическое задание 5 05.05.2023
Кривенок
Вариант 11
Из заданного предложения выбрать и напечатать только те символы, которые 
встречаются в нём только 1 раз (являются уникальными), и строго в том порядке, в 
котором они встречаются в тексте.

*******************************************************************************/
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите текст: ");
    string a = Console.ReadLine();
    List<char> uniqueChars = new List<char>();
    foreach (char c in a) {
            if (a.IndexOf(c) == a.LastIndexOf(c)) {
                uniqueChars.Add(c);
            }
        }

        foreach (char c in uniqueChars) {
            Console.Write(c);
        }
  }
}