using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_72f2-5ce6ee7e")]
        public void Method_1014_72f2()
        {
            ii(0x1014_72f2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_72f7, 5); call(Definitions.sys_check_available_stack_size, 0x1_ea56); /* call 0x10165d52 */
            ii(0x1014_72fc, 1); push(ebx);                              /* push ebx */
            ii(0x1014_72fd, 1); push(ecx);                              /* push ecx */
            ii(0x1014_72fe, 1); push(edx);                              /* push edx */
            ii(0x1014_72ff, 1); push(esi);                              /* push esi */
            ii(0x1014_7300, 1); push(edi);                              /* push edi */
            ii(0x1014_7301, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7302, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7304, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_730a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_730d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7310, 5); call(0x1013_be76, -0xb49f);             /* call 0x1013be76 */
            ii(0x1014_7315, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_7318, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1014_731b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_731e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7321, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_7324, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_7327, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7329, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_732a, 1); pop(edi);                               /* pop edi */
            ii(0x1014_732b, 1); pop(esi);                               /* pop esi */
            ii(0x1014_732c, 1); pop(edx);                               /* pop edx */
            ii(0x1014_732d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_732e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_732f, 1); ret();                                  /* ret */
        }
    }
}
