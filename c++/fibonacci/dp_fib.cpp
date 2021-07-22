#include <iostream>
#include <vector>

int fib(int pos) 
{
    if (pos < 2) 
    {
        return pos;
    }
    std::vector<int> nums(pos + 1);
    nums[1] = 1;
    for (int i = 2; i < pos + 1; ++i) 
    {
        nums[i] = nums[i - 2] + nums[i - 1];
    }
    return nums[pos];
}

int main()
{
    std::cout << fib(4);
}
