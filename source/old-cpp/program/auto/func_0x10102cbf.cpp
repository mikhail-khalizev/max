FUNC_BEGIN(0x10102cbf, 0xb2eddde4c03219fb, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x89, 0x30, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x10, 0x7a, 0x3, 0, 0x8d, 0x55, 0xf4, 0x8b, 0x45, 0xfc, 0xe8, 0x8c, 0x8e, 0x3, 0, 0xff, 0x4d, 0xf4, 0x66, 0x83, 0x7d, 0xf4, 0xff, 0xf, 0x84, 0x8a, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x87, 0x8f, 0x3, 0, 0x89, 0x45, 0xf0, 0x8b, 0x55, 0xf0, 0x8b, 0x45, 0xf8, 0xe8, 0x9, 0x7e, 0xf8, 0xff, 0x8b, 0x45, 0xf0, 0xf6, 0x40, 0x13, 0x20, 0x74, 0xe, 0x8b, 0x15, 0xa0, 0x70, 0x1c, 0x10, 0x8b, 0x45, 0xf0, 0x89, 0x50, 0x22, 0xeb, 0x51, 0x8b, 0x45, 0xf0, 0xf6, 0x40, 0x13, 0x10, 0x74, 0xe, 0x8b, 0x15, 0xa4, 0x70, 0x1c, 0x10, 0x8b, 0x45, 0xf0, 0x89, 0x50, 0x22, 0xeb, 0x3a, 0x8b, 0x45, 0xf0, 0xf6, 0x40, 0x13, 0x8, 0x74, 0xe, 0x8b, 0x15, 0xa8, 0x70, 0x1c, 0x10, 0x8b, 0x45, 0xf0, 0x89, 0x50, 0x22, 0xeb, 0x23, 0x8b, 0x45, 0xf0, 0xf6, 0x40, 0x13, 0x4, 0x74, 0xe, 0x8b, 0x15, 0xac, 0x70, 0x1c, 0x10, 0x8b, 0x45, 0xf0, 0x89, 0x50, 0x22, 0xeb, 0xc, 0x8b, 0x15, 0xb0, 0x70, 0x1c, 0x10, 0x8b, 0x45, 0xf0, 0x89, 0x50, 0x22, 0x8b, 0x45, 0xf0, 0xc6, 0x40, 0x2c, 0, 0xe9, 0x68, 0xff, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10102cbf, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10102cc4, 0x5)   calld(sys_check_available_stack_size, 0x63089); /* call 0x10165d52 */
    II(0x10102cc9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10102cca, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10102ccb, 0x1)   pushd(esi);                           /* push esi */
    II(0x10102ccc, 0x1)   pushd(edi);                           /* push edi */
    II(0x10102ccd, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10102cce, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10102cd0, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10102cd6, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10102cd9, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10102cdc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10102cdf, 0x5)   calld(0x1013a6f4, 0x37a10);           /* call 0x1013a6f4 */
    II(0x10102ce4, 0x3)   lea(edx, ebp - 0xc);                  /* lea edx, [ebp-0xc] */
    II(0x10102ce7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10102cea, 0x5)   calld(0x1013bb7b, 0x38e8c);           /* call 0x1013bb7b */
