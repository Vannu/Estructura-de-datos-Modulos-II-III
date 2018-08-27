/*
 Ejercicios de Estructura de datos IFTS18

 Vanesa Soria
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa que ejercicios ver:");
            string valor = Console.ReadLine();
            int number;
            while (!(int.TryParse(valor, out number)))
            {
                Console.WriteLine("Debe ingresar un número");
                valor = Console.ReadLine();
            }
            switch (number)
            {
                case 1:
                    Ejercicio1(); // Práctica
                    break;
                case 2:
                    Ejercicio2(); //Modulo II
                    break;
                case 3:
                    Ejercicio3(); //Modulo II
                    break;
                case 4:
                    Ejercicio4(); //Modulo II
                    break;
                case 5:
                    Ejercicio5(); //Modulo II
                    break;
                case 6:
                    Ejercicio6(); //Modulo II
                    break;
                case 7:
                    Ejercicio7(); //Modulo II
                    break;
                case 8:
                    Ejercicio8(); //Modulo II
                    break;
                case 9:
                    Ejercicio9(); //Modulo II
                    break;
                case 10:
                    Ejercicio10(); //Modulo II
                    break;
                case 11:
                    Ejercicio11(); //Modulo II
                    break;
                case 12:
                    Ejercicio12(); //Modulo II
                    break;
                case 13:
                    Ejercicio13(); //Modulo II
                    break;
                case 14:
                    Ejercicio14(); //Modulo II
                    break;
                case 15:
                    Ejercicio15(); //Modulo II
                    break;
                case 16:
                    Ejercicio16(); //Modulo II
                    break;
                case 17:
                    Ejercicio17(); //Modulo III
                    break;
                case 18:
                    Ejercicio18(); //Modulo III
                    break;
                case 19:
                    Ejercicio19(); //Modulo III
                    break;
                case 20:
                    Ejercicio20(); //Modulo III
                    break;
                case 21:
                    Ejercicio21(); //Modulo III
                    break;
                case 22:
                    Ejercicio22(); //Modulo III
                    break;
                case 23:
                    Ejercicio23(); //Modulo III
                    break;
                case 24:
                    Ejercicio24(); //Modulo III
                    break;
                case 25:
                    Ejercicio25(); //Modulo III
                    break;
                case 26:
                    Ejercicio26(); //Modulo III
                    break;

            }

        }
        #region PRACTICA
        public static void Ejercicio1()
        {
            /*--------------------PRÁCTICA----------------------
           .Que aparezca un mensaje con el texto "Hola Mundo" (Console.WriteLine)
           .Declarar una variable tipo número entero(int) y asignarle el valor 9
           .Declarar una variable tipo palabra (string) y dejar que el usuario introduzca su nombre (Console.ReadLine)
           .Declarar una variable de tipo número entero (int) y dejar que el usuario introduzca cualquier número entero (Console.ReadLine y Convert.ToInt32)
           .Declarar una variable tipo número entero (int) y asignarle la suma de la primera variable declarada con el numero ingresado por el usuario
           .Que aparezca en un mensaje en pantalla un saludo con el nombre del usuario y otro mensaje si el número es mayor, menor o igual a 0 (if - else - else if)
           */

            Console.WriteLine("Hola Mundo");

            int firstNumber = 9;

            string nombre = "";
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            int secondNumber = 0;
            string valueInput;
            Console.WriteLine("Ingrese número");
            bool correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();

                if (!(int.TryParse(valueInput, out secondNumber)))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                correctInput = true;
            }
            Console.WriteLine("Hola {0}", nombre);
            int suma = firstNumber + secondNumber;

            if (suma > 0)
            {
                Console.WriteLine("La suma es: {0} es mayor a cero", suma);
            }
            else if (suma < 0)
            {
                Console.WriteLine("La suma es: {0} es menor a cero", suma);
            }
            else
            {
                Console.WriteLine("La suma es: {0} es igual a cero", suma);
            }
            Console.ReadKey();
        }
        #endregion
        #region MODULO II
        public static void Ejercicio2()
        {
            /*
               Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56. 
            */

            int suma = 200 + 56;
            Console.WriteLine("La suma de 200 y 56 es {0}", suma);
            Console.ReadKey();
        }
        public static void Ejercicio3()
        {
            /*
            Tarea 3: Haz un programa que calcule el producto de los números 13 y 12. 
            */

            int producto = 13 * 12;
            Console.WriteLine("El producto de 13 y 12 es {0}", producto);
            Console.ReadKey();
        }
        public static void Ejercicio4()
        {
            /*
            Tarea 4: Un programa que calcule la diferencia (resta) entre 321 y 213
            */

            int resta = 321 - 213;
            Console.WriteLine("La resta de 321 y 213 es {0}", resta);
            Console.ReadKey();
        }
        public static void Ejercicio5()
        {
            /*
            Tarea 5: Calcular el resultado de (20+5) % 6
            */

            int suma = 20 + 5;
            Double resultado = suma * 0.06;
            Console.WriteLine("El resultado de (20+5) % 6 es {0}", resultado);
            Console.ReadKey();
        }
        public static void Ejercicio6()
        {
            /*
            Tarea 6: Crea un programa que calcule el producto de los números 12 y 102, usando
variables
            */
            int primerNumero = 12;
            int segundoNumero = 102;
            int producto = primerNumero * segundoNumero;
            Console.WriteLine("El producto de 12 y 102 es {0}", producto);
            Console.ReadKey();
        }
        public static void Ejercicio7()
        {
            /*
            Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando
variables.
            */
            int primerNumero = 200;
            int segundoNumero = 1111;
            int suma = primerNumero + segundoNumero;
            Console.WriteLine("La suma de 12 y 102 es {0}", suma);
            Console.ReadKey();
        }
        public static void Ejercicio8()
        {
            /*
            Tarea 8:Crea un programa que calcule el producto de los números 10 y 25, usando
variables llamadas "numero1" y "numero2".
            */
            int numero1 = 10;
            int numero2 = 25;
            int producto = numero1 * numero2;
            Console.WriteLine("El producto de 10 y 25 es {0}", producto);
            Console.ReadKey();
        }
        public static void Ejercicio9()
        {
            /*
            Tarea 9:Crea un programa que calcule el producto de dos números introducidos por
el usuario.
            */
            int numero1 = 0;
            int numero2 = 0;
            string valueInput;
            Console.WriteLine("Ingrese el primer número");
            bool correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out numero1)))
                {
                    Console.WriteLine("Debe ingresar un número entero");
                    continue;
                }
                correctInput = true;
            }
            Console.WriteLine("Ingrese el segundo número");
            correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out numero2)))
                {
                    Console.WriteLine("Debe ingresar un número entero");
                    continue;
                }
                correctInput = true;
            }


            int producto = numero1 * numero2;
            Console.WriteLine("El producto de {0} y {1} es {2}", numero1, numero2, producto);
            Console.ReadKey();
        }
        public static void Ejercicio10()
        {
            /*
            Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par
(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x
% 2 == 0) ...).
            */
            int number = 0;
            string valueInput;
            Console.WriteLine("Ingrese número");
            bool correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out number)))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                correctInput = true;
            }
            if (number % 2 == 0)
                Console.WriteLine("El número es par");
            else
                Console.WriteLine("El número es impar");

            Console.ReadKey();
        }
        public static void Ejercicio11()
        {
            /*Crea un programa que pida al usuario dos números enteros y diga cuál es el
mayor de ellos.*/
            int firstNumber = 0, secondNumber = 0;
            string valueInput;
            Console.WriteLine("Ingrese primer número");
            bool correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out firstNumber)))
                {
                    Console.WriteLine("Debe ingresar correctamente el primer número");
                    continue;
                }
                correctInput = true;
            }
            Console.WriteLine("Ingrese segundo número");
            correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out secondNumber)))
                {
                    Console.WriteLine("Debe ingresar correctamente el segundo número");
                    continue;
                }
                correctInput = true;
            }
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("El mayor es: {0}", firstNumber);

            }
            else
            {
                Console.WriteLine("El mayor es: {0}", secondNumber);
            }

            Console.ReadKey();

        }
        public static void Ejercicio12()
        {
            /*Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo
no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre
cero".*/

            int firstNumber = 0, secondNumber = 0;
            string valueInput;
            Console.WriteLine("Ingrese el primer número");
            bool correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out firstNumber)))
                {
                    Console.WriteLine("Ingese un número");
                    continue;
                }
                correctInput = true;
            }

            Console.WriteLine("Ingrese el segundo número");
            correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out secondNumber)))
                {
                    Console.WriteLine("Ingese un número");
                    continue;
                }
                correctInput = true;
            }

            if (secondNumber == 0)
            {
                Console.WriteLine("Error no se puede dividir entre cero");
            }
            else
            {
                Console.WriteLine("El resultado de la división es: {0}", firstNumber / secondNumber);
            }

            Console.ReadKey();

        }
        public static void Ejercicio13()
        {
            /*
             Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el programa
escribirá "uno").
             */
            int number = 0;
            string valueInput;
            Console.WriteLine("Ingrese un numero del 1 al 5");
            bool correctInput = false;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out number)))
                {
                    continue;
                }
                if (number <= 1 && number >= 6)
                {
                    Console.WriteLine("Ingrese un número del 1 al 5");
                    continue;
                }
                correctInput = true;
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
            }
            Console.ReadKey();
        }
        public static void Ejercicio14()
        {
            /*Tarea 14: Crea un programa que escriba en pantalla los números del
1 al 10, usando "while".
             */
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i + 1);
                i++;
            }
            Console.ReadKey();

        }
        public static void Ejercicio15()
        {
            /*Tarea 15: Crea un programa que escriba en pantalla los
números del 1 al 10, usando "do..while".
             */
            int number = 1;

            do
            {
                Console.WriteLine(number);

                number++;
            } while (number <= 10);
            Console.ReadKey();

        }
        public static void Ejercicio16()
        {
            /*Tarea 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos,
usando “for”*/

            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        #endregion
        #region MODULO III
        public static void Ejercicio17()
        {
            /*
             Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña (ambos
numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
contraseña "1111".*/

            int id = 711;
            int pass = 1111;
            int correctId;
            int correctPass;

            do
            {
                Console.Write("Introduzca su Identificador: ");
                correctId = Convert.ToInt32(Console.ReadLine());

                if (correctId != id)

                    Console.WriteLine("No válida!");

                Console.Write("Introduzca su Password: ");
                correctPass = Convert.ToInt32(Console.ReadLine());

                if (correctPass != pass)
                    Console.WriteLine("No válida!");
            }
            while (correctId != id && correctPass != pass);

            Console.WriteLine("Aceptada.");
            Console.ReadKey();
        }
        public static void Ejercicio18()
        {
            /*Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
     puede hacer dividiendo varias veces entre 10).

            **/
            int number = 0;

            string valueInput;
            Console.WriteLine("Ingrese una cifra");
            bool correctInput = false;
            int i = 0;
            while (!(correctInput))
            {
                valueInput = Console.ReadLine();
                if (!(int.TryParse(valueInput, out number)))
                {
                    Console.WriteLine("Debe ingresar un números");
                    continue;
                }
                correctInput = true;
            }
            while (number != 0)
            {
                number = number / 10;
                i++;
            }
            Console.WriteLine("Cantidad de cifras: {0}", i);
            Console.ReadKey();
        }
        public static void Ejercicio19()
        {
            /*  Tarea 3: Crea un programa que muestre la tabla de multiplicar del 9.*/
            int number = 0;
            int table = 0;
            string valueInput;
            Console.WriteLine("Tabla de multiplicar ingrese valor");
            valueInput = Console.ReadLine();
            while (!(int.TryParse(valueInput, out number)))
            {
                Console.WriteLine("Debe ingresar un número");
                valueInput = Console.ReadLine();
            }
            for (int i = 1; i <= 10; i++)
            {
                table = number * i;
                Console.WriteLine("{0} * {1} = {2}", number, i, table);
            }
            Console.ReadKey();

        }
        public static void Ejercicio20()
        {
            /* Tarea 4: Crea un programa que contenga un bucle sin fin que muestre los números enteros
       positivos a partir del uno.
       */
            int i = 1;
            while (i >= 1)
            {
                Console.Write(i);

                i++; ;
            }
            Console.ReadKey();
        }
        public static void Ejercicio21()
        {
            /*Tarea 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin
      avanzar de línea.
      
            */
            int i = 1;

            while (i >= 1)
            {
                Console.Write("hola");
                Console.Write(" - ");

            }
            Console.ReadKey();
        }
        public static void Ejercicio22()
        {
            /*Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = ++a; c = a++; b = b * 5;
            a = a * 2; Crea un programa que lo resuelva.*/

            int a = 5;
            int b = a++;
            int c = a++;
            b = b * 5;
            a = a * 2;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadKey();

        }
        public static void Ejercicio23()
        {
            /*Tarea 7: ¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = a + 2; b -= 3; c = -3; c *= 2;
            ++c; a *= b; Crea un programa que te lo muestre.*/

            int a = 5;
            int b = a + 2;
            b -= 3;
            int c = -3;
            c *= 2;
            ++c;
            a *= b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadKey();
        }
        public static void Ejercicio24()
        {
            /*Tarea 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal.*/

            string letter;
            Console.WriteLine("Ingrese una letra");

            letter = Console.ReadLine();
            if (letter.Length == 1)
            {
                switch (letter)
                {
                    case "a": Console.WriteLine("Es una vocal"); break;
                    case "e": Console.WriteLine("Es una vocal"); break;
                    case "i": Console.WriteLine("Es una vocal"); break;
                    case "o": Console.WriteLine("Es una vocal"); break;
                    case "u": Console.WriteLine("Es una vocal"); break;

                    case "A": Console.WriteLine("Es una vocal"); break;
                    case "E": Console.WriteLine("Es una vocal"); break;
                    case "I": Console.WriteLine("Es una vocal"); break;
                    case "O": Console.WriteLine("Es una vocal"); break;
                    case "U": Console.WriteLine("Es una vocal"); break;

                    default: Console.WriteLine("Es una consonante"); break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese sólo una letra");
            }

            Console.ReadKey();
        }
        public static void Ejercicio25()
        {
            /* Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
              debe introducir dos veces.Si las dos contraseñas no son iguales, se avisará al usuario y se le
             volverán a pedir las dos contraseñas.*/

            string name;
            string pass1;
            string pass2;

            Console.WriteLine("Ingrese un nombre");
            name = Console.ReadLine();

            Console.WriteLine("Ingrese una contraseña");
            pass1 = Console.ReadLine();
            do
            {
                Console.Write("Ingrese nuevamente la contraseña ");
                pass2 = Console.ReadLine();
            }
            while (pass1 != pass2);

            Console.WriteLine("Conrtaseña correcta");
            Console.ReadKey();
        }
        public static void Ejercicio26()
        {
            /* Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama
      "Martín", o bien le diga "No te conozco" si teclea otro nombre.
            */

            string name;
            Console.WriteLine("Ingrese su nombre");
            name = Console.ReadLine();
            if (name == "Martín")
            {
                Console.WriteLine("Hola!");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
            Console.ReadKey();
        }
        #endregion      
    }
}