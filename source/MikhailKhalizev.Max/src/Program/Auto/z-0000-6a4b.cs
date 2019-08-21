using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6a4b-83340395")]
        public void Method_0000_6a4b()
        {
            ii(0x6a4b, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x6a4d, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x6a4f, 1);    cli();                                    /* cli */
            ii(0x6a50, 1);    pushw(ax);                                /* push ax */
            ii(0x6a51, 1);    pushw(ds);                                /* push ds */
            ii(0x6a52, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x6a55, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x6a57, 4);    mov(memw_a16[ds, 0xf7c], ss);             /* mov [0xf7c], ss */
            ii(0x6a5b, 4);    mov(memw_a16[ds, 0xf7a], sp);             /* mov [0xf7a], sp */
            ii(0x6a5f, 4);    cmp(memw_a16[ds, 0xf7c], ax);             /* cmp [0xf7c], ax */
            ii(0x6a63, 2);    if(jzw_func(0x6a34, -0x31)) return;       /* jz 0x6a34 */
            ii(0x6a65, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0x6a67, 4);    mov(sp, memw_a16[ds, 0x996]);             /* mov sp, [0x996] */
            ii(0x6a6b, 4);    sub(sp, 0x180);                           /* sub sp, 0x180 */
            ii(0x6a6f, 1);    pusha();                                  /* pusha */
            ii(0x6a70, 1);    pushw(es);                                /* push es */
            ii(0x6a71, 1);    pushw(ds);                                /* push ds */
            ii(0x6a72, 4);    pushw(memw_a16[ds, 0xf7c]);               /* push word [0xf7c] */
            ii(0x6a76, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x6a7a, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6a7c, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x6a7e, 4);    lds(si, ds, 0xf7a);                       /* lds si, [0xf7a] */
            ii(0x6a82, 1);    cld();                                    /* cld */
            ii(0x6a83, 1);    lodsw_a16();                              /* lodsw */
            ii(0x6a84, 3);    mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0x6a87, 3);    lea(di, bp + 0x16);                       /* lea di, [bp+0x16] */
            ii(0x6a8a, 1);    movsw_a16();                              /* movsw */
            ii(0x6a8b, 1);    movsw_a16();                              /* movsw */
            ii(0x6a8c, 2);    movsd_a16();                              /* movsd */
            ii(0x6a8e, 3);    mov(memw_a16[ss, bp + 0xe], si);          /* mov [bp+0xe], si */
            ii(0x6a91, 2);    movsd_a16();                              /* movsd */
            ii(0x6a93, 2);    movsd_a16();                              /* movsd */
            ii(0x6a95, 2);    movsd_a16();                              /* movsd */
            ii(0x6a97, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x6a9a, 2);    mov(ds, ax);                              /* mov ds, ax */
        }
    }
}
