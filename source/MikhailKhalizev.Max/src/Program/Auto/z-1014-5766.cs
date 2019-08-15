using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f45fda82-cda3-4669-81de-acfa9e64e7ac")]
        public void Method_1014_5766()
        {
            ii(0x1014_5766, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_576b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_05e2); /* call 0x10165d52 */
            ii(0x1014_5770, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5771, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5772, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5773, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5774, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5775, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5777, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_577d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_5780, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_5783, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_5786, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5789, 5); calld(0x1013_b518, -0xa276);            /* call 0x1013b518 */
            ii(0x1014_578e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5791, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5794, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5796, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5797, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5798, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5799, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_579a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_579b, 1); retd(); return;                         /* ret */
        }
    }
}
