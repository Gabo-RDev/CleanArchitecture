// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
// Variables

int number = 12;
number = 20;
float deci = 12.3f; // hasta 7 digitos
double dec = 3.14;

// Booleanos

bool isThereBeer = true;

// Strings
string name = "Gabriel";
char land = 'L'; // para guardar letras

// Declarar variables
var num = 15; // Con var se infiere el tipo
var firstName = "Wilmer";
//name = "Dayron"; // No se puede re-declarar

// -------------------------------------------

// Arrays
int[] numbers = new int[5]
{
    1,2, 3, 4, 5
};
//numbers[0] = 0;
//numbers[1] = 1;
//numbers[2] = 2;
//numbers[3] = 3;
//numbers[5] = 4;
//numbers[5] = 5;

Console.WriteLine(numbers[4]);