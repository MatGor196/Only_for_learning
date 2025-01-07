
int number = 4566;

string number_in_string = number.ToString();
char[] digits = number_in_string.ToCharArray();

Console.WriteLine(number);
int[] digits_in_number = {0,0,0,0,0,0,0,0,0,0};

foreach (char digit in digits)
{
    if (digit == '0')
    {
        digits_in_number[0]++;
    }
    else if (digit == '1')
    {
        digits_in_number[1]++;
    }
    else if (digit == '2')
    {
        digits_in_number[2]++;
    }
    else if (digit == '3')
    {
        digits_in_number[3]++;
    }
    else if (digit == '4')
    {
        digits_in_number[4]++;
    }
    else if (digit == '5')
    {
        digits_in_number[5]++;
    }
    else if (digit == '6')
    {
        digits_in_number[6]++;
    }
    else if (digit == '7')
    {
        digits_in_number[7]++;
    }
    else if (digit == '8')
    {
        digits_in_number[8]++;
    }
    else if (digit == '9')
    {
        digits_in_number[9]++;
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + digits_in_number[i]);
}