using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b1e2-9f88fe9e")]
        public void Method_1009_b1e2()
        {
            ii(0x1009_b1e2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_b1e7, 5); call(Definitions.sys_check_available_stack_size, 0xc_ab66); /* call 0x10165d52 */
            ii(0x1009_b1ec, 1); push(ebx);                              /* push ebx */
            ii(0x1009_b1ed, 1); push(ecx);                              /* push ecx */
            ii(0x1009_b1ee, 1); push(edx);                              /* push edx */
            ii(0x1009_b1ef, 1); push(esi);                              /* push esi */
            ii(0x1009_b1f0, 1); push(edi);                              /* push edi */
            ii(0x1009_b1f1, 1); push(ebp);                              /* push ebp */
            ii(0x1009_b1f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b1f4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b1fa, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_b1fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_b200, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b203, 5); call(0x1007_6b90, -0x2_4678);           /* call 0x10076b90 */
            ii(0x1009_b208, 1); cwde();                                 /* cwde */
            ii(0x1009_b209, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_b20b, 2); if(jnz(0x1009_b213, 6)) goto l_0x1009_b213; /* jnz 0x1009b213 */
            ii(0x1009_b20d, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_b211, 2); jmp(0x1009_b217, 4); goto l_0x1009_b217; /* jmp 0x1009b217 */
        l_0x1009_b213:
            ii(0x1009_b213, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x1009_b217:
            ii(0x1009_b217, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1009_b21a, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1009_b21d, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1009_b220, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b222, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_b223, 1); pop(edi);                               /* pop edi */
            ii(0x1009_b224, 1); pop(esi);                               /* pop esi */
            ii(0x1009_b225, 1); pop(edx);                               /* pop edx */
            ii(0x1009_b226, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_b227, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_b228, 1); ret();                                  /* ret */
        }
    }
}
