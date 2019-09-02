using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b226-df11d54c")]
        public void Method_100e_b226()
        {
            ii(0x100e_b226, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_b22b, 5); call(Definitions.sys_check_available_stack_size, 0x7_ab22); /* call 0x10165d52 */
            ii(0x100e_b230, 1); push(ebx);                              /* push ebx */
            ii(0x100e_b231, 1); push(ecx);                              /* push ecx */
            ii(0x100e_b232, 1); push(edx);                              /* push edx */
            ii(0x100e_b233, 1); push(esi);                              /* push esi */
            ii(0x100e_b234, 1); push(edi);                              /* push edi */
            ii(0x100e_b235, 1); push(ebp);                              /* push ebp */
            ii(0x100e_b236, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b238, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100e_b23e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_b241, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b244, 4); cmp(memb[ds, eax + 26], 0);             /* cmp byte [eax+0x1a], 0x0 */
            ii(0x100e_b248, 2); if(jz(0x100e_b27a, 0x30)) goto l_0x100e_b27a; /* jz 0x100eb27a */
            ii(0x100e_b24a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b24d, 4); mov(memb[ds, eax + 26], 0);             /* mov byte [eax+0x1a], 0x0 */
            ii(0x100e_b251, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b254, 4); cmp(memb[ds, eax + 43], 0);             /* cmp byte [eax+0x2b], 0x0 */
            ii(0x100e_b258, 2); if(jz(0x100e_b269, 0xf)) goto l_0x100e_b269; /* jz 0x100eb269 */
            ii(0x100e_b25a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b25d, 4); mov(memb[ds, eax + 43], 0);             /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_b261, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b264, 5); call(0x100e_b6bf, 0x456);               /* call 0x100eb6bf */
        l_0x100e_b269:
            ii(0x100e_b269, 5); call(0x100d_6104, -0x1_516a);           /* call 0x100d6104 */
            ii(0x100e_b26e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_b270, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_b272, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_b275, 5); call(0x100e_b5e1, 0x367);               /* call 0x100eb5e1 */
        l_0x100e_b27a:
            ii(0x100e_b27a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b27c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_b27d, 1); pop(edi);                               /* pop edi */
            ii(0x100e_b27e, 1); pop(esi);                               /* pop esi */
            ii(0x100e_b27f, 1); pop(edx);                               /* pop edx */
            ii(0x100e_b280, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_b281, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_b282, 1); ret();                                  /* ret */
        }
    }
}
