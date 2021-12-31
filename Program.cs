/* Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
 Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

    int[] firstArray = new int[10];
    int[] secondArray = new int[firstArray.Length];
    Random rand = new Random();
    for (int i = 0; i < firstArray.Length; i++)
    {
      firstArray[i] = rand.Next(100);
      Console.Write(firstArray[i] + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < firstArray.Length; i++)
    {
          if (firstArray[i] % 2 == 0)
          {
             secondArray[i] = firstArray[i];
             Console.Write(secondArray[i] + " ");
          } 
    }