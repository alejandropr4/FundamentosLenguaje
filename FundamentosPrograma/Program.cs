using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using FundamentosPrograma.Models;
using FundamentosPrograma.Helpers;

namespace FundamentosPrograma
{
    enum TipoChar {Letras, Numeros, Simbolos}
    class Program
    {
        static void Main(string[] args)
        {

            Coche car = new Coche();
            car.Marca = "Seat";
            car.Modelo = "Leon";
            int opcion = -1;
            while (opcion != 6)
            {
                MostrarMenuCoche();
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    car.Arrancar();
                }
                else if (opcion == 2)
                {
                    car.Acelerar();
                }
                else if (opcion == 3)
                {
                    car.frenar();
                }
                else if (opcion == 4)
                {
                    car.Girar();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Aceleración");
                    int aceleracion = int.Parse(Console.ReadLine());
                    car.Acelerar(aceleracion);
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Hasta luego");
                }
                else
                {
                    Console.WriteLine("Opción incorrecta");
                }
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine("Fin de programa");
        }

        static void MostrarMenuCoche()
        {
            Console.WriteLine("-----------MENU-----------");
            Console.WriteLine("1.- Arrancar");
            Console.WriteLine("2.- Acelerar");
            Console.WriteLine("3.- Frenar");
            Console.WriteLine("4.- Girar");
            Console.WriteLine("5.- Acelerar personalizado");
            Console.WriteLine("6.- Salir");
            Console.WriteLine("Seleccione una opción");
        }


