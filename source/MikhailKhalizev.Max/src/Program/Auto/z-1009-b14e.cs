using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b14e-1c0f586c")]
        public void Method_1009_b14e()
        {
            ii(0x1009_b14e, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_b153, 5); call(Definitions.sys_check_available_stack_size, 0xc_abfa); /* call 0x10165d52 */
            ii(0x1009_b158, 1); push(ebx);                              /* push ebx */
            ii(0x1009_b159, 1); push(ecx);                              /* push ecx */
            ii(0x1009_b15a, 1); push(esi);                              /* push esi */
            ii(0x1009_b15b, 1); push(edi);                              /* push edi */
            ii(0x1009_b15c, 1); push(ebp);                              /* push ebp */
            ii(0x1009_b15d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b15f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b165, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_b168, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_b16b, 5); mov(edx, StringDefinitions.ScavengeMaterials); /* mov edx, 0x101a0729 */
            ii(0x1009_b170, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_b173, 5); call(Definitions.sys_strcpy, 0xc_ad57); /* call 0x10165ecf */
            ii(0x1009_b178, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_b17b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_b17e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_b181, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b183, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_b184, 1); pop(edi);                               /* pop edi */
            ii(0x1009_b185, 1); pop(esi);                               /* pop esi */
            ii(0x1009_b186, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_b187, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_b188, 1); ret();                                  /* ret */
        }
    }
}
