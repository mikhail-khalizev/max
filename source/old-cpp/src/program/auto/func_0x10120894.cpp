FUNC_BEGIN(0x10120894, 0x352f9d24206580fd, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb4, 0x54, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xa1, 0x62, 0xf5, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10120894, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10120899, 0x5)   calld(sys_check_available_stack_size, 0x454b4); /* call 0x10165d52 */
    II(0x1012089e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012089f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101208a0, 0x1)   pushd(edx);                           /* push edx */
    II(0x101208a1, 0x1)   pushd(esi);                           /* push esi */
    II(0x101208a2, 0x1)   pushd(edi);                           /* push edi */
    II(0x101208a3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101208a4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101208a6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101208ac, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101208af, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101208b2, 0x5)   calld(0x10076b58, -0xa9d5f);          /* call 0x10076b58 */
    II(0x101208b7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101208ba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101208bd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101208bf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101208c0, 0x1)   popd(edi);                            /* pop edi */
    II(0x101208c1, 0x1)   popd(esi);                            /* pop esi */
    II(0x101208c2, 0x1)   popd(edx);                            /* pop edx */
    II(0x101208c3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101208c4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101208c5, 0x1)   retd();                               /* ret */
FUNC_END

