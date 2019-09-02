using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_186c-40a076e4")]
        public void Method_1016_186c()
        {
            ii(0x1016_186c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_1871, 5); call(Definitions.sys_check_available_stack_size, 0x44dc); /* call 0x10165d52 */
            ii(0x1016_1876, 1); push(ebx);                              /* push ebx */
            ii(0x1016_1877, 1); push(ecx);                              /* push ecx */
            ii(0x1016_1878, 1); push(edx);                              /* push edx */
            ii(0x1016_1879, 1); push(esi);                              /* push esi */
            ii(0x1016_187a, 1); push(edi);                              /* push edi */
            ii(0x1016_187b, 1); push(ebp);                              /* push ebp */
            ii(0x1016_187c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_187e, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_1884, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1016_1887, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_188a, 4); cmp(memb[ds, eax + 0x3d], 0x16);        /* cmp byte [eax+0x3d], 0x16 */
            ii(0x1016_188e, 2); if(jnz(0x1016_18b9, 0x29)) goto l_0x1016_18b9; /* jnz 0x101618b9 */
            ii(0x1016_1890, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1893, 4); cmp(memb[ds, eax + 0x3e], 0x20);        /* cmp byte [eax+0x3e], 0x20 */
            ii(0x1016_1897, 2); if(jnz(0x1016_18aa, 0x11)) goto l_0x1016_18aa; /* jnz 0x101618aa */
            ii(0x1016_1899, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_189c, 4); mov(memb[ds, eax + 0x2d], 0);           /* mov byte [eax+0x2d], 0x0 */
            ii(0x1016_18a0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_18a3, 5); call(0x1015_ec73, -0x2c35);             /* call 0x1015ec73 */
            ii(0x1016_18a8, 2); jmp(0x1016_18b9, 0xf); goto l_0x1016_18b9; /* jmp 0x101618b9 */
        l_0x1016_18aa:
            ii(0x1016_18aa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_18ad, 4); mov(memb[ds, eax + 0x2d], 4);           /* mov byte [eax+0x2d], 0x4 */
            ii(0x1016_18b1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_18b4, 5); call(0x1016_16bd, -0x1fc);              /* call 0x101616bd */
        l_0x1016_18b9:
            ii(0x1016_18b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_18bb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_18bc, 1); pop(edi);                               /* pop edi */
            ii(0x1016_18bd, 1); pop(esi);                               /* pop esi */
            ii(0x1016_18be, 1); pop(edx);                               /* pop edx */
            ii(0x1016_18bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_18c0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_18c1, 1); ret();                                  /* ret */
        }
    }
}
