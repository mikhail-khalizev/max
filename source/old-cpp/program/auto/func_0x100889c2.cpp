FUNC_BEGIN(0x100889c2, 0xd3b4213ed62db7da, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x86, 0xd3, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0x83, 0xc2, 0x17, 0x8b, 0x45, 0xfc, 0xe8, 0xab, 0xe3, 0xfe, 0xff, 0x84, 0xc0, 0x74, 0xd, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x17, 0xe8, 0x32, 0xdc, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100889c2, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100889c7, 0x5)   calld(sys_check_available_stack_size, 0xdd386); /* call 0x10165d52 */
    II(0x100889cc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100889cd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100889ce, 0x1)   pushd(esi);                           /* push esi */
    II(0x100889cf, 0x1)   pushd(edi);                           /* push edi */
    II(0x100889d0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100889d1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100889d3, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100889d9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100889dc, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100889df, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100889e2, 0x3)   add(edx, 0x17);                       /* add edx, 0x17 */
    II(0x100889e5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100889e8, 0x5)   calld(0x10076d98, -0x11c55);          /* call 0x10076d98 */
    II(0x100889ed, 0x2)   test(al, al);                         /* test al, al */
    II(0x100889ef, 0x2)   jzd(0x100889fe, 0xd);                 /* jz 0x100889fe */
    II(0x100889f1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100889f3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100889f6, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100889f9, 0x5)   calld(0x10076630, -0x123ce);          /* call 0x10076630 */
l_0x100889fe:
    II(0x100889fe, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10088a00, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10088a01, 0x1)   popd(edi);                            /* pop edi */
    II(0x10088a02, 0x1)   popd(esi);                            /* pop esi */
    II(0x10088a03, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10088a04, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10088a05, 0x1)   retd();                               /* ret */
FUNC_END

