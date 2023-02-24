// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int ReadData(string msg)  // The ol' reliable methods for reading and printing data...
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(int num, string msg)
{
    Console.WriteLine(num + msg);
}

// Creating a method to create and fill our dictionary with palindromes


Dictionary<int, int> DictionaryFill()
{
    Dictionary<int, int> palindromes = new Dictionary<int, int>();
    int counter = 1;
    for (int secondDigit = 0; secondDigit <= 9; secondDigit++)
    {
        for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
        {
            palindromes[counter] = firstDigit * 1000 + secondDigit * 100 + secondDigit * 10 + firstDigit;
            counter++;
        }
    }
    return palindromes;
}

// Creating a method for checking if key value is a palindrome using our dictionary
bool IsItInThere(int input, Dictionary<int, int> palindromes)
{
    bool result = false;
    if (input > 9999 && input < 100000)
    {
        if (palindromes.ContainsValue((input / 1000) * 100 + (input % 100)))
        {
            result = true;
        }
    }
    return result;
}

Dictionary<int, int> palindromes = DictionaryFill();
int value = ReadData("Enter a 5-digit number: "); 


// We need to make sure that out value is indeed a 5-digit number...
if (value >= 10000 && value <= 99999)  
{
    // Checking the value for its palindromeness...
    bool result = IsItInThere(value, palindromes); 
    // ...and using the result to establish the output.
    if (result)                       
    {
        PrintData(value, " is a palindrome!");
    }
    else
    {
        PrintData(value, " is not a palindrome. Maybe try different number?");
    }
}
else
{
    // ...because if it is not, we need to tell the user so!
    Console.WriteLine("Your number is invalid. It should be more than 9999 and less than 10000. Try again.");  
}