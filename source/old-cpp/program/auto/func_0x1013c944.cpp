FUNC_BEGIN(0x1013c944, 0xeb06ae5691bb16f4, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x4, 0x94, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x20, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0xa9, 0xd, 0, 0, 0xff, 0xff, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x4, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x10, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xc7, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x8, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0xc, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0xe, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0xc5, 0xd, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0xca, 0xd, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0xce, 0xd, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x16, 0, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x17, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x1c, 0xff, 0xff, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0xa5, 0xd, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0xad, 0xd, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc6, 0x80, 0xd2, 0xd, 0, 0, 0, 0xc7, 0x45, 0xf8, 0x14, 0, 0, 0, 0xff, 0x4d, 0xf8, 0x66, 0x83, 0x7d, 0xf8, 0xff, 0x74, 0x3d, 0xf, 0xbf, 0x45, 0xf8, 0x69, 0xc0, 0x91, 0, 0, 0, 0x3, 0x45, 0xfc, 0xc7, 0x80, 0x51, 0x2, 0, 0, 0xff, 0xff, 0, 0, 0xbb, 0x74, 0, 0, 0, 0x31, 0xd2, 0xf, 0xbf, 0x45, 0xf8, 0x69, 0xc0, 0x91, 0, 0, 0, 0x8b, 0x4d, 0xfc, 0x81, 0xc1, 0x51, 0x2, 0, 0, 0x1, 0xc8, 0x83, 0xc0, 0xb, 0xe8, 0x86, 0x93, 0x2, 0, 0xeb, 0xb9, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013c944, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1013c949, 0x5)   calld(sys_check_available_stack_size, 0x29404); /* call 0x10165d52 */
    II(0x1013c94e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c94f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c950, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013c951, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c952, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c953, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c954, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c956, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013c95c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013c95f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c962, 0x4)   mov(memb_a32(ds, eax + 0x20), 0);     /* mov byte [eax+0x20], 0x0 */
    II(0x1013c966, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c969, 0xa)   mov(memd_a32(ds, eax + 0xda9), 0xffff); /* mov dword [eax+0xda9], 0xffff */
    II(0x1013c973, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c976, 0x7)   mov(memd_a32(ds, eax + 0x4), 0);      /* mov dword [eax+0x4], 0x0 */
    II(0x1013c97d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c980, 0x6)   mov(memw_a32(ds, eax + 0x10), 0xffff); /* mov word [eax+0x10], 0xffff */
    II(0x1013c986, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c989, 0x6)   mov(memd_a32(ds, eax), 0);            /* mov dword [eax], 0x0 */
    II(0x1013c98f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c992, 0x7)   mov(memd_a32(ds, eax + 0x8), 0);      /* mov dword [eax+0x8], 0x0 */
    II(0x1013c999, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c99c, 0x6)   mov(memw_a32(ds, eax + 0xc), 0xffff); /* mov word [eax+0xc], 0xffff */
    II(0x1013c9a2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9a5, 0x6)   mov(memw_a32(ds, eax + 0xe), 0xffff); /* mov word [eax+0xe], 0xffff */
    II(0x1013c9ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9ae, 0xa)   mov(memd_a32(ds, eax + 0xdc5), 0);    /* mov dword [eax+0xdc5], 0x0 */
    II(0x1013c9b8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9bb, 0xa)   mov(memd_a32(ds, eax + 0xdca), 0);    /* mov dword [eax+0xdca], 0x0 */
    II(0x1013c9c5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9c8, 0xa)   mov(memd_a32(ds, eax + 0xdce), 0);    /* mov dword [eax+0xdce], 0x0 */
    II(0x1013c9d2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9d5, 0x4)   mov(memb_a32(ds, eax + 0x16), 0);     /* mov byte [eax+0x16], 0x0 */
    II(0x1013c9d9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9dc, 0x4)   mov(memb_a32(ds, eax + 0x17), 0);     /* mov byte [eax+0x17], 0x0 */
    II(0x1013c9e0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9e3, 0x7)   mov(memd_a32(ds, eax + 0x1c), 0xffff); /* mov dword [eax+0x1c], 0xffff */
    II(0x1013c9ea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9ed, 0xa)   mov(memd_a32(ds, eax + 0xda5), 0);    /* mov dword [eax+0xda5], 0x0 */
    II(0x1013c9f7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c9fa, 0xa)   mov(memd_a32(ds, eax + 0xdad), 0);    /* mov dword [eax+0xdad], 0x0 */
    II(0x1013ca04, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ca07, 0x7)   mov(memb_a32(ds, eax + 0xdd2), 0);    /* mov byte [eax+0xdd2], 0x0 */
    II(0x1013ca0e, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x14);   /* mov dword [ebp-0x8], 0x14 */
l_0x1013ca15:
    II(0x1013ca15, 0x3)   dec(memd_a32(ss, ebp - 0x8));         /* dec dword [ebp-0x8] */
    II(0x1013ca18, 0x5)   cmp(memw_a32(ss, ebp - 0x8), -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xff */
    II(0x1013ca1d, 0x2)   jzd(0x1013ca5c, 0x3d);                /* jz 0x1013ca5c */
    II(0x1013ca1f, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1013ca23, 0x6)   imul(eax, eax, 0x91);                 /* imul eax, eax, 0x91 */
    II(0x1013ca29, 0x3)   add(eax, memd_a32(ss, ebp - 0x4));    /* add eax, [ebp-0x4] */
    II(0x1013ca2c, 0xa)   mov(memd_a32(ds, eax + 0x251), 0xffff); /* mov dword [eax+0x251], 0xffff */
    II(0x1013ca36, 0x5)   mov(ebx, 0x74);                       /* mov ebx, 0x74 */
    II(0x1013ca3b, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013ca3d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1013ca41, 0x6)   imul(eax, eax, 0x91);                 /* imul eax, eax, 0x91 */
    II(0x1013ca47, 0x3)   mov(ecx, memd_a32(ss, ebp - 0x4));    /* mov ecx, [ebp-0x4] */
    II(0x1013ca4a, 0x6)   add(ecx, 0x251);                      /* add ecx, 0x251 */
    II(0x1013ca50, 0x2)   add(eax, ecx);                        /* add eax, ecx */
    II(0x1013ca52, 0x3)   add(eax, 0xb);                        /* add eax, 0xb */
    II(0x1013ca55, 0x5)   calld(sys_memset, 0x29386);           /* call 0x10165de0 */
    II(0x1013ca5a, 0x2)   jmpd(0x1013ca15, -0x47);              /* jmp 0x1013ca15 */
l_0x1013ca5c:
    II(0x1013ca5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ca5f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013ca62, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013ca65, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013ca67, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013ca68, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013ca69, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013ca6a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013ca6b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013ca6c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013ca6d, 0x1)   retd();                               /* ret */
FUNC_END

