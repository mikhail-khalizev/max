FUNC_BEGIN(0x10153d99, 0x3b4d84269f4dbb1, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xaf, 0x1f, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xfc, 0x80, 0x3d, 0x7d, 0x94, 0x1c, 0x10, 0, 0x74, 0x7, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x5f, 0, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x5e, 0x25, 0xff, 0, 0, 0, 0xc1, 0xf8, 0x6, 0x89, 0x45, 0xf0, 0xc7, 0x45, 0xec, 0, 0, 0, 0, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xf, 0xbf, 0x45, 0xf0, 0xc1, 0xe0, 0x6, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x5e, 0x25, 0xff, 0, 0, 0, 0x83, 0xc2, 0x20, 0x39, 0xd0, 0x7d, 0x29, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x5e, 0x1f, 0x75, 0x1e, 0xf, 0xbf, 0x45, 0xf0, 0x66, 0xf, 0xbe, 0x80, 0x14, 0xd9, 0x1b, 0x10, 0x89, 0x45, 0xec, 0xf, 0xbf, 0x45, 0xf0, 0x66, 0xf, 0xbe, 0x80, 0x1c, 0xd9, 0x1b, 0x10, 0x89, 0x45, 0xf4, 0xeb, 0x2d, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x5e, 0x1f, 0x75, 0x24, 0xf, 0xbf, 0x45, 0xf0, 0x66, 0xf, 0xbe, 0x80, 0x14, 0xd9, 0x1b, 0x10, 0x89, 0x45, 0xec, 0xf7, 0x5d, 0xec, 0xf, 0xbf, 0x45, 0xf0, 0x66, 0xf, 0xbe, 0x80, 0x1c, 0xd9, 0x1b, 0x10, 0x89, 0x45, 0xf4, 0xf7, 0x5d, 0xf4, 0x66, 0x83, 0x7d, 0xec, 0, 0x75, 0x7, 0x66, 0x83, 0x7d, 0xf4, 0, 0x74, 0x63, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x5f, 0, 0x75, 0xb, 0x31, 0xc0, 0xa0, 0x7c, 0x94, 0x1c, 0x10, 0x85, 0xc0, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0, 0xeb, 0x6d, 0x8b, 0x45, 0xfc, 0xe8, 0x24, 0x61, 0xff, 0xff, 0xf, 0xbf, 0x5d, 0xf4, 0xf, 0xbf, 0x55, 0xec, 0x8b, 0x45, 0xfc, 0xe8, 0x9b, 0x5d, 0xff, 0xff, 0x8b, 0x45, 0xec, 0x8b, 0x55, 0xfc, 0x66, 0x29, 0x82, 0xd9, 0, 0, 0, 0x8b, 0x45, 0xf4, 0x8b, 0x55, 0xfc, 0x66, 0x29, 0x82, 0xdb, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x1b, 0x5e, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0xea, 0x60, 0xff, 0xff, 0x8b, 0x55, 0xfc, 0xc6, 0x42, 0x5f, 0x1, 0x8b, 0x45, 0xfc, 0xfe, 0x40, 0x5e, 0x66, 0x83, 0x7d, 0xec, 0, 0x75, 0x7, 0x66, 0x83, 0x7d, 0xf4, 0, 0x74, 0x6, 0xc6, 0x45, 0xe8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xe8, 0, 0x8a, 0x45, 0xe8, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10153d99, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x10153d9e, 0x5)   calld(sys_check_available_stack_size, 0x11faf); /* call 0x10165d52 */
    II(0x10153da3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10153da4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10153da5, 0x1)   pushd(edx);                           /* push edx */
    II(0x10153da6, 0x1)   pushd(esi);                           /* push esi */
    II(0x10153da7, 0x1)   pushd(edi);                           /* push edi */
    II(0x10153da8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10153da9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10153dab, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x10153db1, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10153db4, 0x7)   cmp(memb_a32(ds, 0x101c947d), 0);     /* cmp byte [0x101c947d], 0x0 */
    II(0x10153dbb, 0x2)   jzd(0x10153dc4, 0x7);                 /* jz 0x10153dc4 */
    II(0x10153dbd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153dc0, 0x4)   mov(memb_a32(ds, eax + 0x5f), 0);     /* mov byte [eax+0x5f], 0x0 */
