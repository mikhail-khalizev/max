using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_46a4-92c1636a")]
        public void Method_1010_46a4()
        {
            ii(0x1010_46a4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_46a9, 5); call(Definitions.sys_check_available_stack_size, 0x6_16a4); /* call 0x10165d52 */
            ii(0x1010_46ae, 1); push(ebx);                              /* push ebx */
            ii(0x1010_46af, 1); push(ecx);                              /* push ecx */
            ii(0x1010_46b0, 1); push(edx);                              /* push edx */
            ii(0x1010_46b1, 1); push(esi);                              /* push esi */
            ii(0x1010_46b2, 1); push(edi);                              /* push edi */
            ii(0x1010_46b3, 1); push(ebp);                              /* push ebp */
            ii(0x1010_46b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_46b6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_46bc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_46bf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_46c2, 5); call(0x1007_6b58, -0x8_db6f);           /* call 0x10076b58 */
            ii(0x1010_46c7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_46ca, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_46cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_46cf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_46d0, 1); pop(edi);                               /* pop edi */
            ii(0x1010_46d1, 1); pop(esi);                               /* pop esi */
            ii(0x1010_46d2, 1); pop(edx);                               /* pop edx */
            ii(0x1010_46d3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_46d4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_46d5, 1); ret();                                  /* ret */
        }
    }
}
