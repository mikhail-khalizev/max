using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b044-ecab28cd")]
        public void Method_100a_b044()
        {
            ii(0x100a_b044, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_b049, 5); call(Definitions.sys_check_available_stack_size, 0xb_ad04); /* call 0x10165d52 */
            ii(0x100a_b04e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b04f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b050, 1); push(esi);                              /* push esi */
            ii(0x100a_b051, 1); push(edi);                              /* push edi */
            ii(0x100a_b052, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b053, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b055, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b05b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b05e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_b061, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b064, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b067, 5); call(0x1013_a66b, 0x8_f5ff);            /* call 0x1013a66b */
            ii(0x100a_b06c, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x100a_b06f, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100a_b072, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b074, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b075, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b076, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b077, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b078, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b079, 1); ret();                                  /* ret */
        }
    }
}
