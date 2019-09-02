using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ca6a-cffe19cc")]
        public void Method_100a_ca6a()
        {
            ii(0x100a_ca6a, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_ca6f, 5); call(Definitions.sys_check_available_stack_size, 0xb_92de); /* call 0x10165d52 */
            ii(0x100a_ca74, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ca75, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ca76, 1); push(edx);                              /* push edx */
            ii(0x100a_ca77, 1); push(esi);                              /* push esi */
            ii(0x100a_ca78, 1); push(edi);                              /* push edi */
            ii(0x100a_ca79, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ca7a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ca7c, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_ca82, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_ca85, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ca88, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ca8b, 5); call(Definitions.my_3_get_count, -0x2_1610); /* call 0x1008b480 */
            ii(0x100a_ca90, 1); cwde();                                 /* cwde */
            ii(0x100a_ca91, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100a_ca94, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100a_ca97, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_ca9a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_ca9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ca9f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_caa0, 1); pop(edi);                               /* pop edi */
            ii(0x100a_caa1, 1); pop(esi);                               /* pop esi */
            ii(0x100a_caa2, 1); pop(edx);                               /* pop edx */
            ii(0x100a_caa3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_caa4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_caa5, 1); ret();                                  /* ret */
        }
    }
}
