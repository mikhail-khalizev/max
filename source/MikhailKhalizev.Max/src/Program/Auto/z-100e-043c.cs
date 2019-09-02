using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_043c-b1c6c34a")]
        public void Method_100e_043c()
        {
            ii(0x100e_043c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0441, 5); call(Definitions.sys_check_available_stack_size, 0x8_590c); /* call 0x10165d52 */
            ii(0x100e_0446, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0447, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0448, 1); push(esi);                              /* push esi */
            ii(0x100e_0449, 1); push(edi);                              /* push edi */
            ii(0x100e_044a, 1); push(ebp);                              /* push ebp */
            ii(0x100e_044b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_044d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0453, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0456, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_0459, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_045e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_0461, 5); call(0x1007_5e24, -0x6_a642);           /* call 0x10075e24 */
            ii(0x100e_0466, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0469, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_046c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_046f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_0472, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0474, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0475, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0476, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0477, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0478, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0479, 1); ret();                                  /* ret */
        }
    }
}
