using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1b38-14c2d45c")]
        public void Method_1013_1b38()
        {
            ii(0x1013_1b38, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1b3d, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4210); /* call 0x10165d52 */
            ii(0x1013_1b42, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1b43, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1b44, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1b45, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1b46, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1b47, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1b48, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1b4a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1b50, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1b53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1b56, 5); calld(0x1007_6c30, -0xb_af2b);          /* call 0x10076c30 */
            ii(0x1013_1b5b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1b5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1b61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1b63, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1b64, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1b65, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1b66, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1b67, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1b68, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1b69, 1); retd(); return;                         /* ret */
        }
    }
}
