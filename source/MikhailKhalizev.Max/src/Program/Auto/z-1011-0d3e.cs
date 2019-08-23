using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0d3e-e107b2f0")]
        public void Method_1011_0d3e()
        {
            ii(0x1011_0d3e, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_0d43, 5); call(Definitions.sys_check_available_stack_size, 0x5_500a); /* call 0x10165d52 */
            ii(0x1011_0d48, 1); push(ebx);                              /* push ebx */
            ii(0x1011_0d49, 1); push(ecx);                              /* push ecx */
            ii(0x1011_0d4a, 1); push(edx);                              /* push edx */
            ii(0x1011_0d4b, 1); push(esi);                              /* push esi */
            ii(0x1011_0d4c, 1); push(edi);                              /* push edi */
            ii(0x1011_0d4d, 1); push(ebp);                              /* push ebp */
            ii(0x1011_0d4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0d50, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_0d56, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_0d59, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0d5c, 7); mov(memd[ds, eax + 0x8], 0x1);          /* mov dword [eax+0x8], 0x1 */
            ii(0x1011_0d63, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_0d65, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_0d66, 1); pop(edi);                               /* pop edi */
            ii(0x1011_0d67, 1); pop(esi);                               /* pop esi */
            ii(0x1011_0d68, 1); pop(edx);                               /* pop edx */
            ii(0x1011_0d69, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_0d6a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_0d6b, 1); ret();                                  /* ret */
        }
    }
}
