using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cb94-f4d9bf8b")]
        public void Method_1009_cb94()
        {
            ii(0x1009_cb94, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_cb99, 5); call(Definitions.sys_check_available_stack_size, 0xc_91b4); /* call 0x10165d52 */
            ii(0x1009_cb9e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_cb9f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_cba0, 1); push(edx);                              /* push edx */
            ii(0x1009_cba1, 1); push(esi);                              /* push esi */
            ii(0x1009_cba2, 1); push(edi);                              /* push edi */
            ii(0x1009_cba3, 1); push(ebp);                              /* push ebp */
            ii(0x1009_cba4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cba6, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1009_cbac, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_cbaf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_cbb2, 6); mov(memw[ds, eax + 2], 0);              /* mov word [eax+0x2], 0x0 */
            ii(0x1009_cbb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cbba, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_cbbb, 1); pop(edi);                               /* pop edi */
            ii(0x1009_cbbc, 1); pop(esi);                               /* pop esi */
            ii(0x1009_cbbd, 1); pop(edx);                               /* pop edx */
            ii(0x1009_cbbe, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_cbbf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_cbc0, 1); ret();                                  /* ret */
        }
    }
}
