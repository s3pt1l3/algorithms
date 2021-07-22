#include <iostream>
#include <vector>

int fib(int pos) 
{
    if (pos < 2) 
    {
        return pos;
    }
    return fib(pos - 2) + fib(pos - 1);
}

int main()
{
    std::cout << fib(4);
}
