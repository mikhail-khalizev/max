FUNC_BEGIN(0x100b49e3, 0x29bb4d31103b4740, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x65, 0x13, 0xb, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0xb9, 0x2, 0, 0, 0, 0x8b, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0xe8, 0xd, 0xfe, 0xff, 0xff, 0x84, 0xc0, 0x75, 0x17, 0xb9, 0x1, 0, 0, 0, 0x8b, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0xe8, 0xf6, 0xfd, 0xff, 0xff, 0x84, 0xc0, 0x74, 0x6, 0xc6, 0x45, 0xf0, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf0, 0, 0x8a, 0x45, 0xf0, 0x88, 0x45, 0xec, 0x8a, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100b49e3, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100b49e8, 0x5)   calld(sys_check_available_stack_size, 0xb1365); /* call 0x10165d52 */
    II(0x100b49ed, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b49ee, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b49ef, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b49f0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b49f1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b49f3, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x100b49f9, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100b49fc, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100b49ff, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x100b4a02, 0x5)   mov(ecx, 0x2);                        /* mov ecx, 0x2 */
//    II(0x100b4a07, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x4));    /* mov ebx, [ebp-0x4] */
//    II(0x100b4a0a, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
//    II(0x100b4a0d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b4a10, 0x5)   calld(0x100b4822, -0x1f3);            /* call 0x100b4822 */
    II(0x100b4a15, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b4a17, 0x2)   jnzd(0x100b4a30, 0x17);               /* jnz 0x100b4a30 */
    II(0x100b4a19, 0x5)   mov(ecx, 0x1);                        /* mov ecx, 0x1 */
    II(0x100b4a1e, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x4));    /* mov ebx, [ebp-0x4] */
    II(0x100b4a21, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100b4a24, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b4a27, 0x5)   calld(0x100b4822, -0x20a);            /* call 0x100b4822 */
    II(0x100b4a2c, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b4a2e, 0x2)   jzd(0x100b4a36, 0x6);                 /* jz 0x100b4a36 */
l_0x100b4a30:
    II(0x100b4a30, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x1);   /* mov byte [ebp-0x10], 0x1 */
    II(0x100b4a34, 0x2)   jmpd(0x100b4a3a, 0x4);                /* jmp 0x100b4a3a */
l_0x100b4a36:
    II(0x100b4a36, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0);     /* mov byte [ebp-0x10], 0x0 */
l_0x100b4a3a:
    II(0x100b4a3a, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x100b4a3d, 0x3)   mov(memb_a32(ss, ebp - 0x14), al);    /* mov [ebp-0x14], al */
//    II(0x100b4a40, 0x3)   mov(al, memb_a32(ss, ebp - 0x14));    /* mov al, [ebp-0x14] */
    II(0x100b4a43, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b4a45, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b4a46, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b4a47, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b4a48, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b4a49, 0x1)   retd();                               /* ret */
FUNC_END

