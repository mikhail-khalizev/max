using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7411-46076a68")]
        public void Method_1008_7411()
        {
            ii(0x1008_7411, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_7416, 5); call(Definitions.sys_check_available_stack_size, 0xd_e937); /* call 0x10165d52 */
            ii(0x1008_741b, 1); push(ebx);                              /* push ebx */
            ii(0x1008_741c, 1); push(ecx);                              /* push ecx */
            ii(0x1008_741d, 1); push(edx);                              /* push edx */
            ii(0x1008_741e, 1); push(esi);                              /* push esi */
            ii(0x1008_741f, 1); push(edi);                              /* push edi */
            ii(0x1008_7420, 1); push(ebp);                              /* push ebp */
            ii(0x1008_7421, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7423, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_7429, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_742c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_742f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7432, 5); call(0x1013_a794, 0xb_335d);            /* call 0x1013a794 */
            ii(0x1008_7437, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1008_743a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_743d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_7440, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7442, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7443, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7444, 1); pop(esi);                               /* pop esi */
            ii(0x1008_7445, 1); pop(edx);                               /* pop edx */
            ii(0x1008_7446, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_7447, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7448, 1); ret();                                  /* ret */
        }
    }
}
