using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("577ade9d-d181-4a3c-a604-f6a929187611")]
        public void Method_100d_4e6c()
        {
            ii(0x100d_4e6c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4e6d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4e6e, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4e6f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4e70, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4e71, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4e72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4e74, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_4e7a, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100d_4e7e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_4e81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4e83, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4e84, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4e85, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4e86, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4e87, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4e88, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4e89, 1); retd(); return;                         /* ret */
        }
    }
}
