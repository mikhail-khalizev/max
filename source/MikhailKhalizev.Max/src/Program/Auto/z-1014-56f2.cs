using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_56f2-79df8fa5")]
        public void Method_1014_56f2()
        {
            ii(0x1014_56f2, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_56f7, 5); call(Definitions.sys_check_available_stack_size, 0x2_0656); /* call 0x10165d52 */
            ii(0x1014_56fc, 1); push(ebx);                              /* push ebx */
            ii(0x1014_56fd, 1); push(ecx);                              /* push ecx */
            ii(0x1014_56fe, 1); push(esi);                              /* push esi */
            ii(0x1014_56ff, 1); push(edi);                              /* push edi */
            ii(0x1014_5700, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5701, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5703, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_5709, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_570c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_570f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_5712, 5); call(0x1014_7cb0, 0x2599);              /* call 0x10147cb0 */
            ii(0x1014_5717, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_571a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_571d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_571f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5720, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5721, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5722, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_5723, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_5724, 1); ret();                                  /* ret */
        }
    }
}
