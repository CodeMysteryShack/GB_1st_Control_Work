// вывод массива
void PrintArray(string[] array, bool breakLine = false)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{(i == 0 ? "[ " : "")}{array[i]}{(i == array.Length - 1 ? " ]" : ", ")}");
  }

  if (breakLine == true) Console.WriteLine();
}

// ввод массива
Console.Write("Input array size: ");
uint arraySize = Convert.ToUInt32(Console.ReadLine());
uint resultArraySize = 0;
string[] array = new string[arraySize];

for (uint i = 0; i < arraySize; i++)
{
  Console.Write($"Input element {i + 1}: ");
  array[i] = Console.ReadLine() ?? "";

  if (array[i].Length <= 3)
  {
    resultArraySize++;
  }
}

if (resultArraySize > 0)
{
  string[] resultArray = new string[resultArraySize];
  uint currentElementIndex = 0;

  for (uint i = 0; i < arraySize; i++)
  {
    if (array[i].Length <= 3)
    {
      resultArray[currentElementIndex] = array[i];
      currentElementIndex++;
    }
  }

  PrintArray(array);
  Console.Write(" -> ");
  PrintArray(resultArray, true);
}
else
{
  if (arraySize > 0)
  {
    PrintArray(array);
  }
  else
  {
    Console.Write("[ ]");
  }
  Console.WriteLine(" -> [ ]");
}
