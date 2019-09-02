using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4fec-ea5f517e")]
        public void Method_100d_4fec()
        {
            ii(0x100d_4fec, 5); push(0x20);                             /* push 0x20 */
            ii(0x100d_4ff1, 5); call(Definitions.sys_check_available_stack_size, 0x9_0d5c); /* call 0x10165d52 */
            ii(0x100d_4ff6, 1); push(ebx);                              /* push ebx */
            ii(0x100d_4ff7, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4ff8, 1); push(edx);                              /* push edx */
            ii(0x100d_4ff9, 1); push(esi);                              /* push esi */
            ii(0x100d_4ffa, 1); push(edi);                              /* push edi */
            ii(0x100d_4ffb, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4ffc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4ffe, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100d_5004, 7); mov(memd[ss, ebp - 4], 0x101c_35b0);    /* mov dword [ebp-0x4], 0x101c35b0 */
            ii(0x100d_500b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_500e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5010, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_5011, 1); pop(edi);                               /* pop edi */
            ii(0x100d_5012, 1); pop(esi);                               /* pop esi */
            ii(0x100d_5013, 1); pop(edx);                               /* pop edx */
            ii(0x100d_5014, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_5015, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_5016, 1); ret();                                  /* ret */
        }
    }
}
