FUNC_BEGIN(/* sys */ 0x10186f1c, 0x4e423a79d006e449, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x55, 0x50, 0x31, 0xc0, 0xa0, 0x8e, 0xe5, 0x1b, 0x10, 0x83, 0xf8, 0x1, 0x75, 0x9, 0x80, 0x3d, 0x8f, 0xe5, 0x1b, 0x10, 0, 0x74, 0xc, 0x31, 0xc0, 0xa0, 0x8e, 0xe5, 0x1b, 0x10, 0x83, 0xf8, 0x9, 0x75, 0xd, 0x8b, 0x4, 0x24, 0xe8, 0x21, 0xff, 0xff, 0xff, 0xe9, 0xf, 0x1, 0, 0, 0x83, 0x3d, 0x50, 0x1c, 0x1c, 0x10, 0, 0x75, 0x7, 0x31, 0xc0, 0xe9, 0xff, 0, 0, 0, 0x83, 0x3d, 0x60, 0xe5, 0x1b, 0x10, 0xfe, 0x74, 0xf0, 0x89, 0xe0, 0xe8, 0xf8, 0, 0, 0, 0x85, 0xc0, 0xf, 0x84, 0xe7, 0, 0, 0, 0x31, 0xc0, 0xa0, 0x8e, 0xe5, 0x1b, 0x10, 0x83, 0xf8, 0x2, 0x7c, 0x1c, 0x83, 0xf8, 0x8, 0x7f, 0x17, 0x80, 0x3d, 0x90, 0xe5, 0x1b, 0x10, 0, 0x75, 0xe, 0x31, 0xc0, 0x66, 0x8c, 0xd8, 0xf, 0x3, 0xc0, 0x40, 0xa3, 0x60, 0xe5, 0x1b, 0x10, 0x8b, 0x14, 0x24, 0x8b, 0xd, 0x60, 0xe5, 0x1b, 0x10, 0x1, 0xca, 0x39, 0xca, 0x73, 0x5, 0xba, 0xfe, 0xff, 0xff, 0xff, 0x89, 0xd0, 0xe8, 0x2d, 0x39, 0x1, 0, 0x83, 0xf8, 0xff, 0x74, 0x99, 0x89, 0xc3, 0x83, 0xf8, 0xf8, 0x77, 0x92, 0x39, 0xc2, 0x76, 0x8e, 0x29, 0xc2, 0x89, 0x14, 0x24, 0x8d, 0x42, 0xfc, 0x39, 0xd0, 0x77, 0x82, 0x8b, 0x15, 0xc, 0xde, 0x1b, 0x10, 0x89, 0x4, 0x24, 0xeb, 0x12, 0x8b, 0x6a, 0x8, 0x85, 0xed, 0x74, 0xf, 0x39, 0xda, 0x77, 0x4, 0x39, 0xeb, 0x72, 0x7, 0x8b, 0x52, 0x8, 0x85, 0xd2, 0x75, 0xea, 0x85, 0xd2, 0x74, 0x26, 0x8b, 0x2, 0x8d, 0x4b, 0xfc, 0x1, 0xd0, 0x39, 0xc1, 0x75, 0x1b, 0x8b, 0x34, 0x24, 0x83, 0xc6, 0x4, 0x89, 0x34, 0x24, 0x1, 0x32, 0x8b, 0x2c, 0x24, 0x89, 0xc3, 0x8d, 0xc, 0x28, 0xc7, 0x1, 0xff, 0xff, 0xff, 0xff, 0xeb, 0x1f, 0x83, 0x3c, 0x24, 0x38, 0xf, 0x82, 0x2d, 0xff, 0xff, 0xff, 0x8b, 0x4, 0x24, 0x89, 0x3, 0x89, 0xd8, 0x89, 0xda, 0xe8, 0x9d, 0xfc, 0xff, 0xff, 0x89, 0xc3, 0x8b, 0, 0x89, 0x4, 0x24, 0x8b, 0x4, 0x24, 0xc, 0x1, 0x89, 0x3, 0xff, 0x42, 0x18, 0x8d, 0x43, 0x4, 0xc7, 0x42, 0x14, 0xff, 0xff, 0xff, 0xff, 0xe8, 0x67, 0x40, 0xfe, 0xff, 0xb8, 0x1, 0, 0, 0, 0x83, 0xc4, 0x4, 0x5d, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10186f1c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10186f1d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10186f1e, 0x1)   pushd(edx);                           /* push edx */
    II(0x10186f1f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10186f20, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10186f21, 0x1)   pushd(eax);                           /* push eax */
    II(0x10186f22, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10186f24, 0x5)   mov(al, memb_a32(ds, 0x101be58e));    /* mov al, [0x101be58e] */
    II(0x10186f29, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x10186f2c, 0x2)   jnzd(0x10186f37, 0x9);                /* jnz 0x10186f37 */
    II(0x10186f2e, 0x7)   cmp(memb_a32(ds, 0x101be58f), 0);     /* cmp byte [0x101be58f], 0x0 */
    II(0x10186f35, 0x2)   jzd(0x10186f43, 0xc);                 /* jz 0x10186f43 */
