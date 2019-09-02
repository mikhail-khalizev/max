using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_60ac-15e446d0")]
        public void Method_1007_60ac()
        {
            ii(0x1007_60ac, 5); push(0x20);                             /* push 0x20 */
            ii(0x1007_60b1, 5); call(Definitions.sys_check_available_stack_size, 0xe_fc9c); /* call 0x10165d52 */
            ii(0x1007_60b6, 1); push(ebx);                              /* push ebx */
            ii(0x1007_60b7, 1); push(ecx);                              /* push ecx */
            ii(0x1007_60b8, 1); push(esi);                              /* push esi */
            ii(0x1007_60b9, 1); push(edi);                              /* push edi */
            ii(0x1007_60ba, 1); push(ebp);                              /* push ebp */
            ii(0x1007_60bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_60bd, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_60c3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_60c6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_60c9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_60cc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_60cf, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1007_60d4, 5); call(0x1007_6630, 0x557);               /* call 0x10076630 */
            ii(0x1007_60d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_60db, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_60dc, 1); pop(edi);                               /* pop edi */
            ii(0x1007_60dd, 1); pop(esi);                               /* pop esi */
            ii(0x1007_60de, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_60df, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_60e0, 1); ret();                                  /* ret */
        }
    }
}
