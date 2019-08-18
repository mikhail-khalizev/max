using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a2acfd2-00d7-40de-a83c-7caa237d2039")]
        public void Method_100c_ac68()
        {
            ii(0x100c_ac68, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ac69, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ac6a, 1); pushd(edx);                             /* push edx */
            ii(0x100c_ac6b, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ac6c, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ac6d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ac6e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ac70, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_ac76, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100c_ac7a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100c_ac7d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ac7f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ac80, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ac81, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ac82, 1); popd(edx);                              /* pop edx */
            ii(0x100c_ac83, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ac84, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ac85, 1); retd(); return;                         /* ret */
        }
    }
}
