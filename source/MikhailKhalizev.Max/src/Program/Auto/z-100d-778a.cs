using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_778a-2a99d1f2")]
        public void Method_100d_778a()
        {
            ii(0x100d_778a, 5); push(0x20);                             /* push 0x20 */
            ii(0x100d_778f, 5); call(Definitions.sys_check_available_stack_size, 0x8_e5be); /* call 0x10165d52 */
            ii(0x100d_7794, 1); push(ebx);                              /* push ebx */
            ii(0x100d_7795, 1); push(ecx);                              /* push ecx */
            ii(0x100d_7796, 1); push(esi);                              /* push esi */
            ii(0x100d_7797, 1); push(edi);                              /* push edi */
            ii(0x100d_7798, 1); push(ebp);                              /* push ebp */
            ii(0x100d_7799, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_779b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_77a1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_77a4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_77a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_77aa, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_77ad, 4); mov(memw[ds, edx + 0x2b], ax);          /* mov [edx+0x2b], ax */
            ii(0x100d_77b1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_77b3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_77b4, 1); pop(edi);                               /* pop edi */
            ii(0x100d_77b5, 1); pop(esi);                               /* pop esi */
            ii(0x100d_77b6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_77b7, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_77b8, 1); ret();                                  /* ret */
        }
    }
}
