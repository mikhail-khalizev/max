using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3aff595c-1058-47a0-86bb-93298929aa15")]
        public void Method_1013_1cb4()
        {
            ii(0x1013_1cb4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1cb5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1cb6, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1cb7, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1cb8, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1cb9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1cba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1cbc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_1cc2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1cc5, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1013_1cca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1ccd, 5); calld(0x100d_4d78, -0x5cf5a);           /* call 0x100d4d78 */
            ii(0x1013_1cd2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1cd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1cd7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1cd8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1cd9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1cda, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1cdb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1cdc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1cdd, 1); retd(); return;                         /* ret */
        }
    }
}
