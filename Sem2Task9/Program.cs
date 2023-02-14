System.Random numSintesator = new System.Random();

// Вариант 1
int rndNumber = numSintesator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

if (firstNum > secondNum)
{
    Console.WriteLine("Первое число " + firstNum + "больше второго" + secondNum);
}
else
{
    Console.WriteLine("Второе число" + secondNum + "больше первого" + firstNum);
}

// Вариант 2
char[] digits = numSintesator.Next(10, 100).ToString().ToCharArray();
int firstNumber = ((int)digits[0]) - 48;
int secondNumber = ((int)digits[1]) - 48;

// // <переменная> = (условие),<значение1>:<значение2>;
// if (условие)
// {
//     < переменная > = < значение1 >;
// }
// else
// {
//     < переменная > = < значение2 >;
// }

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);