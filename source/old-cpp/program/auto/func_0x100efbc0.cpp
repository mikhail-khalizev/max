FUNC_BEGIN(0x100efbc0, 0x8bf9f1e0f944e2cc, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0x88, 0x61, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x28, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0x45, 0xf8, 0x2, 0x66, 0x8b, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4c, 0x89, 0x45, 0xf0, 0xff, 0x4d, 0xf4, 0x66, 0x83, 0x7d, 0xf4, 0xff, 0xf, 0x84, 0x14, 0x1, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x45, 0xf8, 0x2, 0x66, 0x8b, 0, 0x89, 0x45, 0xec, 0xf, 0xbf, 0x45, 0xec, 0x85, 0xc0, 0x7d, 0x3f, 0x66, 0xf7, 0x45, 0xec, 0, 0x40, 0x74, 0x15, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x67, 0xc1, 0xf8, 0x10, 0xf, 0xbf, 0x55, 0xec, 0xf, 0xaf, 0xc2, 0x29, 0x45, 0xf0, 0xeb, 0x12, 0x8a, 0x55, 0xec, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x61, 0xc1, 0xf8, 0x10, 0x3, 0x45, 0xf0, 0x88, 0x50, 0xff, 0x8b, 0x45, 0xf8, 0x83, 0x45, 0xf8, 0x2, 0x66, 0x8b, 0, 0x66, 0x89, 0x45, 0xec, 0xeb, 0xb9, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0x66, 0xff, 0x4d, 0xec, 0x66, 0x83, 0x7d, 0xec, 0xff, 0xf, 0x84, 0x99, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x45, 0xf8, 0x2, 0x66, 0x8b, 0, 0x66, 0x89, 0x45, 0xe4, 0x8a, 0x45, 0xe4, 0x30, 0xe4, 0x89, 0x45, 0xe0, 0x8b, 0x45, 0xe0, 0x1, 0x45, 0xe8, 0xf, 0xbf, 0x45, 0xe4, 0xc1, 0xf8, 0x8, 0x66, 0x98, 0x66, 0x89, 0x45, 0xe4, 0xf, 0xbf, 0x45, 0xe4, 0x85, 0xc0, 0x7c, 0x28, 0xf, 0xbf, 0x5d, 0xe4, 0x1, 0xdb, 0x8b, 0x55, 0xf8, 0xf, 0xbf, 0x45, 0xe8, 0x3, 0x45, 0xf0, 0xe8, 0x9a, 0x61, 0x7, 0, 0xf, 0xbf, 0x45, 0xe4, 0x1, 0xc0, 0x1, 0x45, 0xf8, 0x8b, 0x45, 0xe4, 0x1, 0xc0, 0x1, 0x45, 0xe8, 0xeb, 0x3b, 0x8b, 0x45, 0xf8, 0x83, 0x45, 0xf8, 0x2, 0x66, 0x8b, 0, 0x89, 0x45, 0xdc, 0xf, 0xbf, 0x45, 0xe8, 0x8b, 0x55, 0xf0, 0x1, 0xc2, 0x89, 0x55, 0xd8, 0x8b, 0x45, 0xe4, 0x1, 0xc0, 0x29, 0x45, 0xe8, 0x66, 0xff, 0x45, 0xe4, 0x66, 0x83, 0x7d, 0xe4, 0x1, 0x74, 0xf, 0x8b, 0x55, 0xd8, 0x83, 0x45, 0xd8, 0x2, 0x8b, 0x45, 0xdc, 0x66, 0x89, 0x2, 0xeb, 0xe6, 0xe9, 0x58, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x67, 0xc1, 0xf8, 0x10, 0x1, 0x45, 0xf0, 0xe9, 0xde, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100efbc0, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x100efbc5, 0x5)   calld(sys_check_available_stack_size, 0x76188); /* call 0x10165d52 */
    II(0x100efbca, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100efbcb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100efbcc, 0x1)   pushd(esi);                           /* push esi */
    II(0x100efbcd, 0x1)   pushd(edi);                           /* push edi */
    II(0x100efbce, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100efbcf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100efbd1, 0x6)   sub(esp, 0x28);                       /* sub esp, 0x28 */
    II(0x100efbd7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100efbda, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100efbdd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100efbe0, 0x4)   add(memd_a32(ss, ebp - 0x8), 0x2);    /* add dword [ebp-0x8], 0x2 */
    II(0x100efbe4, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100efbe7, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100efbea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100efbed, 0x3)   mov(eax, memd_a32(ds, eax + 0x4c));   /* mov eax, [eax+0x4c] */
    II(0x100efbf0, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
l_0x100efbf3:
    II(0x100efbf3, 0x3)   dec(memd_a32(ss, ebp - 0xc));         /* dec dword [ebp-0xc] */
    II(0x100efbf6, 0x5)   cmp(memw_a32(ss, ebp - 0xc), -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xff */
    II(0x100efbfb, 0x6)   jzd(0x100efd15, 0x114);               /* jz dword 0x100efd15 */
    II(0x100efc01, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100efc04, 0x4)   add(memd_a32(ss, ebp - 0x8), 0x2);    /* add dword [ebp-0x8], 0x2 */
    II(0x100efc08, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100efc0b, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
l_0x100efc0e:
    II(0x100efc0e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x14)); /* movsx eax, word [ebp-0x14] */
    II(0x100efc12, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100efc14, 0x2)   jged(0x100efc55, 0x3f);               /* jge 0x100efc55 */
    II(0x100efc16, 0x6)   test(memw_a32(ss, ebp - 0x14), 0x4000); /* test word [ebp-0x14], 0x4000 */
    II(0x100efc1c, 0x2)   jzd(0x100efc33, 0x15);                /* jz 0x100efc33 */
    II(0x100efc1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100efc21, 0x3)   mov(eax, memd_a32(ds, eax + 0x67));   /* mov eax, [eax+0x67] */
    II(0x100efc24, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100efc27, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x14)); /* movsx edx, word [ebp-0x14] */
    II(0x100efc2b, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x100efc2e, 0x3)   sub(memd_a32(ss, ebp - 0x10), eax);   /* sub [ebp-0x10], eax */
    II(0x100efc31, 0x2)   jmpd(0x100efc45, 0x12);               /* jmp 0x100efc45 */
l_0x100efc33:
    II(0x100efc33, 0x3)   mov(dl, memb_a32(ss, ebp - 0x14));    /* mov dl, [ebp-0x14] */
    II(0x100efc36, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100efc39, 0x3)   mov(eax, memd_a32(ds, eax + 0x61));   /* mov eax, [eax+0x61] */
    II(0x100efc3c, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100efc3f, 0x3)   add(eax, memd_a32(ss, ebp - 0x10));   /* add eax, [ebp-0x10] */
    II(0x100efc42, 0x3)   mov(memb_a32(ds, eax - 0x1), dl);     /* mov [eax-0x1], dl */
l_0x100efc45:
    II(0x100efc45, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100efc48, 0x4)   add(memd_a32(ss, ebp - 0x8), 0x2);    /* add dword [ebp-0x8], 0x2 */
    II(0x100efc4c, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100efc4f, 0x4)   mov(memw_a32(ss, ebp - 0x14), ax);    /* mov [ebp-0x14], ax */
    II(0x100efc53, 0x2)   jmpd(0x100efc0e, -0x47);              /* jmp 0x100efc0e */
l_0x100efc55:
    II(0x100efc55, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
l_0x100efc5c:
    II(0x100efc5c, 0x4)   dec(memw_a32(ss, ebp - 0x14));        /* dec word [ebp-0x14] */
    II(0x100efc60, 0x5)   cmp(memw_a32(ss, ebp - 0x14), -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xff */
    II(0x100efc65, 0x6)   jzd(0x100efd04, 0x99);                /* jz dword 0x100efd04 */
    II(0x100efc6b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100efc6e, 0x4)   add(memd_a32(ss, ebp - 0x8), 0x2);    /* add dword [ebp-0x8], 0x2 */
    II(0x100efc72, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100efc75, 0x4)   mov(memw_a32(ss, ebp - 0x1c), ax);    /* mov [ebp-0x1c], ax */
    II(0x100efc79, 0x3)   mov(al, memb_a32(ss, ebp - 0x1c));    /* mov al, [ebp-0x1c] */
    II(0x100efc7c, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x100efc7e, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
//    II(0x100efc81, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100efc84, 0x3)   add(memd_a32(ss, ebp - 0x18), eax);   /* add [ebp-0x18], eax */
    II(0x100efc87, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x100efc8b, 0x3)   sar(eax, 0x8);                        /* sar eax, 0x8 */
    II(0x100efc8e, 0x2)   cbw();                                /* cbw */
    II(0x100efc90, 0x4)   mov(memw_a32(ss, ebp - 0x1c), ax);    /* mov [ebp-0x1c], ax */
    II(0x100efc94, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x100efc98, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100efc9a, 0x2)   jld(0x100efcc4, 0x28);                /* jl 0x100efcc4 */
    II(0x100efc9c, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x1c)); /* movsx ebx, word [ebp-0x1c] */
    II(0x100efca0, 0x2)   add(ebx, ebx);                        /* add ebx, ebx */
    II(0x100efca2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100efca5, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x18)); /* movsx eax, word [ebp-0x18] */
    II(0x100efca9, 0x3)   add(eax, memd_a32(ss, ebp - 0x10));   /* add eax, [ebp-0x10] */
    II(0x100efcac, 0x5)   calld(sys_memcpy, 0x7619a);           /* call 0x10165e4b */
    II(0x100efcb1, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x100efcb5, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100efcb7, 0x3)   add(memd_a32(ss, ebp - 0x8), eax);    /* add [ebp-0x8], eax */
    II(0x100efcba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100efcbd, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100efcbf, 0x3)   add(memd_a32(ss, ebp - 0x18), eax);   /* add [ebp-0x18], eax */
    II(0x100efcc2, 0x2)   jmpd(0x100efcff, 0x3b);               /* jmp 0x100efcff */
l_0x100efcc4:
    II(0x100efcc4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100efcc7, 0x4)   add(memd_a32(ss, ebp - 0x8), 0x2);    /* add dword [ebp-0x8], 0x2 */
    II(0x100efccb, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100efcce, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
    II(0x100efcd1, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x18)); /* movsx eax, word [ebp-0x18] */
    II(0x100efcd5, 0x3)   mov(edx, memd_a32(ss, ebp - 0x10));   /* mov edx, [ebp-0x10] */
    II(0x100efcd8, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100efcda, 0x3)   mov(memd_a32(ss, ebp - 0x28), edx);   /* mov [ebp-0x28], edx */
    II(0x100efcdd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100efce0, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100efce2, 0x3)   sub(memd_a32(ss, ebp - 0x18), eax);   /* sub [ebp-0x18], eax */
l_0x100efce5:
    II(0x100efce5, 0x4)   inc(memw_a32(ss, ebp - 0x1c));        /* inc word [ebp-0x1c] */
    II(0x100efce9, 0x5)   cmp(memw_a32(ss, ebp - 0x1c), 0x1);   /* cmp word [ebp-0x1c], 0x1 */
    II(0x100efcee, 0x2)   jzd(0x100efcff, 0xf);                 /* jz 0x100efcff */
    II(0x100efcf0, 0x3)   mov(edx, memd_a32(ss, ebp - 0x28));   /* mov edx, [ebp-0x28] */
    II(0x100efcf3, 0x4)   add(memd_a32(ss, ebp - 0x28), 0x2);   /* add dword [ebp-0x28], 0x2 */
    II(0x100efcf7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100efcfa, 0x3)   mov(memw_a32(ds, edx), ax);           /* mov [edx], ax */
    II(0x100efcfd, 0x2)   jmpd(0x100efce5, -0x1a);              /* jmp 0x100efce5 */
l_0x100efcff:
    II(0x100efcff, 0x5)   jmpd(0x100efc5c, -0xa8);              /* jmp 0x100efc5c */
l_0x100efd04:
    II(0x100efd04, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100efd07, 0x3)   mov(eax, memd_a32(ds, eax + 0x67));   /* mov eax, [eax+0x67] */
    II(0x100efd0a, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100efd0d, 0x3)   add(memd_a32(ss, ebp - 0x10), eax);   /* add [ebp-0x10], eax */
    II(0x100efd10, 0x5)   jmpd(0x100efbf3, -0x122);             /* jmp 0x100efbf3 */
l_0x100efd15:
    II(0x100efd15, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100efd17, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100efd18, 0x1)   popd(edi);                            /* pop edi */
    II(0x100efd19, 0x1)   popd(esi);                            /* pop esi */
    II(0x100efd1a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100efd1b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100efd1c, 0x1)   retd();                               /* ret */
FUNC_END

