using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cb74-b70b8a0f")]
        public void Method_1009_cb74()
        {
            ii(0x1009_cb74, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_cb75, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cb76, 1); pushd(edx);                             /* push edx */
            ii(0x1009_cb77, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cb78, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cb79, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cb7a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cb7c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_cb82, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1009_cb86, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1009_cb89, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cb8b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_cb8c, 1); popd(edi);                              /* pop edi */
            ii(0x1009_cb8d, 1); popd(esi);                              /* pop esi */
            ii(0x1009_cb8e, 1); popd(edx);                              /* pop edx */
            ii(0x1009_cb8f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_cb90, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_cb91, 1); retd(); return;                         /* ret */
        }
    }
}