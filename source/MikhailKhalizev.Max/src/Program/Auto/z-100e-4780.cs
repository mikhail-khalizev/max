using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4780-edde2a97")]
        public void Method_100e_4780()
        {
            ii(0x100e_4780, 5); push(0x44);                             /* push 0x44 */
            ii(0x100e_4785, 5); call(Definitions.sys_check_available_stack_size, 0x8_15c8); /* call 0x10165d52 */
            ii(0x100e_478a, 1); push(ebx);                              /* push ebx */
            ii(0x100e_478b, 1); push(ecx);                              /* push ecx */
            ii(0x100e_478c, 1); push(esi);                              /* push esi */
            ii(0x100e_478d, 1); push(edi);                              /* push edi */
            ii(0x100e_478e, 1); push(ebp);                              /* push ebp */
            ii(0x100e_478f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4791, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100e_4797, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_479a, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x100e_479d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_47a0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_47a3, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_47a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_47aa, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100e_47ad, 5); call(Definitions.sys_memset, 0x8_162e); /* call 0x10165de0 */
            ii(0x100e_47b2, 6); mov(memw[ss, ebp - 0x2c], 7);           /* mov word [ebp-0x2c], 0x7 */
            ii(0x100e_47b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_47bb, 4); mov(memw[ss, ebp - 0x28], ax);          /* mov [ebp-0x28], ax */
            ii(0x100e_47bf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_47c2, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_47c5, 4); mov(memw[ss, ebp - 0x24], ax);          /* mov [ebp-0x24], ax */
            ii(0x100e_47c9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_47cc, 4); mov(memw[ss, ebp - 0x20], ax);          /* mov [ebp-0x20], ax */
            ii(0x100e_47d0, 3); lea(ebx, memd[ss, ebp - 0x2c]);         /* lea ebx, [ebp-0x2c] */
            ii(0x100e_47d3, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x100e_47d6, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_47db, 5); call(/* sys */ 0x1016_c606, 0x8_7e26);  /* call 0x1016c606 */
            ii(0x100e_47e0, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_47e4, 2); if(jz(0x100e_47ef, 9)) goto l_0x100e_47ef; /* jz 0x100e47ef */
            ii(0x100e_47e6, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100e_47ed, 2); jmp(0x100e_47f6, 7); goto l_0x100e_47f6; /* jmp 0x100e47f6 */
        l_0x100e_47ef:
            ii(0x100e_47ef, 7); mov(memd[ss, ebp - 0xc], 1);            /* mov dword [ebp-0xc], 0x1 */
        l_0x100e_47f6:
            ii(0x100e_47f6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_47f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_47fb, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_47fc, 1); pop(edi);                               /* pop edi */
            ii(0x100e_47fd, 1); pop(esi);                               /* pop esi */
            ii(0x100e_47fe, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_47ff, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_4800, 1); ret();                                  /* ret */
        }
    }
}
