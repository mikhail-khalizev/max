using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bbd8a2d9-bbe9-44ed-a1b0-c206da6ecd49")]
        public void Method_1011_52f4()
        {
            ii(0x1011_52f4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_52f5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_52f6, 1); pushd(edx);                             /* push edx */
            ii(0x1011_52f7, 1); pushd(esi);                             /* push esi */
            ii(0x1011_52f8, 1); pushd(edi);                             /* push edi */
            ii(0x1011_52f9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_52fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_52fc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_5302, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1011_5309, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_530c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_530e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_530f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5310, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5311, 1); popd(edx);                              /* pop edx */
            ii(0x1011_5312, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_5313, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5314, 1); retd(); return;                         /* ret */
        }
    }
}
