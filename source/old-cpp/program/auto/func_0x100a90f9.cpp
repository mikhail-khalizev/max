FUNC_BEGIN(0x100a90f9, 0x4cf6ec739d0765ca, 0x20, ({0x68, 0x30, 0, 0, 0, 0xe8, 0x4f, 0xcc, 0xb, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x88, 0x5d, 0xf8, 0x88, 0x4d, 0xfc, 0x8b, 0x45, 0xf0, 0x8a, 0x40, 0x26, 0x25, 0xff, 0, 0, 0, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x75, 0x6, 0x80, 0x7d, 0xf8, 0, 0x75, 0x9, 0xc6, 0x45, 0xec, 0, 0xe9, 0x84, 0, 0, 0, 0x31, 0xc9, 0x8a, 0x4d, 0xfc, 0xf, 0xbe, 0x5d, 0xf8, 0x8b, 0x45, 0xf0, 0x8b, 0x55, 0xf0, 0x8a, 0x52, 0x26, 0x81, 0xe2, 0xff, 0, 0, 0, 0x69, 0xd2, 0xc5, 0, 0, 0, 0xbe, 0xc4, 0x31, 0x1c, 0x10, 0x1, 0xd6, 0x89, 0xc2, 0x89, 0xf0, 0xe8, 0x5c, 0x8e, 0x1, 0, 0x89, 0x45, 0xe8, 0x31, 0xc0, 0x8b, 0x55, 0xf0, 0x8a, 0x42, 0x4d, 0x89, 0x45, 0xe4, 0x80, 0x7d, 0xf8, 0x3, 0x75, 0x7, 0xc7, 0x45, 0xe4, 0x1, 0, 0, 0, 0x83, 0x7d, 0xe8, 0, 0x74, 0x23, 0x8b, 0x45, 0xf4, 0xf, 0xbf, 0x10, 0xc1, 0xe2, 0x2, 0x3, 0x55, 0xe8, 0x8b, 0x45, 0xf4, 0x8b, 0, 0xc1, 0xf8, 0x10, 0x1, 0xc0, 0x8b, 0x12, 0x1, 0xd0, 0x66, 0x8b, 0, 0x66, 0x3b, 0x45, 0xe4, 0x7d, 0x2, 0xeb, 0x6, 0xc6, 0x45, 0xe0, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xe0, 0, 0x8a, 0x45, 0xe0, 0x88, 0x45, 0xec, 0x8a, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc3}))
    II(0x100a90f9, 0x5)   pushd(0x30);                          /* push dword 0x30 */
    II(0x100a90fe, 0x5)   calld(sys_check_available_stack_size, 0xbcc4f); /* call 0x10165d52 */
    II(0x100a9103, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a9104, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a9105, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a9106, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a9108, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x100a910e, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100a9111, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100a9114, 0x3)   mov(memb_a32(ss, ebp - 0x8), bl);     /* mov [ebp-0x8], bl */
    II(0x100a9117, 0x3)   mov(memb_a32(ss, ebp - 0x4), cl);     /* mov [ebp-0x4], cl */
    II(0x100a911a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a911d, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x100a9120, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100a9125, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100a912b, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x100a9131, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100a9136, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x100a9139, 0x2)   jnzd(0x100a9141, 0x6);                /* jnz 0x100a9141 */
    II(0x100a913b, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0);      /* cmp byte [ebp-0x8], 0x0 */
    II(0x100a913f, 0x2)   jnzd(0x100a914a, 0x9);                /* jnz 0x100a914a */
l_0x100a9141:
    II(0x100a9141, 0x4)   mov(memb_a32(ss, ebp - 0x14), 0);     /* mov byte [ebp-0x14], 0x0 */
    II(0x100a9145, 0x5)   jmpd(0x100a91ce, 0x84);               /* jmp 0x100a91ce */
