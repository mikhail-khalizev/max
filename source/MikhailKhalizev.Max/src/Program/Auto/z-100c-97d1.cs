using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_97d1-c5821422")]
        public void Method_100c_97d1()
        {
            ii(0x100c_97d1, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_97d6, 5); call(Definitions.sys_check_available_stack_size, 0x9_c577); /* call 0x10165d52 */
            ii(0x100c_97db, 1); push(ebx);                              /* push ebx */
            ii(0x100c_97dc, 1); push(ecx);                              /* push ecx */
            ii(0x100c_97dd, 1); push(edx);                              /* push edx */
            ii(0x100c_97de, 1); push(esi);                              /* push esi */
            ii(0x100c_97df, 1); push(edi);                              /* push edi */
            ii(0x100c_97e0, 1); push(ebp);                              /* push ebp */
            ii(0x100c_97e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_97e3, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_97e9, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_97ec, 4); mov(memb[ss, ebp - 8], 0x2e);           /* mov byte [ebp-0x8], 0x2e */
            ii(0x100c_97f0, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_97f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_97f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_97f6, 1); pop(edi);                               /* pop edi */
            ii(0x100c_97f7, 1); pop(esi);                               /* pop esi */
            ii(0x100c_97f8, 1); pop(edx);                               /* pop edx */
            ii(0x100c_97f9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_97fa, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_97fb, 1); ret();                                  /* ret */
        }
    }
}
