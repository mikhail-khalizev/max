FUNC_BEGIN(0x100a8bbd, 0xff5a195c11de6d40, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x8b, 0xd1, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x31, 0xc0, 0xa0, 0xc9, 0x37, 0x1c, 0x10, 0x85, 0xc0, 0xf, 0x84, 0xc6, 0, 0, 0, 0x80, 0x3d, 0x1e, 0x39, 0x1c, 0x10, 0x9, 0x74, 0xd, 0x80, 0x3d, 0x1e, 0x39, 0x1c, 0x10, 0x8, 0xf, 0x85, 0xae, 0, 0, 0, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xfc, 0xff, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x83, 0xf8, 0x4, 0x7d, 0x4f, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x80, 0xb8, 0x91, 0xa4, 0x1c, 0x10, 0, 0x75, 0x1a, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x74, 0x2, 0xeb, 0x1e, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0xc5, 0, 0, 0, 0xba, 0xc4, 0x31, 0x1c, 0x10, 0x1, 0xd0, 0xe8, 0xdf, 0x57, 0x1, 0, 0x84, 0xc0, 0xf, 0x85, 0xa4, 0, 0, 0, 0xeb, 0xa2, 0x80, 0x3d, 0x1e, 0x39, 0x1c, 0x10, 0x8, 0x75, 0x1d, 0x31, 0xc0, 0xa0, 0xda, 0x37, 0x1c, 0x10, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x74, 0x2, 0xeb, 0x16, 0x31, 0xc0, 0xa0, 0xda, 0x37, 0x1c, 0x10, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x80, 0xb8, 0x91, 0xa4, 0x1c, 0x10, 0, 0x75, 0x2, 0xeb, 0x7, 0xc6, 0x5, 0x1e, 0x39, 0x1c, 0x10, 0x9, 0xeb, 0x59, 0x80, 0x3d, 0x1e, 0x39, 0x1c, 0x10, 0x8, 0x75, 0x50, 0x31, 0xc0, 0xa0, 0xc8, 0x37, 0x1c, 0x10, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x75, 0x16, 0x31, 0xc0, 0xa0, 0xc8, 0x37, 0x1c, 0x10, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x80, 0xb8, 0x91, 0xa4, 0x1c, 0x10, 0, 0x74, 0x2, 0xeb, 0x1b, 0x31, 0xc0, 0xa0, 0xc8, 0x37, 0x1c, 0x10, 0x69, 0xc0, 0xc5, 0, 0, 0, 0xba, 0xc4, 0x31, 0x1c, 0x10, 0x1, 0xd0, 0xe8, 0x35, 0x57, 0x1, 0, 0x84, 0xc0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a8bbd, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a8bc2, 0x5)   calld(sys_check_available_stack_size, 0xbd18b); /* call 0x10165d52 */
    II(0x100a8bc7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a8bc8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a8bc9, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a8bca, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a8bcb, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a8bcc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a8bcd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a8bcf, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100a8bd5, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a8bd7, 0x5)   mov(al, memb_a32(ds, 0x101c37c9));    /* mov al, [0x101c37c9] */
    II(0x100a8bdc, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100a8bde, 0x6)   jzd(0x100a8caa, 0xc6);                /* jz dword 0x100a8caa */
    II(0x100a8be4, 0x7)   cmp(memb_a32(ds, 0x101c391e), 0x9);   /* cmp byte [0x101c391e], 0x9 */
    II(0x100a8beb, 0x2)   jzd(0x100a8bfa, 0xd);                 /* jz 0x100a8bfa */
    II(0x100a8bed, 0x7)   cmp(memb_a32(ds, 0x101c391e), 0x8);   /* cmp byte [0x101c391e], 0x8 */
    II(0x100a8bf4, 0x6)   jnzd(0x100a8ca8, 0xae);               /* jnz dword 0x100a8ca8 */
l_0x100a8bfa:
    II(0x100a8bfa, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x100a8c01, 0x2)   jmpd(0x100a8c09, 0x6);                /* jmp 0x100a8c09 */
l_0x100a8c03:
    II(0x100a8c03, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100a8c06, 0x3)   inc(memd_a32(ss, ebp - 0x4));         /* inc dword [ebp-0x4] */
l_0x100a8c09:
    II(0x100a8c09, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100a8c0d, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x100a8c10, 0x2)   jged(0x100a8c61, 0x4f);               /* jge 0x100a8c61 */
    II(0x100a8c12, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100a8c16, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a8c1c, 0x7)   cmp(memb_a32(ds, eax + 0x101ca491), 0); /* cmp byte [eax+0x101ca491], 0x0 */
    II(0x100a8c23, 0x2)   jnzd(0x100a8c3f, 0x1a);               /* jnz 0x100a8c3f */
    II(0x100a8c25, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100a8c29, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a8c2f, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x100a8c35, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100a8c3a, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x100a8c3d, 0x2)   jzd(0x100a8c41, 0x2);                 /* jz 0x100a8c41 */
