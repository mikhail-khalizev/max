FUNC_BEGIN(0x100bb097, 0x64924962ce34abbc, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xb1, 0xac, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x66, 0x83, 0x7d, 0xfc, 0x28, 0x74, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x1e, 0x75, 0x2, 0xeb, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x17, 0x75, 0x2, 0xeb, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x18, 0x75, 0x2, 0xeb, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x19, 0x75, 0x2, 0xeb, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x1b, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100bb097, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100bb09c, 0x5)   calld(sys_check_available_stack_size, 0xaacb1); /* call 0x10165d52 */
    II(0x100bb0a1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100bb0a2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100bb0a3, 0x1)   pushd(edx);                           /* push edx */
    II(0x100bb0a4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100bb0a5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100bb0a6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100bb0a7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100bb0a9, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100bb0af, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100bb0b2, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x28);   /* cmp word [ebp-0x4], 0x28 */
    II(0x100bb0b7, 0x2)   jzd(0x100bb0c0, 0x7);                 /* jz 0x100bb0c0 */
    II(0x100bb0b9, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x1e);   /* cmp word [ebp-0x4], 0x1e */
    II(0x100bb0be, 0x2)   jnzd(0x100bb0c2, 0x2);                /* jnz 0x100bb0c2 */
l_0x100bb0c0:
    II(0x100bb0c0, 0x2)   jmpd(0x100bb0c9, 0x7);                /* jmp 0x100bb0c9 */
l_0x100bb0c2:
    II(0x100bb0c2, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x17);   /* cmp word [ebp-0x4], 0x17 */
    II(0x100bb0c7, 0x2)   jnzd(0x100bb0cb, 0x2);                /* jnz 0x100bb0cb */
l_0x100bb0c9:
    II(0x100bb0c9, 0x2)   jmpd(0x100bb0d2, 0x7);                /* jmp 0x100bb0d2 */
l_0x100bb0cb:
    II(0x100bb0cb, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x18);   /* cmp word [ebp-0x4], 0x18 */
    II(0x100bb0d0, 0x2)   jnzd(0x100bb0d4, 0x2);                /* jnz 0x100bb0d4 */
l_0x100bb0d2:
    II(0x100bb0d2, 0x2)   jmpd(0x100bb0db, 0x7);                /* jmp 0x100bb0db */
l_0x100bb0d4:
    II(0x100bb0d4, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x19);   /* cmp word [ebp-0x4], 0x19 */
    II(0x100bb0d9, 0x2)   jnzd(0x100bb0dd, 0x2);                /* jnz 0x100bb0dd */
l_0x100bb0db:
    II(0x100bb0db, 0x2)   jmpd(0x100bb0e4, 0x7);                /* jmp 0x100bb0e4 */
l_0x100bb0dd:
    II(0x100bb0dd, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x1b);   /* cmp word [ebp-0x4], 0x1b */
    II(0x100bb0e2, 0x2)   jnzd(0x100bb0ea, 0x6);                /* jnz 0x100bb0ea */
l_0x100bb0e4:
    II(0x100bb0e4, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100bb0e8, 0x2)   jmpd(0x100bb0ee, 0x4);                /* jmp 0x100bb0ee */
l_0x100bb0ea:
    II(0x100bb0ea, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x100bb0ee:
    II(0x100bb0ee, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100bb0f1, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x100bb0f4, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100bb0f7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100bb0f9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100bb0fa, 0x1)   popd(edi);                            /* pop edi */
    II(0x100bb0fb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100bb0fc, 0x1)   popd(edx);                            /* pop edx */
    II(0x100bb0fd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100bb0fe, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100bb0ff, 0x1)   retd();                               /* ret */
FUNC_END

