using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c598-aea2e969")]
        public void Method_1009_c598()
        {
            ii(0x1009_c598, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_c59d, 5); call(Definitions.sys_check_available_stack_size, 0xc_97b0); /* call 0x10165d52 */
            ii(0x1009_c5a2, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c5a3, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c5a4, 1); push(esi);                              /* push esi */
            ii(0x1009_c5a5, 1); push(edi);                              /* push edi */
            ii(0x1009_c5a6, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c5a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c5a9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_c5af, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c5b2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c5b5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_c5b8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c5bb, 5); call(0x1007_6cd0, -0x2_58f0);           /* call 0x10076cd0 */
            ii(0x1009_c5c0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c5c3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_c5c6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c5c9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c5cc, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_c5cf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_c5d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c5d4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c5d5, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c5d6, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c5d7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c5d8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c5d9, 1); ret();                                  /* ret */
        }
    }
}
