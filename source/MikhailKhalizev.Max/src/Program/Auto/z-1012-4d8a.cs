using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8771e0d-68ce-4734-8ccc-42fe03092afb")]
        public void Method_1012_4d8a()
        {
            ii(0x1012_4d8a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_4d8f, 5); calld(Definitions.sys_check_available_stack_size, 0x40fbe); /* call 0x10165d52 */
            ii(0x1012_4d94, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4d95, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_4d96, 1); pushd(edx);                             /* push edx */
            ii(0x1012_4d97, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4d98, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4d99, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4d9a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4d9c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_4da2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_4da5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_4da7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_4daa, 5); calld(Definitions.sys_strlen, 0x4d118); /* call 0x10171ec7 */
            ii(0x1012_4daf, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1012_4db2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_4db4, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1012_4db6, 5); calld(0x1012_4890, -0x52b);             /* call 0x10124890 */
            ii(0x1012_4dbb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_4dbd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_4dc2, 5); mov(eax, StringDefinitions.Control29);  /* mov eax, 0x101a8184 */
            ii(0x1012_4dc7, 5); calld(0x1012_4890, -0x53c);             /* call 0x10124890 */
            ii(0x1012_4dcc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4dce, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4dcf, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4dd0, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4dd1, 1); popd(edx);                              /* pop edx */
            ii(0x1012_4dd2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4dd3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4dd4, 1); retd(); return;                         /* ret */
        }
    }
}
