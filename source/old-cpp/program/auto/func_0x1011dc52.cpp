FUNC_BEGIN(0x1011dc52, 0xb32ab2e178e23874, 0x20, ({0x68, 0x38, 0, 0, 0, 0xe8, 0xf6, 0x80, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x16, 0, 0x74, 0x2a, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x16, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xec, 0xe8, 0xb1, 0xe5, 0xff, 0xff, 0xe8, 0xce, 0x82, 0x4, 0, 0x89, 0x45, 0xe8, 0xeb, 0x7, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x1a, 0, 0x74, 0x2a, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x1a, 0x89, 0x45, 0xe4, 0x83, 0x7d, 0xe4, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xe4, 0xe8, 0x7e, 0xe5, 0xff, 0xff, 0xe8, 0x9b, 0x82, 0x4, 0, 0x89, 0x45, 0xe0, 0xeb, 0x7, 0xc7, 0x45, 0xe0, 0, 0, 0, 0, 0x83, 0x3d, 0x68, 0x53, 0x1c, 0x10, 0, 0x74, 0x3d, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf4, 0xff, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x66, 0x3b, 0x5, 0x72, 0x81, 0x1c, 0x10, 0x7d, 0x18, 0xf, 0xbf, 0x45, 0xf4, 0xc1, 0xe0, 0x2, 0x8b, 0x15, 0x68, 0x53, 0x1c, 0x10, 0x1, 0xd0, 0x8b, 0, 0xe8, 0x55, 0x82, 0x4, 0, 0xeb, 0xd6, 0xa1, 0x68, 0x53, 0x1c, 0x10, 0xe8, 0x49, 0x82, 0x4, 0, 0xc7, 0x5, 0x68, 0x53, 0x1c, 0x10, 0, 0, 0, 0, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x4, 0xe8, 0xf2, 0x26, 0, 0, 0x83, 0xe8, 0x4, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0xe8, 0x26, 0x96, 0xf9, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011dc52, 0x5)   pushd(0x38);                          /* push dword 0x38 */
    II(0x1011dc57, 0x5)   calld(sys_check_available_stack_size, 0x480f6); /* call 0x10165d52 */
    II(0x1011dc5c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011dc5d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011dc5e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011dc5f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011dc60, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011dc61, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011dc63, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x1011dc69, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011dc6c, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1011dc6f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dc72, 0x4)   cmp(memd_a32(ds, eax + 0x16), 0);     /* cmp dword [eax+0x16], 0x0 */
    II(0x1011dc76, 0x2)   jzd(0x1011dca2, 0x2a);                /* jz 0x1011dca2 */
    II(0x1011dc78, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dc7b, 0x3)   mov(eax, memd_a32(ds, eax + 0x16));   /* mov eax, [eax+0x16] */
    II(0x1011dc7e, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1011dc81, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x1011dc85, 0x2)   jzd(0x1011dc9b, 0x14);                /* jz 0x1011dc9b */
    II(0x1011dc87, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011dc89, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1011dc8c, 0x5)   calld(my_dtor_d7, -0x1a4f);           /* call 0x1011c242 */
    II(0x1011dc91, 0x5)   calld(sys_delete, 0x482ce);           /* call 0x10165f64 */
    II(0x1011dc96, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x1011dc99, 0x2)   jmpd(0x1011dca2, 0x7);                /* jmp 0x1011dca2 */
l_0x1011dc9b:
    II(0x1011dc9b, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
l_0x1011dca2:
    II(0x1011dca2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dca5, 0x4)   cmp(memd_a32(ds, eax + 0x1a), 0);     /* cmp dword [eax+0x1a], 0x0 */
    II(0x1011dca9, 0x2)   jzd(0x1011dcd5, 0x2a);                /* jz 0x1011dcd5 */
    II(0x1011dcab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dcae, 0x3)   mov(eax, memd_a32(ds, eax + 0x1a));   /* mov eax, [eax+0x1a] */
    II(0x1011dcb1, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x1011dcb4, 0x4)   cmp(memd_a32(ss, ebp - 0x1c), 0);     /* cmp dword [ebp-0x1c], 0x0 */
    II(0x1011dcb8, 0x2)   jzd(0x1011dcce, 0x14);                /* jz 0x1011dcce */
    II(0x1011dcba, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011dcbc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x1011dcbf, 0x5)   calld(my_dtor_d7, -0x1a82);           /* call 0x1011c242 */
    II(0x1011dcc4, 0x5)   calld(sys_delete, 0x4829b);           /* call 0x10165f64 */
    II(0x1011dcc9, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x1011dccc, 0x2)   jmpd(0x1011dcd5, 0x7);                /* jmp 0x1011dcd5 */
l_0x1011dcce:
    II(0x1011dcce, 0x7)   mov(memd_a32(ss, ebp - 0x20), 0);     /* mov dword [ebp-0x20], 0x0 */
l_0x1011dcd5:
    II(0x1011dcd5, 0x7)   cmp(memd_a32(ds, 0x101c5368), 0);     /* cmp dword [0x101c5368], 0x0 */
    II(0x1011dcdc, 0x2)   jzd(0x1011dd1b, 0x3d);                /* jz 0x1011dd1b */
    II(0x1011dcde, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x1011dce5, 0x2)   jmpd(0x1011dced, 0x6);                /* jmp 0x1011dced */
l_0x1011dce7:
    II(0x1011dce7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011dcea, 0x3)   inc(memd_a32(ss, ebp - 0xc));         /* inc dword [ebp-0xc] */
l_0x1011dced:
    II(0x1011dced, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011dcf0, 0x7)   cmp(ax, memw_a32(ds, 0x101c8172));    /* cmp ax, [0x101c8172] */
    II(0x1011dcf7, 0x2)   jged(0x1011dd11, 0x18);               /* jge 0x1011dd11 */
    II(0x1011dcf9, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x1011dcfd, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1011dd00, 0x6)   mov(edx, memd_a32(ds, 0x101c5368));   /* mov edx, [0x101c5368] */
    II(0x1011dd06, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1011dd08, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011dd0a, 0x5)   calld(sys_delete, 0x48255);           /* call 0x10165f64 */
    II(0x1011dd0f, 0x2)   jmpd(0x1011dce7, -0x2a);              /* jmp 0x1011dce7 */
l_0x1011dd11:
    II(0x1011dd11, 0x5)   mov(eax, memd_a32(ds, 0x101c5368));   /* mov eax, [0x101c5368] */
    II(0x1011dd16, 0x5)   calld(sys_delete, 0x48249);           /* call 0x10165f64 */
l_0x1011dd1b:
    II(0x1011dd1b, 0xa)   mov(memd_a32(ds, 0x101c5368), 0);     /* mov dword [0x101c5368], 0x0 */
    II(0x1011dd25, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011dd27, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dd2a, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x1011dd2d, 0x5)   calld(0x10120424, 0x26f2);            /* call 0x10120424 */
    II(0x1011dd32, 0x3)   sub(eax, 0x4);                        /* sub eax, 0x4 */
    II(0x1011dd35, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011dd38, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011dd3a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dd3d, 0x5)   calld(0x100b7368, -0x669da);          /* call 0x100b7368 */
    II(0x1011dd42, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1011dd45, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011dd48, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1011dd4b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1011dd4e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011dd50, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011dd51, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011dd52, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011dd53, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011dd54, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011dd55, 0x1)   retd();                               /* ret */
FUNC_END

