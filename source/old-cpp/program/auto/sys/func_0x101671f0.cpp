FUNC_BEGIN(/* sys */ 0x101671f0, 0xa5b1a238a040b36a, 0x20, ({0x56, 0x57, 0x55, 0x83, 0xec, 0x4, 0x89, 0xd5, 0x89, 0xdf, 0x89, 0xce, 0xe8, 0xab, 0xb, 0, 0, 0x8b, 0x15, 0xbc, 0xdd, 0x1b, 0x10, 0x89, 0x4, 0x24, 0x85, 0xd2, 0xf, 0x84, 0xb8, 0, 0, 0, 0x85, 0xc0, 0xf, 0x84, 0xb0, 0, 0, 0, 0x8b, 0x5c, 0x24, 0x18, 0x81, 0xfb, 0, 0x1, 0, 0, 0x75, 0x4a, 0x83, 0x3d, 0xe0, 0xb2, 0x1c, 0x10, 0, 0x75, 0x12, 0xa1, 0xc0, 0xdd, 0x1b, 0x10, 0x8a, 0x80, 0x20, 0x5, 0x20, 0x10, 0x25, 0xff, 0, 0, 0, 0xeb, 0x5a, 0x8b, 0x48, 0x28, 0x1, 0xf9, 0x51, 0x8b, 0x48, 0x24, 0x1, 0xe9, 0x51, 0x8b, 0x15, 0xe0, 0xb2, 0x1c, 0x10, 0x52, 0x8b, 0x48, 0x18, 0x89, 0xfa, 0xf, 0xaf, 0xd1, 0x8b, 0x40, 0x2c, 0x8b, 0x5c, 0x24, 0x20, 0x1, 0xd0, 0x89, 0xf2, 0x1, 0xe8, 0xe8, 0x6e, 0x3b, 0, 0, 0xeb, 0x2f, 0xf6, 0x44, 0x24, 0x19, 0xff, 0x74, 0x22, 0x89, 0xd8, 0x25, 0xff, 0xff, 0, 0, 0x8b, 0x4, 0x85, 0xbc, 0xd9, 0x1b, 0x10, 0x8a, 0x80, 0x20, 0x5, 0x20, 0x10, 0x89, 0xda, 0x25, 0xff, 0, 0, 0, 0x66, 0x31, 0xda, 0x9, 0xd0, 0xeb, 0x2, 0x89, 0xd8, 0x89, 0x44, 0x24, 0x18, 0x8b, 0x5c, 0x24, 0x18, 0x81, 0xfb, 0, 0x1, 0, 0, 0x7d, 0x1f, 0x8b, 0xc, 0x24, 0x8b, 0x49, 0x18, 0xf, 0xaf, 0xf9, 0x8b, 0x4, 0x24, 0x53, 0x8b, 0x40, 0x2c, 0x89, 0xf2, 0x1, 0xf8, 0x8b, 0x5c, 0x24, 0x18, 0x1, 0xe8, 0xe8, 0xae, 0x3a, 0, 0, 0x83, 0xc4, 0x4, 0x5d, 0x5f, 0x5e, 0xc2, 0x8, 0}))
    II(0x101671f0, 0x1)   pushd(esi);                           /* push esi */
    II(0x101671f1, 0x1)   pushd(edi);                           /* push edi */
    II(0x101671f2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101671f3, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101671f6, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x101671f8, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x101671fa, 0x2)   mov(esi, ecx);                        /* mov esi, ecx */
    II(0x101671fc, 0x5)   calld(/* sys */ 0x10167dac, 0xbab);   /* call 0x10167dac */
    II(0x10167201, 0x6)   mov(edx, memd_a32(ds, 0x101bddbc));   /* mov edx, [0x101bddbc] */
    II(0x10167207, 0x3)   mov(memd_a32(ss, esp), eax);          /* mov [esp], eax */
    II(0x1016720a, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1016720c, 0x6)   jzd(0x101672ca, 0xb8);                /* jz dword 0x101672ca */
    II(0x10167212, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10167214, 0x6)   jzd(0x101672ca, 0xb0);                /* jz dword 0x101672ca */
    II(0x1016721a, 0x4)   mov(ebx, memd_a32(ss, esp + 0x18));   /* mov ebx, [esp+0x18] */
    II(0x1016721e, 0x6)   cmp(ebx, 0x100);                      /* cmp ebx, 0x100 */
    II(0x10167224, 0x2)   jnzd(0x10167270, 0x4a);               /* jnz 0x10167270 */
    II(0x10167226, 0x7)   cmp(memd_a32(ds, 0x101cb2e0), 0);     /* cmp dword [0x101cb2e0], 0x0 */
    II(0x1016722d, 0x2)   jnzd(0x10167241, 0x12);               /* jnz 0x10167241 */
    II(0x1016722f, 0x5)   mov(eax, memd_a32(ds, 0x101bddc0));   /* mov eax, [0x101bddc0] */
    II(0x10167234, 0x6)   mov(al, memb_a32(ds, eax + 0x10200520)); /* mov al, [eax+0x10200520] */
    II(0x1016723a, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1016723f, 0x2)   jmpd(0x1016729b, 0x5a);               /* jmp 0x1016729b */
