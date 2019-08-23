using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5e4e-b2bfa957")]
        public void Method_1012_5e4e()
        {
            ii(0x1012_5e4e, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_5e53, 5); call(Definitions.sys_check_available_stack_size, 0x3_fefa); /* call 0x10165d52 */
            ii(0x1012_5e58, 1); push(ebx);                              /* push ebx */
            ii(0x1012_5e59, 1); push(ecx);                              /* push ecx */
            ii(0x1012_5e5a, 1); push(esi);                              /* push esi */
            ii(0x1012_5e5b, 1); push(edi);                              /* push edi */
            ii(0x1012_5e5c, 1); push(ebp);                              /* push ebp */
            ii(0x1012_5e5d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5e5f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_5e65, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_5e68, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_5e6b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_5e6e, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_5e71, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_5e74, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e77, 5); call(0x1012_5d66, -0x116);              /* call 0x10125d66 */
            ii(0x1012_5e7c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e7f, 5); call(0x1007_611c, -0xa_fd68);           /* call 0x1007611c */
            ii(0x1012_5e84, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_5e86, 2); if(jnz(0x1012_5e93, 0xb)) goto l_0x1012_5e93; /* jnz 0x10125e93 */
            ii(0x1012_5e88, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5e8b, 6); mov(memw[ds, eax + 0x5], 0);            /* mov word [eax+0x5], 0x0 */
            ii(0x1012_5e91, 2); jmp(0x1012_5ea9, 0x16); goto l_0x1012_5ea9; /* jmp 0x10125ea9 */
        l_0x1012_5e93:
            ii(0x1012_5e93, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e96, 5); call(0x1007_611c, -0xa_fd7f);           /* call 0x1007611c */
            ii(0x1012_5e9b, 5); call(0x1007_6154, -0xa_fd4c);           /* call 0x10076154 */
            ii(0x1012_5ea0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_5ea2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5ea5, 4); mov(memw[ds, eax + 0x5], dx);           /* mov [eax+0x5], dx */
        l_0x1012_5ea9:
            ii(0x1012_5ea9, 7); mov(memd[ss, ebp - 0xc], 0x7);          /* mov dword [ebp-0xc], 0x7 */
            ii(0x1012_5eb0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_5eb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5eb5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_5eb6, 1); pop(edi);                               /* pop edi */
            ii(0x1012_5eb7, 1); pop(esi);                               /* pop esi */
            ii(0x1012_5eb8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_5eb9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_5eba, 1); ret();                                  /* ret */
        }
    }
}