l_0x10186f37:
    II(0x10186f37, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10186f39, 0x5)   mov(al, memb_a32(ds, 0x101be58e));    /* mov al, [0x101be58e] */
    II(0x10186f3e, 0x3)   cmp(eax, 0x9);                        /* cmp eax, 0x9 */
    II(0x10186f41, 0x2)   jnzd(0x10186f50, 0xd);                /* jnz 0x10186f50 */
l_0x10186f43:
    II(0x10186f43, 0x3)   mov(eax, memd_a32(ss, esp));          /* mov eax, [esp] */
    II(0x10186f46, 0x5)   calld(/* sys */ 0x10186e6c, -0xdf);   /* call 0x10186e6c */
    II(0x10186f4b, 0x5)   jmpd(0x1018705f, 0x10f);              /* jmp 0x1018705f */
l_0x10186f50:
    II(0x10186f50, 0x7)   cmp(memd_a32(ds, 0x101c1c50), 0);     /* cmp dword [0x101c1c50], 0x0 */
    II(0x10186f57, 0x2)   jnzd(0x10186f60, 0x7);                /* jnz 0x10186f60 */
l_0x10186f59:
    II(0x10186f59, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10186f5b, 0x5)   jmpd(0x1018705f, 0xff);               /* jmp 0x1018705f */
l_0x10186f60:
    II(0x10186f60, 0x7)   cmp(memd_a32(ds, 0x101be560), -0x2 /* 0xfe */); /* cmp dword [0x101be560], 0xfe */
    II(0x10186f67, 0x2)   jzd(0x10186f59, -0x10);               /* jz 0x10186f59 */
    II(0x10186f69, 0x2)   mov(eax, esp);                        /* mov eax, esp */
    II(0x10186f6b, 0x5)   calld(/* sys */ 0x10187068, 0xf8);    /* call 0x10187068 */
    II(0x10186f70, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10186f72, 0x6)   jzd(0x1018705f, 0xe7);                /* jz dword 0x1018705f */
    II(0x10186f78, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10186f7a, 0x5)   mov(al, memb_a32(ds, 0x101be58e));    /* mov al, [0x101be58e] */
    II(0x10186f7f, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x10186f82, 0x2)   jld(0x10186fa0, 0x1c);                /* jl 0x10186fa0 */
    II(0x10186f84, 0x3)   cmp(eax, 0x8);                        /* cmp eax, 0x8 */
    II(0x10186f87, 0x2)   jgd(0x10186fa0, 0x17);                /* jg 0x10186fa0 */
    II(0x10186f89, 0x7)   cmp(memb_a32(ds, 0x101be590), 0);     /* cmp byte [0x101be590], 0x0 */
    II(0x10186f90, 0x2)   jnzd(0x10186fa0, 0xe);                /* jnz 0x10186fa0 */
    II(0x10186f92, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10186f94, 0x3)   mov(ax, ds);                          /* mov ax, ds */
    II(0x10186f97, 0x3)   lsl(eax, ax);                         /* lsl eax, ax */
    II(0x10186f9a, 0x1)   inc(eax);                             /* inc eax */
    II(0x10186f9b, 0x5)   mov(memd_a32(ds, 0x101be560), eax);   /* mov [0x101be560], eax */
