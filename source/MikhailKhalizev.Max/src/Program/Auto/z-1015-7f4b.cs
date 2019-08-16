using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bda878f4-b17a-4fc4-ad73-5b1b38ee9d03")]
        public void Method_1015_7f4b()
        {
            ii(0x1015_7f4b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_7f50, 5); calld(Definitions.sys_check_available_stack_size, 0xddfd); /* call 0x10165d52 */
            ii(0x1015_7f55, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_7f56, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_7f57, 1); pushd(esi);                             /* push esi */
            ii(0x1015_7f58, 1); pushd(edi);                             /* push edi */
            ii(0x1015_7f59, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_7f5a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7f5c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_7f62, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_7f65, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_7f68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7f6b, 5); calld(0x1015_7e4d, -0x123);             /* call 0x10157e4d */
            ii(0x1015_7f70, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7f72, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7f73, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7f74, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7f75, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_7f76, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_7f77, 1); retd(); return;                         /* ret */
        }
    }
}