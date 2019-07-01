FUNC_BEGIN(0x1008a0f8, 0xde4645ac8bb6b71b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0xbc, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x15, 0xcb, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008a0f8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008a0fd, 0x5)   calld(sys_check_available_stack_size, 0xdbc50); /* call 0x10165d52 */
    II(0x1008a102, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a103, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a104, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008a105, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a106, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a107, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a108, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a10a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a110, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008a113, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008a116, 0x5)   calld(0x10076c30, -0x134eb);          /* call 0x10076c30 */
    II(0x1008a11b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008a11e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008a121, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a123, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a124, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a125, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a126, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008a127, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a128, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a129, 0x1)   retd();                               /* ret */
FUNC_END

