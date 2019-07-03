FUNC_BEGIN(0x1011d88c, 0xa7f1e4a5e955d3d0, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xbc, 0x84, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x15, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011d88c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011d891, 0x5)   calld(sys_check_available_stack_size, 0x484bc); /* call 0x10165d52 */
    II(0x1011d896, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011d897, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011d898, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011d899, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011d89a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011d89b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011d89d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011d8a3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011d8a6, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x1011d8a9, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1011d8ac, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1011d8af, 0x3)   mov(memb_a32(ds, edx + 0x15), al);    /* mov [edx+0x15], al */
    II(0x1011d8b2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011d8b4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011d8b5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011d8b6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011d8b7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011d8b8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011d8b9, 0x1)   retd();                               /* ret */
FUNC_END

