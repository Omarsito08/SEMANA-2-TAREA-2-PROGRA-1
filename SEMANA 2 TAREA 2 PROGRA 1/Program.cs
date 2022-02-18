using System;

namespace TAREA_2_PROGRA_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // EJERCICIO NUMERO 1 PEDIR LA EDAD ALL USUARIO
            byte edad, calculo;
            Console.WriteLine("¿CUANTOS AÑOS TIENES?");
            edad = byte.Parse(Console.ReadLine());

            calculo = edad;


            Console.WriteLine("OYE PERO NO APARENTAS {0}", calculo);

            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR");
            Console.ReadKey();


            //EJERCICIO NUMERO 2 PEDIR DOS NUMEROS Y MULTIPLICARLOS
            byte n1, n2, mult;

            Console.WriteLine("¿INGRESA   CUALQUIER   NUMERO?");
            n1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("¿INGRESA   OTRO NUMERO QUE QUIERAS?");
            n2 = Convert.ToByte(Console.ReadLine());

            mult = (byte)(n1 * n2);

            ushort resultado = mult;

            resultado = Convert.ToUInt16(n1 * n2);


            Console.WriteLine("EL RESULTADO ES {0}", resultado);
            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR");
            Console.ReadKey();


            //EJERCICIO NUMERO 3 SUMA Y RESTA DE 2 NUMEROS GRANDES
            long num1, num2, suma, resta, producto;

            Console.WriteLine("¿INGRESA   UN   NUMERO GRANDE?");
            num1 = long.Parse(Console.ReadLine());

            Console.WriteLine("¿INGRESA   OTRO   NUMERO GRANDE?");
            num2 = long.Parse(Console.ReadLine());

            suma = (long)(num1 + num2);
            resta = (long)(num1 - num2);
            producto = (long)(num1 * num2);

            Console.WriteLine("EL RESULTADO DE LA SUMA ES: {0}", suma);
            Console.WriteLine("EL RESULTADO DE LA RESTA ES: {0}", resta);
            Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION ES: {0}", producto);
        }
    }
}