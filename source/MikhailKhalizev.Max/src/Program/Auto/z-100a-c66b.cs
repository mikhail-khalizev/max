using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c66b-77d74073")]
        public void Method_100a_c66b()
        {
            ii(0x100a_c66b, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_c670, 5); call(Definitions.sys_check_available_stack_size, 0xb_96dd); /* call 0x10165d52 */
            ii(0x100a_c675, 1); push(ebx);                              /* push ebx */
            ii(0x100a_c676, 1); push(ecx);                              /* push ecx */
            ii(0x100a_c677, 1); push(esi);                              /* push esi */
            ii(0x100a_c678, 1); push(edi);                              /* push edi */
            ii(0x100a_c679, 1); push(ebp);                              /* push ebp */
            ii(0x100a_c67a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c67c, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_c682, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_c685, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100a_c688, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_c68b, 5); cmp(memw[ds, eax + 0x26], 0x41);        /* cmp word [eax+0x26], 0x41 */
            ii(0x100a_c690, 2); if(jnz(0x100a_c698, 6)) goto l_0x100a_c698; /* jnz 0x100ac698 */
            ii(0x100a_c692, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_c696, 2); if(jz(0x100a_c69a, 2)) goto l_0x100a_c69a; /* jz 0x100ac69a */
        l_0x100a_c698:
            ii(0x100a_c698, 2); jmp(0x100a_c6a9, 0xf); goto l_0x100a_c6a9; /* jmp 0x100ac6a9 */
        l_0x100a_c69a:
            ii(0x100a_c69a, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x100a_c69f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_c6a2, 5); call(0x100a_d86c, 0x11c5);              /* call 0x100ad86c */
            ii(0x100a_c6a7, 2); jmp(0x100a_c6b2, 9); goto l_0x100a_c6b2; /* jmp 0x100ac6b2 */
        l_0x100a_c6a9:
            ii(0x100a_c6a9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_c6ac, 6); mov(memw[ds, eax + 0x26], 0xffff);      /* mov word [eax+0x26], 0xffff */
        l_0x100a_c6b2:
            ii(0x100a_c6b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c6b4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_c6b5, 1); pop(edi);                               /* pop edi */
            ii(0x100a_c6b6, 1); pop(esi);                               /* pop esi */
            ii(0x100a_c6b7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_c6b8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_c6b9, 1); ret();                                  /* ret */
        }
    }
}
