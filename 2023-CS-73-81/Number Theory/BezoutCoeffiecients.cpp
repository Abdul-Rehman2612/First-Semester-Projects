#include <iostream>
using namespace std;

int extendedGCDForBezouts(int, int, int &, int &);

int main()
{
    int num1, num2;
    cout << "Enter first number: ";
    cin >> num1;
    cout << "Enter second number: ";
    cin >> num2;
    int bezout1 = num1, bezout2 = num2;
    cout << "Result GCD: " << extendedGCDForBezouts(num1, num2, bezout1, bezout2) << endl;
    cout << "Bezout Identity One: " << bezout1 << endl;
    cout << "Bezout Idnetity Two: " << bezout2;
    return 0;
}
int extendedGCDForBezouts(int num1, int num2, int &bezout1, int &bezout2)
{
    if (num2 == 0)
    {
        bezout1 = 1;
        bezout2 = 0;
        return num1;
    }
    int gcdResult = extendedGCDForBezouts(num2, num1 % num2, bezout1, bezout2);
    int temp = bezout2;
    bezout2 = bezout1 - (num1 / num2) * bezout2;
    bezout1 = temp;
    return gcdResult;
}