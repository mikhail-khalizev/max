using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3390b208-3704-4276-a58b-28afc0e1adb4")]
        public void Method_0019_41ac()
        {
            ii(0x19_41ac, 1); pushw(bp);                                /* push bp */
            ii(0x19_41ad, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_41af, 1); pushw(si);                                /* push si */
            ii(0x19_41b0, 1); pushw(di);                                /* push di */
            ii(0x19_41b1, 1); pushw(ds);                                /* push ds */
            ii(0x19_41b2, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_41b5, 3); lds(bx, ss, bp + 0xa);                    /* lds bx, [bp+0xa] */
            ii(0x19_41b8, 3); pushw(memw_a16[ds, bx + 0x10]);           /* push word [bx+0x10] */
            ii(0x19_41bb, 3); mov(dx, memw_a16[ds, bx + 0xe]);          /* mov dx, [bx+0xe] */
            ii(0x19_41be, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
            ii(0x19_41c1, 3); mov(di, memw_a16[ds, bx + 0x4]);          /* mov di, [bx+0x4] */
            ii(0x19_41c4, 3); mov(cx, memw_a16[ds, bx + 0x2]);          /* mov cx, [bx+0x2] */
            ii(0x19_41c7, 3); callw(0x19_40cc, -0xfe);                  /* call 0x40cc */
            ii(0x19_41ca, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_41cc, 2); mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0x19_41ce, 3); callw(0x19_40cc, -0x105);                 /* call 0x40cc */
            ii(0x19_41d1, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x19_41d3, 1); popw(cx);                                 /* pop cx */
            ii(0x19_41d4, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_41d7, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x19_41da, 3); callw(0x19_40b7, -0x126);                 /* call 0x40b7 */
            ii(0x19_41dd, 2); if(jzw(0x19_41f3, 0x14)) goto l_0x19_41f3; /* jz 0x41f3 */
            ii(0x19_41df, 4); movzx(edx, dx);                           /* movzx edx, dx */
            ii(0x19_41e3, 4); movzx(esi, si);                           /* movzx esi, si */
            ii(0x19_41e7, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x19_41eb, 4); movzx(ebx, bx);                           /* movzx ebx, bx */
            ii(0x19_41ef, 4); movzx(ecx, cx);                           /* movzx ecx, cx */
        l_0x19_41f3:
            ii(0x19_41f3, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_41f5, 1); pushw(bx);                                /* push bx */
            ii(0x19_41f6, 1); pushw(ds);                                /* push ds */
            ii(0x19_41f7, 3); lds(bx, ss, bp + 0xa);                    /* lds bx, [bp+0xa] */
            ii(0x19_41fa, 3); if(jmpw_func(0x19_4166, -0x97)) return;   /* jmp 0x4166 */
        }
    }
}
