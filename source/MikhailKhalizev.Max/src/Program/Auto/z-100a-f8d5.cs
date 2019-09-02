using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_f8d5-5d04e03")]
        public void Method_100a_f8d5()
        {
            ii(0x100a_f8d5, 5); push(0x5c);                             /* push 0x5c */
            ii(0x100a_f8da, 5); call(Definitions.sys_check_available_stack_size, 0xb_6473); /* call 0x10165d52 */
            ii(0x100a_f8df, 1); push(esi);                              /* push esi */
            ii(0x100a_f8e0, 1); push(edi);                              /* push edi */
            ii(0x100a_f8e1, 1); push(ebp);                              /* push ebp */
            ii(0x100a_f8e2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_f8e4, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100a_f8ea, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_f8ed, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_f8f0, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_f8f3, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100a_f8f6, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_f8f9, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f8fc, 5); call(0x1008_a5f0, -0x2_5311);           /* call 0x1008a5f0 */
            ii(0x100a_f901, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_f904, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_f907, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x100a_f90a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f90d, 5); call(0x1008_a520, -0x2_53f2);           /* call 0x1008a520 */
            ii(0x100a_f912, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f915, 5); call(0x1007_6574, -0x3_93a6);           /* call 0x10076574 */
            ii(0x100a_f91a, 5); call(0x1015_26ac, 0xa_2d8d);            /* call 0x101526ac */
            ii(0x100a_f91f, 5); call(0x1008_b4b4, -0x2_4470);           /* call 0x1008b4b4 */
            ii(0x100a_f924, 2); test(al, al);                           /* test al, al */
            ii(0x100a_f926, 2); if(jz(0x100a_f937, 0xf)) goto l_0x100a_f937; /* jz 0x100af937 */
            ii(0x100a_f928, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f92a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f92d, 5); call(0x1008_8d4c, -0x2_6be6);           /* call 0x10088d4c */
            ii(0x100a_f932, 5); jmp(0x100a_fbaf, 0x278); goto l_0x100a_fbaf; /* jmp 0x100afbaf */
        l_0x100a_f937:
            ii(0x100a_f937, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_f93b, 2); if(jnz(0x100a_f95e, 0x21)) goto l_0x100a_f95e; /* jnz 0x100af95e */
            ii(0x100a_f93d, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x100a_f942, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f945, 5); call(0x1008_a520, -0x2_542a);           /* call 0x1008a520 */
            ii(0x100a_f94a, 5); call(0x100a_d02d, -0x2922);             /* call 0x100ad02d */
            ii(0x100a_f94f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f951, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f954, 5); call(0x1008_8d4c, -0x2_6c0d);           /* call 0x10088d4c */
            ii(0x100a_f959, 5); jmp(0x100a_fbaf, 0x251); goto l_0x100a_fbaf; /* jmp 0x100afbaf */
        l_0x100a_f95e:
            ii(0x100a_f95e, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x100a_f961, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_f964, 5); call(0x100b_7e0c, 0x84a3);              /* call 0x100b7e0c */
            ii(0x100a_f969, 5); call(0x100b_8204, 0x8896);              /* call 0x100b8204 */
            ii(0x100a_f96e, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x100a_f971, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f974, 5); call(0x100b_8204, 0x888b);              /* call 0x100b8204 */
            ii(0x100a_f979, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f97c, 5); call(0x1008_a520, -0x2_5461);           /* call 0x1008a520 */
            ii(0x100a_f981, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f984, 5); call(0x1007_6574, -0x3_9415);           /* call 0x10076574 */
            ii(0x100a_f989, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_f98c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_f98f, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_f992, 5); call(0x1008_a520, -0x2_5477);           /* call 0x1008a520 */
            ii(0x100a_f997, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f99a, 5); call(0x1007_6574, -0x3_942b);           /* call 0x10076574 */
            ii(0x100a_f99f, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100a_f9a2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_f9a5, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100a_f9a8, 5); call(0x1007_6aac, -0x3_8f01);           /* call 0x10076aac */
            ii(0x100a_f9ad, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_f9b0, 5); call(0x100b_82bc, 0x8907);              /* call 0x100b82bc */
            ii(0x100a_f9b5, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100a_f9b8, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100a_f9bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_f9be, 2); if(jle(0x100a_f9c9, 9)) goto l_0x100a_f9c9; /* jle 0x100af9c9 */
            ii(0x100a_f9c0, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100a_f9c7, 2); jmp(0x100a_f9e2, 0x19); goto l_0x100a_f9e2; /* jmp 0x100af9e2 */
        l_0x100a_f9c9:
            ii(0x100a_f9c9, 5); mov(ecx, 0x6aa);                        /* mov ecx, 0x6aa */
            ii(0x100a_f9ce, 5); mov(ebx, StringDefinitions.AiMoveCpp6); /* mov ebx, 0x101a0ee1 */
            ii(0x100a_f9d3, 5); mov(edx, StringDefinitions.CountGreater0); /* mov edx, 0x101a0eed */
            ii(0x100a_f9d8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_f9da, 5); call(Definitions.sys_assert, 0xb_63b3); /* call 0x10165d92 */
            ii(0x100a_f9df, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x100a_f9e2:
            ii(0x100a_f9e2, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_f9e5, 5); call(0x100b_82bc, 0x88d2);              /* call 0x100b82bc */
            ii(0x100a_f9ea, 4); cmp(ax, memw[ss, ebp - 0x28]);          /* cmp ax, [ebp-0x28] */
            ii(0x100a_f9ee, 2); if(jge(0x100a_f9fb, 0xb)) goto l_0x100a_f9fb; /* jge 0x100af9fb */
            ii(0x100a_f9f0, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_f9f3, 5); call(0x100b_82bc, 0x88c4);              /* call 0x100b82bc */
            ii(0x100a_f9f8, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100a_f9fb:
            ii(0x100a_f9fb, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100a_f9ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_fa01, 2); if(jle(0x100a_fa0c, 9)) goto l_0x100a_fa0c; /* jle 0x100afa0c */
            ii(0x100a_fa03, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x100a_fa0a, 2); jmp(0x100a_fa25, 0x19); goto l_0x100a_fa25; /* jmp 0x100afa25 */
        l_0x100a_fa0c:
            ii(0x100a_fa0c, 5); mov(ecx, 0x6ad);                        /* mov ecx, 0x6ad */
            ii(0x100a_fa11, 5); mov(ebx, StringDefinitions.AiMoveCpp7); /* mov ebx, 0x101a0ef7 */
            ii(0x100a_fa16, 5); mov(edx, StringDefinitions.CountGreater02); /* mov edx, 0x101a0f03 */
            ii(0x100a_fa1b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_fa1d, 5); call(Definitions.sys_assert, 0xb_6370); /* call 0x10165d92 */
            ii(0x100a_fa22, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x100a_fa25:
            ii(0x100a_fa25, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x100a_fa2c, 2); jmp(0x100a_fa34, 6); goto l_0x100a_fa34; /* jmp 0x100afa34 */
        l_0x100a_fa2e:
            ii(0x100a_fa2e, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_fa31, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x100a_fa34:
            ii(0x100a_fa34, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_fa37, 4); cmp(ax, memw[ss, ebp - 0x28]);          /* cmp ax, [ebp-0x28] */
            ii(0x100a_fa3b, 2); if(jge(0x100a_faac, 0x6f)) goto l_0x100a_faac; /* jge 0x100afaac */
            ii(0x100a_fa3d, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_fa41, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fa44, 5); call(0x100b_827c, 0x8833);              /* call 0x100b827c */
            ii(0x100a_fa49, 4); movsx(ax, memb[ds, eax]);               /* movsx ax, byte [eax] */
            ii(0x100a_fa4d, 4); add(memw[ss, ebp - 0x24], ax);          /* add [ebp-0x24], ax */
            ii(0x100a_fa51, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_fa55, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fa58, 5); call(0x100b_827c, 0x881f);              /* call 0x100b827c */
            ii(0x100a_fa5d, 5); movsx(ax, memb[ds, eax + 1]);           /* movsx ax, byte [eax+0x1] */
            ii(0x100a_fa62, 4); add(memw[ss, ebp - 0x22], ax);          /* add [ebp-0x22], ax */
            ii(0x100a_fa66, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_fa6a, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fa6d, 5); call(0x100b_827c, 0x880a);              /* call 0x100b827c */
            ii(0x100a_fa72, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_fa74, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_fa78, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_fa7b, 5); call(0x100b_827c, 0x87fc);              /* call 0x100b827c */
            ii(0x100a_fa80, 2); mov(dl, memb[ds, ebx]);                 /* mov dl, [ebx] */
            ii(0x100a_fa82, 2); cmp(dl, memb[ds, eax]);                 /* cmp dl, [eax] */
            ii(0x100a_fa84, 2); if(jnz(0x100a_faa8, 0x22)) goto l_0x100a_faa8; /* jnz 0x100afaa8 */
            ii(0x100a_fa86, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_fa8a, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fa8d, 5); call(0x100b_827c, 0x87ea);              /* call 0x100b827c */
            ii(0x100a_fa92, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_fa94, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_fa98, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_fa9b, 5); call(0x100b_827c, 0x87dc);              /* call 0x100b827c */
            ii(0x100a_faa0, 3); mov(dl, memb[ds, ebx + 1]);             /* mov dl, [ebx+0x1] */
            ii(0x100a_faa3, 3); cmp(dl, memb[ds, eax + 1]);             /* cmp dl, [eax+0x1] */
            ii(0x100a_faa6, 2); if(jz(0x100a_faaa, 2)) goto l_0x100a_faaa; /* jz 0x100afaaa */
        l_0x100a_faa8:
            ii(0x100a_faa8, 2); jmp(0x100a_faac, 2); goto l_0x100a_faac; /* jmp 0x100afaac */
        l_0x100a_faaa:
            ii(0x100a_faaa, 2); jmp(0x100a_fa2e, -0x7e); goto l_0x100a_fa2e; /* jmp 0x100afa2e */
        l_0x100a_faac:
            ii(0x100a_faac, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100a_faaf, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_fab2, 5); call(0x1008_a520, -0x2_5597);           /* call 0x1008a520 */
            ii(0x100a_fab7, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_faba, 5); call(0x1008_8b44, -0x2_6f7b);           /* call 0x10088b44 */
            ii(0x100a_fabf, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_fac2, 4); cmp(ax, memw[ss, ebp - 0x28]);          /* cmp ax, [ebp-0x28] */
            ii(0x100a_fac6, 2); if(jnz(0x100a_fadd, 0x15)) goto l_0x100a_fadd; /* jnz 0x100afadd */
            ii(0x100a_fac8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_facb, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_face, 5); call(0x1008_a520, -0x2_55b3);           /* call 0x1008a520 */
            ii(0x100a_fad3, 5); call(0x100a_fbb7, 0xdf);                /* call 0x100afbb7 */
            ii(0x100a_fad8, 5); jmp(0x100a_fb91, 0xb4); goto l_0x100a_fb91; /* jmp 0x100afb91 */
        l_0x100a_fadd:
            ii(0x100a_fadd, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100a_fae2, 5); call(Definitions.sys_new, 0xb_6319);    /* call 0x10165e00 */
            ii(0x100a_fae7, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100a_faea, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100a_faed, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100a_faf0, 4); cmp(memd[ss, ebp - 0x3c], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100a_faf4, 2); if(jz(0x100a_fb11, 0x1b)) goto l_0x100a_fb11; /* jz 0x100afb11 */
            ii(0x100a_faf6, 4); movsx(ebx, memw[ss, ebp - 0x22]);       /* movsx ebx, word [ebp-0x22] */
            ii(0x100a_fafa, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100a_fafe, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100a_fb01, 5); call(Definitions.my_ctor_c20, 0x6_a450); /* call 0x10119f56 */
            ii(0x100a_fb06, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100a_fb09, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100a_fb0c, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100a_fb0f, 2); jmp(0x100a_fb17, 6); goto l_0x100a_fb17; /* jmp 0x100afb17 */
        l_0x100a_fb11:
            ii(0x100a_fb11, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100a_fb14, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x100a_fb17:
            ii(0x100a_fb17, 3); mov(edx, memd[ss, ebp - 0x44]);         /* mov edx, [ebp-0x44] */
            ii(0x100a_fb1a, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x100a_fb1d, 5); call(0x100a_b3b0, -0x4772);             /* call 0x100ab3b0 */
            ii(0x100a_fb22, 7); mov(memd[ss, ebp - 0x4c], 0);           /* mov dword [ebp-0x4c], 0x0 */
            ii(0x100a_fb29, 2); jmp(0x100a_fb31, 6); goto l_0x100a_fb31; /* jmp 0x100afb31 */
        l_0x100a_fb2b:
            ii(0x100a_fb2b, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100a_fb2e, 3); inc(memd[ss, ebp - 0x4c]);              /* inc dword [ebp-0x4c] */
        l_0x100a_fb31:
            ii(0x100a_fb31, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100a_fb34, 4); cmp(ax, memw[ss, ebp - 0x34]);          /* cmp ax, [ebp-0x34] */
            ii(0x100a_fb38, 2); if(jg(0x100a_fb70, 0x36)) goto l_0x100a_fb70; /* jg 0x100afb70 */
            ii(0x100a_fb3a, 4); movsx(edx, memw[ss, ebp - 0x4c]);       /* movsx edx, word [ebp-0x4c] */
            ii(0x100a_fb3e, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fb41, 5); call(0x100b_827c, 0x8736);              /* call 0x100b827c */
            ii(0x100a_fb46, 5); movsx(ax, memb[ds, eax + 1]);           /* movsx ax, byte [eax+0x1] */
            ii(0x100a_fb4b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_fb4e, 4); movsx(edx, memw[ss, ebp - 0x4c]);       /* movsx edx, word [ebp-0x4c] */
            ii(0x100a_fb52, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fb55, 5); call(0x100b_827c, 0x8722);              /* call 0x100b827c */
            ii(0x100a_fb5a, 4); movsx(ax, memb[ds, eax]);               /* movsx ax, byte [eax] */
            ii(0x100a_fb5e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_fb61, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x100a_fb64, 5); call(0x100a_b2e0, -0x4889);             /* call 0x100ab2e0 */
            ii(0x100a_fb69, 5); call(0x1011_aca3, 0x6_b135);            /* call 0x1011aca3 */
            ii(0x100a_fb6e, 2); jmp(0x100a_fb2b, -0x45); goto l_0x100a_fb2b; /* jmp 0x100afb2b */
        l_0x100a_fb70:
            ii(0x100a_fb70, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x100a_fb73, 5); call(0x100a_b33c, -0x483c);             /* call 0x100ab33c */
            ii(0x100a_fb78, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_fb7a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_fb7d, 5); call(0x1008_a520, -0x2_5662);           /* call 0x1008a520 */
            ii(0x100a_fb82, 5); call(0x100a_fbb7, 0x30);                /* call 0x100afbb7 */
            ii(0x100a_fb87, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_fb89, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x100a_fb8c, 5); call(0x100a_9f38, -0x5c59);             /* call 0x100a9f38 */
        l_0x100a_fb91:
            ii(0x100a_fb91, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_fb93, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_fb96, 5); call(0x100b_7294, 0x76f9);              /* call 0x100b7294 */
            ii(0x100a_fb9b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_fb9d, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_fba0, 5); call(0x100b_7294, 0x76ef);              /* call 0x100b7294 */
            ii(0x100a_fba5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_fba7, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_fbaa, 5); call(0x1008_8d4c, -0x2_6e63);           /* call 0x10088d4c */
        l_0x100a_fbaf:
            ii(0x100a_fbaf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_fbb1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_fbb2, 1); pop(edi);                               /* pop edi */
            ii(0x100a_fbb3, 1); pop(esi);                               /* pop esi */
            ii(0x100a_fbb4, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
