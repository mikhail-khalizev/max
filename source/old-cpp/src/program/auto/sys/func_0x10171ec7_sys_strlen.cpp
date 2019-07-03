FUNC_BEGIN(sys_strlen, 0x76944d30536c3a87, 0x20, ({0x51, 0x57, 0x89, 0xc7, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x29, 0xc9, 0x49, 0x31, 0xc0, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x7, 0x89, 0xc8, 0x5f, 0x59, 0xc3}))
    II(0x10171ec7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10171ec8, 0x1)   pushd(edi);                           /* push edi */
    II(0x10171ec9, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x10171ecb, 0x1)   pushd(es);                            /* push es */
    II(0x10171ecc, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x10171ece, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x10171ed0, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x10171ed2, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10171ed3, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10171ed5, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x10171ed7, 0x2)   not_(ecx);                            /* not ecx */
    II(0x10171ed9, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10171eda, 0x1)   popd(es);                             /* pop es */
    II(0x10171edb, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10171edd, 0x1)   popd(edi);                            /* pop edi */
    II(0x10171ede, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10171edf, 0x1)   retd();                               /* ret */
FUNC_END

