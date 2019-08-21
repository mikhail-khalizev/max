using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a28b-4c0fd561")]
        public void Method_100f_a28b()
        {
            ii(0x100f_a28b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a28d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a292, 5); calld(0x1013_ad71, 0x4_0ada);           /* call 0x1013ad71 */
            ii(0x100f_a297, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a299, 6); if(jzd(0x100f_a3a0, 0x101)) goto l_0x100f_a3a0; /* jz 0x100fa3a0 */
            ii(0x100f_a29f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2a4, 5); calld(0x1007_6574, -0x8_3d35);          /* call 0x10076574 */
            ii(0x100f_a2a9, 4); cmp(memb_a32[ds, eax + 0x56], 0);       /* cmp byte [eax+0x56], 0x0 */
            ii(0x100f_a2ad, 2); if(jzd(0x100f_a2ed, 0x3e)) goto l_0x100f_a2ed; /* jz 0x100fa2ed */
            ii(0x100f_a2af, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a2b2, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_a2b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a2b8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_a2b9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a2bc, 3); mov(ecx, memd_a32[ds, eax + 0x18]);     /* mov ecx, [eax+0x18] */
            ii(0x100f_a2bf, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a2c2, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2c7, 5); calld(0x1007_65d0, -0x8_3cfc);          /* call 0x100765d0 */
            ii(0x100f_a2cc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a2ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a2d0, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x100f_a2d5, 5); calld(0x100f_79d4, -0x2906);            /* call 0x100f79d4 */
            ii(0x100f_a2da, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2df, 5); calld(0x1007_6574, -0x8_3d70);          /* call 0x10076574 */
            ii(0x100f_a2e4, 4); mov(memb_a32[ds, eax + 0x56], 0);       /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a2e8, 5); if(jmpd_func(0x100f_a75d, 0x470)) return; /* jmp 0x100fa75d */
        l_0x100f_a2ed:
            ii(0x100f_a2ed, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a2f2, 5); calld(0x1007_6574, -0x8_3d83);          /* call 0x10076574 */
            ii(0x100f_a2f7, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_a2fb, 2); if(jnzd(0x100f_a351, 0x54)) goto l_0x100f_a351; /* jnz 0x100fa351 */
            ii(0x100f_a2fd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_a2ff, 5); calld(0x100f_448c, -0x5e78);            /* call 0x100f448c */
            ii(0x100f_a304, 5); calld(0x100f_f5c1, 0x52b8);             /* call 0x100ff5c1 */
            ii(0x100f_a309, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a30e, 5); calld(0x1007_6574, -0x8_3d9f);          /* call 0x10076574 */
            ii(0x100f_a313, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_a31a, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100f_a31e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a323, 5); calld(0x1007_6574, -0x8_3db4);          /* call 0x10076574 */
            ii(0x100f_a328, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_a32f, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100f_a333, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100f_a338, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100f_a33d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a342, 5); calld(0x1007_6600, -0x8_3d47);          /* call 0x10076600 */
            ii(0x100f_a347, 5); calld(0x1016_3053, 0x6_8d07);           /* call 0x10163053 */
            ii(0x100f_a34c, 5); if(jmpd_func(0x100f_a75d, 0x40c)) return; /* jmp 0x100fa75d */
        l_0x100f_a351:
            ii(0x100f_a351, 5); mov(eax, memd_a32[ds, 0x101c_3908]);    /* mov eax, [0x101c3908] */
            ii(0x100f_a356, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a359, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100f_a35c, 3); pushd(memd_a32[ss, ebp - 0x70]);        /* push dword [ebp-0x70] */
            ii(0x100f_a35f, 5); mov(eax, memd_a32[ds, 0x101c_3906]);    /* mov eax, [0x101c3906] */
            ii(0x100f_a364, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a367, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100f_a36a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a36f, 5); calld(0x1007_65d0, -0x8_3da4);          /* call 0x100765d0 */
            ii(0x100f_a374, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100f_a377, 5); calld(0x1012_11ea, 0x2_6e6e);           /* call 0x101211ea */
            ii(0x100f_a37c, 2); cmp(al, 0x14);                          /* cmp al, 0x14 */
            ii(0x100f_a37e, 2); if(jnzd(0x100f_a386, 0x6)) goto l_0x100f_a386; /* jnz 0x100fa386 */
            ii(0x100f_a380, 4); mov(memb_a32[ss, ebp - 0x6c], 0);       /* mov byte [ebp-0x6c], 0x0 */
            ii(0x100f_a384, 2); jmpd(0x100f_a38a, 0x4); goto l_0x100f_a38a; /* jmp 0x100fa38a */
        l_0x100f_a386:
            ii(0x100f_a386, 4); mov(memb_a32[ss, ebp - 0x6c], 0x1c);    /* mov byte [ebp-0x6c], 0x1c */
        l_0x100f_a38a:
            ii(0x100f_a38a, 3); mov(edx, memd_a32[ss, ebp - 0x6f]);     /* mov edx, [ebp-0x6f] */
            ii(0x100f_a38d, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100f_a390, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_a395, 3); mov(ecx, memd_a32[ss, ebp - 0x74]);     /* mov ecx, [ebp-0x74] */
            ii(0x100f_a398, 3); mov(ebx, memd_a32[ss, ebp - 0x78]);     /* mov ebx, [ebp-0x78] */
            ii(0x100f_a39b, 5); calld(0x100f_79d4, -0x29cc);            /* call 0x100f79d4 */
        l_0x100f_a3a0:
            ii(0x100f_a3a0, 5); if(jmpd_func(0x100f_a75d, 0x3b8)) return; /* jmp 0x100fa75d */
        }
    }
}
