using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_104f-61d3c33c")]
        public void Method_0018_104f()
        {
            ii(0x18_104f, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x18_1053, 1); pushw(ds);                                /* push ds */
            ii(0x18_1054, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_1057, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_1059, 5); test(memb_a16[ds, 0x19a2], 0x1);          /* test byte [0x19a2], 0x1 */
            ii(0x18_105e, 2); if(jnzw(0x18_1065, 0x5)) goto l_0x18_1065; /* jnz 0x1065 */
            ii(0x18_1060, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_1062, 1); popw(ds);                                 /* pop ds */
            ii(0x18_1063, 1); leavew();                                 /* leave */
            ii(0x18_1064, 1); retfw(); return;                          /* retf */
        l_0x18_1065:
            ii(0x18_1065, 3); lea(ax, bp + 0xa);                        /* lea ax, [bp+0xa] */
            ii(0x18_1068, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x18_106b, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x18_106e, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x18_1071, 1); pushw(ss);                                /* push ss */
            ii(0x18_1072, 1); pushw(ax);                                /* push ax */
            ii(0x18_1073, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_1076, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_1079, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_107b, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x18_107d, 4); pushw(memw_a16[ds, 0x1b6a]);              /* push word [0x1b6a] */
            ii(0x18_1081, 4); pushw(memw_a16[ds, 0x1b68]);              /* push word [0x1b68] */
            ii(0x18_1085, 1); pushw(cs);                                /* push cs */
            ii(0x18_1086, 3); callw(0x18_0f0c, -0x17d);                 /* call 0xf0c */
            ii(0x18_1089, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x18_108c, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x18_108f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_1091, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_1094, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x18_1097, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_109a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_109b, 1); leavew();                                 /* leave */
            ii(0x18_109c, 1); retfw(); return;                          /* retf */
        }
    }
}
