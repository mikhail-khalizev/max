FUNC_BEGIN(0x10109c90, 0xbce9db470433da45, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb8, 0xc0, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x83, 0x3d, 0x48, 0x4e, 0x1c, 0x10, 0, 0x74, 0x34, 0x66, 0xa1, 0x4c, 0x4e, 0x1c, 0x10, 0x89, 0x45, 0xfc, 0xff, 0x4d, 0xfc, 0x66, 0x83, 0x7d, 0xfc, 0xff, 0x74, 0x21, 0xe8, 0xfb, 0xb4, 0xfc, 0xff, 0x31, 0xd2, 0x88, 0xc2, 0xf, 0xbf, 0x45, 0xfc, 0x6b, 0xc0, 0x13, 0x8b, 0x1d, 0x48, 0x4e, 0x1c, 0x10, 0x1, 0xd8, 0x8b, 0, 0xe8, 0x23, 0x5e, 0xfc, 0xff, 0xeb, 0xd5, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10109c90, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10109c95, 0x5)   calld(sys_check_available_stack_size, 0x5c0b8); /* call 0x10165d52 */
    II(0x10109c9a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10109c9b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10109c9c, 0x1)   pushd(edx);                           /* push edx */
    II(0x10109c9d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10109c9e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10109c9f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10109ca0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10109ca2, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10109ca8, 0x7)   cmp(memd_a32(ds, 0x101c4e48), 0);     /* cmp dword [0x101c4e48], 0x0 */
    II(0x10109caf, 0x2)   jzd(0x10109ce5, 0x34);                /* jz 0x10109ce5 */
    II(0x10109cb1, 0x6)   mov(ax, memw_a32(ds, 0x101c4e4c));    /* mov ax, [0x101c4e4c] */
    II(0x10109cb7, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
l_0x10109cba:
    II(0x10109cba, 0x3)   dec(memd_a32(ss, ebp - 0x4));         /* dec dword [ebp-0x4] */
    II(0x10109cbd, 0x5)   cmp(memw_a32(ss, ebp - 0x4), -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xff */
    II(0x10109cc2, 0x2)   jzd(0x10109ce5, 0x21);                /* jz 0x10109ce5 */
    II(0x10109cc4, 0x5)   calld(0x100d51c4, -0x34b05);          /* call 0x100d51c4 */
    II(0x10109cc9, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10109ccb, 0x2)   mov(dl, al);                          /* mov dl, al */
    II(0x10109ccd, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10109cd1, 0x3)   imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
    II(0x10109cd4, 0x6)   mov(ebx, memd_a32(ds, 0x101c4e48));   /* mov ebx, [0x101c4e48] */
    II(0x10109cda, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x10109cdc, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10109cde, 0x5)   calld(0x100cfb06, -0x3a1dd);          /* call 0x100cfb06 */
    II(0x10109ce3, 0x2)   jmpd(0x10109cba, -0x2b);              /* jmp 0x10109cba */
l_0x10109ce5:
    II(0x10109ce5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10109ce7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10109ce8, 0x1)   popd(edi);                            /* pop edi */
    II(0x10109ce9, 0x1)   popd(esi);                            /* pop esi */
    II(0x10109cea, 0x1)   popd(edx);                            /* pop edx */
    II(0x10109ceb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10109cec, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10109ced, 0x1)   retd();                               /* ret */
FUNC_END

