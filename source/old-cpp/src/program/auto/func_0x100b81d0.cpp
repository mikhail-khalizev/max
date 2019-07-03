FUNC_BEGIN(0x100b81d0, 0xa685b4b6c07dae62, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x78, 0xdb, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x3d, 0xea, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b81d0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b81d5, 0x5)   calld(sys_check_available_stack_size, 0xadb78); /* call 0x10165d52 */
    II(0x100b81da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b81db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b81dc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b81dd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b81de, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b81df, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b81e0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b81e2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b81e8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b81eb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b81ee, 0x5)   calld(0x10076c30, -0x415c3);          /* call 0x10076c30 */
    II(0x100b81f3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b81f6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b81f9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b81fb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b81fc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b81fd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b81fe, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b81ff, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8200, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8201, 0x1)   retd();                               /* ret */
FUNC_END

