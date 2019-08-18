using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a8fc-3c22c92a")]
        public void Method_100a_a8fc()
        {
            ii(0x100a_a8fc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a901, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b44c); /* call 0x10165d52 */
            ii(0x100a_a906, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a907, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a908, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a909, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a90a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a90b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a90d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a913, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a916, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a919, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_a91d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a920, 5); calld(0x100a_a934, 0xf);                /* call 0x100aa934 */
            ii(0x100a_a925, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a928, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a92b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a92d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a92e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a92f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a930, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a931, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a932, 1); retd(); return;                         /* ret */
        }
    }
}
