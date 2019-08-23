using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5d1f-57bb96a8")]
        public void Method_1012_5d1f()
        {
            ii(0x1012_5d1f, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_5d24, 5); call(Definitions.sys_check_available_stack_size, 0x4_0029); /* call 0x10165d52 */
            ii(0x1012_5d29, 1); push(ebx);                              /* push ebx */
            ii(0x1012_5d2a, 1); push(ecx);                              /* push ecx */
            ii(0x1012_5d2b, 1); push(edx);                              /* push edx */
            ii(0x1012_5d2c, 1); push(esi);                              /* push esi */
            ii(0x1012_5d2d, 1); push(edi);                              /* push edi */
            ii(0x1012_5d2e, 1); push(ebp);                              /* push ebp */
            ii(0x1012_5d2f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5d31, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_5d37, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5d39, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_5d3e, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_5d41, 2); if(jnz(0x1012_5d52, 0xf)) goto l_0x1012_5d52; /* jnz 0x10125d52 */
            ii(0x1012_5d43, 5); mov(eax, 0x101c_59f0);                  /* mov eax, 0x101c59f0 */
            ii(0x1012_5d48, 5); call(0x1010_744d, -0x1_e900);           /* call 0x1010744d */
            ii(0x1012_5d4d, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_5d50, 2); jmp(0x1012_5d5a, 0x8); goto l_0x1012_5d5a; /* jmp 0x10125d5a */
        l_0x1012_5d52:
            ii(0x1012_5d52, 5); call(0x1012_5920, -0x437);              /* call 0x10125920 */
            ii(0x1012_5d57, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1012_5d5a:
            ii(0x1012_5d5a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_5d5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5d5f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_5d60, 1); pop(edi);                               /* pop edi */
            ii(0x1012_5d61, 1); pop(esi);                               /* pop esi */
            ii(0x1012_5d62, 1); pop(edx);                               /* pop edx */
            ii(0x1012_5d63, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_5d64, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_5d65, 1); ret();                                  /* ret */
        }
    }
}
