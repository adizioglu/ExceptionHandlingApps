#include <iostream>
#include <stdexcept>
#include <vector>

void BadCall()
{
    std::vector<int> ages = { 1, 3, 5 };

    for (size_t i = 0; i <= ages.size(); ++i)
    {
        try
        {
            std::cout << ages.at(i) << std::endl;
        }
        catch (const std::out_of_range& ex)
        {
            std::cout << "We had an error" << std::endl;
            std::cout << ex.what() << std::endl;
            throw std::runtime_error("There was an error handling our array");
        }
    }
}

int main()
{
    try
    {
        BadCall();
    }
    catch (const std::exception& ex)
    {
        std::cout << "There was an exception thrown in our app" << std::endl;
        std::cout << ex.what() << std::endl;
    }

    std::cin.get();
    return 0;
}
