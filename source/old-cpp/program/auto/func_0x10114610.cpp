FUNC_BEGIN(0x10114610, 0x9dd71658878f862b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x38, 0x17, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x56, 0xf5, 0xff, 0xff, 0x31, 0xc0, 0xe8, 0x77, 0x4e, 0xff, 0xff, 0xf, 0xbf, 0xd0, 0xb8, 0x33, 0, 0, 0, 0xe8, 0xb5, 0x64, 0xfb, 0xff, 0xb8, 0x33, 0, 0, 0, 0xe8, 0x8b, 0x19, 0xf6, 0xff, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0xbd, 0xfa, 0xff, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x64, 0xf4, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10114610, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10114615, 0x5)   calld(sys_check_available_stack_size, 0x51738); /* call 0x10165d52 */
    II(0x1011461a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011461b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011461c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011461d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011461e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011461f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10114620, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10114622, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10114628, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1011462b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011462e, 0x5)   calld(0x10113b89, -0xaaa);            /* call 0x10113b89 */
    II(0x10114633, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10114635, 0x5)   calld(0x101094b1, -0xb189);           /* call 0x101094b1 */
    II(0x1011463a, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x1011463d, 0x5)   mov(eax, 0x33);                       /* mov eax, 0x33 */
    II(0x10114642, 0x5)   calld(0x100caafc, -0x49b4b);          /* call 0x100caafc */
    II(0x10114647, 0x5)   mov(eax, 0x33);                       /* mov eax, 0x33 */
    II(0x1011464c, 0x5)   calld(0x10075fdc, -0x9e675);          /* call 0x10075fdc */
    II(0x10114651, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10114654, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114657, 0x5)   calld(0x10114119, -0x543);            /* call 0x10114119 */
    II(0x1011465c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011465e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114661, 0x5)   calld(0x10113aca, -0xb9c);            /* call 0x10113aca */
    II(0x10114666, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10114668, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10114669, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011466a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011466b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011466c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011466d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011466e, 0x1)   retd();                               /* ret */
FUNC_END

