using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bc1a-9ce24c5c")]
        public void Method_1013_bc1a()
        {
            ii(0x1013_bc1a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_bc1f, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a12e); /* call 0x10165d52 */
            ii(0x1013_bc24, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bc25, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bc26, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bc27, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bc28, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bc29, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bc2b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_bc31, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bc34, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_bc37, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1013_bc3c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_bc3f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bc42, 5); calld(0x1013_ba86, -0x1c1);             /* call 0x1013ba86 */
            ii(0x1013_bc47, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bc49, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bc4a, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bc4b, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bc4c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bc4d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bc4e, 1); retd();                                 /* ret */
        }
    }
}
