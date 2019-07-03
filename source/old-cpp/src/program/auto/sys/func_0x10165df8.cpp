FUNC_BEGIN(/* sys */ 0x10165df8, 0x5e7703949b20c146, 0x20, ({0x85, 0xc0, 0x7d, 0x2, 0xf7, 0xd8, 0xc3}))
    II(0x10165df8, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10165dfa, 0x2)   jged(0x10165dfe, 0x2);                /* jge 0x10165dfe */
    II(0x10165dfc, 0x2)   neg(eax);                             /* neg eax */
l_0x10165dfe:
    II(0x10165dfe, 0x1)   retd();                               /* ret */
FUNC_END

