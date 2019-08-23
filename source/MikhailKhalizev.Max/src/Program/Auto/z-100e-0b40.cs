using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0b40-dc6ac110")]
        public void Method_100e_0b40()
        {
            ii(0x100e_0b40, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0b45, 5); call(Definitions.sys_check_available_stack_size, 0x8_5208); /* call 0x10165d52 */
            ii(0x100e_0b4a, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0b4b, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0b4c, 1); push(edx);                              /* push edx */
            ii(0x100e_0b4d, 1); push(esi);                              /* push esi */
            ii(0x100e_0b4e, 1); push(edi);                              /* push edi */
            ii(0x100e_0b4f, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0b50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0b52, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0b58, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0b5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0b5e, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x100e_0b62, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0b65, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0b68, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0b6a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0b6b, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0b6c, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0b6d, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0b6e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0b6f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0b70, 1); ret();                                  /* ret */
        }
    }
}
