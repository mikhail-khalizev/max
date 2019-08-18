using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0310529a-85d7-484c-a7c4-f317aa3c3b26")]
        public void Method_1012_0b8c()
        {
            ii(0x1012_0b8c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_0b91, 5); calld(Definitions.sys_check_available_stack_size, 0x4_51bc); /* call 0x10165d52 */
            ii(0x1012_0b96, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0b97, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0b98, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0b99, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0b9a, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0b9b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0b9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0b9e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_0ba4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_0ba7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_0baa, 5); calld(0x1008_b410, -0x9_579f);          /* call 0x1008b410 */
            ii(0x1012_0baf, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1012_0bb2, 5); calld(0x1009_cb94, -0x8_4023);          /* call 0x1009cb94 */
            ii(0x1012_0bb7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0bb9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0bba, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0bbb, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0bbc, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0bbd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0bbe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0bbf, 1); retd(); return;                         /* ret */
        }
    }
}
