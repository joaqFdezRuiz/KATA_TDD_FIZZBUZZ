namespace KataFizzBuzzConsoleApplication
{
    class KataFizzBuzzConsoleApplication
    {
        static void Main(string[] args)
        {
            KataFizzBuzz.IKataFizzBuzz resultado = new KataFizzBuzz.KataFizzBuzz();
            for (int i = 1; i < 101; i++)
            {
                System.Console.Write(resultado.Game(i.ToString()) + ", ");
            }
            System.Console.ReadLine();
        }
    }
}
