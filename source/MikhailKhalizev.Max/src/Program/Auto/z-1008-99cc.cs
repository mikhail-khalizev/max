using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e10574e4-7e6e-4ea1-a432-8cb2a6609d6c")]
        public void Method_1008_99cc()
        {
            ii(0x1008_99cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_99d1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c37c); /* call 0x10165d52 */
            ii(0x1008_99d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_99d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_99d8, 1); pushd(edx);                             /* push edx */
            ii(0x1008_99d9, 1); pushd(esi);                             /* push esi */
            ii(0x1008_99da, 1); pushd(edi);                             /* push edi */
            ii(0x1008_99db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_99dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_99de, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_99e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_99e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_99ea, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_99ec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_99ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_99f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_99f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_99f5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_99f6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_99f7, 1); popd(edx);                              /* pop edx */
            ii(0x1008_99f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_99f9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_99fa, 1); retd(); return;                         /* ret */
        }
    }
}