l_0x10102cef:
    II(0x10102cef, 0x3)   dec(memd_a32(ss, ebp - 0xc));         /* dec dword [ebp-0xc] */
    II(0x10102cf2, 0x5)   cmp(memw_a32(ss, ebp - 0xc), -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xff */
    II(0x10102cf7, 0x6)   jzd(0x10102d87, 0x8a);                /* jz dword 0x10102d87 */
    II(0x10102cfd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10102d00, 0x5)   calld(0x1013bc8c, 0x38f87);           /* call 0x1013bc8c */
    II(0x10102d05, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10102d08, 0x3)   mov(edx, memd_a32(ss, ebp - 0x10));   /* mov edx, [ebp-0x10] */
    II(0x10102d0b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10102d0e, 0x5)   calld(0x1008ab1c, -0x781f7);          /* call 0x1008ab1c */
    II(0x10102d13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d16, 0x4)   test(memb_a32(ds, eax + 0x13), 0x20); /* test byte [eax+0x13], 0x20 */
    II(0x10102d1a, 0x2)   jzd(0x10102d2a, 0xe);                 /* jz 0x10102d2a */
    II(0x10102d1c, 0x6)   mov(edx, memd_a32(ds, 0x101c70a0));   /* mov edx, [0x101c70a0] */
    II(0x10102d22, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d25, 0x3)   mov(memd_a32(ds, eax + 0x22), edx);   /* mov [eax+0x22], edx */
    II(0x10102d28, 0x2)   jmpd(0x10102d7b, 0x51);               /* jmp 0x10102d7b */
l_0x10102d2a:
    II(0x10102d2a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d2d, 0x4)   test(memb_a32(ds, eax + 0x13), 0x10); /* test byte [eax+0x13], 0x10 */
    II(0x10102d31, 0x2)   jzd(0x10102d41, 0xe);                 /* jz 0x10102d41 */
    II(0x10102d33, 0x6)   mov(edx, memd_a32(ds, 0x101c70a4));   /* mov edx, [0x101c70a4] */
    II(0x10102d39, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d3c, 0x3)   mov(memd_a32(ds, eax + 0x22), edx);   /* mov [eax+0x22], edx */
    II(0x10102d3f, 0x2)   jmpd(0x10102d7b, 0x3a);               /* jmp 0x10102d7b */
l_0x10102d41:
    II(0x10102d41, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d44, 0x4)   test(memb_a32(ds, eax + 0x13), 0x8);  /* test byte [eax+0x13], 0x8 */
    II(0x10102d48, 0x2)   jzd(0x10102d58, 0xe);                 /* jz 0x10102d58 */
    II(0x10102d4a, 0x6)   mov(edx, memd_a32(ds, 0x101c70a8));   /* mov edx, [0x101c70a8] */
    II(0x10102d50, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d53, 0x3)   mov(memd_a32(ds, eax + 0x22), edx);   /* mov [eax+0x22], edx */
    II(0x10102d56, 0x2)   jmpd(0x10102d7b, 0x23);               /* jmp 0x10102d7b */
l_0x10102d58:
    II(0x10102d58, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d5b, 0x4)   test(memb_a32(ds, eax + 0x13), 0x4);  /* test byte [eax+0x13], 0x4 */
    II(0x10102d5f, 0x2)   jzd(0x10102d6f, 0xe);                 /* jz 0x10102d6f */
    II(0x10102d61, 0x6)   mov(edx, memd_a32(ds, 0x101c70ac));   /* mov edx, [0x101c70ac] */
    II(0x10102d67, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d6a, 0x3)   mov(memd_a32(ds, eax + 0x22), edx);   /* mov [eax+0x22], edx */
    II(0x10102d6d, 0x2)   jmpd(0x10102d7b, 0xc);                /* jmp 0x10102d7b */
l_0x10102d6f:
    II(0x10102d6f, 0x6)   mov(edx, memd_a32(ds, 0x101c70b0));   /* mov edx, [0x101c70b0] */
    II(0x10102d75, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d78, 0x3)   mov(memd_a32(ds, eax + 0x22), edx);   /* mov [eax+0x22], edx */
l_0x10102d7b:
    II(0x10102d7b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10102d7e, 0x4)   mov(memb_a32(ds, eax + 0x2c), 0);     /* mov byte [eax+0x2c], 0x0 */
    II(0x10102d82, 0x5)   jmpd(0x10102cef, -0x98);              /* jmp 0x10102cef */
l_0x10102d87:
    II(0x10102d87, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10102d89, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10102d8a, 0x1)   popd(edi);                            /* pop edi */
    II(0x10102d8b, 0x1)   popd(esi);                            /* pop esi */
    II(0x10102d8c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10102d8d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10102d8e, 0x1)   retd();                               /* ret */
FUNC_END

