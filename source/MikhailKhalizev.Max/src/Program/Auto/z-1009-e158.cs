using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e158-63b4130e")]
        public void Method_1009_e158()
        {
            ii(0x1009_e158, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_e15d, 5); call(Definitions.sys_check_available_stack_size, 0xc_7bf0); /* call 0x10165d52 */
            ii(0x1009_e162, 1); push(ecx);                              /* push ecx */
            ii(0x1009_e163, 1); push(esi);                              /* push esi */
            ii(0x1009_e164, 1); push(edi);                              /* push edi */
            ii(0x1009_e165, 1); push(ebp);                              /* push ebp */
            ii(0x1009_e166, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e168, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_e16e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_e171, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_e174, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1009_e177, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_e17a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_e17d, 4); cmp(memb[ss, ebp - 4], 2);              /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1009_e181, 2); if(jz(0x1009_e18d, 0xa)) goto l_0x1009_e18d; /* jz 0x1009e18d */
            ii(0x1009_e183, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_e186, 5); call(0x1009_e31c, 0x191);               /* call 0x1009e31c */
            ii(0x1009_e18b, 2); jmp(0x1009_e195, 8); goto l_0x1009_e195; /* jmp 0x1009e195 */
        l_0x1009_e18d:
            ii(0x1009_e18d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_e190, 5); call(0x1009_e19c, 7);                   /* call 0x1009e19c */
        l_0x1009_e195:
            ii(0x1009_e195, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e197, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_e198, 1); pop(edi);                               /* pop edi */
            ii(0x1009_e199, 1); pop(esi);                               /* pop esi */
            ii(0x1009_e19a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_e19b, 1); ret();                                  /* ret */
        }
    }
}
