using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b14d-835d660d")]
        public void Method_100e_b14d()
        {
            ii(0x100e_b14d, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_b152, 5); call(Definitions.sys_check_available_stack_size, 0x7_abfb); /* call 0x10165d52 */
            ii(0x100e_b157, 1); push(ebx);                              /* push ebx */
            ii(0x100e_b158, 1); push(ecx);                              /* push ecx */
            ii(0x100e_b159, 1); push(esi);                              /* push esi */
            ii(0x100e_b15a, 1); push(edi);                              /* push edi */
            ii(0x100e_b15b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_b15c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b15e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_b164, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_b167, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_b16a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_b16d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_b170, 3); mov(eax, memd[ds, eax + 35]);           /* mov eax, [eax+0x23] */
            ii(0x100e_b173, 5); call(Definitions.sys_strcpy, 0x7_ad57); /* call 0x10165ecf */
            ii(0x100e_b178, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b17a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_b17b, 1); pop(edi);                               /* pop edi */
            ii(0x100e_b17c, 1); pop(esi);                               /* pop esi */
            ii(0x100e_b17d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_b17e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_b17f, 1); ret();                                  /* ret */
        }
    }
}
