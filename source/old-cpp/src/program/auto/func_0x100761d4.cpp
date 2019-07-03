FUNC_BEGIN(0x100761d4, 0xd78b3a4904e4cfe2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x74, 0xfb, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x7e, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100761d4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100761d9, 0x5)   calld(sys_check_available_stack_size, 0xefb74); /* call 0x10165d52 */
    II(0x100761de, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100761df, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100761e0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100761e1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100761e2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100761e3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100761e4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100761e6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100761ec, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100761ef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100761f2, 0x3)   mov(eax, memd_a32(ds, eax + 0x7e));   /* mov eax, [eax+0x7e] */
    II(0x100761f5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100761f8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100761fb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100761fd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100761fe, 0x1)   popd(edi);                            /* pop edi */
    II(0x100761ff, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076200, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076201, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076202, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076203, 0x1)   retd();                               /* ret */
FUNC_END

