FUNC_BEGIN(0x1010e33d, 0xce022c11b1243346, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb, 0x7a, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x11, 0xfe, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x10, 0x83, 0xe8, 0xc, 0x98, 0xe8, 0x41, 0xb1, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0x71, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010e33d, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010e342, 0x5)   calld(sys_check_available_stack_size, 0x57a0b); /* call 0x10165d52 */
    II(0x1010e347, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010e348, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010e349, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010e34a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010e34b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010e34c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010e34d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010e34f, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010e355, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010e358, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010e35b, 0x5)   calld(0x1010e171, -0x1ef);            /* call 0x1010e171 */
    II(0x1010e360, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010e363, 0x4)   mov(ax, memw_a32(ds, eax + 0x10));    /* mov ax, [eax+0x10] */
    II(0x1010e367, 0x3)   sub(eax, 0xc);                        /* sub eax, 0xc */
    II(0x1010e36a, 0x1)   cwde();                               /* cwde */
    II(0x1010e36b, 0x5)   calld(0x101094b1, -0x4ebf);           /* call 0x101094b1 */
    II(0x1010e370, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010e373, 0x5)   calld(0x1010e1e9, -0x18f);            /* call 0x1010e1e9 */
    II(0x1010e378, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010e37a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010e37b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010e37c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010e37d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010e37e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010e37f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010e380, 0x1)   retd();                               /* ret */
FUNC_END

