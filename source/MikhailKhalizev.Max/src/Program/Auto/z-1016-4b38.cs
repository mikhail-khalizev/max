using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4b38-6b489c29")]
        public void Method_1016_4b38()
        {
            ii(0x1016_4b38, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4b39, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4b3a, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4b3b, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4b3c, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4b3d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4b3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4b40, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_4b46, 7); mov(memd_a32[ss, ebp - 0x4], StringDefinitions.Empty62); /* mov dword [ebp-0x4], 0x101b234e */
            ii(0x1016_4b4d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4b50, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4b52, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4b53, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4b54, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4b55, 1); popd(edx);                              /* pop edx */
            ii(0x1016_4b56, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4b57, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4b58, 1); retd(); return;                         /* ret */
        }
    }
}
