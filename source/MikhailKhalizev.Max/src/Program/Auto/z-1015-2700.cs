using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2700-9bccaa94")]
        public void Method_1015_2700()
        {
            ii(0x1015_2700, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_2705, 5); call(Definitions.sys_check_available_stack_size, 0x1_3648); /* call 0x10165d52 */
            ii(0x1015_270a, 1); push(ebx);                              /* push ebx */
            ii(0x1015_270b, 1); push(ecx);                              /* push ecx */
            ii(0x1015_270c, 1); push(edx);                              /* push edx */
            ii(0x1015_270d, 1); push(esi);                              /* push esi */
            ii(0x1015_270e, 1); push(edi);                              /* push edi */
            ii(0x1015_270f, 1); push(ebp);                              /* push ebp */
            ii(0x1015_2710, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2712, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1015_2718, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_271b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_271e, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_2723, 5); call(0x1008_aef4, -0xc_7834);           /* call 0x1008aef4 */
            ii(0x1015_2728, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_272b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_272e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2730, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_2731, 1); pop(edi);                               /* pop edi */
            ii(0x1015_2732, 1); pop(esi);                               /* pop esi */
            ii(0x1015_2733, 1); pop(edx);                               /* pop edx */
            ii(0x1015_2734, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_2735, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_2736, 1); ret();                                  /* ret */
        }
    }
}
