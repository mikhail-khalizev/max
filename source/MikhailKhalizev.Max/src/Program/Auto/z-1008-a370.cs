using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a61211fa-c534-480e-a3dd-84852af9859b")]
        public void Method_1008_a370()
        {
            ii(0x1008_a370, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a375, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b9d8); /* call 0x10165d52 */
            ii(0x1008_a37a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a37b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a37c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a37d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a37e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a37f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a380, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a382, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a388, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a38b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a38e, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_a391, 5); calld(0x1007_65d0, -0x1_3dc6);          /* call 0x100765d0 */
            ii(0x1008_a396, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a399, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a39c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a39e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a39f, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a3a0, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a3a1, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a3a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a3a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a3a4, 1); retd(); return;                         /* ret */
        }
    }
}
