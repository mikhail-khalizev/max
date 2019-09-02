using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_78a8-482bb83a")]
        public void /* sys */ Method_1018_78a8()
        {
            ii(0x1018_78a8, 1); push(eax);                              /* push eax */
            ii(0x1018_78a9, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1018_78ad, 5); and(eax, 0x7ff0_0000);                  /* and eax, 0x7ff00000 */
            ii(0x1018_78b2, 5); cmp(eax, 0x7ff0_0000);                  /* cmp eax, 0x7ff00000 */
            ii(0x1018_78b7, 2); if(jz(0x1018_78ec, 0x33)) goto l_0x1018_78ec; /* jz 0x101878ec */
            ii(0x1018_78b9, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1018_78bb, 5); and(eax, 0x3800);                       /* and eax, 0x3800 */
            ii(0x1018_78c0, 2); if(jz(0x1018_78cf, 0xd)) goto l_0x1018_78cf; /* jz 0x101878cf */
            ii(0x1018_78c2, 4); fld(memq[ss, esp + 8]);                 /* fld qword [esp+0x8] */
            ii(0x1018_78c6, 5); call(/* sys */ 0x1018_7823, -0xa8);     /* call 0x10187823 */
            ii(0x1018_78cb, 1); pop(eax);                               /* pop eax */
            ii(0x1018_78cc, 3); ret(8); return;                         /* ret 0x8 */
        l_0x1018_78cf:
            ii(0x1018_78cf, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_78d1, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_78d4, 3); fstp(memt[ss, esp]);                    /* fstp tword [esp] */
            ii(0x1018_78d7, 4); fld(memq[ss, esp + 0x14]);              /* fld qword [esp+0x14] */
            ii(0x1018_78db, 5); call(/* sys */ 0x1018_7823, -0xbd);     /* call 0x10187823 */
            ii(0x1018_78e0, 3); fld(memt[ss, esp]);                     /* fld tword [esp] */
            ii(0x1018_78e3, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_78e5, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1018_78e8, 1); pop(eax);                               /* pop eax */
            ii(0x1018_78e9, 3); ret(8); return;                         /* ret 0x8 */
        l_0x1018_78ec:
            ii(0x1018_78ec, 4); fdiv(memq[ss, esp + 8]);                /* fdiv qword [esp+0x8] */
            ii(0x1018_78f0, 1); pop(eax);                               /* pop eax */
            ii(0x1018_78f1, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
