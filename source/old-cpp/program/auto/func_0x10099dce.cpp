FUNC_BEGIN(0x10099dce, 0x4880792c24fbfa81, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x7a, 0xbf, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x9e, 0x6, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xd7, 0xc0, 0xc, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10099dce, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10099dd3, 0x5)   calld(sys_check_available_stack_size, 0xcbf7a); /* call 0x10165d52 */
    II(0x10099dd8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10099dd9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10099dda, 0x1)   pushd(esi);                           /* push esi */
    II(0x10099ddb, 0x1)   pushd(edi);                           /* push edi */
    II(0x10099ddc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10099ddd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10099ddf, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10099de5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10099de8, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10099deb, 0x5)   mov(edx, 0x101a069e);                 /* mov edx, 0x101a069e */ /* "Habitat assistant" */
    II(0x10099df0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10099df3, 0x5)   calld(sys_strcpy, 0xcc0d7);           /* call 0x10165ecf */
    II(0x10099df8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10099dfb, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10099dfe, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10099e01, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10099e03, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10099e04, 0x1)   popd(edi);                            /* pop edi */
    II(0x10099e05, 0x1)   popd(esi);                            /* pop esi */
    II(0x10099e06, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10099e07, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10099e08, 0x1)   retd();                               /* ret */
FUNC_END

