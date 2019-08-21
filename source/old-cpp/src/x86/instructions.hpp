#ifndef OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED
#define OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED

namespace raw_program {
namespace x86 {


#define jod_func(...)    \
    jmpd_func_if(of == true, __VA_ARGS__)

#define jnod_func(...)   \
    jmpd_func_if(of == false, __VA_ARGS__)

#define jgew_func(...)   \
    jmpw_func_if(sf == of, __VA_ARGS__)

#define jlw_func(...)    \
    jmpw_func_if(sf != of, __VA_ARGS__)

#define jnow(...)   \
    jmpw_if(of == false, __VA_ARGS__)

#define jod(...)    \
    jmpd_if(of == true, __VA_ARGS__)

#define jpd(...)    \
    jmpd_if(pf == true, __VA_ARGS__)


#define loopnzw_a16(...)            \
    if (--cx != 0 && zf == false)   \
        jmpw(__VA_ARGS__)


inline void setl(uint_<8> & d)
{
    if (sf != of)
        d = 1;
    else
        d = 0;
}

//inline void lodsdd_a16()
//{
//    eax = memd_a16(ds, si);
//    si += df ? -4 : 4;
//}
//
//inline void lodsdd_a32()
//{
//    eax = memd_a32(ds, esi);
//    esi += df ? -4 : 4;
//}


inline void insb_a16()
{
    // @todo check permission
    dos::inb(memb_a16(es, di), dx);
    di += df ? -1 : 1;
}


} /* namespace x86 */
} /* namespave raw_program */

#endif /* OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED */
