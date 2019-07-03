#include <iostream>
#include <initializer_list>
#include <exo/global.hpp>
#include <exo/util/used_space.hpp>

using exo::util::used_space;


template<typename US>
void print_u(US & u)
{
    std::cout << "used_space: ";
    for (auto i = u.begin(); i != u.end(); i++)
        std::cout << "{" <<  i.get_begin() << ", " << i.get_end() << "} ";
    std::cout << std::endl;
}

template<typename T>
void print_s(std::initializer_list<T> & s)
{
    std::cout << "checked array: ";
    for (size_t i = 0; i < s.size(); i += 2)
        std::cout << "{" <<  s.begin()[i] << ", " << s.begin()[i + 1] << "} ";
    std::cout << std::endl;
}

static void print_s()
{
    std::cout << "checked array: " << std::endl;
}


template<typename US, typename T>
void print(US & u, std::initializer_list<T> & s)
{
    print_u(u);
    print_s(s);
    std::cout << std::endl;
}

template<typename US>
void print(US & u)
{
    print_u(u);
    print_s();
    std::cout << std::endl;
}


template<typename US, typename T>
void must_be(US & u, std::initializer_list<T> s)
{
    print(u, s);

    bool ok = true;

    if (2 * u.size() != s.size())
        ok = false;

    if (ok)
    {
        size_t index = 0;
        for (auto i = u.begin(); i != u.end(); i++, index += 2)
            if (i.get_begin() != s.begin()[index] ||
                    i.get_end() != s.begin()[index + 1])
            {
                ok = false;
                break;
            }
    }


    if (ok)
        return;

    throw std::runtime_error("Check fail.");
}

template<typename US>
void must_be(US & u)
{
    print(u);

    if (u.size() != 0)
        throw std::runtime_error("Check fail.");
}


int main()
{
    used_space<int> tst1;

    must_be(tst1);

    tst1.add(5, 6);
    must_be(tst1, {5, 6});

    tst1.add(7, 8);
    must_be(tst1, {5, 6, 7, 8});

    tst1.add(6, 7);
    must_be(tst1, {5, 8});

    tst1.add(4, 9);
    must_be(tst1, {4, 9});


    tst1.add(12, 13);
    must_be(tst1, {4, 9, 12, 13});

    tst1.add(10, 11);
    must_be(tst1, {4, 9, 10, 11, 12, 13});

    tst1.add(14, 15);
    must_be(tst1, {4, 9, 10, 11, 12, 13, 14, 15});

    tst1.add(6, 13);
    must_be(tst1, {4, 13, 14, 15});

    tst1.add(3, 16);
    must_be(tst1, {3, 16});


    used_space<uint_<32>> tst2;
    tst2.add(5, 6);

    return 0;
}

