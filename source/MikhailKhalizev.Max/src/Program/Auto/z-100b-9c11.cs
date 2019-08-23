using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_9c11-720b7909")]
        public void Method_100b_9c11()
        {
            ii(0x100b_9c11, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_9c16, 5); calld(Definitions.sys_check_available_stack_size, 0xa_c137); /* call 0x10165d52 */
            ii(0x100b_9c1b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_9c1c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_9c1d, 1); pushd(esi);                             /* push esi */
            ii(0x100b_9c1e, 1); pushd(edi);                             /* push edi */
            ii(0x100b_9c1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_9c20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_9c22, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_9c28, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9c2b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_9c2e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_9c31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9c34, 3); add(eax, 0x6d);                         /* add eax, 0x6d */
            ii(0x100b_9c37, 5); calld(0x100c_b21c, 0x1_15e0);           /* call 0x100cb21c */
            ii(0x100b_9c3c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_9c3e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_9c3f, 1); popd(edi);                              /* pop edi */
            ii(0x100b_9c40, 1); popd(esi);                              /* pop esi */
            ii(0x100b_9c41, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_9c42, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_9c43, 1); retd();                                 /* ret */
        }
    }
}
