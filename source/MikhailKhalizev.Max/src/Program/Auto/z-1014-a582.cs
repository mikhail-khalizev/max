using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_a582-999e4ee")]
        public void Method_1014_a582()
        {
            ii(0x1014_a582, 5); push(0x68);                             /* push 0x68 */
            ii(0x1014_a587, 5); call(Definitions.sys_check_available_stack_size, 0x1_b7c6); /* call 0x10165d52 */
            ii(0x1014_a58c, 1); push(ebx);                              /* push ebx */
            ii(0x1014_a58d, 1); push(ecx);                              /* push ecx */
            ii(0x1014_a58e, 1); push(esi);                              /* push esi */
            ii(0x1014_a58f, 1); push(edi);                              /* push edi */
            ii(0x1014_a590, 1); push(ebp);                              /* push ebp */
            ii(0x1014_a591, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_a593, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1014_a599, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_a59c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_a59f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a5a2, 4); test(memb[ds, eax + 21], 0x10);         /* test byte [eax+0x15], 0x10 */
            ii(0x1014_a5a6, 6); if(jz(0x1014_a862, 0x2b6)) goto l_0x1014_a862; /* jz 0x1014a862 */
            ii(0x1014_a5ac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_a5af, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_a5b2, 4); add(memw[ds, edx + 82], ax);            /* add [edx+0x52], ax */
            ii(0x1014_a5b6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_a5b9, 3); mov(edx, memd[ds, edx + 80]);           /* mov edx, [edx+0x50] */
            ii(0x1014_a5bc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a5bf, 3); cmp(edx, 0xf);                          /* cmp edx, 0xf */
            ii(0x1014_a5c2, 6); if(jl(0x1014_a862, 0x29a)) goto l_0x1014_a862; /* jl 0x1014a862 */
            ii(0x1014_a5c8, 3); lea(edi, memd[ss, ebp - 28]);           /* lea edi, [ebp-0x1c] */
            ii(0x1014_a5cb, 5); mov(esi, 0x101b_d8f4);                  /* mov esi, 0x101bd8f4 */
            ii(0x1014_a5d0, 1); movsd();                                /* movsd */
            ii(0x1014_a5d1, 1); movsb();                                /* movsb */
            ii(0x1014_a5d2, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x1014_a5d6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a5d9, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_a5dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a5df, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a5e2, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_a5e5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a5ea, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_a5f0, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1014_a5f6, 5); call(0x1008_b104, -0xb_f4f7);           /* call 0x1008b104 */
            ii(0x1014_a5fb, 3); lea(ebx, memd[ss, ebp - 32]);           /* lea ebx, [ebp-0x20] */
            ii(0x1014_a5fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_a600, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_a602, 5); call(0x1007_6800, -0xd_3e07);           /* call 0x10076800 */
            ii(0x1014_a607, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a60a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_a60d, 5); call(0x100c_b74c, -0x7_eec6);           /* call 0x100cb74c */
            ii(0x1014_a612, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_a614, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a617, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_a61a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a61d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a620, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_a623, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a628, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_a62e, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1014_a634, 5); call(0x100c_b63c, -0x7_effd);           /* call 0x100cb63c */
            ii(0x1014_a639, 5); call(/* sys */ 0x1016_5e9b, 0x1_b85d);  /* call 0x10165e9b */
            ii(0x1014_a63e, 3); lea(eax, memd[ds, eax + eax * 4]);      /* lea eax, [eax+eax*4] */
            ii(0x1014_a641, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1014_a644, 4); mov(al, memb[ds, eax + ebp - 28]);      /* mov al, [eax+ebp-0x1c] */
            ii(0x1014_a648, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1014_a64b, 4); movsx(ebx, memb[ss, ebp - 12]);         /* movsx ebx, byte [ebp-0xc] */
            ii(0x1014_a64f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a652, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_a655, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a658, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a65b, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_a65e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a660, 1); cwde();                                 /* cwde */
            ii(0x1014_a661, 5); call(0x100d_fdf9, -0x6_a86d);           /* call 0x100dfdf9 */
            ii(0x1014_a666, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
        l_0x1014_a669:
            ii(0x1014_a669, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1014_a66c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_a66f, 4); cmp(ax, memw[ds, edx + 82]);            /* cmp ax, [edx+0x52] */
            ii(0x1014_a673, 6); if(jg(0x1014_a743, 0xca)) goto l_0x1014_a743; /* jg 0x1014a743 */
            ii(0x1014_a679, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1014_a67c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_a67f, 4); sub(memw[ds, edx + 82], ax);            /* sub [edx+0x52], ax */
            ii(0x1014_a683, 4); cmp(memb[ss, ebp - 16], 0);             /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1014_a687, 2); if(jnz(0x1014_a6d6, 0x4d)) goto l_0x1014_a6d6; /* jnz 0x1014a6d6 */
            ii(0x1014_a689, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1014_a68e, 5); call(Definitions.sys_new, 0x1_b76d);    /* call 0x10165e00 */
            ii(0x1014_a693, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1014_a696, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1014_a699, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1014_a69c, 4); cmp(memd[ss, ebp - 40], 0);             /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1014_a6a0, 2); if(jz(0x1014_a6c2, 0x20)) goto l_0x1014_a6c2; /* jz 0x1014a6c2 */
            ii(0x1014_a6a2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a6a5, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_a6a8, 5); call(0x100c_b6f0, -0x7_efbd);           /* call 0x100cb6f0 */
            ii(0x1014_a6ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_a6af, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1014_a6b2, 5); call(0x100c_a2f8, -0x8_03bf);           /* call 0x100ca2f8 */
            ii(0x1014_a6b7, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1014_a6ba, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1014_a6bd, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1014_a6c0, 2); jmp(0x1014_a6c8, 6); goto l_0x1014_a6c8; /* jmp 0x1014a6c8 */
        l_0x1014_a6c2:
            ii(0x1014_a6c2, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1014_a6c5, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
        l_0x1014_a6c8:
            ii(0x1014_a6c8, 3); mov(edx, memd[ss, ebp - 48]);           /* mov edx, [ebp-0x30] */
            ii(0x1014_a6cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a6ce, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_a6d1, 5); call(0x100c_b77c, -0x7_ef5a);           /* call 0x100cb77c */
        l_0x1014_a6d6:
            ii(0x1014_a6d6, 4); movsx(edx, memb[ss, ebp - 12]);         /* movsx edx, byte [ebp-0xc] */
            ii(0x1014_a6da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a6dd, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_a6e0, 5); call(0x1007_6730, -0xd_3fb5);           /* call 0x10076730 */
            ii(0x1014_a6e5, 5); call(0x1016_3b41, 0x1_9457);            /* call 0x10163b41 */
            ii(0x1014_a6ea, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1014_a6ec, 4); movsx(ebx, memb[ss, ebp - 12]);         /* movsx ebx, byte [ebp-0xc] */
            ii(0x1014_a6f0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_a6f3, 3); mov(edx, memd[ds, edx + 6]);            /* mov edx, [edx+0x6] */
            ii(0x1014_a6f6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a6f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a6fc, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_a6ff, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a701, 1); cwde();                                 /* cwde */
            ii(0x1014_a702, 5); call(0x100d_fd69, -0x6_a99e);           /* call 0x100dfd69 */
            ii(0x1014_a707, 3); add(memw[ds, ecx], ax);                 /* add [ecx], ax */
            ii(0x1014_a70a, 5); call(/* sys */ 0x1016_5e9b, 0x1_b78c);  /* call 0x10165e9b */
            ii(0x1014_a70f, 3); lea(eax, memd[ds, eax + eax * 4]);      /* lea eax, [eax+eax*4] */
            ii(0x1014_a712, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1014_a715, 4); mov(al, memb[ds, eax + ebp - 28]);      /* mov al, [eax+ebp-0x1c] */
            ii(0x1014_a719, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1014_a71c, 4); movsx(ebx, memb[ss, ebp - 12]);         /* movsx ebx, byte [ebp-0xc] */
            ii(0x1014_a720, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x1014_a723, 3); mov(edx, memd[ds, ecx + 6]);            /* mov edx, [ecx+0x6] */
            ii(0x1014_a726, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a729, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a72c, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_a72f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a731, 1); cwde();                                 /* cwde */
            ii(0x1014_a732, 5); call(0x100d_fdf9, -0x6_a93e);           /* call 0x100dfdf9 */
            ii(0x1014_a737, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1014_a73a, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1014_a73e, 5); jmp(0x1014_a669, -0xda); goto l_0x1014_a669; /* jmp 0x1014a669 */
        l_0x1014_a743:
            ii(0x1014_a743, 4); cmp(memb[ss, ebp - 16], 0);             /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1014_a747, 6); if(jz(0x1014_a829, 0xdc)) goto l_0x1014_a829; /* jz 0x1014a829 */
            ii(0x1014_a74d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a750, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a752, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1014_a755, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_a757, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1014_a75c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_a75e, 2); if(jnz(0x1014_a7da, 0x7a)) goto l_0x1014_a7da; /* jnz 0x1014a7da */
            ii(0x1014_a760, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a763, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1014_a766, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_a769, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a76c, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1014_a76f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a772, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1014_a775, 5); call(0x1007_6aac, -0xd_3cce);           /* call 0x10076aac */
            ii(0x1014_a77a, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1014_a77c, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_a77f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a781, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a784, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x1014_a787, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_a78a, 1); inc(eax);                               /* inc eax */
            ii(0x1014_a78b, 1); push(eax);                              /* push eax */
            ii(0x1014_a78c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a78f, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1014_a792, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_a795, 1); inc(eax);                               /* inc eax */
            ii(0x1014_a796, 1); push(eax);                              /* push eax */
            ii(0x1014_a797, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a79a, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1014_a79d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_a7a0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_a7a3, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1014_a7a9, 5); mov(eax, StringDefinitions.SAtIIHasIncreasedInExperience); /* mov eax, 0x101ad296 */
            ii(0x1014_a7ae, 1); push(eax);                              /* push eax */
            ii(0x1014_a7af, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1014_a7b4, 1); push(eax);                              /* push eax */
            ii(0x1014_a7b5, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_a7b8, 5); call(Definitions.my_string_ctor, -0x8cd5); /* call 0x10141ae8 */
            ii(0x1014_a7bd, 1); push(eax);                              /* push eax */
            ii(0x1014_a7be, 5); call(0x1014_2037, -0x878c);             /* call 0x10142037 */
            ii(0x1014_a7c3, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1014_a7c6, 5); call(Definitions.my_strobj_c_str_v2, -0xc_1003); /* call 0x100897c8 */
            ii(0x1014_a7cb, 5); call(0x1011_5b60, -0x3_4c70);           /* call 0x10115b60 */
            ii(0x1014_a7d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a7d2, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_a7d5, 5); call(Definitions.my_string_dtor, -0x8cb0); /* call 0x10141b2a */
        l_0x1014_a7da:
            ii(0x1014_a7da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a7dd, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_a7e0, 5); call(0x1007_6730, -0xd_40b5);           /* call 0x10076730 */
            ii(0x1014_a7e5, 5); call(0x100c_b7e4, -0x7_f006);           /* call 0x100cb7e4 */
            ii(0x1014_a7ea, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_a7ef, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a7f2, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_a7f5, 5); call(0x1007_6730, -0xd_40ca);           /* call 0x10076730 */
            ii(0x1014_a7fa, 5); call(0x100c_b7b4, -0x7_f04b);           /* call 0x100cb7b4 */
            ii(0x1014_a7ff, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1014_a806, 2); if(jz(0x1014_a810, 8)) goto l_0x1014_a810; /* jz 0x1014a810 */
            ii(0x1014_a808, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a80b, 5); call(0x1012_8bb2, -0x2_1c5e);           /* call 0x10128bb2 */
        l_0x1014_a810:
            ii(0x1014_a810, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_a815, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a818, 5); call(0x1007_6d98, -0xd_3a85);           /* call 0x10076d98 */
            ii(0x1014_a81d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_a81f, 2); if(jz(0x1014_a829, 8)) goto l_0x1014_a829; /* jz 0x1014a829 */
            ii(0x1014_a821, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a824, 5); call(0x100f_f637, -0x4_b1f2);           /* call 0x100ff637 */
        l_0x1014_a829:
            ii(0x1014_a829, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_a82c, 5); call(0x100c_b74c, -0x7_f0e5);           /* call 0x100cb74c */
            ii(0x1014_a831, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_a833, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a836, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_a839, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_a83c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_a83f, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_a842, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_a847, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_a84d, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1014_a853, 5); call(0x100c_b63c, -0x7_f21c);           /* call 0x100cb63c */
            ii(0x1014_a858, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a85a, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_a85d, 5); call(0x1007_5eec, -0xd_4976);           /* call 0x10075eec */
        l_0x1014_a862:
            ii(0x1014_a862, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_a864, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_a865, 1); pop(edi);                               /* pop edi */
            ii(0x1014_a866, 1); pop(esi);                               /* pop esi */
            ii(0x1014_a867, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_a868, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_a869, 1); ret();                                  /* ret */
        }
    }
}
