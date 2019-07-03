FUNC_BEGIN(/* sys */ 0x10179096, 0x829049dde1fdca94, 0x20, ({0x89, 0xcf, 0x7, 0x89, 0xfa, 0x85, 0xff, 0x74, 0x24, 0x89, 0xe9, 0x89, 0xdf, 0x89, 0xd6, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x31, 0xc0, 0xf3, 0xa6, 0x74, 0x5, 0x19, 0xc0, 0x83, 0xd8, 0xff, 0x7, 0x85, 0xc0, 0x75, 0x4, 0x89, 0xd0, 0xeb, 0x7, 0x8d, 0x72, 0x1, 0xeb, 0xb8, 0x31, 0xc0}))
    II(0x10179096, 0x2)   mov(edi, ecx);                        /* mov edi, ecx */
    II(0x10179098, 0x1)   popd(es);                             /* pop es */
    II(0x10179099, 0x2)   mov(edx, edi);                        /* mov edx, edi */
    II(0x1017909b, 0x2)   test(edi, edi);                       /* test edi, edi */
    II(0x1017909d, 0x2)   jzd(0x101790c3, 0x24);                /* jz 0x101790c3 */
    II(0x1017909f, 0x2)   mov(ecx, ebp);                        /* mov ecx, ebp */
    II(0x101790a1, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x101790a3, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x101790a5, 0x1)   pushd(es);                            /* push es */
    II(0x101790a6, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x101790a8, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x101790aa, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101790ac, 0x2)   repe_a32 cmpsb_a32();                 /* rep cmpsb */
    II(0x101790ae, 0x2)   jzd(0x101790b5, 0x5);                 /* jz 0x101790b5 */
    II(0x101790b0, 0x2)   sbb(eax, eax);                        /* sbb eax, eax */
    II(0x101790b2, 0x3)   sbb(eax, -0x1 /* 0xff */);            /* sbb eax, 0xff */
l_0x101790b5:
    II(0x101790b5, 0x1)   popd(es);                             /* pop es */
    II(0x101790b6, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101790b8, 0x2)   jnzd(0x101790be, 0x4);                /* jnz 0x101790be */
    II(0x101790ba, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x101790bc, 0x2)   jmpd_func(0x101790c5, 0x7);           /* jmp 0x101790c5 */
l_0x101790be:
    II(0x101790be, 0x3)   lea(esi, edx + 0x1);                  /* lea esi, [edx+0x1] */
    II(0x101790c1, 0x2)   jmpd_func(0x1017907b, -0x48);         /* jmp 0x1017907b */
l_0x101790c3:
    II(0x101790c3, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101790c5, 0)     jmpd_func(/* sys */ 0x101790c5, 0);   /* Принудительное завершение функции. */
FUNC_END

