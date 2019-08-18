using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fb00bd90-0f61-4c82-997c-63f478e2ef33")]
        public void Method_0000_65c4()
        {
            ii(0x65c4, 4);    mov(memw_a16[ds, 0xd66], gs);             /* mov [0xd66], gs */
            ii(0x65c8, 4);    mov(memw_a16[ds, 0xd64], fs);             /* mov [0xd64], fs */
            ii(0x65cc, 4);    mov(fs, memw_a16[ds, 0xd60]);             /* mov fs, [0xd60] */
            ii(0x65d0, 4);    mov(gs, memw_a16[ds, 0xd62]);             /* mov gs, [0xd62] */
            ii(0x65d4, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x65d6, 4);    cmp(memb_a16[ds, 0x35], al);              /* cmp [0x35], al */
            ii(0x65da, 2);    if(jnzw(0x65df, 0x3)) goto l_0x65df;      /* jnz 0x65df */
            ii(0x65dc, 3);    callw(0x4989, -0x1c56);                   /* call 0x4989 */
        l_0x65df:
            ii(0x65df, 5);    cmp(memb_a16[ds, 0x11f0], 0);             /* cmp byte [0x11f0], 0x0 */
            ii(0x65e4, 2);    if(jnzw(0x65eb, 0x5)) goto l_0x65eb;      /* jnz 0x65eb */
            ii(0x65e6, 2);    mov(cl, 0x9);                             /* mov cl, 0x9 */
            ii(0x65e8, 3);    if(jmpw_func(0x4662, -0x1f89)) return;    /* jmp 0x4662 */
        l_0x65eb:
            ii(0x65eb, 1);    retw(); return;                           /* ret */
        }
    }
}
