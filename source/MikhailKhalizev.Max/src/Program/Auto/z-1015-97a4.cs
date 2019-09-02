using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_97a4-2ce191bd")]
        public void Method_1015_97a4()
        {
            ii(0x1015_97a4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_97a9, 5); call(Definitions.sys_check_available_stack_size, 0xc5a4); /* call 0x10165d52 */
            ii(0x1015_97ae, 1); push(ebx);                              /* push ebx */
            ii(0x1015_97af, 1); push(ecx);                              /* push ecx */
            ii(0x1015_97b0, 1); push(esi);                              /* push esi */
            ii(0x1015_97b1, 1); push(edi);                              /* push edi */
            ii(0x1015_97b2, 1); push(ebp);                              /* push ebp */
            ii(0x1015_97b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_97b5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_97bb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_97be, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_97c1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_97c4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_97c7, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_97cc, 5); call(0x100f_448c, -0x6_5345);           /* call 0x100f448c */
            ii(0x1015_97d1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_97d4, 4); cmp(memb[ds, eax + 0x57], 8);           /* cmp byte [eax+0x57], 0x8 */
            ii(0x1015_97d8, 2); if(jnz(0x1015_97e3, 9)) goto l_0x1015_97e3; /* jnz 0x101597e3 */
            ii(0x1015_97da, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_97dd, 4); mov(memb[ds, eax + 0x57], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_97e1, 2); jmp(0x1015_97ea, 7); goto l_0x1015_97ea; /* jmp 0x101597ea */
        l_0x1015_97e3:
            ii(0x1015_97e3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_97e6, 4); mov(memb[ds, eax + 0x57], 8);           /* mov byte [eax+0x57], 0x8 */
        l_0x1015_97ea:
            ii(0x1015_97ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_97ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_97ed, 1); pop(edi);                               /* pop edi */
            ii(0x1015_97ee, 1); pop(esi);                               /* pop esi */
            ii(0x1015_97ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_97f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_97f1, 1); ret();                                  /* ret */
        }
    }
}
