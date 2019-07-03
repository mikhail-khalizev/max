FUNC_BEGIN(0x1010485c, 0x90b75635f9ff43cb, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xec, 0x14, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0x9, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1010485c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10104861, 0x5)   calld(sys_check_available_stack_size, 0x614ec); /* call 0x10165d52 */
    II(0x10104866, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10104867, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10104868, 0x1)   pushd(esi);                           /* push esi */
    II(0x10104869, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010486a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010486b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010486d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10104873, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10104876, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10104879, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1010487c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010487f, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x10104882, 0x5)   calld(0x10104890, 0x9);               /* call 0x10104890 */
    II(0x10104887, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10104889, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010488a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010488b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010488c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010488d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010488e, 0x1)   retd();                               /* ret */
FUNC_END

