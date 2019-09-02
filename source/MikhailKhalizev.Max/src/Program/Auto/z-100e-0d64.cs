using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0d64-986f0451")]
        public void Method_100e_0d64()
        {
            ii(0x100e_0d64, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0d69, 5); call(Definitions.sys_check_available_stack_size, 0x8_4fe4); /* call 0x10165d52 */
            ii(0x100e_0d6e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0d6f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0d70, 1); push(edx);                              /* push edx */
            ii(0x100e_0d71, 1); push(esi);                              /* push esi */
            ii(0x100e_0d72, 1); push(edi);                              /* push edi */
            ii(0x100e_0d73, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0d74, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0d76, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_0d7c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0d7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0d82, 4); mov(ax, memw[ds, eax + 20]);            /* mov ax, [eax+0x14] */
            ii(0x100e_0d86, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0d89, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_0d8c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0d8e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0d8f, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0d90, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0d91, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0d92, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0d93, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0d94, 1); ret();                                  /* ret */
        }
    }
}
