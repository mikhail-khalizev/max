using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e6a872c-2bf3-49b3-b1c3-c6bb80d8f347")]
        public void Method_1008_db91()
        {
            ii(0x1008_db91, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_db96, 5); calld(Definitions.sys_check_available_stack_size, 0xd_81b7); /* call 0x10165d52 */
            ii(0x1008_db9b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_db9c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_db9d, 1); pushd(edx);                             /* push edx */
            ii(0x1008_db9e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_db9f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_dba0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_dba1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_dba3, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_dba9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_dbac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dbaf, 5); calld(0x1008_df3e, 0x38a);              /* call 0x1008df3e */
            ii(0x1008_dbb4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_dbb6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_dbb7, 1); popd(edi);                              /* pop edi */
            ii(0x1008_dbb8, 1); popd(esi);                              /* pop esi */
            ii(0x1008_dbb9, 1); popd(edx);                              /* pop edx */
            ii(0x1008_dbba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_dbbb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_dbbc, 1); retd(); return;                         /* ret */
        }
    }
}
