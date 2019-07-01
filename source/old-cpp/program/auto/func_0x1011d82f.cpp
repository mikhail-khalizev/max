FUNC_BEGIN(0x1011d82f, 0xe45e13fe06f50336, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x19, 0x85, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x14, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011d82f, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011d834, 0x5)   calld(sys_check_available_stack_size, 0x48519); /* call 0x10165d52 */
    II(0x1011d839, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011d83a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011d83b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011d83c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011d83d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011d83e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011d840, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011d846, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011d849, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x1011d84c, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1011d84f, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1011d852, 0x3)   mov(memb_a32(ds, edx + 0x14), al);    /* mov [edx+0x14], al */
    II(0x1011d855, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011d857, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011d858, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011d859, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011d85a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011d85b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011d85c, 0x1)   retd();                               /* ret */
FUNC_END

