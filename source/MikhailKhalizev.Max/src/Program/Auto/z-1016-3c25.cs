using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f032259c-ada9-47b7-9dce-86b26e2c2a1e")]
        public void Method_1016_3c25()
        {
            ii(0x1016_3c25, 5); mov(ecx, 0x1fd8);                       /* mov ecx, 0x1fd8 */
            ii(0x1016_3c2a, 5); mov(ebx, StringDefinitions.UnitsmgrCpp); /* mov ebx, 0x101b2b0d */
            ii(0x1016_3c2f, 5); mov(edx, StringDefinitions.UnitvaluesGetattributeCalledWithInvalidIndex); /* mov edx, 0x101b2b1a */
            ii(0x1016_3c34, 5); mov(eax, StringDefinitions.False2);     /* mov eax, 0x101b2b4e */
            ii(0x1016_3c39, 5); calld(0x100f_07d4, -0x7346a);           /* call 0x100f07d4 */
            ii(0x1016_3c3e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3c41, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1016_3c44, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_3c47, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3c4a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3c4c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3c4d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3c4e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3c4f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3c50, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3c51, 1); retd(); return;                         /* ret */
        }
    }
}