l_0x100a914a:
    II(0x100a914a, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x100a914c, 0x3)   mov(cl, memb_a32(ss, ebp - 0x4));     /* mov cl, [ebp-0x4] */
    II(0x100a914f, 0x4)   movsx(ebx, memb_a32(ss, ebp - 0x8));  /* movsx ebx, byte [ebp-0x8] */
    II(0x100a9153, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a9156, 0x3)   mov(edx, memd_a32(ss, ebp - 0x10));   /* mov edx, [ebp-0x10] */
    II(0x100a9159, 0x3)   mov(dl, memb_a32(ds, edx + 0x26));    /* mov dl, [edx+0x26] */
    II(0x100a915c, 0x6)   and_(edx, 0xff);                      /* and edx, 0xff */
    II(0x100a9162, 0x6)   imul(edx, edx, 0xc5);                 /* imul edx, edx, 0xc5 */
    II(0x100a9168, 0x5)   mov(esi, 0x101c31c4);                 /* mov esi, 0x101c31c4 */
    II(0x100a916d, 0x2)   add(esi, edx);                        /* add esi, edx */
    II(0x100a916f, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100a9171, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x100a9173, 0x5)   calld(0x100c1fd4, 0x18e5c);           /* call 0x100c1fd4 */
    II(0x100a9178, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100a917b, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100a917d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x10));   /* mov edx, [ebp-0x10] */
    II(0x100a9180, 0x3)   mov(al, memb_a32(ds, edx + 0x4d));    /* mov al, [edx+0x4d] */
    II(0x100a9183, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x100a9186, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0x3);    /* cmp byte [ebp-0x8], 0x3 */
    II(0x100a918a, 0x2)   jnzd(0x100a9193, 0x7);                /* jnz 0x100a9193 */
    II(0x100a918c, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0x1);   /* mov dword [ebp-0x1c], 0x1 */
l_0x100a9193:
    II(0x100a9193, 0x4)   cmp(memd_a32(ss, ebp - 0x18), 0);     /* cmp dword [ebp-0x18], 0x0 */
    II(0x100a9197, 0x2)   jzd(0x100a91bc, 0x23);                /* jz 0x100a91bc */
    II(0x100a9199, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100a919c, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x100a919f, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x100a91a2, 0x3)   add(edx, memd_a32(ss, ebp - 0x18));   /* add edx, [ebp-0x18] */
    II(0x100a91a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100a91a8, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100a91aa, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100a91ad, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100a91af, 0x2)   mov(edx, memd_a32(ds, edx));          /* mov edx, [edx] */
    II(0x100a91b1, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x100a91b3, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100a91b6, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x1c));    /* cmp ax, [ebp-0x1c] */
    II(0x100a91ba, 0x2)   jged(0x100a91be, 0x2);                /* jge 0x100a91be */
l_0x100a91bc:
    II(0x100a91bc, 0x2)   jmpd(0x100a91c4, 0x6);                /* jmp 0x100a91c4 */
l_0x100a91be:
    II(0x100a91be, 0x4)   mov(memb_a32(ss, ebp - 0x20), 0x1);   /* mov byte [ebp-0x20], 0x1 */
    II(0x100a91c2, 0x2)   jmpd(0x100a91c8, 0x4);                /* jmp 0x100a91c8 */
l_0x100a91c4:
    II(0x100a91c4, 0x4)   mov(memb_a32(ss, ebp - 0x20), 0);     /* mov byte [ebp-0x20], 0x0 */
l_0x100a91c8:
    II(0x100a91c8, 0x3)   mov(al, memb_a32(ss, ebp - 0x20));    /* mov al, [ebp-0x20] */
    II(0x100a91cb, 0x3)   mov(memb_a32(ss, ebp - 0x14), al);    /* mov [ebp-0x14], al */
l_0x100a91ce:
    II(0x100a91ce, 0x3)   mov(al, memb_a32(ss, ebp - 0x14));    /* mov al, [ebp-0x14] */
    II(0x100a91d1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a91d3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a91d4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a91d5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a91d6, 0x1)   retd();                               /* ret */
FUNC_END

