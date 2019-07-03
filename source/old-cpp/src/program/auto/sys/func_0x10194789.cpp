FUNC_BEGIN(/* sys */ 0x10194789, 0x876c66ea49aed676, 0x20, ({0x53, 0x51, 0x56, 0x57, 0x83, 0xec, 0x8, 0x89, 0xc6, 0x89, 0xd7, 0x80, 0x64, 0x24, 0x4, 0xfe}))
    II(0x10194789, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019478a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019478b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019478c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1019478d, 0x3)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10194790, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10194792, 0x2)   mov(edi, edx);                        /* mov edi, edx */
    II(0x10194794, 0x5)   and_(memb_a32(ss, esp + 0x4), -0x2 /* 0xfe */); /* and byte [esp+0x4], 0xfe */
    II(0x10194799, 0)     jmpd_func(/* sys */ 0x10194799, 0);   /* Принудительное завершение функции. */
FUNC_END

