using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1caccbe7-703c-4955-b15d-3eca22007a52")]
        public void Method_1013_1a64()
        {
            ii(0x1013_1a64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1a69, 5); calld(Definitions.sys_check_available_stack_size, 0x3_42e4); /* call 0x10165d52 */
            ii(0x1013_1a6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1a6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1a70, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1a71, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1a72, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1a73, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1a74, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1a76, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1a7c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1a7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1a82, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1013_1a85, 5); calld(0x1007_65d0, -0xb_b4ba);          /* call 0x100765d0 */
            ii(0x1013_1a8a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1a8d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1a90, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1a92, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1a93, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1a94, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1a95, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1a96, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1a97, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1a98, 1); retd(); return;                         /* ret */
        }
    }
}