l_0x10186fa0:
    II(0x10186fa0, 0x3)   mov(edx, memd_a32(ss, esp));          /* mov edx, [esp] */
    II(0x10186fa3, 0x6)   mov(ecx, memd_a32(ds, 0x101be560));   /* mov ecx, [0x101be560] */
    II(0x10186fa9, 0x2)   add(edx, ecx);                        /* add edx, ecx */
    II(0x10186fab, 0x2)   cmp(edx, ecx);                        /* cmp edx, ecx */
    II(0x10186fad, 0x2)   jaed(0x10186fb4, 0x5);                /* jae 0x10186fb4 */
    II(0x10186faf, 0x5)   mov(edx, 0xfffffffe);                 /* mov edx, 0xfffffffe */
l_0x10186fb4:
    II(0x10186fb4, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x10186fb6, 0x5)   calld(/* sys */ 0x1019a8e8, 0x1392d); /* call 0x1019a8e8 */
    II(0x10186fbb, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x10186fbe, 0x2)   jzd(0x10186f59, -0x67);               /* jz 0x10186f59 */
    II(0x10186fc0, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10186fc2, 0x3)   cmp(eax, -0x8 /* 0xf8 */);            /* cmp eax, 0xf8 */
    II(0x10186fc5, 0x2)   jad(0x10186f59, -0x6e);               /* ja 0x10186f59 */
    II(0x10186fc7, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x10186fc9, 0x2)   jbed(0x10186f59, -0x72);              /* jbe 0x10186f59 */
    II(0x10186fcb, 0x2)   sub(edx, eax);                        /* sub edx, eax */
    II(0x10186fcd, 0x3)   mov(memd_a32(ss, esp), edx);          /* mov [esp], edx */
    II(0x10186fd0, 0x3)   lea(eax, edx - 0x4);                  /* lea eax, [edx-0x4] */
    II(0x10186fd3, 0x2)   cmp(eax, edx);                        /* cmp eax, edx */
    II(0x10186fd5, 0x2)   jad(0x10186f59, -0x7e);               /* ja 0x10186f59 */
    II(0x10186fd7, 0x6)   mov(edx, memd_a32(ds, 0x101bde0c));   /* mov edx, [0x101bde0c] */
    II(0x10186fdd, 0x3)   mov(memd_a32(ss, esp), eax);          /* mov [esp], eax */
    II(0x10186fe0, 0x2)   jmpd(0x10186ff4, 0x12);               /* jmp 0x10186ff4 */
l_0x10186fe2:
    II(0x10186fe2, 0x3)   mov(ebp, memd_a32(ds, edx + 0x8));    /* mov ebp, [edx+0x8] */
    II(0x10186fe5, 0x2)   test(ebp, ebp);                       /* test ebp, ebp */
    II(0x10186fe7, 0x2)   jzd(0x10186ff8, 0xf);                 /* jz 0x10186ff8 */
    II(0x10186fe9, 0x2)   cmp(edx, ebx);                        /* cmp edx, ebx */
    II(0x10186feb, 0x2)   jad(0x10186ff1, 0x4);                 /* ja 0x10186ff1 */
    II(0x10186fed, 0x2)   cmp(ebx, ebp);                        /* cmp ebx, ebp */
    II(0x10186fef, 0x2)   jbd(0x10186ff8, 0x7);                 /* jb 0x10186ff8 */
