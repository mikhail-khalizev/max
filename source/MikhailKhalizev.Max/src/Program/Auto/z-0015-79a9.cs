using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5158698-d54c-47cf-b809-e8cee59b085b")]
        public void Method_0015_79a9()
        {
            ii(0x15_79a9, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x15_79ad, 1); pushw(di);                                /* push di */
            ii(0x15_79ae, 1); pushw(si);                                /* push si */
            ii(0x15_79af, 5); callw_far_abs(0x80, 0x5740);              /* call word 0x80:0x5740 */
            ii(0x15_79b4, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_79b7, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_79ba, 3); jmpw(0x15_79bd, 0); goto l_0x15_79bd;     /* jmp 0x79bd */
        l_0x15_79bd:
            ii(0x15_79bd, 1); popw(si);                                 /* pop si */
            ii(0x15_79be, 1); popw(di);                                 /* pop di */
            ii(0x15_79bf, 1); leavew();                                 /* leave */
            ii(0x15_79c0, 1); retw(); return;                           /* ret */
        }
    }
}
