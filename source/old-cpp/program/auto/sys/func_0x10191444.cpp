FUNC_BEGIN(/* sys */ 0x10191444, 0x156498f0640220e0, 0x20, ({0x55, 0x8b, 0xec, 0x83, 0xc4, 0xe8, 0x56, 0x57, 0x53, 0x66, 0x8c, 0xd8, 0x66, 0x8e, 0xc0, 0xa1, 0xd8, 0x9c, 0x20, 0x10, 0x2b, 0x5, 0xc8, 0x9c, 0x20, 0x10, 0x89, 0x45, 0xf4, 0x33, 0xdb, 0x8a, 0x1d, 0xd2, 0x9d, 0x20, 0x10, 0x8b, 0x45, 0x10, 0xc1, 0xe0, 0x4, 0xa3, 0xe0, 0x9c, 0x20, 0x10, 0x8b, 0x45, 0x18, 0xc1, 0xe0, 0x4, 0xa3, 0xdc, 0x9c, 0x20, 0x10, 0x8b, 0x45, 0x14, 0xc1, 0xe0, 0x3, 0xf7, 0xe3, 0xa3, 0xe4, 0x9c, 0x20, 0x10, 0x8b, 0x45, 0x1c, 0xc1, 0xe0, 0x3, 0xf7, 0xe3, 0xa3, 0xd4, 0x9c, 0x20, 0x10, 0xa1, 0xc4, 0x9c, 0x20, 0x10, 0x2b, 0x5, 0xdc, 0x9c, 0x20, 0x10, 0x89, 0x45, 0xf8, 0xa1, 0xc8, 0x9c, 0x20, 0x10, 0x89, 0x45, 0xfc, 0x83, 0x7d, 0x10, 0, 0x75, 0x6, 0x83, 0x7d, 0x14, 0, 0x74, 0x14, 0xa1, 0xe4, 0x9c, 0x20, 0x10, 0xf7, 0x25, 0xd0, 0x9c, 0x20, 0x10, 0x3, 0x5, 0xe0, 0x9c, 0x20, 0x10, 0x1, 0x45, 0xfc, 0xa1, 0xec, 0x9c, 0x20, 0x10, 0x83, 0xe8, 0x10, 0x89, 0x45, 0xf0, 0x8b, 0x75, 0xc, 0x8b, 0x7d, 0xfc, 0x33, 0xc0, 0x66, 0x8b, 0x6, 0x3, 0xc6, 0x89, 0x45, 0xe8, 0x83, 0xc6, 0x2, 0x8b, 0x45, 0x18, 0xd1, 0xe8, 0x89, 0x45, 0xec, 0x2e, 0x8b, 0xc0, 0xff, 0x4d, 0xec, 0x78, 0x26, 0x8b, 0x5d, 0x8, 0x8a, 0x3, 0x43, 0x89, 0x5d, 0x8, 0x33, 0xdb, 0x8a, 0xd8, 0xc0, 0xeb, 0x4, 0x83, 0xe0, 0xf, 0x68, 0xf8, 0x14, 0x19, 0x10, 0xff, 0x34, 0x9d, 0xd0, 0x1, 0x1c, 0x10, 0xff, 0x24, 0x85, 0xd0, 0x1, 0x1c, 0x10, 0x3, 0x7d, 0xf8, 0xff, 0x4d, 0x1c, 0x75, 0xc2, 0x5b, 0x5f, 0x5e, 0xc9, 0xc3}))
    II(0x10191444, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10191445, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10191447, 0x3)   add(esp, -0x18 /* 0xe8 */);           /* add esp, 0xe8 */
    II(0x1019144a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019144b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1019144c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019144d, 0x3)   mov(ax, ds);                          /* mov ax, ds */
    II(0x10191450, 0x3)   mov(es, ax);                          /* mov es, ax */
    II(0x10191453, 0x5)   mov(eax, memd_a32(ds, 0x10209cd8));   /* mov eax, [0x10209cd8] */
    II(0x10191458, 0x6)   sub(eax, memd_a32(ds, 0x10209cc8));   /* sub eax, [0x10209cc8] */
    II(0x1019145e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10191461, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10191463, 0x6)   mov(bl, memb_a32(ds, 0x10209dd2));    /* mov bl, [0x10209dd2] */
    II(0x10191469, 0x3)   mov(eax, memd_a32(ss, ebp + 0x10));   /* mov eax, [ebp+0x10] */
    II(0x1019146c, 0x3)   shl(eax, 0x4);                        /* shl eax, 0x4 */
    II(0x1019146f, 0x5)   mov(memd_a32(ds, 0x10209ce0), eax);   /* mov [0x10209ce0], eax */
    II(0x10191474, 0x3)   mov(eax, memd_a32(ss, ebp + 0x18));   /* mov eax, [ebp+0x18] */
    II(0x10191477, 0x3)   shl(eax, 0x4);                        /* shl eax, 0x4 */
    II(0x1019147a, 0x5)   mov(memd_a32(ds, 0x10209cdc), eax);   /* mov [0x10209cdc], eax */
    II(0x1019147f, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x10191482, 0x3)   shl(eax, 0x3);                        /* shl eax, 0x3 */
    II(0x10191485, 0x2)   mul(ebx);                             /* mul ebx */
    II(0x10191487, 0x5)   mov(memd_a32(ds, 0x10209ce4), eax);   /* mov [0x10209ce4], eax */
    II(0x1019148c, 0x3)   mov(eax, memd_a32(ss, ebp + 0x1c));   /* mov eax, [ebp+0x1c] */
    II(0x1019148f, 0x3)   shl(eax, 0x3);                        /* shl eax, 0x3 */
    II(0x10191492, 0x2)   mul(ebx);                             /* mul ebx */
    II(0x10191494, 0x5)   mov(memd_a32(ds, 0x10209cd4), eax);   /* mov [0x10209cd4], eax */
    II(0x10191499, 0x5)   mov(eax, memd_a32(ds, 0x10209cc4));   /* mov eax, [0x10209cc4] */
    II(0x1019149e, 0x6)   sub(eax, memd_a32(ds, 0x10209cdc));   /* sub eax, [0x10209cdc] */
    II(0x101914a4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101914a7, 0x5)   mov(eax, memd_a32(ds, 0x10209cc8));   /* mov eax, [0x10209cc8] */
    II(0x101914ac, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101914af, 0x4)   cmp(memd_a32(ss, ebp + 0x10), 0);     /* cmp dword [ebp+0x10], 0x0 */
    II(0x101914b3, 0x2)   jnzd(0x101914bb, 0x6);                /* jnz 0x101914bb */
    II(0x101914b5, 0x4)   cmp(memd_a32(ss, ebp + 0x14), 0);     /* cmp dword [ebp+0x14], 0x0 */
    II(0x101914b9, 0x2)   jzd(0x101914cf, 0x14);                /* jz 0x101914cf */
