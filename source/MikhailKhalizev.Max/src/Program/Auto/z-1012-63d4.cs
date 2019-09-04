using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_63d4-102bfed")]
        public void Method_1012_63d4()
        {
            ii(0x1012_63d4, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1012_63d9, 5); call(Definitions.sys_check_available_stack_size, 0x3_f974); /* call 0x10165d52 */
            ii(0x1012_63de, 1); push(ebx);                              /* push ebx */
            ii(0x1012_63df, 1); push(ecx);                              /* push ecx */
            ii(0x1012_63e0, 1); push(edx);                              /* push edx */
            ii(0x1012_63e1, 1); push(esi);                              /* push esi */
            ii(0x1012_63e2, 1); push(edi);                              /* push edi */
            ii(0x1012_63e3, 1); push(ebp);                              /* push ebp */
            ii(0x1012_63e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_63e6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_63ec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_63ee, 5); call(0x100e_883d, -0x3_dbb6);           /* call 0x100e883d */
            ii(0x1012_63f3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_63f6, 10); mov(memd[ds, 0x101c_5628], 0);         /* mov dword [0x101c5628], 0x0 */
            ii(0x1012_6400, 7); mov(memb[ds, 0x101c_5631], 0);          /* mov byte [0x101c5631], 0x0 */
            ii(0x1012_6407, 7); mov(memb[ds, 0x101c_59b9], 0);          /* mov byte [0x101c59b9], 0x0 */
            ii(0x1012_640e, 7); mov(memb[ds, 0x101c_59ba], 0);          /* mov byte [0x101c59ba], 0x0 */
            ii(0x1012_6415, 7); mov(memb[ds, 0x101c_59bb], 0);          /* mov byte [0x101c59bb], 0x0 */
            ii(0x1012_641c, 7); mov(memb[ds, 0x101c_37da], 0);          /* mov byte [0x101c37da], 0x0 */
            ii(0x1012_6423, 7); mov(memb[ds, 0x101c_59bc], 0);          /* mov byte [0x101c59bc], 0x0 */
            ii(0x1012_642a, 7); mov(memb[ds, 0x101c_59c4], 1);          /* mov byte [0x101c59c4], 0x1 */
            ii(0x1012_6431, 7); mov(memb[ds, 0x101c_59c5], 0);          /* mov byte [0x101c59c5], 0x0 */
            ii(0x1012_6438, 7); mov(memb[ds, 0x101c_59b8], 0);          /* mov byte [0x101c59b8], 0x0 */
            ii(0x1012_643f, 7); mov(memb[ds, 0x101c_5630], 0);          /* mov byte [0x101c5630], 0x0 */
            ii(0x1012_6446, 7); mov(memb[ds, 0x101c_59c9], 1);          /* mov byte [0x101c59c9], 0x1 */
            ii(0x1012_644d, 7); mov(memb[ds, 0x101c_609e], 0);          /* mov byte [0x101c609e], 0x0 */
            ii(0x1012_6454, 7); mov(memd[ss, ebp - 4], 4);              /* mov dword [ebp-0x4], 0x4 */
        l_0x1012_645b:
            ii(0x1012_645b, 3); dec(memd[ss, ebp - 4]);                 /* dec dword [ebp-0x4] */
            ii(0x1012_645e, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x1012_6463, 2); if(jz(0x1012_64c6, 0x61)) goto l_0x1012_64c6; /* jz 0x101264c6 */
            ii(0x1012_6465, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6469, 7); mov(memb[ds, eax + 0x101c_59c0], 0);    /* mov byte [eax+0x101c59c0], 0x0 */
            ii(0x1012_6470, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6474, 7); mov(memb[ds, eax + 0x101c_59d0], 0);    /* mov byte [eax+0x101c59d0], 0x0 */
            ii(0x1012_647b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_647f, 7); mov(memb[ds, eax + 0x101c_59d4], 0);    /* mov byte [eax+0x101c59d4], 0x0 */
            ii(0x1012_6486, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_648a, 7); mov(memb[ds, eax + 0x101c_59d8], 0);    /* mov byte [eax+0x101c59d8], 0x0 */
            ii(0x1012_6491, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6495, 7); mov(memb[ds, eax + 0x101c_59dc], 0);    /* mov byte [eax+0x101c59dc], 0x0 */
            ii(0x1012_649c, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_64a0, 7); mov(memb[ds, eax + 0x101c_59e0], 0);    /* mov byte [eax+0x101c59e0], 0x0 */
            ii(0x1012_64a7, 5); mov(ebx, 6);                            /* mov ebx, 0x6 */
            ii(0x1012_64ac, 5); mov(edx, 0xff);                         /* mov edx, 0xff */
            ii(0x1012_64b1, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_64b5, 3); imul(ecx, eax, 6);                      /* imul ecx, eax, 0x6 */
            ii(0x1012_64b8, 5); mov(eax, 0x101c_4090);                  /* mov eax, 0x101c4090 */
            ii(0x1012_64bd, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_64bf, 5); call(Definitions.sys_memset, 0x3_f91c); /* call 0x10165de0 */
            ii(0x1012_64c4, 2); jmp(0x1012_645b, -0x6b); goto l_0x1012_645b; /* jmp 0x1012645b */
        l_0x1012_64c6:
            ii(0x1012_64c6, 9); mov(memw[ds, 0x101c_40d0], 0x913f);     /* mov word [0x101c40d0], 0x913f */
            ii(0x1012_64cf, 7); mov(memd[ss, ebp - 4], 0x20);           /* mov dword [ebp-0x4], 0x20 */
        l_0x1012_64d6:
            ii(0x1012_64d6, 3); dec(memd[ss, ebp - 4]);                 /* dec dword [ebp-0x4] */
            ii(0x1012_64d9, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x1012_64de, 6); if(jz(0x1012_66a6, 0x1c2)) goto l_0x1012_66a6; /* jz 0x101266a6 */
            ii(0x1012_64e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_64e7, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_64ea, 5); jmp(0x1012_6680, 0x191); goto l_0x1012_6680; /* jmp 0x10126680 */
        l_0x1012_64ef:
            ii(0x1012_64ef, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_64f3, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_64f6, 10); mov(memd[ds, eax + 0x101c_60a0], 0x1012_5d66); /* mov dword [eax+0x101c60a0], 0x10125d66 */
            ii(0x1012_6500, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6504, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_6507, 10); mov(memd[ds, eax + 0x101c_60a4], 0x1012_5dd6); /* mov dword [eax+0x101c60a4], 0x10125dd6 */
            ii(0x1012_6511, 5); jmp(0x1012_66a1, 0x18b); goto l_0x1012_66a1; /* jmp 0x101266a1 */
        l_0x1012_6516:
            ii(0x1012_6516, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_651a, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_651d, 10); mov(memd[ds, eax + 0x101c_60a0], 0x1012_5e4e); /* mov dword [eax+0x101c60a0], 0x10125e4e */
            ii(0x1012_6527, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_652b, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_652e, 10); mov(memd[ds, eax + 0x101c_60a4], 0x1012_5ebb); /* mov dword [eax+0x101c60a4], 0x10125ebb */
            ii(0x1012_6538, 5); jmp(0x1012_66a1, 0x164); goto l_0x1012_66a1; /* jmp 0x101266a1 */
        l_0x1012_653d:
            ii(0x1012_653d, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6541, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_6544, 10); mov(memd[ds, eax + 0x101c_60a0], 0x1012_5f31); /* mov dword [eax+0x101c60a0], 0x10125f31 */
            ii(0x1012_654e, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6552, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_6555, 10); mov(memd[ds, eax + 0x101c_60a4], 0x1012_5fba); /* mov dword [eax+0x101c60a4], 0x10125fba */
            ii(0x1012_655f, 5); jmp(0x1012_66a1, 0x13d); goto l_0x1012_66a1; /* jmp 0x101266a1 */
        l_0x1012_6564:
            ii(0x1012_6564, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6568, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_656b, 10); mov(memd[ds, eax + 0x101c_60a0], 0x1012_604c); /* mov dword [eax+0x101c60a0], 0x1012604c */
            ii(0x1012_6575, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6579, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_657c, 10); mov(memd[ds, eax + 0x101c_60a4], 0x1012_612d); /* mov dword [eax+0x101c60a4], 0x1012612d */
            ii(0x1012_6586, 5); jmp(0x1012_66a1, 0x116); goto l_0x1012_66a1; /* jmp 0x101266a1 */
        l_0x1012_658b:
            ii(0x1012_658b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_658f, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_6592, 10); mov(memd[ds, eax + 0x101c_60a0], 0x1012_6202); /* mov dword [eax+0x101c60a0], 0x10126202 */
            ii(0x1012_659c, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_65a0, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1012_65a3, 10); mov(memd[ds, eax + 0x101c_60a4], 0x1012_6272); /* mov dword [eax+0x101c60a4], 0x10126272 */
            ii(0x1012_65ad, 5); jmp(0x1012_66a1, 0xef); goto l_0x1012_66a1; /* jmp 0x101266a1 */
        l_0x1012_65b2:
            ii(0x1012_65b2, 5); mov(edx, StringDefinitions.PacketLengthArrayOutOfSync); /* mov edx, 0x101a8196 */
            ii(0x1012_65b7, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_65bc, 5); call(Definitions.sys_strcpy, 0x3_f90e); /* call 0x10165ecf */
            ii(0x1012_65c1, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_65c6, 1); push(eax);                              /* push eax */
            ii(0x1012_65c7, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1012_65cc, 1); push(eax);                              /* push eax */
            ii(0x1012_65cd, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_65d2, 1); push(eax);                              /* push eax */
            ii(0x1012_65d3, 5); push(0x1ae);                            /* push 0x1ae */
            ii(0x1012_65d8, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1012_65dd, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1012_65e2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_65e5, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x1012_65e8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_65eb, 5); call(0x1011_60dc, -0x1_0514);           /* call 0x101160dc */
        l_0x1012_65f0:
            ii(0x1012_65f0, 5); call(/* sys */ 0x1016_b208, 0x4_4c13);  /* call 0x1016b208 */
            ii(0x1012_65f5, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_65f8, 2); if(jnz(0x1012_65f0, -0xa)) goto l_0x1012_65f0; /* jnz 0x101265f0 */
            ii(0x1012_65fa, 5); jmp(0x1012_66a1, 0xa2); goto l_0x1012_66a1; /* jmp 0x101266a1 */
        //  ii(0x1012_65ff, 1); nop();                                  /* nop */
        //  ii(0x1012_6600, 128); /* Служебная область с абсолютными адресами переходов. (0x1012_64ef, 0x1012_6564, 0x1012_653d, 0x1012_653d, 0x1012_6564, 0x1012_653d, 0x1012_658b, 0x1012_64ef, 0x1012_64ef, 0x1012_64ef, 0x1012_6516, 0x1012_6564, 0x1012_64ef, 0x1012_64ef, 0x1012_64ef, 0x1012_64ef, 0x1012_64ef, 0x1012_6516, 0x1012_6516, 0x1012_6516, 0x1012_653d, 0x1012_64ef, 0x1012_64ef, 0x1012_64ef, 0x1012_653d, 0x1012_653d, 0x1012_6564, 0x1012_653d, 0x1012_6516, 0x1012_64ef, 0x1012_653d, 0x1012_64ef). */
        l_0x1012_6680:
            ii(0x1012_6680, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_6683, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_6686, 5); cmp(memw[ss, ebp - 16], 0x1f);          /* cmp word [ebp-0x10], 0x1f */
            ii(0x1012_668b, 6); if(ja(0x1012_65b2, -0xdf)) goto l_0x1012_65b2; /* ja 0x101265b2 */
            ii(0x1012_6691, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_6693, 4); mov(ax, memw[ss, ebp - 16]);            /* mov ax, [ebp-0x10] */
            ii(0x1012_6697, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1012_669a, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1012_6600]))
            {
                case 0x1012_64ef:
                    goto l_0x1012_64ef;
                case 0x1012_6516:
                    goto l_0x1012_6516;
                case 0x1012_653d:
                    goto l_0x1012_653d;
                case 0x1012_6564:
                    goto l_0x1012_6564;
                case 0x1012_658b:
                    goto l_0x1012_658b;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x10126600] */
        l_0x1012_66a1:
            ii(0x1012_66a1, 5); jmp(0x1012_64d6, -0x1d0); goto l_0x1012_64d6; /* jmp 0x101264d6 */
        l_0x1012_66a6:
            ii(0x1012_66a6, 9); mov(memw[ds, 0x101c_609a], 0x28);       /* mov word [0x101c609a], 0x28 */
            ii(0x1012_66af, 9); mov(memw[ds, 0x101c_609c], 0x17);       /* mov word [0x101c609c], 0x17 */
            ii(0x1012_66b8, 5); mov(eax, memd[ds, 0x101c_6098]);        /* mov eax, [0x101c6098] */
            ii(0x1012_66bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_66c0, 5); cmp(eax, 0x226);                        /* cmp eax, 0x226 */
            ii(0x1012_66c5, 2); if(jg(0x1012_66d6, 0xf)) goto l_0x1012_66d6; /* jg 0x101266d6 */
            ii(0x1012_66c7, 5); mov(eax, memd[ds, 0x101c_609a]);        /* mov eax, [0x101c609a] */
            ii(0x1012_66cc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_66cf, 5); cmp(eax, 0x226);                        /* cmp eax, 0x226 */
            ii(0x1012_66d4, 2); if(jle(0x1012_671e, 0x48)) goto l_0x1012_671e; /* jle 0x1012671e */
        l_0x1012_66d6:
            ii(0x1012_66d6, 5); mov(edx, StringDefinitions.MaxPacketLengthExceeded); /* mov edx, 0x101a81b6 */
            ii(0x1012_66db, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_66e0, 5); call(Definitions.sys_strcpy, 0x3_f7ea); /* call 0x10165ecf */
            ii(0x1012_66e5, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_66ea, 1); push(eax);                              /* push eax */
            ii(0x1012_66eb, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1012_66f0, 1); push(eax);                              /* push eax */
            ii(0x1012_66f1, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_66f6, 1); push(eax);                              /* push eax */
            ii(0x1012_66f7, 5); push(0x1ae);                            /* push 0x1ae */
            ii(0x1012_66fc, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1012_6701, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1012_6706, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6709, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x1012_670c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_670f, 5); call(0x1011_60dc, -0x1_0638);           /* call 0x101160dc */
        l_0x1012_6714:
            ii(0x1012_6714, 5); call(/* sys */ 0x1016_b208, 0x4_4aef);  /* call 0x1016b208 */
            ii(0x1012_6719, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_671c, 2); if(jnz(0x1012_6714, -0xa)) goto l_0x1012_6714; /* jnz 0x10126714 */
        l_0x1012_671e:
            ii(0x1012_671e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6720, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_6721, 1); pop(edi);                               /* pop edi */
            ii(0x1012_6722, 1); pop(esi);                               /* pop esi */
            ii(0x1012_6723, 1); pop(edx);                               /* pop edx */
            ii(0x1012_6724, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_6725, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_6726, 1); ret();                                  /* ret */
        }
    }
}
