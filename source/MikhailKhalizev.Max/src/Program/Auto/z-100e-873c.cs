using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_873c-39bf48e")]
        public void Method_100e_873c()
        {
            ii(0x100e_873c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_8741, 5); call(Definitions.sys_check_available_stack_size, 0x7_d60c); /* call 0x10165d52 */
            ii(0x100e_8746, 1); push(ebx);                              /* push ebx */
            ii(0x100e_8747, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8748, 1); push(edx);                              /* push edx */
            ii(0x100e_8749, 1); push(esi);                              /* push esi */
            ii(0x100e_874a, 1); push(edi);                              /* push edi */
            ii(0x100e_874b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_874c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_874e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_8754, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_8757, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_875a, 4); mov(ax, memw[ds, eax + 16]);            /* mov ax, [eax+0x10] */
            ii(0x100e_875e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_8761, 4); sub(ax, memw[ds, edx + 8]);             /* sub ax, [edx+0x8] */
            ii(0x100e_8765, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_8768, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_876b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_876d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_876e, 1); pop(edi);                               /* pop edi */
            ii(0x100e_876f, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8770, 1); pop(edx);                               /* pop edx */
            ii(0x100e_8771, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_8772, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_8773, 1); ret();                                  /* ret */
        }
    }
}
