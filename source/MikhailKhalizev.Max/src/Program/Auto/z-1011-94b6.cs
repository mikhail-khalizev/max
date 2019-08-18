using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_94b6-34ee9c26")]
        public void Method_1011_94b6()
        {
            ii(0x1011_94b6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_94bb, 5); calld(Definitions.sys_check_available_stack_size, 0x4_c892); /* call 0x10165d52 */
            ii(0x1011_94c0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_94c1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_94c2, 1); pushd(edx);                             /* push edx */
            ii(0x1011_94c3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_94c4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_94c5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_94c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_94c8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_94ce, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_94d1, 5); mov(eax, 0x101c_52fe);                  /* mov eax, 0x101c52fe */
            ii(0x1011_94d6, 5); calld(0x1012_0d64, 0x7889);             /* call 0x10120d64 */
            ii(0x1011_94db, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_94de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_94e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_94e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_94e4, 1); popd(edi);                              /* pop edi */
            ii(0x1011_94e5, 1); popd(esi);                              /* pop esi */
            ii(0x1011_94e6, 1); popd(edx);                              /* pop edx */
            ii(0x1011_94e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_94e8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_94e9, 1); retd(); return;                         /* ret */
        }
    }
}
