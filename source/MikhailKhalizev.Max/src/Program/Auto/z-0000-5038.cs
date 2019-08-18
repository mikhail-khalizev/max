using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5038-a84dea10")]
        public void Method_0000_5038()
        {
            ii(0x5038, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x503a, 3);    mov(si, memw_a16[ds, bx + 0x2]);          /* mov si, [bx+0x2] */
            ii(0x503d, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x503f, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x5041, 3);    mov(bx, 0x8);                             /* mov bx, 0x8 */
            ii(0x5044, 1);    cld();                                    /* cld */
            ii(0x5045, 1);    cli();                                    /* cli */
            ii(0x5046, 3);    mov(di, 0x20);                            /* mov di, 0x20 */
        l_0x5049:
            ii(0x5049, 5);    cmp(memb_a16[ds, bx + 0x10be], 0);        /* cmp byte [bx+0x10be], 0x0 */
            ii(0x504e, 2);    if(jnzw(0x505a, 0xa)) goto l_0x505a;      /* jnz 0x505a */
        l_0x5050:
            ii(0x5050, 1);    cmpsw_a16();                              /* cmpsw */
            ii(0x5051, 1);    cmpsw_a16();                              /* cmpsw */
        l_0x5052:
            ii(0x5052, 1);    inc(bx);                                  /* inc bx */
            ii(0x5053, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0x5056, 2);    if(jbew(0x5049, -0xf)) goto l_0x5049;     /* jbe 0x5049 */
            ii(0x5058, 2);    if(jmpw_func(0x5035, -0x25)) return;      /* jmp 0x5035 */
        l_0x505a:
            ii(0x505a, 4);    cmp(bl, memb_a16[ds, 0x34]);              /* cmp bl, [0x34] */
            ii(0x505e, 2);    if(jzw(0x5050, -0x10)) goto l_0x5050;     /* jz 0x5050 */
            ii(0x5060, 1);    movsw_a16();                              /* movsw */
            ii(0x5061, 1);    movsw_a16();                              /* movsw */
            ii(0x5062, 2);    jmpw(0x5052, -0x12); goto l_0x5052;       /* jmp 0x5052 */
        }
    }
}
