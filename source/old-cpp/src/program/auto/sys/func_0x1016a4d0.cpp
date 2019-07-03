FUNC_BEGIN(/* sys */ 0x1016a4d0, 0xb931bc3ff51e9783, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x8b, 0x3d, 0x64, 0xf9, 0x1c, 0x10, 0x89, 0xc2, 0x8b, 0x77, 0xc, 0x8a, 0x18, 0x31, 0xc9, 0x84, 0xdb, 0x74, 0x1c, 0x31, 0xd2, 0x8b, 0x2f, 0x8a, 0x10, 0x89, 0xfb, 0x39, 0xea, 0x7d, 0x8, 0x8b, 0x14, 0xd6, 0x3, 0x57, 0x8, 0x1, 0xd1, 0x8a, 0x78, 0x1, 0x40, 0x84, 0xff, 0x75, 0xe4, 0x89, 0xc8, 0x89, 0x3d, 0x64, 0xf9, 0x1c, 0x10, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016a4d0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016a4d1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016a4d2, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016a4d3, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016a4d4, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016a4d5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016a4d6, 0x6)   mov(edi, memd_a32(ds, 0x101cf964));   /* mov edi, [0x101cf964] */
    II(0x1016a4dc, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1016a4de, 0x3)   mov(esi, memd_a32(ds, edi + 0xc));    /* mov esi, [edi+0xc] */
    II(0x1016a4e1, 0x2)   mov(bl, memb_a32(ds, eax));           /* mov bl, [eax] */
    II(0x1016a4e3, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1016a4e5, 0x2)   test(bl, bl);                         /* test bl, bl */
    II(0x1016a4e7, 0x2)   jzd(0x1016a505, 0x1c);                /* jz 0x1016a505 */
l_0x1016a4e9:
    II(0x1016a4e9, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016a4eb, 0x2)   mov(ebp, memd_a32(ds, edi));          /* mov ebp, [edi] */
    II(0x1016a4ed, 0x2)   mov(dl, memb_a32(ds, eax));           /* mov dl, [eax] */
    II(0x1016a4ef, 0x2)   mov(ebx, edi);                        /* mov ebx, edi */
    II(0x1016a4f1, 0x2)   cmp(edx, ebp);                        /* cmp edx, ebp */
    II(0x1016a4f3, 0x2)   jged(0x1016a4fd, 0x8);                /* jge 0x1016a4fd */
    II(0x1016a4f5, 0x3)   mov(edx, memd_a32(ds, esi + edx * 0x8)); /* mov edx, [esi+edx*8] */
    II(0x1016a4f8, 0x3)   add(edx, memd_a32(ds, edi + 0x8));    /* add edx, [edi+0x8] */
    II(0x1016a4fb, 0x2)   add(ecx, edx);                        /* add ecx, edx */
l_0x1016a4fd:
    II(0x1016a4fd, 0x3)   mov(bh, memb_a32(ds, eax + 0x1));     /* mov bh, [eax+0x1] */
    II(0x1016a500, 0x1)   inc(eax);                             /* inc eax */
    II(0x1016a501, 0x2)   test(bh, bh);                         /* test bh, bh */
    II(0x1016a503, 0x2)   jnzd(0x1016a4e9, -0x1c);              /* jnz 0x1016a4e9 */
l_0x1016a505:
    II(0x1016a505, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1016a507, 0x6)   mov(memd_a32(ds, 0x101cf964), edi);   /* mov [0x101cf964], edi */
    II(0x1016a50d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016a50e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016a50f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016a510, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016a511, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016a512, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016a513, 0x1)   retd();                               /* ret */
FUNC_END

