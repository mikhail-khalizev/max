FUNC_BEGIN(0x100e0bd0, 0xc5f4bc7e81a1b050, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xa8, 0x35, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x8a, 0x41, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0bd0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0bd1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0bd2, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0bd3, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0bd4, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0bd5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0bd6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0bd8, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e0bde, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100e0be1, 0x5)   mov(edx, 0x101c35a8);                 /* mov edx, 0x101c35a8 */
//    II(0x100e0be6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0be9, 0x5)   calld(0x100d4d78, -0xbe76);           /* call 0x100d4d78 */
    II(0x100e0bee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0bf1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0bf3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0bf4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0bf5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0bf6, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0bf7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0bf8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0bf9, 0x1)   retd();                               /* ret */
FUNC_END

