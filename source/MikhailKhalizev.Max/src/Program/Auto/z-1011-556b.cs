using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_556b-9239a99f")]
        public void Method_1011_556b()
        {
            ii(0x1011_556b, 5); push(0xac);                             /* push 0xac */
            ii(0x1011_5570, 5); call(Definitions.sys_check_available_stack_size, 0x5_07dd); /* call 0x10165d52 */
            ii(0x1011_5575, 1); push(ebx);                              /* push ebx */
            ii(0x1011_5576, 1); push(ecx);                              /* push ecx */
            ii(0x1011_5577, 1); push(esi);                              /* push esi */
            ii(0x1011_5578, 1); push(edi);                              /* push edi */
            ii(0x1011_5579, 1); push(ebp);                              /* push ebp */
            ii(0x1011_557a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_557c, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x1011_5582, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_5585, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1011_5588, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1011_558d, 5); call(0x1013_d111, 0x2_7b7f);            /* call 0x1013d111 */
            ii(0x1011_5592, 5); call(0x100e_88bd, -0x2_ccda);           /* call 0x100e88bd */
            ii(0x1011_5597, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_559b, 5); call(Definitions.my_get_res_data_by_id_malloc, 0x1_ec4b); /* call 0x101341eb */
            ii(0x1011_55a0, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_55a3, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_55a7, 2); if(jnz(0x1011_55b2, 0x9)) goto l_0x1011_55b2; /* jnz 0x101155b2 */
            ii(0x1011_55a9, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_55ad, 5); jmp(0x1011_57c9, 0x217); goto l_0x1011_57c9; /* jmp 0x101157c9 */
        l_0x1011_55b2:
            ii(0x1011_55b2, 4); mov(memb[ss, ebp - 0x78], 0);           /* mov byte [ebp-0x78], 0x0 */
            ii(0x1011_55b6, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_55ba, 2); if(jz(0x1011_55c9, 0xd)) goto l_0x1011_55c9; /* jz 0x101155c9 */
            ii(0x1011_55bc, 5); mov(edx, 0x101c_3e9c);                  /* mov edx, 0x101c3e9c */
            ii(0x1011_55c1, 3); lea(eax, memd[ss, ebp - 0x78]);         /* lea eax, [ebp-0x78] */
            ii(0x1011_55c4, 5); call(Definitions.sys_strcpy, 0x5_0906); /* call 0x10165ecf */
        l_0x1011_55c9:
            ii(0x1011_55c9, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_55cc, 3); lea(eax, memd[ss, ebp - 0x78]);         /* lea eax, [ebp-0x78] */
            ii(0x1011_55cf, 5); call(Definitions.sys_strcat, 0x5_095d); /* call 0x10165f31 */
            ii(0x1011_55d4, 3); lea(ebx, memd[ss, ebp - 0x7c]);         /* lea ebx, [ebp-0x7c] */
            ii(0x1011_55d7, 5); mov(edx, 0x200);                        /* mov edx, 0x200 */
            ii(0x1011_55dc, 3); lea(eax, memd[ss, ebp - 0x78]);         /* lea eax, [ebp-0x78] */
            ii(0x1011_55df, 5); call(/* sys */ 0x1017_9465, 0x6_3e81);  /* call 0x10179465 */
            ii(0x1011_55e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_55e6, 2); if(jz(0x1011_55f1, 0x9)) goto l_0x1011_55f1; /* jz 0x101155f1 */
            ii(0x1011_55e8, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1011_55ec, 5); jmp(0x1011_5797, 0x1a6); goto l_0x1011_5797; /* jmp 0x10115797 */
        l_0x1011_55f1:
            ii(0x1011_55f1, 7); mov(memd[ss, ebp - 0x80], 0x101b_dec0); /* mov dword [ebp-0x80], 0x101bdec0 */
            ii(0x1011_55f8, 5); call(/* sys */ 0x1016_cc1c, 0x5_761f);  /* call 0x1016cc1c */
            ii(0x1011_55fd, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x1011_5603, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5605, 5); call(0x1012_0d94, 0xb78a);              /* call 0x10120d94 */
            ii(0x1011_560a, 5); call(/* sys */ 0x1016_bcc4, 0x5_66b5);  /* call 0x1016bcc4 */
            ii(0x1011_560f, 10); mov(memd[ds, 0x101c_4e58], 0);         /* mov dword [0x101c4e58], 0x0 */
            ii(0x1011_5619, 5); mov(eax, 0x1011_53e3);                  /* mov eax, 0x101153e3 */
            ii(0x1011_561e, 1); push(eax);                              /* push eax */
            ii(0x1011_561f, 5); mov(eax, 0x1011_53b8);                  /* mov eax, 0x101153b8 */
            ii(0x1011_5624, 1); push(eax);                              /* push eax */
            ii(0x1011_5625, 5); call(/* sys */ 0x1017_94c0, 0x6_3e96);  /* call 0x101794c0 */
            ii(0x1011_562a, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1011_562d, 5); mov(eax, 0x1011_5406);                  /* mov eax, 0x10115406 */
            ii(0x1011_5632, 1); push(eax);                              /* push eax */
            ii(0x1011_5633, 5); call(/* sys */ 0x1017_98a0, 0x6_4268);  /* call 0x101798a0 */
            ii(0x1011_5638, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_563b, 5); mov(eax, 0x1011_5461);                  /* mov eax, 0x10115461 */
            ii(0x1011_5640, 1); push(eax);                              /* push eax */
            ii(0x1011_5641, 5); call(/* sys */ 0x1017_b840, 0x6_61fa);  /* call 0x1017b840 */
            ii(0x1011_5646, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_5649, 2); push(0x3);                              /* push 0x3 */
            ii(0x1011_564b, 5); call(/* sys */ 0x1017_b860, 0x6_6210);  /* call 0x1017b860 */
            ii(0x1011_5650, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_5653, 5); mov(eax, 0x36);                         /* mov eax, 0x36 */
            ii(0x1011_5658, 5); call(0x1007_5fdc, -0x9_f681);           /* call 0x10075fdc */
            ii(0x1011_565d, 6); imul(edx, eax, 0x7fff);                 /* imul edx, eax, 0x7fff */
            ii(0x1011_5663, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1011_5668, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_566a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_566d, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_566f, 5); mov(memd[ds, 0x101c_4e60], eax);        /* mov [0x101c4e60], eax */
            ii(0x1011_5674, 5); mov(eax, 0x39);                         /* mov eax, 0x39 */
            ii(0x1011_5679, 5); call(0x1007_5fdc, -0x9_f6a2);           /* call 0x10075fdc */
            ii(0x1011_567e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_5680, 2); if(jz(0x1011_568c, 0xa)) goto l_0x1011_568c; /* jz 0x1011568c */
            ii(0x1011_5682, 10); mov(memd[ds, 0x101c_4e60], 0);         /* mov dword [0x101c4e60], 0x0 */
        l_0x1011_568c:
            ii(0x1011_568c, 6); push(memd[ds, 0x101c_4e60]);            /* push dword [0x101c4e60] */
            ii(0x1011_5692, 5); call(/* sys */ 0x1017_9c70, 0x6_45d9);  /* call 0x10179c70 */
            ii(0x1011_5697, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_569a, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1011_569f, 5); call(0x1007_5fdc, -0x9_f6c8);           /* call 0x10075fdc */
            ii(0x1011_56a4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_56a6, 2); if(jz(0x1011_56b2, 0xa)) goto l_0x1011_56b2; /* jz 0x101156b2 */
            ii(0x1011_56a8, 2); push(0x1);                              /* push 0x1 */
            ii(0x1011_56aa, 5); call(/* sys */ 0x1017_b850, 0x6_61a1);  /* call 0x1017b850 */
            ii(0x1011_56af, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1011_56b2:
            ii(0x1011_56b2, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_56b6, 6); if(jz(0x1011_5732, 0x76)) goto l_0x1011_5732; /* jz 0x10115732 */
            ii(0x1011_56bc, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1011_56c1, 5); call(0x1007_5fdc, -0x9_f6ea);           /* call 0x10075fdc */
            ii(0x1011_56c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_56c8, 2); if(jz(0x1011_56fe, 0x34)) goto l_0x1011_56fe; /* jz 0x101156fe */
            ii(0x1011_56ca, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1011_56cf, 5); call(0x1007_5fdc, -0x9_f6f8);           /* call 0x10075fdc */
            ii(0x1011_56d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_56d6, 2); if(jz(0x1011_56eb, 0x13)) goto l_0x1011_56eb; /* jz 0x101156eb */
            ii(0x1011_56d8, 5); mov(eax, 0xffff_8101);                  /* mov eax, 0xffff8101 */
            ii(0x1011_56dd, 1); push(eax);                              /* push eax */
            ii(0x1011_56de, 5); call(/* sys */ 0x1017_b570, 0x6_5e8d);  /* call 0x1017b570 */
            ii(0x1011_56e3, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_56e6, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1011_56e9, 2); jmp(0x1011_56fc, 0x11); goto l_0x1011_56fc; /* jmp 0x101156fc */
        l_0x1011_56eb:
            ii(0x1011_56eb, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1011_56f0, 1); push(eax);                              /* push eax */
            ii(0x1011_56f1, 5); call(/* sys */ 0x1017_b570, 0x6_5e7a);  /* call 0x1017b570 */
            ii(0x1011_56f6, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_56f9, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
        l_0x1011_56fc:
            ii(0x1011_56fc, 2); jmp(0x1011_5730, 0x32); goto l_0x1011_5730; /* jmp 0x10115730 */
        l_0x1011_56fe:
            ii(0x1011_56fe, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1011_5703, 5); call(0x1007_5fdc, -0x9_f72c);           /* call 0x10075fdc */
            ii(0x1011_5708, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_570a, 2); if(jz(0x1011_571f, 0x13)) goto l_0x1011_571f; /* jz 0x1011571f */
            ii(0x1011_570c, 5); mov(eax, 0xffff_8f00);                  /* mov eax, 0xffff8f00 */
            ii(0x1011_5711, 1); push(eax);                              /* push eax */
            ii(0x1011_5712, 5); call(/* sys */ 0x1017_b570, 0x6_5e59);  /* call 0x1017b570 */
            ii(0x1011_5717, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_571a, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1011_571d, 2); jmp(0x1011_5730, 0x11); goto l_0x1011_5730; /* jmp 0x10115730 */
        l_0x1011_571f:
            ii(0x1011_571f, 5); mov(eax, 0xf00);                        /* mov eax, 0xf00 */
            ii(0x1011_5724, 1); push(eax);                              /* push eax */
            ii(0x1011_5725, 5); call(/* sys */ 0x1017_b570, 0x6_5e46);  /* call 0x1017b570 */
            ii(0x1011_572a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_572d, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
        l_0x1011_5730:
            ii(0x1011_5730, 2); jmp(0x1011_5743, 0x11); goto l_0x1011_5743; /* jmp 0x10115743 */
        l_0x1011_5732:
            ii(0x1011_5732, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1011_5737, 1); push(eax);                              /* push eax */
            ii(0x1011_5738, 5); call(/* sys */ 0x1017_b570, 0x6_5e33);  /* call 0x1017b570 */
            ii(0x1011_573d, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1011_5740, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
        l_0x1011_5743:
            ii(0x1011_5743, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1011_5747, 2); if(jz(0x1011_576b, 0x22)) goto l_0x1011_576b; /* jz 0x1011576b */
            ii(0x1011_5749, 2); push(0);                                /* push 0x0 */
            ii(0x1011_574b, 2); push(-0x1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1011_574d, 2); push(-0x1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1011_574f, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x1011_5752, 1); push(eax);                              /* push eax */
            ii(0x1011_5753, 5); call(/* sys */ 0x1017_c1d0, 0x6_6a78);  /* call 0x1017c1d0 */
            ii(0x1011_5758, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1011_575b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_575d, 2); if(jz(0x1011_5765, 0x6)) goto l_0x1011_5765; /* jz 0x10115765 */
            ii(0x1011_575f, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_5763, 2); jmp(0x1011_5769, 0x4); goto l_0x1011_5769; /* jmp 0x10115769 */
        l_0x1011_5765:
            ii(0x1011_5765, 4); mov(memb[ss, ebp - 0x10], 0x3);         /* mov byte [ebp-0x10], 0x3 */
        l_0x1011_5769:
            ii(0x1011_5769, 2); jmp(0x1011_576f, 0x4); goto l_0x1011_576f; /* jmp 0x1011576f */
        l_0x1011_576b:
            ii(0x1011_576b, 4); mov(memb[ss, ebp - 0x10], 0x2);         /* mov byte [ebp-0x10], 0x2 */
        l_0x1011_576f:
            ii(0x1011_576f, 5); call(/* sys */ 0x1017_c2d0, 0x6_6b5c);  /* call 0x1017c2d0 */
            ii(0x1011_5774, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x1011_5779, 6); mov(edx, memd[ss, ebp - 0x84]);         /* mov edx, [ebp-0x84] */
            ii(0x1011_577f, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1011_5782, 5); call(Definitions.sys_memcpy, 0x5_06c4); /* call 0x10165e4b */
            ii(0x1011_5787, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1011_578a, 5); call(/* sys */ 0x1016_d2cc, 0x5_7b3d);  /* call 0x1016d2cc */
            ii(0x1011_578f, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x1011_5792, 5); call(/* sys */ 0x1017_9446, 0x6_3caf);  /* call 0x10179446 */
        l_0x1011_5797:
            ii(0x1011_5797, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1011_579b, 2); if(jz(0x1011_57a3, 0x6)) goto l_0x1011_57a3; /* jz 0x101157a3 */
            ii(0x1011_579d, 4); cmp(memb[ss, ebp - 0x10], 0x3);         /* cmp byte [ebp-0x10], 0x3 */
            ii(0x1011_57a1, 2); if(jnz(0x1011_57b6, 0x13)) goto l_0x1011_57b6; /* jnz 0x101157b6 */
        l_0x1011_57a3:
            ii(0x1011_57a3, 5); mov(eax, /* sys */ 0x1017_14e0);        /* mov eax, 0x101714e0 */
            ii(0x1011_57a8, 5); call(/* sys */ 0x1016_64fc, 0x5_0d4f);  /* call 0x101664fc */
            ii(0x1011_57ad, 5); call(0x100e_88bd, -0x2_cef5);           /* call 0x100e88bd */
            ii(0x1011_57b2, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1011_57b6:
            ii(0x1011_57b6, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_57b9, 5); call(Definitions.sys_delete, 0x5_07a6); /* call 0x10165f64 */
            ii(0x1011_57be, 5); call(0x1014_837e, 0x3_2bbb);            /* call 0x1014837e */
            ii(0x1011_57c3, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1011_57c6, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x1011_57c9:
            ii(0x1011_57c9, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1011_57cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_57ce, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_57cf, 1); pop(edi);                               /* pop edi */
            ii(0x1011_57d0, 1); pop(esi);                               /* pop esi */
            ii(0x1011_57d1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_57d2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_57d3, 1); ret();                                  /* ret */
        }
    }
}
