using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_8698-3cea57df")]
        public void /* sys */ Method_1016_8698()
        {
            ii(0x1016_8698, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_8699, 1); pushd(esi);                             /* push esi */
            ii(0x1016_869a, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_869c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_86a1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_86a3, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_86a5, 5); calld(Definitions.sys_fread_internal, 0x63c2); /* call 0x1016ea6c */
            ii(0x1016_86aa, 1); popd(esi);                              /* pop esi */
            ii(0x1016_86ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_86ac, 1); retd(); return;                         /* ret */
        }
    }
}
