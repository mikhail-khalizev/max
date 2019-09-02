using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7836-326ce7cc")]
        public void Method_100a_7836()
        {
            ii(0x100a_7836, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_783b, 5); call(Definitions.sys_check_available_stack_size, 0xb_e512); /* call 0x10165d52 */
            ii(0x100a_7840, 1); push(ebx);                              /* push ebx */
            ii(0x100a_7841, 1); push(ecx);                              /* push ecx */
            ii(0x100a_7842, 1); push(edx);                              /* push edx */
            ii(0x100a_7843, 1); push(esi);                              /* push esi */
            ii(0x100a_7844, 1); push(edi);                              /* push edi */
            ii(0x100a_7845, 1); push(ebp);                              /* push ebp */
            ii(0x100a_7846, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7848, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_784e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_7851, 4); mov(memb[ss, ebp - 8], 7);              /* mov byte [ebp-0x8], 0x7 */
            ii(0x100a_7855, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_7858, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_785a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_785b, 1); pop(edi);                               /* pop edi */
            ii(0x100a_785c, 1); pop(esi);                               /* pop esi */
            ii(0x100a_785d, 1); pop(edx);                               /* pop edx */
            ii(0x100a_785e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_785f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_7860, 1); ret();                                  /* ret */
        }
    }
}
