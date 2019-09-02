using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0b74-fe207482")]
        public void Method_100e_0b74()
        {
            ii(0x100e_0b74, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0b79, 5); call(Definitions.sys_check_available_stack_size, 0x8_51d4); /* call 0x10165d52 */
            ii(0x100e_0b7e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0b7f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0b80, 1); push(edx);                              /* push edx */
            ii(0x100e_0b81, 1); push(esi);                              /* push esi */
            ii(0x100e_0b82, 1); push(edi);                              /* push edi */
            ii(0x100e_0b83, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0b84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0b86, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_0b8c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0b8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0b92, 3); mov(al, memb[ds, eax + 0xe]);           /* mov al, [eax+0xe] */
            ii(0x100e_0b95, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100e_0b98, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100e_0b9b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0b9d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0b9e, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0b9f, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0ba0, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0ba1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0ba2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0ba3, 1); ret();                                  /* ret */
        }
    }
}
