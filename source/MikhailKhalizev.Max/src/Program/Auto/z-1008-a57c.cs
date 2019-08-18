using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a57c-2bf2096")]
        public void Method_1008_a57c()
        {
            ii(0x1008_a57c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a581, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b7cc); /* call 0x10165d52 */
            ii(0x1008_a586, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a587, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a588, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a589, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a58a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a58b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a58c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a58e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a594, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a597, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a59a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_a59c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a59f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a5a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a5a4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a5a5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a5a6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a5a7, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a5a8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a5a9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a5aa, 1); retd(); return;                         /* ret */
        }
    }
}
