FUNC_BEGIN(0x10125871, 0x343637d9b22e11a2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd7, 0x4, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x88, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x8, 0, 0, 0, 0xb8, 0xd, 0, 0, 0, 0x31, 0xd2, 0x66, 0x8b, 0x15, 0x5c, 0xb4, 0x1b, 0x10, 0x42, 0xee, 0xa1, 0x78, 0x58, 0x1c, 0x10, 0x8b, 0x15, 0x7c, 0x58, 0x1c, 0x10, 0x8b, 0, 0x89, 0x2, 0xff, 0x4d, 0xf8, 0x66, 0x83, 0x7d, 0xf8, 0xff, 0x74, 0x36, 0x31, 0xd2, 0x66, 0x8b, 0x15, 0x5c, 0xb4, 0x1b, 0x10, 0x83, 0xc2, 0x6, 0x29, 0xc0, 0xec, 0x31, 0xc0, 0x66, 0xa1, 0x5c, 0xb4, 0x1b, 0x10, 0x8d, 0x50, 0x5, 0x29, 0xc0, 0xec, 0x83, 0xe0, 0x60, 0x83, 0xf8, 0x60, 0x75, 0xea, 0xb8, 0xff, 0, 0, 0, 0x31, 0xd2, 0x66, 0x8b, 0x15, 0x5c, 0xb4, 0x1b, 0x10, 0xee, 0xeb, 0xc0, 0x31, 0xd2, 0x8a, 0x55, 0xfc, 0xc1, 0xe2, 0x2, 0xa1, 0x7c, 0x58, 0x1c, 0x10, 0x8b, 0x92, 0x80, 0x58, 0x1c, 0x10, 0x89, 0x10, 0xb8, 0xf, 0, 0, 0, 0x31, 0xd2, 0x66, 0x8b, 0x15, 0x5c, 0xb4, 0x1b, 0x10, 0x42, 0xee, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10125871, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10125876, 0x5)   calld(sys_check_available_stack_size, 0x404d7); /* call 0x10165d52 */
    II(0x1012587b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012587c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012587d, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012587e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012587f, 0x1)   pushd(edi);                           /* push edi */
    II(0x10125880, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10125881, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10125883, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10125889, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
    II(0x1012588c, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x8);    /* mov dword [ebp-0x8], 0x8 */
    II(0x10125893, 0x5)   mov(eax, 0xd);                        /* mov eax, 0xd */
    II(0x10125898, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1012589a, 0x7)   mov(dx, memw_a32(ds, 0x101bb45c));    /* mov dx, [0x101bb45c] */
    II(0x101258a1, 0x1)   inc(edx);                             /* inc edx */
    II(0x101258a2, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x101258a3, 0x5)   mov(eax, memd_a32(ds, 0x101c5878));   /* mov eax, [0x101c5878] */
    II(0x101258a8, 0x6)   mov(edx, memd_a32(ds, 0x101c587c));   /* mov edx, [0x101c587c] */
    II(0x101258ae, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x101258b0, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
l_0x101258b2:
    II(0x101258b2, 0x3)   dec(memd_a32(ss, ebp - 0x8));         /* dec dword [ebp-0x8] */
    II(0x101258b5, 0x5)   cmp(memw_a32(ss, ebp - 0x8), -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xff */
    II(0x101258ba, 0x2)   jzd(0x101258f2, 0x36);                /* jz 0x101258f2 */
    II(0x101258bc, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101258be, 0x7)   mov(dx, memw_a32(ds, 0x101bb45c));    /* mov dx, [0x101bb45c] */
    II(0x101258c5, 0x3)   add(edx, 0x6);                        /* add edx, 0x6 */
    II(0x101258c8, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x101258ca, 0x1)   inb(al, dx);                          /* in al, dx */
l_0x101258cb:
    II(0x101258cb, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101258cd, 0x6)   mov(ax, memw_a32(ds, 0x101bb45c));    /* mov ax, [0x101bb45c] */
    II(0x101258d3, 0x3)   lea(edx, eax + 0x5);                  /* lea edx, [eax+0x5] */
    II(0x101258d6, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x101258d8, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x101258d9, 0x3)   and_(eax, 0x60);                      /* and eax, 0x60 */
    II(0x101258dc, 0x3)   cmp(eax, 0x60);                       /* cmp eax, 0x60 */
    II(0x101258df, 0x2)   jnzd(0x101258cb, -0x16);              /* jnz 0x101258cb */
    II(0x101258e1, 0x5)   mov(eax, 0xff);                       /* mov eax, 0xff */
    II(0x101258e6, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101258e8, 0x7)   mov(dx, memw_a32(ds, 0x101bb45c));    /* mov dx, [0x101bb45c] */
    II(0x101258ef, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x101258f0, 0x2)   jmpd(0x101258b2, -0x40);              /* jmp 0x101258b2 */
l_0x101258f2:
    II(0x101258f2, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101258f4, 0x3)   mov(dl, memb_a32(ss, ebp - 0x4));     /* mov dl, [ebp-0x4] */
    II(0x101258f7, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x101258fa, 0x5)   mov(eax, memd_a32(ds, 0x101c587c));   /* mov eax, [0x101c587c] */
    II(0x101258ff, 0x6)   mov(edx, memd_a32(ds, edx + 0x101c5880)); /* mov edx, [edx+0x101c5880] */
    II(0x10125905, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x10125907, 0x5)   mov(eax, 0xf);                        /* mov eax, 0xf */
    II(0x1012590c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1012590e, 0x7)   mov(dx, memw_a32(ds, 0x101bb45c));    /* mov dx, [0x101bb45c] */
    II(0x10125915, 0x1)   inc(edx);                             /* inc edx */
    II(0x10125916, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10125917, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10125919, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012591a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012591b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012591c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012591d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012591e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012591f, 0x1)   retd();                               /* ret */
FUNC_END

