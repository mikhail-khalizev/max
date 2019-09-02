using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b530-1a6f0f6e")]
        public void Method_1008_b530()
        {
            ii(0x1008_b530, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_b535, 5); call(Definitions.sys_check_available_stack_size, 0xd_a818); /* call 0x10165d52 */
            ii(0x1008_b53a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_b53b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b53c, 1); push(esi);                              /* push esi */
            ii(0x1008_b53d, 1); push(edi);                              /* push edi */
            ii(0x1008_b53e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b53f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b541, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b547, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_b54a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_b54d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_b550, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1008_b552, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_b555, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1008_b557, 2); if(jnz(0x1008_b55f, 6)) goto l_0x1008_b55f; /* jnz 0x1008b55f */
            ii(0x1008_b559, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_b55d, 2); jmp(0x1008_b563, 4); goto l_0x1008_b563; /* jmp 0x1008b563 */
        l_0x1008_b55f:
            ii(0x1008_b55f, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_b563:
            ii(0x1008_b563, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1008_b566, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1008_b569, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1008_b56c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b56e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_b56f, 1); pop(edi);                               /* pop edi */
            ii(0x1008_b570, 1); pop(esi);                               /* pop esi */
            ii(0x1008_b571, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_b572, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_b573, 1); ret();                                  /* ret */
        }
    }
}