l_0x10186ff1:
    II(0x10186ff1, 0x3)   mov(edx, memd_a32(ds, edx + 0x8));    /* mov edx, [edx+0x8] */
l_0x10186ff4:
    II(0x10186ff4, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x10186ff6, 0x2)   jnzd(0x10186fe2, -0x16);              /* jnz 0x10186fe2 */
l_0x10186ff8:
    II(0x10186ff8, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x10186ffa, 0x2)   jzd(0x10187022, 0x26);                /* jz 0x10187022 */
    II(0x10186ffc, 0x2)   mov(eax, memd_a32(ds, edx));          /* mov eax, [edx] */
    II(0x10186ffe, 0x3)   lea(ecx, ebx - 0x4);                  /* lea ecx, [ebx-0x4] */
    II(0x10187001, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10187003, 0x2)   cmp(ecx, eax);                        /* cmp ecx, eax */
    II(0x10187005, 0x2)   jnzd(0x10187022, 0x1b);               /* jnz 0x10187022 */
    II(0x10187007, 0x3)   mov(esi, memd_a32(ss, esp));          /* mov esi, [esp] */
    II(0x1018700a, 0x3)   add(esi, 0x4);                        /* add esi, 0x4 */
    II(0x1018700d, 0x3)   mov(memd_a32(ss, esp), esi);          /* mov [esp], esi */
    II(0x10187010, 0x2)   add(memd_a32(ds, edx), esi);          /* add [edx], esi */
    II(0x10187012, 0x3)   mov(ebp, memd_a32(ss, esp));          /* mov ebp, [esp] */
    II(0x10187015, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10187017, 0x3)   lea(ecx, eax + ebp);                  /* lea ecx, [eax+ebp] */
    II(0x1018701a, 0x6)   mov(memd_a32(ds, ecx), 0xffffffff);   /* mov dword [ecx], 0xffffffff */
    II(0x10187020, 0x2)   jmpd(0x10187041, 0x1f);               /* jmp 0x10187041 */
l_0x10187022:
    II(0x10187022, 0x4)   cmp(memd_a32(ss, esp), 0x38);         /* cmp dword [esp], 0x38 */
    II(0x10187026, 0x6)   jbd(0x10186f59, -0xd3);               /* jb dword 0x10186f59 */
    II(0x1018702c, 0x3)   mov(eax, memd_a32(ss, esp));          /* mov eax, [esp] */
    II(0x1018702f, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x10187031, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10187033, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x10187035, 0x5)   calld(/* sys */ 0x10186cd7, -0x363);  /* call 0x10186cd7 */
    II(0x1018703a, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1018703c, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1018703e, 0x3)   mov(memd_a32(ss, esp), eax);          /* mov [esp], eax */
l_0x10187041:
    II(0x10187041, 0x3)   mov(eax, memd_a32(ss, esp));          /* mov eax, [esp] */
    II(0x10187044, 0x2)   or_(al, 0x1);                         /* or al, 0x1 */
    II(0x10187046, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x10187048, 0x3)   inc(memd_a32(ds, edx + 0x18));        /* inc dword [edx+0x18] */
    II(0x1018704b, 0x3)   lea(eax, ebx + 0x4);                  /* lea eax, [ebx+0x4] */
    II(0x1018704e, 0x7)   mov(memd_a32(ds, edx + 0x14), 0xffffffff); /* mov dword [edx+0x14], 0xffffffff */
    II(0x10187055, 0x5)   calld(sys_free, -0x1bf99);            /* call 0x1016b0c1 */
    II(0x1018705a, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
l_0x1018705f:
    II(0x1018705f, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x10187062, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10187063, 0x1)   popd(esi);                            /* pop esi */
    II(0x10187064, 0x1)   popd(edx);                            /* pop edx */
    II(0x10187065, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10187066, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10187067, 0x1)   retd();                               /* ret */
FUNC_END

