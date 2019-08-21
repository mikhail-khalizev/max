using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a3a5-2aebea5b")]
        public void Method_100f_a3a5()
        {
            ii(0x100f_a3a5, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a3ab, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a3ae, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a3b4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a3b7, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a3bd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3c2, 5); calld(0x1007_65d0, -0x8_3df7);          /* call 0x100765d0 */
            ii(0x100f_a3c7, 5); calld(0x100f_9465, -0xf67);             /* call 0x100f9465 */
            ii(0x100f_a3cc, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a3ce, 2); if(jzd(0x100f_a3f5, 0x25)) goto l_0x100f_a3f5; /* jz 0x100fa3f5 */
            ii(0x100f_a3d0, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3d5, 5); calld(0x1007_6574, -0x8_3e66);          /* call 0x10076574 */
            ii(0x100f_a3da, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_a3dc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3e1, 5); calld(0x1007_6574, -0x8_3e72);          /* call 0x10076574 */
            ii(0x100f_a3e6, 5); calld(0x1007_623c, -0x8_41af);          /* call 0x1007623c */
            ii(0x100f_a3eb, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x100f_a3ef, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x100f_a3f3, 2); if(jld(0x100f_a3fa, 0x5)) goto l_0x100f_a3fa; /* jl 0x100fa3fa */
        l_0x100f_a3f5:
            ii(0x100f_a3f5, 5); jmpd(0x100f_a521, 0x127); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a3fa:
            ii(0x100f_a3fa, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a3ff, 5); calld(0x1007_6574, -0x8_3e90);          /* call 0x10076574 */
            ii(0x100f_a404, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100f_a409, 2); if(jnzd(0x100f_a44f, 0x44)) goto l_0x100f_a44f; /* jnz 0x100fa44f */
            ii(0x100f_a40b, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a411, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a416, 5); calld(0x1007_6574, -0x8_3ea7);          /* call 0x10076574 */
            ii(0x100f_a41b, 5); calld(0x1008_a998, -0x6_fa88);          /* call 0x1008a998 */
            ii(0x100f_a420, 5); mov(eax, memd_a32[ds, 0x101c_3908]);    /* mov eax, [0x101c3908] */
            ii(0x100f_a425, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a428, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a429, 6); mov(ecx, memd_a32[ds, 0x101c_3906]);    /* mov ecx, [0x101c3906] */
            ii(0x100f_a42f, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a432, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a437, 5); calld(0x1007_65d0, -0x8_3e6c);          /* call 0x100765d0 */
            ii(0x100f_a43c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a43e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a440, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_a445, 5); calld(0x100f_79d4, -0x2a76);            /* call 0x100f79d4 */
            ii(0x100f_a44a, 5); jmpd(0x100f_a521, 0xd2); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a44f:
            ii(0x100f_a44f, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a454, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_a458, 2); if(jnzd(0x100f_a482, 0x28)) goto l_0x100f_a482; /* jnz 0x100fa482 */
            ii(0x100f_a45a, 5); calld(0x100c_aa00, -0x2_fa5f);          /* call 0x100caa00 */
            ii(0x100f_a45f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_a464, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a465, 5); calld(0x100c_aa20, -0x2_fa4a);          /* call 0x100caa20 */
            ii(0x100f_a46a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_a46c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_a46e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_a473, 5); mov(eax, StringDefinitions.UnableToLoadDisabledUnits); /* mov eax, 0x101a2879 */
            ii(0x100f_a478, 5); calld(0x1011_5d23, 0x1_b8a6);           /* call 0x10115d23 */
            ii(0x100f_a47d, 5); jmpd(0x100f_a521, 0x9f); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a482:
            ii(0x100f_a482, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a487, 5); calld(0x1007_6574, -0x8_3f18);          /* call 0x10076574 */
            ii(0x100f_a48c, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a492, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x100f_a496, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x100f_a49a, 2); if(jnzd(0x100f_a4b6, 0x1a)) goto l_0x100f_a4b6; /* jnz 0x100fa4b6 */
            ii(0x100f_a49c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a4a1, 5); calld(0x1007_6574, -0x8_3f32);          /* call 0x10076574 */
            ii(0x100f_a4a6, 6); mov(edx, memd_a32[ds, 0x101c_3894]);    /* mov edx, [0x101c3894] */
            ii(0x100f_a4ac, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x100f_a4b0, 4); cmp(dx, memw_a32[ds, eax + 0x1c]);      /* cmp dx, [eax+0x1c] */
            ii(0x100f_a4b4, 2); if(jzd(0x100f_a4b8, 0x2)) goto l_0x100f_a4b8; /* jz 0x100fa4b8 */
        l_0x100f_a4b6:
            ii(0x100f_a4b6, 2); jmpd(0x100f_a4c3, 0xb); goto l_0x100f_a4c3; /* jmp 0x100fa4c3 */
        l_0x100f_a4b8:
            ii(0x100f_a4b8, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a4bd, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_a4c1, 2); if(jzd(0x100f_a4c5, 0x2)) goto l_0x100f_a4c5; /* jz 0x100fa4c5 */
        l_0x100f_a4c3:
            ii(0x100f_a4c3, 2); jmpd(0x100f_a4ee, 0x29); goto l_0x100f_a4ee; /* jmp 0x100fa4ee */
        l_0x100f_a4c5:
            ii(0x100f_a4c5, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a4ca, 5); calld(0x1007_65d0, -0x8_3eff);          /* call 0x100765d0 */
            ii(0x100f_a4cf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_a4d1, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a4d6, 5); calld(0x1008_a998, -0x6_fb43);          /* call 0x1008a998 */
            ii(0x100f_a4db, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_a4dd, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x100f_a4e2, 5); mov(eax, memd_a32[ds, 0x101c_3894]);    /* mov eax, [0x101c3894] */
            ii(0x100f_a4e7, 5); calld(0x1016_3053, 0x6_8b67);           /* call 0x10163053 */
            ii(0x100f_a4ec, 2); jmpd(0x100f_a521, 0x33); goto l_0x100f_a521; /* jmp 0x100fa521 */
        l_0x100f_a4ee:
            ii(0x100f_a4ee, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a4f3, 5); calld(0x1007_6574, -0x8_3f84);          /* call 0x10076574 */
            ii(0x100f_a4f8, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_a4fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a4fe, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a4ff, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a504, 5); calld(0x1007_6574, -0x8_3f95);          /* call 0x10076574 */
            ii(0x100f_a509, 3); mov(ecx, memd_a32[ds, eax + 0x18]);     /* mov ecx, [eax+0x18] */
            ii(0x100f_a50c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a50f, 6); mov(ebx, memd_a32[ds, 0x101c_3894]);    /* mov ebx, [0x101c3894] */
            ii(0x100f_a515, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a517, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x100f_a51c, 5); calld(0x100f_79d4, -0x2b4d);            /* call 0x100f79d4 */
        l_0x100f_a521:
            ii(0x100f_a521, 5); if(jmpd_func(0x100f_a75d, 0x237)) return; /* jmp 0x100fa75d */
        }
    }
}
