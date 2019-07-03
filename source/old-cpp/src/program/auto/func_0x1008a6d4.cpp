FUNC_BEGIN(0x1008a6d4, 0xbd21213314bd6315, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0xff, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008a6d4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a6d5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a6d6, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008a6d7, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a6d8, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a6d9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a6da, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a6dc, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1008a6e2, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0xffffffff); /* mov dword [ebp-0x4], 0xffffffff */
    II(0x1008a6e9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a6ec, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a6ee, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a6ef, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a6f0, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a6f1, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008a6f2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a6f3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a6f4, 0x1)   retd();                               /* ret */
FUNC_END

