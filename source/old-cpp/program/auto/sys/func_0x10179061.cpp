FUNC_BEGIN(/* sys */ 0x10179061, 0x13be7ddc30760599, 0x20, ({0x89, 0xcf, 0x7, 0x89, 0x3c, 0x24, 0x89, 0xdf, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x29, 0xc9, 0x49, 0x31, 0xc0, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x7, 0x89, 0xcd}))
    II(0x10179061, 0x2)   mov(edi, ecx);                        /* mov edi, ecx */
    II(0x10179063, 0x1)   popd(es);                             /* pop es */
    II(0x10179064, 0x3)   mov(memd_a32(ss, esp), edi);          /* mov [esp], edi */
    II(0x10179067, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x10179069, 0x1)   pushd(es);                            /* push es */
    II(0x1017906a, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x1017906c, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x1017906e, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x10179070, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10179071, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10179073, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x10179075, 0x2)   not_(ecx);                            /* not ecx */
    II(0x10179077, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10179078, 0x1)   popd(es);                             /* pop es */
    II(0x10179079, 0x2)   mov(ebp, ecx);                        /* mov ebp, ecx */
    II(0x1017907b, 0)     jmpd_func(/* sys */ 0x1017907b, 0);   /* Принудительное завершение функции. */
FUNC_END

