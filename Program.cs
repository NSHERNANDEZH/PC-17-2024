// See https://aka.ms/new-console-template for more information
#region Exploring unary operators
int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b}");
#endregion
#region EXploring unary operators
int c2 = 3;
int d2 = ++c2;
// Prefix means increment c before assigning it.
Console.WriteLine($"c is {c2}, d is {d2}");
#endregion
#region
int e = 11;
int f = 3;
Console.WriteLine($"e is {e},f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
double g = 11.0;

Console.WriteLine($"g is (g:N1), f is (f)");
#endregion
#region# Ejercicios operadores de asignacion
int p1 = 6;

p1 += 3; // Equivalent to: p = p + 3;

p1 -= 3; // Equivalent to: P = P - 3;

p1 *= 3; // Equivalent to: p = p * 3;

p1 /= 3; // Equivalent to: p = p / 3;
#endregion
#region #Operadores que utilizan null
string? authorName = ReadLine() ;

//Prompt user to enter an author name;

// The maxLength variable will be the length of authorName if it is 

// not null, or 30 if authorname is null. 

int maxLength = authorName?.Length ?? 30;

// The authorName variable will be "unknown" if authorName was nulL.

authorName ??= "unknown";
#endregion

#region operadores logicos 
bool p = true;
bool q = false;

Console.WriteLine("AND

pq);

WriteLine($°p | {
    P & p,-5) | { p & 9, -5}
    ");

WriteLine($"QI| {a & p,-5) | {9 & q, -5} ");

    WriteLine();

    WriteLine($"OR | p | q ");

    WriteLine($"p | {p | p,-5} | {p | 9,-5} ");

    WriteLine($"q | {q | p,-5} | (q | q, -5) ");

    WriteLine();

    WriteLine($"XOR | p | q ");

    WriteLine($"p | {P ^ P,-5) | (p ^ 9, -5) ");

    writeline($"q | (q ^ P, -5) | (q ^ 9, -5) ");
    #endregion