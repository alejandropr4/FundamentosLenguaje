using System;

namespace FundamentosPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //PruebaGit
            //NumeroPositivoNegativo();
            //MayorTresNumero();
            //DiaNacimiento();
            //ConjeturaCollatz();
            //NumerosPares(); 
            SumarNumeros();
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
