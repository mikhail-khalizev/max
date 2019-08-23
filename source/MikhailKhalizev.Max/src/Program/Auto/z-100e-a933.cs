using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a933-9e4c9ed3")]
        public void Method_100e_a933()
        {
            ii(0x100e_a933, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_a938, 5); call(Definitions.sys_check_available_stack_size, 0x7_b415); /* call 0x10165d52 */
            ii(0x100e_a93d, 1); push(ebx);                              /* push ebx */
            ii(0x100e_a93e, 1); push(ecx);                              /* push ecx */
            ii(0x100e_a93f, 1); push(edx);                              /* push edx */
            ii(0x100e_a940, 1); push(esi);                              /* push esi */
            ii(0x100e_a941, 1); push(edi);                              /* push edi */
            ii(0x100e_a942, 1); push(ebp);                              /* push ebp */
            ii(0x100e_a943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a945, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_a94b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_a94e, 5); call(0x100e_a7e7, -0x16c);              /* call 0x100ea7e7 */
            ii(0x100e_a953, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a958, 5); call(Definitions.my_3_get_count, -0x5_f4dd); /* call 0x1008b480 */
            ii(0x100e_a95d, 1); cwde();                                 /* cwde */
            ii(0x100e_a95e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_a960, 2); if(jnz(0x100e_a968, 0x6)) goto l_0x100e_a968; /* jnz 0x100ea968 */
            ii(0x100e_a962, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_a966, 2); jmp(0x100e_a98e, 0x26); goto l_0x100e_a98e; /* jmp 0x100ea98e */
        l_0x100e_a968:
            ii(0x100e_a968, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_a96a, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a96f, 5); call(0x100e_adcc, 0x458);               /* call 0x100eadcc */
            ii(0x100e_a974, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_a976, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a979, 5); call(0x100e_acec, 0x36e);               /* call 0x100eacec */
            ii(0x100e_a97e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_a980, 5); mov(eax, 0x101c_3664);                  /* mov eax, 0x101c3664 */
            ii(0x100e_a985, 5); call(0x100c_db14, -0x1_ce76);           /* call 0x100cdb14 */
            ii(0x100e_a98a, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
        l_0x100e_a98e:
            ii(0x100e_a98e, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100e_a991, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a993, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_a994, 1); pop(edi);                               /* pop edi */
            ii(0x100e_a995, 1); pop(esi);                               /* pop esi */
            ii(0x100e_a996, 1); pop(edx);                               /* pop edx */
            ii(0x100e_a997, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_a998, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_a999, 1); ret();                                  /* ret */
        }
    }
}
