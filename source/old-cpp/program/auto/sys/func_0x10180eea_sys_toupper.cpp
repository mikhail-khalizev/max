FUNC_BEGIN(sys_toupper, 0xc5a8ef24d005323f, 0x20, ({0x83, 0xf8, 0x41, 0x7c, 0x8, 0x83, 0xf8, 0x5a, 0x7f, 0x3, 0x83, 0xc0, 0x20, 0xc3}))
    II(0x10180eea, 0x3)   cmp(eax, 0x41);                       /* cmp eax, 0x41 */
    II(0x10180eed, 0x2)   jld(0x10180ef7, 0x8);                 /* jl 0x10180ef7 */
    II(0x10180eef, 0x3)   cmp(eax, 0x5a);                       /* cmp eax, 0x5a */
    II(0x10180ef2, 0x2)   jgd(0x10180ef7, 0x3);                 /* jg 0x10180ef7 */
    II(0x10180ef4, 0x3)   add(eax, 0x20);                       /* add eax, 0x20 */
l_0x10180ef7:
    II(0x10180ef7, 0x1)   retd();                               /* ret */
FUNC_END

