using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b4554548-72bb-4dd0-bc56-80535915255e")]
        public void Method_100d_5134()
        {
            ii(0x100d_5134, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_5139, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0c14); /* call 0x10165d52 */
            ii(0x100d_513e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_513f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5140, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5141, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5142, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5143, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5145, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_514b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_514e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_5151, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5154, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5157, 3); mov(memd_a32[ds, edx + 0x20], eax);     /* mov [edx+0x20], eax */
            ii(0x100d_515a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_515c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_515d, 1); popd(edi);                              /* pop edi */
            ii(0x100d_515e, 1); popd(esi);                              /* pop esi */
            ii(0x100d_515f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5160, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5161, 1); retd(); return;                         /* ret */
        }
    }
}
