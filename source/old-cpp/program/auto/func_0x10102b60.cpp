FUNC_BEGIN(0x10102b60, 0x9ffb2b69932e6995, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10102b60, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10102b61, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10102b62, 0x1)   pushd(edx);                           /* push edx */
    II(0x10102b63, 0x1)   pushd(esi);                           /* push esi */
    II(0x10102b64, 0x1)   pushd(edi);                           /* push edi */
    II(0x10102b65, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10102b66, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10102b68, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10102b6e, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x10102b75, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10102b78, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10102b7a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10102b7b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10102b7c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10102b7d, 0x1)   popd(edx);                            /* pop edx */
    II(0x10102b7e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10102b7f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10102b80, 0x1)   retd();                               /* ret */
FUNC_END

