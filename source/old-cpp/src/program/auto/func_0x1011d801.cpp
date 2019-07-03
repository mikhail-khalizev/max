FUNC_BEGIN(0x1011d801, 0x9add9fa1537a5397, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x47, 0x85, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x13, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011d801, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011d806, 0x5)   calld(sys_check_available_stack_size, 0x48547); /* call 0x10165d52 */
    II(0x1011d80b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011d80c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011d80d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011d80e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011d80f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011d810, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011d812, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011d818, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011d81b, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x1011d81e, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1011d821, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1011d824, 0x3)   mov(memb_a32(ds, edx + 0x13), al);    /* mov [edx+0x13], al */
    II(0x1011d827, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011d829, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011d82a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011d82b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011d82c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011d82d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011d82e, 0x1)   retd();                               /* ret */
FUNC_END

