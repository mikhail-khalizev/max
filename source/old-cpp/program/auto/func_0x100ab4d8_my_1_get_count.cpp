FUNC_BEGIN(my_1_get_count, 0xc89097cc6311c9d2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x70, 0xa8, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ab4d8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ab4dd, 0x5)   calld(sys_check_available_stack_size, 0xba870); /* call 0x10165d52 */
    II(0x100ab4e2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ab4e3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ab4e4, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ab4e5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ab4e6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ab4e7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ab4e8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ab4ea, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ab4f0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100ab4f3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ab4f6, 0x4)   mov(ax, memw_a32(ds, eax + 0x4));     /* mov ax, [eax+0x4] */
    II(0x100ab4fa, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ab4fd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ab500, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ab502, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ab503, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ab504, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ab505, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ab506, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ab507, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ab508, 0x1)   retd();                               /* ret */
FUNC_END

