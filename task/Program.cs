Console.WriteLine("Enter array size: ");
int size = ReadTextFromConsole();
string[] arrayText = new string[size];

int ReadTextFromConsole()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}

void FillArrayConsoleWords(string[] arrayText)
{
    for(int i = 0; i < arrayText.Length; i++)
    {
        Console.WriteLine($"Enter {i+1} array word");
        arrayText[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
          Console.Write($"{array[i]} ");
        }
    Console.Write("]");
    Console.WriteLine();
}


string [] ThreeWordText(string[] arrayText)
{
    int count = 0;
    for (int i = 0; i < arrayText.Length; i++)
    {
      if(arrayText[i].Length <= 3)
      count++;
    }
    string [] result = new string [size];
    int j = 0;
    for (int i = 0; i < arrayText.Length; i++)
    {
      if(arrayText[i].Length <= 3)
      {
        result[j] = arrayText[i];
        j++;
      }
    }
    return result;
}
        
FillArrayConsoleWords(arrayText);
PrintArray(arrayText);
PrintArray(ThreeWordText(arrayText));   


