FUNC_BEGIN(0x101152c8, 0xd8222d79bf08beb9, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0x54, 0x4e, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x92, 0xfa, 0xfb, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101152c8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101152c9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101152ca, 0x1)   pushd(edx);                           /* push edx */
    II(0x101152cb, 0x1)   pushd(esi);                           /* push esi */
    II(0x101152cc, 0x1)   pushd(edi);                           /* push edi */
    II(0x101152cd, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101152ce, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101152d0, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101152d6, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101152d9, 0x5)   mov(edx, 0x101c4e54);                 /* mov edx, 0x101c4e54 */
//    II(0x101152de, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101152e1, 0x5)   calld(0x100d4d78, -0x4056e);          /* call 0x100d4d78 */
    II(0x101152e6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101152e9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101152eb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101152ec, 0x1)   popd(edi);                            /* pop edi */
    II(0x101152ed, 0x1)   popd(esi);                            /* pop esi */
    II(0x101152ee, 0x1)   popd(edx);                            /* pop edx */
    II(0x101152ef, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101152f0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101152f1, 0x1)   retd();                               /* ret */
FUNC_END

