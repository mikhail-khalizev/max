FUNC_BEGIN(0x100f927b, 0x49ae402ad32ba6b7, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xcd, 0xca, 0x6, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x89, 0x5d, 0xf8, 0x89, 0x4d, 0xfc, 0x8b, 0x45, 0xf0, 0x3b, 0x45, 0xf4, 0x75, 0x40, 0xf, 0xbf, 0x5d, 0xfc, 0xf, 0xbf, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0xe8, 0x97, 0x95, 0xf7, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf0, 0x3b, 0x45, 0xf4, 0x74, 0x6, 0x83, 0x7d, 0xf4, 0, 0x75, 0x2, 0xeb, 0x1b, 0x31, 0xc0, 0xa0, 0xda, 0x37, 0x1c, 0x10, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf4, 0xe8, 0x9b, 0xcd, 0xf7, 0xff, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x75, 0x2, 0xeb, 0x14, 0x31, 0xc0, 0xe8, 0xa1, 0xb1, 0xff, 0xff, 0xe8, 0xd1, 0x62, 0, 0, 0x8b, 0x45, 0xf4, 0xe8, 0x3f, 0x63, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc3}))
    II(0x100f927b, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100f9280, 0x5)   calld(sys_check_available_stack_size, 0x6cacd); /* call 0x10165d52 */
    II(0x100f9285, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f9286, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f9287, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f9288, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f928a, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100f9290, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100f9293, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100f9296, 0x3)   mov(memd_a32(ss, ebp - 0x8), ebx);    /* mov [ebp-0x8], ebx */
    II(0x100f9299, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
//    II(0x100f929c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100f929f, 0x3)   cmp(eax, memd_a32(ss, ebp - 0xc));    /* cmp eax, [ebp-0xc] */
    II(0x100f92a2, 0x2)   jnzd(0x100f92e4, 0x40);               /* jnz 0x100f92e4 */
    II(0x100f92a4, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x100f92a8, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x100f92ac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100f92af, 0x5)   calld(0x1007284b, -0x86a69);          /* call 0x1007284b */
    II(0x100f92b4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100f92b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100f92ba, 0x3)   cmp(eax, memd_a32(ss, ebp - 0xc));    /* cmp eax, [ebp-0xc] */
    II(0x100f92bd, 0x2)   jzd(0x100f92c5, 0x6);                 /* jz 0x100f92c5 */
    II(0x100f92bf, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0);      /* cmp dword [ebp-0xc], 0x0 */
    II(0x100f92c3, 0x2)   jnzd(0x100f92c7, 0x2);                /* jnz 0x100f92c7 */
l_0x100f92c5:
    II(0x100f92c5, 0x2)   jmpd(0x100f92e2, 0x1b);               /* jmp 0x100f92e2 */
l_0x100f92c7:
    II(0x100f92c7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100f92c9, 0x5)   mov(al, memb_a32(ds, 0x101c37da));    /* mov al, [0x101c37da] */
    II(0x100f92ce, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100f92d1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100f92d4, 0x5)   calld(0x10076074, -0x83265);          /* call 0x10076074 */
    II(0x100f92d9, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100f92de, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100f92e0, 0x2)   jnzd(0x100f92e4, 0x2);                /* jnz 0x100f92e4 */
l_0x100f92e2:
    II(0x100f92e2, 0x2)   jmpd(0x100f92f8, 0x14);               /* jmp 0x100f92f8 */
l_0x100f92e4:
    II(0x100f92e4, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100f92e6, 0x5)   calld(0x100f448c, -0x4e5f);           /* call 0x100f448c */
    II(0x100f92eb, 0x5)   calld(0x100ff5c1, 0x62d1);            /* call 0x100ff5c1 */
    II(0x100f92f0, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100f92f3, 0x5)   calld(0x100ff637, 0x633f);            /* call 0x100ff637 */
l_0x100f92f8:
    II(0x100f92f8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100f92fa, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f92fb, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f92fc, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f92fd, 0x1)   retd();                               /* ret */
FUNC_END

