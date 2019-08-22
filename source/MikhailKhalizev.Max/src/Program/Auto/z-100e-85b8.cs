using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_85b8-c502b1ca")]
        public void Method_100e_85b8()
        {
            ii(0x100e_85b8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_85b9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_85ba, 1); pushd(edx);                             /* push edx */
            ii(0x100e_85bb, 1); pushd(esi);                             /* push esi */
            ii(0x100e_85bc, 1); pushd(edi);                             /* push edi */
            ii(0x100e_85bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_85be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_85c0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_85c6, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100e_85cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_85d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_85d2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_85d3, 1); popd(edi);                              /* pop edi */
            ii(0x100e_85d4, 1); popd(esi);                              /* pop esi */
            ii(0x100e_85d5, 1); popd(edx);                              /* pop edx */
            ii(0x100e_85d6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_85d7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_85d8, 1); retd(); return;                         /* ret */
        }
    }
}