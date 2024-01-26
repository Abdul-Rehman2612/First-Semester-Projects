#include <iostream>
using namespace std;

int modularInverseFinder(int, int);
int extendedGCD(int, int, int &, int &);

int main()
{
    int num, modulus;
    cout << "Enter the number: ";
    cin >> num;
    cout << "Enter the modulus: ";
    cin >> modulus;
    cout << "Modulo Inverse: " << modularInverseFinder(num, modulus) << endl;
    return 0;
}
int modularInverseFinder(int number, int mod)
{
    int x, y;
    int gcd = extendedGCD(number, mod, x, y);
    if (gcd != 1)
    {
        cout << "Inverse not exists\n";
        return -1;
    }
    else
    {
        int res = (x % mod + mod) % mod;
        return res;
    }
}
int extendedGCD(int a, int b, int &x, int &y)
{
    if (b == 0)
    {
        x = 1;
        y = 0;
        return a;
    }
    int x1, y1;
    int gcd = extendedGCD(b, a % b, x1, y1);
    x = y1;
    y = x1 - (a / b) * y1;
    return gcd;
}
