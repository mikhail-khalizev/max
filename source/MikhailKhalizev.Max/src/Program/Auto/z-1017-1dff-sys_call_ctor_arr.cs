using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1dff-d7d4178f")]
        public void /* sys */ sys_call_ctor_arr()
        {
            ii(0x1017_1dff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_1e00, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_1e02, 5); mov(ecx, Definitions.sys_delete_arr);   /* mov ecx, 0x10165fd8 */
            ii(0x1017_1e07, 5); calld(/* sys */ 0x1017_1d6c, -0xa0);    /* call 0x10171d6c */
            ii(0x1017_1e0c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_1e0d, 1); retd(); return;                         /* ret */
        }
    }
}
