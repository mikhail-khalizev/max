FUNC_BEGIN(0x10088a08, 0xfce477d7e402ddfe, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x40, 0xd3, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xd4, 0x1a, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x8f, 0xfa, 0x2, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10088a08, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10088a0d, 0x5)   calld(sys_check_available_stack_size, 0xdd340); /* call 0x10165d52 */
    II(0x10088a12, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10088a13, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10088a14, 0x1)   pushd(edx);                           /* push edx */
    II(0x10088a15, 0x1)   pushd(esi);                           /* push esi */
    II(0x10088a16, 0x1)   pushd(edi);                           /* push edi */
    II(0x10088a17, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10088a18, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10088a1a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10088a20, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10088a23, 0x5)   calld(0x1008a4fc, 0x1ad4);            /* call 0x1008a4fc */
    II(0x10088a28, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10088a2b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10088a2e, 0x5)   calld(0x100b84c2, 0x2fa8f);           /* call 0x100b84c2 */
    II(0x10088a33, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10088a36, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10088a39, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10088a3b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10088a3c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10088a3d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10088a3e, 0x1)   popd(edx);                            /* pop edx */
    II(0x10088a3f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10088a40, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10088a41, 0x1)   retd();                               /* ret */
FUNC_END

