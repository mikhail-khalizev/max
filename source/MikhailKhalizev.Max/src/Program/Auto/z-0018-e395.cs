using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e395-db388519")]
        public void Method_0018_e395()
        {
            ii(0x18_e395, 4); mov(bl, memb_a32[ss, ebp + 20]);          /* mov bl, [ebp+0x14] */
            ii(0x18_e399, 3); cmp(bl, 0x10);                            /* cmp bl, 0x10 */
            ii(0x18_e39c, 2); if(ja_func(0x18_e392, -0xc)) return;      /* ja 0xe392 */
            ii(0x18_e39e, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_e3a0, 1); pop(ds);                                  /* pop ds */
            ii(0x18_e3a1, 2); xor(bh, bh);                              /* xor bh, bh */
            ii(0x18_e3a3, 1); push(bx);                                 /* push bx */
            ii(0x18_e3a4, 2); push(0);                                  /* push 0x0 */
            ii(0x18_e3a6, 3); call(0x18_e868, 0x4bf);                   /* call 0xe868 */
            ii(0x18_e3a9, 3); call(0x18_e958, 0x5ac);                   /* call 0xe958 */
            ii(0x18_e3ac, 1); pop(bx);                                  /* pop bx */
            ii(0x18_e3ad, 1); pop(di);                                  /* pop di */
            ii(0x18_e3ae, 3); imul(di, di, 0x1c);                       /* imul di, di, 0x1c */
            ii(0x18_e3b1, 5); mov(eax, memd_a32[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x18_e3b6, 5); mov(memd[ds, bx + di + 16937], eax);      /* mov [bx+di+0x4229], eax */
            ii(0x18_e3bb, 4); mov(ax, memw_a32[ss, ebp + 28]);          /* mov ax, [ebp+0x1c] */
            ii(0x18_e3bf, 4); mov(memw[ds, bx + di + 16941], ax);       /* mov [bx+di+0x422d], ax */
            ii(0x18_e3c3, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x18_e3c7, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x18_e3cc, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x18_e3ce, 4); and(memw[ds, bx + di + 16939], cx);       /* and [bx+di+0x422b], cx */
            ii(0x18_e3d2, 3); if(jmp_func(0x18_e067, -0x36e)) return;   /* jmp 0xe067 */
        }
    }
}
