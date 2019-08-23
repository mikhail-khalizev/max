using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b2a8-cfbe792")]
        public void Method_1008_b2a8()
        {
            ii(0x1008_b2a8, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_b2ad, 5); call(Definitions.sys_check_available_stack_size, 0xd_aaa0); /* call 0x10165d52 */
            ii(0x1008_b2b2, 1); push(ebx);                              /* push ebx */
            ii(0x1008_b2b3, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b2b4, 1); push(esi);                              /* push esi */
            ii(0x1008_b2b5, 1); push(edi);                              /* push edi */
            ii(0x1008_b2b6, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b2b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b2b9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_b2bf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_b2c2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_b2c5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_b2c8, 5); call(0x1008_b410, 0x143);               /* call 0x1008b410 */
            ii(0x1008_b2cd, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_b2d0, 5); call(Definitions.my_3_get_count, 0x1ab); /* call 0x1008b480 */
            ii(0x1008_b2d5, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1008_b2d8, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_b2db, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_b2de, 5); call(0x1008_b2ec, 0x9);                 /* call 0x1008b2ec */
            ii(0x1008_b2e3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b2e5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_b2e6, 1); pop(edi);                               /* pop edi */
            ii(0x1008_b2e7, 1); pop(esi);                               /* pop esi */
            ii(0x1008_b2e8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_b2e9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_b2ea, 1); ret();                                  /* ret */
        }
    }
}
