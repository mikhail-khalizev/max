using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb1b9-b7b77fa9")]
        public void Method_0000_b1b9()
        {
            ii(0xb1b9, 2);    pushd(esi);                               /* push esi */
            ii(0xb1bb, 2);    pushd(edi);                               /* push edi */
            ii(0xb1bd, 3);    xor(esi, esi);                            /* xor esi, esi */
            ii(0xb1c0, 3);    xor(edi, edi);                            /* xor edi, edi */
            ii(0xb1c3, 1);    pushw(ds);                                /* push ds */
            ii(0xb1c4, 3);    mov(di, 0x7330);                          /* mov di, 0x7330 */
            ii(0xb1c7, 4);    mov(es, memw_a16[ds, 0xc32]);             /* mov es, [0xc32] */
            ii(0xb1cb, 3);    mov(si, 0x744a);                          /* mov si, 0x744a */
            ii(0xb1ce, 1);    pushw(cs);                                /* push cs */
            ii(0xb1cf, 1);    popw(ds);                                 /* pop ds */
            ii(0xb1d0, 3);    mov(ax, 0x303);                           /* mov ax, 0x303 */
            ii(0xb1d3, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xb1d5, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0xb1d8, 2);    if(jbw(0xb1e4, 0xa)) goto l_0xb1e4;       /* jb 0xb1e4 */
            ii(0xb1da, 3);    mov(di, 0xf6e);                           /* mov di, 0xf6e */
            ii(0xb1dd, 2);    mov(al, 0xea);                            /* mov al, 0xea */
            ii(0xb1df, 1);    stosb_a16();                              /* stosb */
            ii(0xb1e0, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xb1e1, 1);    stosw_a16();                              /* stosw */
            ii(0xb1e2, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xb1e3, 1);    stosw_a16();                              /* stosw */
        l_0xb1e4:
            ii(0xb1e4, 1);    popw(ds);                                 /* pop ds */
            ii(0xb1e5, 2);    popd(edi);                                /* pop edi */
            ii(0xb1e7, 2);    popd(esi);                                /* pop esi */
            ii(0xb1e9, 1);    retw();                                   /* ret */
        }
    }
}
