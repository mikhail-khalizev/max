FUNC_BEGIN(0x10133c5b, 0x42d7aeef4d59c6c9, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xed, 0x20, 0x3, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xf, 0xbf, 0, 0x3, 0x45, 0xf8, 0x80, 0x38, 0x20, 0x75, 0x8, 0x8b, 0x45, 0xfc, 0x66, 0xff, 0, 0xeb, 0xea, 0x8b, 0x45, 0xfc, 0xf, 0xbf, 0, 0x3, 0x45, 0xf8, 0xe8, 0x32, 0x54, 0x4, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xfc, 0xf, 0xbf, 0, 0x3, 0x45, 0xf8, 0x80, 0x38, 0x20, 0x74, 0x14, 0x8b, 0x45, 0xfc, 0xf, 0xbf, 0, 0x3, 0x45, 0xf8, 0x8a, 0, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x75, 0x2, 0xeb, 0x8, 0x8b, 0x45, 0xfc, 0x66, 0xff, 0, 0xeb, 0xd4, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10133c5b, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10133c60, 0x5)   calld(sys_check_available_stack_size, 0x320ed); /* call 0x10165d52 */
    II(0x10133c65, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10133c66, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10133c67, 0x1)   pushd(esi);                           /* push esi */
    II(0x10133c68, 0x1)   pushd(edi);                           /* push edi */
    II(0x10133c69, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10133c6a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10133c6c, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10133c72, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10133c75, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
l_0x10133c78:
    II(0x10133c78, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10133c7b, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x10133c7e, 0x3)   add(eax, memd_a32(ss, ebp - 0x8));    /* add eax, [ebp-0x8] */
    II(0x10133c81, 0x3)   cmp(memb_a32(ds, eax), 0x20);         /* cmp byte [eax], 0x20 */
    II(0x10133c84, 0x2)   jnzd(0x10133c8e, 0x8);                /* jnz 0x10133c8e */
    II(0x10133c86, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10133c89, 0x3)   inc(memw_a32(ds, eax));               /* inc word [eax] */
    II(0x10133c8c, 0x2)   jmpd(0x10133c78, -0x16);              /* jmp 0x10133c78 */
l_0x10133c8e:
    II(0x10133c8e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10133c91, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x10133c94, 0x3)   add(eax, memd_a32(ss, ebp - 0x8));    /* add eax, [ebp-0x8] */
    II(0x10133c97, 0x5)   calld(/* sys */ 0x101790ce, 0x45432); /* call 0x101790ce */
    II(0x10133c9c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x10133c9f:
    II(0x10133c9f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10133ca2, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x10133ca5, 0x3)   add(eax, memd_a32(ss, ebp - 0x8));    /* add eax, [ebp-0x8] */
    II(0x10133ca8, 0x3)   cmp(memb_a32(ds, eax), 0x20);         /* cmp byte [eax], 0x20 */
    II(0x10133cab, 0x2)   jzd(0x10133cc1, 0x14);                /* jz 0x10133cc1 */
    II(0x10133cad, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10133cb0, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x10133cb3, 0x3)   add(eax, memd_a32(ss, ebp - 0x8));    /* add eax, [ebp-0x8] */
    II(0x10133cb6, 0x2)   mov(al, memb_a32(ds, eax));           /* mov al, [eax] */
    II(0x10133cb8, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10133cbd, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10133cbf, 0x2)   jnzd(0x10133cc3, 0x2);                /* jnz 0x10133cc3 */
l_0x10133cc1:
    II(0x10133cc1, 0x2)   jmpd(0x10133ccb, 0x8);                /* jmp 0x10133ccb */
l_0x10133cc3:
    II(0x10133cc3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10133cc6, 0x3)   inc(memw_a32(ds, eax));               /* inc word [eax] */
    II(0x10133cc9, 0x2)   jmpd(0x10133c9f, -0x2c);              /* jmp 0x10133c9f */
l_0x10133ccb:
    II(0x10133ccb, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10133cce, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x10133cd1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10133cd4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10133cd6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10133cd7, 0x1)   popd(edi);                            /* pop edi */
    II(0x10133cd8, 0x1)   popd(esi);                            /* pop esi */
    II(0x10133cd9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10133cda, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10133cdb, 0x1)   retd();                               /* ret */
FUNC_END

