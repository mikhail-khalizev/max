FUNC_BEGIN(0x10132f1a, 0x2d921a2becc70081, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x2e, 0x2e, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x1d, 0, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x1d, 0, 0x75, 0x33, 0xe8, 0xbe, 0x82, 0x3, 0, 0x89, 0x45, 0xf8, 0x80, 0x3d, 0xd2, 0x37, 0x1c, 0x10, 0, 0x75, 0x6, 0x83, 0x7d, 0xf8, 0x1b, 0x75, 0x7, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x1d, 0x1, 0xe8, 0x2c, 0x21, 0xfa, 0xff, 0x31, 0xd2, 0x88, 0xc2, 0xb8, 0x1, 0, 0, 0, 0xe8, 0xbc, 0xde, 0xfc, 0xff, 0xeb, 0xc4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10132f1a, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10132f1f, 0x5)   calld(sys_check_available_stack_size, 0x32e2e); /* call 0x10165d52 */
    II(0x10132f24, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10132f25, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10132f26, 0x1)   pushd(edx);                           /* push edx */
    II(0x10132f27, 0x1)   pushd(esi);                           /* push esi */
    II(0x10132f28, 0x1)   pushd(edi);                           /* push edi */
    II(0x10132f29, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10132f2a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10132f2c, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10132f32, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10132f35, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10132f38, 0x4)   mov(memb_a32(ds, eax + 0x1d), 0);     /* mov byte [eax+0x1d], 0x0 */
l_0x10132f3c:
    II(0x10132f3c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10132f3f, 0x4)   cmp(memb_a32(ds, eax + 0x1d), 0);     /* cmp byte [eax+0x1d], 0x0 */
    II(0x10132f43, 0x2)   jnzd(0x10132f78, 0x33);               /* jnz 0x10132f78 */
    II(0x10132f45, 0x5)   calld(/* sys */ 0x1016b208, 0x382be); /* call 0x1016b208 */
    II(0x10132f4a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10132f4d, 0x7)   cmp(memb_a32(ds, 0x101c37d2), 0);     /* cmp byte [0x101c37d2], 0x0 */
    II(0x10132f54, 0x2)   jnzd(0x10132f5c, 0x6);                /* jnz 0x10132f5c */
    II(0x10132f56, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0x1b);   /* cmp dword [ebp-0x8], 0x1b */
    II(0x10132f5a, 0x2)   jnzd(0x10132f63, 0x7);                /* jnz 0x10132f63 */
l_0x10132f5c:
    II(0x10132f5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10132f5f, 0x4)   mov(memb_a32(ds, eax + 0x1d), 0x1);   /* mov byte [eax+0x1d], 0x1 */
l_0x10132f63:
    II(0x10132f63, 0x5)   calld(0x100d5094, -0x5ded4);          /* call 0x100d5094 */
    II(0x10132f68, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10132f6a, 0x2)   mov(dl, al);                          /* mov dl, al */
    II(0x10132f6c, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10132f71, 0x5)   calld(0x10100e32, -0x32144);          /* call 0x10100e32 */
    II(0x10132f76, 0x2)   jmpd(0x10132f3c, -0x3c);              /* jmp 0x10132f3c */
l_0x10132f78:
    II(0x10132f78, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10132f7a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10132f7b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10132f7c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10132f7d, 0x1)   popd(edx);                            /* pop edx */
    II(0x10132f7e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10132f7f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10132f80, 0x1)   retd();                               /* ret */
FUNC_END

