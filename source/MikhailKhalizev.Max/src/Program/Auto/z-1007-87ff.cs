using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_87ff-8a8fbb15")]
        public void Method_1007_87ff()
        {
            ii(0x1007_87ff, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_8804, 5); call(Definitions.sys_check_available_stack_size, 0xe_d549); /* call 0x10165d52 */
            ii(0x1007_8809, 1); push(ebx);                              /* push ebx */
            ii(0x1007_880a, 1); push(ecx);                              /* push ecx */
            ii(0x1007_880b, 1); push(edx);                              /* push edx */
            ii(0x1007_880c, 1); push(esi);                              /* push esi */
            ii(0x1007_880d, 1); push(edi);                              /* push edi */
            ii(0x1007_880e, 1); push(ebp);                              /* push ebp */
            ii(0x1007_880f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_8811, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_8817, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_881a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_881d, 5); call(0x1008_aa80, 0x1_225e);            /* call 0x1008aa80 */
            ii(0x1007_8822, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_8825, 7); or(memd[ss, ebp - 0x8], 0xfe);          /* or dword [ebp-0x8], 0xfe */
            ii(0x1007_882c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_882f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_8832, 5); call(0x1008_a9d0, 0x1_2199);            /* call 0x1008a9d0 */
            ii(0x1007_8837, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_8839, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_883a, 1); pop(edi);                               /* pop edi */
            ii(0x1007_883b, 1); pop(esi);                               /* pop esi */
            ii(0x1007_883c, 1); pop(edx);                               /* pop edx */
            ii(0x1007_883d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_883e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_883f, 1); ret();                                  /* ret */
        }
    }
}
