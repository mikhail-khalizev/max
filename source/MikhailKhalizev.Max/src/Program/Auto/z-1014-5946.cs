using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5946-c5cb09b7")]
        public void Method_1014_5946()
        {
            ii(0x1014_5946, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_594b, 5); call(Definitions.sys_check_available_stack_size, 0x2_0402); /* call 0x10165d52 */
            ii(0x1014_5950, 1); push(ebx);                              /* push ebx */
            ii(0x1014_5951, 1); push(ecx);                              /* push ecx */
            ii(0x1014_5952, 1); push(esi);                              /* push esi */
            ii(0x1014_5953, 1); push(edi);                              /* push edi */
            ii(0x1014_5954, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5955, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5957, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_595d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_5960, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_5963, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_5966, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_5969, 5); call(0x1014_5725, -0x249);              /* call 0x10145725 */
            ii(0x1014_596e, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_5971, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1014_5975, 2); if(jnz(0x1014_5980, 9)) goto l_0x1014_5980; /* jnz 0x10145980 */
            ii(0x1014_5977, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_597e, 2); jmp(0x1014_598b, 0xb); goto l_0x1014_598b; /* jmp 0x1014598b */
        l_0x1014_5980:
            ii(0x1014_5980, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_5983, 5); call(0x1014_7c10, 0x2288);              /* call 0x10147c10 */
            ii(0x1014_5988, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1014_598b:
            ii(0x1014_598b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_598e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5990, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5991, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5992, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5993, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_5994, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_5995, 1); ret();                                  /* ret */
        }
    }
}
