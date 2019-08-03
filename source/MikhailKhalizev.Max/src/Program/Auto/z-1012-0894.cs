using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe0ec66c-57ef-465a-8982-5b8049ade925")]
        public void Method_1012_0894()
        {
            ii(0x1012_0894, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0899, 5); calld(Definitions.sys_check_available_stack_size, 0x454b4); /* call 0x10165d52 */
            ii(0x1012_089e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_089f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_08a0, 1); pushd(edx);                             /* push edx */
            ii(0x1012_08a1, 1); pushd(esi);                             /* push esi */
            ii(0x1012_08a2, 1); pushd(edi);                             /* push edi */
            ii(0x1012_08a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_08a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_08a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_08ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_08af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_08b2, 5); calld(0x1007_6b58, -0xa9d5f);           /* call 0x10076b58 */
            ii(0x1012_08b7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_08ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_08bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_08bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_08c0, 1); popd(edi);                              /* pop edi */
            ii(0x1012_08c1, 1); popd(esi);                              /* pop esi */
            ii(0x1012_08c2, 1); popd(edx);                              /* pop edx */
            ii(0x1012_08c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_08c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_08c5, 1); retd(); return;                         /* ret */
        }
    }
}
