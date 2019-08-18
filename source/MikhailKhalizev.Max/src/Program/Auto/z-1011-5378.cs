using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("532a0adb-a03c-4d56-bcbc-d3adf0cc9f61")]
        public void Method_1011_5378()
        {
            ii(0x1011_5378, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5379, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_537a, 1); pushd(edx);                             /* push edx */
            ii(0x1011_537b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_537c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_537d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_537e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5380, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_5386, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_538a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_538d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_538f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5390, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5391, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5392, 1); popd(edx);                              /* pop edx */
            ii(0x1011_5393, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_5394, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5395, 1); retd(); return;                         /* ret */
        }
    }
}
