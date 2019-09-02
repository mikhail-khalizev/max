using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d995-f69e7753")]
        public void Method_100a_d995()
        {
            ii(0x100a_d995, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_d99a, 5); call(Definitions.sys_check_available_stack_size, 0xb_83b3); /* call 0x10165d52 */
            ii(0x100a_d99f, 1); push(ebx);                              /* push ebx */
            ii(0x100a_d9a0, 1); push(ecx);                              /* push ecx */
            ii(0x100a_d9a1, 1); push(esi);                              /* push esi */
            ii(0x100a_d9a2, 1); push(edi);                              /* push edi */
            ii(0x100a_d9a3, 1); push(ebp);                              /* push ebp */
            ii(0x100a_d9a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d9a6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_d9ac, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_d9af, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_d9b2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_d9b5, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_d9b8, 5); mov(edx, 3);                            /* mov edx, 0x3 */
            ii(0x100a_d9bd, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_d9c0, 5); call(0x100a_d02d, -0x998);              /* call 0x100ad02d */
            ii(0x100a_d9c5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d9c7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_d9c8, 1); pop(edi);                               /* pop edi */
            ii(0x100a_d9c9, 1); pop(esi);                               /* pop esi */
            ii(0x100a_d9ca, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_d9cb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_d9cc, 1); ret();                                  /* ret */
        }
    }
}
