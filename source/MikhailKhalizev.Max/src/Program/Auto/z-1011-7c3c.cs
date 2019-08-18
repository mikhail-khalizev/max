using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f59c201-c0db-4297-8e9e-bf1b5c09e53f")]
        public void Method_1011_7c3c()
        {
            ii(0x1011_7c3c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_7c41, 5); calld(Definitions.sys_check_available_stack_size, 0x4_e10c); /* call 0x10165d52 */
            ii(0x1011_7c46, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7c47, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7c48, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7c49, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7c4a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7c4b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7c4d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_7c53, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7c56, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7c59, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_7c5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7c5f, 5); calld(0x1013_a2ab, 0x2_2647);           /* call 0x1013a2ab */
            ii(0x1011_7c64, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7c66, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7c67, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7c68, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7c69, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7c6a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7c6b, 1); retd(); return;                         /* ret */
        }
    }
}
