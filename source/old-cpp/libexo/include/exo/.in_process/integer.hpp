#ifndef EXO__IN_PROCESS_INTEGER_HPP_INCLUDED
#define EXO__IN_PROCESS_INTEGER_HPP_INCLUDED

// #include <exo/integer_s.hpp>
// #include <exo/integer_u.hpp>

namespace exo {

/** @todo Переписать в более совершенном виде:
 *
 * Один единый класс uint<min = 0, max>.
 * uint<1, 5> + uint<4, 6> -> uint<5, 11>
 *
 * Необходимое кол-во бит: bit_num = log2_upper(max - min + 1)
 * Нормализация:
 *   1) в битовом представлении значению 0 из интервала int<0, 'любое'> соответствуют все нули.
 *   2) в битовом представлении  значение X из заданного интервала <min, max>  равно  значению X % (2 ^ bit_num) из интервала int<0, 2 ^ bit_num - 1>.
 *
 * Пример: uint<10, 15>. Занимает 3 бита. Значению 10 соответствует '010b'.
 * Пример: uint<-20, -5>. Занимает 4 бита. Значению -5 соответствует '1011b'.
 */


template<abstract_int min_, abstract_int max_>
class uint
{
    /* @todo Заменить int на соответствующий тип.*/
    typedef int sign_type;
    typedef unsigned int unsign_type;

    sign_type val;


    /* @todo В отдельный файл вместе с abstract_int. */
    template<abstract_int val_>
    struct math1
    {
        static constexpr abstract_int log2_upper() throw()
        {
            static_assert(0 <= val_, "Input value must be not negative.");
            static_assert(val_ <= 256, "Not implement.");

            return
                    (val_ <= 2) ? 1 :
                    (val_ <= 4) ? 2 :
                    (val_ <= 8) ? 3 :
                    (val_ <= 16) ? 4 :
                    (val_ <= 32) ? 5 :
                    (val_ <= 64) ? 6 :
                    (val_ <= 128) ? 7 :
                    (val_ <= 256) ? 8 : 0;
        }
    };

    template<abstract_int x1, abstract_int x2>
    struct math2
    {
        static constexpr abstract_int max() throw()
        {
            return x1 < x2 ? x2 : x1;
        }

        static constexpr abstract_int min() throw()
        {
            return x1 < x2 ? x1 : x2;
        }
    };


public:

    static constexpr abstract_int bits() throw()
    {
        // @todo В конструктор static_assert.
        static_assert(min_ <= max_, "Min must be less or equal Max.");
        return math1<max_ - min_ + 1>::log2_upper();
    }

    static constexpr abstract_int max() throw()
    {
        return max_;
    }

    static constexpr abstract_int min() throw()
    {
        return min_;
    }

private:

    static constexpr abstract_int frame_len() throw()
    {
        return 1 << bits();
    }

    static constexpr abstract_int first_frame_num() throw()
    {
        return 0 <= min() ?
                min() / frame_len() :
                -((-min() - 1) / frame_len()) - 1;
    }

    static constexpr abstract_int first_frame_val() throw()
    {
        return first_frame_num() * frame_len();
    }

public:

    template<abstract_int min1, abstract_int max1, abstract_int min2, abstract_int max2>
    friend uint<min1 + min2, max1 + max2> operator+(uint<min1, max1> x, uint<min2, max2> y) throw();

    template<abstract_int min1, abstract_int max1, abstract_int min2, abstract_int max2>
    friend uint<min1 - max2, max1 - min2> operator-(uint<min1, max1> x, uint<min2, max2> y) throw();
//
//    template<int bits1, int bits2>
//    friend uint<bits1 + bits2> operator*(uint<bits1> a, uint<bits2> b) throw();
//
//    template<int bits1, int bits2>
//    friend uint<bits1 < bits2 ? bits2 : bits1> operator/(uint<bits1> a, uint<bits2> b);

    friend void internal_check();
};

template<abstract_int min1, abstract_int max1, abstract_int min2, abstract_int max2>
uint<min1 + min2, max1 + max2> operator+(uint<min1, max1> x, uint<min2, max2> y) throw()
{
    typedef uint<min1 + min2, max1 + max2> ret_type;


}

} /* namespace exo */

#endif /* EXO__IN_PROCESS_INTEGER_HPP_INCLUDED */

