using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f52376f-34bc-4087-9b86-3ce73f99d7e3")]
        public void Method_1009_c560()
        {
            ii(0x1009_c560, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c565, 5); calld(Definitions.sys_check_available_stack_size, 0xc_97e8); /* call 0x10165d52 */
            ii(0x1009_c56a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c56b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c56c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c56d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c56e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c56f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c571, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c577, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c57a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c57d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_c580, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c583, 5); calld(0x1007_6c98, -0x2_58f0);          /* call 0x10076c98 */
            ii(0x1009_c588, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c58b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c58e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c590, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c591, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c592, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c593, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c594, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c595, 1); retd(); return;                         /* ret */
        }
    }
}
