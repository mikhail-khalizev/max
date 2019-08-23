using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_0b00-4d28ac8f")]
        public void Method_1008_0b00()
        {
            ii(0x1008_0b00, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_0b05, 5); call(Definitions.sys_check_available_stack_size, 0xe_5248); /* call 0x10165d52 */
            ii(0x1008_0b0a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_0b0b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_0b0c, 1); push(esi);                              /* push esi */
            ii(0x1008_0b0d, 1); push(edi);                              /* push edi */
            ii(0x1008_0b0e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_0b0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0b11, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_0b17, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_0b1a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_0b1d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_0b20, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_0b23, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_0b26, 5); call(0x1008_ab1c, 0x9ff1);              /* call 0x1008ab1c */
            ii(0x1008_0b2b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_0b2e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0b31, 5); call(0x1015_27ed, 0xd_1cb7);            /* call 0x101527ed */
            ii(0x1008_0b36, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0b39, 5); cmp(memw[ds, eax + 0x8], 0x38);         /* cmp word [eax+0x8], 0x38 */
            ii(0x1008_0b3e, 2); if(jnz(0x1008_0b4b, 0xb)) goto l_0x1008_0b4b; /* jnz 0x10080b4b */
            ii(0x1008_0b40, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_0b43, 6); mov(memw[ds, eax + 0x1d], 0);           /* mov word [eax+0x1d], 0x0 */
            ii(0x1008_0b49, 2); jmp(0x1008_0b54, 0x9); goto l_0x1008_0b54; /* jmp 0x10080b54 */
        l_0x1008_0b4b:
            ii(0x1008_0b4b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_0b4e, 6); mov(memw[ds, eax + 0x1f], 0);           /* mov word [eax+0x1f], 0x0 */
        l_0x1008_0b54:
            ii(0x1008_0b54, 5); call(0x1008_b0e4, 0xa58b);              /* call 0x1008b0e4 */
            ii(0x1008_0b59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0b5b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1008_0b5d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0b60, 5); call(0x100a_297d, 0x2_1e18);            /* call 0x100a297d */
            ii(0x1008_0b65, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0b67, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_0b68, 1); pop(edi);                               /* pop edi */
            ii(0x1008_0b69, 1); pop(esi);                               /* pop esi */
            ii(0x1008_0b6a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_0b6b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_0b6c, 1); ret();                                  /* ret */
        }
    }
}
