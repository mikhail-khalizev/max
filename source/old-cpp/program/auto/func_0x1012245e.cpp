FUNC_BEGIN(0x1012245e, 0x6ae36837868ac49a, 0x20, ({0x68, 0x44, 0, 0, 0, 0xe8, 0xea, 0x38, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x2c, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x1c, 0xba, 0x5c, 0xb0, 0x1b, 0x10, 0x1, 0xc2, 0x89, 0x55, 0xe0, 0x8b, 0x55, 0xf4, 0x83, 0xc2, 0x17, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x10, 0xe8, 0xcd, 0x5a, 0xfb, 0xff, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0xe8, 0xcb, 0x49, 0xf5, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x8, 0xc1, 0xf8, 0x10, 0xe8, 0xc3, 0x72, 0xf6, 0xff, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x10, 0xe8, 0x21, 0x2a, 0xfb, 0xff, 0x5, 0xa, 0, 0, 0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x10, 0xe8, 0xda, 0x29, 0xfb, 0xff, 0x89, 0x45, 0xdc, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x10, 0xe8, 0x68, 0x2a, 0xfb, 0xff, 0x83, 0xe8, 0x14, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xe0, 0x8b, 0x40, 0x10, 0xe8, 0x23, 0x2a, 0xfb, 0xff, 0x89, 0x45, 0xe4, 0xb8, 0x83, 0x1, 0, 0, 0xe8, 0xca, 0x1a, 0x1, 0, 0x89, 0x45, 0xd8, 0x8b, 0x55, 0xd8, 0xf, 0xbf, 0x12, 0xf, 0xbf, 0x45, 0xfc, 0xf, 0xaf, 0xd0, 0x8b, 0x5d, 0xe0, 0x8b, 0x5b, 0x8, 0xc1, 0xfb, 0x10, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0xf, 0xbf, 0x55, 0xec, 0x1, 0xd0, 0x89, 0x45, 0xe8, 0xb8, 0x82, 0x1, 0, 0, 0xe8, 0x97, 0x1a, 0x1, 0, 0x89, 0x45, 0xd8, 0x8b, 0x55, 0xd8, 0xf, 0xbf, 0x12, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0xf, 0xbf, 0x55, 0xe8, 0x29, 0xc2, 0x89, 0x55, 0xe8, 0x8b, 0x55, 0xd8, 0x8b, 0x12, 0xc1, 0xfa, 0x10, 0xb8, 0x14, 0, 0, 0, 0x29, 0xd0, 0x89, 0xc2, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0xf, 0xbf, 0x55, 0xdc, 0x1, 0xd0, 0x89, 0x45, 0xd4, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x17, 0x50, 0xb9, 0x1, 0, 0, 0, 0xf, 0xbf, 0x5d, 0xd4, 0xf, 0xbf, 0x55, 0xe8, 0xb8, 0x82, 0x1, 0, 0, 0xe8, 0x54, 0x69, 0xfc, 0xff, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xe0, 0x66, 0x89, 0x42, 0x18, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1012245e, 0x5)   pushd(0x44);                          /* push dword 0x44 */
    II(0x10122463, 0x5)   calld(sys_check_available_stack_size, 0x438ea); /* call 0x10165d52 */
    II(0x10122468, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10122469, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012246a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012246b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012246c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012246e, 0x6)   sub(esp, 0x2c);                       /* sub esp, 0x2c */
    II(0x10122474, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10122477, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1012247a, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x1012247d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10122481, 0x3)   imul(eax, eax, 0x1c);                 /* imul eax, eax, 0x1c */
    II(0x10122484, 0x5)   mov(edx, 0x101bb05c);                 /* mov edx, 0x101bb05c */
    II(0x10122489, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1012248b, 0x3)   mov(memd_a32(ss, ebp - 0x20), edx);   /* mov [ebp-0x20], edx */
    II(0x1012248e, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x10122491, 0x3)   add(edx, 0x17);                       /* add edx, 0x17 */
    II(0x10122494, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x10122497, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x1012249a, 0x5)   calld(0x100d7f6c, -0x4a533);          /* call 0x100d7f6c */
    II(0x1012249f, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x101224a3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x101224a6, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x101224a9, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x101224ac, 0x5)   calld(0x10076e7c, -0xab635);          /* call 0x10076e7c */
    II(0x101224b1, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101224b3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x101224b6, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x101224b9, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x101224bc, 0x5)   calld(my_min, -0x98d3d);              /* call 0x10089784 */
    II(0x101224c1, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101224c4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x101224c7, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x101224ca, 0x5)   calld(0x100d4ef0, -0x4d5df);          /* call 0x100d4ef0 */
    II(0x101224cf, 0x5)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x101224d4, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x101224d7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x101224da, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x101224dd, 0x5)   calld(0x100d4ebc, -0x4d626);          /* call 0x100d4ebc */
    II(0x101224e2, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
    II(0x101224e5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x101224e8, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x101224eb, 0x5)   calld(0x100d4f58, -0x4d598);          /* call 0x100d4f58 */
    II(0x101224f0, 0x3)   sub(eax, 0x14);                       /* sub eax, 0x14 */
    II(0x101224f3, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x101224f6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x101224f9, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x101224fc, 0x5)   calld(0x100d4f24, -0x4d5dd);          /* call 0x100d4f24 */
    II(0x10122501, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x10122504, 0x5)   mov(eax, 0x183);                      /* mov eax, 0x183 */
    II(0x10122509, 0x5)   calld(my_get_res_data_by_id, 0x11aca); /* call 0x10133fd8 */
    II(0x1012250e, 0x3)   mov(memd_a32(ss, ebp - 0x28), eax);   /* mov [ebp-0x28], eax */
    II(0x10122511, 0x3)   mov(edx, memd_a32(ss, ebp - 0x28));   /* mov edx, [ebp-0x28] */
    II(0x10122514, 0x3)   movsx(edx, memw_a32(ds, edx));        /* movsx edx, word [edx] */
    II(0x10122517, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x1012251b, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x1012251e, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x20));   /* mov ebx, [ebp-0x20] */
    II(0x10122521, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x8));    /* mov ebx, [ebx+0x8] */
    II(0x10122524, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10122527, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x10122529, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1012252c, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x1012252e, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x14)); /* movsx edx, word [ebp-0x14] */
    II(0x10122532, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10122534, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x10122537, 0x5)   mov(eax, 0x182);                      /* mov eax, 0x182 */
    II(0x1012253c, 0x5)   calld(my_get_res_data_by_id, 0x11a97); /* call 0x10133fd8 */
    II(0x10122541, 0x3)   mov(memd_a32(ss, ebp - 0x28), eax);   /* mov [ebp-0x28], eax */
    II(0x10122544, 0x3)   mov(edx, memd_a32(ss, ebp - 0x28));   /* mov edx, [ebp-0x28] */
    II(0x10122547, 0x3)   movsx(edx, memw_a32(ds, edx));        /* movsx edx, word [edx] */
    II(0x1012254a, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1012254c, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1012254f, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x10122551, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x10122553, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x18)); /* movsx edx, word [ebp-0x18] */
    II(0x10122557, 0x2)   sub(edx, eax);                        /* sub edx, eax */
    II(0x10122559, 0x3)   mov(memd_a32(ss, ebp - 0x18), edx);   /* mov [ebp-0x18], edx */
    II(0x1012255c, 0x3)   mov(edx, memd_a32(ss, ebp - 0x28));   /* mov edx, [ebp-0x28] */
    II(0x1012255f, 0x2)   mov(edx, memd_a32(ds, edx));          /* mov edx, [edx] */
    II(0x10122561, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10122564, 0x5)   mov(eax, 0x14);                       /* mov eax, 0x14 */
    II(0x10122569, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x1012256b, 0x2)   mov(edx, eax);                        /* mov edx, eax */
