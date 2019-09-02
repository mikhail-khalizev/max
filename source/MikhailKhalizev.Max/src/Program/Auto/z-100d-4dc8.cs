using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4dc8-2b7480c3")]
        public void Method_100d_4dc8()
        {
            ii(0x100d_4dc8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_4dcd, 5); call(Definitions.sys_check_available_stack_size, 0x9_0f80); /* call 0x10165d52 */
            ii(0x100d_4dd2, 1); push(ebx);                              /* push ebx */
            ii(0x100d_4dd3, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4dd4, 1); push(edx);                              /* push edx */
            ii(0x100d_4dd5, 1); push(esi);                              /* push esi */
            ii(0x100d_4dd6, 1); push(edi);                              /* push edi */
            ii(0x100d_4dd7, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4dd8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4dda, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_4de0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_4de3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4de6, 6); mov(memd[ds, eax], 0x101b_5c4c);        /* mov dword [eax], 0x101b5c4c */
            ii(0x100d_4dec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4def, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_4df2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_4df5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4df7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4df8, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4df9, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4dfa, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4dfb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4dfc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4dfd, 1); ret();                                  /* ret */
        }
    }
}
