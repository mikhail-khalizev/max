FUNC_BEGIN(0x100f1a86, 0xd204f49a7c1731b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc2, 0x42, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x88, 0x45, 0xfc, 0x31, 0xd2, 0x8a, 0x55, 0xfc, 0xb8, 0x90, 0x39, 0x1c, 0x10, 0xe8, 0x4, 0xfa, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100f1a86, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100f1a8b, 0x5)   calld(sys_check_available_stack_size, 0x742c2); /* call 0x10165d52 */
    II(0x100f1a90, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f1a91, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f1a92, 0x1)   pushd(edx);                           /* push edx */
    II(0x100f1a93, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f1a94, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f1a95, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f1a96, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f1a98, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100f1a9e, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
    II(0x100f1aa1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f1aa3, 0x3)   mov(dl, memb_a32(ss, ebp - 0x4));     /* mov dl, [ebp-0x4] */
    II(0x100f1aa6, 0x5)   mov(eax, 0x101c3990);                 /* mov eax, 0x101c3990 */
    II(0x100f1aab, 0x5)   calld(0x100f14b4, -0x5fc);            /* call 0x100f14b4 */
    II(0x100f1ab0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100f1ab2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f1ab3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f1ab4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f1ab5, 0x1)   popd(edx);                            /* pop edx */
    II(0x100f1ab6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f1ab7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f1ab8, 0x1)   retd();                               /* ret */
FUNC_END

