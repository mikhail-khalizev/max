using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d44e9dd2-5f54-41e0-b710-a478bc5655b7")]
        public void Method_0000_60db()
        {
            ii(0x60db, 1);    cli();                                    /* cli */
            ii(0x60dc, 2);    pushw(0x38);                              /* push 0x38 */
            ii(0x60de, 1);    popw(es);                                 /* pop es */
            ii(0x60df, 6);    movzx(esi, memw_a16[ds, 0xaa]);           /* movzx esi, word [0xaa] */
            ii(0x60e5, 4);    add(si, 0x100);                           /* add si, 0x100 */
            ii(0x60e9, 4);    shl(esi, 0x4);                            /* shl esi, 0x4 */
            ii(0x60ed, 5);    cmp(memb_a16[ds, 0xdff], 0);              /* cmp byte [0xdff], 0x0 */
            ii(0x60f2, 2);    if(jzw(0x60fa, 0x6)) goto l_0x60fa;       /* jz 0x60fa */
            ii(0x60f4, 6);    mov(esi, 0x3f_f000);                      /* mov esi, 0x3ff000 */
        l_0x60fa:
            ii(0x60fa, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x60fc, 2);    mov(fs, cx);                              /* mov fs, cx */
            ii(0x60fe, 2);    mov(gs, cx);                              /* mov gs, cx */
            ii(0x6100, 1);    retfw(); return;                          /* retf */
        }
    }
}
