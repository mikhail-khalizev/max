FUNC_BEGIN(0x1013cf8e, 0x89effde4622cc0a, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0xba, 0x8d, 0x2, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x2c, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x55, 0xf4, 0x66, 0x3b, 0x42, 0xc, 0x74, 0x7, 0x66, 0x83, 0x7d, 0xf8, 0xff, 0x75, 0x5, 0xe9, 0xbe, 0, 0, 0, 0xb8, 0x39, 0, 0, 0, 0xe8, 0xd, 0x90, 0xf3, 0xff, 0x85, 0xc0, 0x74, 0xf, 0x8b, 0x45, 0xf8, 0x8b, 0x55, 0xf4, 0x66, 0x89, 0x42, 0xe, 0xe9, 0xa1, 0, 0, 0, 0x8b, 0x45, 0xf4, 0xe8, 0x27, 0x1, 0, 0, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf4, 0x88, 0x82, 0xc9, 0xd, 0, 0, 0x80, 0x7d, 0xfc, 0, 0x74, 0x12, 0x66, 0x81, 0x7d, 0xf8, 0xa5, 0x6, 0x7c, 0x8, 0x66, 0x81, 0x7d, 0xf8, 0xae, 0x6, 0x7e, 0x2, 0xeb, 0x2, 0xeb, 0x25, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf0, 0xff, 0x45, 0xf0, 0xf, 0xbf, 0x45, 0xf0, 0x83, 0xf8, 0xa, 0x74, 0xd, 0xf, 0xbf, 0x45, 0xf0, 0xc6, 0x80, 0x84, 0x80, 0x1c, 0x10, 0x1, 0xeb, 0xe4, 0xc6, 0x45, 0xde, 0x4, 0x8b, 0x45, 0xf8, 0x66, 0x89, 0x45, 0xd4, 0xc7, 0x45, 0xd6, 0xff, 0x7f, 0, 0, 0xc7, 0x45, 0xda, 0xff, 0x7f, 0, 0, 0xc7, 0x45, 0xdf, 0, 0x80, 0, 0, 0xc7, 0x45, 0xe3, 0, 0, 0, 0, 0x66, 0xc7, 0x45, 0xe7, 0, 0, 0x66, 0xc7, 0x45, 0xe9, 0, 0, 0x66, 0xc7, 0x45, 0xeb, 0, 0, 0xc6, 0x45, 0xed, 0, 0x66, 0xc7, 0x45, 0xee, 0xff, 0xff, 0x8d, 0x55, 0xd4, 0x8b, 0x45, 0xf4, 0xe8, 0x4e, 0xf, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1013cf8e, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x1013cf93, 0x5)   calld(sys_check_available_stack_size, 0x28dba); /* call 0x10165d52 */
    II(0x1013cf98, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013cf99, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013cf9a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013cf9b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013cf9c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013cf9e, 0x6)   sub(esp, 0x2c);                       /* sub esp, 0x2c */
    II(0x1013cfa4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1013cfa7, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1013cfaa, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x1013cfad, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013cfb0, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x1013cfb3, 0x4)   cmp(ax, memw_a32(ds, edx + 0xc));     /* cmp ax, [edx+0xc] */
    II(0x1013cfb7, 0x2)   jzd(0x1013cfc0, 0x7);                 /* jz 0x1013cfc0 */
    II(0x1013cfb9, 0x5)   cmp(memw_a32(ss, ebp - 0x8), -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xff */
    II(0x1013cfbe, 0x2)   jnzd(0x1013cfc5, 0x5);                /* jnz 0x1013cfc5 */
l_0x1013cfc0:
    II(0x1013cfc0, 0x5)   jmpd(0x1013d083, 0xbe);               /* jmp 0x1013d083 */
l_0x1013cfc5:
    II(0x1013cfc5, 0x5)   mov(eax, 0x39);                       /* mov eax, 0x39 */
    II(0x1013cfca, 0x5)   calld(0x10075fdc, -0xc6ff3);          /* call 0x10075fdc */
    II(0x1013cfcf, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1013cfd1, 0x2)   jzd(0x1013cfe2, 0xf);                 /* jz 0x1013cfe2 */
    II(0x1013cfd3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013cfd6, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x1013cfd9, 0x4)   mov(memw_a32(ds, edx + 0xe), ax);     /* mov [edx+0xe], ax */
    II(0x1013cfdd, 0x5)   jmpd(0x1013d083, 0xa1);               /* jmp 0x1013d083 */
l_0x1013cfe2:
    II(0x1013cfe2, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013cfe5, 0x5)   calld(0x1013d111, 0x127);             /* call 0x1013d111 */
    II(0x1013cfea, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1013cfed, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x1013cff0, 0x6)   mov(memb_a32(ds, edx + 0xdc9), al);   /* mov [edx+0xdc9], al */
    II(0x1013cff6, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0);      /* cmp byte [ebp-0x4], 0x0 */
    II(0x1013cffa, 0x2)   jzd(0x1013d00e, 0x12);                /* jz 0x1013d00e */
    II(0x1013cffc, 0x6)   cmp(memw_a32(ss, ebp - 0x8), 0x6a5);  /* cmp word [ebp-0x8], 0x6a5 */
    II(0x1013d002, 0x2)   jld(0x1013d00c, 0x8);                 /* jl 0x1013d00c */
    II(0x1013d004, 0x6)   cmp(memw_a32(ss, ebp - 0x8), 0x6ae);  /* cmp word [ebp-0x8], 0x6ae */
    II(0x1013d00a, 0x2)   jled(0x1013d00e, 0x2);                /* jle 0x1013d00e */
l_0x1013d00c:
    II(0x1013d00c, 0x2)   jmpd(0x1013d010, 0x2);                /* jmp 0x1013d010 */
l_0x1013d00e:
    II(0x1013d00e, 0x2)   jmpd(0x1013d035, 0x25);               /* jmp 0x1013d035 */
l_0x1013d010:
    II(0x1013d010, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x1013d017, 0x2)   jmpd(0x1013d01f, 0x6);                /* jmp 0x1013d01f */
l_0x1013d019:
    II(0x1013d019, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013d01c, 0x3)   inc(memd_a32(ss, ebp - 0x10));        /* inc dword [ebp-0x10] */
l_0x1013d01f:
    II(0x1013d01f, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x1013d023, 0x3)   cmp(eax, 0xa);                        /* cmp eax, 0xa */
    II(0x1013d026, 0x2)   jzd(0x1013d035, 0xd);                 /* jz 0x1013d035 */
    II(0x1013d028, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x1013d02c, 0x7)   mov(memb_a32(ds, eax + 0x101c8084), 0x1); /* mov byte [eax+0x101c8084], 0x1 */
    II(0x1013d033, 0x2)   jmpd(0x1013d019, -0x1c);              /* jmp 0x1013d019 */
l_0x1013d035:
    II(0x1013d035, 0x4)   mov(memb_a32(ss, ebp - 0x22), 0x4);   /* mov byte [ebp-0x22], 0x4 */
    II(0x1013d039, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013d03c, 0x4)   mov(memw_a32(ss, ebp - 0x2c), ax);    /* mov [ebp-0x2c], ax */
    II(0x1013d040, 0x7)   mov(memd_a32(ss, ebp - 0x2a), 0x7fff); /* mov dword [ebp-0x2a], 0x7fff */
    II(0x1013d047, 0x7)   mov(memd_a32(ss, ebp - 0x26), 0x7fff); /* mov dword [ebp-0x26], 0x7fff */
    II(0x1013d04e, 0x7)   mov(memd_a32(ss, ebp - 0x21), 0x8000); /* mov dword [ebp-0x21], 0x8000 */
    II(0x1013d055, 0x7)   mov(memd_a32(ss, ebp - 0x1d), 0);     /* mov dword [ebp-0x1d], 0x0 */
    II(0x1013d05c, 0x6)   mov(memw_a32(ss, ebp - 0x19), 0);     /* mov word [ebp-0x19], 0x0 */
    II(0x1013d062, 0x6)   mov(memw_a32(ss, ebp - 0x17), 0);     /* mov word [ebp-0x17], 0x0 */
    II(0x1013d068, 0x6)   mov(memw_a32(ss, ebp - 0x15), 0);     /* mov word [ebp-0x15], 0x0 */
    II(0x1013d06e, 0x4)   mov(memb_a32(ss, ebp - 0x13), 0);     /* mov byte [ebp-0x13], 0x0 */
    II(0x1013d072, 0x6)   mov(memw_a32(ss, ebp - 0x12), 0xffff); /* mov word [ebp-0x12], 0xffff */
    II(0x1013d078, 0x3)   lea(edx, ebp - 0x2c);                 /* lea edx, [ebp-0x2c] */
    II(0x1013d07b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013d07e, 0x5)   calld(0x1013dfd1, 0xf4e);             /* call 0x1013dfd1 */
l_0x1013d083:
    II(0x1013d083, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013d085, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013d086, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013d087, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013d088, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013d089, 0x1)   retd();                               /* ret */
FUNC_END

