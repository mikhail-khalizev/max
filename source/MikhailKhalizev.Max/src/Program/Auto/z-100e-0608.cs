using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0608-3ca5381a")]
        public void Method_100e_0608()
        {
            ii(0x100e_0608, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_060d, 5); call(Definitions.sys_check_available_stack_size, 0x8_5740); /* call 0x10165d52 */
            ii(0x100e_0612, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0613, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0614, 1); push(edx);                              /* push edx */
            ii(0x100e_0615, 1); push(esi);                              /* push esi */
            ii(0x100e_0616, 1); push(edi);                              /* push edi */
            ii(0x100e_0617, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0618, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_061a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0620, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0623, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0626, 5); call(0x1007_6d58, -0x6_98d3);           /* call 0x10076d58 */
            ii(0x100e_062b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_062e, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_0631, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0634, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0637, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_063a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_063d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_063f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0640, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0641, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0642, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0643, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0644, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0645, 1); ret();                                  /* ret */
        }
    }
}
