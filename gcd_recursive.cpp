#include <iostream>

int gcd(int a, int b) 
{
    if (a == 0 || b == 0) 
    {
        return std::max(a, b);
    }
    if (a > b) 
    {
        return gcd(a % b, b);
    }
    else 
    {
        return gcd(a, b % a);
    }
}

int main()
{
    std::cout << gcd(4, 20);
}
