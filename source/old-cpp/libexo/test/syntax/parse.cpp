#include <stdio.h>
#include <typeinfo>
#include <exo/syntax/general.hpp>

using namespace exo;
using namespace exo::syntax;


static int ret_code = 0;

#define my_assert(ex) \
    if (!(ex)) \
        { \
            printf("line %d\n", __LINE__); \
            ret_code = 1; \
        } \

int main()
{
    {
        auto r1 = string("abc", 1);
        auto r2 = string("azx", 2);
        auto r3 = string("123", 3);
        auto r4 = string("12t", 4);

        auto r_2or3 = r2 | r3 | r4;
        auto r12 = r1 >> r_2or3;


        memory_space_const input = "abcazx";
        auto result = r12.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "abc123";
        result = r12.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "abc125";
        result = r12.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(!result.success);
    }

    {
        auto r1 = string("1");
        auto r2 = string("2");

        auto r_1or2 = r1 | r2;
        auto r_3to5_1or2 = repeat(r_1or2, 3, 5);


        memory_space_const input = "12";
        auto result = r_3to5_1or2.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(!result.success);

        input = "121";
        result = r_3to5_1or2.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "1212";
        result = r_3to5_1or2.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "12121";
        result = r_3to5_1or2.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "121212";
        result = r_3to5_1or2.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == reinterpret_cast<const char*>(input.end()) - 1);
    }

    {
        auto space = string(" ");
        auto spaces = repeat(space);
        auto ignore_ = make_ignore(spaces);

        auto str = string("123");
        auto many_str = repeat(ignore_ >> str);

        auto tmp = ignore_ >> ignore_;
        auto tmp2 = ignore_ | ignore_;
        auto tmp3 = repeat(ignore_);


        memory_space_const input = "123";
        auto result = many_str.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "123123";
        result = many_str.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "   123  123";
        result = many_str.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());

        input = "   123  123123";
        result = many_str.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        printf("'%s': '%s', %p.\n", &input.get<char>(0), result.begin, &result.match);
        my_assert(result.success);
        my_assert(result.begin == input.end());


        auto result1 = tmp.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        auto result2 = tmp2.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
        auto result3 = tmp3.try_parse(&input.get<char>(0), &input.get<char>(0) + input.size());
    }

    return ret_code;
}
