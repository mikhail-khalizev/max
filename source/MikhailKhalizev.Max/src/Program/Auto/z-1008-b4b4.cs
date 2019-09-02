using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b4b4-c9b4612c")]
        public void Method_1008_b4b4()
        {
            ii(0x1008_b4b4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_b4b9, 5); call(Definitions.sys_check_available_stack_size, 0xd_a894); /* call 0x10165d52 */
            ii(0x1008_b4be, 1); push(ebx);                              /* push ebx */
            ii(0x1008_b4bf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b4c0, 1); push(esi);                              /* push esi */
            ii(0x1008_b4c1, 1); push(edi);                              /* push edi */
            ii(0x1008_b4c2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b4c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b4c5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_b4cb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_b4ce, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_b4d1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_b4d4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_b4d7, 5); call(0x1008_b4ec, 0x10);                /* call 0x1008b4ec */
            ii(0x1008_b4dc, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1008_b4df, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1008_b4e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b4e4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_b4e5, 1); pop(edi);                               /* pop edi */
            ii(0x1008_b4e6, 1); pop(esi);                               /* pop esi */
            ii(0x1008_b4e7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_b4e8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_b4e9, 1); ret();                                  /* ret */
        }
    }
}
