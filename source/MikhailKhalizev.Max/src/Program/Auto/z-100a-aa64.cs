using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_aa64-30729595")]
        public void Method_100a_aa64()
        {
            ii(0x100a_aa64, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_aa69, 5); call(Definitions.sys_check_available_stack_size, 0xb_b2e4); /* call 0x10165d52 */
            ii(0x100a_aa6e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_aa6f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_aa70, 1); push(esi);                              /* push esi */
            ii(0x100a_aa71, 1); push(edi);                              /* push edi */
            ii(0x100a_aa72, 1); push(ebp);                              /* push ebp */
            ii(0x100a_aa73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aa75, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_aa7b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_aa7e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_aa81, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_aa84, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100a_aa86, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_aa89, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_aa8c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_aa8f, 5); call(0x100a_aa9c, 0x8);                 /* call 0x100aaa9c */
            ii(0x100a_aa94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aa96, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_aa97, 1); pop(edi);                               /* pop edi */
            ii(0x100a_aa98, 1); pop(esi);                               /* pop esi */
            ii(0x100a_aa99, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_aa9a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_aa9b, 1); ret();                                  /* ret */
        }
    }
}
