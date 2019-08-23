using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_537c-2885bab4")]
        public void Method_1015_537c()
        {
            ii(0x1015_537c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_5381, 5); calld(Definitions.sys_check_available_stack_size, 0x1_09cc); /* call 0x10165d52 */
            ii(0x1015_5386, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_5387, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_5388, 1); pushd(edx);                             /* push edx */
            ii(0x1015_5389, 1); pushd(esi);                             /* push esi */
            ii(0x1015_538a, 1); pushd(edi);                             /* push edi */
            ii(0x1015_538b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_538c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_538e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_5394, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_5397, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_539a, 4); mov(ax, memw_a32[ds, eax + 0x16]);      /* mov ax, [eax+0x16] */
            ii(0x1015_539e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_53a1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_53a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_53a6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_53a7, 1); popd(edi);                              /* pop edi */
            ii(0x1015_53a8, 1); popd(esi);                              /* pop esi */
            ii(0x1015_53a9, 1); popd(edx);                              /* pop edx */
            ii(0x1015_53aa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_53ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_53ac, 1); retd();                                 /* ret */
        }
    }
}
