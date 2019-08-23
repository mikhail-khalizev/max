using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8774-8e30f385")]
        public void Method_100e_8774()
        {
            ii(0x100e_8774, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_8779, 5); call(Definitions.sys_check_available_stack_size, 0x7_d5d4); /* call 0x10165d52 */
            ii(0x100e_877e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_877f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8780, 1); push(edx);                              /* push edx */
            ii(0x100e_8781, 1); push(esi);                              /* push esi */
            ii(0x100e_8782, 1); push(edi);                              /* push edi */
            ii(0x100e_8783, 1); push(ebp);                              /* push ebp */
            ii(0x100e_8784, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8786, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_878c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_878f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_8792, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100e_8796, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_8799, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x100e_879d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_87a0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_87a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_87a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_87a6, 1); pop(edi);                               /* pop edi */
            ii(0x100e_87a7, 1); pop(esi);                               /* pop esi */
            ii(0x100e_87a8, 1); pop(edx);                               /* pop edx */
            ii(0x100e_87a9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_87aa, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_87ab, 1); ret();                                  /* ret */
        }
    }
}
