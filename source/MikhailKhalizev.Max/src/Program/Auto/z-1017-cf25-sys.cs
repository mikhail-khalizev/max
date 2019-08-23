using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_cf25-bdd120c0")]
        public void /* sys */ Method_1017_cf25()
        {
            ii(0x1017_cf25, 1); push(ebx);                              /* push ebx */
            ii(0x1017_cf26, 1); push(edx);                              /* push edx */
            ii(0x1017_cf27, 4); lea(eax, memd[ss, esp + 0x14]);         /* lea eax, [esp+0x14] */
            ii(0x1017_cf2b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1017_cf2e, 3); mov(eax, memd[ds, eax - 0x4]);          /* mov eax, [eax-0x4] */
            ii(0x1017_cf31, 1); push(eax);                              /* push eax */
            ii(0x1017_cf32, 2); push(0);                                /* push 0x0 */
            ii(0x1017_cf34, 4); mov(edx, memd[ss, esp + 0x18]);         /* mov edx, [esp+0x18] */
            ii(0x1017_cf38, 1); push(edx);                              /* push edx */
            ii(0x1017_cf39, 4); mov(ebx, memd[ss, esp + 0x18]);         /* mov ebx, [esp+0x18] */
            ii(0x1017_cf3d, 1); push(ebx);                              /* push ebx */
            ii(0x1017_cf3e, 5); call(/* sys */ 0x1017_cf49, 0x6);       /* call 0x1017cf49 */
            ii(0x1017_cf43, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_cf46, 1); pop(edx);                               /* pop edx */
            ii(0x1017_cf47, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_cf48, 1); ret();                                  /* ret */
        }
    }
}
