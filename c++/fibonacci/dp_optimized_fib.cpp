#include <iostream>

int fib(int pos) 
{
    if (pos < 2) 
    {
        return pos;
    }
    int a = 0;
    int b = 1;
    for (int i = 2; i < pos + 1; ++i) 
    {
        int c = a + b;
        a = b;
        b = c;
    }
    return b;
}

int main()
{
    std::cout << fib(4);
}
