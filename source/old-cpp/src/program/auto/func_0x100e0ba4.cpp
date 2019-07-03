FUNC_BEGIN(0x100e0ba4, 0x89261287a7bf9383, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xa8, 0x35, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xb6, 0x41, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0ba4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0ba5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0ba6, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0ba7, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0ba8, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0ba9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0baa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0bac, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e0bb2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100e0bb5, 0x5)   mov(edx, 0x101c35a8);                 /* mov edx, 0x101c35a8 */
//    II(0x100e0bba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0bbd, 0x5)   calld(0x100d4d78, -0xbe4a);           /* call 0x100d4d78 */
    II(0x100e0bc2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0bc5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0bc7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0bc8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0bc9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0bca, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0bcb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0bcc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0bcd, 0x1)   retd();                               /* ret */
FUNC_END

