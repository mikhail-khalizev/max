FUNC_BEGIN(0x100e047c, 0x27605b586757c9f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xcc, 0x58, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x91, 0x67, 0xf9, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e047c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e0481, 0x5)   calld(sys_check_available_stack_size, 0x858cc); /* call 0x10165d52 */
    II(0x100e0486, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0487, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0488, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0489, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e048a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e048b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e048c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e048e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e0494, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e0497, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e049a, 0x5)   calld(0x10076c30, -0x6986f);          /* call 0x10076c30 */
    II(0x100e049f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e04a2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e04a5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e04a7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e04a8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e04a9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e04aa, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e04ab, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e04ac, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e04ad, 0x1)   retd();                               /* ret */
FUNC_END

