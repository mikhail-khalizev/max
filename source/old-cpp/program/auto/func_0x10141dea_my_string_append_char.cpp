FUNC_BEGIN(my_string_append_char, 0x111f5026cb1a9225, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x5e, 0x3f, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x4d, 0x5, 0, 0, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xb, 0x91, 0xfa, 0xff, 0x40, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x35, 0x7, 0, 0, 0x66, 0x3b, 0x45, 0xf4, 0x7d, 0x1d, 0xe8, 0x9a, 0x6, 0, 0, 0x31, 0xdb, 0x88, 0xc3, 0xf, 0xbf, 0x45, 0xf4, 0xe8, 0x99, 0x5, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf8, 0xe8, 0x18, 0xfd, 0xff, 0xff, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xa4, 0x79, 0xf4, 0xff, 0x1, 0xc2, 0x8a, 0x45, 0xfc, 0x88, 0x42, 0xff, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x92, 0x79, 0xf4, 0xff, 0xf, 0xbf, 0x55, 0xf4, 0x1, 0xd0, 0xc6, 0, 0, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x6b, 0x6, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10141dea, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10141def, 0x5)   calld(sys_check_available_stack_size, 0x23f5e); /* call 0x10165d52 */
    II(0x10141df4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141df5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141df6, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141df7, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141df8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141df9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141dfb, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10141e01, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10141e04, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x10141e07, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e0a, 0x5)   calld(my_string_make_single_ref, 0x54d); /* call 0x1014235c */
    II(0x10141e0f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e12, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141e14, 0x5)   calld(my_strobj_get_len, -0x56ef5);   /* call 0x100eaf24 */
    II(0x10141e19, 0x1)   inc(eax);                             /* inc eax */
    II(0x10141e1a, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10141e1d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e20, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141e22, 0x5)   calld(my_strobj_get_size, 0x735);     /* call 0x1014255c */
    II(0x10141e27, 0x4)   cmp(ax, memw_a32(ss, ebp - 0xc));     /* cmp ax, [ebp-0xc] */
    II(0x10141e2b, 0x2)   jged(0x10141e4a, 0x1d);               /* jge 0x10141e4a */
    II(0x10141e2d, 0x5)   calld(my_set_al_1, 0x69a);            /* call 0x101424cc */
    II(0x10141e32, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10141e34, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x10141e36, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x10141e3a, 0x5)   calld(my_string_compute_capacity_from_length, 0x599); /* call 0x101423d8 */
    II(0x10141e3f, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10141e42, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e45, 0x5)   calld(my_string_reserve, -0x2e8);     /* call 0x10141b62 */
l_0x10141e4a:
    II(0x10141e4a, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x10141e4e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e51, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141e53, 0x5)   calld(my_strobj_c_str, -0xb865c);     /* call 0x100897fc */
    II(0x10141e58, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x10141e5a, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x10141e5d, 0x3)   mov(memb_a32(ds, edx - 0x1), al);     /* mov [edx-0x1], al */
    II(0x10141e60, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e63, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141e65, 0x5)   calld(my_strobj_c_str, -0xb866e);     /* call 0x100897fc */
    II(0x10141e6a, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x10141e6e, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10141e70, 0x3)   mov(memb_a32(ds, eax), 0);            /* mov byte [eax], 0x0 */
    II(0x10141e73, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x10141e77, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e7a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141e7c, 0x5)   calld(my_strobj_set_len, 0x66b);      /* call 0x101424ec */
    II(0x10141e81, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141e84, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x10141e87, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10141e8a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141e8c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141e8d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141e8e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141e8f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141e90, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141e91, 0x1)   retd();                               /* ret */
FUNC_END

