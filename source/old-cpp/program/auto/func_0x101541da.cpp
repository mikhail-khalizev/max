FUNC_BEGIN(0x101541da, 0x975064ffa5df6fbf, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x6e, 0x1b, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x5e, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x75, 0x11, 0xba, 0xbc, 0x37, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x87, 0x2b, 0xf2, 0xff, 0x84, 0xc0, 0x75, 0x2, 0xeb, 0x1b, 0xe8, 0xdc, 0xe9, 0xfa, 0xff, 0x31, 0xc9, 0x88, 0xc1, 0xbb, 0x12, 0, 0, 0, 0x8b, 0x55, 0xfc, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0x8e, 0x93, 0xfe, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0x6e, 0x5d, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x8a, 0x50, 0x5e, 0xfe, 0xc2, 0x8b, 0x45, 0xfc, 0x80, 0xe2, 0x3f, 0x88, 0x50, 0x5e, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x5e, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x4, 0x7f, 0x2c, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0xa8, 0xd9, 0, 0, 0, 0x10, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0xa8, 0xdb, 0, 0, 0, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x58, 0x5a, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0x27, 0x5d, 0xff, 0xff, 0xc6, 0x45, 0xf8, 0, 0xeb, 0xb, 0x8b, 0x45, 0xfc, 0x80, 0x48, 0x14, 0x1, 0xc6, 0x45, 0xf8, 0x1, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101541da, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101541df, 0x5)   calld(sys_check_available_stack_size, 0x11b6e); /* call 0x10165d52 */
    II(0x101541e4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101541e5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101541e6, 0x1)   pushd(edx);                           /* push edx */
    II(0x101541e7, 0x1)   pushd(esi);                           /* push esi */
    II(0x101541e8, 0x1)   pushd(edi);                           /* push edi */
    II(0x101541e9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101541ea, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101541ec, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101541f2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101541f5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101541f8, 0x3)   mov(al, memb_a32(ds, eax + 0x5e));    /* mov al, [eax+0x5e] */
    II(0x101541fb, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10154200, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10154202, 0x2)   jnzd(0x10154215, 0x11);               /* jnz 0x10154215 */
    II(0x10154204, 0x5)   mov(edx, 0x101c37bc);                 /* mov edx, 0x101c37bc */
    II(0x10154209, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015420c, 0x5)   calld(0x10076d98, -0xdd479);          /* call 0x10076d98 */
    II(0x10154211, 0x2)   test(al, al);                         /* test al, al */
    II(0x10154213, 0x2)   jnzd(0x10154217, 0x2);                /* jnz 0x10154217 */
l_0x10154215:
    II(0x10154215, 0x2)   jmpd(0x10154232, 0x1b);               /* jmp 0x10154232 */
l_0x10154217:
    II(0x10154217, 0x5)   calld(0x10102bf8, -0x51624);          /* call 0x10102bf8 */
    II(0x1015421c, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1015421e, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x10154220, 0x5)   mov(ebx, 0x12);                       /* mov ebx, 0x12 */
    II(0x10154225, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10154228, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x1015422d, 0x5)   calld(0x1013d5c0, -0x16c72);          /* call 0x1013d5c0 */
l_0x10154232:
    II(0x10154232, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154235, 0x5)   calld(0x10149fa8, -0xa292);           /* call 0x10149fa8 */
    II(0x1015423a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015423d, 0x3)   mov(dl, memb_a32(ds, eax + 0x5e));    /* mov dl, [eax+0x5e] */
    II(0x10154240, 0x2)   inc(dl);                              /* inc dl */
    II(0x10154242, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154245, 0x3)   and_(dl, 0x3f);                       /* and dl, 0x3f */
    II(0x10154248, 0x3)   mov(memb_a32(ds, eax + 0x5e), dl);    /* mov [eax+0x5e], dl */
    II(0x1015424b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015424e, 0x3)   mov(al, memb_a32(ds, eax + 0x5e));    /* mov al, [eax+0x5e] */
    II(0x10154251, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10154256, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x10154259, 0x2)   jgd(0x10154287, 0x2c);                /* jg 0x10154287 */
    II(0x1015425b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015425e, 0x8)   sub(memw_a32(ds, eax + 0xd9), 0x10);  /* sub word [eax+0xd9], 0x10 */
    II(0x10154266, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154269, 0x8)   sub(memw_a32(ds, eax + 0xdb), 0x10);  /* sub word [eax+0xdb], 0x10 */
    II(0x10154271, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154274, 0x5)   calld(0x10149cd1, -0xa5a8);           /* call 0x10149cd1 */
    II(0x10154279, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015427c, 0x5)   calld(0x10149fa8, -0xa2d9);           /* call 0x10149fa8 */
    II(0x10154281, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x10154285, 0x2)   jmpd(0x10154292, 0xb);                /* jmp 0x10154292 */
l_0x10154287:
    II(0x10154287, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015428a, 0x4)   or_(memb_a32(ds, eax + 0x14), 0x1);   /* or byte [eax+0x14], 0x1 */
    II(0x1015428e, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
l_0x10154292:
    II(0x10154292, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10154295, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10154297, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10154298, 0x1)   popd(edi);                            /* pop edi */
    II(0x10154299, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015429a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1015429b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015429c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015429d, 0x1)   retd();                               /* ret */
FUNC_END

