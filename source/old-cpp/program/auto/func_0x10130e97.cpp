FUNC_BEGIN(0x10130e97, 0x66c66d12bfb922da, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb1, 0x4e, 0x3, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0xc6, 0x5, 0x8d, 0xb4, 0x1b, 0x10, 0x1, 0x8b, 0x45, 0xf4, 0xe8, 0x3a, 0xe1, 0xff, 0xff, 0x8b, 0x45, 0xf4, 0x80, 0x78, 0x17, 0, 0x74, 0x9, 0x8b, 0x45, 0xf4, 0x80, 0x78, 0x17, 0x1, 0x75, 0xd, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf4, 0xe8, 0x2e, 0xfd, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10130e97, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10130e9c, 0x5)   calld(sys_check_available_stack_size, 0x34eb1); /* call 0x10165d52 */
    II(0x10130ea1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10130ea2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10130ea3, 0x1)   pushd(esi);                           /* push esi */
    II(0x10130ea4, 0x1)   pushd(edi);                           /* push edi */
    II(0x10130ea5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10130ea6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10130ea8, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10130eae, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10130eb1, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10130eb4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10130eb7, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10130eba, 0x7)   mov(memb_a32(ds, 0x101bb48d), 0x1);   /* mov byte [0x101bb48d], 0x1 */
    II(0x10130ec1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10130ec4, 0x5)   calld(0x1012f003, -0x1ec6);           /* call 0x1012f003 */
    II(0x10130ec9, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10130ecc, 0x4)   cmp(memb_a32(ds, eax + 0x17), 0);     /* cmp byte [eax+0x17], 0x0 */
    II(0x10130ed0, 0x2)   jzd(0x10130edb, 0x9);                 /* jz 0x10130edb */
    II(0x10130ed2, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10130ed5, 0x4)   cmp(memb_a32(ds, eax + 0x17), 0x1);   /* cmp byte [eax+0x17], 0x1 */
    II(0x10130ed9, 0x2)   jnzd(0x10130ee8, 0xd);                /* jnz 0x10130ee8 */
l_0x10130edb:
    II(0x10130edb, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x10130ee0, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10130ee3, 0x5)   calld(0x10130c16, -0x2d2);            /* call 0x10130c16 */
l_0x10130ee8:
    II(0x10130ee8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10130eea, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10130eeb, 0x1)   popd(edi);                            /* pop edi */
    II(0x10130eec, 0x1)   popd(esi);                            /* pop esi */
    II(0x10130eed, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10130eee, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10130eef, 0x1)   retd();                               /* ret */
FUNC_END

