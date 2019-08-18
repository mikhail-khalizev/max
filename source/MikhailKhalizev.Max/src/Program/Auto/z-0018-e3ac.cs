using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e3ac-eb345006")]
        public void Method_0018_e3ac()
        {
            ii(0x18_e3ac, 1); popw(bx);                                 /* pop bx */
            ii(0x18_e3ad, 1); popw(di);                                 /* pop di */
            ii(0x18_e3ae, 3); imul(di, di, 0x1c);                       /* imul di, di, 0x1c */
            ii(0x18_e3b1, 5); mov(eax, memd_a32[ss, ebp + 0x18]);       /* mov eax, [ebp+0x18] */
            ii(0x18_e3b6, 5); mov(memd_a16[ds, bx + di + 0x4229], eax); /* mov [bx+di+0x4229], eax */
            ii(0x18_e3bb, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x18_e3bf, 4); mov(memw_a16[ds, bx + di + 0x422d], ax);  /* mov [bx+di+0x422d], ax */
            ii(0x18_e3c3, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x18_e3c7, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x18_e3cc, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x18_e3ce, 4); and(memw_a16[ds, bx + di + 0x422b], cx);  /* and [bx+di+0x422b], cx */
            ii(0x18_e3d2, 3); if(jmpw_func(0x18_e067, -0x36e)) return;  /* jmp 0xe067 */
        }
    }
}