l_0x100a8c3f:
    II(0x100a8c3f, 0x2)   jmpd(0x100a8c5f, 0x1e);               /* jmp 0x100a8c5f */
l_0x100a8c41:
    II(0x100a8c41, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100a8c45, 0x6)   imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
    II(0x100a8c4b, 0x5)   mov(edx, 0x101c31c4);                 /* mov edx, 0x101c31c4 */
    II(0x100a8c50, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x100a8c52, 0x5)   calld(0x100be436, 0x157df);           /* call 0x100be436 */
    II(0x100a8c57, 0x2)   test(al, al);                         /* test al, al */
    II(0x100a8c59, 0x6)   jnzd(0x100a8d03, 0xa4);               /* jnz dword 0x100a8d03 */
l_0x100a8c5f:
    II(0x100a8c5f, 0x2)   jmpd(0x100a8c03, -0x5e);              /* jmp 0x100a8c03 */
l_0x100a8c61:
    II(0x100a8c61, 0x7)   cmp(memb_a32(ds, 0x101c391e), 0x8);   /* cmp byte [0x101c391e], 0x8 */
    II(0x100a8c68, 0x2)   jnzd(0x100a8c87, 0x1d);               /* jnz 0x100a8c87 */
    II(0x100a8c6a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a8c6c, 0x5)   mov(al, memb_a32(ds, 0x101c37da));    /* mov al, [0x101c37da] */
    II(0x100a8c71, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a8c77, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x100a8c7d, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100a8c82, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x100a8c85, 0x2)   jzd(0x100a8c89, 0x2);                 /* jz 0x100a8c89 */
l_0x100a8c87:
    II(0x100a8c87, 0x2)   jmpd(0x100a8c9f, 0x16);               /* jmp 0x100a8c9f */
l_0x100a8c89:
    II(0x100a8c89, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a8c8b, 0x5)   mov(al, memb_a32(ds, 0x101c37da));    /* mov al, [0x101c37da] */
    II(0x100a8c90, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a8c96, 0x7)   cmp(memb_a32(ds, eax + 0x101ca491), 0); /* cmp byte [eax+0x101ca491], 0x0 */
    II(0x100a8c9d, 0x2)   jnzd(0x100a8ca1, 0x2);                /* jnz 0x100a8ca1 */
l_0x100a8c9f:
    II(0x100a8c9f, 0x2)   jmpd(0x100a8ca8, 0x7);                /* jmp 0x100a8ca8 */
l_0x100a8ca1:
    II(0x100a8ca1, 0x7)   mov(memb_a32(ds, 0x101c391e), 0x9);   /* mov byte [0x101c391e], 0x9 */
l_0x100a8ca8:
    II(0x100a8ca8, 0x2)   jmpd(0x100a8d03, 0x59);               /* jmp 0x100a8d03 */
l_0x100a8caa:
    II(0x100a8caa, 0x7)   cmp(memb_a32(ds, 0x101c391e), 0x8);   /* cmp byte [0x101c391e], 0x8 */
    II(0x100a8cb1, 0x2)   jnzd(0x100a8d03, 0x50);               /* jnz 0x100a8d03 */
    II(0x100a8cb3, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a8cb5, 0x5)   mov(al, memb_a32(ds, 0x101c37c8));    /* mov al, [0x101c37c8] */
    II(0x100a8cba, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a8cc0, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x100a8cc6, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100a8ccb, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x100a8cce, 0x2)   jnzd(0x100a8ce6, 0x16);               /* jnz 0x100a8ce6 */
    II(0x100a8cd0, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a8cd2, 0x5)   mov(al, memb_a32(ds, 0x101c37c8));    /* mov al, [0x101c37c8] */
    II(0x100a8cd7, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a8cdd, 0x7)   cmp(memb_a32(ds, eax + 0x101ca491), 0); /* cmp byte [eax+0x101ca491], 0x0 */
    II(0x100a8ce4, 0x2)   jzd(0x100a8ce8, 0x2);                 /* jz 0x100a8ce8 */
l_0x100a8ce6:
    II(0x100a8ce6, 0x2)   jmpd(0x100a8d03, 0x1b);               /* jmp 0x100a8d03 */
l_0x100a8ce8:
    II(0x100a8ce8, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a8cea, 0x5)   mov(al, memb_a32(ds, 0x101c37c8));    /* mov al, [0x101c37c8] */
    II(0x100a8cef, 0x6)   imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
    II(0x100a8cf5, 0x5)   mov(edx, 0x101c31c4);                 /* mov edx, 0x101c31c4 */
    II(0x100a8cfa, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x100a8cfc, 0x5)   calld(0x100be436, 0x15735);           /* call 0x100be436 */
    II(0x100a8d01, 0x2)   test(al, al);                         /* test al, al */
l_0x100a8d03:
    II(0x100a8d03, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a8d05, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a8d06, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a8d07, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a8d08, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a8d09, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a8d0a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a8d0b, 0x1)   retd();                               /* ret */
FUNC_END

