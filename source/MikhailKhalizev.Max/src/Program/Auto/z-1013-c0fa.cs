using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c0fa-69a58d51")]
        public void Method_1013_c0fa()
        {
            ii(0x1013_c0fa, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_c0ff, 5); call(Definitions.sys_check_available_stack_size, 0x2_9c4e); /* call 0x10165d52 */
            ii(0x1013_c104, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c105, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c106, 1); push(esi);                              /* push esi */
            ii(0x1013_c107, 1); push(edi);                              /* push edi */
            ii(0x1013_c108, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c109, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c10b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_c111, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c114, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c117, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1013_c11c, 3); lea(edx, memd[ss, ebp - 4]);            /* lea edx, [ebp-0x4] */
            ii(0x1013_c11f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c122, 5); call(0x1013_c055, -0xd2);               /* call 0x1013c055 */
            ii(0x1013_c127, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c129, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c12a, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c12b, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c12c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c12d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c12e, 1); ret();                                  /* ret */
        }
    }
}
