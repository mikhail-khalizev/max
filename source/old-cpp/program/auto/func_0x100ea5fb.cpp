FUNC_BEGIN(0x100ea5fb, 0x3941bfdfee60ec59, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0x4d, 0xb7, 0x7, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x30, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x89, 0x5d, 0xf8, 0x89, 0x4d, 0xfc, 0xe8, 0xfb, 0x25, 0x8, 0, 0x89, 0x45, 0xd8, 0x8b, 0x45, 0xfc, 0x3, 0x45, 0x10, 0x89, 0x45, 0xe8, 0xc7, 0x45, 0xd4, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xd4, 0xff, 0x45, 0xd4, 0xf, 0xbf, 0x45, 0xd4, 0x3d, 0, 0x1, 0, 0, 0xf, 0x8d, 0x10, 0x1, 0, 0, 0x8a, 0x45, 0xd4, 0x88, 0x45, 0xec, 0xf, 0xbf, 0x45, 0xd4, 0x8d, 0x4, 0x40, 0x3, 0x45, 0xd8, 0xf, 0xbe, 0x10, 0xf, 0xbf, 0x45, 0x10, 0xf, 0xaf, 0xd0, 0xf, 0xbf, 0x5d, 0xf0, 0xf, 0xbf, 0x45, 0xfc, 0xf, 0xaf, 0xc3, 0x1, 0xc2, 0xf, 0xbf, 0x5d, 0xe8, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x88, 0x45, 0xd0, 0xf, 0xbf, 0x45, 0xd4, 0x8d, 0x4, 0x40, 0x8b, 0x55, 0xd8, 0x1, 0xc2, 0xf, 0xbe, 0x52, 0x2, 0xf, 0xbf, 0x45, 0x10, 0xf, 0xaf, 0xd0, 0x89, 0xd3, 0xf, 0xbf, 0x55, 0xf8, 0xf, 0xbf, 0x45, 0xfc, 0xf, 0xaf, 0xd0, 0x1, 0xda, 0xf, 0xbf, 0x5d, 0xe8, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x88, 0x45, 0xd2, 0xf, 0xbf, 0x45, 0xd4, 0x8d, 0x4, 0x40, 0x3, 0x45, 0xd8, 0xf, 0xbe, 0x50, 0x1, 0xf, 0xbf, 0x45, 0x10, 0xf, 0xaf, 0xd0, 0xf, 0xbf, 0x45, 0xf4, 0xf, 0xbf, 0x5d, 0xfc, 0xf, 0xaf, 0xc3, 0x1, 0xc2, 0xf, 0xbf, 0x5d, 0xe8, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x88, 0x45, 0xd1, 0x8d, 0x55, 0xd0, 0x31, 0xc0, 0x8a, 0x45, 0xec, 0x8d, 0x4, 0x40, 0x3, 0x45, 0xd8, 0xe8, 0xec, 0xf8, 0xff, 0xff, 0x89, 0x45, 0xe4, 0xc7, 0x45, 0xdc, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xdc, 0xff, 0x45, 0xdc, 0xf, 0xbf, 0x45, 0xdc, 0x3d, 0, 0x1, 0, 0, 0x7d, 0x8, 0xf, 0xbf, 0x45, 0xe4, 0x85, 0xc0, 0x7f, 0x2, 0xeb, 0x2c, 0x8d, 0x55, 0xd0, 0xf, 0xbf, 0x45, 0xdc, 0x8d, 0x4, 0x40, 0x3, 0x45, 0xd8, 0xe8, 0xb3, 0xf8, 0xff, 0xff, 0x89, 0x45, 0xe0, 0x8b, 0x45, 0xe0, 0x66, 0x3b, 0x45, 0xe4, 0x7d, 0xc, 0x8b, 0x45, 0xe4, 0x89, 0x45, 0xe0, 0x8a, 0x45, 0xdc, 0x88, 0x45, 0xec, 0xeb, 0xb9, 0xf, 0xbf, 0x55, 0xd4, 0x3, 0x55, 0x14, 0x8a, 0x45, 0xec, 0x88, 0x2, 0xe9, 0xdb, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc2, 0x8, 0}))
    II(0x100ea5fb, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x100ea600, 0x5)   calld(sys_check_available_stack_size, 0x7b74d); /* call 0x10165d52 */
    II(0x100ea605, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ea606, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ea607, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ea608, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ea60a, 0x6)   sub(esp, 0x30);                       /* sub esp, 0x30 */
    II(0x100ea610, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100ea613, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100ea616, 0x3)   mov(memd_a32(ss, ebp - 0x8), ebx);    /* mov [ebp-0x8], ebx */
    II(0x100ea619, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
    II(0x100ea61c, 0x5)   calld(/* sys */ 0x1016cc1c, 0x825fb); /* call 0x1016cc1c */
    II(0x100ea621, 0x3)   mov(memd_a32(ss, ebp - 0x28), eax);   /* mov [ebp-0x28], eax */
    II(0x100ea624, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ea627, 0x3)   add(eax, memd_a32(ss, ebp + 0x10));   /* add eax, [ebp+0x10] */
    II(0x100ea62a, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100ea62d, 0x7)   mov(memd_a32(ss, ebp - 0x2c), 0);     /* mov dword [ebp-0x2c], 0x0 */
    II(0x100ea634, 0x2)   jmpd(0x100ea63c, 0x6);                /* jmp 0x100ea63c */
l_0x100ea636:
    II(0x100ea636, 0x3)   mov(eax, memd_a32(ss, ebp - 0x2c));   /* mov eax, [ebp-0x2c] */
    II(0x100ea639, 0x3)   inc(memd_a32(ss, ebp - 0x2c));        /* inc dword [ebp-0x2c] */
l_0x100ea63c:
    II(0x100ea63c, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x2c)); /* movsx eax, word [ebp-0x2c] */
    II(0x100ea640, 0x5)   cmp(eax, 0x100);                      /* cmp eax, 0x100 */
    II(0x100ea645, 0x6)   jged(0x100ea75b, 0x110);              /* jge dword 0x100ea75b */
    II(0x100ea64b, 0x3)   mov(al, memb_a32(ss, ebp - 0x2c));    /* mov al, [ebp-0x2c] */
    II(0x100ea64e, 0x3)   mov(memb_a32(ss, ebp - 0x14), al);    /* mov [ebp-0x14], al */
    II(0x100ea651, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x2c)); /* movsx eax, word [ebp-0x2c] */
    II(0x100ea655, 0x3)   lea(eax, eax + eax * 0x2);            /* lea eax, [eax+eax*2] */
    II(0x100ea658, 0x3)   add(eax, memd_a32(ss, ebp - 0x28));   /* add eax, [ebp-0x28] */
    II(0x100ea65b, 0x3)   movsx(edx, memb_a32(ds, eax));        /* movsx edx, byte [eax] */
    II(0x100ea65e, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x10)); /* movsx eax, word [ebp+0x10] */
    II(0x100ea662, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100ea665, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x10)); /* movsx ebx, word [ebp-0x10] */
    II(0x100ea669, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ea66d, 0x3)   imul(eax, ebx);                       /* imul eax, ebx */
    II(0x100ea670, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100ea672, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x18)); /* movsx ebx, word [ebp-0x18] */
    II(0x100ea676, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100ea678, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100ea67b, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x100ea67d, 0x3)   mov(memb_a32(ss, ebp - 0x30), al);    /* mov [ebp-0x30], al */
    II(0x100ea680, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x2c)); /* movsx eax, word [ebp-0x2c] */
    II(0x100ea684, 0x3)   lea(eax, eax + eax * 0x2);            /* lea eax, [eax+eax*2] */
    II(0x100ea687, 0x3)   mov(edx, memd_a32(ss, ebp - 0x28));   /* mov edx, [ebp-0x28] */
    II(0x100ea68a, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100ea68c, 0x4)   movsx(edx, memb_a32(ds, edx + 0x2));  /* movsx edx, byte [edx+0x2] */
    II(0x100ea690, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x10)); /* movsx eax, word [ebp+0x10] */
    II(0x100ea694, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100ea697, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x100ea699, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x100ea69d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ea6a1, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100ea6a4, 0x2)   add(edx, ebx);                        /* add edx, ebx */
    II(0x100ea6a6, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x18)); /* movsx ebx, word [ebp-0x18] */
    II(0x100ea6aa, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100ea6ac, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100ea6af, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x100ea6b1, 0x3)   mov(memb_a32(ss, ebp - 0x2e), al);    /* mov [ebp-0x2e], al */
    II(0x100ea6b4, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x2c)); /* movsx eax, word [ebp-0x2c] */
    II(0x100ea6b8, 0x3)   lea(eax, eax + eax * 0x2);            /* lea eax, [eax+eax*2] */
    II(0x100ea6bb, 0x3)   add(eax, memd_a32(ss, ebp - 0x28));   /* add eax, [ebp-0x28] */
    II(0x100ea6be, 0x4)   movsx(edx, memb_a32(ds, eax + 0x1));  /* movsx edx, byte [eax+0x1] */
    II(0x100ea6c2, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x10)); /* movsx eax, word [ebp+0x10] */
    II(0x100ea6c6, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100ea6c9, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x100ea6cd, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x100ea6d1, 0x3)   imul(eax, ebx);                       /* imul eax, ebx */
    II(0x100ea6d4, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100ea6d6, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x18)); /* movsx ebx, word [ebp-0x18] */
    II(0x100ea6da, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100ea6dc, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100ea6df, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x100ea6e1, 0x3)   mov(memb_a32(ss, ebp - 0x2f), al);    /* mov [ebp-0x2f], al */
    II(0x100ea6e4, 0x3)   lea(edx, ebp - 0x30);                 /* lea edx, [ebp-0x30] */
    II(0x100ea6e7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100ea6e9, 0x3)   mov(al, memb_a32(ss, ebp - 0x14));    /* mov al, [ebp-0x14] */
    II(0x100ea6ec, 0x3)   lea(eax, eax + eax * 0x2);            /* lea eax, [eax+eax*2] */
    II(0x100ea6ef, 0x3)   add(eax, memd_a32(ss, ebp - 0x28));   /* add eax, [ebp-0x28] */
    II(0x100ea6f2, 0x5)   calld(0x100e9fe3, -0x714);            /* call 0x100e9fe3 */
    II(0x100ea6f7, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x100ea6fa, 0x7)   mov(memd_a32(ss, ebp - 0x24), 0);     /* mov dword [ebp-0x24], 0x0 */
    II(0x100ea701, 0x2)   jmpd(0x100ea709, 0x6);                /* jmp 0x100ea709 */
