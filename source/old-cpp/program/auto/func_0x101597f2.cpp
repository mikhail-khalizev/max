FUNC_BEGIN(0x101597f2, 0xe9fa2400abb46f65, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x56, 0xc5, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0xb8, 0x1, 0, 0, 0, 0xe8, 0x6d, 0xac, 0xf9, 0xff, 0x8b, 0x45, 0xf4, 0x80, 0x78, 0x57, 0x9, 0x75, 0x9, 0x8b, 0x45, 0xf4, 0xc6, 0x40, 0x57, 0, 0xeb, 0x7, 0x8b, 0x45, 0xf4, 0xc6, 0x40, 0x57, 0x9, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101597f2, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101597f7, 0x5)   calld(sys_check_available_stack_size, 0xc556); /* call 0x10165d52 */
    II(0x101597fc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101597fd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101597fe, 0x1)   pushd(esi);                           /* push esi */
    II(0x101597ff, 0x1)   pushd(edi);                           /* push edi */
    II(0x10159800, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10159801, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10159803, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10159809, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1015980c, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1015980f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10159812, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10159815, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1015981a, 0x5)   calld(0x100f448c, -0x65393);          /* call 0x100f448c */
    II(0x1015981f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10159822, 0x4)   cmp(memb_a32(ds, eax + 0x57), 0x9);   /* cmp byte [eax+0x57], 0x9 */
    II(0x10159826, 0x2)   jnzd(0x10159831, 0x9);                /* jnz 0x10159831 */
    II(0x10159828, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1015982b, 0x4)   mov(memb_a32(ds, eax + 0x57), 0);     /* mov byte [eax+0x57], 0x0 */
    II(0x1015982f, 0x2)   jmpd(0x10159838, 0x7);                /* jmp 0x10159838 */
l_0x10159831:
    II(0x10159831, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10159834, 0x4)   mov(memb_a32(ds, eax + 0x57), 0x9);   /* mov byte [eax+0x57], 0x9 */
l_0x10159838:
    II(0x10159838, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015983a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015983b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015983c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015983d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015983e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015983f, 0x1)   retd();                               /* ret */
FUNC_END

