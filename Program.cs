using System;
namespace practice
{
    //esto es una clase, un conjunto de métodos
    // static void es igual a una función
    class Program
     
    {
        //método principal del programa
        static void Main(string[] args)
        {
            //Escribe en la consola
            Console.WriteLine("Introduce dividendo"); 
            //x es igual a lo que escribe el usuario en la siguiente linea (convertido de string a tipo float)
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un divisor");
            float y = float.Parse(Console.ReadLine());
            // la llamada a la función (con los argumentos siendo las variables que se han definido)
            Divide(x,y);
               
        }
        //la función divide de x e y, y que salga en la consola
        static void Divide(float x, float y)
        {
            Console.WriteLine(x / y);
        }


    }
}