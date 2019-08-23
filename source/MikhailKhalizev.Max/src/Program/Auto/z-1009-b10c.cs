using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b10c-8e4325c2")]
        public void Method_1009_b10c()
        {
            ii(0x1009_b10c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_b111, 5); call(Definitions.sys_check_available_stack_size, 0xc_ac3c); /* call 0x10165d52 */
            ii(0x1009_b116, 1); push(ebx);                              /* push ebx */
            ii(0x1009_b117, 1); push(ecx);                              /* push ecx */
            ii(0x1009_b118, 1); push(esi);                              /* push esi */
            ii(0x1009_b119, 1); push(edi);                              /* push edi */
            ii(0x1009_b11a, 1); push(ebp);                              /* push ebp */
            ii(0x1009_b11b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b11d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_b123, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b126, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_b129, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_b12c, 5); cmp(memw[ds, eax + 0x8], 0x3e);         /* cmp word [eax+0x8], 0x3e */
            ii(0x1009_b131, 2); if(jnz(0x1009_b139, 0x6)) goto l_0x1009_b139; /* jnz 0x1009b139 */
            ii(0x1009_b133, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_b137, 2); jmp(0x1009_b13d, 0x4); goto l_0x1009_b13d; /* jmp 0x1009b13d */
        l_0x1009_b139:
            ii(0x1009_b139, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1009_b13d:
            ii(0x1009_b13d, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1009_b140, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1009_b143, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1009_b146, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b148, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_b149, 1); pop(edi);                               /* pop edi */
            ii(0x1009_b14a, 1); pop(esi);                               /* pop esi */
            ii(0x1009_b14b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_b14c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_b14d, 1); ret();                                  /* ret */
        }
    }
}
