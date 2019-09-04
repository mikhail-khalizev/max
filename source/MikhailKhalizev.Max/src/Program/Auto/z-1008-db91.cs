using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_db91-16e9411b")]
        public void Method_1008_db91()
        {
            ii(0x1008_db91, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_db96, 5); call(Definitions.sys_check_available_stack_size, 0xd_81b7); /* call 0x10165d52 */
            ii(0x1008_db9b, 1); push(ebx);                              /* push ebx */
            ii(0x1008_db9c, 1); push(ecx);                              /* push ecx */
            ii(0x1008_db9d, 1); push(edx);                              /* push edx */
            ii(0x1008_db9e, 1); push(esi);                              /* push esi */
            ii(0x1008_db9f, 1); push(edi);                              /* push edi */
            ii(0x1008_dba0, 1); push(ebp);                              /* push ebp */
            ii(0x1008_dba1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_dba3, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1008_dba9, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_dbac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_dbaf, 5); call(0x1008_df3e, 0x38a);               /* call 0x1008df3e */
            ii(0x1008_dbb4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_dbb6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_dbb7, 1); pop(edi);                               /* pop edi */
            ii(0x1008_dbb8, 1); pop(esi);                               /* pop esi */
            ii(0x1008_dbb9, 1); pop(edx);                               /* pop edx */
            ii(0x1008_dbba, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_dbbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_dbbc, 1); ret();                                  /* ret */
        }
    }
}
