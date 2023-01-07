//1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10
//exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
//notas de los exámenes y el promedio resultante.

//List<int> notes = new List<int>() { 10, 9, 5, 7, 8, 3, 8, 2, 7, 5 };
//int sum = 0;
//notes.ForEach(note =>
//{
//    sum += note;
//    Console.WriteLine("La nota obtenida es: " + note);
//});

//Console.WriteLine("El promedio de final es de: " + sum / 10);



//2.Dada las edades de 20 personas guardadas en una lista, imprimir por
//pantalla cuántos son mayores de edad y cuántos no.

//List<int> ages = new List<int>() { 10, 9, 5, 7, 8, 3, 8, 2, 7, 5, 22, 56, 98, 19, 18, 44, 34, 50, 17, 73 };

//int oldies = ages.Where(age => age >= 18).Count();

//Console.WriteLine(oldies);


//3.Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y
//el que tenga menos letras de todos.

//List<string> nombres = new List<string>() { "Homero", "Jay", "Lisa", "Bartolomeo", "Margaret", "Maggie" };
//int cantLetras = 9999999;
//string masCorto = "";

//nombres.ForEach(nombre =>
//    {
//        if (nombre.Length < cantLetras) {
//            cantLetras = nombre.Length;
//            masCorto = nombre;
//        }
//    });

//Console.WriteLine("El nombre más corto es: " + masCorto + " con " + cantLetras + " caracteres.");

//4.Crear una variable para guardar los nombres de elementos para una “lista de
//supermercado”. Solicitar al usuario que ingrese el nombre de un elemento
//que va a comprar en el super y verificar que el elemento esté en la lista. Si no
//está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar
//que sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y
//los que compró, pero no estaban en la lista. Si se quiere, mostrar también
//todos los elementos que el usuario compró. Para salir el usuario debe
//ingresar “fin”.


//using System.Collections.Generic;

//string usrEntry = "";
//List<string> listaCompras = new List<string>() { "manteca", "pan", "carbon", "carne", "papas", "detergente", "agua", "sal" };
//List<string> compradoEnLista = new List<string>();
//List<string> compradoNoLista = new List<string>();

//while (true)
//{
//    Console.WriteLine("Ingrese el elemento que va a comprar, para finalizar ingrese fin:");
//    usrEntry = Console.ReadLine().ToLower();
//    if (usrEntry == "fin")
//    {
//        break;
//    }

//    if (listaCompras.Exists(item => item == usrEntry))
//    {
//        Console.WriteLine($"El producto {usrEntry} se encuentra en la lista de compras.");
//        listaCompras.Remove(usrEntry);
//        compradoEnLista.Add(usrEntry);
//        continue;
//    }

//    Console.WriteLine($"El producto {usrEntry} no se encuentra en la lista de compras.");
//    compradoNoLista.Add(usrEntry);
//    listaCompras.Add(usrEntry);
//};

//Console.WriteLine("La lista de productos de productos no comprados es: ");
//foreach (var item in listaCompras)
//{
//    if (!compradoNoLista.Exists(comprado => comprado == item)) {
//        Console.WriteLine(item);
//    }
//}

//Console.WriteLine("La lista de productos de productos comprados es que no están en la lista es: ");
//foreach (var item in compradoNoLista)
//{
//    Console.WriteLine(item);
//}

//5.Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en
//lugares pares. Imprimir la matriz por pantalla

//char[,] matriz = new char[5, 5];

//for (int i = 1; i < 6; i++)
//{
//    for (int j = 1; j < 6; j++)
//    {

//        if ((i + j) % 2 == 0)
//        {
//            matriz[i - 1, j - 1] = 'P';
//        }
//        else
//        {
//            matriz[i - 1, j - 1] = 'I';
//        }
//    }
//}

//foreach (char item in matriz)
//{
//    Console.WriteLine(item);
//}

//6.Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los
//días de la semana. La estructura es para registrar la temperatura diaria de
//una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la
//matriz de forma aleatoria para el mes de mayo donde el primer día inicia en
//lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada
//con valores aleatorios desde el principio del programa, no es necesario pedir
//los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
//a.Obtener la temperatura más alta y baja de la semana y que día se
//produjo (lunes, martes, etc.)
//b.Promedio de temperatura de la semana.
//c. Temperatura más alta del mes y su día.

