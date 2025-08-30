//// An unsigned integer is a positive whole number or 0.
//using System;

//uint naturalNumber = 23;

//// An integer is a negative or positive whole number or 0.
//int integerNumber = -23;

//// A float is a single-precision floating-point number.
//// The F or f suffix makes the value a float literal.
//// The suffix is required to compile.
//float realNumber = 2.3f;

//// A double is a double-precision floating-point number.
//// double is the default for a number value with a decimal point.
//double anotherRealNumber = 2.3; // A double literal value.

//int decimalNotation = 2_000_000;
//int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
//int hexadecimalNotation = 0x_001E_8480;

//// Check the three variables have the same value.
//Console.WriteLine($"{decimalNotation == binaryNotation}");
//Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

//// Output the variable values in decimal.
//Console.WriteLine($"{decimalNotation:N0}");
//Console.WriteLine($"{binaryNotation:N0}");
//Console.WriteLine($"{hexadecimalNotation:N0}");
//// Output the variable values in hexadecimal.

//Console.WriteLine($"{decimalNotation:X}");
//Console.WriteLine($"{binaryNotation:X}");
//Console.WriteLine($"{hexadecimalNotation:X}");

//Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0}to {int.MaxValue:N0}.");
//Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
//Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

//Console.WriteLine("Using doubles:");
//double a = 0.1;
//double b = 0.2;
//if (a + b == 0.3)
//{
//    Console.WriteLine($"{a} + {b} equals {0.3}");
//}
//else
//{
//    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
//}

//Console.WriteLine("Using decimals:");
//decimal c = 0.1M; // M suffix means a decimal literal value
//decimal d = 0.2M;
//if (c + d == 0.3M)
//{
//    Console.WriteLine($"{c} + {d} equals {0.3M}");
//}
//else
//{
//    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
//}

//#region Special float and double values
//Console.WriteLine($"double.Epsilon: {double.Epsilon}");
//Console.WriteLine($"double.Epsilon to 324 decimal places: {double.
//Epsilon:N324}");
//Console.WriteLine($"double.Epsilon to 330 decimal places: {double.
//Epsilon:N330}");
//const int col1 = 37; // First column width.
//const int col2 = 6; // Second column width.
//string line = new string('-', col1 + col2 + 3);
//Console.WriteLine(line);
//Console.WriteLine($"{"Expression",-col1} | {"Value",col2}");
//Console.WriteLine(line);
//Console.WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
//Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
//Console.WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
//Console.WriteLine(line);
//Console.WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
//Console.WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
//Console.WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
//Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
//Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} |{-3.0 / 0.0 == double.NegativeInfinity,col2}");
//Console.WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
//Console.WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}");
//Console.WriteLine(line);
//#endregion

//unsafe
//{
//    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
//    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
//}

//object height = 1.88; // Storing a double in an object.
//object name = "Amir"; // Storing a string in an object.
//Console.WriteLine($"{name} is {height} metres tall.");
////int length1 = name.Length; // This gives a compile error!
//int length2 = ((string)name).Length; // Cast name to a string.
//Console.WriteLine($"{name} has {length2} characters.");

//dynamic something;
//// Storing an array of int values in a dynamic object.
//// An array of any type has a Length property.
////something = new[] { 3, 5, 7 };
//// Storing an int in a dynamic object.
//// int does not have a Length property.
//something = 12;
//// Storing a string in a dynamic object.
//// string has a Length property.
//something = "Ahmed";
//// This compiles but might throw an exception at run-time.
//Console.WriteLine($"The length of something is {something.Length}");
//// Output the type of the something variable.
//Console.WriteLine($"something is a {something.GetType()}");


//using System.Xml;

//var population = 67_000_000; // 67 million in UK.
//var weight = 1.88; // in kilograms.
//var price = 4.99M; // in pounds sterling.
//var fruit = "Apples"; // string values use double-quotes.
//var letter = 'Z'; // char values use single-quotes.
//var happy = true; // Booleans can only be true or false.

//// Good use of var because it avoids the repeated type
//// as shown in the more verbose second statement.
//var xml1 = new XmlDocument(); // Works with C# 3 and later.
//XmlDocument xml2 = new XmlDocument(); // Works with all C# versions.
//// Bad use of var because we cannot tell the type, so we
//// should use a specific type declaration as shown in
//// the second statement.
//var file1 = File.CreateText("something1.txt");
//StreamWriter file2 = File.CreateText("something2.txt");


//Console.WriteLine($"default(int) = {default(int)}");
//Console.WriteLine($"default(bool) = {default(bool)}");
//Console.WriteLine($"default(DateTime) = {default(DateTime)}");
//Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");
//int number = 13;
//Console.WriteLine($"number set to: {number}");
//number = default;
//Console.WriteLine($"number reset to its default: {number}");

//using System.Globalization; // To use CultureInfo.
//// Set current culture to US English so that all readers
//// see the same output as shown in the book.
//CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
//int numberOfApples = 12;
//decimal pricePerApple = 0.35M;
//Console.WriteLine(
//format: "{0} apples cost {1:C}",
//arg0: numberOfApples,
//arg1: pricePerApple * numberOfApples);
//string formatted = string.Format(
//format: "{0} apples cost {1:C}",
//arg0: numberOfApples,
//arg1: pricePerApple * numberOfApples);
////WriteToFile(formatted); // Writes the string into a file.

//// Three parameter values can use named arguments.
//Console.WriteLine("{0} {1} lived in {2}.",
//arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
//// Four or more parameter values cannot use named arguments.
//Console.WriteLine(
//"{0} {1} lived in {2} and worked in the {3} team at {4}.",
//"Roger", "Cevung", "Stockholm", "Education", "Optimizely");

//string applesText = "Apples";
//int applesCount = 1234;
//string bananasText = "Bananas";
//int bananasCount = 56789;
//Console.WriteLine();
//Console.WriteLine(format: "{0,-10} {1,6}",
//arg0: "Name", arg1: "Count");
//Console.WriteLine(format: "{0,-10} {1,6:N0}",
//arg0: applesText, arg1: applesCount);
//Console.WriteLine(format: "{0,-10} {1,6:N0}",
//arg0: bananasText, arg1: bananasCount);


//Console.Write("Type your first name and press ENTER: ");
//string? firstName = Console.ReadLine();
//Console.Write("Type your age and press ENTER: ");
//string age = Console.ReadLine()!;
//Console.WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);
