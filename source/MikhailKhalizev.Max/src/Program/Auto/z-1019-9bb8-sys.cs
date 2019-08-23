using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_9bb8-d24e3b2b")]
        public void /* sys */ Method_1019_9bb8()
        {
            ii(0x1019_9bb8, 2); pushw(ax);                              /* push ax */
            ii(0x1019_9bba, 1); wait();                                 /* wait */
            ii(0x1019_9bbb, 2); fninit();                               /* fninit */
            ii(0x1019_9bbd, 2); fld1();                                 /* fld1 */
            ii(0x1019_9bbf, 2); fldz();                                 /* fldz */
            ii(0x1019_9bc1, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1019_9bc3, 2); fld(ST(0));                             /* fld st0 */
            ii(0x1019_9bc5, 2); fchs();                                 /* fchs */
            ii(0x1019_9bc7, 2); fcompp();                               /* fcompp */
            ii(0x1019_9bc9, 2); fnstsw(ax);                             /* fnstsw ax */
            ii(0x1019_9bcb, 2); mov(al, 0x2);                           /* mov al, 0x2 */
            ii(0x1019_9bcd, 1); sahf();                                 /* sahf */
            ii(0x1019_9bce, 2); if(jz(0x1019_9bd2, 0x2)) goto l_0x1019_9bd2; /* jz 0x10199bd2 */
            ii(0x1019_9bd0, 2); mov(al, 0x3);                           /* mov al, 0x3 */
        l_0x1019_9bd2:
            ii(0x1019_9bd2, 1); wait();                                 /* wait */
            ii(0x1019_9bd3, 2); fninit();                               /* fninit */
            ii(0x1019_9bd5, 3); fldcw(memw[ss, esp]);                   /* fldcw word [esp] */
            ii(0x1019_9bd8, 4); xchg(memw[ss, esp], ax);                /* xchg [esp], ax */
            ii(0x1019_9bdc, 2); popw(ax);                               /* pop ax */
            ii(0x1019_9bde, 1); ret();                                  /* ret */
        }
    }
}
