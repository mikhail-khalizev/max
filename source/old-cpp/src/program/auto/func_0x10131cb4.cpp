FUNC_BEGIN(0x10131cb4, 0x351b5dee159e40c4, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0x78, 0x36, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xa6, 0x30, 0xfa, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10131cb4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10131cb5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10131cb6, 0x1)   pushd(edx);                           /* push edx */
    II(0x10131cb7, 0x1)   pushd(esi);                           /* push esi */
    II(0x10131cb8, 0x1)   pushd(edi);                           /* push edi */
    II(0x10131cb9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10131cba, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10131cbc, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10131cc2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10131cc5, 0x5)   mov(edx, 0x101c3678);                 /* mov edx, 0x101c3678 */
//    II(0x10131cca, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10131ccd, 0x5)   calld(0x100d4d78, -0x5cf5a);          /* call 0x100d4d78 */
    II(0x10131cd2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10131cd5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10131cd7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10131cd8, 0x1)   popd(edi);                            /* pop edi */
    II(0x10131cd9, 0x1)   popd(esi);                            /* pop esi */
    II(0x10131cda, 0x1)   popd(edx);                            /* pop edx */
    II(0x10131cdb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10131cdc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10131cdd, 0x1)   retd();                               /* ret */
FUNC_END

