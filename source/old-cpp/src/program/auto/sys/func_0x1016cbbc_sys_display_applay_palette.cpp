FUNC_BEGIN(sys_display_applay_palette, 0xa850e20f21b9adca, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x81, 0xec, 0, 0x3, 0, 0, 0x31, 0xdb, 0x31, 0xc9, 0x8a, 0x8, 0x8a, 0x89, 0xe0, 0xff, 0x1c, 0x10, 0x88, 0xc, 0x1c, 0x43, 0x8a, 0x8, 0x40, 0x88, 0x8b, 0xdf, 0xfc, 0x1c, 0x10, 0x81, 0xfb, 0, 0x3, 0, 0, 0x7c, 0xe1, 0x89, 0xe1, 0x31, 0xdb, 0xbe, 0xc9, 0x3, 0, 0, 0xba, 0xc8, 0x3, 0, 0, 0x88, 0xd8, 0xee, 0x89, 0xf2, 0x8a, 0x1, 0xee, 0x8a, 0x41, 0x1, 0x83, 0xc1, 0x3, 0xee, 0x8a, 0x41, 0xff, 0x43, 0xee, 0x81, 0xfb, 0, 0x1, 0, 0, 0x7c, 0xdf, 0x81, 0xc4, 0, 0x3, 0, 0, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016cbbc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016cbbd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016cbbe, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016cbbf, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016cbc0, 0x6)   sub(esp, 0x300);                      /* sub esp, 0x300 */
    II(0x1016cbc6, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
l_0x1016cbc8:
    II(0x1016cbc8, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1016cbca, 0x2)   mov(cl, memb_a32(ds, eax));           /* mov cl, [eax] */
    II(0x1016cbcc, 0x6)   mov(cl, memb_a32(ds, ecx + 0x101cffe0)); /* mov cl, [ecx+0x101cffe0] */
    II(0x1016cbd2, 0x3)   mov(memb_a32(ss, esp + ebx), cl);     /* mov [esp+ebx], cl */
    II(0x1016cbd5, 0x1)   inc(ebx);                             /* inc ebx */
    II(0x1016cbd6, 0x2)   mov(cl, memb_a32(ds, eax));           /* mov cl, [eax] */
    II(0x1016cbd8, 0x1)   inc(eax);                             /* inc eax */
    II(0x1016cbd9, 0x6)   mov(memb_a32(ds, ebx + 0x101cfcdf), cl); /* mov [ebx+0x101cfcdf], cl */
    II(0x1016cbdf, 0x6)   cmp(ebx, 0x300);                      /* cmp ebx, 0x300 */
    II(0x1016cbe5, 0x2)   jld(0x1016cbc8, -0x1f);               /* jl 0x1016cbc8 */
    II(0x1016cbe7, 0x2)   mov(ecx, esp);                        /* mov ecx, esp */
    II(0x1016cbe9, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1016cbeb, 0x5)   mov(esi, 0x3c9);                      /* mov esi, 0x3c9 */
l_0x1016cbf0:
    II(0x1016cbf0, 0x5)   mov(edx, 0x3c8);                      /* mov edx, 0x3c8 */
    II(0x1016cbf5, 0x2)   mov(al, bl);                          /* mov al, bl */
    II(0x1016cbf7, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x1016cbf8, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x1016cbfa, 0x2)   mov(al, memb_a32(ds, ecx));           /* mov al, [ecx] */
    II(0x1016cbfc, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x1016cbfd, 0x3)   mov(al, memb_a32(ds, ecx + 0x1));     /* mov al, [ecx+0x1] */
    II(0x1016cc00, 0x3)   add(ecx, 0x3);                        /* add ecx, 0x3 */
    II(0x1016cc03, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x1016cc04, 0x3)   mov(al, memb_a32(ds, ecx - 0x1));     /* mov al, [ecx-0x1] */
    II(0x1016cc07, 0x1)   inc(ebx);                             /* inc ebx */
    II(0x1016cc08, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x1016cc09, 0x6)   cmp(ebx, 0x100);                      /* cmp ebx, 0x100 */
    II(0x1016cc0f, 0x2)   jld(0x1016cbf0, -0x21);               /* jl 0x1016cbf0 */
    II(0x1016cc11, 0x6)   add(esp, 0x300);                      /* add esp, 0x300 */
    II(0x1016cc17, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016cc18, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016cc19, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016cc1a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016cc1b, 0x1)   retd();                               /* ret */
FUNC_END

