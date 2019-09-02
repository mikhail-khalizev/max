using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_08bc-98f6e993")]
        public void Method_100e_08bc()
        {
            ii(0x100e_08bc, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_08c1, 5); call(Definitions.sys_check_available_stack_size, 0x8_548c); /* call 0x10165d52 */
            ii(0x100e_08c6, 1); push(ebx);                              /* push ebx */
            ii(0x100e_08c7, 1); push(ecx);                              /* push ecx */
            ii(0x100e_08c8, 1); push(esi);                              /* push esi */
            ii(0x100e_08c9, 1); push(edi);                              /* push edi */
            ii(0x100e_08ca, 1); push(ebp);                              /* push ebp */
            ii(0x100e_08cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_08cd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_08d3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_08d6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_08d9, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100e_08dd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_08e0, 5); call(0x1008_b410, -0x5_54d5);           /* call 0x1008b410 */
            ii(0x100e_08e5, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100e_08e8, 5); call(0x1008_b440, -0x5_54ad);           /* call 0x1008b440 */
            ii(0x100e_08ed, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_08f0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_08f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_08f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_08f6, 1); pop(edi);                               /* pop edi */
            ii(0x100e_08f7, 1); pop(esi);                               /* pop esi */
            ii(0x100e_08f8, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_08f9, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_08fa, 1); ret();                                  /* ret */
        }
    }
}
