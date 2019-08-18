using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_1f02-471fd5aa")]
        public void Method_100e_1f02()
        {
            ii(0x100e_1f02, 5); pushd(0x1fc);                           /* push 0x1fc */
            ii(0x100e_1f07, 5); calld(Definitions.sys_check_available_stack_size, 0x8_3e46); /* call 0x10165d52 */
            ii(0x100e_1f0c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_1f0d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_1f0e, 1); pushd(esi);                             /* push esi */
            ii(0x100e_1f0f, 1); pushd(edi);                             /* push edi */
            ii(0x100e_1f10, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_1f11, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_1f13, 6); sub(esp, 0x1cc);                        /* sub esp, 0x1cc */
            ii(0x100e_1f19, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1f1c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_1f1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1f22, 5); cmp(memw_a32[ds, eax + 0x8], 0xa);      /* cmp word [eax+0x8], 0xa */
            ii(0x100e_1f27, 2); if(jnzd(0x100e_1f32, 0x9)) goto l_0x100e_1f32; /* jnz 0x100e1f32 */
            ii(0x100e_1f29, 7); mov(memd_a32[ss, ebp - 0x10], 0x6d3);   /* mov dword [ebp-0x10], 0x6d3 */
            ii(0x100e_1f30, 2); jmpd(0x100e_1f39, 0x7); goto l_0x100e_1f39; /* jmp 0x100e1f39 */
        l_0x100e_1f32:
            ii(0x100e_1f32, 7); mov(memd_a32[ss, ebp - 0x10], 0x6d2);   /* mov dword [ebp-0x10], 0x6d2 */
        l_0x100e_1f39:
            ii(0x100e_1f39, 3); mov(edx, memd_a32[ss, ebp - 0x12]);     /* mov edx, [ebp-0x12] */
            ii(0x100e_1f3c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_1f3f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1f42, 5); calld(0x100d_67d8, -0xb76f);            /* call 0x100d67d8 */
            ii(0x100e_1f47, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1f4a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_1f4d, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100e_1f50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1f53, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_1f56, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x6_b86b); /* call 0x100766f0 */
            ii(0x100e_1f5b, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x100e_1f5e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1f61, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_1f64, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100e_1f67, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1f6a, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_1f6d, 5); calld(Definitions.my_ctor_0x101b_56fc, -0x5_92f6); /* call 0x10088c7c */
            ii(0x100e_1f72, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x100e_1f75, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1f78, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_1f7b, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100e_1f7e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1f81, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_6060); /* mov dword [eax+0x13], 0x101b6060 */
            ii(0x100e_1f88, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_1f8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1f8e, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_1f91, 5); calld(0x1007_6630, -0x6_b966);          /* call 0x10076630 */
            ii(0x100e_1f96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1f99, 4); mov(memb_a32[ds, eax + 0x17], 0);       /* mov byte [eax+0x17], 0x0 */
            ii(0x100e_1f9d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_1fa2, 5); calld(0x1012_0d94, 0x3_eded);           /* call 0x10120d94 */
            ii(0x100e_1fa7, 5); calld(/* sys */ 0x1016_be34, 0x8_9e88); /* call 0x1016be34 */
            ii(0x100e_1fac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1fae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1fb1, 5); calld(0x100d_6adf, -0xb4d7);            /* call 0x100d6adf */
            ii(0x100e_1fb6, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100e_1fbc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1fbf, 5); calld(0x100d_6a11, -0xb5b3);            /* call 0x100d6a11 */
            ii(0x100e_1fc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1fc7, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_1fca, 5); calld(0x1007_6574, -0x6_ba5b);          /* call 0x10076574 */
            ii(0x100e_1fcf, 5); cmp(memw_a32[ds, eax + 0x8], 0xa);      /* cmp word [eax+0x8], 0xa */
            ii(0x100e_1fd4, 6); if(jnzd(0x100e_2130, 0x156)) goto l_0x100e_2130; /* jnz 0x100e2130 */
            ii(0x100e_1fda, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1fdd, 6); mov(memw_a32[ds, eax + 0x28], 0x4);     /* mov word [eax+0x28], 0x4 */
            ii(0x100e_1fe3, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_1fea, 2); jmpd(0x100e_1ff2, 0x6); goto l_0x100e_1ff2; /* jmp 0x100e1ff2 */
        l_0x100e_1fec:
            ii(0x100e_1fec, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_1fef, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100e_1ff2:
            ii(0x100e_1ff2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_1ff5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_1ff8, 4); cmp(ax, memw_a32[ds, edx + 0x28]);      /* cmp ax, [edx+0x28] */
            ii(0x100e_1ffc, 6); if(jged(0x100e_210c, 0x10a)) goto l_0x100e_210c; /* jge 0x100e210c */
            ii(0x100e_2002, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_2005, 5); and(eax, 0x1);                          /* and eax, 0x1 */
            ii(0x100e_200a, 6); imul(eax, eax, 0xe2);                   /* imul eax, eax, 0xe2 */
            ii(0x100e_2010, 5); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x100e_2015, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_2018, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100e_201c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_201e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_2021, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_2023, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_2025, 6); imul(eax, eax, 0xeb);                   /* imul eax, eax, 0xeb */
            ii(0x100e_202b, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100e_202e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_2031, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100e_2036, 5); calld(Definitions.sys_new, 0x8_3dc5);   /* call 0x10165e00 */
            ii(0x100e_203b, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x100e_2041, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_2047, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x100e_204d, 7); cmp(memd_a32[ss, ebp - 0x94], 0);       /* cmp dword [ebp-0x94], 0x0 */
            ii(0x100e_2054, 6); if(jzd(0x100e_20e6, 0x8c)) goto l_0x100e_20e6; /* jz 0x100e20e6 */
            ii(0x100e_205a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_205f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2060, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_2063, 5); add(eax, 0xaa);                         /* add eax, 0xaa */
            ii(0x100e_2068, 1); cwde();                                 /* cwde */
            ii(0x100e_2069, 1); pushd(eax);                             /* push eax */
            ii(0x100e_206a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_206d, 5); add(eax, 0xa0);                         /* add eax, 0xa0 */
            ii(0x100e_2072, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_2075, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_2078, 5); add(eax, 0x8c);                         /* add eax, 0x8c */
            ii(0x100e_207d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_2080, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_2083, 5); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x100e_2088, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_208b, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x100e_2091, 5); calld(0x1008_b148, -0x5_6f4e);          /* call 0x1008b148 */
            ii(0x100e_2096, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_2098, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_209b, 5); add(eax, 0x80);                         /* add eax, 0x80 */
            ii(0x100e_20a0, 1); cwde();                                 /* cwde */
            ii(0x100e_20a1, 1); pushd(eax);                             /* push eax */
            ii(0x100e_20a2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_20a5, 5); add(eax, 0xc8);                         /* add eax, 0xc8 */
            ii(0x100e_20aa, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_20ad, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_20b1, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100e_20b5, 6); lea(eax, ebp - 0xb4);                   /* lea eax, [ebp-0xb4] */
            ii(0x100e_20bb, 5); calld(0x1008_b148, -0x5_6f78);          /* call 0x1008b148 */
            ii(0x100e_20c0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_20c2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_20c5, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_20cb, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x100e_20cd, 5); calld(0x100e_0e82, -0x1250);            /* call 0x100e0e82 */
            ii(0x100e_20d2, 6); mov(memd_a32[ss, ebp - 0xb8], eax);     /* mov [ebp-0xb8], eax */
            ii(0x100e_20d8, 6); mov(eax, memd_a32[ss, ebp - 0xb8]);     /* mov eax, [ebp-0xb8] */
            ii(0x100e_20de, 6); mov(memd_a32[ss, ebp - 0xbc], eax);     /* mov [ebp-0xbc], eax */
            ii(0x100e_20e4, 2); jmpd(0x100e_20f2, 0xc); goto l_0x100e_20f2; /* jmp 0x100e20f2 */
        l_0x100e_20e6:
            ii(0x100e_20e6, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100e_20ec, 6); mov(memd_a32[ss, ebp - 0xbc], eax);     /* mov [ebp-0xbc], eax */
        l_0x100e_20f2:
            ii(0x100e_20f2, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_20f6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_20f9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_20fc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_20fe, 6); mov(eax, memd_a32[ss, ebp - 0xbc]);     /* mov eax, [ebp-0xbc] */
            ii(0x100e_2104, 3); mov(memd_a32[ds, edx + 0x2c], eax);     /* mov [edx+0x2c], eax */
            ii(0x100e_2107, 5); jmpd(0x100e_1fec, -0x120); goto l_0x100e_1fec; /* jmp 0x100e1fec */
        l_0x100e_210c:
            ii(0x100e_210c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_2110, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x100e_2113, 2); if(jged(0x100e_212b, 0x16)) goto l_0x100e_212b; /* jge 0x100e212b */
            ii(0x100e_2115, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_2118, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100e_211b, 1); cwde();                                 /* cwde */
            ii(0x100e_211c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_211f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100e_2122, 7); mov(memd_a32[ds, eax + 0x2c], 0);       /* mov dword [eax+0x2c], 0x0 */
            ii(0x100e_2129, 2); jmpd(0x100e_210c, -0x1f); goto l_0x100e_210c; /* jmp 0x100e210c */
        l_0x100e_212b:
            ii(0x100e_212b, 5); jmpd(0x100e_22c4, 0x194); goto l_0x100e_22c4; /* jmp 0x100e22c4 */
        l_0x100e_2130:
            ii(0x100e_2130, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2133, 6); mov(memw_a32[ds, eax + 0x28], 0x6);     /* mov word [eax+0x28], 0x6 */
            ii(0x100e_2139, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_2140, 2); jmpd(0x100e_2148, 0x6); goto l_0x100e_2148; /* jmp 0x100e2148 */
        l_0x100e_2142:
            ii(0x100e_2142, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_2145, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100e_2148:
            ii(0x100e_2148, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_214b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_214e, 4); cmp(ax, memw_a32[ds, edx + 0x28]);      /* cmp ax, [edx+0x28] */
            ii(0x100e_2152, 6); if(jged(0x100e_22c4, 0x16c)) goto l_0x100e_22c4; /* jge 0x100e22c4 */
            ii(0x100e_2158, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100e_215c, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100e_2161, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_2163, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_2166, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_2168, 6); imul(edx, edx, 0x9b);                   /* imul edx, edx, 0x9b */
            ii(0x100e_216e, 3); add(edx, 0x11);                         /* add edx, 0x11 */
            ii(0x100e_2171, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x100e_2174, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100e_2178, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100e_217d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_217f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_2182, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_2184, 6); imul(eax, eax, 0xeb);                   /* imul eax, eax, 0xeb */
            ii(0x100e_218a, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100e_218d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_2190, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2193, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2196, 5); calld(0x1007_6574, -0x6_bc27);          /* call 0x10076574 */
            ii(0x100e_219b, 5); cmp(memw_a32[ds, eax + 0x8], 0xb);      /* cmp word [eax+0x8], 0xb */
            ii(0x100e_21a0, 2); if(jnzd(0x100e_21c5, 0x23)) goto l_0x100e_21c5; /* jnz 0x100e21c5 */
            ii(0x100e_21a2, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_21a6, 1); pushd(eax);                             /* push eax */
            ii(0x100e_21a7, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_21ab, 1); pushd(eax);                             /* push eax */
            ii(0x100e_21ac, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_21ae, 1); pushd(eax);                             /* push eax */
            ii(0x100e_21af, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100e_21b1, 4); movsx(ebx, memw_a32[ss, ebp - 0x7c]);   /* movsx ebx, word [ebp-0x7c] */
            ii(0x100e_21b5, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100e_21bb, 5); mov(eax, 0x760);                        /* mov eax, 0x760 */
            ii(0x100e_21c0, 5); calld(0x100e_8c51, 0x6a8c);             /* call 0x100e8c51 */
        l_0x100e_21c5:
            ii(0x100e_21c5, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100e_21ca, 5); calld(Definitions.sys_new, 0x8_3c31);   /* call 0x10165e00 */
            ii(0x100e_21cf, 6); mov(memd_a32[ss, ebp - 0xc4], eax);     /* mov [ebp-0xc4], eax */
            ii(0x100e_21d5, 6); mov(eax, memd_a32[ss, ebp - 0xc4]);     /* mov eax, [ebp-0xc4] */
            ii(0x100e_21db, 6); mov(memd_a32[ss, ebp - 0xc8], eax);     /* mov [ebp-0xc8], eax */
            ii(0x100e_21e1, 7); cmp(memd_a32[ss, ebp - 0xc8], 0);       /* cmp dword [ebp-0xc8], 0x0 */
            ii(0x100e_21e8, 6); if(jzd(0x100e_229e, 0xb0)) goto l_0x100e_229e; /* jz 0x100e229e */
            ii(0x100e_21ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_21f1, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_21f4, 5); calld(0x1007_6574, -0x6_bc85);          /* call 0x10076574 */
            ii(0x100e_21f9, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100e_21fd, 2); if(jzd(0x100e_2208, 0x9)) goto l_0x100e_2208; /* jz 0x100e2208 */
            ii(0x100e_21ff, 7); mov(memb_a32[ss, ebp - 0xc0], 0x1);     /* mov byte [ebp-0xc0], 0x1 */
            ii(0x100e_2206, 2); jmpd(0x100e_220f, 0x7); goto l_0x100e_220f; /* jmp 0x100e220f */
        l_0x100e_2208:
            ii(0x100e_2208, 7); mov(memb_a32[ss, ebp - 0xc0], 0);       /* mov byte [ebp-0xc0], 0x0 */
        l_0x100e_220f:
            ii(0x100e_220f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_2211, 6); mov(al, memb_a32[ss, ebp - 0xc0]);      /* mov al, [ebp-0xc0] */
            ii(0x100e_2217, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2218, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_221b, 5); add(eax, 0xaa);                         /* add eax, 0xaa */
            ii(0x100e_2220, 1); cwde();                                 /* cwde */
            ii(0x100e_2221, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2222, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_2225, 5); add(eax, 0x7d);                         /* add eax, 0x7d */
            ii(0x100e_222a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_222d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_2230, 5); add(eax, 0x8c);                         /* add eax, 0x8c */
            ii(0x100e_2235, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_2238, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_223b, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100e_2240, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_2243, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100e_2249, 5); calld(0x1008_b148, -0x5_7106);          /* call 0x1008b148 */
            ii(0x100e_224e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_2250, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_2253, 5); add(eax, 0x80);                         /* add eax, 0x80 */
            ii(0x100e_2258, 1); cwde();                                 /* cwde */
            ii(0x100e_2259, 1); pushd(eax);                             /* push eax */
            ii(0x100e_225a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_225d, 5); add(eax, 0x80);                         /* add eax, 0x80 */
            ii(0x100e_2262, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_2265, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_2269, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100e_226d, 6); lea(eax, ebp - 0xe8);                   /* lea eax, [ebp-0xe8] */
            ii(0x100e_2273, 5); calld(0x1008_b148, -0x5_7130);          /* call 0x1008b148 */
            ii(0x100e_2278, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_227a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_227d, 6); mov(eax, memd_a32[ss, ebp - 0xc4]);     /* mov eax, [ebp-0xc4] */
            ii(0x100e_2283, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x100e_2285, 5); calld(0x100e_0e82, -0x1408);            /* call 0x100e0e82 */
            ii(0x100e_228a, 6); mov(memd_a32[ss, ebp - 0xec], eax);     /* mov [ebp-0xec], eax */
            ii(0x100e_2290, 6); mov(eax, memd_a32[ss, ebp - 0xec]);     /* mov eax, [ebp-0xec] */
            ii(0x100e_2296, 6); mov(memd_a32[ss, ebp - 0xf0], eax);     /* mov [ebp-0xf0], eax */
            ii(0x100e_229c, 2); jmpd(0x100e_22aa, 0xc); goto l_0x100e_22aa; /* jmp 0x100e22aa */
        l_0x100e_229e:
            ii(0x100e_229e, 6); mov(eax, memd_a32[ss, ebp - 0xc8]);     /* mov eax, [ebp-0xc8] */
            ii(0x100e_22a4, 6); mov(memd_a32[ss, ebp - 0xf0], eax);     /* mov [ebp-0xf0], eax */
        l_0x100e_22aa:
            ii(0x100e_22aa, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_22ae, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_22b1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_22b4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_22b6, 6); mov(eax, memd_a32[ss, ebp - 0xf0]);     /* mov eax, [ebp-0xf0] */
            ii(0x100e_22bc, 3); mov(memd_a32[ds, edx + 0x2c], eax);     /* mov [edx+0x2c], eax */
            ii(0x100e_22bf, 5); jmpd(0x100e_2142, -0x182); goto l_0x100e_2142; /* jmp 0x100e2142 */
        l_0x100e_22c4:
            ii(0x100e_22c4, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100e_22c9, 1); pushd(eax);                             /* push eax */
            ii(0x100e_22ca, 5); mov(ecx, 0x5a);                         /* mov ecx, 0x5a */
            ii(0x100e_22cf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_22d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_22d3, 6); lea(eax, ebp - 0x100);                  /* lea eax, [ebp-0x100] */
            ii(0x100e_22d9, 5); calld(0x1008_b148, -0x5_7196);          /* call 0x1008b148 */
            ii(0x100e_22de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_22e1, 6); mov(memw_a32[ds, eax + 0x26], 0);       /* mov word [eax+0x26], 0x0 */
            ii(0x100e_22e7, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100e_22ec, 5); calld(/* sys */ 0x1016_a24c, 0x8_7f5b); /* call 0x1016a24c */
            ii(0x100e_22f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_22f4, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_22f7, 5); calld(0x1007_6574, -0x6_bd88);          /* call 0x10076574 */
            ii(0x100e_22fc, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100e_2301, 2); if(jnzd(0x100e_2312, 0xf)) goto l_0x100e_2312; /* jnz 0x100e2312 */
            ii(0x100e_2303, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2306, 7); mov(memd_a32[ds, eax + 0x4c], 0);       /* mov dword [eax+0x4c], 0x0 */
            ii(0x100e_230d, 5); jmpd(0x100e_240b, 0xf9); goto l_0x100e_240b; /* jmp 0x100e240b */
        l_0x100e_2312:
            ii(0x100e_2312, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_2317, 5); calld(Definitions.sys_new, 0x8_3ae4);   /* call 0x10165e00 */
            ii(0x100e_231c, 6); mov(memd_a32[ss, ebp - 0x104], eax);    /* mov [ebp-0x104], eax */
            ii(0x100e_2322, 6); mov(eax, memd_a32[ss, ebp - 0x104]);    /* mov eax, [ebp-0x104] */
            ii(0x100e_2328, 6); mov(memd_a32[ss, ebp - 0x108], eax);    /* mov [ebp-0x108], eax */
            ii(0x100e_232e, 7); cmp(memd_a32[ss, ebp - 0x108], 0);      /* cmp dword [ebp-0x108], 0x0 */
            ii(0x100e_2335, 2); if(jzd(0x100e_236b, 0x34)) goto l_0x100e_236b; /* jz 0x100e236b */
            ii(0x100e_2337, 5); mov(eax, 0xfc);                         /* mov eax, 0xfc */
            ii(0x100e_233c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_233d, 5); mov(ecx, 0x1ff);                        /* mov ecx, 0x1ff */
            ii(0x100e_2342, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100e_2347, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x100e_234c, 6); mov(eax, memd_a32[ss, ebp - 0x104]);    /* mov eax, [ebp-0x104] */
            ii(0x100e_2352, 5); calld(Definitions.my_ctor_c17, -0x1_3f48); /* call 0x100ce40f */
            ii(0x100e_2357, 6); mov(memd_a32[ss, ebp - 0x10c], eax);    /* mov [ebp-0x10c], eax */
            ii(0x100e_235d, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x100e_2363, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
            ii(0x100e_2369, 2); jmpd(0x100e_2377, 0xc); goto l_0x100e_2377; /* jmp 0x100e2377 */
        l_0x100e_236b:
            ii(0x100e_236b, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100e_2371, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
        l_0x100e_2377:
            ii(0x100e_2377, 6); mov(eax, memd_a32[ss, ebp - 0x110]);    /* mov eax, [ebp-0x110] */
            ii(0x100e_237d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2380, 3); mov(memd_a32[ds, edx + 0x4c], eax);     /* mov [edx+0x4c], eax */
            ii(0x100e_2383, 5); mov(edx, 0x191);                        /* mov edx, 0x191 */
            ii(0x100e_2388, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_238b, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_238e, 5); calld(0x100c_f2ba, -0x1_30d9);          /* call 0x100cf2ba */
            ii(0x100e_2393, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_2396, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2399, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_239c, 5); calld(0x100c_e92d, -0x1_3a74);          /* call 0x100ce92d */
            ii(0x100e_23a1, 6); lea(eax, ebp - 0x114);                  /* lea eax, [ebp-0x114] */
            ii(0x100e_23a7, 5); calld(0x100e_0ba4, -0x1808);            /* call 0x100e0ba4 */
            ii(0x100e_23ac, 1); pushd(eax);                             /* push eax */
            ii(0x100e_23ad, 6); lea(eax, ebp - 0x118);                  /* lea eax, [ebp-0x118] */
            ii(0x100e_23b3, 5); calld(0x100e_0bd0, -0x17e8);            /* call 0x100e0bd0 */
            ii(0x100e_23b8, 1); pushd(eax);                             /* push eax */
            ii(0x100e_23b9, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x100e_23bf, 5); calld(0x100e_0bfc, -0x17c8);            /* call 0x100e0bfc */
            ii(0x100e_23c4, 1); pushd(eax);                             /* push eax */
            ii(0x100e_23c5, 6); lea(eax, ebp - 0x120);                  /* lea eax, [ebp-0x120] */
            ii(0x100e_23cb, 5); calld(0x100e_0c28, -0x17a8);            /* call 0x100e0c28 */
            ii(0x100e_23d0, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_23d2, 6); lea(ebx, ebp - 0x100);                  /* lea ebx, [ebp-0x100] */
            ii(0x100e_23d8, 5); mov(edx, StringDefinitions.ActivateAll); /* mov edx, 0x101a1b9f */
            ii(0x100e_23dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_23e0, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_23e3, 5); calld(0x100c_edcd, -0x1_361b);          /* call 0x100cedcd */
            ii(0x100e_23e8, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_23eb, 5); mov(edx, 0x100e_3451);                  /* mov edx, 0x100e3451 */
            ii(0x100e_23f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_23f3, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_23f6, 5); calld(0x100c_f824, -0x1_2bd7);          /* call 0x100cf824 */
            ii(0x100e_23fb, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_2400, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2403, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_2406, 5); calld(0x100d_50d4, -0xd337);            /* call 0x100d50d4 */
        l_0x100e_240b:
            ii(0x100e_240b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_2410, 5); calld(Definitions.sys_new, 0x8_39eb);   /* call 0x10165e00 */
            ii(0x100e_2415, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100e_2418, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100e_241b, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100e_241e, 4); cmp(memd_a32[ss, ebp - 0x58], 0);       /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100e_2422, 2); if(jzd(0x100e_244f, 0x2b)) goto l_0x100e_244f; /* jz 0x100e244f */
            ii(0x100e_2424, 5); mov(eax, 0x174);                        /* mov eax, 0x174 */
            ii(0x100e_2429, 1); pushd(eax);                             /* push eax */
            ii(0x100e_242a, 5); mov(ecx, 0x1ff);                        /* mov ecx, 0x1ff */
            ii(0x100e_242f, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100e_2434, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x100e_2439, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100e_243c, 5); calld(Definitions.my_ctor_c17, -0x1_4032); /* call 0x100ce40f */
            ii(0x100e_2441, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100e_2444, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100e_2447, 6); mov(memd_a32[ss, ebp - 0x124], eax);    /* mov [ebp-0x124], eax */
            ii(0x100e_244d, 2); jmpd(0x100e_2458, 0x9); goto l_0x100e_2458; /* jmp 0x100e2458 */
        l_0x100e_244f:
            ii(0x100e_244f, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100e_2452, 6); mov(memd_a32[ss, ebp - 0x124], eax);    /* mov [ebp-0x124], eax */
        l_0x100e_2458:
            ii(0x100e_2458, 6); mov(eax, memd_a32[ss, ebp - 0x124]);    /* mov eax, [ebp-0x124] */
            ii(0x100e_245e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2461, 3); mov(memd_a32[ds, edx + 0x5c], eax);     /* mov [edx+0x5c], eax */
            ii(0x100e_2464, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_2467, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_246a, 3); mov(eax, memd_a32[ds, eax + 0x5c]);     /* mov eax, [eax+0x5c] */
            ii(0x100e_246d, 5); calld(0x100c_e92d, -0x1_3b45);          /* call 0x100ce92d */
            ii(0x100e_2472, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100e_2475, 5); calld(0x100e_0ba4, -0x18d6);            /* call 0x100e0ba4 */
            ii(0x100e_247a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_247b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_247e, 5); calld(0x100e_0bd0, -0x18b3);            /* call 0x100e0bd0 */
            ii(0x100e_2483, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2484, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100e_2487, 5); calld(0x100e_0bfc, -0x1890);            /* call 0x100e0bfc */
            ii(0x100e_248c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_248d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_2490, 5); calld(0x100e_0c28, -0x186d);            /* call 0x100e0c28 */
            ii(0x100e_2495, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_2497, 6); lea(ebx, ebp - 0x100);                  /* lea ebx, [ebp-0x100] */
            ii(0x100e_249d, 5); mov(edx, StringDefinitions.Done8);      /* mov edx, 0x101a1bac */
            ii(0x100e_24a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_24a5, 3); mov(eax, memd_a32[ds, eax + 0x5c]);     /* mov eax, [eax+0x5c] */
            ii(0x100e_24a8, 5); calld(0x100c_edcd, -0x1_36e0);          /* call 0x100cedcd */
            ii(0x100e_24ad, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_24b0, 5); mov(edx, 0x100e_3938);                  /* mov edx, 0x100e3938 */
            ii(0x100e_24b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_24b8, 3); mov(eax, memd_a32[ds, eax + 0x5c]);     /* mov eax, [eax+0x5c] */
            ii(0x100e_24bb, 5); calld(0x100c_f824, -0x1_2c9c);          /* call 0x100cf824 */
            ii(0x100e_24c0, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100e_24c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_24c8, 3); mov(eax, memd_a32[ds, eax + 0x5c]);     /* mov eax, [eax+0x5c] */
            ii(0x100e_24cb, 5); calld(0x100d_50d4, -0xd3fc);            /* call 0x100d50d4 */
            ii(0x100e_24d0, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_24d5, 5); calld(Definitions.sys_new, 0x8_3926);   /* call 0x10165e00 */
            ii(0x100e_24da, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100e_24dd, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100e_24e0, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100e_24e3, 4); cmp(memd_a32[ss, ebp - 0x6c], 0);       /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100e_24e7, 2); if(jzd(0x100e_2514, 0x2b)) goto l_0x100e_2514; /* jz 0x100e2514 */
            ii(0x100e_24e9, 5); mov(eax, 0x1aa);                        /* mov eax, 0x1aa */
            ii(0x100e_24ee, 1); pushd(eax);                             /* push eax */
            ii(0x100e_24ef, 5); mov(ecx, 0x1f8);                        /* mov ecx, 0x1f8 */
            ii(0x100e_24f4, 5); mov(ebx, 0x193);                        /* mov ebx, 0x193 */
            ii(0x100e_24f9, 5); mov(edx, 0x192);                        /* mov edx, 0x192 */
            ii(0x100e_24fe, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100e_2501, 5); calld(Definitions.my_ctor_c17, -0x1_40f7); /* call 0x100ce40f */
            ii(0x100e_2506, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100e_2509, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100e_250c, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
            ii(0x100e_2512, 2); jmpd(0x100e_251d, 0x9); goto l_0x100e_251d; /* jmp 0x100e251d */
        l_0x100e_2514:
            ii(0x100e_2514, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100e_2517, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
        l_0x100e_251d:
            ii(0x100e_251d, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x100e_2523, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2526, 3); mov(memd_a32[ds, edx + 0x60], eax);     /* mov [edx+0x60], eax */
            ii(0x100e_2529, 5); mov(edx, 0x194);                        /* mov edx, 0x194 */
            ii(0x100e_252e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2531, 3); mov(eax, memd_a32[ds, eax + 0x60]);     /* mov eax, [eax+0x60] */
            ii(0x100e_2534, 5); calld(0x100c_f2ba, -0x1_327f);          /* call 0x100cf2ba */
            ii(0x100e_2539, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_253c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_253f, 3); mov(eax, memd_a32[ds, eax + 0x60]);     /* mov eax, [eax+0x60] */
            ii(0x100e_2542, 5); calld(0x100c_e92d, -0x1_3c1a);          /* call 0x100ce92d */
            ii(0x100e_2547, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_254a, 5); mov(edx, 0x100e_397a);                  /* mov edx, 0x100e397a */
            ii(0x100e_254f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2552, 3); mov(eax, memd_a32[ds, eax + 0x60]);     /* mov eax, [eax+0x60] */
            ii(0x100e_2555, 5); calld(0x100c_f824, -0x1_2d36);          /* call 0x100cf824 */
            ii(0x100e_255a, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_255f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2562, 3); mov(eax, memd_a32[ds, eax + 0x60]);     /* mov eax, [eax+0x60] */
            ii(0x100e_2565, 5); calld(0x100d_50d4, -0xd496);            /* call 0x100d50d4 */
            ii(0x100e_256a, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_256f, 5); calld(Definitions.sys_new, 0x8_388c);   /* call 0x10165e00 */
            ii(0x100e_2574, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_2577, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_257a, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100e_257d, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100e_2581, 2); if(jzd(0x100e_25ae, 0x2b)) goto l_0x100e_25ae; /* jz 0x100e25ae */
            ii(0x100e_2583, 5); mov(eax, 0x1aa);                        /* mov eax, 0x1aa */
            ii(0x100e_2588, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2589, 5); mov(ecx, 0x212);                        /* mov ecx, 0x212 */
            ii(0x100e_258e, 5); mov(ebx, 0x196);                        /* mov ebx, 0x196 */
            ii(0x100e_2593, 5); mov(edx, 0x195);                        /* mov edx, 0x195 */
            ii(0x100e_2598, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_259b, 5); calld(Definitions.my_ctor_c17, -0x1_4191); /* call 0x100ce40f */
            ii(0x100e_25a0, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100e_25a3, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100e_25a6, 6); mov(memd_a32[ss, ebp - 0x12c], eax);    /* mov [ebp-0x12c], eax */
            ii(0x100e_25ac, 2); jmpd(0x100e_25b7, 0x9); goto l_0x100e_25b7; /* jmp 0x100e25b7 */
        l_0x100e_25ae:
            ii(0x100e_25ae, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100e_25b1, 6); mov(memd_a32[ss, ebp - 0x12c], eax);    /* mov [ebp-0x12c], eax */
        l_0x100e_25b7:
            ii(0x100e_25b7, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x100e_25bd, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_25c0, 3); mov(memd_a32[ds, edx + 0x64], eax);     /* mov [edx+0x64], eax */
            ii(0x100e_25c3, 5); mov(edx, 0x197);                        /* mov edx, 0x197 */
            ii(0x100e_25c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_25cb, 3); mov(eax, memd_a32[ds, eax + 0x64]);     /* mov eax, [eax+0x64] */
            ii(0x100e_25ce, 5); calld(0x100c_f2ba, -0x1_3319);          /* call 0x100cf2ba */
            ii(0x100e_25d3, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_25d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_25d9, 3); mov(eax, memd_a32[ds, eax + 0x64]);     /* mov eax, [eax+0x64] */
            ii(0x100e_25dc, 5); calld(0x100c_e92d, -0x1_3cb4);          /* call 0x100ce92d */
            ii(0x100e_25e1, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_25e4, 5); mov(edx, 0x100e_39d6);                  /* mov edx, 0x100e39d6 */
            ii(0x100e_25e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_25ec, 3); mov(eax, memd_a32[ds, eax + 0x64]);     /* mov eax, [eax+0x64] */
            ii(0x100e_25ef, 5); calld(0x100c_f824, -0x1_2dd0);          /* call 0x100cf824 */
            ii(0x100e_25f4, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_25f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_25fc, 3); mov(eax, memd_a32[ds, eax + 0x64]);     /* mov eax, [eax+0x64] */
            ii(0x100e_25ff, 5); calld(0x100d_50d4, -0xd530);            /* call 0x100d50d4 */
            ii(0x100e_2604, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_2609, 5); calld(Definitions.sys_new, 0x8_37f2);   /* call 0x10165e00 */
            ii(0x100e_260e, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100e_2611, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100e_2614, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_2617, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100e_261b, 2); if(jzd(0x100e_2648, 0x2b)) goto l_0x100e_2648; /* jz 0x100e2648 */
            ii(0x100e_261d, 5); mov(eax, 0x1aa);                        /* mov eax, 0x1aa */
            ii(0x100e_2622, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2623, 5); mov(ecx, 0x248);                        /* mov ecx, 0x248 */
            ii(0x100e_2628, 5); mov(ebx, 0x199);                        /* mov ebx, 0x199 */
            ii(0x100e_262d, 5); mov(edx, 0x198);                        /* mov edx, 0x198 */
            ii(0x100e_2632, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100e_2635, 5); calld(Definitions.my_ctor_c17, -0x1_422b); /* call 0x100ce40f */
            ii(0x100e_263a, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100e_263d, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100e_2640, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
            ii(0x100e_2646, 2); jmpd(0x100e_2651, 0x9); goto l_0x100e_2651; /* jmp 0x100e2651 */
        l_0x100e_2648:
            ii(0x100e_2648, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_264b, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
        l_0x100e_2651:
            ii(0x100e_2651, 6); mov(eax, memd_a32[ss, ebp - 0x130]);    /* mov eax, [ebp-0x130] */
            ii(0x100e_2657, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_265a, 3); mov(memd_a32[ds, edx + 0x68], eax);     /* mov [edx+0x68], eax */
            ii(0x100e_265d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_2660, 5); mov(edx, 0x100e_3a40);                  /* mov edx, 0x100e3a40 */
            ii(0x100e_2665, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2668, 3); mov(eax, memd_a32[ds, eax + 0x68]);     /* mov eax, [eax+0x68] */
            ii(0x100e_266b, 5); calld(0x100c_f824, -0x1_2e4c);          /* call 0x100cf824 */
            ii(0x100e_2670, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_2675, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2678, 3); mov(eax, memd_a32[ds, eax + 0x68]);     /* mov eax, [eax+0x68] */
            ii(0x100e_267b, 5); calld(0x100d_50d4, -0xd5ac);            /* call 0x100d50d4 */
            ii(0x100e_2680, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2683, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2686, 5); calld(0x1007_6574, -0x6_c117);          /* call 0x10076574 */
            ii(0x100e_268b, 5); cmp(memw_a32[ds, eax + 0x8], 0x9);      /* cmp word [eax+0x8], 0x9 */
            ii(0x100e_2690, 2); if(jzd(0x100e_26a4, 0x12)) goto l_0x100e_26a4; /* jz 0x100e26a4 */
            ii(0x100e_2692, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2695, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2698, 5); calld(0x1007_6574, -0x6_c129);          /* call 0x10076574 */
            ii(0x100e_269d, 5); cmp(memw_a32[ds, eax + 0x8], 0xa);      /* cmp word [eax+0x8], 0xa */
            ii(0x100e_26a2, 2); if(jnzd(0x100e_26a6, 0x2)) goto l_0x100e_26a6; /* jnz 0x100e26a6 */
        l_0x100e_26a4:
            ii(0x100e_26a4, 2); jmpd(0x100e_26b8, 0x12); goto l_0x100e_26b8; /* jmp 0x100e26b8 */
        l_0x100e_26a6:
            ii(0x100e_26a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26a9, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_26ac, 5); calld(0x1007_6574, -0x6_c13d);          /* call 0x10076574 */
            ii(0x100e_26b1, 5); cmp(memw_a32[ds, eax + 0x8], 0xb);      /* cmp word [eax+0x8], 0xb */
            ii(0x100e_26b6, 2); if(jnzd(0x100e_26ba, 0x2)) goto l_0x100e_26ba; /* jnz 0x100e26ba */
        l_0x100e_26b8:
            ii(0x100e_26b8, 2); jmpd(0x100e_26cc, 0x12); goto l_0x100e_26cc; /* jmp 0x100e26cc */
        l_0x100e_26ba:
            ii(0x100e_26ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26bd, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_26c0, 5); calld(0x1007_6574, -0x6_c151);          /* call 0x10076574 */
            ii(0x100e_26c5, 5); cmp(memw_a32[ds, eax + 0x8], 0x3);      /* cmp word [eax+0x8], 0x3 */
            ii(0x100e_26ca, 2); if(jnzd(0x100e_26ce, 0x2)) goto l_0x100e_26ce; /* jnz 0x100e26ce */
        l_0x100e_26cc:
            ii(0x100e_26cc, 2); jmpd(0x100e_270e, 0x40); goto l_0x100e_270e; /* jmp 0x100e270e */
        l_0x100e_26ce:
            ii(0x100e_26ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26d1, 7); mov(memd_a32[ds, eax + 0x50], 0);       /* mov dword [eax+0x50], 0x0 */
            ii(0x100e_26d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26db, 7); mov(memd_a32[ds, eax + 0x54], 0);       /* mov dword [eax+0x54], 0x0 */
            ii(0x100e_26e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26e5, 7); mov(memd_a32[ds, eax + 0x58], 0);       /* mov dword [eax+0x58], 0x0 */
            ii(0x100e_26ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26ef, 7); mov(memd_a32[ds, eax + 0x44], 0);       /* mov dword [eax+0x44], 0x0 */
            ii(0x100e_26f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_26f9, 7); mov(memd_a32[ds, eax + 0x48], 0);       /* mov dword [eax+0x48], 0x0 */
            ii(0x100e_2700, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2703, 6); mov(memw_a32[ds, eax + 0x2a], 0);       /* mov word [eax+0x2a], 0x0 */
            ii(0x100e_2709, 5); jmpd(0x100e_2b99, 0x48b); goto l_0x100e_2b99; /* jmp 0x100e2b99 */
        l_0x100e_270e:
            ii(0x100e_270e, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_2713, 5); calld(Definitions.sys_new, 0x8_36e8);   /* call 0x10165e00 */
            ii(0x100e_2718, 6); mov(memd_a32[ss, ebp - 0x134], eax);    /* mov [ebp-0x134], eax */
            ii(0x100e_271e, 6); mov(eax, memd_a32[ss, ebp - 0x134]);    /* mov eax, [ebp-0x134] */
            ii(0x100e_2724, 6); mov(memd_a32[ss, ebp - 0x138], eax);    /* mov [ebp-0x138], eax */
            ii(0x100e_272a, 7); cmp(memd_a32[ss, ebp - 0x138], 0);      /* cmp dword [ebp-0x138], 0x0 */
            ii(0x100e_2731, 2); if(jzd(0x100e_2767, 0x34)) goto l_0x100e_2767; /* jz 0x100e2767 */
            ii(0x100e_2733, 5); mov(eax, 0x115);                        /* mov eax, 0x115 */
            ii(0x100e_2738, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2739, 5); mov(ecx, 0x1ff);                        /* mov ecx, 0x1ff */
            ii(0x100e_273e, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100e_2743, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x100e_2748, 6); mov(eax, memd_a32[ss, ebp - 0x134]);    /* mov eax, [ebp-0x134] */
            ii(0x100e_274e, 5); calld(Definitions.my_ctor_c17, -0x1_4344); /* call 0x100ce40f */
            ii(0x100e_2753, 6); mov(memd_a32[ss, ebp - 0x13c], eax);    /* mov [ebp-0x13c], eax */
            ii(0x100e_2759, 6); mov(eax, memd_a32[ss, ebp - 0x13c]);    /* mov eax, [ebp-0x13c] */
            ii(0x100e_275f, 6); mov(memd_a32[ss, ebp - 0x140], eax);    /* mov [ebp-0x140], eax */
            ii(0x100e_2765, 2); jmpd(0x100e_2773, 0xc); goto l_0x100e_2773; /* jmp 0x100e2773 */
        l_0x100e_2767:
            ii(0x100e_2767, 6); mov(eax, memd_a32[ss, ebp - 0x138]);    /* mov eax, [ebp-0x138] */
            ii(0x100e_276d, 6); mov(memd_a32[ss, ebp - 0x140], eax);    /* mov [ebp-0x140], eax */
        l_0x100e_2773:
            ii(0x100e_2773, 6); mov(eax, memd_a32[ss, ebp - 0x140]);    /* mov eax, [ebp-0x140] */
            ii(0x100e_2779, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_277c, 3); mov(memd_a32[ds, edx + 0x50], eax);     /* mov [edx+0x50], eax */
            ii(0x100e_277f, 5); mov(edx, 0x191);                        /* mov edx, 0x191 */
            ii(0x100e_2784, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2787, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_278a, 5); calld(0x100c_f2ba, -0x1_34d5);          /* call 0x100cf2ba */
            ii(0x100e_278f, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_2792, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2795, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_2798, 5); calld(0x100c_e92d, -0x1_3e70);          /* call 0x100ce92d */
            ii(0x100e_279d, 6); lea(eax, ebp - 0x144);                  /* lea eax, [ebp-0x144] */
            ii(0x100e_27a3, 5); calld(0x100e_0ba4, -0x1c04);            /* call 0x100e0ba4 */
            ii(0x100e_27a8, 1); pushd(eax);                             /* push eax */
            ii(0x100e_27a9, 6); lea(eax, ebp - 0x148);                  /* lea eax, [ebp-0x148] */
            ii(0x100e_27af, 5); calld(0x100e_0bd0, -0x1be4);            /* call 0x100e0bd0 */
            ii(0x100e_27b4, 1); pushd(eax);                             /* push eax */
            ii(0x100e_27b5, 6); lea(eax, ebp - 0x14c);                  /* lea eax, [ebp-0x14c] */
            ii(0x100e_27bb, 5); calld(0x100e_0bfc, -0x1bc4);            /* call 0x100e0bfc */
            ii(0x100e_27c0, 1); pushd(eax);                             /* push eax */
            ii(0x100e_27c1, 6); lea(eax, ebp - 0x150);                  /* lea eax, [ebp-0x150] */
            ii(0x100e_27c7, 5); calld(0x100e_0c28, -0x1ba4);            /* call 0x100e0c28 */
            ii(0x100e_27cc, 6); lea(ebx, ebp - 0x100);                  /* lea ebx, [ebp-0x100] */
            ii(0x100e_27d2, 5); mov(edx, StringDefinitions.ReloadAll);  /* mov edx, 0x101a1bb1 */
            ii(0x100e_27d7, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100e_27da, 3); mov(esi, memd_a32[ds, esi + 0x50]);     /* mov esi, [esi+0x50] */
            ii(0x100e_27dd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_27df, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100e_27e1, 5); calld(0x100c_edcd, -0x1_3a19);          /* call 0x100cedcd */
            ii(0x100e_27e6, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_27e9, 5); mov(edx, 0x100e_3729);                  /* mov edx, 0x100e3729 */
            ii(0x100e_27ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_27f1, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_27f4, 5); calld(0x100c_f824, -0x1_2fd5);          /* call 0x100cf824 */
            ii(0x100e_27f9, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_27fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2801, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_2804, 5); calld(0x100d_50d4, -0xd735);            /* call 0x100d50d4 */
            ii(0x100e_2809, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_280e, 5); calld(Definitions.sys_new, 0x8_35ed);   /* call 0x10165e00 */
            ii(0x100e_2813, 6); mov(memd_a32[ss, ebp - 0x154], eax);    /* mov [ebp-0x154], eax */
            ii(0x100e_2819, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x100e_281f, 6); mov(memd_a32[ss, ebp - 0x158], eax);    /* mov [ebp-0x158], eax */
            ii(0x100e_2825, 7); cmp(memd_a32[ss, ebp - 0x158], 0);      /* cmp dword [ebp-0x158], 0x0 */
            ii(0x100e_282c, 2); if(jzd(0x100e_2862, 0x34)) goto l_0x100e_2862; /* jz 0x100e2862 */
            ii(0x100e_282e, 5); mov(eax, 0x12e);                        /* mov eax, 0x12e */
            ii(0x100e_2833, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2834, 5); mov(ecx, 0x1ff);                        /* mov ecx, 0x1ff */
            ii(0x100e_2839, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100e_283e, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x100e_2843, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x100e_2849, 5); calld(Definitions.my_ctor_c17, -0x1_443f); /* call 0x100ce40f */
            ii(0x100e_284e, 6); mov(memd_a32[ss, ebp - 0x15c], eax);    /* mov [ebp-0x15c], eax */
            ii(0x100e_2854, 6); mov(eax, memd_a32[ss, ebp - 0x15c]);    /* mov eax, [ebp-0x15c] */
            ii(0x100e_285a, 6); mov(memd_a32[ss, ebp - 0x160], eax);    /* mov [ebp-0x160], eax */
            ii(0x100e_2860, 2); jmpd(0x100e_286e, 0xc); goto l_0x100e_286e; /* jmp 0x100e286e */
        l_0x100e_2862:
            ii(0x100e_2862, 6); mov(eax, memd_a32[ss, ebp - 0x158]);    /* mov eax, [ebp-0x158] */
            ii(0x100e_2868, 6); mov(memd_a32[ss, ebp - 0x160], eax);    /* mov [ebp-0x160], eax */
        l_0x100e_286e:
            ii(0x100e_286e, 6); mov(eax, memd_a32[ss, ebp - 0x160]);    /* mov eax, [ebp-0x160] */
            ii(0x100e_2874, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2877, 3); mov(memd_a32[ds, edx + 0x54], eax);     /* mov [edx+0x54], eax */
            ii(0x100e_287a, 5); mov(edx, 0x191);                        /* mov edx, 0x191 */
            ii(0x100e_287f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2882, 3); mov(eax, memd_a32[ds, eax + 0x54]);     /* mov eax, [eax+0x54] */
            ii(0x100e_2885, 5); calld(0x100c_f2ba, -0x1_35d0);          /* call 0x100cf2ba */
            ii(0x100e_288a, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_288d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2890, 3); mov(eax, memd_a32[ds, eax + 0x54]);     /* mov eax, [eax+0x54] */
            ii(0x100e_2893, 5); calld(0x100c_e92d, -0x1_3f6b);          /* call 0x100ce92d */
            ii(0x100e_2898, 6); lea(eax, ebp - 0x164);                  /* lea eax, [ebp-0x164] */
            ii(0x100e_289e, 5); calld(0x100e_0ba4, -0x1cff);            /* call 0x100e0ba4 */
            ii(0x100e_28a3, 1); pushd(eax);                             /* push eax */
            ii(0x100e_28a4, 6); lea(eax, ebp - 0x168);                  /* lea eax, [ebp-0x168] */
            ii(0x100e_28aa, 5); calld(0x100e_0bd0, -0x1cdf);            /* call 0x100e0bd0 */
            ii(0x100e_28af, 1); pushd(eax);                             /* push eax */
            ii(0x100e_28b0, 6); lea(eax, ebp - 0x16c);                  /* lea eax, [ebp-0x16c] */
            ii(0x100e_28b6, 5); calld(0x100e_0bfc, -0x1cbf);            /* call 0x100e0bfc */
            ii(0x100e_28bb, 1); pushd(eax);                             /* push eax */
            ii(0x100e_28bc, 6); lea(eax, ebp - 0x170);                  /* lea eax, [ebp-0x170] */
            ii(0x100e_28c2, 5); calld(0x100e_0c28, -0x1c9f);            /* call 0x100e0c28 */
            ii(0x100e_28c7, 6); lea(ebx, ebp - 0x100);                  /* lea ebx, [ebp-0x100] */
            ii(0x100e_28cd, 5); mov(edx, StringDefinitions.RepairAll);  /* mov edx, 0x101a1bbc */
            ii(0x100e_28d2, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100e_28d5, 3); mov(esi, memd_a32[ds, esi + 0x54]);     /* mov esi, [esi+0x54] */
            ii(0x100e_28d8, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_28da, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100e_28dc, 5); calld(0x100c_edcd, -0x1_3b14);          /* call 0x100cedcd */
            ii(0x100e_28e1, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_28e4, 5); mov(edx, 0x100e_37ee);                  /* mov edx, 0x100e37ee */
            ii(0x100e_28e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_28ec, 3); mov(eax, memd_a32[ds, eax + 0x54]);     /* mov eax, [eax+0x54] */
            ii(0x100e_28ef, 5); calld(0x100c_f824, -0x1_30d0);          /* call 0x100cf824 */
            ii(0x100e_28f4, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_28f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_28fc, 3); mov(eax, memd_a32[ds, eax + 0x54]);     /* mov eax, [eax+0x54] */
            ii(0x100e_28ff, 5); calld(0x100d_50d4, -0xd830);            /* call 0x100d50d4 */
            ii(0x100e_2904, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_2909, 5); calld(Definitions.sys_new, 0x8_34f2);   /* call 0x10165e00 */
            ii(0x100e_290e, 6); mov(memd_a32[ss, ebp - 0x174], eax);    /* mov [ebp-0x174], eax */
            ii(0x100e_2914, 6); mov(eax, memd_a32[ss, ebp - 0x174]);    /* mov eax, [ebp-0x174] */
            ii(0x100e_291a, 6); mov(memd_a32[ss, ebp - 0x178], eax);    /* mov [ebp-0x178], eax */
            ii(0x100e_2920, 7); cmp(memd_a32[ss, ebp - 0x178], 0);      /* cmp dword [ebp-0x178], 0x0 */
            ii(0x100e_2927, 2); if(jzd(0x100e_295d, 0x34)) goto l_0x100e_295d; /* jz 0x100e295d */
            ii(0x100e_2929, 5); mov(eax, 0x147);                        /* mov eax, 0x147 */
            ii(0x100e_292e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_292f, 5); mov(ecx, 0x1ff);                        /* mov ecx, 0x1ff */
            ii(0x100e_2934, 5); mov(ebx, 0x191);                        /* mov ebx, 0x191 */
            ii(0x100e_2939, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x100e_293e, 6); mov(eax, memd_a32[ss, ebp - 0x174]);    /* mov eax, [ebp-0x174] */
            ii(0x100e_2944, 5); calld(Definitions.my_ctor_c17, -0x1_453a); /* call 0x100ce40f */
            ii(0x100e_2949, 6); mov(memd_a32[ss, ebp - 0x17c], eax);    /* mov [ebp-0x17c], eax */
            ii(0x100e_294f, 6); mov(eax, memd_a32[ss, ebp - 0x17c]);    /* mov eax, [ebp-0x17c] */
            ii(0x100e_2955, 6); mov(memd_a32[ss, ebp - 0x180], eax);    /* mov [ebp-0x180], eax */
            ii(0x100e_295b, 2); jmpd(0x100e_2969, 0xc); goto l_0x100e_2969; /* jmp 0x100e2969 */
        l_0x100e_295d:
            ii(0x100e_295d, 6); mov(eax, memd_a32[ss, ebp - 0x178]);    /* mov eax, [ebp-0x178] */
            ii(0x100e_2963, 6); mov(memd_a32[ss, ebp - 0x180], eax);    /* mov [ebp-0x180], eax */
        l_0x100e_2969:
            ii(0x100e_2969, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x100e_296f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2972, 3); mov(memd_a32[ds, edx + 0x58], eax);     /* mov [edx+0x58], eax */
            ii(0x100e_2975, 5); mov(edx, 0x191);                        /* mov edx, 0x191 */
            ii(0x100e_297a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_297d, 3); mov(eax, memd_a32[ds, eax + 0x58]);     /* mov eax, [eax+0x58] */
            ii(0x100e_2980, 5); calld(0x100c_f2ba, -0x1_36cb);          /* call 0x100cf2ba */
            ii(0x100e_2985, 3); mov(edx, memd_a32[ss, ebp - 0x7a]);     /* mov edx, [ebp-0x7a] */
            ii(0x100e_2988, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_298b, 3); mov(eax, memd_a32[ds, eax + 0x58]);     /* mov eax, [eax+0x58] */
            ii(0x100e_298e, 5); calld(0x100c_e92d, -0x1_4066);          /* call 0x100ce92d */
            ii(0x100e_2993, 6); lea(eax, ebp - 0x184);                  /* lea eax, [ebp-0x184] */
            ii(0x100e_2999, 5); calld(0x100e_0ba4, -0x1dfa);            /* call 0x100e0ba4 */
            ii(0x100e_299e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_299f, 6); lea(eax, ebp - 0x188);                  /* lea eax, [ebp-0x188] */
            ii(0x100e_29a5, 5); calld(0x100e_0bd0, -0x1dda);            /* call 0x100e0bd0 */
            ii(0x100e_29aa, 1); pushd(eax);                             /* push eax */
            ii(0x100e_29ab, 6); lea(eax, ebp - 0x18c);                  /* lea eax, [ebp-0x18c] */
            ii(0x100e_29b1, 5); calld(0x100e_0bfc, -0x1dba);            /* call 0x100e0bfc */
            ii(0x100e_29b6, 1); pushd(eax);                             /* push eax */
            ii(0x100e_29b7, 6); lea(eax, ebp - 0x190);                  /* lea eax, [ebp-0x190] */
            ii(0x100e_29bd, 5); calld(0x100e_0c28, -0x1d9a);            /* call 0x100e0c28 */
            ii(0x100e_29c2, 6); lea(ebx, ebp - 0x100);                  /* lea ebx, [ebp-0x100] */
            ii(0x100e_29c8, 5); mov(edx, StringDefinitions.UpgradeAll); /* mov edx, 0x101a1bc7 */
            ii(0x100e_29cd, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100e_29d0, 3); mov(esi, memd_a32[ds, esi + 0x58]);     /* mov esi, [esi+0x58] */
            ii(0x100e_29d3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_29d5, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100e_29d7, 5); calld(0x100c_edcd, -0x1_3c0f);          /* call 0x100cedcd */
            ii(0x100e_29dc, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100e_29df, 5); mov(edx, 0x100e_38b3);                  /* mov edx, 0x100e38b3 */
            ii(0x100e_29e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_29e7, 3); mov(eax, memd_a32[ds, eax + 0x58]);     /* mov eax, [eax+0x58] */
            ii(0x100e_29ea, 5); calld(0x100c_f824, -0x1_31cb);          /* call 0x100cf824 */
            ii(0x100e_29ef, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_29f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_29f7, 3); mov(eax, memd_a32[ds, eax + 0x58]);     /* mov eax, [eax+0x58] */
            ii(0x100e_29fa, 5); calld(0x100d_50d4, -0xd92b);            /* call 0x100d50d4 */
            ii(0x100e_29ff, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100e_2a04, 5); calld(Definitions.sys_new, 0x8_33f7);   /* call 0x10165e00 */
            ii(0x100e_2a09, 6); mov(memd_a32[ss, ebp - 0x194], eax);    /* mov [ebp-0x194], eax */
            ii(0x100e_2a0f, 6); mov(eax, memd_a32[ss, ebp - 0x194]);    /* mov eax, [ebp-0x194] */
            ii(0x100e_2a15, 6); mov(memd_a32[ss, ebp - 0x198], eax);    /* mov [ebp-0x198], eax */
            ii(0x100e_2a1b, 7); cmp(memd_a32[ss, ebp - 0x198], 0);      /* cmp dword [ebp-0x198], 0x0 */
            ii(0x100e_2a22, 2); if(jzd(0x100e_2a58, 0x34)) goto l_0x100e_2a58; /* jz 0x100e2a58 */
            ii(0x100e_2a24, 5); mov(eax, 0x73);                         /* mov eax, 0x73 */
            ii(0x100e_2a29, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2a2a, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100e_2a2f, 5); mov(ebx, 0x6a);                         /* mov ebx, 0x6a */
            ii(0x100e_2a34, 5); mov(edx, 0x222);                        /* mov edx, 0x222 */
            ii(0x100e_2a39, 6); mov(eax, memd_a32[ss, ebp - 0x194]);    /* mov eax, [ebp-0x194] */
            ii(0x100e_2a3f, 5); calld(0x100d_7bdc, -0xae68);            /* call 0x100d7bdc */
            ii(0x100e_2a44, 6); mov(memd_a32[ss, ebp - 0x19c], eax);    /* mov [ebp-0x19c], eax */
            ii(0x100e_2a4a, 6); mov(eax, memd_a32[ss, ebp - 0x19c]);    /* mov eax, [ebp-0x19c] */
            ii(0x100e_2a50, 6); mov(memd_a32[ss, ebp - 0x1a0], eax);    /* mov [ebp-0x1a0], eax */
            ii(0x100e_2a56, 2); jmpd(0x100e_2a64, 0xc); goto l_0x100e_2a64; /* jmp 0x100e2a64 */
        l_0x100e_2a58:
            ii(0x100e_2a58, 6); mov(eax, memd_a32[ss, ebp - 0x198]);    /* mov eax, [ebp-0x198] */
            ii(0x100e_2a5e, 6); mov(memd_a32[ss, ebp - 0x1a0], eax);    /* mov [ebp-0x1a0], eax */
        l_0x100e_2a64:
            ii(0x100e_2a64, 6); mov(eax, memd_a32[ss, ebp - 0x1a0]);    /* mov eax, [ebp-0x1a0] */
            ii(0x100e_2a6a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2a6d, 3); mov(memd_a32[ds, edx + 0x44], eax);     /* mov [edx+0x44], eax */
            ii(0x100e_2a70, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100e_2a76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2a79, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x100e_2a7c, 5); calld(0x100d_7d74, -0xad0d);            /* call 0x100d7d74 */
            ii(0x100e_2a81, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100e_2a86, 5); calld(Definitions.sys_new, 0x8_3375);   /* call 0x10165e00 */
            ii(0x100e_2a8b, 6); mov(memd_a32[ss, ebp - 0x1a4], eax);    /* mov [ebp-0x1a4], eax */
            ii(0x100e_2a91, 6); mov(eax, memd_a32[ss, ebp - 0x1a4]);    /* mov eax, [ebp-0x1a4] */
            ii(0x100e_2a97, 6); mov(memd_a32[ss, ebp - 0x1a8], eax);    /* mov [ebp-0x1a8], eax */
            ii(0x100e_2a9d, 7); cmp(memd_a32[ss, ebp - 0x1a8], 0);      /* cmp dword [ebp-0x1a8], 0x0 */
            ii(0x100e_2aa4, 2); if(jzd(0x100e_2ada, 0x34)) goto l_0x100e_2ada; /* jz 0x100e2ada */
            ii(0x100e_2aa6, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x100e_2aab, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2aac, 5); mov(ecx, 0x36);                         /* mov ecx, 0x36 */
            ii(0x100e_2ab1, 5); mov(ebx, 0x4c);                         /* mov ebx, 0x4c */
            ii(0x100e_2ab6, 5); mov(edx, 0x211);                        /* mov edx, 0x211 */
            ii(0x100e_2abb, 6); mov(eax, memd_a32[ss, ebp - 0x1a4]);    /* mov eax, [ebp-0x1a4] */
            ii(0x100e_2ac1, 5); calld(0x100d_7bdc, -0xaeea);            /* call 0x100d7bdc */
            ii(0x100e_2ac6, 6); mov(memd_a32[ss, ebp - 0x1ac], eax);    /* mov [ebp-0x1ac], eax */
            ii(0x100e_2acc, 6); mov(eax, memd_a32[ss, ebp - 0x1ac]);    /* mov eax, [ebp-0x1ac] */
            ii(0x100e_2ad2, 6); mov(memd_a32[ss, ebp - 0x1b0], eax);    /* mov [ebp-0x1b0], eax */
            ii(0x100e_2ad8, 2); jmpd(0x100e_2ae6, 0xc); goto l_0x100e_2ae6; /* jmp 0x100e2ae6 */
        l_0x100e_2ada:
            ii(0x100e_2ada, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100e_2ae0, 6); mov(memd_a32[ss, ebp - 0x1b0], eax);    /* mov [ebp-0x1b0], eax */
        l_0x100e_2ae6:
            ii(0x100e_2ae6, 6); mov(eax, memd_a32[ss, ebp - 0x1b0]);    /* mov eax, [ebp-0x1b0] */
            ii(0x100e_2aec, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2aef, 3); mov(memd_a32[ds, edx + 0x48], eax);     /* mov [edx+0x48], eax */
            ii(0x100e_2af2, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x100e_2af8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2afb, 3); mov(eax, memd_a32[ds, eax + 0x48]);     /* mov eax, [eax+0x48] */
            ii(0x100e_2afe, 5); calld(0x100d_7d74, -0xad8f);            /* call 0x100d7d74 */
            ii(0x100e_2b03, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100e_2b08, 5); calld(/* sys */ 0x1016_a24c, 0x8_773f); /* call 0x1016a24c */
            ii(0x100e_2b0d, 5); calld(0x100d_531c, -0xd7f6);            /* call 0x100d531c */
            ii(0x100e_2b12, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_2b17, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2b18, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_2b1d, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2b1e, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x100e_2b23, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x100e_2b28, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2b29, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100e_2b2e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2b2f, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x100e_2b34, 1); pushd(eax);                             /* push eax */
            ii(0x100e_2b35, 5); mov(ecx, 0x208);                        /* mov ecx, 0x208 */
            ii(0x100e_2b3a, 5); mov(ebx, StringDefinitions.MaterialInComplex); /* mov ebx, 0x101a1bd3 */
            ii(0x100e_2b3f, 4); movsx(edx, memw_a32[ss, ebp - 0x7c]);   /* movsx edx, word [ebp-0x7c] */
            ii(0x100e_2b43, 3); mov(eax, memd_a32[ss, ebp - 0x76]);     /* mov eax, [ebp-0x76] */
            ii(0x100e_2b46, 5); calld(0x100e_9ae5, 0x6f9a);             /* call 0x100e9ae5 */
            ii(0x100e_2b4b, 6); lea(eax, ebp - 0x1bc);                  /* lea eax, [ebp-0x1bc] */
            ii(0x100e_2b51, 5); calld(0x1007_20b1, -0x7_0aa5);          /* call 0x100720b1 */
            ii(0x100e_2b56, 6); lea(eax, ebp - 0x1c8);                  /* lea eax, [ebp-0x1c8] */
            ii(0x100e_2b5c, 5); calld(0x1007_20b1, -0x7_0ab0);          /* call 0x100720b1 */
            ii(0x100e_2b61, 6); lea(ebx, ebp - 0x1c8);                  /* lea ebx, [ebp-0x1c8] */
            ii(0x100e_2b67, 6); lea(edx, ebp - 0x1bc);                  /* lea edx, [ebp-0x1bc] */
            ii(0x100e_2b6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2b70, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2b73, 5); calld(0x1007_6574, -0x6_c604);          /* call 0x10076574 */
            ii(0x100e_2b78, 5); calld(0x1007_6204, -0x6_c979);          /* call 0x10076204 */
            ii(0x100e_2b7d, 5); calld(0x1014_3616, 0x6_0a94);           /* call 0x10143616 */
            ii(0x100e_2b82, 6); mov(eax, memd_a32[ss, ebp - 0x1ba]);    /* mov eax, [ebp-0x1ba] */
            ii(0x100e_2b88, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2b8b, 4); mov(memw_a32[ds, edx + 0x2a], ax);      /* mov [edx+0x2a], ax */
            ii(0x100e_2b8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_2b91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2b94, 5); calld(0x100e_3e05, 0x126c);             /* call 0x100e3e05 */
        l_0x100e_2b99:
            ii(0x100e_2b99, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100e_2b9d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100e_2ba0, 5); calld(0x1007_64fc, -0x6_c6a9);          /* call 0x100764fc */
            ii(0x100e_2ba5, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_2ba8, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100e_2bac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2baf, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2bb2, 5); calld(0x1007_6574, -0x6_c643);          /* call 0x10076574 */
            ii(0x100e_2bb7, 5); cmp(memw_a32[ds, eax + 0x8], 0xa);      /* cmp word [eax+0x8], 0xa */
            ii(0x100e_2bbc, 2); if(jnzd(0x100e_2bd6, 0x18)) goto l_0x100e_2bd6; /* jnz 0x100e2bd6 */
            ii(0x100e_2bbe, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100e_2bc3, 5); calld(0x1007_6338, -0x6_c890);          /* call 0x10076338 */
            ii(0x100e_2bc8, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x100e_2bcb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_2bcd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_2bcf, 5); calld(0x1007_643c, -0x6_c798);          /* call 0x1007643c */
            ii(0x100e_2bd4, 2); jmpd(0x100e_2bec, 0x16); goto l_0x100e_2bec; /* jmp 0x100e2bec */
        l_0x100e_2bd6:
            ii(0x100e_2bd6, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_2bdb, 5); calld(0x1007_6338, -0x6_c8a8);          /* call 0x10076338 */
            ii(0x100e_2be0, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x100e_2be3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_2be5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_2be7, 5); calld(0x1007_643c, -0x6_c7b0);          /* call 0x1007643c */
        l_0x100e_2bec:
            ii(0x100e_2bec, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100e_2bef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2bf2, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2bf5, 5); calld(0x1007_65d0, -0x6_c62a);          /* call 0x100765d0 */
            ii(0x100e_2bfa, 5); calld(0x1007_2eb4, -0x6_fd4b);          /* call 0x10072eb4 */
            ii(0x100e_2bff, 2); test(al, al);                           /* test al, al */
            ii(0x100e_2c01, 2); if(jzd(0x100e_2c22, 0x1f)) goto l_0x100e_2c22; /* jz 0x100e2c22 */
            ii(0x100e_2c03, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100e_2c06, 5); calld(0x1007_6408, -0x6_c803);          /* call 0x10076408 */
            ii(0x100e_2c0b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_2c0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c10, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_2c13, 5); calld(0x1008_ab1c, -0x5_80fc);          /* call 0x1008ab1c */
            ii(0x100e_2c18, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100e_2c1b, 5); calld(0x1007_6bf8, -0x6_c028);          /* call 0x10076bf8 */
            ii(0x100e_2c20, 2); jmpd(0x100e_2bec, -0x36); goto l_0x100e_2bec; /* jmp 0x100e2bec */
        l_0x100e_2c22:
            ii(0x100e_2c22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_2c24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c27, 5); calld(0x100e_41e7, 0x15bb);             /* call 0x100e41e7 */
            ii(0x100e_2c2c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c2f, 4); cmp(memd_a32[ds, eax + 0x4c], 0);       /* cmp dword [eax+0x4c], 0x0 */
            ii(0x100e_2c33, 2); if(jzd(0x100e_2c45, 0x10)) goto l_0x100e_2c45; /* jz 0x100e2c45 */
            ii(0x100e_2c35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c38, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2c3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c3d, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_2c40, 5); calld(0x100c_f85c, -0x1_33e9);          /* call 0x100cf85c */
        l_0x100e_2c45:
            ii(0x100e_2c45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c48, 4); cmp(memd_a32[ds, eax + 0x50], 0);       /* cmp dword [eax+0x50], 0x0 */
            ii(0x100e_2c4c, 2); if(jzd(0x100e_2c7e, 0x30)) goto l_0x100e_2c7e; /* jz 0x100e2c7e */
            ii(0x100e_2c4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c51, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2c53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c56, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_2c59, 5); calld(0x100c_f85c, -0x1_3402);          /* call 0x100cf85c */
            ii(0x100e_2c5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c61, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2c63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c66, 3); mov(eax, memd_a32[ds, eax + 0x54]);     /* mov eax, [eax+0x54] */
            ii(0x100e_2c69, 5); calld(0x100c_f85c, -0x1_3412);          /* call 0x100cf85c */
            ii(0x100e_2c6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c71, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2c73, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c76, 3); mov(eax, memd_a32[ds, eax + 0x58]);     /* mov eax, [eax+0x58] */
            ii(0x100e_2c79, 5); calld(0x100c_f85c, -0x1_3422);          /* call 0x100cf85c */
        l_0x100e_2c7e:
            ii(0x100e_2c7e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c81, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2c83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c86, 3); mov(eax, memd_a32[ds, eax + 0x5c]);     /* mov eax, [eax+0x5c] */
            ii(0x100e_2c89, 5); calld(0x100c_f85c, -0x1_3432);          /* call 0x100cf85c */
            ii(0x100e_2c8e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c91, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2c93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2c96, 3); mov(eax, memd_a32[ds, eax + 0x60]);     /* mov eax, [eax+0x60] */
            ii(0x100e_2c99, 5); calld(0x100c_f85c, -0x1_3442);          /* call 0x100cf85c */
            ii(0x100e_2c9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2ca1, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2ca3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2ca6, 3); mov(eax, memd_a32[ds, eax + 0x64]);     /* mov eax, [eax+0x64] */
            ii(0x100e_2ca9, 5); calld(0x100c_f85c, -0x1_3452);          /* call 0x100cf85c */
            ii(0x100e_2cae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2cb1, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_2cb3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2cb6, 3); mov(eax, memd_a32[ds, eax + 0x68]);     /* mov eax, [eax+0x68] */
            ii(0x100e_2cb9, 5); calld(0x100c_f85c, -0x1_3462);          /* call 0x100cf85c */
            ii(0x100e_2cbe, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_2cc5, 2); jmpd(0x100e_2ccd, 0x6); goto l_0x100e_2ccd; /* jmp 0x100e2ccd */
        l_0x100e_2cc7:
            ii(0x100e_2cc7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_2cca, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100e_2ccd:
            ii(0x100e_2ccd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_2cd0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_2cd3, 4); cmp(ax, memw_a32[ds, edx + 0x28]);      /* cmp ax, [edx+0x28] */
            ii(0x100e_2cd7, 2); if(jged(0x100e_2ced, 0x14)) goto l_0x100e_2ced; /* jge 0x100e2ced */
            ii(0x100e_2cd9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_2cdd, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_2ce0, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100e_2ce3, 3); mov(eax, memd_a32[ds, eax + 0x2c]);     /* mov eax, [eax+0x2c] */
            ii(0x100e_2ce6, 5); calld(0x100e_1544, -0x17a7);            /* call 0x100e1544 */
            ii(0x100e_2ceb, 2); jmpd(0x100e_2cc7, -0x26); goto l_0x100e_2cc7; /* jmp 0x100e2cc7 */
        l_0x100e_2ced:
            ii(0x100e_2ced, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2cf0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_2cf2, 5); calld(Definitions.sys_display_draw_0, 0x8_478d); /* call 0x10167484 */
            ii(0x100e_2cf7, 5); calld(/* sys */ 0x1016_bcc4, 0x8_8fc8); /* call 0x1016bcc4 */
            ii(0x100e_2cfc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_2cfe, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100e_2d01, 5); calld(0x1007_5f6c, -0x6_cd9a);          /* call 0x10075f6c */
            ii(0x100e_2d06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_2d09, 6); mov(memd_a32[ss, ebp - 0x1cc], eax);    /* mov [ebp-0x1cc], eax */
            ii(0x100e_2d0f, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100e_2d15, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_2d17, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_2d18, 1); popd(edi);                              /* pop edi */
            ii(0x100e_2d19, 1); popd(esi);                              /* pop esi */
            ii(0x100e_2d1a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_2d1b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_2d1c, 1); retd(); return;                         /* ret */
        }
    }
}