l_0x10153dc4:
    II(0x10153dc4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153dc7, 0x3)   mov(al, memb_a32(ds, eax + 0x5e));    /* mov al, [eax+0x5e] */
    II(0x10153dca, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10153dcf, 0x3)   sar(eax, 0x6);                        /* sar eax, 0x6 */
    II(0x10153dd2, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10153dd5, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0);     /* mov dword [ebp-0x14], 0x0 */
    II(0x10153ddc, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x10153de3, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x10153de7, 0x3)   shl(eax, 0x6);                        /* shl eax, 0x6 */
    II(0x10153dea, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10153dec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153def, 0x3)   mov(al, memb_a32(ds, eax + 0x5e));    /* mov al, [eax+0x5e] */
    II(0x10153df2, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10153df7, 0x3)   add(edx, 0x20);                       /* add edx, 0x20 */
    II(0x10153dfa, 0x2)   cmp(eax, edx);                        /* cmp eax, edx */
    II(0x10153dfc, 0x2)   jged(0x10153e27, 0x29);               /* jge 0x10153e27 */
    II(0x10153dfe, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153e01, 0x4)   test(memb_a32(ds, eax + 0x5e), 0x1f); /* test byte [eax+0x5e], 0x1f */
    II(0x10153e05, 0x2)   jnzd(0x10153e25, 0x1e);               /* jnz 0x10153e25 */
    II(0x10153e07, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x10153e0b, 0x8)   movsx(ax, memb_a32(ds, eax + 0x101bd914)); /* movsx ax, byte [eax+0x101bd914] */
    II(0x10153e13, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10153e16, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x10153e1a, 0x8)   movsx(ax, memb_a32(ds, eax + 0x101bd91c)); /* movsx ax, byte [eax+0x101bd91c] */
    II(0x10153e22, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x10153e25:
    II(0x10153e25, 0x2)   jmpd(0x10153e54, 0x2d);               /* jmp 0x10153e54 */
l_0x10153e27:
    II(0x10153e27, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153e2a, 0x4)   test(memb_a32(ds, eax + 0x5e), 0x1f); /* test byte [eax+0x5e], 0x1f */
    II(0x10153e2e, 0x2)   jnzd(0x10153e54, 0x24);               /* jnz 0x10153e54 */
    II(0x10153e30, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x10153e34, 0x8)   movsx(ax, memb_a32(ds, eax + 0x101bd914)); /* movsx ax, byte [eax+0x101bd914] */
    II(0x10153e3c, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10153e3f, 0x3)   neg(memd_a32(ss, ebp - 0x14));        /* neg dword [ebp-0x14] */
    II(0x10153e42, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x10153e46, 0x8)   movsx(ax, memb_a32(ds, eax + 0x101bd91c)); /* movsx ax, byte [eax+0x101bd91c] */
    II(0x10153e4e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10153e51, 0x3)   neg(memd_a32(ss, ebp - 0xc));         /* neg dword [ebp-0xc] */
l_0x10153e54:
    II(0x10153e54, 0x5)   cmp(memw_a32(ss, ebp - 0x14), 0);     /* cmp word [ebp-0x14], 0x0 */
    II(0x10153e59, 0x2)   jnzd(0x10153e62, 0x7);                /* jnz 0x10153e62 */
    II(0x10153e5b, 0x5)   cmp(memw_a32(ss, ebp - 0xc), 0);      /* cmp word [ebp-0xc], 0x0 */
    II(0x10153e60, 0x2)   jzd(0x10153ec5, 0x63);                /* jz 0x10153ec5 */
l_0x10153e62:
    II(0x10153e62, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153e65, 0x4)   cmp(memb_a32(ds, eax + 0x5f), 0);     /* cmp byte [eax+0x5f], 0x0 */
    II(0x10153e69, 0x2)   jnzd(0x10153e76, 0xb);                /* jnz 0x10153e76 */
    II(0x10153e6b, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10153e6d, 0x5)   mov(al, memb_a32(ds, 0x101c947c));    /* mov al, [0x101c947c] */
    II(0x10153e72, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10153e74, 0x2)   jnzd(0x10153e7c, 0x6);                /* jnz 0x10153e7c */
l_0x10153e76:
    II(0x10153e76, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x10153e7a, 0x2)   jmpd(0x10153ee9, 0x6d);               /* jmp 0x10153ee9 */
l_0x10153e7c:
    II(0x10153e7c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153e7f, 0x5)   calld(0x10149fa8, -0x9edc);           /* call 0x10149fa8 */
    II(0x10153e84, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0xc));  /* movsx ebx, word [ebp-0xc] */
    II(0x10153e88, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x14)); /* movsx edx, word [ebp-0x14] */
    II(0x10153e8c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153e8f, 0x5)   calld(0x10149c2f, -0xa265);           /* call 0x10149c2f */
    II(0x10153e94, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x10153e97, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10153e9a, 0x7)   sub(memw_a32(ds, edx + 0xd9), ax);    /* sub [edx+0xd9], ax */
    II(0x10153ea1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10153ea4, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10153ea7, 0x7)   sub(memw_a32(ds, edx + 0xdb), ax);    /* sub [edx+0xdb], ax */
    II(0x10153eae, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153eb1, 0x5)   calld(0x10149cd1, -0xa1e5);           /* call 0x10149cd1 */
    II(0x10153eb6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153eb9, 0x5)   calld(0x10149fa8, -0x9f16);           /* call 0x10149fa8 */
    II(0x10153ebe, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10153ec1, 0x4)   mov(memb_a32(ds, edx + 0x5f), 0x1);   /* mov byte [edx+0x5f], 0x1 */
