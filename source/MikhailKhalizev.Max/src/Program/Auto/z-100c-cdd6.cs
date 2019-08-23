using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_cdd6-f712fe75")]
        public void Method_100c_cdd6()
        {
            ii(0x100c_cdd6, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_cddb, 5); call(Definitions.sys_check_available_stack_size, 0x9_8f72); /* call 0x10165d52 */
            ii(0x100c_cde0, 1); push(ecx);                              /* push ecx */
            ii(0x100c_cde1, 1); push(esi);                              /* push esi */
            ii(0x100c_cde2, 1); push(edi);                              /* push edi */
            ii(0x100c_cde3, 1); push(ebp);                              /* push ebp */
            ii(0x100c_cde4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_cde6, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_cdec, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_cdef, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_cdf2, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_cdf5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_cdf8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_cdfb, 4); cmp(memb[ss, ebp - 0x4], 0x2);          /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100c_cdff, 2); if(jnz(0x100c_ce0b, 0xa)) goto l_0x100c_ce0b; /* jnz 0x100cce0b */
            ii(0x100c_ce01, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ce04, 5); call(0x100c_cd68, -0xa1);               /* call 0x100ccd68 */
            ii(0x100c_ce09, 2); jmp(0x100c_ce23, 0x18); goto l_0x100c_ce23; /* jmp 0x100cce23 */
        l_0x100c_ce0b:
            ii(0x100c_ce0b, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_ce0f, 2); if(jnz(0x100c_ce23, 0x12)) goto l_0x100c_ce23; /* jnz 0x100cce23 */
            ii(0x100c_ce11, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ce14, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_ce17, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_ce1a, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_ce1d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_ce20, 3); call_abs(memd[ds, edx + 0x3c]);         /* call dword [edx+0x3c] */
        l_0x100c_ce23:
            ii(0x100c_ce23, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ce25, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ce26, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ce27, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ce28, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ce29, 1); ret();                                  /* ret */
        }
    }
}
