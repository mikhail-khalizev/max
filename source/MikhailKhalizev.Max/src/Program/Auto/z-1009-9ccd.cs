using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9ccd-ad343bb")]
        public void Method_1009_9ccd()
        {
            ii(0x1009_9ccd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_9cd2, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c07b); /* call 0x10165d52 */
            ii(0x1009_9cd7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9cd8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9cd9, 1); pushd(edx);                             /* push edx */
            ii(0x1009_9cda, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9cdb, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9cdc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9cdd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9cdf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_9ce5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_9ce8, 4); mov(memb_a32[ss, ebp - 0x8], 0x1b);     /* mov byte [ebp-0x8], 0x1b */
            ii(0x1009_9cec, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_9cef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9cf1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9cf2, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9cf3, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9cf4, 1); popd(edx);                              /* pop edx */
            ii(0x1009_9cf5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9cf6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9cf7, 1); retd(); return;                         /* ret */
        }
    }
}
