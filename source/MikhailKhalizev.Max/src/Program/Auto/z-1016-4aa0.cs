using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90004924-e9d0-4b1d-9469-9b2edd422d03")]
        public void Method_1016_4aa0()
        {
            ii(0x1016_4aa0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_4aa5, 5); calld(Definitions.sys_check_available_stack_size, 0x12a8); /* call 0x10165d52 */
            ii(0x1016_4aaa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4aab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4aac, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4aad, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4aae, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4aaf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4ab0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4ab2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_4ab8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4abb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4abe, 5); calld(0x1007_6b58, -0xedf6b);           /* call 0x10076b58 */
            ii(0x1016_4ac3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4ac6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4ac9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4acb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4acc, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4acd, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4ace, 1); popd(edx);                              /* pop edx */
            ii(0x1016_4acf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4ad0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4ad1, 1); retd(); return;                         /* ret */
        }
    }
}
