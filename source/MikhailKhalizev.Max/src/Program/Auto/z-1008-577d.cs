using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_577d-56a39555")]
        public void Method_1008_577d()
        {
            ii(0x1008_577d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1008_5784, 2); jmpd(0x1008_578c, 0x6); goto l_0x1008_578c; /* jmp 0x1008578c */
        l_0x1008_5786:
            ii(0x1008_5786, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_5789, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1008_578c:
            ii(0x1008_578c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_578f, 4); cmp(ax, memw_a32[ss, ebp - 0x2c]);      /* cmp ax, [ebp-0x2c] */
            ii(0x1008_5793, 6); if(jged(0x1008_5882, 0xe9)) goto l_0x1008_5882; /* jge 0x10085882 */
            ii(0x1008_5799, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1008_579d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_579f, 2); if(jld(0x1008_57ad, 0xc)) goto l_0x1008_57ad; /* jl 0x100857ad */
            ii(0x1008_57a1, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1008_57a4, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1008_57ab, 2); if(jld(0x1008_57af, 0x2)) goto l_0x1008_57af; /* jl 0x100857af */
        l_0x1008_57ad:
            ii(0x1008_57ad, 2); jmpd(0x1008_57b7, 0x8); goto l_0x1008_57b7; /* jmp 0x100857b7 */
        l_0x1008_57af:
            ii(0x1008_57af, 4); movsx(eax, memw_a32[ss, ebp - 0x46]);   /* movsx eax, word [ebp-0x46] */
            ii(0x1008_57b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_57b5, 2); if(jged(0x1008_57b9, 0x2)) goto l_0x1008_57b9; /* jge 0x100857b9 */
        l_0x1008_57b7:
            ii(0x1008_57b7, 2); jmpd(0x1008_57c5, 0xc); goto l_0x1008_57c5; /* jmp 0x100857c5 */
        l_0x1008_57b9:
            ii(0x1008_57b9, 3); mov(eax, memd_a32[ss, ebp - 0x46]);     /* mov eax, [ebp-0x46] */
            ii(0x1008_57bc, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1008_57c3, 2); if(jld(0x1008_57c7, 0x2)) goto l_0x1008_57c7; /* jl 0x100857c7 */
        l_0x1008_57c5:
            ii(0x1008_57c5, 2); jmpd(0x1008_57e4, 0x1d); goto l_0x1008_57e4; /* jmp 0x100857e4 */
        l_0x1008_57c7:
            ii(0x1008_57c7, 4); movsx(ebx, memw_a32[ss, ebp - 0x46]);   /* movsx ebx, word [ebp-0x46] */
            ii(0x1008_57cb, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1008_57cf, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_57d2, 5); calld(0x1008_a728, 0x4f51);             /* call 0x1008a728 */
            ii(0x1008_57d7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_57d9, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_57db, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_57e0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_57e2, 2); if(jgd(0x1008_57e6, 0x2)) goto l_0x1008_57e6; /* jg 0x100857e6 */
        l_0x1008_57e4:
            ii(0x1008_57e4, 2); jmpd(0x1008_5805, 0x1f); goto l_0x1008_5805; /* jmp 0x10085805 */
        l_0x1008_57e6:
            ii(0x1008_57e6, 4); cmp(memd_a32[ss, ebp - 0x4c], 0);       /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x1008_57ea, 2); if(jzd(0x1008_5803, 0x17)) goto l_0x1008_5803; /* jz 0x10085803 */
            ii(0x1008_57ec, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1008_57f0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_57f3, 3); add(eax, memd_a32[ss, ebp - 0x4c]);     /* add eax, [ebp-0x4c] */
            ii(0x1008_57f6, 4); movsx(edx, memw_a32[ss, ebp - 0x46]);   /* movsx edx, word [ebp-0x46] */
            ii(0x1008_57fa, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_57fc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_57fe, 3); test(memb_a32[ds, eax], 0x8);           /* test byte [eax], 0x8 */
            ii(0x1008_5801, 2); if(jnzd(0x1008_5805, 0x2)) goto l_0x1008_5805; /* jnz 0x10085805 */
        l_0x1008_5803:
            ii(0x1008_5803, 2); jmpd(0x1008_5807, 0x2); goto l_0x1008_5807; /* jmp 0x10085807 */
        l_0x1008_5805:
            ii(0x1008_5805, 2); jmpd(0x1008_5867, 0x60); goto l_0x1008_5867; /* jmp 0x10085867 */
        l_0x1008_5807:
            ii(0x1008_5807, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1008_580a, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1008_580d, 5); calld(0x1007_5e64, -0xf9ae);            /* call 0x10075e64 */
            ii(0x1008_5812, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5814, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_5817, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1008_581a, 5); calld(0x1007_5e64, -0xf9bb);            /* call 0x10075e64 */
            ii(0x1008_581f, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_5821, 5); calld(0x100a_5fca, 0x2_07a4);           /* call 0x100a5fca */
            ii(0x1008_5826, 3); imul(ecx, eax, 0x32);                   /* imul ecx, eax, 0x32 */
            ii(0x1008_5829, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1008_582c, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1008_582f, 5); calld(0x1007_5e64, -0xf9d0);            /* call 0x10075e64 */
            ii(0x1008_5834, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5836, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_5839, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1008_583c, 5); calld(0x1007_5e64, -0xf9dd);            /* call 0x10075e64 */
            ii(0x1008_5841, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_5843, 5); calld(0x100a_5fca, 0x2_0782);           /* call 0x100a5fca */
            ii(0x1008_5848, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1008_584a, 3); mov(memd_a32[ss, ebp - 0x14], ecx);     /* mov [ebp-0x14], ecx */
            ii(0x1008_584d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_5850, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1008_5854, 2); if(jged(0x1008_5867, 0x11)) goto l_0x1008_5867; /* jge 0x10085867 */
            ii(0x1008_5856, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_5859, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_585c, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_585f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_5862, 5); calld(0x1008_8b44, 0x32dd);             /* call 0x10088b44 */
        l_0x1008_5867:
            ii(0x1008_5867, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_586b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_586e, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1008_5873, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_5875, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_5878, 5); calld(0x1008_b1a4, 0x5927);             /* call 0x1008b1a4 */
            ii(0x1008_587d, 5); jmpd(0x1008_5786, -0xfc); goto l_0x1008_5786; /* jmp 0x10085786 */
        l_0x1008_5882:
            ii(0x1008_5882, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_5885, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1008_588a, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1008_588f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_5892, 5); if(jmpd_func(0x1008_5709, -0x18e)) return; /* jmp 0x10085709 */
        }
    }
}
