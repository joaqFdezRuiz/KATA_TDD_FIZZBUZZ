using NUnit.Framework;

namespace KataFizzBuzzTests
{
    public class KataFizzBuzzTests
    {
        [TestFixture]
        public class Paso_Numero_Uno_Al_Juego {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup() {
                resultado = SUT.Game("1");
            }

            [Test]
            public void Debe_Devolver_Uno() {
                Assert.AreEqual(resultado, "1");
            }
        }

        [TestFixture]
        public class Paso_Numero_Dos_Al_Juego
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("2");
            }

            [Test]
            public void Debe_Devolver_Dos()
            {
                Assert.AreEqual(resultado, "2");
            }
        }

        [TestFixture]
        public class Paso_Numero_Divisible_Tres_Al_Juego
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("3");
            }

            [Test]
            public void Debe_Devolver_Fizz()
            {
                Assert.AreEqual(resultado, "Fizz");
            }
        }

        [TestFixture]
        public class Paso_Numero_Divisible_Cinco_Al_Juego
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("5");
            }

            [Test]
            public void Debe_Devolver_Buzz()
            {
                Assert.AreEqual(resultado, "Buzz");
            }
        }

        [TestFixture]
        public class Paso_Numero_Divisible_Tres_Y_Cinco_Al_Juego
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("60");
            }

            [Test]
            public void Debe_Devolver_FizzBuzz()
            {
                Assert.AreEqual(resultado, "FizzBuzz");
            }
        }

        [TestFixture]
        public class Paso_Numero_Que_Contiene_Tres_Pero_No_Es_Divisible_Tres
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("13");
            }

            [Test]
            public void Debe_Devolver_Fizz()
            {
                Assert.AreEqual(resultado, "Fizz");
            }
        }

        [TestFixture]
        public class Paso_Numero_Que_Contiene_Cinco_Pero_No_Es_Divisible_Cinco
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("52");
            }

            [Test]
            public void Debe_Devolver_Buzz()
            {
                Assert.AreEqual(resultado, "Buzz");
            }
        }

        [TestFixture]
        public class Paso_Numero_Que_Contiene_Tres_Y_Cinco
        {
            KataFizzBuzz.IKataFizzBuzz SUT = new KataFizzBuzz.KataFizzBuzz();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Game("53");
            }

            [Test]
            public void Debe_Devolver_FizzBuzz()
            {
                Assert.AreEqual(resultado, "FizzBuzz");
            }
        }
        
    }
}
