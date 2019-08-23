using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8841-df3e173a")]
        public void Method_100c_8841()
        {
            ii(0x100c_8841, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_8846, 5); call(Definitions.sys_check_available_stack_size, 0x9_d507); /* call 0x10165d52 */
            ii(0x100c_884b, 1); push(ebx);                              /* push ebx */
            ii(0x100c_884c, 1); push(ecx);                              /* push ecx */
            ii(0x100c_884d, 1); push(edx);                              /* push edx */
            ii(0x100c_884e, 1); push(esi);                              /* push esi */
            ii(0x100c_884f, 1); push(edi);                              /* push edi */
            ii(0x100c_8850, 1); push(ebp);                              /* push ebp */
            ii(0x100c_8851, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_8853, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_8859, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_885c, 4); mov(memb[ss, ebp - 0x8], 0x16);         /* mov byte [ebp-0x8], 0x16 */
            ii(0x100c_8860, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_8863, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8865, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_8866, 1); pop(edi);                               /* pop edi */
            ii(0x100c_8867, 1); pop(esi);                               /* pop esi */
            ii(0x100c_8868, 1); pop(edx);                               /* pop edx */
            ii(0x100c_8869, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_886a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_886b, 1); ret();                                  /* ret */
        }
    }
}
