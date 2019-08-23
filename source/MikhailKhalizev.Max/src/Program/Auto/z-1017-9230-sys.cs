using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9230-4089f7e")]
        public void /* sys */ Method_1017_9230()
        {
            ii(0x1017_9230, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_9231, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_9233, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1017_9235, 2); mov(ah, 0x19);                          /* mov ah, 0x19 */
            ii(0x1017_9237, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_9239, 2); inc(ax);                                /* inc ax */
            ii(0x1017_923b, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1017_923d, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1017_923f, 3); sub(ax, ax);                            /* sub ax, ax */
            ii(0x1017_9242, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_9243, 1); retd();                                 /* ret */
        }
    }
}
