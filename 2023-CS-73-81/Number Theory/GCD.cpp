#include <iostream>
using namespace std;

int calculateGCD(int number1, int number2);

main()
{
    int number1, number2;

    cout << "Enter the first number: ";
    cin >> number1;

    cout << "Enter the second number: ";
    cin >> number2;

    if (number1 > number2)
    {
        int number = number2;
        number2 = number1;
        number1 = number;
    }

    int GCD = calculateGCD(number1, number2);
    cout << "GCD: " << GCD << endl;
}
int calculateGCD(int number1, int number2)
{
    int number;
    int n;

    while (number2 != 0)
    {
        number = number2;
        number2 = number1 % number2;
        if (number2 > 0)
        {
            n = number / number2;
            cout << number << "=" << number2 << "*" << n << "+" << number - number2 * n << endl;
        }

        number1 = number;
    }

    return number1;
}