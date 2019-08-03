using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("507681ae-b8c4-41e9-b6cd-88acba9ac0a3")]
        public void Method_100e_f348()
        {
            ii(0x100e_f348, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_f349, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_f34a, 1); pushd(edx);                             /* push edx */
            ii(0x100e_f34b, 1); pushd(esi);                             /* push esi */
            ii(0x100e_f34c, 1); pushd(edi);                             /* push edi */
            ii(0x100e_f34d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_f34e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f350, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_f356, 7); mov(memd_a32[ss, ebp - 0x4], 0x32);     /* mov dword [ebp-0x4], 0x32 */
            ii(0x100e_f35d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_f360, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f362, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_f363, 1); popd(edi);                              /* pop edi */
            ii(0x100e_f364, 1); popd(esi);                              /* pop esi */
            ii(0x100e_f365, 1); popd(edx);                              /* pop edx */
            ii(0x100e_f366, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_f367, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_f368, 1); retd(); return;                         /* ret */
        }
    }
}
