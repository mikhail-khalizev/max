FUNC_BEGIN(my_string_append_string, 0x49dde40d0eb71eec, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xbf, 0x40, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xae, 0x6, 0, 0, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x6c, 0x92, 0xfa, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0x60, 0x92, 0xfa, 0xff, 0x1, 0xc2, 0x89, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x89, 0x8, 0, 0, 0x66, 0x3b, 0x45, 0xf4, 0x7d, 0x1d, 0xe8, 0xee, 0x7, 0, 0, 0x31, 0xdb, 0x88, 0xc3, 0xf, 0xbf, 0x45, 0xf4, 0xe8, 0xed, 0x6, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf8, 0xe8, 0x6c, 0xfe, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0xfc, 0x7a, 0xf4, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x18, 0x92, 0xfa, 0xff, 0xf, 0xbf, 0xd8, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xe3, 0x7a, 0xf4, 0xff, 0x1, 0xd8, 0xe8, 0xaf, 0x41, 0x2, 0, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xbe, 0x7, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10141c89, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10141c8e, 0x5)   calld(sys_check_available_stack_size, 0x240bf); /* call 0x10165d52 */
    II(0x10141c93, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141c94, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141c95, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141c96, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141c97, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141c98, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141c9a, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10141ca0, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10141ca3, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10141ca6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141ca9, 0x5)   calld(my_string_make_single_ref, 0x6ae); /* call 0x1014235c */
    II(0x10141cae, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141cb1, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141cb3, 0x5)   calld(my_strobj_get_len, -0x56d94);   /* call 0x100eaf24 */
    II(0x10141cb8, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10141cba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141cbd, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141cbf, 0x5)   calld(my_strobj_get_len, -0x56da0);   /* call 0x100eaf24 */
    II(0x10141cc4, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x10141cc6, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x10141cc9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141ccc, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141cce, 0x5)   calld(my_strobj_get_size, 0x889);     /* call 0x1014255c */
    II(0x10141cd3, 0x4)   cmp(ax, memw_a32(ss, ebp - 0xc));     /* cmp ax, [ebp-0xc] */
    II(0x10141cd7, 0x2)   jged(0x10141cf6, 0x1d);               /* jge 0x10141cf6 */
    II(0x10141cd9, 0x5)   calld(my_set_al_1, 0x7ee);            /* call 0x101424cc */
    II(0x10141cde, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10141ce0, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x10141ce2, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x10141ce6, 0x5)   calld(my_string_compute_capacity_from_length, 0x6ed); /* call 0x101423d8 */
    II(0x10141ceb, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10141cee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141cf1, 0x5)   calld(my_string_reserve, -0x194);     /* call 0x10141b62 */
l_0x10141cf6:
    II(0x10141cf6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141cf9, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141cfb, 0x5)   calld(my_strobj_c_str, -0xb8504);     /* call 0x100897fc */
    II(0x10141d00, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10141d02, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141d05, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141d07, 0x5)   calld(my_strobj_get_len, -0x56de8);   /* call 0x100eaf24 */
    II(0x10141d0c, 0x3)   movsx(ebx, ax);                       /* movsx ebx, ax */
    II(0x10141d0f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141d12, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141d14, 0x5)   calld(my_strobj_c_str, -0xb851d);     /* call 0x100897fc */
    II(0x10141d19, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x10141d1b, 0x5)   calld(sys_strcpy, 0x241af);           /* call 0x10165ecf */
    II(0x10141d20, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x10141d24, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141d27, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141d29, 0x5)   calld(my_strobj_set_len, 0x7be);      /* call 0x101424ec */
    II(0x10141d2e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141d31, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x10141d34, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10141d37, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141d39, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141d3a, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141d3b, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141d3c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141d3d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141d3e, 0x1)   retd();                               /* ret */
FUNC_END

