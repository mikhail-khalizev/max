using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f97c931-d984-4ff7-88b8-6fdcd0b5c7c6")]
        public void Method_100b_81d0()
        {
            ii(0x100b_81d0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_81d5, 5); calld(Definitions.sys_check_available_stack_size, 0xa_db78); /* call 0x10165d52 */
            ii(0x100b_81da, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_81db, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_81dc, 1); pushd(edx);                             /* push edx */
            ii(0x100b_81dd, 1); pushd(esi);                             /* push esi */
            ii(0x100b_81de, 1); pushd(edi);                             /* push edi */
            ii(0x100b_81df, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_81e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_81e2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_81e8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_81eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_81ee, 5); calld(0x1007_6c30, -0x4_15c3);          /* call 0x10076c30 */
            ii(0x100b_81f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_81f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_81f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_81fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_81fc, 1); popd(edi);                              /* pop edi */
            ii(0x100b_81fd, 1); popd(esi);                              /* pop esi */
            ii(0x100b_81fe, 1); popd(edx);                              /* pop edx */
            ii(0x100b_81ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8200, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8201, 1); retd(); return;                         /* ret */
        }
    }
}