l_0x10167241:
    II(0x10167241, 0x3)   mov(ecx, memd_a32(ds, eax + 0x28));   /* mov ecx, [eax+0x28] */
    II(0x10167244, 0x2)   add(ecx, edi);                        /* add ecx, edi */
    II(0x10167246, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10167247, 0x3)   mov(ecx, memd_a32(ds, eax + 0x24));   /* mov ecx, [eax+0x24] */
    II(0x1016724a, 0x2)   add(ecx, ebp);                        /* add ecx, ebp */
    II(0x1016724c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016724d, 0x6)   mov(edx, memd_a32(ds, 0x101cb2e0));   /* mov edx, [0x101cb2e0] */
    II(0x10167253, 0x1)   pushd(edx);                           /* push edx */
    II(0x10167254, 0x3)   mov(ecx, memd_a32(ds, eax + 0x18));   /* mov ecx, [eax+0x18] */
    II(0x10167257, 0x2)   mov(edx, edi);                        /* mov edx, edi */
    II(0x10167259, 0x3)   imul(edx, ecx);                       /* imul edx, ecx */
    II(0x1016725c, 0x3)   mov(eax, memd_a32(ds, eax + 0x2c));   /* mov eax, [eax+0x2c] */
    II(0x1016725f, 0x4)   mov(ebx, memd_a32(ss, esp + 0x20));   /* mov ebx, [esp+0x20] */
    II(0x10167263, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10167265, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x10167267, 0x2)   add(eax, ebp);                        /* add eax, ebp */
    II(0x10167269, 0x5)   calld(/* sys */ 0x1016addc, 0x3b6e);  /* call 0x1016addc */
    II(0x1016726e, 0x2)   jmpd(0x1016729f, 0x2f);               /* jmp 0x1016729f */
l_0x10167270:
    II(0x10167270, 0x5)   test(memb_a32(ss, esp + 0x19), 0xff); /* test byte [esp+0x19], 0xff */
    II(0x10167275, 0x2)   jzd(0x10167299, 0x22);                /* jz 0x10167299 */
    II(0x10167277, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10167279, 0x5)   and_(eax, 0xffff);                    /* and eax, 0xffff */
    II(0x1016727e, 0x7)   mov(eax, memd_a32(ds, eax * 0x4 + 0x101bd9bc)); /* mov eax, [eax*4+0x101bd9bc] */
    II(0x10167285, 0x6)   mov(al, memb_a32(ds, eax + 0x10200520)); /* mov al, [eax+0x10200520] */
    II(0x1016728b, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1016728d, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10167292, 0x3)   xor_(dx, bx);                         /* xor dx, bx */
    II(0x10167295, 0x2)   or_(eax, edx);                        /* or eax, edx */
    II(0x10167297, 0x2)   jmpd(0x1016729b, 0x2);                /* jmp 0x1016729b */
l_0x10167299:
    II(0x10167299, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
l_0x1016729b:
    II(0x1016729b, 0x4)   mov(memd_a32(ss, esp + 0x18), eax);   /* mov [esp+0x18], eax */
l_0x1016729f:
    II(0x1016729f, 0x4)   mov(ebx, memd_a32(ss, esp + 0x18));   /* mov ebx, [esp+0x18] */
    II(0x101672a3, 0x6)   cmp(ebx, 0x100);                      /* cmp ebx, 0x100 */
    II(0x101672a9, 0x2)   jged(0x101672ca, 0x1f);               /* jge 0x101672ca */
    II(0x101672ab, 0x3)   mov(ecx, memd_a32(ss, esp));          /* mov ecx, [esp] */
    II(0x101672ae, 0x3)   mov(ecx, memd_a32(ds, ecx + 0x18));   /* mov ecx, [ecx+0x18] */
    II(0x101672b1, 0x3)   imul(edi, ecx);                       /* imul edi, ecx */
    II(0x101672b4, 0x3)   mov(eax, memd_a32(ss, esp));          /* mov eax, [esp] */
    II(0x101672b7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101672b8, 0x3)   mov(eax, memd_a32(ds, eax + 0x2c));   /* mov eax, [eax+0x2c] */
    II(0x101672bb, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x101672bd, 0x2)   add(eax, edi);                        /* add eax, edi */
    II(0x101672bf, 0x4)   mov(ebx, memd_a32(ss, esp + 0x18));   /* mov ebx, [esp+0x18] */
    II(0x101672c3, 0x2)   add(eax, ebp);                        /* add eax, ebp */
    II(0x101672c5, 0x5)   calld(/* sys */ 0x1016ad78, 0x3aae);  /* call 0x1016ad78 */
l_0x101672ca:
    II(0x101672ca, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x101672cd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101672ce, 0x1)   popd(edi);                            /* pop edi */
    II(0x101672cf, 0x1)   popd(esi);                            /* pop esi */
    II(0x101672d0, 0x3)   retd(0x8);                            /* ret 0x8 */
FUNC_END

