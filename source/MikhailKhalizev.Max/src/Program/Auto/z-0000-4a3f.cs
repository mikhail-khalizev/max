using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4a3f-c1383515")]
        public void Method_0000_4a3f()
        {
            ii(0x4a3f, 1);    cli();                                    /* cli */
            ii(0x4a40, 1);    push(ax);                                 /* push ax */
            ii(0x4a41, 1);    push(ds);                                 /* push ds */
            ii(0x4a42, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x4a45, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x4a47, 4);    mov(memw[ds, 0xf7c], ss);                 /* mov [0xf7c], ss */
            ii(0x4a4b, 4);    mov(memw[ds, 0xf7a], sp);                 /* mov [0xf7a], sp */
            ii(0x4a4f, 4);    cmp(memw[ds, 0xf7c], ax);                 /* cmp [0xf7c], ax */
            ii(0x4a53, 2);    if(jz_func(0x4a24, -0x31)) return;        /* jz 0x4a24 */
            ii(0x4a55, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0x4a57, 4);    mov(sp, memw[ds, 0x996]);                 /* mov sp, [0x996] */
            ii(0x4a5b, 4);    sub(sp, 0x180);                           /* sub sp, 0x180 */
            ii(0x4a5f, 1);    pusha();                                  /* pusha */
            ii(0x4a60, 1);    push(es);                                 /* push es */
            ii(0x4a61, 1);    push(ds);                                 /* push ds */
            ii(0x4a62, 4);    push(memw[ds, 0xf7c]);                    /* push word [0xf7c] */
            ii(0x4a66, 4);    push(memw[ds, 0x996]);                    /* push word [0x996] */
            ii(0x4a6a, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4a6c, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x4a6e, 4);    lds(si, memw[ds, 0xf7a]);                 /* lds si, [0xf7a] */
            ii(0x4a72, 1);    cld();                                    /* cld */
            ii(0x4a73, 1);    lodsw();                                  /* lodsw */
            ii(0x4a74, 3);    mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
            ii(0x4a77, 3);    lea(di, memw[ss, bp + 22]);               /* lea di, [bp+0x16] */
            ii(0x4a7a, 1);    movsw();                                  /* movsw */
            ii(0x4a7b, 1);    movsw();                                  /* movsw */
            ii(0x4a7c, 2);    movsd();                                  /* movsd */
            ii(0x4a7e, 3);    mov(memw[ss, bp + 14], si);               /* mov [bp+0xe], si */
            ii(0x4a81, 2);    movsd();                                  /* movsd */
            ii(0x4a83, 2);    movsd();                                  /* movsd */
            ii(0x4a85, 2);    movsd();                                  /* movsd */
            ii(0x4a87, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x4a8a, 2);    mov(ds, ax);                              /* mov ds, ax */
        }
    }
}
