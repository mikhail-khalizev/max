using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6a2c-76cb9436")]
        public void Method_1010_6a2c()
        {
            ii(0x1010_6a2c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_6a31, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f31c); /* call 0x10165d52 */
            ii(0x1010_6a36, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6a37, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6a38, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6a39, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6a3a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6a3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6a3d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_6a43, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_6a46, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_6a49, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1010_6a4e, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x1010_6a51, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6a54, 5); calld(0x1013_c055, 0x3_55fc);           /* call 0x1013c055 */
            ii(0x1010_6a59, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6a5b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6a5c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6a5d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6a5e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6a5f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6a60, 1); retd(); return;                         /* ret */
        }
    }
}
