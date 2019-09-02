using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5fc8-eb71e58c")]
        public void Method_100b_5fc8()
        {
            ii(0x100b_5fc8, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_5fcd, 5); call(Definitions.sys_check_available_stack_size, 0xa_fd80); /* call 0x10165d52 */
            ii(0x100b_5fd2, 1); push(ebx);                              /* push ebx */
            ii(0x100b_5fd3, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5fd4, 1); push(esi);                              /* push esi */
            ii(0x100b_5fd5, 1); push(edi);                              /* push edi */
            ii(0x100b_5fd6, 1); push(ebp);                              /* push ebp */
            ii(0x100b_5fd7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5fd9, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_5fdf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_5fe2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_5fe5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_5fe8, 5); cmp(memw[ds, eax + 8], 0x4e);           /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_5fed, 2); if(jz(0x100b_5ff9, 0xa)) goto l_0x100b_5ff9; /* jz 0x100b5ff9 */
            ii(0x100b_5fef, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_5ff2, 5); cmp(memw[ds, eax + 8], 0x48);           /* cmp word [eax+0x8], 0x48 */
            ii(0x100b_5ff7, 2); if(jnz(0x100b_5ffb, 2)) goto l_0x100b_5ffb; /* jnz 0x100b5ffb */
        l_0x100b_5ff9:
            ii(0x100b_5ff9, 2); jmp(0x100b_6005, 0xa); goto l_0x100b_6005; /* jmp 0x100b6005 */
        l_0x100b_5ffb:
            ii(0x100b_5ffb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_5ffe, 5); cmp(memw[ds, eax + 8], 0x41);           /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_6003, 2); if(jnz(0x100b_602f, 0x2a)) goto l_0x100b_602f; /* jnz 0x100b602f */
        l_0x100b_6005:
            ii(0x100b_6005, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_6008, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_600b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_600e, 5); call(0x1008_ab1c, -0x2_b4f7);           /* call 0x1008ab1c */
            ii(0x100b_6013, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_6016, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_6019, 5); call(0x1015_27ed, 0x9_c7cf);            /* call 0x101527ed */
            ii(0x100b_601e, 5); call(0x1008_b0e4, -0x2_af3f);           /* call 0x1008b0e4 */
            ii(0x100b_6023, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6025, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_6027, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_602a, 5); call(0x100a_297d, -0x1_36b2);           /* call 0x100a297d */
        l_0x100b_602f:
            ii(0x100b_602f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6031, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_6032, 1); pop(edi);                               /* pop edi */
            ii(0x100b_6033, 1); pop(esi);                               /* pop esi */
            ii(0x100b_6034, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_6035, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_6036, 1); ret();                                  /* ret */
        }
    }
}
