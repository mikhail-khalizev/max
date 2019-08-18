using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6eb20e3a-a48c-4455-9977-088cd5053977")]
        public void Method_0000_aa09()
        {
            ii(0xaa09, 2);    pushd(esi);                               /* push esi */
            ii(0xaa0b, 2);    pushd(edi);                               /* push edi */
            ii(0xaa0d, 3);    xor(esi, esi);                            /* xor esi, esi */
            ii(0xaa10, 3);    xor(edi, edi);                            /* xor edi, edi */
            ii(0xaa13, 1);    pushw(ds);                                /* push ds */
            ii(0xaa14, 3);    mov(di, 0x7330);                          /* mov di, 0x7330 */
            ii(0xaa17, 4);    mov(es, memw_a16[ds, 0xc32]);             /* mov es, [0xc32] */
            ii(0xaa1b, 3);    mov(si, 0x744a);                          /* mov si, 0x744a */
            ii(0xaa1e, 1);    pushw(cs);                                /* push cs */
            ii(0xaa1f, 1);    popw(ds);                                 /* pop ds */
            ii(0xaa20, 3);    mov(ax, 0x303);                           /* mov ax, 0x303 */
            ii(0xaa23, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xaa25, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0xaa28, 2);    if(jbw(0xaa34, 0xa)) goto l_0xaa34;       /* jb 0xaa34 */
            ii(0xaa2a, 3);    mov(di, 0xf6e);                           /* mov di, 0xf6e */
            ii(0xaa2d, 2);    mov(al, 0xea);                            /* mov al, 0xea */
            ii(0xaa2f, 1);    stosb_a16();                              /* stosb */
            ii(0xaa30, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xaa31, 1);    stosw_a16();                              /* stosw */
            ii(0xaa32, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xaa33, 1);    stosw_a16();                              /* stosw */
        l_0xaa34:
            ii(0xaa34, 1);    popw(ds);                                 /* pop ds */
            ii(0xaa35, 2);    popd(edi);                                /* pop edi */
            ii(0xaa37, 2);    popd(esi);                                /* pop esi */
            ii(0xaa39, 1);    retw(); return;                           /* ret */
        }
    }
}
