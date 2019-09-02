using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a2b4-ca1897ad")]
        public void Method_1008_a2b4()
        {
            ii(0x1008_a2b4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a2b9, 5); call(Definitions.sys_check_available_stack_size, 0xd_ba94); /* call 0x10165d52 */
            ii(0x1008_a2be, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a2bf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a2c0, 1); push(esi);                              /* push esi */
            ii(0x1008_a2c1, 1); push(edi);                              /* push edi */
            ii(0x1008_a2c2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a2c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a2c5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a2cb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a2ce, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_a2d1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_a2d4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a2d7, 5); call(0x1013_ac7d, 0xb_09a1);            /* call 0x1013ac7d */
            ii(0x1008_a2dc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_a2df, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_a2e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a2e4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a2e5, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a2e6, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a2e7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a2e8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a2e9, 1); ret();                                  /* ret */
        }
    }
}
