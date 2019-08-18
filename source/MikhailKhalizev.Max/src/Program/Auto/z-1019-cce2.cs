using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_cce2-36961f32")]
        public void Method_1019_cce2()
        {
            ii(0x1019_cce2, 1); pushd(eax);                             /* push eax */
            ii(0x1019_cce3, 4); fld(memq_a32[ss, esp + 0x8]);           /* fld qword [esp+0x8] */
            ii(0x1019_cce7, 2); fld(ST(0));                             /* fld st0 */
            ii(0x1019_cce9, 5); calld(Definitions.sys_round, -0x3_6c70); /* call 0x1016607e */
            ii(0x1019_ccee, 2); fsub(ST(1), ST(0));                     /* fsub st1, st0 */
            ii(0x1019_ccf0, 4); mov(eax, memd_a32[ss, esp + 0x10]);     /* mov eax, [esp+0x10] */
            ii(0x1019_ccf4, 2); fstp(memq_a32[ds, eax]);                /* fstp qword [eax] */
            ii(0x1019_ccf6, 1); popd(eax);                              /* pop eax */
            ii(0x1019_ccf7, 1); wait();                                 /* wait */
            ii(0x1019_ccf8, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
