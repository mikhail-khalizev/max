using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d587000f-604c-4875-90af-09437d2c3e17")]
        public void Method_1008_9dd8()
        {
            ii(0x1008_9dd8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9ddd, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bf70); /* call 0x10165d52 */
            ii(0x1008_9de2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9de3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9de4, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9de5, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9de6, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9de7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9de8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9dea, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9df0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9df3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9df6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_9df8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9dfb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9dfe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9e00, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9e01, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9e02, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9e03, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9e04, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9e05, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9e06, 1); retd(); return;                         /* ret */
        }
    }
}