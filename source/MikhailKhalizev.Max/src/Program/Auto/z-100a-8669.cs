using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_8669-a7060de2")]
        public void Method_100a_8669()
        {
            ii(0x100a_8669, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_866e, 5); call(Definitions.sys_check_available_stack_size, 0xb_d6df); /* call 0x10165d52 */
            ii(0x100a_8673, 1); push(ebx);                              /* push ebx */
            ii(0x100a_8674, 1); push(ecx);                              /* push ecx */
            ii(0x100a_8675, 1); push(esi);                              /* push esi */
            ii(0x100a_8676, 1); push(edi);                              /* push edi */
            ii(0x100a_8677, 1); push(ebp);                              /* push ebp */
            ii(0x100a_8678, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_867a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_8680, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_8683, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_8686, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_8689, 3); add(edx, 0x4e);                         /* add edx, 0x4e */
            ii(0x100a_868c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_868f, 5); call(0x1007_6d98, -0x3_18fc);           /* call 0x10076d98 */
            ii(0x100a_8694, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8696, 2); if(jz(0x100a_86ac, 0x14)) goto l_0x100a_86ac; /* jz 0x100a86ac */
            ii(0x100a_8698, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_869a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_869d, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_86a0, 5); call(0x1007_6630, -0x3_2075);           /* call 0x10076630 */
            ii(0x100a_86a5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_86a8, 4); mov(memb[ds, eax + 19], 0);             /* mov byte [eax+0x13], 0x0 */
        l_0x100a_86ac:
            ii(0x100a_86ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_86ae, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_86af, 1); pop(edi);                               /* pop edi */
            ii(0x100a_86b0, 1); pop(esi);                               /* pop esi */
            ii(0x100a_86b1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_86b2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_86b3, 1); ret();                                  /* ret */
        }
    }
}
