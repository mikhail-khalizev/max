using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7d58-a9ab9b3b")]
        public void Method_1011_7d58()
        {
            ii(0x1011_7d58, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_7d5d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_dff0); /* call 0x10165d52 */
            ii(0x1011_7d62, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7d63, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7d64, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7d65, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7d66, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7d67, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7d69, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7d6f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7d72, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7d75, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_7d78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7d7b, 5); calld(0x1007_6c98, -0xa_10e8);          /* call 0x10076c98 */
            ii(0x1011_7d80, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7d83, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7d86, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7d88, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7d89, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7d8a, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7d8b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7d8c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7d8d, 1); retd();                                 /* ret */
        }
    }
}
