using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6e23-6ed091df")]
        public void Method_1013_6e23()
        {
            ii(0x1013_6e23, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_6e28, 5); call(Definitions.sys_check_available_stack_size, 0x2_ef25); /* call 0x10165d52 */
            ii(0x1013_6e2d, 1); push(ebx);                              /* push ebx */
            ii(0x1013_6e2e, 1); push(ecx);                              /* push ecx */
            ii(0x1013_6e2f, 1); push(edx);                              /* push edx */
            ii(0x1013_6e30, 1); push(esi);                              /* push esi */
            ii(0x1013_6e31, 1); push(edi);                              /* push edi */
            ii(0x1013_6e32, 1); push(ebp);                              /* push ebp */
            ii(0x1013_6e33, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6e35, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_6e3b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_6e3e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6e41, 3); mov(eax, memd[ds, eax + 0x4f]);         /* mov eax, [eax+0x4f] */
            ii(0x1013_6e44, 5); call(0x100e_b226, -0x4_bc23);           /* call 0x100eb226 */
            ii(0x1013_6e49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6e4b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_6e4c, 1); pop(edi);                               /* pop edi */
            ii(0x1013_6e4d, 1); pop(esi);                               /* pop esi */
            ii(0x1013_6e4e, 1); pop(edx);                               /* pop edx */
            ii(0x1013_6e4f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_6e50, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_6e51, 1); ret();                                  /* ret */
        }
    }
}
