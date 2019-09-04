using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a12c-c002ca44")]
        public void Method_1008_a12c()
        {
            ii(0x1008_a12c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a131, 5); call(Definitions.sys_check_available_stack_size, 0xd_bc1c); /* call 0x10165d52 */
            ii(0x1008_a136, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a137, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a138, 1); push(edx);                              /* push edx */
            ii(0x1008_a139, 1); push(esi);                              /* push esi */
            ii(0x1008_a13a, 1); push(edi);                              /* push edi */
            ii(0x1008_a13b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a13c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a13e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_a144, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_a147, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_a14a, 5); call(0x1007_6c30, -0x1_351f);           /* call 0x10076c30 */
            ii(0x1008_a14f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a152, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a155, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a157, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a158, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a159, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a15a, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a15b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a15c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a15d, 1); ret();                                  /* ret */
        }
    }
}
