FUNC_BEGIN(0x100b0050, 0x321f36a513af9fb0, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xf8, 0x5c, 0xb, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x24, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x89, 0x5d, 0xf8, 0x89, 0x4d, 0xfc, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xe4, 0xff, 0x52, 0x14, 0xf, 0xbf, 0xc8, 0x8b, 0x5d, 0xf4, 0x8b, 0x45, 0xf8, 0xe8, 0xff, 0xac, 0xfd, 0xff, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf0, 0xe8, 0x35, 0x26, 0xff, 0xff, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xe0, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x13, 0xe8, 0x84, 0xa5, 0xfd, 0xff, 0x83, 0xe8, 0x13, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x17, 0xe8, 0x29, 0x66, 0xfc, 0xff, 0x83, 0xe8, 0x17, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x21, 0xe8, 0x12, 0x6a, 0xfc, 0xff, 0x83, 0xe8, 0x21, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0xc7, 0x40, 0x2, 0x24, 0x54, 0x1b, 0x10, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x17, 0xe8, 0x34, 0x65, 0xfc, 0xff, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x13, 0xe8, 0xf2, 0x7b, 0, 0, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xdc, 0x8b, 0x45, 0xdc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc3}))
    II(0x100b0050, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x100b0055, 0x5)   calld(sys_check_available_stack_size, 0xb5cf8); /* call 0x10165d52 */
    II(0x100b005a, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b005b, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b005c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b005d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b005f, 0x6)   sub(esp, 0x24);                       /* sub esp, 0x24 */
    II(0x100b0065, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100b0068, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100b006b, 0x3)   mov(memd_a32(ss, ebp - 0x8), ebx);    /* mov [ebp-0x8], ebx */
    II(0x100b006e, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
    II(0x100b0071, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0074, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x100b0077, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100b007a, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100b007d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100b0080, 0x3)   calld_abs(memd_a32(ds, edx + 0x14));  /* call dword near [edx+0x14] */
    II(0x100b0083, 0x3)   movsx(ecx, ax);                       /* movsx ecx, ax */
    II(0x100b0086, 0x3)   mov(ebx, memd_a32(ss, ebp - 0xc));    /* mov ebx, [ebp-0xc] */
    II(0x100b0089, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b008c, 0x5)   calld(0x1008ad90, -0x25301);          /* call 0x1008ad90 */
    II(0x100b0091, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100b0094, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b0097, 0x5)   calld(0x100a26d1, -0xd9cb);           /* call 0x100a26d1 */
    II(0x100b009c, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100b009f, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100b00a2, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x100b00a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b00a8, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b00ab, 0x5)   calld(0x1008a634, -0x25a7c);          /* call 0x1008a634 */
    II(0x100b00b0, 0x3)   sub(eax, 0x13);                       /* sub eax, 0x13 */
    II(0x100b00b3, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100b00b6, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100b00b9, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100b00bc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b00bf, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100b00c2, 0x5)   calld(my_ctor_0x101b38f8, -0x399d7);  /* call 0x100766f0 */
    II(0x100b00c7, 0x3)   sub(eax, 0x17);                       /* sub eax, 0x17 */
    II(0x100b00ca, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100b00cd, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100b00d0, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100b00d3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b00d6, 0x3)   add(eax, 0x21);                       /* add eax, 0x21 */
    II(0x100b00d9, 0x5)   calld(my_ctor_0x101b4184, -0x395ee);  /* call 0x10076af0 */
    II(0x100b00de, 0x3)   sub(eax, 0x21);                       /* sub eax, 0x21 */
    II(0x100b00e1, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100b00e4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b00e7, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b5424); /* mov dword [eax+0x2], 0x101b5424 */
    II(0x100b00ee, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b00f1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b00f4, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x100b00f7, 0x5)   calld(0x10076630, -0x39acc);          /* call 0x10076630 */
    II(0x100b00fc, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100b00ff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b0102, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100b0105, 0x5)   calld(0x100b7cfc, 0x7bf2);            /* call 0x100b7cfc */
    II(0x100b010a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b010d, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
//    II(0x100b0110, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100b0113, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b0115, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b0116, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b0117, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b0118, 0x1)   retd();                               /* ret */
FUNC_END

