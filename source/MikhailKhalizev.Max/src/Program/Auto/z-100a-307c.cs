using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7358af27-5766-4f1c-8378-e5cb8c5b961b")]
        public void Method_100a_307c()
        {
            ii(0x100a_307c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_3081, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2ccc); /* call 0x10165d52 */
            ii(0x100a_3086, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3087, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3088, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3089, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_308a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_308c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_3092, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3095, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_3098, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_309b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_309d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_309e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_309f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_30a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_30a1, 1); retd(); return;                         /* ret */
        }
    }
}
