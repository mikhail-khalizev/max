FUNC_BEGIN(0x100d0a87, 0xf7f74be113fd945b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc1, 0x52, 0x9, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x8b, 0x45, 0xf4, 0xe8, 0x1a, 0x43, 0, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0xc7, 0, 0xb8, 0x5c, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x55, 0xf4, 0x89, 0x42, 0x4, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf4, 0x88, 0x42, 0x8, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100d0a87, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d0a8c, 0x5)   calld(sys_check_available_stack_size, 0x952c1); /* call 0x10165d52 */
    II(0x100d0a91, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d0a92, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d0a93, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d0a94, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d0a95, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d0a97, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100d0a9d, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100d0aa0, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100d0aa3, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x100d0aa6, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100d0aa9, 0x5)   calld(0x100d4dc8, 0x431a);            /* call 0x100d4dc8 */
    II(0x100d0aae, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100d0ab1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100d0ab4, 0x6)   mov(memd_a32(ds, eax), 0x101b5cb8);   /* mov dword [eax], 0x101b5cb8 */
    II(0x100d0aba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d0abd, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100d0ac0, 0x3)   mov(memd_a32(ds, edx + 0x4), eax);    /* mov [edx+0x4], eax */
    II(0x100d0ac3, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100d0ac6, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100d0ac9, 0x3)   mov(memb_a32(ds, edx + 0x8), al);     /* mov [edx+0x8], al */
    II(0x100d0acc, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100d0acf, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100d0ad2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100d0ad5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d0ad7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d0ad8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d0ad9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d0ada, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d0adb, 0x1)   retd();                               /* ret */
FUNC_END

