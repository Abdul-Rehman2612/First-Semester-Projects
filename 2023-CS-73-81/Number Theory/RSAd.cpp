#include <iostream>
#include <cmath>
using namespace std;

long long gcd(long long phi, long long i);
long long modInverse(long long a, long long m);
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
        return 0;
    }
    long long n = p * q;
    long long phi = (p - 1) * (q - 1);

    for (long long i = 2; i < phi; i++)
    {
        result = gcd(i, phi);
        if (result == 1)
        {
            e = i;
            break;
        }
    }
    cout << "Enter the encrypted message: ";
    cin >> message;
    e = 5;
    long long d = modInverse(e, phi);
    cout << "RSA Decryption Key (d): " << d << endl;
    power = 1;
    for (long long i = 0; i < d; i++)
    {
        power = power * message;
    }
    c = power % n;

    cout << "Decrypted Message is : " << c << endl;
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
long long modInverse(long long e, long long phi)
{
    long long M = phi;
    long long t, q;
    long long x = 0, y = 1;
    if (phi == 1)
    {

        return 0;
    }

    while (e > 1)
    {
        q = e / phi;
        t = phi;
        phi = e % phi;
        e = t;

        t = x;
        x = y - q * x;
        y = t;
    }
    return y;
}
