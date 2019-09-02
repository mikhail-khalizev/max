using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_aa28-2e09710c")]
        public void Method_100a_aa28()
        {
            ii(0x100a_aa28, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_aa2d, 5); call(Definitions.sys_check_available_stack_size, 0xb_b320); /* call 0x10165d52 */
            ii(0x100a_aa32, 1); push(ebx);                              /* push ebx */
            ii(0x100a_aa33, 1); push(ecx);                              /* push ecx */
            ii(0x100a_aa34, 1); push(esi);                              /* push esi */
            ii(0x100a_aa35, 1); push(edi);                              /* push edi */
            ii(0x100a_aa36, 1); push(ebp);                              /* push ebp */
            ii(0x100a_aa37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aa39, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_aa3f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_aa42, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_aa45, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100a_aa49, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100a_aa4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_aa4e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_aa51, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100a_aa54, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_aa56, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_aa59, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_aa5c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aa5e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_aa5f, 1); pop(edi);                               /* pop edi */
            ii(0x100a_aa60, 1); pop(esi);                               /* pop esi */
            ii(0x100a_aa61, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_aa62, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_aa63, 1); ret();                                  /* ret */
        }
    }
}
