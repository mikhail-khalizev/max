FUNC_BEGIN(0x1015410e, 0xa1173f6586c2ce6f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3a, 0x1c, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x5e, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x75, 0x11, 0xba, 0xbc, 0x37, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x53, 0x2c, 0xf2, 0xff, 0x84, 0xc0, 0x75, 0x2, 0xeb, 0x1b, 0xe8, 0xa8, 0xea, 0xfa, 0xff, 0x31, 0xc9, 0x88, 0xc1, 0xbb, 0x11, 0, 0, 0, 0x8b, 0x55, 0xfc, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0x5a, 0x94, 0xfe, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0x3a, 0x5e, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x8a, 0x50, 0x5e, 0xfe, 0xc2, 0x8b, 0x45, 0xfc, 0x80, 0xe2, 0x3f, 0x88, 0x50, 0x5e, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x5e, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x8, 0x7f, 0x2c, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x80, 0xd9, 0, 0, 0, 0x8, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x80, 0xdb, 0, 0, 0, 0x8, 0x8b, 0x45, 0xfc, 0xe8, 0x24, 0x5b, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0xf3, 0x5d, 0xff, 0xff, 0xc6, 0x45, 0xf8, 0, 0xeb, 0x13, 0x8b, 0x45, 0xfc, 0x80, 0x60, 0x14, 0xfe, 0x8b, 0x45, 0xfc, 0xe8, 0xf0, 0x6, 0, 0, 0xc6, 0x45, 0xf8, 0x1, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1015410e, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10154113, 0x5)   calld(sys_check_available_stack_size, 0x11c3a); /* call 0x10165d52 */
    II(0x10154118, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10154119, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015411a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1015411b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015411c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1015411d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1015411e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10154120, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10154126, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10154129, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015412c, 0x3)   mov(al, memb_a32(ds, eax + 0x5e));    /* mov al, [eax+0x5e] */
    II(0x1015412f, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10154134, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10154136, 0x2)   jnzd(0x10154149, 0x11);               /* jnz 0x10154149 */
    II(0x10154138, 0x5)   mov(edx, 0x101c37bc);                 /* mov edx, 0x101c37bc */
    II(0x1015413d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154140, 0x5)   calld(0x10076d98, -0xdd3ad);          /* call 0x10076d98 */
    II(0x10154145, 0x2)   test(al, al);                         /* test al, al */
    II(0x10154147, 0x2)   jnzd(0x1015414b, 0x2);                /* jnz 0x1015414b */
l_0x10154149:
    II(0x10154149, 0x2)   jmpd(0x10154166, 0x1b);               /* jmp 0x10154166 */
l_0x1015414b:
    II(0x1015414b, 0x5)   calld(0x10102bf8, -0x51558);          /* call 0x10102bf8 */
    II(0x10154150, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10154152, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x10154154, 0x5)   mov(ebx, 0x11);                       /* mov ebx, 0x11 */
    II(0x10154159, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1015415c, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x10154161, 0x5)   calld(0x1013d5c0, -0x16ba6);          /* call 0x1013d5c0 */
l_0x10154166:
    II(0x10154166, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154169, 0x5)   calld(0x10149fa8, -0xa1c6);           /* call 0x10149fa8 */
    II(0x1015416e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154171, 0x3)   mov(dl, memb_a32(ds, eax + 0x5e));    /* mov dl, [eax+0x5e] */
    II(0x10154174, 0x2)   inc(dl);                              /* inc dl */
    II(0x10154176, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154179, 0x3)   and_(dl, 0x3f);                       /* and dl, 0x3f */
    II(0x1015417c, 0x3)   mov(memb_a32(ds, eax + 0x5e), dl);    /* mov [eax+0x5e], dl */
    II(0x1015417f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154182, 0x3)   mov(al, memb_a32(ds, eax + 0x5e));    /* mov al, [eax+0x5e] */
    II(0x10154185, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1015418a, 0x3)   cmp(eax, 0x8);                        /* cmp eax, 0x8 */
    II(0x1015418d, 0x2)   jgd(0x101541bb, 0x2c);                /* jg 0x101541bb */
    II(0x1015418f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10154192, 0x8)   add(memw_a32(ds, eax + 0xd9), 0x8);   /* add word [eax+0xd9], 0x8 */
    II(0x1015419a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015419d, 0x8)   add(memw_a32(ds, eax + 0xdb), 0x8);   /* add word [eax+0xdb], 0x8 */
    II(0x101541a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101541a8, 0x5)   calld(0x10149cd1, -0xa4dc);           /* call 0x10149cd1 */
    II(0x101541ad, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101541b0, 0x5)   calld(0x10149fa8, -0xa20d);           /* call 0x10149fa8 */
    II(0x101541b5, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x101541b9, 0x2)   jmpd(0x101541ce, 0x13);               /* jmp 0x101541ce */
l_0x101541bb:
    II(0x101541bb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101541be, 0x4)   and_(memb_a32(ds, eax + 0x14), -0x2 /* 0xfe */); /* and byte [eax+0x14], 0xfe */
    II(0x101541c2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101541c5, 0x5)   calld(0x101548ba, 0x6f0);             /* call 0x101548ba */
    II(0x101541ca, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
l_0x101541ce:
    II(0x101541ce, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x101541d1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101541d3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101541d4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101541d5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101541d6, 0x1)   popd(edx);                            /* pop edx */
    II(0x101541d7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101541d8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101541d9, 0x1)   retd();                               /* ret */
FUNC_END