l_0x100ea703:
    II(0x100ea703, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100ea706, 0x3)   inc(memd_a32(ss, ebp - 0x24));        /* inc dword [ebp-0x24] */
l_0x100ea709:
    II(0x100ea709, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x24)); /* movsx eax, word [ebp-0x24] */
    II(0x100ea70d, 0x5)   cmp(eax, 0x100);                      /* cmp eax, 0x100 */
    II(0x100ea712, 0x2)   jged(0x100ea71c, 0x8);                /* jge 0x100ea71c */
    II(0x100ea714, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x100ea718, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100ea71a, 0x2)   jgd(0x100ea71e, 0x2);                 /* jg 0x100ea71e */
l_0x100ea71c:
    II(0x100ea71c, 0x2)   jmpd(0x100ea74a, 0x2c);               /* jmp 0x100ea74a */
l_0x100ea71e:
    II(0x100ea71e, 0x3)   lea(edx, ebp - 0x30);                 /* lea edx, [ebp-0x30] */
    II(0x100ea721, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x24)); /* movsx eax, word [ebp-0x24] */
    II(0x100ea725, 0x3)   lea(eax, eax + eax * 0x2);            /* lea eax, [eax+eax*2] */
    II(0x100ea728, 0x3)   add(eax, memd_a32(ss, ebp - 0x28));   /* add eax, [ebp-0x28] */
    II(0x100ea72b, 0x5)   calld(0x100e9fe3, -0x74d);            /* call 0x100e9fe3 */
    II(0x100ea730, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
//    II(0x100ea733, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100ea736, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x1c));    /* cmp ax, [ebp-0x1c] */
    II(0x100ea73a, 0x2)   jged(0x100ea748, 0xc);                /* jge 0x100ea748 */
    II(0x100ea73c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100ea73f, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x100ea742, 0x3)   mov(al, memb_a32(ss, ebp - 0x24));    /* mov al, [ebp-0x24] */
    II(0x100ea745, 0x3)   mov(memb_a32(ss, ebp - 0x14), al);    /* mov [ebp-0x14], al */
l_0x100ea748:
    II(0x100ea748, 0x2)   jmpd(0x100ea703, -0x47);              /* jmp 0x100ea703 */
l_0x100ea74a:
    II(0x100ea74a, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x2c)); /* movsx edx, word [ebp-0x2c] */
    II(0x100ea74e, 0x3)   add(edx, memd_a32(ss, ebp + 0x14));   /* add edx, [ebp+0x14] */
    II(0x100ea751, 0x3)   mov(al, memb_a32(ss, ebp - 0x14));    /* mov al, [ebp-0x14] */
    II(0x100ea754, 0x2)   mov(memb_a32(ds, edx), al);           /* mov [edx], al */
    II(0x100ea756, 0x5)   jmpd(0x100ea636, -0x125);             /* jmp 0x100ea636 */
l_0x100ea75b:
    II(0x100ea75b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ea75d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ea75e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ea75f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ea760, 0x3)   retd(0x8);                            /* ret 0x8 */
FUNC_END

