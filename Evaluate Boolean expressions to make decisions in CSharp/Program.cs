﻿// See https://aka.ms/new-console-template for more information
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // output: True
Console.WriteLine(pangram.Contains("cow")); // output: False

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false); // output: False
Console.WriteLine(!pangram.Contains("fox")); // output: False

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

Console.ReadKey();

