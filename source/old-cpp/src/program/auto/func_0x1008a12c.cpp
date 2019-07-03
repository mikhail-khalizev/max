FUNC_BEGIN(0x1008a12c, 0xd5bf12e7778564c6, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x1c, 0xbc, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xe1, 0xca, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008a12c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a131, 0x5)   calld(sys_check_available_stack_size, 0xdbc1c); /* call 0x10165d52 */
    II(0x1008a136, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a137, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a138, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008a139, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a13a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a13b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a13c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a13e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a144, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008a147, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a14a, 0x5)   calld(0x10076c30, -0x1351f);          /* call 0x10076c30 */
    II(0x1008a14f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008a152, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a155, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a157, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a158, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a159, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a15a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008a15b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a15c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a15d, 0x1)   retd();                               /* ret */
FUNC_END

