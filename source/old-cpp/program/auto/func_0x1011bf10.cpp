FUNC_BEGIN(0x1011bf10, 0xf98c6167474b3f48, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x38, 0x9e, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x8b, 0x45, 0xf8, 0xf, 0xbf, 0x10, 0xc1, 0xe2, 0x2, 0xa1, 0x68, 0x53, 0x1c, 0x10, 0x1, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xc1, 0xf8, 0x10, 0x8b, 0x12, 0x1, 0xd0, 0x8a, 0, 0x88, 0x45, 0xf0, 0xff, 0x5, 0xec, 0x52, 0x1c, 0x10, 0x80, 0x7d, 0xfc, 0, 0x74, 0x4f, 0x8b, 0x45, 0xf4, 0xf, 0xbf, 0x10, 0xc1, 0xe2, 0x2, 0xa1, 0x68, 0x53, 0x1c, 0x10, 0x1, 0xc2, 0x8b, 0x45, 0xf4, 0x8b, 0, 0xc1, 0xf8, 0x10, 0x8b, 0x12, 0x1, 0xd0, 0x8a, 0, 0x88, 0x45, 0xec, 0xf6, 0x45, 0xf0, 0x40, 0x74, 0x6, 0xf6, 0x45, 0xec, 0x80, 0x75, 0x2, 0xeb, 0x9, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0xeb, 0x21, 0xf6, 0x45, 0xec, 0x40, 0x74, 0x6, 0xf6, 0x45, 0xf0, 0x80, 0x75, 0x2, 0xeb, 0x9, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0xeb, 0xa, 0x8a, 0x45, 0xf0, 0x24, 0x1f, 0x30, 0xe4, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1011bf10, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x1011bf15, 0x5)   calld(sys_check_available_stack_size, 0x49e38); /* call 0x10165d52 */
    II(0x1011bf1a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011bf1b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011bf1c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011bf1d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011bf1e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011bf20, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x1011bf26, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1011bf29, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1011bf2c, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x1011bf2f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011bf32, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x1011bf35, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x1011bf38, 0x5)   mov(eax, memd_a32(ds, 0x101c5368));   /* mov eax, [0x101c5368] */
    II(0x1011bf3d, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1011bf3f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011bf42, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011bf44, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1011bf47, 0x2)   mov(edx, memd_a32(ds, edx));          /* mov edx, [edx] */
    II(0x1011bf49, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1011bf4b, 0x2)   mov(al, memb_a32(ds, eax));           /* mov al, [eax] */
    II(0x1011bf4d, 0x3)   mov(memb_a32(ss, ebp - 0x10), al);    /* mov [ebp-0x10], al */
    II(0x1011bf50, 0x6)   inc(memd_a32(ds, 0x101c52ec));        /* inc dword [0x101c52ec] */
    II(0x1011bf56, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0);      /* cmp byte [ebp-0x4], 0x0 */
    II(0x1011bf5a, 0x2)   jzd(0x1011bfab, 0x4f);                /* jz 0x1011bfab */
    II(0x1011bf5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011bf5f, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x1011bf62, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x1011bf65, 0x5)   mov(eax, memd_a32(ds, 0x101c5368));   /* mov eax, [0x101c5368] */
    II(0x1011bf6a, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1011bf6c, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011bf6f, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011bf71, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1011bf74, 0x2)   mov(edx, memd_a32(ds, edx));          /* mov edx, [edx] */
    II(0x1011bf76, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1011bf78, 0x2)   mov(al, memb_a32(ds, eax));           /* mov al, [eax] */
    II(0x1011bf7a, 0x3)   mov(memb_a32(ss, ebp - 0x14), al);    /* mov [ebp-0x14], al */
    II(0x1011bf7d, 0x4)   test(memb_a32(ss, ebp - 0x10), 0x40); /* test byte [ebp-0x10], 0x40 */
    II(0x1011bf81, 0x2)   jzd(0x1011bf89, 0x6);                 /* jz 0x1011bf89 */
    II(0x1011bf83, 0x4)   test(memb_a32(ss, ebp - 0x14), 0x80); /* test byte [ebp-0x14], 0x80 */
    II(0x1011bf87, 0x2)   jnzd(0x1011bf8b, 0x2);                /* jnz 0x1011bf8b */
l_0x1011bf89:
    II(0x1011bf89, 0x2)   jmpd(0x1011bf94, 0x9);                /* jmp 0x1011bf94 */
l_0x1011bf8b:
    II(0x1011bf8b, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
    II(0x1011bf92, 0x2)   jmpd(0x1011bfb5, 0x21);               /* jmp 0x1011bfb5 */
l_0x1011bf94:
    II(0x1011bf94, 0x4)   test(memb_a32(ss, ebp - 0x14), 0x40); /* test byte [ebp-0x14], 0x40 */
    II(0x1011bf98, 0x2)   jzd(0x1011bfa0, 0x6);                 /* jz 0x1011bfa0 */
    II(0x1011bf9a, 0x4)   test(memb_a32(ss, ebp - 0x10), 0x80); /* test byte [ebp-0x10], 0x80 */
    II(0x1011bf9e, 0x2)   jnzd(0x1011bfa2, 0x2);                /* jnz 0x1011bfa2 */
l_0x1011bfa0:
    II(0x1011bfa0, 0x2)   jmpd(0x1011bfab, 0x9);                /* jmp 0x1011bfab */
l_0x1011bfa2:
    II(0x1011bfa2, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
    II(0x1011bfa9, 0x2)   jmpd(0x1011bfb5, 0xa);                /* jmp 0x1011bfb5 */
l_0x1011bfab:
    II(0x1011bfab, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x1011bfae, 0x2)   and_(al, 0x1f);                       /* and al, 0x1f */
    II(0x1011bfb0, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1011bfb2, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
l_0x1011bfb5:
    II(0x1011bfb5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1011bfb8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011bfba, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011bfbb, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011bfbc, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011bfbd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011bfbe, 0x1)   retd();                               /* ret */
FUNC_END

