FUNC_BEGIN(0x1012124a, 0x22a3197e73cdc9cd, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xfe, 0x4a, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf8, 0xff, 0x45, 0xf8, 0xf, 0xbf, 0x45, 0xf8, 0x83, 0xf8, 0x1e, 0xf, 0x8d, 0x1f, 0x1, 0, 0, 0xf, 0xbf, 0x45, 0xf8, 0x1, 0xc0, 0x66, 0x8b, 0x80, 0xe4, 0xaf, 0x1b, 0x10, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x41, 0x2d, 0x1, 0, 0x89, 0x45, 0xf4, 0xf, 0xbf, 0x55, 0xf8, 0x6b, 0xd2, 0x16, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x8, 0x89, 0x82, 0x9e, 0x53, 0x1c, 0x10, 0x83, 0x7d, 0xf4, 0, 0xf, 0x84, 0xe1, 0, 0, 0, 0x8b, 0x45, 0xf4, 0xf, 0xbf, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x16, 0x89, 0x90, 0x8c, 0x53, 0x1c, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x10, 0xc1, 0xfa, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x16, 0x89, 0x90, 0x90, 0x53, 0x1c, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x2, 0xc1, 0xfa, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x16, 0x89, 0x90, 0x94, 0x53, 0x1c, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x4, 0xc1, 0xfa, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x16, 0x89, 0x90, 0x98, 0x53, 0x1c, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x16, 0x66, 0xc7, 0x80, 0x9c, 0x53, 0x1c, 0x10, 0x1, 0, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x16, 0xf, 0xbf, 0x55, 0xf8, 0x6b, 0xd2, 0x16, 0x8b, 0x92, 0x8c, 0x53, 0x1c, 0x10, 0x1, 0xd2, 0x3b, 0x90, 0x90, 0x53, 0x1c, 0x10, 0x7d, 0x5f, 0xf, 0xbf, 0x55, 0xf8, 0x6b, 0xd2, 0x16, 0xf, 0xbf, 0x5d, 0xf8, 0x6b, 0xdb, 0x16, 0x8b, 0x92, 0x90, 0x53, 0x1c, 0x10, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xbb, 0x8c, 0x53, 0x1c, 0x10, 0x89, 0xc2, 0x89, 0xd3, 0xf, 0xbf, 0x55, 0xf8, 0x6b, 0xd2, 0x16, 0x66, 0x89, 0x9a, 0x9c, 0x53, 0x1c, 0x10, 0xf, 0xbf, 0x5d, 0xf8, 0x6b, 0xdb, 0x16, 0xf, 0xbf, 0x55, 0xf8, 0x6b, 0xd2, 0x16, 0x8b, 0x8a, 0x9a, 0x53, 0x1c, 0x10, 0xc1, 0xf9, 0x10, 0x8b, 0x83, 0x90, 0x53, 0x1c, 0x10, 0x8b, 0x93, 0x90, 0x53, 0x1c, 0x10, 0xc1, 0xfa, 0x1f, 0xf7, 0xf9, 0x89, 0x83, 0x90, 0x53, 0x1c, 0x10, 0xe9, 0xce, 0xfe, 0xff, 0xff, 0xc6, 0x5, 0x20, 0x56, 0x1c, 0x10, 0x1e, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012124a, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1012124f, 0x5)   calld(sys_check_available_stack_size, 0x44afe); /* call 0x10165d52 */
    II(0x10121254, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10121255, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10121256, 0x1)   pushd(edx);                           /* push edx */
    II(0x10121257, 0x1)   pushd(esi);                           /* push esi */
    II(0x10121258, 0x1)   pushd(edi);                           /* push edi */
    II(0x10121259, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012125a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012125c, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10121262, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x10121269, 0x2)   jmpd(0x10121271, 0x6);                /* jmp 0x10121271 */
l_0x1012126b:
    II(0x1012126b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012126e, 0x3)   inc(memd_a32(ss, ebp - 0x8));         /* inc dword [ebp-0x8] */
