FUNC_BEGIN(0x10089e08, 0xd0d177fd9f2b3c02, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x40, 0xbf, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089e08, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089e0d, 0x5)   calld(sys_check_available_stack_size, 0xdbf40); /* call 0x10165d52 */
    II(0x10089e12, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089e13, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089e14, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089e15, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089e16, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089e17, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089e18, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089e1a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089e20, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089e23, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089e26, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10089e28, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089e2b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089e2e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089e30, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089e31, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089e32, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089e33, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089e34, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089e35, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089e36, 0x1)   retd();                               /* ret */
FUNC_END

