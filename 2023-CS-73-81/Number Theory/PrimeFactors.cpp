#include <iostream>
using namespace std;
main()
{
    int num;
    cout << "Enter a number: ";
    cin >> num;
    while (num != 1)
    {
        for (int i = 2; i <= num; i++)
        {
            if (num % i == 0)
            {
                cout << i << " ";
                num = num / i;
                break;
            }
        }
    }
}