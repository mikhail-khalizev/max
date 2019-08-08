using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a37e32de-338b-4748-bac8-fa091acf8166")]
        public void Method_0014_e41e()
        {
            ii(0x14_e41e, 4); mov(al, memb_a32[ss, ebp + 0x14]);        /* mov al, [ebp+0x14] */
            ii(0x14_e422, 2); xor(ah, ah);                              /* xor ah, ah */
            ii(0x14_e424, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x14_e426, 2); cmp(al, 0x10);                            /* cmp al, 0x10 */
            ii(0x14_e428, 2); if(jbew_func(0x14_e416, -0x14)) return;   /* jbe 0xe416 */
            ii(0x14_e42a, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x14_e42c, 1); popw(es);                                 /* pop es */
            ii(0x14_e42d, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x14_e430, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x14_e434, 1); stosw_a16();                              /* stosw */
            ii(0x14_e435, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x14_e439, 1); stosw_a16();                              /* stosw */
            ii(0x14_e43a, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x14_e43e, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x14_e443, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x14_e445, 4); and(cx, memw_a32[ss, ebp + 0x1a]);        /* and cx, [ebp+0x1a] */
            ii(0x14_e449, 4); mov(memw_a16[es, di + 0x2], cx);          /* mov [es:di+0x2], cx */
            ii(0x14_e44d, 3); if(jmpw_func(0x14_e067, -0x3e9)) return;  /* jmp 0xe067 */
        }
    }
}