l_0x10121271:
    II(0x10121271, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10121275, 0x3)   cmp(eax, 0x1e);                       /* cmp eax, 0x1e */
    II(0x10121278, 0x6)   jged(0x1012139d, 0x11f);              /* jge dword 0x1012139d */
    II(0x1012127e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10121282, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x10121284, 0x7)   mov(ax, memw_a32(ds, eax + 0x101bafe4)); /* mov ax, [eax+0x101bafe4] */
    II(0x1012128b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1012128e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10121292, 0x5)   calld(my_get_res_data_by_id, 0x12d41); /* call 0x10133fd8 */
    II(0x10121297, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1012129a, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x1012129e, 0x3)   imul(edx, edx, 0x16);                 /* imul edx, edx, 0x16 */
    II(0x101212a1, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101212a4, 0x3)   add(eax, 0x8);                        /* add eax, 0x8 */
    II(0x101212a7, 0x6)   mov(memd_a32(ds, edx + 0x101c539e), eax); /* mov [edx+0x101c539e], eax */
    II(0x101212ad, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0);      /* cmp dword [ebp-0xc], 0x0 */
    II(0x101212b1, 0x6)   jzd(0x10121398, 0xe1);                /* jz dword 0x10121398 */
    II(0x101212b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101212ba, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x101212bd, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x101212c1, 0x3)   imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
    II(0x101212c4, 0x6)   mov(memd_a32(ds, eax + 0x101c538c), edx); /* mov [eax+0x101c538c], edx */
    II(0x101212ca, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101212cd, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x101212cf, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x101212d2, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x101212d6, 0x3)   imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
    II(0x101212d9, 0x6)   mov(memd_a32(ds, eax + 0x101c5390), edx); /* mov [eax+0x101c5390], edx */
    II(0x101212df, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101212e2, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
    II(0x101212e5, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x101212e8, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x101212ec, 0x3)   imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
    II(0x101212ef, 0x6)   mov(memd_a32(ds, eax + 0x101c5394), edx); /* mov [eax+0x101c5394], edx */
    II(0x101212f5, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101212f8, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x101212fb, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x101212fe, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10121302, 0x3)   imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
    II(0x10121305, 0x6)   mov(memd_a32(ds, eax + 0x101c5398), edx); /* mov [eax+0x101c5398], edx */
    II(0x1012130b, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012130f, 0x3)   imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
    II(0x10121312, 0x9)   mov(memw_a32(ds, eax + 0x101c539c), 0x1); /* mov word [eax+0x101c539c], 0x1 */
    II(0x1012131b, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012131f, 0x3)   imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
    II(0x10121322, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x10121326, 0x3)   imul(edx, edx, 0x16);                 /* imul edx, edx, 0x16 */
    II(0x10121329, 0x6)   mov(edx, memd_a32(ds, edx + 0x101c538c)); /* mov edx, [edx+0x101c538c] */
    II(0x1012132f, 0x2)   add(edx, edx);                        /* add edx, edx */
    II(0x10121331, 0x6)   cmp(edx, memd_a32(ds, eax + 0x101c5390)); /* cmp edx, [eax+0x101c5390] */
    II(0x10121337, 0x2)   jged(0x10121398, 0x5f);               /* jge 0x10121398 */
    II(0x10121339, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x1012133d, 0x3)   imul(edx, edx, 0x16);                 /* imul edx, edx, 0x16 */
    II(0x10121340, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x8));  /* movsx ebx, word [ebp-0x8] */
    II(0x10121344, 0x3)   imul(ebx, ebx, 0x16);                 /* imul ebx, ebx, 0x16 */
    II(0x10121347, 0x6)   mov(edx, memd_a32(ds, edx + 0x101c5390)); /* mov edx, [edx+0x101c5390] */
    II(0x1012134d, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1012134f, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x10121352, 0x6)   idiv(memd_a32(ds, ebx + 0x101c538c)); /* idiv dword [ebx+0x101c538c] */
    II(0x10121358, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1012135a, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x1012135c, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x10121360, 0x3)   imul(edx, edx, 0x16);                 /* imul edx, edx, 0x16 */
    II(0x10121363, 0x7)   mov(memw_a32(ds, edx + 0x101c539c), bx); /* mov [edx+0x101c539c], bx */
    II(0x1012136a, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x8));  /* movsx ebx, word [ebp-0x8] */
    II(0x1012136e, 0x3)   imul(ebx, ebx, 0x16);                 /* imul ebx, ebx, 0x16 */
    II(0x10121371, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x10121375, 0x3)   imul(edx, edx, 0x16);                 /* imul edx, edx, 0x16 */
    II(0x10121378, 0x6)   mov(ecx, memd_a32(ds, edx + 0x101c539a)); /* mov ecx, [edx+0x101c539a] */
    II(0x1012137e, 0x3)   sar(ecx, 0x10);                       /* sar ecx, 0x10 */
    II(0x10121381, 0x6)   mov(eax, memd_a32(ds, ebx + 0x101c5390)); /* mov eax, [ebx+0x101c5390] */
    II(0x10121387, 0x6)   mov(edx, memd_a32(ds, ebx + 0x101c5390)); /* mov edx, [ebx+0x101c5390] */
    II(0x1012138d, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x10121390, 0x2)   idiv(ecx);                            /* idiv ecx */
    II(0x10121392, 0x6)   mov(memd_a32(ds, ebx + 0x101c5390), eax); /* mov [ebx+0x101c5390], eax */
l_0x10121398:
    II(0x10121398, 0x5)   jmpd(0x1012126b, -0x132);             /* jmp 0x1012126b */
l_0x1012139d:
    II(0x1012139d, 0x7)   mov(memb_a32(ds, 0x101c5620), 0x1e);  /* mov byte [0x101c5620], 0x1e */
    II(0x101213a4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101213a6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101213a7, 0x1)   popd(edi);                            /* pop edi */
    II(0x101213a8, 0x1)   popd(esi);                            /* pop esi */
    II(0x101213a9, 0x1)   popd(edx);                            /* pop edx */
    II(0x101213aa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101213ab, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101213ac, 0x1)   retd();                               /* ret */
FUNC_END

