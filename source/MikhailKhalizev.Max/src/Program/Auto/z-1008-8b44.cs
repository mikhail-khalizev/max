using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8b44-7220daba")]
        public void Method_1008_8b44()
        {
            ii(0x1008_8b44, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8b49, 5); call(Definitions.sys_check_available_stack_size, 0xd_d204); /* call 0x10165d52 */
            ii(0x1008_8b4e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8b4f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8b50, 1); push(esi);                              /* push esi */
            ii(0x1008_8b51, 1); push(edi);                              /* push edi */
            ii(0x1008_8b52, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8b53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8b55, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8b5b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8b5e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_8b61, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8b64, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1008_8b66, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8b69, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1008_8b6b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8b6e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_8b71, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_8b74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8b76, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8b77, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8b78, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8b79, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8b7a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8b7b, 1); ret();                                  /* ret */
        }
    }
}
