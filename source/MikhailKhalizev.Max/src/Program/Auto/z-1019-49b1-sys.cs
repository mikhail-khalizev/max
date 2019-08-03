using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e6f353e6-7819-47c8-9635-c824fc0eb291")]
        public void /* sys */ Method_1019_49b1()
        {
            ii(0x1019_49b1, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_49b4, 1); popd(edi);                              /* pop edi */
            ii(0x1019_49b5, 1); popd(esi);                              /* pop esi */
            ii(0x1019_49b6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_49b7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_49b8, 1); retd(); return;                         /* ret */
        }
    }
}