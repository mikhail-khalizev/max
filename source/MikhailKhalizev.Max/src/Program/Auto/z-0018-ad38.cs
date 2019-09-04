using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ad38-f14b8303")]
        public void Method_0018_ad38()
        {
            ii(0x18_ad38, 1); push(bx);                                 /* push bx */
            ii(0x18_ad39, 4); mov(bx, memw[ds, 0xc2c]);                 /* mov bx, [0xc2c] */
            ii(0x18_ad3d, 3); mov(ax, 6);                               /* mov ax, 0x6 */
            ii(0x18_ad40, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_ad42, 3); mov(bx, 0);                               /* mov bx, 0x0 */
            ii(0x18_ad45, 2); if(jb(0x18_ad54, 0xd)) goto l_0x18_ad54;  /* jb 0xad54 */
            ii(0x18_ad47, 3); mov(ax, 0x10);                            /* mov ax, 0x10 */
            ii(0x18_ad4a, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x18_ad4c, 2); if(jae(0x18_ad54, 6)) goto l_0x18_ad54;   /* jae 0xad54 */
            ii(0x18_ad4e, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x18_ad4f, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x18_ad50, 2); div(cx);                                  /* div cx */
            ii(0x18_ad52, 2); mov(bx, ax);                              /* mov bx, ax */
        l_0x18_ad54:
            ii(0x18_ad54, 4); mov(es, memw[ds, 0xc2a]);                 /* mov es, [0xc2a] */
            ii(0x18_ad58, 5); mov(memw[es, 0x2c], bx);                  /* mov [es:0x2c], bx */
            ii(0x18_ad5d, 1); pop(bx);                                  /* pop bx */
            ii(0x18_ad5e, 1); ret();                                    /* ret */
        }
    }
}
