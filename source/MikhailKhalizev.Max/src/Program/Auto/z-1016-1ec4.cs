using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_1ec4-49be5e44")]
        public void Method_1016_1ec4()
        {
            ii(0x1016_1ec4, 5); mov(eax, StringDefinitions.Firing);     /* mov eax, 0x101b28fb */
            ii(0x1016_1ec9, 5); calld(0x100a_8b4a, -0xb_9384);          /* call 0x100a8b4a */
            ii(0x1016_1ece, 7); mov(memb_a32[ds, 0x101c_9448], 0x1);    /* mov byte [0x101c9448], 0x1 */
            ii(0x1016_1ed5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ed8, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_1edb, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1016_1ede, 5); jmpd(0x1016_1f91, 0xae); goto l_0x1016_1f91; /* jmp 0x10161f91 */
        l_0x1016_1ee3:
            ii(0x1016_1ee3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1ee6, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1016_1eeb, 5); calld(0x1008_ab1c, -0xd_73d4);          /* call 0x1008ab1c */
            ii(0x1016_1ef0, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_1ef5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ef8, 3); mov(ebx, memd_a32[ds, eax + 0x41]);     /* mov ebx, [eax+0x41] */
            ii(0x1016_1efb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_1efe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f01, 3); mov(edx, memd_a32[ds, eax + 0x3f]);     /* mov edx, [eax+0x3f] */
            ii(0x1016_1f04, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_1f07, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f0a, 5); calld(0x1014_e906, -0x1_3609);          /* call 0x1014e906 */
            ii(0x1016_1f0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f12, 4); mov(memb_a32[ds, eax + 0x3e], 0x28);    /* mov byte [eax+0x3e], 0x28 */
            ii(0x1016_1f16, 5); jmpd(0x1016_1fdf, 0xc4); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f1b:
            ii(0x1016_1f1b, 5); jmpd(0x1016_1fdf, 0xbf); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f20:
            ii(0x1016_1f20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f23, 4); mov(memb_a32[ds, eax + 0x3e], 0x5);     /* mov byte [eax+0x3e], 0x5 */
            ii(0x1016_1f27, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1f2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f2f, 5); calld(0x1007_6d98, -0xe_b19c);          /* call 0x10076d98 */
            ii(0x1016_1f34, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1f36, 2); if(jzd(0x1016_1f53, 0x1b)) goto l_0x1016_1f53; /* jz 0x10161f53 */
            ii(0x1016_1f38, 5); calld(0x1010_2bf8, -0x5_f345);          /* call 0x10102bf8 */
            ii(0x1016_1f3d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_1f3f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_1f41, 5); mov(ebx, 0xb);                          /* mov ebx, 0xb */
            ii(0x1016_1f46, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1f49, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_1f4e, 5); calld(0x1013_d5c0, -0x2_4993);          /* call 0x1013d5c0 */
        l_0x1016_1f53:
            ii(0x1016_1f53, 7); mov(memb_a32[ds, 0x101c_9447], 0x1);    /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1f5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f5d, 5); calld(0x1016_0d16, -0x124c);            /* call 0x10160d16 */
            ii(0x1016_1f62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1f64, 6); if(jzd(0x1016_1fdf, 0x75)) goto l_0x1016_1fdf; /* jz 0x10161fdf */
        l_0x1016_1f6a:
            ii(0x1016_1f6a, 7); mov(memb_a32[ds, 0x101c_9447], 0x1);    /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1f71, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f74, 5); calld(0x1015_4355, -0xdc24);            /* call 0x10154355 */
            ii(0x1016_1f79, 5); jmpd(0x1016_1fdf, 0x61); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f7e:
            ii(0x1016_1f7e, 7); mov(memb_a32[ds, 0x101c_9447], 0x1);    /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1f85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1f88, 5); calld(0x1015_46ce, -0xd8bf);            /* call 0x101546ce */
            ii(0x1016_1f8d, 2); jmpd(0x1016_1fdf, 0x50); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f8f:
            ii(0x1016_1f8f, 2); jmpd(0x1016_1fdf, 0x4e); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f91:
            ii(0x1016_1f91, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x1016_1f94, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1016_1f97, 4); cmp(memb_a32[ss, ebp - 0x28], 0x8);     /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1016_1f9b, 2); if(jbd(0x1016_1fc7, 0x2a)) goto l_0x1016_1fc7; /* jb 0x10161fc7 */
            ii(0x1016_1f9d, 4); cmp(memb_a32[ss, ebp - 0x28], 0x8);     /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1016_1fa1, 2); if(jbed(0x1016_1f6a, -0x39)) goto l_0x1016_1f6a; /* jbe 0x10161f6a */
            ii(0x1016_1fa3, 4); cmp(memb_a32[ss, ebp - 0x28], 0x28);    /* cmp byte [ebp-0x28], 0x28 */
            ii(0x1016_1fa7, 2); if(jbd(0x1016_1fbf, 0x16)) goto l_0x1016_1fbf; /* jb 0x10161fbf */
            ii(0x1016_1fa9, 4); cmp(memb_a32[ss, ebp - 0x28], 0x28);    /* cmp byte [ebp-0x28], 0x28 */
            ii(0x1016_1fad, 6); if(jbed(0x1016_1f1b, -0x98)) goto l_0x1016_1f1b; /* jbe 0x10161f1b */
            ii(0x1016_1fb3, 4); cmp(memb_a32[ss, ebp - 0x28], 0x29);    /* cmp byte [ebp-0x28], 0x29 */
            ii(0x1016_1fb7, 6); if(jzd(0x1016_1f20, -0x9d)) goto l_0x1016_1f20; /* jz 0x10161f20 */
            ii(0x1016_1fbd, 2); jmpd(0x1016_1f8f, -0x30); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        l_0x1016_1fbf:
            ii(0x1016_1fbf, 4); cmp(memb_a32[ss, ebp - 0x28], 0x9);     /* cmp byte [ebp-0x28], 0x9 */
            ii(0x1016_1fc3, 2); if(jzd(0x1016_1f7e, -0x47)) goto l_0x1016_1f7e; /* jz 0x10161f7e */
            ii(0x1016_1fc5, 2); jmpd(0x1016_1f8f, -0x38); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        l_0x1016_1fc7:
            ii(0x1016_1fc7, 4); cmp(memb_a32[ss, ebp - 0x28], 0);       /* cmp byte [ebp-0x28], 0x0 */
            ii(0x1016_1fcb, 6); if(jbed(0x1016_1ee3, -0xee)) goto l_0x1016_1ee3; /* jbe 0x10161ee3 */
            ii(0x1016_1fd1, 4); cmp(memb_a32[ss, ebp - 0x28], 0x5);     /* cmp byte [ebp-0x28], 0x5 */
            ii(0x1016_1fd5, 6); if(jzd(0x1016_1f53, -0x88)) goto l_0x1016_1f53; /* jz 0x10161f53 */
            ii(0x1016_1fdb, 2); jmpd(0x1016_1f8f, -0x4e); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        //  ii(0x1016_1fdd, 2); jmpd(0x1016_1f8f, -0x50); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        l_0x1016_1fdf:
            ii(0x1016_1fdf, 5); if(jmpd_func(0x1016_29a7, 0x9c3)) return; /* jmp 0x101629a7 */
        }
    }
}
