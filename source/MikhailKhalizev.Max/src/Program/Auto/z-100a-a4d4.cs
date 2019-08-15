using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("70c3b8a5-9a4c-4582-b192-c423d4067f81")]
        public void Method_100a_a4d4()
        {
            ii(0x100a_a4d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a4d9, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b874); /* call 0x10165d52 */
            ii(0x100a_a4de, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a4df, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a4e0, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a4e1, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a4e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a4e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a4e5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a4eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a4ee, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a4f1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a4f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a4f9, 5); calld(0x1013_b0a5, 0x9_0ba7);           /* call 0x1013b0a5 */
            ii(0x100a_a4fe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a501, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a504, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a507, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a50a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a50c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a50d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a50e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a50f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a510, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a511, 1); retd(); return;                         /* ret */
        }
    }
}
