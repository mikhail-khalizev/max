using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b688309e-a46d-48ae-b220-e36991edfbc1")]
        public void Method_1007_6054()
        {
            ii(0x1007_6054, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6055, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6056, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6057, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6058, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6059, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_605a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_605c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_6062, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1007_6066, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1007_6069, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_606b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_606c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_606d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_606e, 1); popd(edx);                              /* pop edx */
            ii(0x1007_606f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6070, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6071, 1); retd(); return;                         /* ret */
        }
    }
}
