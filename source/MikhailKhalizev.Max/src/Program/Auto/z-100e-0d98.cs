using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0d98-3df0f557")]
        public void Method_100e_0d98()
        {
            ii(0x100e_0d98, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0d9d, 5); call(Definitions.sys_check_available_stack_size, 0x8_4fb0); /* call 0x10165d52 */
            ii(0x100e_0da2, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0da3, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0da4, 1); push(edx);                              /* push edx */
            ii(0x100e_0da5, 1); push(esi);                              /* push esi */
            ii(0x100e_0da6, 1); push(edi);                              /* push edi */
            ii(0x100e_0da7, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0da8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0daa, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_0db0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0db3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0db6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_0db8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0dbb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_0dbe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0dc0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0dc1, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0dc2, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0dc3, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0dc4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0dc5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0dc6, 1); ret();                                  /* ret */
        }
    }
}