//double[,] mes = new double[5, 7];
//double temp = 0.0;
//var rand = new Random();
//int orden = 0;


//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        orden++;
//        if (orden <= 31)
//        {
//            do
//            {
//                temp = rand.NextDouble() * 39;
//            } while (temp < 7.0);

//            mes[i, j] = (Math.Truncate(temp * 4) / 4);
//        }
//    }
//}

//double tempBaja = 39;
//double tempAlta = 0;
//double tempMasBaja = 39;
//double tempMasAlta = 0;
//double promedio = 0;
//int diaAlto = 0;
//int diaBaja = 0;
//int diaMasAlta = 0;
//int diaMasBaja = 0;
//orden = 0;

//static string calDia(int numOrd)
//{
//    int numDia = (numOrd - 1) % 7;
//    return numDia switch
//    {
//        0 => "Lúnes",
//        1 => "Martes",
//        2 => "Miércoles",
//        3 => "Jueves",
//        4 => "Viernes",
//        5 => "Sábado",
//        6 => "Domingo",
//        _ => "Error",
//    };
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        orden++;
//        if (orden <= 31)
//        {
//            if (mes[i, j] < tempBaja)
//            {
//                tempBaja = mes[i, j];
//                diaBaja = orden;
//            }
//            if (mes[i, j] > tempAlta)
//            {
//                tempAlta = mes[i, j];
//                diaAlto = orden;
//            }
//            promedio += mes[i, j];
//        }
//    }
//    if (tempAlta > tempMasAlta)
//    {
//        tempMasAlta = tempAlta;
//        diaMasAlta = diaAlto;
//    }
//    if (tempMasBaja > tempBaja)
//    {
//        tempMasBaja = tempBaja;
//        diaMasBaja = diaBaja;
//    }

//    Console.WriteLine("El promedio de la semana es {0:N2}: ",  promedio / 7);
//    Console.WriteLine($"En la semana {i + 1} la temperatura más alta fue de {tempAlta}º, un {calDia(diaAlto)}; y la más baja fue de {tempBaja}º, un {calDia(diaBaja)}.");
//    tempBaja = 39;
//    tempAlta = 0;
//    promedio = 0;
//}

//Console.WriteLine($"En mes la temperatura más alta fue de {tempMasAlta}º, un {calDia(diaMasAlta)} y la más baja fue de {tempMasBaja}º, un {calDia(diaMasBaja)}");


//7.Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la
//primera fila y la primera columna se debe guardar los números (de 0 a 9),
//estando el cero en la primera posición (fila 0, columna 0). El resto de los
//lugares debe ser calculado usando los números que se dispone, por ejemplo,
//en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o
//arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla


//int[,] tabla = new int[10, 10];

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        tabla[i, j] = (i) * ( j);
//    }
//}
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.Write(tabla[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//8.Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
//cantidad que el programador decida, pero no más de la mitad de los lugares
//disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que
//hay una X, ingresando la fila y la columna por separado. Informar si acertó o
//no por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X
//que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya
//sea porque se terminaron los 3 intentos, o el jugador acertó todas las X)
//imprimir por pantalla la matriz con sus correspondientes X, mostrando un *
//donde no haya nada.

char[,] matriz = new char[10, 10];
var rand = new Random();
int lives = 3;
int restantes = 10;


for (int i = 0; i < 10; i++)
{
    matriz[rand.Next(0, 9), rand.Next(0, 9)] = 'X';
}




while (lives != 0 && restantes != 0)
{
    Console.WriteLine("Ingrese la fila donde cree que hay una X");
    int fila = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la columna donde cree que hay una X");
    int columna = int.Parse(Console.ReadLine());
    if (matriz[fila, columna] == 'X')
    {
        Console.WriteLine("Usted ha acertado");
        restantes--;
        Console.WriteLine($"Quedan {restantes} minas por encontrar.");

    }
    else
    {
        Console.WriteLine("Usted ha fallado");
        lives--;
        Console.WriteLine($"Le quedan {lives} vidas.");

    }
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (matriz[i, j] != 'X')
        {
            Console.Write('*' + " ");
            continue;
        }
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}