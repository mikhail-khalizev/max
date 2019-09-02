using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x428f-c1383515")]
        public void Method_0000_428f()
        {
            ii(0x428f, 1);    cli();                                    /* cli */
            ii(0x4290, 1);    push(ax);                                 /* push ax */
            ii(0x4291, 1);    push(ds);                                 /* push ds */
            ii(0x4292, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x4295, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x4297, 4);    mov(memw[ds, 0xf7c], ss);                 /* mov [0xf7c], ss */
            ii(0x429b, 4);    mov(memw[ds, 0xf7a], sp);                 /* mov [0xf7a], sp */
            ii(0x429f, 4);    cmp(memw[ds, 0xf7c], ax);                 /* cmp [0xf7c], ax */
            ii(0x42a3, 2);    if(jz_func(0x4274, -0x31)) return;        /* jz 0x4274 */
            ii(0x42a5, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0x42a7, 4);    mov(sp, memw[ds, 0x996]);                 /* mov sp, [0x996] */
            ii(0x42ab, 4);    sub(sp, 0x180);                           /* sub sp, 0x180 */
            ii(0x42af, 1);    pusha();                                  /* pusha */
            ii(0x42b0, 1);    push(es);                                 /* push es */
            ii(0x42b1, 1);    push(ds);                                 /* push ds */
            ii(0x42b2, 4);    push(memw[ds, 0xf7c]);                    /* push word [0xf7c] */
            ii(0x42b6, 4);    push(memw[ds, 0x996]);                    /* push word [0x996] */
            ii(0x42ba, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x42bc, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x42be, 4);    lds(si, memw[ds, 0xf7a]);                 /* lds si, [0xf7a] */
            ii(0x42c2, 1);    cld();                                    /* cld */
            ii(0x42c3, 1);    lodsw();                                  /* lodsw */
            ii(0x42c4, 3);    mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
            ii(0x42c7, 3);    lea(di, memw[ss, bp + 22]);               /* lea di, [bp+0x16] */
            ii(0x42ca, 1);    movsw();                                  /* movsw */
            ii(0x42cb, 1);    movsw();                                  /* movsw */
            ii(0x42cc, 2);    movsd();                                  /* movsd */
            ii(0x42ce, 3);    mov(memw[ss, bp + 14], si);               /* mov [bp+0xe], si */
            ii(0x42d1, 2);    movsd();                                  /* movsd */
            ii(0x42d3, 2);    movsd();                                  /* movsd */
            ii(0x42d5, 2);    movsd();                                  /* movsd */
            ii(0x42d7, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x42da, 2);    mov(ds, ax);                              /* mov ds, ax */
        }
    }
}
