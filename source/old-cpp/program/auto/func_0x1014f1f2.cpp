FUNC_BEGIN(0x1014f1f2, 0x4eb918d5f2d33800, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x56, 0x6b, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf8, 0xff, 0x45, 0xf8, 0xf, 0xbf, 0x45, 0xf8, 0x83, 0xf8, 0x5, 0x7d, 0x5f, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x29, 0x74, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x2a, 0x75, 0x2, 0xeb, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x42, 0x75, 0x2, 0xeb, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0x8, 0x47, 0x75, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0x3, 0x45, 0xfc, 0xc6, 0x80, 0xab, 0, 0, 0, 0, 0xeb, 0x13, 0xf, 0xbf, 0x45, 0xf8, 0x3, 0x45, 0xfc, 0x8a, 0x15, 0x20, 0x39, 0x1c, 0x10, 0x88, 0x90, 0xab, 0, 0, 0, 0xf, 0xbf, 0x45, 0xf8, 0x3, 0x45, 0xfc, 0xc6, 0x80, 0xb0, 0, 0, 0, 0, 0xeb, 0x92, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x26, 0x25, 0xff, 0, 0, 0, 0x3, 0x45, 0xfc, 0xc6, 0x80, 0xab, 0, 0, 0, 0x1, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014f1f2, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014f1f7, 0x5)   calld(sys_check_available_stack_size, 0x16b56); /* call 0x10165d52 */
    II(0x1014f1fc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014f1fd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014f1fe, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014f1ff, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014f200, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014f201, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014f202, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014f204, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014f20a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1014f20d, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x1014f214, 0x2)   jmpd(0x1014f21c, 0x6);                /* jmp 0x1014f21c */
l_0x1014f216:
    II(0x1014f216, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f219, 0x3)   inc(memd_a32(ss, ebp - 0x8));         /* inc dword [ebp-0x8] */
l_0x1014f21c:
    II(0x1014f21c, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1014f220, 0x3)   cmp(eax, 0x5);                        /* cmp eax, 0x5 */
    II(0x1014f223, 0x2)   jged(0x1014f284, 0x5f);               /* jge 0x1014f284 */
    II(0x1014f225, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f228, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x29);   /* cmp word [eax+0x8], 0x29 */
    II(0x1014f22d, 0x2)   jzd(0x1014f239, 0xa);                 /* jz 0x1014f239 */
    II(0x1014f22f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f232, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x2a);   /* cmp word [eax+0x8], 0x2a */
    II(0x1014f237, 0x2)   jnzd(0x1014f23b, 0x2);                /* jnz 0x1014f23b */
l_0x1014f239:
    II(0x1014f239, 0x2)   jmpd(0x1014f245, 0xa);                /* jmp 0x1014f245 */
l_0x1014f23b:
    II(0x1014f23b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f23e, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x42);   /* cmp word [eax+0x8], 0x42 */
    II(0x1014f243, 0x2)   jnzd(0x1014f247, 0x2);                /* jnz 0x1014f247 */
l_0x1014f245:
    II(0x1014f245, 0x2)   jmpd(0x1014f251, 0xa);                /* jmp 0x1014f251 */
l_0x1014f247:
    II(0x1014f247, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f24a, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x47);   /* cmp word [eax+0x8], 0x47 */
    II(0x1014f24f, 0x2)   jnzd(0x1014f261, 0x10);               /* jnz 0x1014f261 */
l_0x1014f251:
    II(0x1014f251, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1014f255, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1014f258, 0x7)   mov(memb_a32(ds, eax + 0xab), 0);     /* mov byte [eax+0xab], 0x0 */
    II(0x1014f25f, 0x2)   jmpd(0x1014f274, 0x13);               /* jmp 0x1014f274 */
l_0x1014f261:
    II(0x1014f261, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1014f265, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1014f268, 0x6)   mov(dl, memb_a32(ds, 0x101c3920));    /* mov dl, [0x101c3920] */
    II(0x1014f26e, 0x6)   mov(memb_a32(ds, eax + 0xab), dl);    /* mov [eax+0xab], dl */
l_0x1014f274:
    II(0x1014f274, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1014f278, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1014f27b, 0x7)   mov(memb_a32(ds, eax + 0xb0), 0);     /* mov byte [eax+0xb0], 0x0 */
    II(0x1014f282, 0x2)   jmpd(0x1014f216, -0x6e);              /* jmp 0x1014f216 */
l_0x1014f284:
    II(0x1014f284, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014f287, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x1014f28a, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1014f28f, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1014f292, 0x7)   mov(memb_a32(ds, eax + 0xab), 0x1);   /* mov byte [eax+0xab], 0x1 */
    II(0x1014f299, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014f29b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014f29c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014f29d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014f29e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014f29f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014f2a0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014f2a1, 0x1)   retd();                               /* ret */
FUNC_END

