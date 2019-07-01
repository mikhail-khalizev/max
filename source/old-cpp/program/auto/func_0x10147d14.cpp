FUNC_BEGIN(0x10147d14, 0x8420a2f9856282d1, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x34, 0xe0, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xf9, 0xee, 0xf2, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10147d14, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10147d19, 0x5)   calld(sys_check_available_stack_size, 0x1e034); /* call 0x10165d52 */
    II(0x10147d1e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10147d1f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10147d20, 0x1)   pushd(edx);                           /* push edx */
    II(0x10147d21, 0x1)   pushd(esi);                           /* push esi */
    II(0x10147d22, 0x1)   pushd(edi);                           /* push edi */
    II(0x10147d23, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10147d24, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10147d26, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10147d2c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10147d2f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10147d32, 0x5)   calld(0x10076c30, -0xd1107);          /* call 0x10076c30 */
    II(0x10147d37, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10147d3a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10147d3d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10147d3f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10147d40, 0x1)   popd(edi);                            /* pop edi */
    II(0x10147d41, 0x1)   popd(esi);                            /* pop esi */
    II(0x10147d42, 0x1)   popd(edx);                            /* pop edx */
    II(0x10147d43, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10147d44, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10147d45, 0x1)   retd();                               /* ret */
FUNC_END

