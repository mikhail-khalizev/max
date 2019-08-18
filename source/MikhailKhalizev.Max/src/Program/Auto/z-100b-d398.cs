using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_d398-83d7e20e")]
        public void Method_100b_d398()
        {
            ii(0x100b_d398, 5); pushd(0xd8);                            /* push 0xd8 */
            ii(0x100b_d39d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_89b0); /* call 0x10165d52 */
            ii(0x100b_d3a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_d3a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_d3a4, 1); pushd(edx);                             /* push edx */
            ii(0x100b_d3a5, 1); pushd(esi);                             /* push esi */
            ii(0x100b_d3a6, 1); pushd(edi);                             /* push edi */
            ii(0x100b_d3a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_d3a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_d3aa, 6); sub(esp, 0xbc);                         /* sub esp, 0xbc */
            ii(0x100b_d3b0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_d3b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_d3b6, 4); cmp(memd_a32[ds, eax + 0x63], 0);       /* cmp dword [eax+0x63], 0x0 */
            ii(0x100b_d3ba, 2); if(jzd(0x100b_d3c9, 0xd)) goto l_0x100b_d3c9; /* jz 0x100bd3c9 */
            ii(0x100b_d3bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_d3bf, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x100b_d3c2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_d3c5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_d3c7, 2); if(jgd(0x100b_d3ce, 0x5)) goto l_0x100b_d3ce; /* jg 0x100bd3ce */
        l_0x100b_d3c9:
            ii(0x100b_d3c9, 5); jmpd(0x100b_de90, 0xac2); goto l_0x100b_de90; /* jmp 0x100bde90 */
        l_0x100b_d3ce:
            ii(0x100b_d3ce, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_d3d2, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_d3d5, 5); calld(0x1008_bbed, -0x3_17ed);          /* call 0x1008bbed */
            ii(0x100b_d3da, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100b_d3dd, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_d3e1, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_d3e6, 5); calld(0x1007_6338, -0x4_70b3);          /* call 0x10076338 */
            ii(0x100b_d3eb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d3ed, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d3f0, 5); calld(0x1007_64b8, -0x4_6f3d);          /* call 0x100764b8 */
            ii(0x100b_d3f5, 2); jmpd(0x100b_d3ff, 0x8); goto l_0x100b_d3ff; /* jmp 0x100bd3ff */
        l_0x100b_d3f7:
            ii(0x100b_d3f7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d3fa, 5); calld(0x1007_6bf8, -0x4_6807);          /* call 0x10076bf8 */
        l_0x100b_d3ff:
            ii(0x100b_d3ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d401, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d404, 5); calld(0x1013_ad71, 0x7_d968);           /* call 0x1013ad71 */
            ii(0x100b_d409, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d40b, 6); if(jzd(0x100b_d5e5, 0x1d4)) goto l_0x100b_d5e5; /* jz 0x100bd5e5 */
            ii(0x100b_d411, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d414, 5); calld(0x1007_63a0, -0x4_7079);          /* call 0x100763a0 */
            ii(0x100b_d419, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d41b, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_d41e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_d421, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_d424, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_d426, 6); if(jnzd(0x100b_d5e0, 0x1b4)) goto l_0x100b_d5e0; /* jnz 0x100bd5e0 */
            ii(0x100b_d42c, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d42f, 5); calld(0x1007_63a0, -0x4_7094);          /* call 0x100763a0 */
            ii(0x100b_d434, 5); cmp(memw_a32[ds, eax + 0x8], 0x22);     /* cmp word [eax+0x8], 0x22 */
            ii(0x100b_d439, 2); if(jzd(0x100b_d44a, 0xf)) goto l_0x100b_d44a; /* jz 0x100bd44a */
            ii(0x100b_d43b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d43e, 5); calld(0x1007_63a0, -0x4_70a3);          /* call 0x100763a0 */
            ii(0x100b_d443, 5); cmp(memw_a32[ds, eax + 0x8], 0x25);     /* cmp word [eax+0x8], 0x25 */
            ii(0x100b_d448, 2); if(jnzd(0x100b_d44c, 0x2)) goto l_0x100b_d44c; /* jnz 0x100bd44c */
        l_0x100b_d44a:
            ii(0x100b_d44a, 2); jmpd(0x100b_d45f, 0x13); goto l_0x100b_d45f; /* jmp 0x100bd45f */
        l_0x100b_d44c:
            ii(0x100b_d44c, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d44f, 5); calld(0x1007_63a0, -0x4_70b4);          /* call 0x100763a0 */
            ii(0x100b_d454, 5); cmp(memw_a32[ds, eax + 0x8], 0x24);     /* cmp word [eax+0x8], 0x24 */
            ii(0x100b_d459, 6); if(jnzd(0x100b_d520, 0xc1)) goto l_0x100b_d520; /* jnz 0x100bd520 */
        l_0x100b_d45f:
            ii(0x100b_d45f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d462, 5); calld(0x1007_63a0, -0x4_70c7);          /* call 0x100763a0 */
            ii(0x100b_d467, 5); calld(0x1007_623c, -0x4_7230);          /* call 0x1007623c */
            ii(0x100b_d46c, 3); mov(ecx, memd_a32[ds, eax + 0x10]);     /* mov ecx, [eax+0x10] */
            ii(0x100b_d46f, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100b_d472, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d475, 5); calld(0x1007_63a0, -0x4_70da);          /* call 0x100763a0 */
            ii(0x100b_d47a, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_d47d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_d480, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d483, 5); calld(0x1007_63a0, -0x4_70e8);          /* call 0x100763a0 */
            ii(0x100b_d488, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_d48b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d48e, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_d491, 5); calld(0x1007_6aac, -0x4_69ea);          /* call 0x10076aac */
            ii(0x100b_d496, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d498, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_d49b, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100b_d49d, 5); calld(0x100a_95c1, -0x1_3ee1);          /* call 0x100a95c1 */
            ii(0x100b_d4a2, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d4a5, 5); calld(0x1007_63a0, -0x4_710a);          /* call 0x100763a0 */
            ii(0x100b_d4aa, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x100b_d4ad, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d4b0, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d4b3, 5); calld(0x1007_63a0, -0x4_7118);          /* call 0x100763a0 */
            ii(0x100b_d4b8, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100b_d4bb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_d4be, 5); calld(0x1007_3cfd, -0x4_97c6);          /* call 0x10073cfd */
            ii(0x100b_d4c3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100b_d4c6:
            ii(0x100b_d4c6, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_d4c9, 5); calld(0x1008_982c, -0x3_3ca2);          /* call 0x1008982c */
            ii(0x100b_d4ce, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_d4d1, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_d4d4, 5); calld(0x1008_9860, -0x3_3c79);          /* call 0x10089860 */
            ii(0x100b_d4d9, 1); cwde();                                 /* cwde */
            ii(0x100b_d4da, 5); calld(0x1007_3cfd, -0x4_97e2);          /* call 0x10073cfd */
            ii(0x100b_d4df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d4e1, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x100b_d4e4, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100b_d4e8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_d4ea, 2); if(jnzd(0x100b_d50f, 0x23)) goto l_0x100b_d50f; /* jnz 0x100bd50f */
            ii(0x100b_d4ec, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_d4ef, 5); calld(0x1008_982c, -0x3_3cc8);          /* call 0x1008982c */
            ii(0x100b_d4f4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_d4f7, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_d4fa, 5); calld(0x1008_9860, -0x3_3c9f);          /* call 0x10089860 */
            ii(0x100b_d4ff, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_d502, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_d505, 5); calld(0x1008_a728, -0x3_2de2);          /* call 0x1008a728 */
            ii(0x100b_d50a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_d50c, 3); mov(memb_a32[ds, eax], 0x1);            /* mov byte [eax], 0x1 */
        l_0x100b_d50f:
            ii(0x100b_d50f, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_d512, 5); calld(0x100a_96db, -0x1_3e3c);          /* call 0x100a96db */
            ii(0x100b_d517, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d519, 2); if(jnzd(0x100b_d4c6, -0x55)) goto l_0x100b_d4c6; /* jnz 0x100bd4c6 */
            ii(0x100b_d51b, 5); jmpd(0x100b_d5e0, 0xc0); goto l_0x100b_d5e0; /* jmp 0x100bd5e0 */
        l_0x100b_d520:
            ii(0x100b_d520, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d523, 5); calld(0x1007_63a0, -0x4_7188);          /* call 0x100763a0 */
            ii(0x100b_d528, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100b_d52c, 6); if(jzd(0x100b_d5e0, 0xae)) goto l_0x100b_d5e0; /* jz 0x100bd5e0 */
            ii(0x100b_d532, 5); mov(ecx, 0x8);                          /* mov ecx, 0x8 */
            ii(0x100b_d537, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d53a, 5); calld(0x1007_63a0, -0x4_719f);          /* call 0x100763a0 */
            ii(0x100b_d53f, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_d542, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_d545, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d548, 5); calld(0x1007_63a0, -0x4_71ad);          /* call 0x100763a0 */
            ii(0x100b_d54d, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_d550, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d553, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_d556, 5); calld(0x1007_6aac, -0x4_6aaf);          /* call 0x10076aac */
            ii(0x100b_d55b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d55d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_d560, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100b_d562, 5); calld(0x100a_95c1, -0x1_3fa6);          /* call 0x100a95c1 */
            ii(0x100b_d567, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d56a, 5); calld(0x1007_63a0, -0x4_71cf);          /* call 0x100763a0 */
            ii(0x100b_d56f, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x100b_d572, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d575, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d578, 5); calld(0x1007_63a0, -0x4_71dd);          /* call 0x100763a0 */
            ii(0x100b_d57d, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100b_d580, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_d583, 5); calld(0x1007_3cfd, -0x4_988b);          /* call 0x10073cfd */
            ii(0x100b_d588, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100b_d58b:
            ii(0x100b_d58b, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_d58e, 5); calld(0x1008_982c, -0x3_3d67);          /* call 0x1008982c */
            ii(0x100b_d593, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_d596, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_d599, 5); calld(0x1008_9860, -0x3_3d3e);          /* call 0x10089860 */
            ii(0x100b_d59e, 1); cwde();                                 /* cwde */
            ii(0x100b_d59f, 5); calld(0x1007_3cfd, -0x4_98a7);          /* call 0x10073cfd */
            ii(0x100b_d5a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d5a6, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x100b_d5a9, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100b_d5ad, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_d5af, 2); if(jnzd(0x100b_d5d4, 0x23)) goto l_0x100b_d5d4; /* jnz 0x100bd5d4 */
            ii(0x100b_d5b1, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_d5b4, 5); calld(0x1008_982c, -0x3_3d8d);          /* call 0x1008982c */
            ii(0x100b_d5b9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_d5bc, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_d5bf, 5); calld(0x1008_9860, -0x3_3d64);          /* call 0x10089860 */
            ii(0x100b_d5c4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_d5c7, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_d5ca, 5); calld(0x1008_a728, -0x3_2ea7);          /* call 0x1008a728 */
            ii(0x100b_d5cf, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_d5d1, 3); mov(memb_a32[ds, eax], 0x1);            /* mov byte [eax], 0x1 */
        l_0x100b_d5d4:
            ii(0x100b_d5d4, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100b_d5d7, 5); calld(0x100a_96db, -0x1_3f01);          /* call 0x100a96db */
            ii(0x100b_d5dc, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d5de, 2); if(jnzd(0x100b_d58b, -0x55)) goto l_0x100b_d58b; /* jnz 0x100bd58b */
        l_0x100b_d5e0:
            ii(0x100b_d5e0, 5); jmpd(0x100b_d3f7, -0x1ee); goto l_0x100b_d3f7; /* jmp 0x100bd3f7 */
        l_0x100b_d5e5:
            ii(0x100b_d5e5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_d5ea, 5); calld(0x1008_a768, -0x3_2e87);          /* call 0x1008a768 */
            ii(0x100b_d5ef, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x100b_d5f2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d5f4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_d5f6, 5); calld(0x1008_ae70, -0x3_278b);          /* call 0x1008ae70 */
            ii(0x100b_d5fb, 2); jmpd(0x100b_d605, 0x8); goto l_0x100b_d605; /* jmp 0x100bd605 */
        l_0x100b_d5fd:
            ii(0x100b_d5fd, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d600, 5); calld(0x1007_6bf8, -0x4_6a0d);          /* call 0x10076bf8 */
        l_0x100b_d605:
            ii(0x100b_d605, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d607, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d60a, 5); calld(0x1013_ad71, 0x7_d762);           /* call 0x1013ad71 */
            ii(0x100b_d60f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d611, 6); if(jzd(0x100b_d72c, 0x115)) goto l_0x100b_d72c; /* jz 0x100bd72c */
            ii(0x100b_d617, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d61a, 5); calld(0x1008_adc4, -0x3_285b);          /* call 0x1008adc4 */
            ii(0x100b_d61f, 5); calld(0x1008_ad90, -0x3_2894);          /* call 0x1008ad90 */
            ii(0x100b_d624, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d626, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_d629, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100b_d62c, 2); if(jnzd(0x100b_d649, 0x1b)) goto l_0x100b_d649; /* jnz 0x100bd649 */
            ii(0x100b_d62e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d631, 5); calld(0x1008_adc4, -0x3_2872);          /* call 0x1008adc4 */
            ii(0x100b_d636, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100b_d639, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100b_d63c, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_d63f, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100b_d642, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_d645, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x100b_d647, 2); if(jzd(0x100b_d64e, 0x5)) goto l_0x100b_d64e; /* jz 0x100bd64e */
        l_0x100b_d649:
            ii(0x100b_d649, 5); jmpd(0x100b_d727, 0xd9); goto l_0x100b_d727; /* jmp 0x100bd727 */
        l_0x100b_d64e:
            ii(0x100b_d64e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d651, 5); calld(0x1008_adf8, -0x3_285e);          /* call 0x1008adf8 */
            ii(0x100b_d656, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100b_d659, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100b_d65c, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100b_d65f, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x100b_d662, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_d665, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x100b_d668, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x100b_d66b, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d66d, 2); if(jzd(0x100b_d684, 0x15)) goto l_0x100b_d684; /* jz 0x100bd684 */
            ii(0x100b_d66f, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100b_d672, 5); calld(0x1009_c4c4, -0x2_11b3);          /* call 0x1009c4c4 */
            ii(0x100b_d677, 1); cwde();                                 /* cwde */
            ii(0x100b_d678, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_d67b, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x100b_d682, 2); if(jnzd(0x100b_d689, 0x5)) goto l_0x100b_d689; /* jnz 0x100bd689 */
        l_0x100b_d684:
            ii(0x100b_d684, 5); jmpd(0x100b_d727, 0x9e); goto l_0x100b_d727; /* jmp 0x100bd727 */
        l_0x100b_d689:
            ii(0x100b_d689, 3); lea(edx, ebp - 0x74);                   /* lea edx, [ebp-0x74] */
            ii(0x100b_d68c, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100b_d68f, 5); calld(0x100a_2d3d, -0x1_a957);          /* call 0x100a2d3d */
            ii(0x100b_d694, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100b_d699, 3); lea(edx, ebp - 0x74);                   /* lea edx, [ebp-0x74] */
            ii(0x100b_d69c, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x100b_d69f, 5); calld(0x1007_5e64, -0x4_7840);          /* call 0x10075e64 */
            ii(0x100b_d6a4, 6); lea(ecx, ebp - 0x88);                   /* lea ecx, [ebp-0x88] */
            ii(0x100b_d6aa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d6ac, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_d6ae, 5); calld(0x100a_95c1, -0x1_40f2);          /* call 0x100a95c1 */
            ii(0x100b_d6b3, 4); movsx(edx, memw_a32[ss, ebp - 0x72]);   /* movsx edx, word [ebp-0x72] */
            ii(0x100b_d6b7, 4); movsx(eax, memw_a32[ss, ebp - 0x74]);   /* movsx eax, word [ebp-0x74] */
            ii(0x100b_d6bb, 5); calld(0x1007_3cfd, -0x4_99c3);          /* call 0x10073cfd */
            ii(0x100b_d6c0, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100b_d6c3:
            ii(0x100b_d6c3, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_d6c9, 5); calld(0x1008_982c, -0x3_3ea2);          /* call 0x1008982c */
            ii(0x100b_d6ce, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_d6d1, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_d6d7, 5); calld(0x1008_9860, -0x3_3e7c);          /* call 0x10089860 */
            ii(0x100b_d6dc, 1); cwde();                                 /* cwde */
            ii(0x100b_d6dd, 5); calld(0x1007_3cfd, -0x4_99e5);          /* call 0x10073cfd */
            ii(0x100b_d6e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d6e4, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x100b_d6e7, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100b_d6eb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_d6ed, 2); if(jnzd(0x100b_d718, 0x29)) goto l_0x100b_d718; /* jnz 0x100bd718 */
            ii(0x100b_d6ef, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_d6f5, 5); calld(0x1008_982c, -0x3_3ece);          /* call 0x1008982c */
            ii(0x100b_d6fa, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_d6fd, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_d703, 5); calld(0x1008_9860, -0x3_3ea8);          /* call 0x10089860 */
            ii(0x100b_d708, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_d70b, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_d70e, 5); calld(0x1008_a728, -0x3_2feb);          /* call 0x1008a728 */
            ii(0x100b_d713, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_d715, 3); mov(memb_a32[ds, eax], 0x1);            /* mov byte [eax], 0x1 */
        l_0x100b_d718:
            ii(0x100b_d718, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_d71e, 5); calld(0x100a_96db, -0x1_4048);          /* call 0x100a96db */
            ii(0x100b_d723, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d725, 2); if(jnzd(0x100b_d6c3, -0x64)) goto l_0x100b_d6c3; /* jnz 0x100bd6c3 */
        l_0x100b_d727:
            ii(0x100b_d727, 5); jmpd(0x100b_d5fd, -0x12f); goto l_0x100b_d5fd; /* jmp 0x100bd5fd */
        l_0x100b_d72c:
            ii(0x100b_d72c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_d731, 5); calld(0x1008_a768, -0x3_2fce);          /* call 0x1008a768 */
            ii(0x100b_d736, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x100b_d739, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d73b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_d73d, 5); calld(0x100a_b1f8, -0x1_254a);          /* call 0x100ab1f8 */
            ii(0x100b_d742, 2); jmpd(0x100b_d74c, 0x8); goto l_0x100b_d74c; /* jmp 0x100bd74c */
        l_0x100b_d744:
            ii(0x100b_d744, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d747, 5); calld(0x1007_6bf8, -0x4_6b54);          /* call 0x10076bf8 */
        l_0x100b_d74c:
            ii(0x100b_d74c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d74e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d751, 5); calld(0x1013_ad71, 0x7_d61b);           /* call 0x1013ad71 */
            ii(0x100b_d756, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d758, 6); if(jzd(0x100b_d8c4, 0x166)) goto l_0x100b_d8c4; /* jz 0x100bd8c4 */
            ii(0x100b_d75e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d761, 5); calld(0x1008_adc4, -0x3_29a2);          /* call 0x1008adc4 */
            ii(0x100b_d766, 5); calld(0x1008_ad90, -0x3_29db);          /* call 0x1008ad90 */
            ii(0x100b_d76b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d76d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_d770, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100b_d773, 2); if(jnzd(0x100b_d799, 0x24)) goto l_0x100b_d799; /* jnz 0x100bd799 */
            ii(0x100b_d775, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d778, 5); calld(0x1008_adc4, -0x3_29b9);          /* call 0x1008adc4 */
            ii(0x100b_d77d, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x100b_d783, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100b_d789, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_d78c, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100b_d792, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_d795, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x100b_d797, 2); if(jzd(0x100b_d79e, 0x5)) goto l_0x100b_d79e; /* jz 0x100bd79e */
        l_0x100b_d799:
            ii(0x100b_d799, 5); jmpd(0x100b_d8bf, 0x121); goto l_0x100b_d8bf; /* jmp 0x100bd8bf */
        l_0x100b_d79e:
            ii(0x100b_d79e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_d7a1, 5); calld(0x1008_adf8, -0x3_29ae);          /* call 0x1008adf8 */
            ii(0x100b_d7a6, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x100b_d7ac, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100b_d7b2, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x100b_d7b8, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100b_d7be, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_d7c1, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100b_d7c7, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x100b_d7ca, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d7cc, 6); if(jzd(0x100b_d8bf, 0xed)) goto l_0x100b_d8bf; /* jz 0x100bd8bf */
            ii(0x100b_d7d2, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100b_d7d8, 6); mov(memd_a32[ss, ebp - 0x98], eax);     /* mov [ebp-0x98], eax */
            ii(0x100b_d7de, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100b_d7e4, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_d7e7, 6); lea(edx, ebp - 0xa8);                   /* lea edx, [ebp-0xa8] */
            ii(0x100b_d7ed, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100b_d7f3, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x100b_d7f6, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100b_d7fc, 5); calld(0x1009_c4c4, -0x2_133d);          /* call 0x1009c4c4 */
            ii(0x100b_d801, 1); cwde();                                 /* cwde */
            ii(0x100b_d802, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_d805, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x100b_d80c, 2); if(jzd(0x100b_d874, 0x66)) goto l_0x100b_d874; /* jz 0x100bd874 */
            ii(0x100b_d80e, 6); mov(edx, memd_a32[ss, ebp - 0xa8]);     /* mov edx, [ebp-0xa8] */
            ii(0x100b_d814, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x100b_d817, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_d819, 5); calld(0x1007_6e7c, -0x4_69a2);          /* call 0x10076e7c */
            ii(0x100b_d81e, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100b_d824, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_d82a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d82d, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100b_d833, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100b_d836, 5); calld(Definitions.my_min, -0x3_40b7);   /* call 0x10089784 */
            ii(0x100b_d83b, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x100b_d841, 6); mov(edx, memd_a32[ss, ebp - 0xa4]);     /* mov edx, [ebp-0xa4] */
            ii(0x100b_d847, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x100b_d84a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_d84c, 5); calld(0x1007_6e7c, -0x4_69d5);          /* call 0x10076e7c */
            ii(0x100b_d851, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100b_d857, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100b_d85d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d860, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100b_d866, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100b_d869, 5); calld(Definitions.my_min, -0x3_40ea);   /* call 0x10089784 */
            ii(0x100b_d86e, 6); mov(memd_a32[ss, ebp - 0x9c], eax);     /* mov [ebp-0x9c], eax */
        l_0x100b_d874:
            ii(0x100b_d874, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100b_d87a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_d87d, 2); jmpd(0x100b_d885, 0x6); goto l_0x100b_d885; /* jmp 0x100bd885 */
        l_0x100b_d87f:
            ii(0x100b_d87f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_d882, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_d885:
            ii(0x100b_d885, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_d889, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_d88b, 2); if(jged(0x100b_d8bf, 0x32)) goto l_0x100b_d8bf; /* jge 0x100bd8bf */
            ii(0x100b_d88d, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100b_d893, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_d896, 2); jmpd(0x100b_d89e, 0x6); goto l_0x100b_d89e; /* jmp 0x100bd89e */
        l_0x100b_d898:
            ii(0x100b_d898, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_d89b, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x100b_d89e:
            ii(0x100b_d89e, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_d8a2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_d8a4, 2); if(jged(0x100b_d8bd, 0x17)) goto l_0x100b_d8bd; /* jge 0x100bd8bd */
            ii(0x100b_d8a6, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_d8aa, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_d8ad, 5); calld(0x1008_a728, -0x3_318a);          /* call 0x1008a728 */
            ii(0x100b_d8b2, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_d8b6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_d8b8, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x100b_d8bb, 2); jmpd(0x100b_d898, -0x25); goto l_0x100b_d898; /* jmp 0x100bd898 */
        l_0x100b_d8bd:
            ii(0x100b_d8bd, 2); jmpd(0x100b_d87f, -0x40); goto l_0x100b_d87f; /* jmp 0x100bd87f */
        l_0x100b_d8bf:
            ii(0x100b_d8bf, 5); jmpd(0x100b_d744, -0x180); goto l_0x100b_d744; /* jmp 0x100bd744 */
        l_0x100b_d8c4:
            ii(0x100b_d8c4, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_d8c9, 5); calld(0x1007_6338, -0x4_7596);          /* call 0x10076338 */
            ii(0x100b_d8ce, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x100b_d8d1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_d8d3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_d8d5, 5); calld(0x1007_643c, -0x4_749e);          /* call 0x1007643c */
            ii(0x100b_d8da, 2); jmpd(0x100b_d8e4, 0x8); goto l_0x100b_d8e4; /* jmp 0x100bd8e4 */
        l_0x100b_d8dc:
            ii(0x100b_d8dc, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d8df, 5); calld(0x1007_6bf8, -0x4_6cec);          /* call 0x10076bf8 */
        l_0x100b_d8e4:
            ii(0x100b_d8e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d8e6, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d8e9, 5); calld(0x1013_ad71, 0x7_d483);           /* call 0x1013ad71 */
            ii(0x100b_d8ee, 2); test(al, al);                           /* test al, al */
            ii(0x100b_d8f0, 6); if(jzd(0x100b_d9f4, 0xfe)) goto l_0x100b_d9f4; /* jz 0x100bd9f4 */
            ii(0x100b_d8f6, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d8f9, 5); calld(0x1007_63a0, -0x4_755e);          /* call 0x100763a0 */
            ii(0x100b_d8fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_d900, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_d903, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_d906, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_d909, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_d90b, 6); if(jnzd(0x100b_d9ef, 0xde)) goto l_0x100b_d9ef; /* jnz 0x100bd9ef */
            ii(0x100b_d911, 6); lea(edx, ebp - 0xa8);                   /* lea edx, [ebp-0xa8] */
            ii(0x100b_d917, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d91a, 5); calld(0x1007_63a0, -0x4_757f);          /* call 0x100763a0 */
            ii(0x100b_d91f, 5); calld(0x1015_2532, 0x9_4c0e);           /* call 0x10152532 */
            ii(0x100b_d924, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_d927, 5); calld(0x1007_63a0, -0x4_758c);          /* call 0x100763a0 */
            ii(0x100b_d92c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_d92f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_d932, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_d935, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x100b_d93c, 2); if(jzd(0x100b_d9a4, 0x66)) goto l_0x100b_d9a4; /* jz 0x100bd9a4 */
            ii(0x100b_d93e, 6); mov(edx, memd_a32[ss, ebp - 0xa8]);     /* mov edx, [ebp-0xa8] */
            ii(0x100b_d944, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x100b_d947, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_d949, 5); calld(0x1007_6e7c, -0x4_6ad2);          /* call 0x10076e7c */
            ii(0x100b_d94e, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100b_d954, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_d95a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d95d, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100b_d963, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100b_d966, 5); calld(Definitions.my_min, -0x3_41e7);   /* call 0x10089784 */
            ii(0x100b_d96b, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x100b_d971, 6); mov(edx, memd_a32[ss, ebp - 0xa4]);     /* mov edx, [ebp-0xa4] */
            ii(0x100b_d977, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x100b_d97a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_d97c, 5); calld(0x1007_6e7c, -0x4_6b05);          /* call 0x10076e7c */
            ii(0x100b_d981, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100b_d987, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100b_d98d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_d990, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100b_d996, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100b_d999, 5); calld(Definitions.my_min, -0x3_421a);   /* call 0x10089784 */
            ii(0x100b_d99e, 6); mov(memd_a32[ss, ebp - 0x9c], eax);     /* mov [ebp-0x9c], eax */
        l_0x100b_d9a4:
            ii(0x100b_d9a4, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100b_d9aa, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_d9ad, 2); jmpd(0x100b_d9b5, 0x6); goto l_0x100b_d9b5; /* jmp 0x100bd9b5 */
        l_0x100b_d9af:
            ii(0x100b_d9af, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_d9b2, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_d9b5:
            ii(0x100b_d9b5, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_d9b9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_d9bb, 2); if(jged(0x100b_d9ef, 0x32)) goto l_0x100b_d9ef; /* jge 0x100bd9ef */
            ii(0x100b_d9bd, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100b_d9c3, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_d9c6, 2); jmpd(0x100b_d9ce, 0x6); goto l_0x100b_d9ce; /* jmp 0x100bd9ce */
        l_0x100b_d9c8:
            ii(0x100b_d9c8, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_d9cb, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x100b_d9ce:
            ii(0x100b_d9ce, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_d9d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_d9d4, 2); if(jged(0x100b_d9ed, 0x17)) goto l_0x100b_d9ed; /* jge 0x100bd9ed */
            ii(0x100b_d9d6, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_d9da, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_d9dd, 5); calld(0x1008_a728, -0x3_32ba);          /* call 0x1008a728 */
            ii(0x100b_d9e2, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_d9e6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_d9e8, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x100b_d9eb, 2); jmpd(0x100b_d9c8, -0x25); goto l_0x100b_d9c8; /* jmp 0x100bd9c8 */
        l_0x100b_d9ed:
            ii(0x100b_d9ed, 2); jmpd(0x100b_d9af, -0x40); goto l_0x100b_d9af; /* jmp 0x100bd9af */
        l_0x100b_d9ef:
            ii(0x100b_d9ef, 5); jmpd(0x100b_d8dc, -0x118); goto l_0x100b_d8dc; /* jmp 0x100bd8dc */
        l_0x100b_d9f4:
            ii(0x100b_d9f4, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_d9fb, 2); jmpd(0x100b_da03, 0x6); goto l_0x100b_da03; /* jmp 0x100bda03 */
        l_0x100b_d9fd:
            ii(0x100b_d9fd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_da00, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100b_da03:
            ii(0x100b_da03, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_da07, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_da0a, 6); if(jged(0x100b_daca, 0xba)) goto l_0x100b_daca; /* jge 0x100bdaca */
            ii(0x100b_da10, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_da13, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_da16, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100b_da19, 2); if(jzd(0x100b_da34, 0x19)) goto l_0x100b_da34; /* jz 0x100bda34 */
            ii(0x100b_da1b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_da1f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_da25, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_da2b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_da30, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_da32, 2); if(jnzd(0x100b_da39, 0x5)) goto l_0x100b_da39; /* jnz 0x100bda39 */
        l_0x100b_da34:
            ii(0x100b_da34, 5); jmpd(0x100b_dac5, 0x8c); goto l_0x100b_dac5; /* jmp 0x100bdac5 */
        l_0x100b_da39:
            ii(0x100b_da39, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100b_da3d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_da43, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x100b_da49, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100b_da4f, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100b_da56, 2); jmpd(0x100b_da5e, 0x6); goto l_0x100b_da5e; /* jmp 0x100bda5e */
        l_0x100b_da58:
            ii(0x100b_da58, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_da5b, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_da5e:
            ii(0x100b_da5e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_da61, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_da68, 2); if(jged(0x100b_dac5, 0x5b)) goto l_0x100b_dac5; /* jge 0x100bdac5 */
            ii(0x100b_da6a, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_da71, 2); jmpd(0x100b_da79, 0x6); goto l_0x100b_da79; /* jmp 0x100bda79 */
        l_0x100b_da73:
            ii(0x100b_da73, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_da76, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x100b_da79:
            ii(0x100b_da79, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_da7c, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100b_da83, 2); if(jged(0x100b_dac3, 0x3e)) goto l_0x100b_dac3; /* jge 0x100bdac3 */
            ii(0x100b_da85, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_da89, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_da8f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_da92, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100b_da95, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_da99, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_da9b, 6); add(eax, memd_a32[ss, ebp - 0xac]);     /* add eax, [ebp-0xac] */
            ii(0x100b_daa1, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100b_daa3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_daa8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_daaa, 2); if(jzd(0x100b_dac1, 0x15)) goto l_0x100b_dac1; /* jz 0x100bdac1 */
            ii(0x100b_daac, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_dab0, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_dab3, 5); calld(0x1008_a728, -0x3_3390);          /* call 0x1008a728 */
            ii(0x100b_dab8, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_dabc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_dabe, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100b_dac1:
            ii(0x100b_dac1, 2); jmpd(0x100b_da73, -0x50); goto l_0x100b_da73; /* jmp 0x100bda73 */
        l_0x100b_dac3:
            ii(0x100b_dac3, 2); jmpd(0x100b_da58, -0x6d); goto l_0x100b_da58; /* jmp 0x100bda58 */
        l_0x100b_dac5:
            ii(0x100b_dac5, 5); jmpd(0x100b_d9fd, -0xcd); goto l_0x100b_d9fd; /* jmp 0x100bd9fd */
        l_0x100b_daca:
            ii(0x100b_daca, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_dad1, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_dad8, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_dadf, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100b_dae6, 2); jmpd(0x100b_daee, 0x6); goto l_0x100b_daee; /* jmp 0x100bdaee */
        l_0x100b_dae8:
            ii(0x100b_dae8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_daeb, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_daee:
            ii(0x100b_daee, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_daf1, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_daf8, 6); if(jged(0x100b_dbaf, 0xb1)) goto l_0x100b_dbaf; /* jge 0x100bdbaf */
            ii(0x100b_dafe, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_db05, 2); jmpd(0x100b_db0d, 0x6); goto l_0x100b_db0d; /* jmp 0x100bdb0d */
        l_0x100b_db07:
            ii(0x100b_db07, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_db0a, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x100b_db0d:
            ii(0x100b_db0d, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_db10, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100b_db17, 6); if(jged(0x100b_dbaa, 0x8d)) goto l_0x100b_dbaa; /* jge 0x100bdbaa */
            ii(0x100b_db1d, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_db21, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_db25, 5); calld(0x1007_3cfd, -0x4_9e2d);          /* call 0x10073cfd */
            ii(0x100b_db2a, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_db2d, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_db31, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_db34, 5); calld(0x1008_a728, -0x3_3411);          /* call 0x1008a728 */
            ii(0x100b_db39, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_db3d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_db3f, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100b_db41, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_db46, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_db48, 2); if(jnzd(0x100b_db66, 0x1c)) goto l_0x100b_db66; /* jnz 0x100bdb66 */
            ii(0x100b_db4a, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_db4e, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_db51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_db54, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_db57, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_db59, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_db5d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_db5f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_db61, 3); and(memb_a32[ds, eax], -0x3 /* 0xfd */); /* and byte [eax], 0xfd */
            ii(0x100b_db64, 2); jmpd(0x100b_dba5, 0x3f); goto l_0x100b_dba5; /* jmp 0x100bdba5 */
        l_0x100b_db66:
            ii(0x100b_db66, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_db69, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x100b_db6c, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_db70, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_db73, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_db75, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_db78, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_db7b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_db7d, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_db81, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_db83, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_db85, 3); test(memb_a32[ds, eax], 0x2);           /* test byte [eax], 0x2 */
            ii(0x100b_db88, 2); if(jzd(0x100b_dba5, 0x1b)) goto l_0x100b_dba5; /* jz 0x100bdba5 */
            ii(0x100b_db8a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_db8d, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100b_db90, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_db94, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_db97, 5); calld(0x1008_a728, -0x3_3474);          /* call 0x1008a728 */
            ii(0x100b_db9c, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_dba0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_dba2, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100b_dba5:
            ii(0x100b_dba5, 5); jmpd(0x100b_db07, -0xa3); goto l_0x100b_db07; /* jmp 0x100bdb07 */
        l_0x100b_dbaa:
            ii(0x100b_dbaa, 5); jmpd(0x100b_dae8, -0xc7); goto l_0x100b_dae8; /* jmp 0x100bdae8 */
        l_0x100b_dbaf:
            ii(0x100b_dbaf, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100b_dbb4, 5); calld(0x1007_6338, -0x4_7881);          /* call 0x10076338 */
            ii(0x100b_dbb9, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x100b_dbbc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_dbbe, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_dbc0, 5); calld(0x1007_643c, -0x4_7789);          /* call 0x1007643c */
            ii(0x100b_dbc5, 2); jmpd(0x100b_dbcf, 0x8); goto l_0x100b_dbcf; /* jmp 0x100bdbcf */
        l_0x100b_dbc7:
            ii(0x100b_dbc7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dbca, 5); calld(0x1007_6bf8, -0x4_6fd7);          /* call 0x10076bf8 */
        l_0x100b_dbcf:
            ii(0x100b_dbcf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dbd1, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dbd4, 5); calld(0x1013_ad71, 0x7_d198);           /* call 0x1013ad71 */
            ii(0x100b_dbd9, 2); test(al, al);                           /* test al, al */
            ii(0x100b_dbdb, 6); if(jzd(0x100b_dcb1, 0xd0)) goto l_0x100b_dcb1; /* jz 0x100bdcb1 */
            ii(0x100b_dbe1, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dbe4, 5); calld(0x1007_63a0, -0x4_7849);          /* call 0x100763a0 */
            ii(0x100b_dbe9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dbeb, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_dbee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_dbf1, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_dbf4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_dbf6, 2); if(jnzd(0x100b_dc18, 0x20)) goto l_0x100b_dc18; /* jnz 0x100bdc18 */
            ii(0x100b_dbf8, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dbfb, 5); calld(0x1007_63a0, -0x4_7860);          /* call 0x100763a0 */
            ii(0x100b_dc00, 5); cmp(memw_a32[ds, eax + 0x8], 0x29);     /* cmp word [eax+0x8], 0x29 */
            ii(0x100b_dc05, 2); if(jzd(0x100b_dc16, 0xf)) goto l_0x100b_dc16; /* jz 0x100bdc16 */
            ii(0x100b_dc07, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc0a, 5); calld(0x1007_63a0, -0x4_786f);          /* call 0x100763a0 */
            ii(0x100b_dc0f, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x100b_dc14, 2); if(jnzd(0x100b_dc18, 0x2)) goto l_0x100b_dc18; /* jnz 0x100bdc18 */
        l_0x100b_dc16:
            ii(0x100b_dc16, 2); jmpd(0x100b_dc1a, 0x2); goto l_0x100b_dc1a; /* jmp 0x100bdc1a */
        l_0x100b_dc18:
            ii(0x100b_dc18, 2); jmpd(0x100b_dc4b, 0x31); goto l_0x100b_dc4b; /* jmp 0x100bdc4b */
        l_0x100b_dc1a:
            ii(0x100b_dc1a, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc1d, 5); calld(0x1007_63a0, -0x4_7882);          /* call 0x100763a0 */
            ii(0x100b_dc22, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_dc25, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_dc28, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc2b, 5); calld(0x1007_63a0, -0x4_7890);          /* call 0x100763a0 */
            ii(0x100b_dc30, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_dc33, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_dc36, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_dc39, 5); calld(0x1008_a728, -0x3_3516);          /* call 0x1008a728 */
            ii(0x100b_dc3e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_dc40, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100b_dc42, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_dc47, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_dc49, 2); if(jnzd(0x100b_dc4d, 0x2)) goto l_0x100b_dc4d; /* jnz 0x100bdc4d */
        l_0x100b_dc4b:
            ii(0x100b_dc4b, 2); jmpd(0x100b_dcac, 0x5f); goto l_0x100b_dcac; /* jmp 0x100bdcac */
        l_0x100b_dc4d:
            ii(0x100b_dc4d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_dc50, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x100b_dc53, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc56, 5); calld(0x1007_63a0, -0x4_78bb);          /* call 0x100763a0 */
            ii(0x100b_dc5b, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100b_dc5e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_dc61, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_dc64, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_dc66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_dc69, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_dc6c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_dc6e, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc71, 5); calld(0x1007_63a0, -0x4_78d6);          /* call 0x100763a0 */
            ii(0x100b_dc76, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_dc79, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_dc7c, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x100b_dc7e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_dc80, 3); and(memb_a32[ds, eax], -0x3 /* 0xfd */); /* and byte [eax], 0xfd */
            ii(0x100b_dc83, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc86, 5); calld(0x1007_63a0, -0x4_78eb);          /* call 0x100763a0 */
            ii(0x100b_dc8b, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_dc8e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_dc91, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dc94, 5); calld(0x1007_63a0, -0x4_78f9);          /* call 0x100763a0 */
            ii(0x100b_dc99, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_dc9c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_dc9f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_dca2, 5); calld(0x1008_a728, -0x3_357f);          /* call 0x1008a728 */
            ii(0x100b_dca7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_dca9, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100b_dcac:
            ii(0x100b_dcac, 5); jmpd(0x100b_dbc7, -0xea); goto l_0x100b_dbc7; /* jmp 0x100bdbc7 */
        l_0x100b_dcb1:
            ii(0x100b_dcb1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_dcb4, 3); mov(edx, memd_a32[ds, edx + 0x5]);      /* mov edx, [edx+0x5] */
            ii(0x100b_dcb7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_dcba, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100b_dcbe, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100b_dcc1, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x100b_dcc6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_dcc8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_dccb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100b_dccd, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100b_dcd1, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_dcd3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_dcd5, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_dcd9, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100b_dcdb, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x100b_dcde, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100b_dce2, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100b_dce7, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100b_dce9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_dceb, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100b_dcef, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_dcf1, 2); if(jld(0x100b_dcfe, 0xb)) goto l_0x100b_dcfe; /* jl 0x100bdcfe */
            ii(0x100b_dcf3, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100b_dcf8, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x100b_dcfb, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100b_dcfe:
            ii(0x100b_dcfe, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_dd01, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100b_dd04, 3); sub(memd_a32[ss, ebp - 0x18], eax);     /* sub [ebp-0x18], eax */
            ii(0x100b_dd07, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100b_dd0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_dd0d, 2); if(jgd(0x100b_dd32, 0x23)) goto l_0x100b_dd32; /* jg 0x100bdd32 */
            ii(0x100b_dd0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dd11, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_dd14, 5); calld(0x1008_8bbc, -0x3_515d);          /* call 0x10088bbc */
            ii(0x100b_dd19, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dd1b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_dd1e, 5); calld(0x1007_5f6c, -0x4_7db7);          /* call 0x10075f6c */
            ii(0x100b_dd23, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dd25, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_dd28, 5); calld(0x1008_bc9f, -0x3_208e);          /* call 0x1008bc9f */
            ii(0x100b_dd2d, 5); jmpd(0x100b_de90, 0x15e); goto l_0x100b_de90; /* jmp 0x100bde90 */
        l_0x100b_dd32:
            ii(0x100b_dd32, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100b_dd39, 2); jmpd(0x100b_dd41, 0x6); goto l_0x100b_dd41; /* jmp 0x100bdd41 */
        l_0x100b_dd3b:
            ii(0x100b_dd3b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_dd3e, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100b_dd41:
            ii(0x100b_dd41, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_dd44, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_dd4b, 2); if(jged(0x100b_dd54, 0x7)) goto l_0x100b_dd54; /* jge 0x100bdd54 */
            ii(0x100b_dd4d, 5); cmp(memw_a32[ss, ebp - 0x20], 0);       /* cmp word [ebp-0x20], 0x0 */
            ii(0x100b_dd52, 2); if(jnzd(0x100b_dd59, 0x5)) goto l_0x100b_dd59; /* jnz 0x100bdd59 */
        l_0x100b_dd54:
            ii(0x100b_dd54, 5); jmpd(0x100b_dddf, 0x86); goto l_0x100b_dddf; /* jmp 0x100bdddf */
        l_0x100b_dd59:
            ii(0x100b_dd59, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_dd60, 2); jmpd(0x100b_dd68, 0x6); goto l_0x100b_dd68; /* jmp 0x100bdd68 */
        l_0x100b_dd62:
            ii(0x100b_dd62, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_dd65, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x100b_dd68:
            ii(0x100b_dd68, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_dd6b, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100b_dd72, 2); if(jged(0x100b_dd7b, 0x7)) goto l_0x100b_dd7b; /* jge 0x100bdd7b */
            ii(0x100b_dd74, 5); cmp(memw_a32[ss, ebp - 0x20], 0);       /* cmp word [ebp-0x20], 0x0 */
            ii(0x100b_dd79, 2); if(jnzd(0x100b_dd7d, 0x2)) goto l_0x100b_dd7d; /* jnz 0x100bdd7d */
        l_0x100b_dd7b:
            ii(0x100b_dd7b, 2); jmpd(0x100b_ddda, 0x5d); goto l_0x100b_ddda; /* jmp 0x100bddda */
        l_0x100b_dd7d:
            ii(0x100b_dd7d, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_dd81, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_dd84, 5); calld(0x1008_a728, -0x3_3661);          /* call 0x1008a728 */
            ii(0x100b_dd89, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_dd8d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_dd8f, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100b_dd91, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_dd96, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_dd98, 2); if(jzd(0x100b_ddd8, 0x3e)) goto l_0x100b_ddd8; /* jz 0x100bddd8 */
            ii(0x100b_dd9a, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100b_dd9e, 5); calld(/* sys */ 0x1016_5e9b, 0xa_80f8); /* call 0x10165e9b */
            ii(0x100b_dda3, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100b_dda6, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100b_dda9, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100b_ddad, 1); inc(eax);                               /* inc eax */
            ii(0x100b_ddae, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100b_ddb0, 2); if(jgd(0x100b_ddd2, 0x20)) goto l_0x100b_ddd2; /* jg 0x100bddd2 */
            ii(0x100b_ddb2, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_ddb6, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_ddb9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_ddbc, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_ddbf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_ddc1, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_ddc5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_ddc7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_ddc9, 3); or(memb_a32[ds, eax], 0x2);             /* or byte [eax], 0x2 */
            ii(0x100b_ddcc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_ddcf, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
        l_0x100b_ddd2:
            ii(0x100b_ddd2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_ddd5, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
        l_0x100b_ddd8:
            ii(0x100b_ddd8, 2); jmpd(0x100b_dd62, -0x78); goto l_0x100b_dd62; /* jmp 0x100bdd62 */
        l_0x100b_ddda:
            ii(0x100b_ddda, 5); jmpd(0x100b_dd3b, -0xa4); goto l_0x100b_dd3b; /* jmp 0x100bdd3b */
        l_0x100b_dddf:
            ii(0x100b_dddf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dde1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_dde4, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x100b_dde7, 5); calld(0x1013_ad11, 0x7_cf25);           /* call 0x1013ad11 */
            ii(0x100b_ddec, 2); test(al, al);                           /* test al, al */
            ii(0x100b_ddee, 6); if(jzd(0x100b_de72, 0x7e)) goto l_0x100b_de72; /* jz 0x100bde72 */
            ii(0x100b_ddf4, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x100b_ddf9, 5); calld(Definitions.sys_new, 0xa_8002);   /* call 0x10165e00 */
            ii(0x100b_ddfe, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x100b_de04, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100b_de0a, 6); mov(memd_a32[ss, ebp - 0xb4], eax);     /* mov [ebp-0xb4], eax */
            ii(0x100b_de10, 7); cmp(memd_a32[ss, ebp - 0xb4], 0);       /* cmp dword [ebp-0xb4], 0x0 */
            ii(0x100b_de17, 2); if(jzd(0x100b_de3e, 0x25)) goto l_0x100b_de3e; /* jz 0x100bde3e */
            ii(0x100b_de19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_de1c, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_de1f, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100b_de25, 5); calld(0x1008_076d, -0x3_d6bd);          /* call 0x1008076d */
            ii(0x100b_de2a, 6); mov(memd_a32[ss, ebp - 0xb8], eax);     /* mov [ebp-0xb8], eax */
            ii(0x100b_de30, 6); mov(eax, memd_a32[ss, ebp - 0xb8]);     /* mov eax, [ebp-0xb8] */
            ii(0x100b_de36, 6); mov(memd_a32[ss, ebp - 0xbc], eax);     /* mov [ebp-0xbc], eax */
            ii(0x100b_de3c, 2); jmpd(0x100b_de4a, 0xc); goto l_0x100b_de4a; /* jmp 0x100bde4a */
        l_0x100b_de3e:
            ii(0x100b_de3e, 6); mov(eax, memd_a32[ss, ebp - 0xb4]);     /* mov eax, [ebp-0xb4] */
            ii(0x100b_de44, 6); mov(memd_a32[ss, ebp - 0xbc], eax);     /* mov [ebp-0xbc], eax */
        l_0x100b_de4a:
            ii(0x100b_de4a, 6); mov(edx, memd_a32[ss, ebp - 0xbc]);     /* mov edx, [ebp-0xbc] */
            ii(0x100b_de50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_de53, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x100b_de56, 5); calld(0x1008_afe4, -0x3_2e77);          /* call 0x1008afe4 */
            ii(0x100b_de5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_de5e, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x100b_de61, 5); calld(0x1008_af84, -0x3_2ee2);          /* call 0x1008af84 */
            ii(0x100b_de66, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_de68, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_de6d, 5); calld(0x100a_4d50, -0x1_9122);          /* call 0x100a4d50 */
        l_0x100b_de72:
            ii(0x100b_de72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_de74, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_de77, 5); calld(0x1008_8bbc, -0x3_52c0);          /* call 0x10088bbc */
            ii(0x100b_de7c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_de7e, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_de81, 5); calld(0x1007_5f6c, -0x4_7f1a);          /* call 0x10075f6c */
            ii(0x100b_de86, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_de88, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100b_de8b, 5); calld(0x1008_bc9f, -0x3_21f1);          /* call 0x1008bc9f */
        l_0x100b_de90:
            ii(0x100b_de90, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_de92, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_de93, 1); popd(edi);                              /* pop edi */
            ii(0x100b_de94, 1); popd(esi);                              /* pop esi */
            ii(0x100b_de95, 1); popd(edx);                              /* pop edx */
            ii(0x100b_de96, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_de97, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_de98, 1); retd(); return;                         /* ret */
        }
    }
}