//    II(0x1012256d, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1012256f, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x10122572, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x10122574, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x10122576, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x24)); /* movsx edx, word [ebp-0x24] */
    II(0x1012257a, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1012257c, 0x3)   mov(memd_a32(ss, ebp - 0x2c), eax);   /* mov [ebp-0x2c], eax */
    II(0x1012257f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10122582, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x10122585, 0x1)   pushd(eax);                           /* push eax */
    II(0x10122586, 0x5)   mov(ecx, 0x1);                        /* mov ecx, 0x1 */
    II(0x1012258b, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x2c)); /* movsx ebx, word [ebp-0x2c] */
    II(0x1012258f, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x18)); /* movsx edx, word [ebp-0x18] */
    II(0x10122593, 0x5)   mov(eax, 0x182);                      /* mov eax, 0x182 */
    II(0x10122598, 0x5)   calld(0x100e8ef1, -0x396ac);          /* call 0x100e8ef1 */
    II(0x1012259d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101225a0, 0x3)   mov(edx, memd_a32(ss, ebp - 0x20));   /* mov edx, [ebp-0x20] */
    II(0x101225a3, 0x4)   mov(memw_a32(ds, edx + 0x18), ax);    /* mov [edx+0x18], ax */
    II(0x101225a7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101225a9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101225aa, 0x1)   popd(edi);                            /* pop edi */
    II(0x101225ab, 0x1)   popd(esi);                            /* pop esi */
    II(0x101225ac, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101225ad, 0x1)   retd();                               /* ret */
FUNC_END

