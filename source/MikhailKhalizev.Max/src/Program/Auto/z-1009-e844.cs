using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e844-fd0952eb")]
        public void Method_1009_e844()
        {
            ii(0x1009_e844, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_e849, 5); call(Definitions.sys_check_available_stack_size, 0xc_7504); /* call 0x10165d52 */
            ii(0x1009_e84e, 1); push(ecx);                              /* push ecx */
            ii(0x1009_e84f, 1); push(esi);                              /* push esi */
            ii(0x1009_e850, 1); push(edi);                              /* push edi */
            ii(0x1009_e851, 1); push(ebp);                              /* push ebp */
            ii(0x1009_e852, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e854, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_e85a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_e85d, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_e860, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1009_e863, 4); cmp(memb[ss, ebp - 0x4], 0x2);          /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1009_e867, 2); if(jnz(0x1009_e881, 0x18)) goto l_0x1009_e881; /* jnz 0x1009e881 */
            ii(0x1009_e869, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_e86c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_e86f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_e874, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_e877, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_e87a, 5); call(0x1009_d066, -0x1819);             /* call 0x1009d066 */
            ii(0x1009_e87f, 2); jmp(0x1009_e898, 0x17); goto l_0x1009_e898; /* jmp 0x1009e898 */
        l_0x1009_e881:
            ii(0x1009_e881, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1009_e885, 2); if(jnz(0x1009_e898, 0x11)) goto l_0x1009_e898; /* jnz 0x1009e898 */
            ii(0x1009_e887, 5); call(0x1008_b0e4, -0x1_37a8);           /* call 0x1008b0e4 */
            ii(0x1009_e88c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_e88e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_e890, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_e893, 5); call(0x100a_297d, 0x40e5);              /* call 0x100a297d */
        l_0x1009_e898:
            ii(0x1009_e898, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e89a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_e89b, 1); pop(edi);                               /* pop edi */
            ii(0x1009_e89c, 1); pop(esi);                               /* pop esi */
            ii(0x1009_e89d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_e89e, 1); ret();                                  /* ret */
        }
    }
}
