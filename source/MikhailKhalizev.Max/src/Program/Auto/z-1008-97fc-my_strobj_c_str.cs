using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_97fc-907199a4")]
        public void my_strobj_c_str()
        {
            ii(0x1008_97fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9801, 5); call(Definitions.sys_check_available_stack_size, 0xd_c54c); /* call 0x10165d52 */
            ii(0x1008_9806, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9807, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9808, 1); push(edx);                              /* push edx */
            ii(0x1008_9809, 1); push(esi);                              /* push esi */
            ii(0x1008_980a, 1); push(edi);                              /* push edi */
            ii(0x1008_980b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_980c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_980e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_9814, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_9817, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_981a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_981c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_981f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9822, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9824, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9825, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9826, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9827, 1); pop(edx);                               /* pop edx */
            ii(0x1008_9828, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9829, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_982a, 1); ret();                                  /* ret */
        }
    }
}
