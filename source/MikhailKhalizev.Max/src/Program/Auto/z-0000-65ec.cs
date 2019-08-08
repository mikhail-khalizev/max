using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a28659ac-ee4c-4e0c-a526-1a2e4f572758")]
        public void Method_0000_65ec()
        {
            ii(0x65ec, 1);    pushw(bx);                                /* push bx */
            ii(0x65ed, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0x65ef, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x65f2, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x65f4, 1);    popw(es);                                 /* pop es */
            ii(0x65f5, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x65f8, 1);    cli();                                    /* cli */
            ii(0x65f9, 3);    xchg(memw_a16[es, bx], ax);               /* xchg [es:bx], ax */
            ii(0x65fc, 2);    mov(ss, bx);                              /* mov ss, bx */
            ii(0x65fe, 3);    xchg(memw_a16[es, bx], ax);               /* xchg [es:bx], ax */
            ii(0x6601, 1);    popw(bx);                                 /* pop bx */
            ii(0x6602, 2);    if(jmpw_func(0x660b, 0x7)) return;        /* jmp 0x660b */
        }
    }
}
