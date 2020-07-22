using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x60db-c34d792e")]
        public void Method_0000_60db()
        {
            ii(0x60db, 1);  cli();                                     /* cli */
            ii(0x60dc, 2);  push(0x38);                                /* push 0x38 */
            ii(0x60de, 1);  pop(es);                                   /* pop es */
            ii(0x60df, 6);  movzx(esi, memw[ds, 0xaa]);                /* movzx esi, word [0xaa] */
            ii(0x60e5, 4);  add(si, 0x100);                            /* add si, 0x100 */
            ii(0x60e9, 4);  shl(esi, 4);                               /* shl esi, 0x4 */
            ii(0x60ed, 5);  cmp(memb[ds, 0xdff], 0);                   /* cmp byte [0xdff], 0x0 */
            ii(0x60f2, 2);  if(jz(0x60fa, 6)) goto l_0x60fa;           /* jz 0x60fa */
            ii(0x60f4, 6);  mov(esi, 0x3f_f000);                       /* mov esi, 0x3ff000 */
        l_0x60fa:
            ii(0x60fa, 2);  xor(cx, cx);                               /* xor cx, cx */
            ii(0x60fc, 2);  mov(fs, cx);                               /* mov fs, cx */
            ii(0x60fe, 2);  mov(gs, cx);                               /* mov gs, cx */
            ii(0x6100, 1);  retf();                                    /* retf */
        }
    }
}
