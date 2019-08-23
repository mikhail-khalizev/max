using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0c64-8b03aae5")]
        public void Method_1012_0c64()
        {
            ii(0x1012_0c64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0c69, 5); calld(Definitions.sys_check_available_stack_size, 0x4_50e4); /* call 0x10165d52 */
            ii(0x1012_0c6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0c6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0c70, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0c71, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0c72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0c73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0c75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0c7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0c7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0c81, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0c84, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0c87, 5); calld(0x1013_acc5, 0x1_a039);           /* call 0x1013acc5 */
            ii(0x1012_0c8c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0c8f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0c92, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0c94, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0c95, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0c96, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0c97, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0c98, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0c99, 1); retd();                                 /* ret */
        }
    }
}