l_0x101914bb:
    II(0x101914bb, 0x5)   mov(eax, memd_a32(ds, 0x10209ce4));   /* mov eax, [0x10209ce4] */
    II(0x101914c0, 0x6)   mul(memd_a32(ds, 0x10209cd0));        /* mul dword [0x10209cd0] */
    II(0x101914c6, 0x6)   add(eax, memd_a32(ds, 0x10209ce0));   /* add eax, [0x10209ce0] */
    II(0x101914cc, 0x3)   add(memd_a32(ss, ebp - 0x4), eax);    /* add [ebp-0x4], eax */
l_0x101914cf:
    II(0x101914cf, 0x5)   mov(eax, memd_a32(ds, 0x10209cec));   /* mov eax, [0x10209cec] */
    II(0x101914d4, 0x3)   sub(eax, 0x10);                       /* sub eax, 0x10 */
    II(0x101914d7, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x101914da, 0x3)   mov(esi, memd_a32(ss, ebp + 0xc));    /* mov esi, [ebp+0xc] */
    II(0x101914dd, 0x3)   mov(edi, memd_a32(ss, ebp - 0x4));    /* mov edi, [ebp-0x4] */
    II(0x101914e0, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101914e2, 0x3)   mov(ax, memw_a32(ds, esi));           /* mov ax, [esi] */
    II(0x101914e5, 0x2)   add(eax, esi);                        /* add eax, esi */
    II(0x101914e7, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x101914ea, 0x3)   add(esi, 0x2);                        /* add esi, 0x2 */
l_0x101914ed:
    II(0x101914ed, 0x3)   mov(eax, memd_a32(ss, ebp + 0x18));   /* mov eax, [ebp+0x18] */
    II(0x101914f0, 0x2)   shr(eax, 0x1);                        /* shr eax, 1 */
    II(0x101914f2, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x101914f5, 0x3)   mov(eax, eax);                        /* mov eax, eax */
    II(0x101914f8, 0x3)   dec(memd_a32(ss, ebp - 0x14));        /* dec dword [ebp-0x14] */
    II(0x101914fb, 0x2)   jsd(0x10191523, 0x26);                /* js 0x10191523 */
    II(0x101914fd, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x8));    /* mov ebx, [ebp+0x8] */
    II(0x10191500, 0x2)   mov(al, memb_a32(ds, ebx));           /* mov al, [ebx] */
    II(0x10191502, 0x1)   inc(ebx);                             /* inc ebx */
    II(0x10191503, 0x3)   mov(memd_a32(ss, ebp + 0x8), ebx);    /* mov [ebp+0x8], ebx */
    II(0x10191506, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10191508, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1019150a, 0x3)   shr(bl, 0x4);                         /* shr bl, 0x4 */
    II(0x1019150d, 0x3)   and_(eax, 0xf);                       /* and eax, 0xf */
    II(0x10191510, 0x5)   pushd(/* sys */ 0x101914f8);          /* push dword 0x101914f8 */
    II(0x10191515, 0x7)   pushd(memd_a32(ds, ebx * 0x4 + 0x101c01d0)); /* push dword [ebx*4+0x101c01d0] */
    II(0x1019151c, 0x7)   jmpd_abs(memd_a32(ds, eax * 0x4 + 0x101c01d0)); /* jmp dword near [eax*4+0x101c01d0] */
l_0x10191523:
    II(0x10191523, 0x3)   add(edi, memd_a32(ss, ebp - 0x8));    /* add edi, [ebp-0x8] */
    II(0x10191526, 0x3)   dec(memd_a32(ss, ebp + 0x1c));        /* dec dword [ebp+0x1c] */
    II(0x10191529, 0x2)   jnzd(0x101914ed, -0x3e);              /* jnz 0x101914ed */
    II(0x1019152b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019152c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1019152d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019152e, 0x1)   leaved();                             /* leave */
    II(0x1019152f, 0x1)   retd();                               /* ret */
FUNC_END

