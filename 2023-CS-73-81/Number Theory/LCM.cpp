#include <iostream>
#include <cmath>
using namespace std;

int calculateLCM(int number1, int number2, int GCD);
int calculateGCD(int number1, int number2);

main()
{
    int number1;
    int number2;

    cout << "Enter the first number: ";
    cin >> number1;

    cout << "Enter the second number: ";
    cin >> number2;

    int GCD = calculateGCD(number1, number2);
    int LCM = calculateLCM(number1, number2, GCD);
    cout << "LCM: " << LCM;
}
int calculateGCD(int number1, int number2)
{
    int number;

    while (number2 != 0)
    {
        number = number2;
        number2 = number1 % number2;
        number1 = number;
    }
    return number1;
}
int calculateLCM(int number1, int number2, int GCD)
{
    int LCM;
    LCM = (number1 * number2) / GCD;
    return LCM;
}