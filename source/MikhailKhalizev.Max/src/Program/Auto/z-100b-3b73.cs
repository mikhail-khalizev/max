using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3b73-dbd89e69")]
        public void Method_100b_3b73()
        {
            ii(0x100b_3b73, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_3b78, 5); call(Definitions.sys_check_available_stack_size, 0xb_21d5); /* call 0x10165d52 */
            ii(0x100b_3b7d, 1); push(ebx);                              /* push ebx */
            ii(0x100b_3b7e, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3b7f, 1); push(edx);                              /* push edx */
            ii(0x100b_3b80, 1); push(esi);                              /* push esi */
            ii(0x100b_3b81, 1); push(edi);                              /* push edi */
            ii(0x100b_3b82, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3b83, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3b85, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100b_3b8b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_3b8e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_3b91, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3b94, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3b97, 5); call(0x1007_6574, -0x3_d628);           /* call 0x10076574 */
            ii(0x100b_3b9c, 5); call(0x1015_27ed, 0x9_ec4c);            /* call 0x101527ed */
            ii(0x100b_3ba1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3ba4, 5); call(0x100b_3ed0, 0x327);               /* call 0x100b3ed0 */
            ii(0x100b_3ba9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3bab, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3bac, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3bad, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3bae, 1); pop(edx);                               /* pop edx */
            ii(0x100b_3baf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3bb0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3bb1, 1); ret();                                  /* ret */
        }
    }
}
