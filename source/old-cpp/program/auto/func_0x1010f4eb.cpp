FUNC_BEGIN(0x1010f4eb, 0x2aa53dd4b32859e6, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x5d, 0x68, 0x5, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x72, 0xfe, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0xe8, 0xb7, 0xfd, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x14, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x75, 0x65, 0xe8, 0x7, 0xc9, 0x5, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x6b, 0xf4, 0xff, 0xff, 0xe8, 0x2, 0x5e, 0xfc, 0xff, 0x98, 0x50, 0xe8, 0x1f, 0x5e, 0xfc, 0xff, 0x98, 0x50, 0x31, 0xc0, 0x50, 0x31, 0xc9, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x8b, 0x58, 0xe, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x10, 0xb8, 0xc0, 0x6, 0, 0, 0xe8, 0xef, 0x96, 0xfd, 0xff, 0xba, 0x42, 0x46, 0x1a, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xb7, 0xd0, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x2b, 0xf8, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x8b, 0x40, 0x12, 0xe8, 0xfc, 0x7e, 0x5, 0, 0xe8, 0x37, 0xc7, 0x5, 0, 0x31, 0xd2, 0x8a, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x14, 0x30, 0xe4, 0x98, 0xe8, 0x1e, 0xf3, 0xff, 0xff, 0x85, 0xc0, 0x74, 0xc, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x4, 0x1, 0, 0, 0, 0xeb, 0x1d, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x14, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x75, 0x5, 0xe8, 0x7e, 0xf3, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0xe8, 0xb2, 0xf9, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1010f4eb, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x1010f4f0, 0x5)   calld(sys_check_available_stack_size, 0x5685d); /* call 0x10165d52 */
    II(0x1010f4f5, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010f4f6, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010f4f7, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010f4f8, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010f4f9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010f4fa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010f4fc, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1010f502, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1010f505, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x1010f508, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f50b, 0x5)   calld(0x1010f382, -0x18e);            /* call 0x1010f382 */
    II(0x1010f510, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f513, 0x5)   calld(0x1010f2cf, -0x249);            /* call 0x1010f2cf */
    II(0x1010f518, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f51b, 0x3)   mov(al, memb_a32(ds, eax + 0x14));    /* mov al, [eax+0x14] */
    II(0x1010f51e, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1010f523, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x1010f526, 0x2)   jnzd(0x1010f58d, 0x65);               /* jnz 0x1010f58d */
    II(0x1010f528, 0x5)   calld(/* sys */ 0x1016be34, 0x5c907); /* call 0x1016be34 */
    II(0x1010f52d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f530, 0x5)   calld(0x1010e9a0, -0xb95);            /* call 0x1010e9a0 */
    II(0x1010f535, 0x5)   calld(0x100d533c, -0x3a1fe);          /* call 0x100d533c */
    II(0x1010f53a, 0x1)   cwde();                               /* cwde */
    II(0x1010f53b, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010f53c, 0x5)   calld(0x100d5360, -0x3a1e1);          /* call 0x100d5360 */
    II(0x1010f541, 0x1)   cwde();                               /* cwde */
    II(0x1010f542, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010f543, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1010f545, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010f546, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1010f548, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f54b, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1010f54d, 0x3)   mov(ebx, memd_a32(ds, eax + 0xe));    /* mov ebx, [eax+0xe] */
    II(0x1010f550, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x1010f553, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f556, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x1010f558, 0x5)   mov(eax, 0x6c0);                      /* mov eax, 0x6c0 */
    II(0x1010f55d, 0x5)   calld(0x100e8c51, -0x26911);          /* call 0x100e8c51 */
    II(0x1010f562, 0x5)   mov(edx, 0x101a4642);                 /* mov edx, 0x101a4642 */ /* "Modem Play Menu" */
    II(0x1010f567, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f56a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1010f56c, 0x5)   calld(0x1010c628, -0x2f49);           /* call 0x1010c628 */
    II(0x1010f571, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f574, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1010f576, 0x5)   calld(0x1010eda6, -0x7d5);            /* call 0x1010eda6 */
    II(0x1010f57b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f57e, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1010f580, 0x3)   mov(eax, memd_a32(ds, eax + 0x12));   /* mov eax, [eax+0x12] */
    II(0x1010f583, 0x5)   calld(sys_display_draw_0, 0x57efc);   /* call 0x10167484 */
    II(0x1010f588, 0x5)   calld(/* sys */ 0x1016bcc4, 0x5c737); /* call 0x1016bcc4 */
l_0x1010f58d:
    II(0x1010f58d, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010f58f, 0x3)   mov(dl, memb_a32(ss, ebp - 0x4));     /* mov dl, [ebp-0x4] */
    II(0x1010f592, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f595, 0x3)   mov(al, memb_a32(ds, eax + 0x14));    /* mov al, [eax+0x14] */
    II(0x1010f598, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1010f59a, 0x1)   cwde();                               /* cwde */
    II(0x1010f59b, 0x5)   calld(0x1010e8be, -0xce2);            /* call 0x1010e8be */
    II(0x1010f5a0, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010f5a2, 0x2)   jzd(0x1010f5b0, 0xc);                 /* jz 0x1010f5b0 */
    II(0x1010f5a4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f5a7, 0x7)   mov(memd_a32(ds, eax + 0x4), 0x1);    /* mov dword [eax+0x4], 0x1 */
    II(0x1010f5ae, 0x2)   jmpd(0x1010f5cd, 0x1d);               /* jmp 0x1010f5cd */
l_0x1010f5b0:
    II(0x1010f5b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f5b3, 0x3)   mov(al, memb_a32(ds, eax + 0x14));    /* mov al, [eax+0x14] */
    II(0x1010f5b6, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1010f5bb, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x1010f5be, 0x2)   jnzd(0x1010f5c5, 0x5);                /* jnz 0x1010f5c5 */
    II(0x1010f5c0, 0x5)   calld(0x1010e943, -0xc82);            /* call 0x1010e943 */
l_0x1010f5c5:
    II(0x1010f5c5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010f5c8, 0x5)   calld(0x1010ef7f, -0x64e);            /* call 0x1010ef7f */
l_0x1010f5cd:
    II(0x1010f5cd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010f5cf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010f5d0, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010f5d1, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010f5d2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010f5d3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010f5d4, 0x1)   retd();                               /* ret */
FUNC_END

