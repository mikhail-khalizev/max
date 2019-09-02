using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_072b-9aaf6167")]
        public void Method_1008_072b()
        {
            ii(0x1008_072b, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_0730, 5); call(Definitions.sys_check_available_stack_size, 0xe_561d); /* call 0x10165d52 */
            ii(0x1008_0735, 1); push(ebx);                              /* push ebx */
            ii(0x1008_0736, 1); push(ecx);                              /* push ecx */
            ii(0x1008_0737, 1); push(esi);                              /* push esi */
            ii(0x1008_0738, 1); push(edi);                              /* push edi */
            ii(0x1008_0739, 1); push(ebp);                              /* push ebp */
            ii(0x1008_073a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_073c, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_0742, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_0745, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_0748, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_074b, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1008_074e, 5); call(0x1008_a228, 0x9ad5);              /* call 0x1008a228 */
            ii(0x1008_0753, 5); call(0x1008_a370, 0x9c18);              /* call 0x1008a370 */
            ii(0x1008_0758, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1008_075b, 2); if(jnz(0x1008_0765, 8)) goto l_0x1008_0765; /* jnz 0x10080765 */
            ii(0x1008_075d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_0760, 5); call(0x1007_f659, -0x110c);             /* call 0x1007f659 */
        l_0x1008_0765:
            ii(0x1008_0765, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0767, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_0768, 1); pop(edi);                               /* pop edi */
            ii(0x1008_0769, 1); pop(esi);                               /* pop esi */
            ii(0x1008_076a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_076b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_076c, 1); ret();                                  /* ret */
        }
    }
}
