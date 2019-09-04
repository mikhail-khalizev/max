using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_f018-db91e7e0")]
        public void Method_100a_f018()
        {
            ii(0x100a_f018, 5); push(0x40);                             /* push 0x40 */
            ii(0x100a_f01d, 5); call(Definitions.sys_check_available_stack_size, 0xb_6d30); /* call 0x10165d52 */
            ii(0x100a_f022, 1); push(ebx);                              /* push ebx */
            ii(0x100a_f023, 1); push(ecx);                              /* push ecx */
            ii(0x100a_f024, 1); push(edx);                              /* push edx */
            ii(0x100a_f025, 1); push(esi);                              /* push esi */
            ii(0x100a_f026, 1); push(edi);                              /* push edi */
            ii(0x100a_f027, 1); push(ebp);                              /* push ebp */
            ii(0x100a_f028, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_f02a, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_f030, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_f033, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_f03a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f03d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f040, 5); call(0x1007_6574, -0x3_8ad1);           /* call 0x10076574 */
            ii(0x100a_f045, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f047, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_f049, 3); mov(al, memb[ds, edx + 77]);            /* mov al, [edx+0x4d] */
            ii(0x100a_f04c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_f04f, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100a_f056, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_f059, 4); cmp(memb[ds, edx + 25], 0);             /* cmp byte [edx+0x19], 0x0 */
            ii(0x100a_f05d, 2); if(jle(0x100a_f098, 0x39)) goto l_0x100a_f098; /* jle 0x100af098 */
            ii(0x100a_f05f, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100a_f064, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f067, 3); mov(ebx, memd[ds, eax + 22]);           /* mov ebx, [eax+0x16] */
            ii(0x100a_f06a, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x100a_f06d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f070, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f073, 5); call(0x1007_65d0, -0x3_8aa8);           /* call 0x100765d0 */
            ii(0x100a_f078, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f07a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f07d, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100a_f080, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_f083, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x100a_f089, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_f08e, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_f090, 5); call(0x100c_1fd4, 0x1_2f3f);            /* call 0x100c1fd4 */
            ii(0x100a_f095, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
        l_0x100a_f098:
            ii(0x100a_f098, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f09b, 4); cmp(memb[ds, eax + 25], 3);             /* cmp byte [eax+0x19], 0x3 */
            ii(0x100a_f09f, 2); if(jnz(0x100a_f0a8, 7)) goto l_0x100a_f0a8; /* jnz 0x100af0a8 */
            ii(0x100a_f0a1, 7); mov(memd[ss, ebp - 24], 1);             /* mov dword [ebp-0x18], 0x1 */
        l_0x100a_f0a8:
            ii(0x100a_f0a8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f0ab, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f0ae, 5); call(Definitions.my_3_get_count, -0x2_3c33); /* call 0x1008b480 */
            ii(0x100a_f0b3, 1); cwde();                                 /* cwde */
            ii(0x100a_f0b4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_f0b6, 2); if(jz(0x100a_f0c1, 9)) goto l_0x100a_f0c1; /* jz 0x100af0c1 */
            ii(0x100a_f0b8, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
            ii(0x100a_f0bf, 2); jmp(0x100a_f0da, 0x19); goto l_0x100a_f0da; /* jmp 0x100af0da */
        l_0x100a_f0c1:
            ii(0x100a_f0c1, 5); mov(ecx, 0x5d6);                        /* mov ecx, 0x5d6 */
            ii(0x100a_f0c6, 5); mov(ebx, StringDefinitions.AiMoveCpp5); /* mov ebx, 0x101a0eb8 */
            ii(0x100a_f0cb, 5); mov(edx, StringDefinitions.PlannedPathGetcountNotEqual0); /* mov edx, 0x101a0ec4 */
            ii(0x100a_f0d0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_f0d2, 5); call(Definitions.sys_assert, 0xb_6cbb); /* call 0x10165d92 */
            ii(0x100a_f0d7, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100a_f0da:
            ii(0x100a_f0da, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f0dd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f0e0, 5); call(0x1007_6574, -0x3_8b71);           /* call 0x10076574 */
            ii(0x100a_f0e5, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100a_f0e8, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_f0ea, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100a_f0ed, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_f0f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f0f3, 4); cmp(memb[ds, eax + 72], 0);             /* cmp byte [eax+0x48], 0x0 */
            ii(0x100a_f0f7, 2); if(jz(0x100a_f100, 7)) goto l_0x100a_f100; /* jz 0x100af100 */
            ii(0x100a_f0f9, 7); mov(memd[ss, ebp - 20], 1);             /* mov dword [ebp-0x14], 0x1 */
        l_0x100a_f100:
            ii(0x100a_f100, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f103, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f106, 5); call(0x1007_6574, -0x3_8b97);           /* call 0x10076574 */
            ii(0x100a_f10b, 4); mov(dx, memw[ds, eax + 26]);            /* mov dx, [eax+0x1a] */
            ii(0x100a_f10f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f112, 4); mov(memw[ds, eax + 26], dx);            /* mov [eax+0x1a], dx */
            ii(0x100a_f116, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f119, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f11c, 5); call(0x1007_6574, -0x3_8bad);           /* call 0x10076574 */
            ii(0x100a_f121, 4); mov(dx, memw[ds, eax + 28]);            /* mov dx, [eax+0x1c] */
            ii(0x100a_f125, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f128, 4); mov(memw[ds, eax + 28], dx);            /* mov [eax+0x1c], dx */
            ii(0x100a_f12c, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_f133, 2); jmp(0x100a_f13b, 6); goto l_0x100a_f13b; /* jmp 0x100af13b */
        l_0x100a_f135:
            ii(0x100a_f135, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_f138, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x100a_f13b:
            ii(0x100a_f13b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f13e, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f141, 5); call(Definitions.my_3_get_count, -0x2_3cc6); /* call 0x1008b480 */
            ii(0x100a_f146, 4); cmp(ax, memw[ss, ebp - 16]);            /* cmp ax, [ebp-0x10] */
            ii(0x100a_f14a, 2); if(jle(0x100a_f154, 8)) goto l_0x100a_f154; /* jle 0x100af154 */
            ii(0x100a_f14c, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100a_f150, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_f152, 2); if(jg(0x100a_f159, 5)) goto l_0x100a_f159; /* jg 0x100af159 */
        l_0x100a_f154:
            ii(0x100a_f154, 5); jmp(0x100a_f21a, 0xc1); goto l_0x100a_f21a; /* jmp 0x100af21a */
        l_0x100a_f159:
            ii(0x100a_f159, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100a_f15e, 1); push(eax);                              /* push eax */
            ii(0x100a_f15f, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_f163, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f166, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f169, 5); call(0x100a_aa28, -0x4746);             /* call 0x100aaa28 */
            ii(0x100a_f16e, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x100a_f170, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100a_f173, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_f177, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f17a, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f17d, 5); call(0x100a_aa28, -0x475a);             /* call 0x100aaa28 */
            ii(0x100a_f182, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100a_f185, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f188, 3); mov(edx, memd[ds, eax + 7]);            /* mov edx, [eax+0x7] */
            ii(0x100a_f18b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_f18e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f191, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f194, 5); call(0x1007_6574, -0x3_8c25);           /* call 0x10076574 */
            ii(0x100a_f199, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_f19c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_f19f, 5); call(0x1007_02b9, -0x3_eeeb);           /* call 0x100702b9 */
            ii(0x100a_f1a4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_f1a7, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_f1ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f1ae, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f1b1, 5); call(0x100a_aa28, -0x478e);             /* call 0x100aaa28 */
            ii(0x100a_f1b6, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100a_f1b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f1bc, 4); cmp(dx, memw[ds, eax + 26]);            /* cmp dx, [eax+0x1a] */
            ii(0x100a_f1c0, 2); if(jz(0x100a_f1de, 0x1c)) goto l_0x100a_f1de; /* jz 0x100af1de */
            ii(0x100a_f1c2, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_f1c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f1c9, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f1cc, 5); call(0x100a_aa28, -0x47a9);             /* call 0x100aaa28 */
            ii(0x100a_f1d1, 4); mov(dx, memw[ds, eax + 2]);             /* mov dx, [eax+0x2] */
            ii(0x100a_f1d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f1d8, 4); cmp(dx, memw[ds, eax + 28]);            /* cmp dx, [eax+0x1c] */
            ii(0x100a_f1dc, 2); if(jnz(0x100a_f1e0, 2)) goto l_0x100a_f1e0; /* jnz 0x100af1e0 */
        l_0x100a_f1de:
            ii(0x100a_f1de, 2); jmp(0x100a_f1f3, 0x13); goto l_0x100a_f1f3; /* jmp 0x100af1f3 */
        l_0x100a_f1e0:
            ii(0x100a_f1e0, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100a_f1e4, 3); lea(edx, memd[ds, edx + edx * 2]);      /* lea edx, [edx+edx*2] */
            ii(0x100a_f1e7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_f1e9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_f1ec, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_f1ee, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100a_f1f0, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x100a_f1f3:
            ii(0x100a_f1f3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_f1f6, 3); sub(memd[ss, ebp - 20], eax);           /* sub [ebp-0x14], eax */
            ii(0x100a_f1f9, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_f1fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f200, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f203, 5); call(0x100a_aa28, -0x47e0);             /* call 0x100aaa28 */
            ii(0x100a_f208, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f20a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f20d, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_f210, 5); call(0x1008_8b44, -0x2_66d1);           /* call 0x10088b44 */
            ii(0x100a_f215, 5); jmp(0x100a_f135, -0xe5); goto l_0x100a_f135; /* jmp 0x100af135 */
        l_0x100a_f21a:
            ii(0x100a_f21a, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x100a_f21e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_f220, 2); if(jnz(0x100a_f22b, 9)) goto l_0x100a_f22b; /* jnz 0x100af22b */
            ii(0x100a_f222, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_f226, 5); jmp(0x100a_f29b, 0x70); goto l_0x100a_f29b; /* jmp 0x100af29b */
        l_0x100a_f22b:
            ii(0x100a_f22b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f22e, 4); cmp(memb[ds, eax + 25], 0);             /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_f232, 2); if(jle(0x100a_f23a, 6)) goto l_0x100a_f23a; /* jle 0x100af23a */
            ii(0x100a_f234, 4); cmp(memd[ss, ebp - 28], 0);             /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100a_f238, 2); if(jnz(0x100a_f23c, 2)) goto l_0x100a_f23c; /* jnz 0x100af23c */
        l_0x100a_f23a:
            ii(0x100a_f23a, 2); jmp(0x100a_f263, 0x27); goto l_0x100a_f263; /* jmp 0x100af263 */
        l_0x100a_f23c:
            ii(0x100a_f23c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f23f, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100a_f242, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_f245, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100a_f248, 3); add(edx, memd[ss, ebp - 28]);           /* add edx, [ebp-0x1c] */
            ii(0x100a_f24b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f24e, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x100a_f251, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_f254, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100a_f256, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100a_f258, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_f25a, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_f25d, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x100a_f261, 2); if(jge(0x100a_f265, 2)) goto l_0x100a_f265; /* jge 0x100af265 */
        l_0x100a_f263:
            ii(0x100a_f263, 2); jmp(0x100a_f26b, 6); goto l_0x100a_f26b; /* jmp 0x100af26b */
        l_0x100a_f265:
            ii(0x100a_f265, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_f269, 2); jmp(0x100a_f29b, 0x30); goto l_0x100a_f29b; /* jmp 0x100af29b */
        l_0x100a_f26b:
            ii(0x100a_f26b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f26e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f271, 5); call(0x1007_6574, -0x3_8d02);           /* call 0x10076574 */
            ii(0x100a_f276, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_f279, 4); mov(dx, memw[ds, edx + 26]);            /* mov dx, [edx+0x1a] */
            ii(0x100a_f27d, 4); mov(memw[ds, eax + 65], dx);            /* mov [eax+0x41], dx */
            ii(0x100a_f281, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f284, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f287, 5); call(0x1007_6574, -0x3_8d18);           /* call 0x10076574 */
            ii(0x100a_f28c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_f28f, 4); mov(dx, memw[ds, edx + 28]);            /* mov dx, [edx+0x1c] */
            ii(0x100a_f293, 4); mov(memw[ds, eax + 67], dx);            /* mov [eax+0x43], dx */
            ii(0x100a_f297, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x100a_f29b:
            ii(0x100a_f29b, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_f29e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_f2a0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_f2a1, 1); pop(edi);                               /* pop edi */
            ii(0x100a_f2a2, 1); pop(esi);                               /* pop esi */
            ii(0x100a_f2a3, 1); pop(edx);                               /* pop edx */
            ii(0x100a_f2a4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_f2a5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_f2a6, 1); ret();                                  /* ret */
        }
    }
}
