using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6710-9e625d64")]
        public void Method_100d_6710()
        {
            ii(0x100d_6710, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_6715, 5); call(Definitions.sys_check_available_stack_size, 0x8_f638); /* call 0x10165d52 */
            ii(0x100d_671a, 1); push(ebx);                              /* push ebx */
            ii(0x100d_671b, 1); push(ecx);                              /* push ecx */
            ii(0x100d_671c, 1); push(edx);                              /* push edx */
            ii(0x100d_671d, 1); push(esi);                              /* push esi */
            ii(0x100d_671e, 1); push(edi);                              /* push edi */
            ii(0x100d_671f, 1); push(ebp);                              /* push ebp */
            ii(0x100d_6720, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6722, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_6728, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_672b, 7); mov(dx, memw[ds, 0x101c_3600]);         /* mov dx, [0x101c3600] */
            ii(0x100d_6732, 7); inc(memw[ds, 0x101c_3600]);             /* inc word [0x101c3600] */
            ii(0x100d_6739, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_673c, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x100d_673f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6742, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_6745, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_6748, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_674a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_674b, 1); pop(edi);                               /* pop edi */
            ii(0x100d_674c, 1); pop(esi);                               /* pop esi */
            ii(0x100d_674d, 1); pop(edx);                               /* pop edx */
            ii(0x100d_674e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_674f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_6750, 1); ret();                                  /* ret */
        }
    }
}
