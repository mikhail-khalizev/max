using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c2fc-19c88dd7")]
        public void Method_1013_c2fc()
        {
            ii(0x1013_c2fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c301, 5); call(Definitions.sys_check_available_stack_size, 0x2_9a4c); /* call 0x10165d52 */
            ii(0x1013_c306, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c307, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c308, 1); push(esi);                              /* push esi */
            ii(0x1013_c309, 1); push(edi);                              /* push edi */
            ii(0x1013_c30a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c30b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c30d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c313, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c316, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c319, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c31c, 6); mov(memd[ds, eax], 0x101b_6ef0);        /* mov dword [eax], 0x101b6ef0 */
            ii(0x1013_c322, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c325, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c328, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_c32b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c32d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c32e, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c32f, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c330, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c331, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c332, 1); ret();                                  /* ret */
        }
    }
}