        static void EjemploMeses()
        {
            HelperMeses helper = new HelperMeses();
            foreach (TemperaturaMes mes in helper.Meses)
            {
                Console.WriteLine(mes.Mes + ", Maxima: "
                    + mes.Maxima + ", Minima: "
                    + mes.Minima + ", Media Mensual: "
                    + mes.GetMedia());
            }

            Console.WriteLine("------DATOS ANUALES------");
            Console.WriteLine("Maxima Anual " + helper.GetMaximaAnual());
            Console.WriteLine("Minima Anual " + helper.GetMinimaAnual());
            Console.WriteLine("Media Anual " + helper.GetMediaAnual());

            Console.WriteLine("fin del programa");

        }
        static void EvaluarNumerosWhile()
        {
            Console.WriteLine("Introduce un número: ");
            string dato = Console.ReadLine();
            int numero = int.Parse(dato);

            while (dato != "n" && dato != "N")
            {
                if (numero > 0)
                {
                    Console.WriteLine("POSITIVO");
                }else if (numero < 0)
                {
                    Console.WriteLine("NEGATIVO");
                }
                else
                {
                    Console.WriteLine("ZERO");
                }
                Console.WriteLine("¿Desea continuar? (s/n)");
                dato = Console.ReadLine();
                
                if (dato!= "n" && dato != "N")
                {
                    Console.WriteLine("Introduce otro número: ");
                    dato = Console.ReadLine();
                    numero = int.Parse(dato);
                }
            }

        }
        static void EjemploViernes()
        {
            string nombre = "";

            List<String> nombres = new List<string>();

            while (nombre != "n" && nombre != "N")
            {
                Console.WriteLine("Introduzca un nombre: ");
                nombre = Console.ReadLine();
                if (nombre != "n" && nombre != "N")
                {
                    nombres.Add(nombre);
                }

                foreach (String name in nombres)
                {
                        Console.WriteLine(name);
                }                                
            }
        }
        static void EjemploColecciones()
        {
            List<int> numeros = new List<int>();
            numeros.Add(45);
            numeros.Add(78);
            foreach(int num in numeros)
            {

            }
            List<String> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Adrian");
            nombres.Add("Lucia");
            nombres.Add("Ana");
            //nombres.Remove("Ana");
            //Console.WriteLine(nombres[1]);
            nombres.RemoveAt(3);
            foreach (String name in nombres)
            {
                Console.WriteLine(name);
                
            }

        }
        static void EjemploChar(TipoChar tipo)
        {
            for (int i = 0; i <= 255; i++)
            {
                char letra = (char)i;
                if (tipo == TipoChar.Simbolos)
                {
                    if (char.IsSymbol(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }
                else if (tipo == TipoChar.Letras)
                {
                    if (char.IsLetter(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }
                else if (tipo == TipoChar.Numeros)
                {
                    if (char.IsNumber(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }
            }
        }
        static void InvertirTextoStringBuilder(String datos)
        {
            //Queremos medir rendimiento
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(datos);
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }

            Console.WriteLine("--------------------------------");
            krono.Stop();
            Console.WriteLine(texto);
            Console.WriteLine("---------------TIEMPO-------------------------");
            Console.WriteLine("Milisegundos; " + krono.ElapsedMilliseconds);
            

            } 
        static void InvertirTextoString(String texto)
        {
            //Queremos medir rendimiento
            Stopwatch krono = new Stopwatch();
            krono.Start();
            for (int i = 0; i< texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }

            Console.WriteLine("--------------------------------");
            krono.Stop();
            Console.WriteLine(texto);
            Console.WriteLine("---------------TIEMPO-------------------------");
            Console.WriteLine("Milisegundos; " + krono.ElapsedMilliseconds);
        }
        static void SumarNumerosString()
        {
            Console.WriteLine("Introduzca un texto: ");
            string texto = Console.ReadLine();
            int suma = 0;
            for(var i=0; i<texto.Length; i++)
            {
                char caracter = texto[i];
                // int numero = (int)caracter;

                int numero = int.Parse(caracter.ToString());
                suma += numero;
                
            }
            Console.WriteLine(suma);
        }
        static void SumarNumeros()
        {
            Console.WriteLine("Introduzca un numero: ");
            string dato = Console.ReadLine();
            int numero = int.Parse(dato);
            int suma = numero;
            while (numero != 0)
            {
                Console.WriteLine("Suma "+ suma);
                Console.WriteLine("Introduzca un numero: ");
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                suma += numero;
            }
            Console.WriteLine("Hasta luego");
        }
        static void NumerosPares()
        {
            Console.WriteLine("Introduzca un inicio: ");
            string dato = Console.ReadLine();
            int inicio = int.Parse(dato);
            Console.WriteLine("Introduzca un fin: ");
            dato = Console.ReadLine();
            int fin = int.Parse(dato);
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduzca un número: ");
            string dato = Console.ReadLine();
            int numero = int.Parse(dato);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    //PAR
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                Console.WriteLine(numero);
            }
        }
        static void DiaNacimiento()
        {
            Console.WriteLine("Dia de nacimiento");
            Console.WriteLine("Introduzca un día: ");
            string dato = Console.ReadLine();
            int dia = int.Parse(dato);
            Console.WriteLine("Introduzca un mes: ");
            dato = Console.ReadLine();
            int mes = int.Parse(dato);
            Console.WriteLine("Introduzca un año: ");
            dato = Console.ReadLine();
            int anyo = int.Parse(dato);
            
            int op1 = 0;
            int op2 = 0;
            int op3 = 0;
            int op4 = 0;
            int op5 = 0;
            int op6 = 0;
            int resultado = 0;
            if (mes == 1)
            {
                mes = 13;
                anyo = anyo - 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo = anyo - 1;
            }
            op1=((mes+1)*3)/5;
            op2 = anyo / 4;
            op3 = anyo / 100;
            op4 = anyo / 400;
            op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            op6 = op5 / 7;
            resultado = (op5 - (op6 * 7));
            if (resultado == 0)
            {
                Console.WriteLine("SABADO");
            } else if (resultado == 1)
            {
                Console.WriteLine("DOMINGO");
            } else if (resultado == 2)
            {
                Console.WriteLine("LUNES");
            } else if (resultado == 3)
            {
                Console.WriteLine("MARTES");
            } else if (resultado == 4)
            {
                Console.WriteLine("MIERCOLES");
            }else if (resultado == 5)
            {
                Console.WriteLine("Jueves");
            }else if (resultado == 6)
            {
                Console.WriteLine("SABADO");
            }
            Console.WriteLine("Fin del programa");
        }
        static void MayorTresNumero()
        {
            Console.WriteLine("Numero 1: ");
            string dato = Console.ReadLine();
            int numero1 = int.Parse(dato);
            Console.WriteLine("Numero 2: ");
            dato = Console.ReadLine();
            int numero2 = int.Parse(dato);
            Console.WriteLine("Numero 3: ");
            dato = Console.ReadLine();
            int numero3 = int.Parse(dato);
            int mayor = 0, menor=0, intermedio=0;
            if(numero1>=numero2 && numero1 >= numero3)
            {
                mayor = numero1;
            }else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }
            if(numero1<=numero2 && numero1 <= numero3)
            {
                menor = numero1;
            }else if (numero2<=numero1 && numero2 <= numero3)
            {
                menor = numero2;
            }
            else
            {
                menor = numero3;
            }
            int suma = (numero1 + numero2 + numero3);
            intermedio = suma - mayor - menor;
            Console.WriteLine("Numero mayor: " + mayor);
            Console.WriteLine("Numero menor: " + menor);
            Console.WriteLine("Numero intermedio: " + intermedio);
        }
        static void NumeroPositivoNegativo() {
            Console.WriteLine("Introduzca un numero: ");

            string dato = Console.ReadLine();
            int numero = int.Parse(dato);

            if(numero > 0)
            {
                Console.WriteLine("Positivo");
            }else if (numero == 0)
            {
                Console.WriteLine("Cero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    
    }

}
