#include <iostream>

int gcd(int a, int b) 
{
    while (a != 0 && b != 0) 
    {
        if (a > b) 
        {
            a = a % b;
        }
        else
        {
            b = b % a;
        }
    }
    if (!(a == 0 && b == 0)) 
    {
        return std::max(a, b);
    }
}

int main()
{
    std::cout << gcd(4, 20);
}
