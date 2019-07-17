#ifndef OPENMAX_PROGRAM_RAW_PROGRAM_HPP_INCLUDED
#define OPENMAX_PROGRAM_RAW_PROGRAM_HPP_INCLUDED

#include <initializer_list>
#include <boost/preprocessor/cat.hpp>
#include <boost/preprocessor/stringize.hpp>

#include <exo/global.hpp>
#include <exo/memory_space.hpp>


namespace raw_program {


extern const uint_<16> image_load_seg;
extern const uint_<16> pspseg;


uint_<32> add_internal_dyn_func(void (*func)(), uint_<8> mode);
void add_internal_dyn_func(void (*func)(), uint_<8> mode, uint_<32> addr);
void add_internal_dyn_func_if_free(void (*func)(), uint_<8> mode, uint_<32> addr);


class func_info_inserter
{
public:

    func_info_inserter(uint_<32> pc, exo::memory_space_const func_name, void (*func)(),  std::initializer_list<unsigned char> code, uint_<8> mode);
};

// -
#define FUNC_INFO_V4(pc, suffix, mode, ...)         \
    FUNC_INFO_V5(pc, suffix, mode, (__VA_ARGS__))

// -
#define FUNC_INFO_V5(pc, suffix, mode, code)        \
    namespace raw_program {                         \
        using namespace x86;                        \
        using namespace dos;                        \
        void BOOST_PP_CAT(func_, BOOST_PP_CAT(pc, BOOST_PP_CAT(_, suffix))) ();        \
        func_info_inserter BOOST_PP_CAT(func_info_inserter_, BOOST_PP_CAT(pc, BOOST_PP_CAT(_, suffix))) (static_cast<uint_<32>>(pc), BOOST_PP_STRINGIZE(BOOST_PP_CAT(func_, BOOST_PP_CAT(pc, BOOST_PP_CAT(_, suffix)))), BOOST_PP_CAT(func_, BOOST_PP_CAT(pc, BOOST_PP_CAT(_, suffix))), std::initializer_list<unsigned char> code, mode);        \
    } /* namespace raw_program */ \
    void raw_program:: BOOST_PP_CAT(func_, BOOST_PP_CAT(pc, BOOST_PP_CAT(_, suffix)))()


// + RawProgramMain.run_func
#define FUNC_START_V2(pc, mode_)                                \
        uint_<32> func_delta = cs.get_base() + eip - pc;        \
        func_delta = func_delta; /* Чтобы не было warning. */   \
        const uint_<8> mode = mode_;                            \
        check_mode()

// -
#define FUNC_BEGIN(pc, suffix, mode, code)        \
        FUNC_INFO_V5(pc, suffix, mode, code) {    \
        FUNC_START_V2(pc, mode);

// -
#define FUNC_END    }

// - => MethodInfo.Addresses
#define LINK(pc, full_func_name, mode, code)    \
    namespace raw_program {                     \
        using namespace x86;                    \
        using namespace dos;                    \
        void full_func_name();                  \
        func_info_inserter BOOST_PP_CAT(func_info_inserter_, BOOST_PP_CAT(pc, BOOST_PP_CAT(_, full_func_name))) (static_cast<uint_<32>>(pc), BOOST_PP_STRINGIZE(full_func_name), full_func_name, std::initializer_list<unsigned char> code, mode);        \
    } /* namespace raw_program */


// +
#define II(inst_offset, inst_len)                        \
        eip = inst_offset + func_delta - cs.get_base();  \
        eip_next = eip + inst_len;
//        if (cs.get_db() == false
//                && (0xffff < eip || 0xffff < eip_next))
//            throw std::logic_error("Bad eip");


void run_func();

void debug_breakpoint();

void init_x86_dos_prog();


#define CALL(addr, name)    \
        const uint_<32> name = addr;
#define VARIABLE CALL

#include "known_definitions.hpp"

#undef VARIABLE
#undef CALL


} /* namespace raw_program */

#endif /* OPENMAX_PROGRAM_RAW_PROGRAM_HPP_INCLUDED */
