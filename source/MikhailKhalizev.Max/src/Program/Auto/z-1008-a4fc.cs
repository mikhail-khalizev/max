using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e68d5302-091a-4abd-9f4a-65e868b47ee3")]
        public void Method_1008_a4fc()
        {
            ii(0x1008_a4fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a4fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a4fe, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a4ff, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a500, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a501, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a502, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a504, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_a50a, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x1008_a511, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a514, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a516, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a517, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a518, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a519, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a51a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a51b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a51c, 1); retd(); return;                         /* ret */
        }
    }
}