l_0x10153ec5:
    II(0x10153ec5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10153ec8, 0x3)   inc(memb_a32(ds, eax + 0x5e));        /* inc byte [eax+0x5e] */
    II(0x10153ecb, 0x5)   cmp(memw_a32(ss, ebp - 0x14), 0);     /* cmp word [ebp-0x14], 0x0 */
    II(0x10153ed0, 0x2)   jnzd(0x10153ed9, 0x7);                /* jnz 0x10153ed9 */
    II(0x10153ed2, 0x5)   cmp(memw_a32(ss, ebp - 0xc), 0);      /* cmp word [ebp-0xc], 0x0 */
    II(0x10153ed7, 0x2)   jzd(0x10153edf, 0x6);                 /* jz 0x10153edf */
l_0x10153ed9:
    II(0x10153ed9, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0x1);   /* mov byte [ebp-0x18], 0x1 */
    II(0x10153edd, 0x2)   jmpd(0x10153ee3, 0x4);                /* jmp 0x10153ee3 */
l_0x10153edf:
    II(0x10153edf, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0);     /* mov byte [ebp-0x18], 0x0 */
l_0x10153ee3:
    II(0x10153ee3, 0x3)   mov(al, memb_a32(ss, ebp - 0x18));    /* mov al, [ebp-0x18] */
    II(0x10153ee6, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
l_0x10153ee9:
    II(0x10153ee9, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10153eec, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10153eee, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10153eef, 0x1)   popd(edi);                            /* pop edi */
    II(0x10153ef0, 0x1)   popd(esi);                            /* pop esi */
    II(0x10153ef1, 0x1)   popd(edx);                            /* pop edx */
    II(0x10153ef2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10153ef3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10153ef4, 0x1)   retd();                               /* ret */
FUNC_END

