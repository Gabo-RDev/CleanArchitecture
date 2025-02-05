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

// Condicionales
var age = 21;
if(age > 60)
{
    Console.WriteLine("Es de la tercera edad");
} else if(age  > 18)
{
    Console.WriteLine("Es mayor de edad");
} else
{
    Console.WriteLine("Es menor de edad");
}

// Switch

switch (age)
{
    case < 18:
        {
            Console.WriteLine("Es menor de edad");
            break;
        }
    case < 60:
        {
            Console.WriteLine("Es mayor de edad");
            break;
        }
    default:
        Console.WriteLine("Es de tercera edad");
        break;
}

// Loops

var names = new string[3]
{
    "Gabriel", "Wilmer", "Dayron"
};

int i = 0;
do
{
    Console.WriteLine(names[i]);
    i++;
} while(i < names.Length);

while(i < names.Length)
{
    Console.WriteLine(names[i]);
}

for (int j = 0; j < numbers.Length; j++)
{
    Console.WriteLine(numbers[j]);
}

// Functions
int res = Area(30, 20);

Console.WriteLine(res);

int Area(int x, int y)
{
    int res = x * y;
    return res;
}

// No retorna nada
Show("Arquitectura Limpia");
Bye();
void Show(string message)
{
    Console.WriteLine(message);
}

void Bye()
{
    Show("Adios");
}

// Ejemplo
int limit  = 10;
var beers = new string[limit];
int iBeers = 0;
int op  = 0;

do 
{
    Console.Clear();
    ShowMneu();
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            if (iBeers < limit)
            {
                Console.Clear();
                Console.WriteLine("Escribe nombre de la cerveza");
                var beer = Console.ReadLine();
                beers[iBeers] = beer;
                iBeers++;
            } else
            {
                Console.WriteLine("Ya no caben cervezas");
            }
            break;
        case 2:
            Console.Clear();
            ShowBeers(beers, iBeers);
            break;  
        case 3:
            Console.WriteLine("Adios");
			break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

} while(op != 3);

void ShowMneu()
{
    Console.WriteLine("1. Agregar nombre");
    Console.WriteLine("2. Mostrar nombre");
    Console.WriteLine("3. Salir");
}

void ShowBeers(string[] beers, int iBeers)
{
    Console.Clear();
    Console.WriteLine("----Cerverzas-----");
	for (int i = 0; i <= iBeers; i++)
	{
        Console.WriteLine(beers[i]);
	}
    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadLine();
}