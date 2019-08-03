using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("40732364-a09e-417b-84b7-a5966a4d3b63")]
        public void Method_1008_9894()
        {
            ii(0x1008_9894, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9899, 5); calld(Definitions.sys_check_available_stack_size, 0xdc4b4); /* call 0x10165d52 */
            ii(0x1008_989e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_989f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_98a0, 1); pushd(edx);                             /* push edx */
            ii(0x1008_98a1, 1); pushd(esi);                             /* push esi */
            ii(0x1008_98a2, 1); pushd(edi);                             /* push edi */
            ii(0x1008_98a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_98a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_98a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_98ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_98af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_98b2, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1008_98b5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_98b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_98bb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_98bd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_98be, 1); popd(edi);                              /* pop edi */
            ii(0x1008_98bf, 1); popd(esi);                              /* pop esi */
            ii(0x1008_98c0, 1); popd(edx);                              /* pop edx */
            ii(0x1008_98c1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_98c2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_98c3, 1); retd(); return;                         /* ret */
        }
    }
}
