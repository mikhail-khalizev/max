using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x688b-c34d792e")]
        public void Method_0000_688b()
        {
            ii(0x688b, 1);    cli();                                    /* cli */
            ii(0x688c, 2);    pushw(0x38);                              /* push 0x38 */
            ii(0x688e, 1);    popw(es);                                 /* pop es */
            ii(0x688f, 6);    movzx(esi, memw_a16[ds, 0xaa]);           /* movzx esi, word [0xaa] */
            ii(0x6895, 4);    add(si, 0x100);                           /* add si, 0x100 */
            ii(0x6899, 4);    shl(esi, 0x4);                            /* shl esi, 0x4 */
            ii(0x689d, 5);    cmp(memb_a16[ds, 0xdff], 0);              /* cmp byte [0xdff], 0x0 */
            ii(0x68a2, 2);    if(jzw(0x68aa, 0x6)) goto l_0x68aa;       /* jz 0x68aa */
            ii(0x68a4, 6);    mov(esi, 0x3f_f000);                      /* mov esi, 0x3ff000 */
        l_0x68aa:
            ii(0x68aa, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x68ac, 2);    mov(fs, cx);                              /* mov fs, cx */
            ii(0x68ae, 2);    mov(gs, cx);                              /* mov gs, cx */
            ii(0x68b0, 1);    retfw();                                  /* retf */
        }
    }
}
