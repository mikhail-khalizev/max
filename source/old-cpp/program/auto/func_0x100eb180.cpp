FUNC_BEGIN(0x100eb180, 0x5e337a8337650b2b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc8, 0xab, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1b, 0xe8, 0xcb, 0xcb, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100eb180, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100eb185, 0x5)   calld(sys_check_available_stack_size, 0x7abc8); /* call 0x10165d52 */
    II(0x100eb18a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eb18b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eb18c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100eb18d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eb18e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eb18f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eb190, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eb192, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100eb198, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100eb19b, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100eb19e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100eb1a1, 0x3)   mov(eax, memd_a32(ds, eax + 0x1b));   /* mov eax, [eax+0x1b] */
    II(0x100eb1a4, 0x5)   calld(0x100d7d74, -0x13435);          /* call 0x100d7d74 */
    II(0x100eb1a9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100eb1ab, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100eb1ac, 0x1)   popd(edi);                            /* pop edi */
    II(0x100eb1ad, 0x1)   popd(esi);                            /* pop esi */
    II(0x100eb1ae, 0x1)   popd(edx);                            /* pop edx */
    II(0x100eb1af, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100eb1b0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100eb1b1, 0x1)   retd();                               /* ret */
FUNC_END

