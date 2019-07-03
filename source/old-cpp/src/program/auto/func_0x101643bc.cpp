FUNC_BEGIN(0x101643bc, 0x668ca8ce9bcc03c4, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x8c, 0x19, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xa4, 0x5, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x31, 0x5, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101643bc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101643c1, 0x5)   calld(sys_check_available_stack_size, 0x198c); /* call 0x10165d52 */
    II(0x101643c6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101643c7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101643c8, 0x1)   pushd(edx);                           /* push edx */
    II(0x101643c9, 0x1)   pushd(esi);                           /* push esi */
    II(0x101643ca, 0x1)   pushd(edi);                           /* push edi */
    II(0x101643cb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101643cc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101643ce, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101643d4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101643d7, 0x5)   calld(0x10164980, 0x5a4);             /* call 0x10164980 */
    II(0x101643dc, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x101643df, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101643e2, 0x5)   calld(0x10164918, 0x531);             /* call 0x10164918 */
    II(0x101643e7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101643ea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101643ed, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101643ef, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101643f0, 0x1)   popd(edi);                            /* pop edi */
    II(0x101643f1, 0x1)   popd(esi);                            /* pop esi */
    II(0x101643f2, 0x1)   popd(edx);                            /* pop edx */
    II(0x101643f3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101643f4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101643f5, 0x1)   retd();                               /* ret */
FUNC_END

