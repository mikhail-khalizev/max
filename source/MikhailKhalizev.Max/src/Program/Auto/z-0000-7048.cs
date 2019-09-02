using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7048-a84dea10")]
        public void Method_0000_7048()
        {
            ii(0x7048, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x704a, 3);    mov(si, memw[ds, bx + 2]);                /* mov si, [bx+0x2] */
            ii(0x704d, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x704f, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x7051, 3);    mov(bx, 8);                               /* mov bx, 0x8 */
            ii(0x7054, 1);    cld();                                    /* cld */
            ii(0x7055, 1);    cli();                                    /* cli */
            ii(0x7056, 3);    mov(di, 0x20);                            /* mov di, 0x20 */
        l_0x7059:
            ii(0x7059, 5);    cmp(memb[ds, bx + 0x10be], 0);            /* cmp byte [bx+0x10be], 0x0 */
            ii(0x705e, 2);    if(jnz(0x706a, 0xa)) goto l_0x706a;       /* jnz 0x706a */
        l_0x7060:
            ii(0x7060, 1);    cmpsw();                                  /* cmpsw */
            ii(0x7061, 1);    cmpsw();                                  /* cmpsw */
        l_0x7062:
            ii(0x7062, 1);    inc(bx);                                  /* inc bx */
            ii(0x7063, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0x7066, 2);    if(jbe(0x7059, -0xf)) goto l_0x7059;      /* jbe 0x7059 */
            ii(0x7068, 2);    if(jmp_func(0x7045, -0x25)) return;       /* jmp 0x7045 */
        l_0x706a:
            ii(0x706a, 4);    cmp(bl, memb[ds, 0x34]);                  /* cmp bl, [0x34] */
            ii(0x706e, 2);    if(jz(0x7060, -0x10)) goto l_0x7060;      /* jz 0x7060 */
            ii(0x7070, 1);    movsw();                                  /* movsw */
            ii(0x7071, 1);    movsw();                                  /* movsw */
            ii(0x7072, 2);    jmp(0x7062, -0x12); goto l_0x7062;        /* jmp 0x7062 */
        }
    }
}
