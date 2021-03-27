using System;

namespace Calculate
{
    class Program
    {
        public object Parse { get; private set; }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    float number1, number2, result;
                    char operation;
                    //1. Wyświetlenie nagłowka - opis aplikacji
                    Console.WriteLine("Welcome in the Calculate Program !\n" +
                        "Here you can make four different math operations\n" +
                        "1. +\n" +
                        "2. -\n" +
                        "3. *\n" +
                        "4. / ");

                    //2. Prośba o podanie 1 liczby
                    Console.WriteLine("Please give the number: ");

                    //3. Pobranie liczby od użytkownika
                    number1 = GetNumber();

                    //4. Prośba o podanie działania
                    Console.WriteLine("Please choose the math operation:");

                    //5. Pobranie wybranego działania od użytkownika
                    operation = char.Parse(Console.ReadLine());

                    //6. Prośba o podanie 2 liczby
                    Console.WriteLine("Please give the number: ");

                    //7. Pobranie liczby od użytkownika
                    number2 = GetNumber();

                    //8. Wykonanie obliczeń
                    result = Calculate(number1, number2, operation);

                    //9. Wyświetlenie wyniku użytkownikowi
                    Console.WriteLine("Your result of: " + operation + " is = " + result + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex + "\n");
                }
            }
        }

        public static float GetNumber()
        {
            float result;
            try
            {
                result = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                throw new Exception("It's not a number");
            }
            return result;
        }

        public static float Calculate(float number1, float number2, char operation)
        {
            float result = 0;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Wrong operation");
            }

            return result;
        }

    }
}
