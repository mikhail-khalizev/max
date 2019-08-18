using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ac70-7e93caef")]
        public void Method_1008_ac70()
        {
            ii(0x1008_ac70, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ac71, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_ac72, 1); pushd(edx);                             /* push edx */
            ii(0x1008_ac73, 1); pushd(esi);                             /* push esi */
            ii(0x1008_ac74, 1); pushd(edi);                             /* push edi */
            ii(0x1008_ac75, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_ac76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ac78, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_ac7e, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1008_ac85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_ac88, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ac8a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_ac8b, 1); popd(edi);                              /* pop edi */
            ii(0x1008_ac8c, 1); popd(esi);                              /* pop esi */
            ii(0x1008_ac8d, 1); popd(edx);                              /* pop edx */
            ii(0x1008_ac8e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_ac8f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_ac90, 1); retd(); return;                         /* ret */
        }
    }
}
