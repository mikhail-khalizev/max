FUNC_BEGIN(0x10073aa6, 0x7e19334b985e7781, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xa2, 0x22, 0xf, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0xf, 0xbf, 0x45, 0xf4, 0x85, 0xc0, 0x7c, 0xc, 0x8b, 0x45, 0xf4, 0x66, 0x3b, 0x5, 0x72, 0x81, 0x1c, 0x10, 0x7c, 0x2, 0xeb, 0x8, 0xf, 0xbf, 0x45, 0xf8, 0x85, 0xc0, 0x7d, 0x2, 0xeb, 0xc, 0x8b, 0x45, 0xf8, 0x66, 0x3b, 0x5, 0x74, 0x81, 0x1c, 0x10, 0x7c, 0xc, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xe9, 0x11, 0x1, 0, 0, 0xf, 0xbf, 0x5d, 0xf8, 0xf, 0xbf, 0x55, 0xf4, 0xb8, 0xb8, 0x39, 0x1c, 0x10, 0xe8, 0x32, 0xfa, 0x8, 0, 0x89, 0xc2, 0x8d, 0x45, 0xec, 0xe8, 0x9f, 0x29, 0, 0, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x47, 0x72, 0xc, 0, 0x84, 0xc0, 0xf, 0x84, 0x9b, 0, 0, 0, 0x8d, 0x45, 0xec, 0xe8, 0x66, 0x28, 0, 0, 0x31, 0xd2, 0x8a, 0x50, 0x26, 0xf, 0xbf, 0x45, 0xfc, 0x39, 0xc2, 0x75, 0xe, 0x8d, 0x45, 0xec, 0xe8, 0x51, 0x28, 0, 0, 0xf6, 0x40, 0x14, 0x40, 0x75, 0x2, 0xeb, 0xe, 0x8d, 0x45, 0xec, 0xe8, 0x41, 0x28, 0, 0, 0xf6, 0x40, 0x14, 0x1, 0x74, 0x2, 0xeb, 0xe, 0x8d, 0x45, 0xec, 0xe8, 0x31, 0x28, 0, 0, 0xf6, 0x40, 0x12, 0x1, 0x74, 0x2, 0xeb, 0xf, 0x8d, 0x45, 0xec, 0xe8, 0x21, 0x28, 0, 0, 0x66, 0x83, 0x78, 0x8, 0x16, 0x75, 0x2, 0xeb, 0xe, 0x8d, 0x45, 0xec, 0xe8, 0x10, 0x28, 0, 0, 0x80, 0x78, 0x3d, 0x10, 0x75, 0x2, 0xeb, 0x19, 0x8d, 0x45, 0xec, 0xe8, 0, 0x28, 0, 0, 0xe8, 0xaf, 0x25, 0, 0, 0x25, 0xff, 0xff, 0, 0, 0x3d, 0xff, 0xff, 0, 0, 0x75, 0x2, 0xeb, 0xd, 0x8d, 0x45, 0xec, 0xe8, 0x4d, 0x28, 0, 0, 0x89, 0x45, 0xe8, 0xeb, 0xd, 0x8d, 0x45, 0xec, 0xe8, 0x30, 0x30, 0, 0, 0xe9, 0x53, 0xff, 0xff, 0xff, 0x83, 0x7d, 0xe8, 0, 0x74, 0x1f, 0x8b, 0x45, 0xe8, 0x66, 0x83, 0x78, 0x8, 0xf, 0x74, 0xa, 0x8b, 0x45, 0xe8, 0x66, 0x83, 0x78, 0x8, 0x10, 0x75, 0xb, 0x8b, 0x45, 0xe8, 0xe8, 0x2d, 0x25, 0, 0, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xf0, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x6a, 0x23, 0, 0, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x5e, 0x23, 0, 0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10073aa6, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x10073aab, 0x5)   calld(sys_check_available_stack_size, 0xf22a2); /* call 0x10165d52 */
    II(0x10073ab0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10073ab1, 0x1)   pushd(esi);                           /* push esi */
    II(0x10073ab2, 0x1)   pushd(edi);                           /* push edi */
    II(0x10073ab3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10073ab4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10073ab6, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x10073abc, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10073abf, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10073ac2, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x10073ac5, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x10073ac9, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10073acb, 0x2)   jld(0x10073ad9, 0xc);                 /* jl 0x10073ad9 */
    II(0x10073acd, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10073ad0, 0x7)   cmp(ax, memw_a32(ds, 0x101c8172));    /* cmp ax, [0x101c8172] */
    II(0x10073ad7, 0x2)   jld(0x10073adb, 0x2);                 /* jl 0x10073adb */
