using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5109cae6-081b-4caf-8257-e7bc0aa6f9c2")]
        public void Method_100a_0104()
        {
            ii(0x100a_0104, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100a_0109, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5c44); /* call 0x10165d52 */
            ii(0x100a_010e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_010f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_0110, 1); pushd(edi);                             /* push edi */
            ii(0x100a_0111, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_0112, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0114, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100a_011a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_011d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_0120, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_0123, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0126, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_0129, 5); calld(0x1007_6998, -0x2_9796);          /* call 0x10076998 */
            ii(0x100a_012e, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100a_0131, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_0134, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_0137, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_013a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_013d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_0140, 5); calld(0x1007_20b1, -0x2_e094);          /* call 0x100720b1 */
            ii(0x100a_0145, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_0148, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_014b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_014e, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x100a_0151, 5); calld(0x1007_20b1, -0x2_e0a5);          /* call 0x100720b1 */
            ii(0x100a_0156, 3); sub(eax, 0x12);                         /* sub eax, 0x12 */
            ii(0x100a_0159, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_015c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_015f, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_0162, 5); calld(0x1007_20b1, -0x2_e0b6);          /* call 0x100720b1 */
            ii(0x100a_0167, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100a_016a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_016d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0170, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_0173, 5); calld(0x1007_20b1, -0x2_e0c7);          /* call 0x100720b1 */
            ii(0x100a_0178, 3); sub(eax, 0x2a);                         /* sub eax, 0x2a */
            ii(0x100a_017b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_017e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0181, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x100a_0184, 5); calld(0x1007_20b1, -0x2_e0d8);          /* call 0x100720b1 */
            ii(0x100a_0189, 3); sub(eax, 0x36);                         /* sub eax, 0x36 */
            ii(0x100a_018c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_018f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0192, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_0195, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x2_9aaa); /* call 0x100766f0 */
            ii(0x100a_019a, 3); sub(eax, 0x44);                         /* sub eax, 0x44 */
            ii(0x100a_019d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_01a0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_01a3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_01a6, 5); calld(0x1008_b3ec, -0x1_4dbf);          /* call 0x1008b3ec */
            ii(0x100a_01ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_01ae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_01b1, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100a_01b4, 5); calld(0x1008_b1e4, -0x1_4fd5);          /* call 0x1008b1e4 */
            ii(0x100a_01b9, 3); sub(eax, 0x48);                         /* sub eax, 0x48 */
            ii(0x100a_01bc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_01bf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_01c2, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_01c5, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100a_01c9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_01cc, 5); calld(0x1007_64fc, -0x2_9cd5);          /* call 0x100764fc */
            ii(0x100a_01d1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_01d4, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100a_01d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_01db, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_01de, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100a_01e1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_01e4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_01e7, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_01ea, 5); calld(0x100a_b2a8, 0xb0b9);             /* call 0x100ab2a8 */
            ii(0x100a_01ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_01f2, 4); mov(memb_a32[ds, eax + 0x4d], 0);       /* mov byte [eax+0x4d], 0x0 */
            ii(0x100a_01f6, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_01fb, 5); calld(0x1007_6338, -0x2_9ec8);          /* call 0x10076338 */
            ii(0x100a_0200, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0202, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0205, 5); calld(0x1007_643c, -0x2_9dce);          /* call 0x1007643c */
            ii(0x100a_020a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_020d, 9); mov(memw_a32[ds, eax + 0x373], 0);      /* mov word [eax+0x373], 0x0 */
            ii(0x100a_0216, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0219, 9); mov(memw_a32[ds, eax + 0x36f], 0);      /* mov word [eax+0x36f], 0x0 */
            ii(0x100a_0222, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0225, 9); mov(memw_a32[ds, eax + 0x371], 0);      /* mov word [eax+0x371], 0x0 */
            ii(0x100a_022e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0231, 9); mov(memw_a32[ds, eax + 0x36d], 0);      /* mov word [eax+0x36d], 0x0 */
        l_0x100a_023a:
            ii(0x100a_023a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_023c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_023f, 5); calld(0x1013_ad71, 0x9_ab2d);           /* call 0x1013ad71 */
            ii(0x100a_0244, 2); test(al, al);                           /* test al, al */
            ii(0x100a_0246, 6); if(jzd(0x100a_0486, 0x23a)) goto l_0x100a_0486; /* jz 0x100a0486 */
            ii(0x100a_024c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_024f, 5); calld(0x1007_63a0, -0x2_9eb4);          /* call 0x100763a0 */
            ii(0x100a_0254, 5); calld(0x1007_6204, -0x2_a055);          /* call 0x10076204 */
            ii(0x100a_0259, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100a_025c, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x100a_025f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0261, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_0263, 5); calld(0x1007_6e00, -0x2_9468);          /* call 0x10076e00 */
            ii(0x100a_0268, 2); test(al, al);                           /* test al, al */
            ii(0x100a_026a, 6); if(jzd(0x100a_0479, 0x209)) goto l_0x100a_0479; /* jz 0x100a0479 */
            ii(0x100a_0270, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_0273, 5); calld(0x1007_20b1, -0x2_e1c7);          /* call 0x100720b1 */
            ii(0x100a_0278, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100a_027b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_027e, 5); calld(0x1007_6408, -0x2_9e7b);          /* call 0x10076408 */
            ii(0x100a_0283, 5); calld(0x1007_21b6, -0x2_e0d2);          /* call 0x100721b6 */
            ii(0x100a_0288, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_028a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_028d, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x100a_0290, 5); calld(0x1007_213f, -0x2_e156);          /* call 0x1007213f */
            ii(0x100a_0295, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100a_0298, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_029b, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_029e, 5); calld(0x1007_213f, -0x2_e164);          /* call 0x1007213f */
            ii(0x100a_02a3, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_02a8, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100a_02ab, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_02ae, 5); calld(0x1007_6408, -0x2_9eab);          /* call 0x10076408 */
            ii(0x100a_02b3, 5); calld(0x1007_2388, -0x2_df30);          /* call 0x10072388 */
            ii(0x100a_02b8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_02ba, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_02bd, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_02c0, 5); calld(0x1007_213f, -0x2_e186);          /* call 0x1007213f */
            ii(0x100a_02c5, 4); movsx(eax, memw_a32[ss, ebp - 0x2e]);   /* movsx eax, word [ebp-0x2e] */
            ii(0x100a_02c9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_02cb, 2); if(jled(0x100a_02d7, 0xa)) goto l_0x100a_02d7; /* jle 0x100a02d7 */
            ii(0x100a_02cd, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x100a_02d0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_02d3, 4); add(memw_a32[ds, edx + 0x20], ax);      /* add [edx+0x20], ax */
        l_0x100a_02d7:
            ii(0x100a_02d7, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100a_02db, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_02dd, 2); if(jled(0x100a_02e9, 0xa)) goto l_0x100a_02e9; /* jle 0x100a02e9 */
            ii(0x100a_02df, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_02e2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_02e5, 4); add(memw_a32[ds, edx + 0x22], ax);      /* add [edx+0x22], ax */
        l_0x100a_02e9:
            ii(0x100a_02e9, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100a_02ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_02ef, 2); if(jled(0x100a_02fb, 0xa)) goto l_0x100a_02fb; /* jle 0x100a02fb */
            ii(0x100a_02f1, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_02f4, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_02f7, 4); add(memw_a32[ds, edx + 0x1e], ax);      /* add [edx+0x1e], ax */
        l_0x100a_02fb:
            ii(0x100a_02fb, 4); movsx(eax, memw_a32[ss, ebp - 0x2a]);   /* movsx eax, word [ebp-0x2a] */
            ii(0x100a_02ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_0301, 2); if(jled(0x100a_030d, 0xa)) goto l_0x100a_030d; /* jle 0x100a030d */
            ii(0x100a_0303, 3); mov(eax, memd_a32[ss, ebp - 0x2a]);     /* mov eax, [ebp-0x2a] */
            ii(0x100a_0306, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0309, 4); add(memw_a32[ds, edx + 0x24], ax);      /* add [edx+0x24], ax */
        l_0x100a_030d:
            ii(0x100a_030d, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100a_0311, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_0313, 2); if(jled(0x100a_031f, 0xa)) goto l_0x100a_031f; /* jle 0x100a031f */
            ii(0x100a_0315, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_0318, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_031b, 4); add(memw_a32[ds, edx + 0x26], ax);      /* add [edx+0x26], ax */
        l_0x100a_031f:
            ii(0x100a_031f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0322, 5); calld(0x1007_63a0, -0x2_9f87);          /* call 0x100763a0 */
            ii(0x100a_0327, 5); cmp(memw_a32[ds, eax + 0x8], 0x2);      /* cmp word [eax+0x8], 0x2 */
            ii(0x100a_032c, 2); if(jnzd(0x100a_033c, 0xe)) goto l_0x100a_033c; /* jnz 0x100a033c */
            ii(0x100a_032e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0331, 5); calld(0x1007_63a0, -0x2_9f96);          /* call 0x100763a0 */
            ii(0x100a_0336, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_033a, 2); if(jnzd(0x100a_033e, 0x2)) goto l_0x100a_033e; /* jnz 0x100a033e */
        l_0x100a_033c:
            ii(0x100a_033c, 2); jmpd(0x100a_0360, 0x22); goto l_0x100a_0360; /* jmp 0x100a0360 */
        l_0x100a_033e:
            ii(0x100a_033e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0341, 5); calld(0x1007_63a0, -0x2_9fa6);          /* call 0x100763a0 */
            ii(0x100a_0346, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100a_034a, 2); if(jnzd(0x100a_0356, 0xa)) goto l_0x100a_0356; /* jnz 0x100a0356 */
            ii(0x100a_034c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_034f, 7); inc(memw_a32[ds, eax + 0x373]);         /* inc word [eax+0x373] */
        l_0x100a_0356:
            ii(0x100a_0356, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0359, 7); inc(memw_a32[ds, eax + 0x36f]);         /* inc word [eax+0x36f] */
        l_0x100a_0360:
            ii(0x100a_0360, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0363, 5); calld(0x1007_63a0, -0x2_9fc8);          /* call 0x100763a0 */
            ii(0x100a_0368, 5); cmp(memw_a32[ds, eax + 0x8], 0x1);      /* cmp word [eax+0x8], 0x1 */
            ii(0x100a_036d, 2); if(jnzd(0x100a_037d, 0xe)) goto l_0x100a_037d; /* jnz 0x100a037d */
            ii(0x100a_036f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0372, 5); calld(0x1007_63a0, -0x2_9fd7);          /* call 0x100763a0 */
            ii(0x100a_0377, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_037b, 2); if(jnzd(0x100a_037f, 0x2)) goto l_0x100a_037f; /* jnz 0x100a037f */
        l_0x100a_037d:
            ii(0x100a_037d, 2); jmpd(0x100a_03a1, 0x22); goto l_0x100a_03a1; /* jmp 0x100a03a1 */
        l_0x100a_037f:
            ii(0x100a_037f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0382, 5); calld(0x1007_63a0, -0x2_9fe7);          /* call 0x100763a0 */
            ii(0x100a_0387, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100a_038b, 2); if(jnzd(0x100a_0397, 0xa)) goto l_0x100a_0397; /* jnz 0x100a0397 */
            ii(0x100a_038d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0390, 7); inc(memw_a32[ds, eax + 0x371]);         /* inc word [eax+0x371] */
        l_0x100a_0397:
            ii(0x100a_0397, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_039a, 7); inc(memw_a32[ds, eax + 0x36d]);         /* inc word [eax+0x36d] */
        l_0x100a_03a1:
            ii(0x100a_03a1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_03a4, 5); calld(0x1007_63a0, -0x2_a009);          /* call 0x100763a0 */
            ii(0x100a_03a9, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100a_03ae, 2); if(jnzd(0x100a_03ce, 0x1e)) goto l_0x100a_03ce; /* jnz 0x100a03ce */
            ii(0x100a_03b0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_03b3, 5); calld(0x1007_63a0, -0x2_a018);          /* call 0x100763a0 */
            ii(0x100a_03b8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100a_03bc, 2); if(jzd(0x100a_03cc, 0xe)) goto l_0x100a_03cc; /* jz 0x100a03cc */
            ii(0x100a_03be, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_03c1, 5); calld(0x1007_63a0, -0x2_a026);          /* call 0x100763a0 */
            ii(0x100a_03c6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x6);     /* cmp byte [eax+0x3d], 0x6 */
            ii(0x100a_03ca, 2); if(jnzd(0x100a_03ce, 0x2)) goto l_0x100a_03ce; /* jnz 0x100a03ce */
        l_0x100a_03cc:
            ii(0x100a_03cc, 2); jmpd(0x100a_03d3, 0x5); goto l_0x100a_03d3; /* jmp 0x100a03d3 */
        l_0x100a_03ce:
            ii(0x100a_03ce, 5); jmpd(0x100a_0479, 0xa6); goto l_0x100a_0479; /* jmp 0x100a0479 */
        l_0x100a_03d3:
            ii(0x100a_03d3, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x100a_03d8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_03db, 5); calld(0x1007_63a0, -0x2_a040);          /* call 0x100763a0 */
            ii(0x100a_03e0, 3); mov(al, memb_a32[ds, eax + 0x4a]);      /* mov al, [eax+0x4a] */
            ii(0x100a_03e3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_03e8, 5); calld(Definitions.my_min, -0x1_6c69);   /* call 0x10089784 */
            ii(0x100a_03ed, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_03f0, 4); add(memw_a32[ds, edx + 0x38], ax);      /* add [edx+0x38], ax */
            ii(0x100a_03f4, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x100a_03f9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_03fc, 5); calld(0x1007_63a0, -0x2_a061);          /* call 0x100763a0 */
            ii(0x100a_0401, 3); mov(al, memb_a32[ds, eax + 0x4c]);      /* mov al, [eax+0x4c] */
            ii(0x100a_0404, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_0409, 5); calld(Definitions.my_min, -0x1_6c8a);   /* call 0x10089784 */
            ii(0x100a_040e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0411, 4); add(memw_a32[ds, edx + 0x3a], ax);      /* add [edx+0x3a], ax */
            ii(0x100a_0415, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x100a_041a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_041d, 5); calld(0x1007_63a0, -0x2_a082);          /* call 0x100763a0 */
            ii(0x100a_0422, 3); mov(al, memb_a32[ds, eax + 0x4b]);      /* mov al, [eax+0x4b] */
            ii(0x100a_0425, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_042a, 5); calld(Definitions.my_min, -0x1_6cab);   /* call 0x10089784 */
            ii(0x100a_042f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0432, 4); add(memw_a32[ds, edx + 0x36], ax);      /* add [edx+0x36], ax */
            ii(0x100a_0436, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0439, 5); calld(0x1007_63a0, -0x2_a09e);          /* call 0x100763a0 */
            ii(0x100a_043e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_0440, 3); mov(dl, memb_a32[ds, eax + 0x4a]);      /* mov dl, [eax+0x4a] */
            ii(0x100a_0443, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0446, 5); calld(0x1007_63a0, -0x2_a0ab);          /* call 0x100763a0 */
            ii(0x100a_044b, 3); mov(al, memb_a32[ds, eax + 0x4c]);      /* mov al, [eax+0x4c] */
            ii(0x100a_044e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_0450, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0452, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_0455, 5); calld(0x1007_63a0, -0x2_a0ba);          /* call 0x100763a0 */
            ii(0x100a_045a, 3); mov(al, memb_a32[ds, eax + 0x4b]);      /* mov al, [eax+0x4b] */
            ii(0x100a_045d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_045f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0461, 3); mov(memd_a32[ss, ebp - 0x34], edx);     /* mov [ebp-0x34], edx */
            ii(0x100a_0464, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x100a_0469, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x100a_046d, 5); calld(Definitions.my_min, -0x1_6cee);   /* call 0x10089784 */
            ii(0x100a_0472, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0475, 4); mov(memw_a32[ds, edx + 0x42], ax);      /* mov [edx+0x42], ax */
        l_0x100a_0479:
            ii(0x100a_0479, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_047c, 5); calld(0x1007_6bf8, -0x2_9889);          /* call 0x10076bf8 */
            ii(0x100a_0481, 5); jmpd(0x100a_023a, -0x24c); goto l_0x100a_023a; /* jmp 0x100a023a */
        l_0x100a_0486:
            ii(0x100a_0486, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0489, 3); add(edx, 0x1e);                         /* add edx, 0x1e */
            ii(0x100a_048c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_048f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_0492, 5); calld(0x100a_9f78, 0x9ae1);             /* call 0x100a9f78 */
            ii(0x100a_0497, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_0499, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_049c, 5); calld(0x1007_5f6c, -0x2_a535);          /* call 0x10075f6c */
            ii(0x100a_04a1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_04a4, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100a_04a7, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100a_04aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_04ac, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_04ad, 1); popd(edi);                              /* pop edi */
            ii(0x100a_04ae, 1); popd(esi);                              /* pop esi */
            ii(0x100a_04af, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_04b0, 1); retd(); return;                         /* ret */
        }
    }
}
