using System;


namespace ArraysH01
{
    class ArraysH01
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, която създава масив с 20 елемента от целочислен тип
             * и инициализира всеки от елементите със стойност равна на индекса на елемента,умножен по 5. 
             * Елементите на масива да се изведат на конзолата.
             * (Hint: Използвайте масив int[] и for цикъл.)*/
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Output: ");
            for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 5 * array[i];
                    Console.WriteLine(array[i]);
                }
        }
    }
}