l_0x10073ad9:
    II(0x10073ad9, 0x2)   jmpd(0x10073ae3, 0x8);                /* jmp 0x10073ae3 */
l_0x10073adb:
    II(0x10073adb, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10073adf, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10073ae1, 0x2)   jged(0x10073ae5, 0x2);                /* jge 0x10073ae5 */
l_0x10073ae3:
    II(0x10073ae3, 0x2)   jmpd(0x10073af1, 0xc);                /* jmp 0x10073af1 */
l_0x10073ae5:
    II(0x10073ae5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10073ae8, 0x7)   cmp(ax, memw_a32(ds, 0x101c8174));    /* cmp ax, [0x101c8174] */
    II(0x10073aef, 0x2)   jld(0x10073afd, 0xc);                 /* jl 0x10073afd */
l_0x10073af1:
    II(0x10073af1, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x10073af8, 0x5)   jmpd(0x10073c0e, 0x111);              /* jmp 0x10073c0e */
l_0x10073afd:
    II(0x10073afd, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x8));  /* movsx ebx, word [ebp-0x8] */
    II(0x10073b01, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x10073b05, 0x5)   mov(eax, 0x101c39b8);                 /* mov eax, 0x101c39b8 */
    II(0x10073b0a, 0x5)   calld(0x10103541, 0x8fa32);           /* call 0x10103541 */
    II(0x10073b0f, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10073b11, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b14, 0x5)   calld(0x100764b8, 0x299f);            /* call 0x100764b8 */
    II(0x10073b19, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
l_0x10073b20:
    II(0x10073b20, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10073b22, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b25, 0x5)   calld(0x1013ad71, 0xc7247);           /* call 0x1013ad71 */
    II(0x10073b2a, 0x2)   test(al, al);                         /* test al, al */
    II(0x10073b2c, 0x6)   jzd(0x10073bcd, 0x9b);                /* jz dword 0x10073bcd */
    II(0x10073b32, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b35, 0x5)   calld(0x100763a0, 0x2866);            /* call 0x100763a0 */
    II(0x10073b3a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10073b3c, 0x3)   mov(dl, memb_a32(ds, eax + 0x26));    /* mov dl, [eax+0x26] */
    II(0x10073b3f, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10073b43, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x10073b45, 0x2)   jnzd(0x10073b55, 0xe);                /* jnz 0x10073b55 */
    II(0x10073b47, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b4a, 0x5)   calld(0x100763a0, 0x2851);            /* call 0x100763a0 */
    II(0x10073b4f, 0x4)   test(memb_a32(ds, eax + 0x14), 0x40); /* test byte [eax+0x14], 0x40 */
    II(0x10073b53, 0x2)   jnzd(0x10073b57, 0x2);                /* jnz 0x10073b57 */
l_0x10073b55:
    II(0x10073b55, 0x2)   jmpd(0x10073b65, 0xe);                /* jmp 0x10073b65 */
l_0x10073b57:
    II(0x10073b57, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b5a, 0x5)   calld(0x100763a0, 0x2841);            /* call 0x100763a0 */
    II(0x10073b5f, 0x4)   test(memb_a32(ds, eax + 0x14), 0x1);  /* test byte [eax+0x14], 0x1 */
    II(0x10073b63, 0x2)   jzd(0x10073b67, 0x2);                 /* jz 0x10073b67 */
l_0x10073b65:
    II(0x10073b65, 0x2)   jmpd(0x10073b75, 0xe);                /* jmp 0x10073b75 */
l_0x10073b67:
    II(0x10073b67, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b6a, 0x5)   calld(0x100763a0, 0x2831);            /* call 0x100763a0 */
    II(0x10073b6f, 0x4)   test(memb_a32(ds, eax + 0x12), 0x1);  /* test byte [eax+0x12], 0x1 */
    II(0x10073b73, 0x2)   jzd(0x10073b77, 0x2);                 /* jz 0x10073b77 */
l_0x10073b75:
    II(0x10073b75, 0x2)   jmpd(0x10073b86, 0xf);                /* jmp 0x10073b86 */
l_0x10073b77:
    II(0x10073b77, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b7a, 0x5)   calld(0x100763a0, 0x2821);            /* call 0x100763a0 */
    II(0x10073b7f, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x16);   /* cmp word [eax+0x8], 0x16 */
    II(0x10073b84, 0x2)   jnzd(0x10073b88, 0x2);                /* jnz 0x10073b88 */
l_0x10073b86:
    II(0x10073b86, 0x2)   jmpd(0x10073b96, 0xe);                /* jmp 0x10073b96 */
l_0x10073b88:
    II(0x10073b88, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b8b, 0x5)   calld(0x100763a0, 0x2810);            /* call 0x100763a0 */
    II(0x10073b90, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x10);  /* cmp byte [eax+0x3d], 0x10 */
    II(0x10073b94, 0x2)   jnzd(0x10073b98, 0x2);                /* jnz 0x10073b98 */
l_0x10073b96:
    II(0x10073b96, 0x2)   jmpd(0x10073bb1, 0x19);               /* jmp 0x10073bb1 */
l_0x10073b98:
    II(0x10073b98, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073b9b, 0x5)   calld(0x100763a0, 0x2800);            /* call 0x100763a0 */
    II(0x10073ba0, 0x5)   calld(0x10076154, 0x25af);            /* call 0x10076154 */
    II(0x10073ba5, 0x5)   and_(eax, 0xffff);                    /* and eax, 0xffff */
    II(0x10073baa, 0x5)   cmp(eax, 0xffff);                     /* cmp eax, 0xffff */
    II(0x10073baf, 0x2)   jnzd(0x10073bb3, 0x2);                /* jnz 0x10073bb3 */
l_0x10073bb1:
    II(0x10073bb1, 0x2)   jmpd(0x10073bc0, 0xd);                /* jmp 0x10073bc0 */
l_0x10073bb3:
    II(0x10073bb3, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073bb6, 0x5)   calld(0x10076408, 0x284d);            /* call 0x10076408 */
    II(0x10073bbb, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x10073bbe, 0x2)   jmpd(0x10073bcd, 0xd);                /* jmp 0x10073bcd */
l_0x10073bc0:
    II(0x10073bc0, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073bc3, 0x5)   calld(0x10076bf8, 0x3030);            /* call 0x10076bf8 */
    II(0x10073bc8, 0x5)   jmpd(0x10073b20, -0xad);              /* jmp 0x10073b20 */
l_0x10073bcd:
    II(0x10073bcd, 0x4)   cmp(memd_a32(ss, ebp - 0x18), 0);     /* cmp dword [ebp-0x18], 0x0 */
    II(0x10073bd1, 0x2)   jzd(0x10073bf2, 0x1f);                /* jz 0x10073bf2 */
    II(0x10073bd3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10073bd6, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0xf);    /* cmp word [eax+0x8], 0xf */
    II(0x10073bdb, 0x2)   jzd(0x10073be7, 0xa);                 /* jz 0x10073be7 */
    II(0x10073bdd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10073be0, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x10);   /* cmp word [eax+0x8], 0x10 */
    II(0x10073be5, 0x2)   jnzd(0x10073bf2, 0xb);                /* jnz 0x10073bf2 */
l_0x10073be7:
    II(0x10073be7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10073bea, 0x5)   calld(0x1007611c, 0x252d);            /* call 0x1007611c */
    II(0x10073bef, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
l_0x10073bf2:
    II(0x10073bf2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10073bf5, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10073bf8, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10073bfa, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10073bfd, 0x5)   calld(0x10075f6c, 0x236a);            /* call 0x10075f6c */
    II(0x10073c02, 0x2)   jmpd(0x10073c0e, 0xa);                /* jmp 0x10073c0e */
//  II(0x10073c04, 0xa)   /* Недостижимый код. */
l_0x10073c0e:
    II(0x10073c0e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10073c11, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10073c13, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10073c14, 0x1)   popd(edi);                            /* pop edi */
    II(0x10073c15, 0x1)   popd(esi);                            /* pop esi */
    II(0x10073c16, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10073c17, 0x1)   retd();                               /* ret */
FUNC_END

