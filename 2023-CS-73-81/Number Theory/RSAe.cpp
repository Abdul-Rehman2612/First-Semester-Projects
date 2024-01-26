#include <iostream>
#include <cmath>
using namespace std;

long long gcd(long long phi, long long i);
bool isPrime(long long num);

main()
{
    long long result, e = 0;
    long long c, message, power;
    long long p, q;

    cout << "Enter first prime number 'p' : ";
    cin >> p;

    cout << "Enter second prime number 'q': ";
    cin >> q;
    if (isPrime(p) == false || isPrime(q) == false)
    {
        cout << "Invalid input. Both p and q must be prime numbers." << endl;
        return 1;
    }
    long long n = p * q;
    long long phi = (p - 1) * (q - 1);

    cout << "Enter the value of message: ";
    cin >> message;

    for (long long i = 2; i < phi; i++)
    {
        result = gcd(i, phi);
        if (result == 1)
        {
            e = i;
            break;
        }
    }
    cout << "Public Key (n, e): (" << n << ", " << e << ")" << endl;
    power = 1;
    for (long long i = 0; i < e; i++)
    {
        power = power * message;
    }
    c = power % n;

    cout << "Encrypted Message is : " << c << endl;
}

long long gcd(long long phi, long long i)
{
    while (i != 0)
    {
        long long temp = i;
        i = phi % i;
        phi = temp;
    }
    return phi;
}

bool isPrime(long long num)
{
    int count = 1;
    for (long long i = 2; i <= num; i++)
    {
        if (num % i == 0)
        {
            count++;
        }
    }
    if (count == 2)
    {

        return true;
    }
    else
    {
        return false;
    }
}
