using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7ca0-c725a777")]
        public void Method_1011_7ca0()
        {
            ii(0x1011_7ca0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_7ca5, 5); call(Definitions.sys_check_available_stack_size, 0x4_e0a8); /* call 0x10165d52 */
            ii(0x1011_7caa, 1); push(ebx);                              /* push ebx */
            ii(0x1011_7cab, 1); push(ecx);                              /* push ecx */
            ii(0x1011_7cac, 1); push(esi);                              /* push esi */
            ii(0x1011_7cad, 1); push(edi);                              /* push edi */
            ii(0x1011_7cae, 1); push(ebp);                              /* push ebp */
            ii(0x1011_7caf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7cb1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_7cb7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7cba, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_7cbd, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7cc0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7cc3, 5); call(0x1013_a112, 0x2_244a);            /* call 0x1013a112 */
            ii(0x1011_7cc8, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7ccb, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1011_7cce, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_7cd1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7cd4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_7cd7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7cda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7cdc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7cdd, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7cde, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7cdf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_7ce0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_7ce1, 1); ret();                                  /* ret */
        }
    }
}
