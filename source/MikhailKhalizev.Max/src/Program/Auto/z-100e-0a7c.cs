using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0a7c-33f7f2d8")]
        public void Method_100e_0a7c()
        {
            ii(0x100e_0a7c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0a81, 5); call(Definitions.sys_check_available_stack_size, 0x8_52cc); /* call 0x10165d52 */
            ii(0x100e_0a86, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0a87, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0a88, 1); push(edx);                              /* push edx */
            ii(0x100e_0a89, 1); push(esi);                              /* push esi */
            ii(0x100e_0a8a, 1); push(edi);                              /* push edi */
            ii(0x100e_0a8b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0a8c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0a8e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_0a94, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0a97, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0a9a, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100e_0a9e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0aa1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_0aa4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0aa6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0aa7, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0aa8, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0aa9, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0aaa, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0aab, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0aac, 1); ret();                                  /* ret */
        }
    }
}
