using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bd19-493fb043")]
        public void Method_100a_bd19()
        {
            ii(0x100a_bd19, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_bd1e, 5); call(Definitions.sys_check_available_stack_size, 0xb_a02f); /* call 0x10165d52 */
            ii(0x100a_bd23, 1); push(ebx);                              /* push ebx */
            ii(0x100a_bd24, 1); push(ecx);                              /* push ecx */
            ii(0x100a_bd25, 1); push(edx);                              /* push edx */
            ii(0x100a_bd26, 1); push(esi);                              /* push esi */
            ii(0x100a_bd27, 1); push(edi);                              /* push edi */
            ii(0x100a_bd28, 1); push(ebp);                              /* push ebp */
            ii(0x100a_bd29, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_bd2b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_bd31, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_bd34, 4); mov(memb[ss, ebp - 0x8], 0x10);         /* mov byte [ebp-0x8], 0x10 */
            ii(0x100a_bd38, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100a_bd3b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bd3d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_bd3e, 1); pop(edi);                               /* pop edi */
            ii(0x100a_bd3f, 1); pop(esi);                               /* pop esi */
            ii(0x100a_bd40, 1); pop(edx);                               /* pop edx */
            ii(0x100a_bd41, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_bd42, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_bd43, 1); ret();                                  /* ret */
        }
    }
}
