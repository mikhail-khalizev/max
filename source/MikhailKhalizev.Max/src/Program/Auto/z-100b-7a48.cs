using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7a48-bda5a2da")]
        public void Method_100b_7a48()
        {
            ii(0x100b_7a48, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7a4d, 5); call(Definitions.sys_check_available_stack_size, 0xa_e300); /* call 0x10165d52 */
            ii(0x100b_7a52, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7a53, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7a54, 1); push(edx);                              /* push edx */
            ii(0x100b_7a55, 1); push(esi);                              /* push esi */
            ii(0x100b_7a56, 1); push(edi);                              /* push edi */
            ii(0x100b_7a57, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7a58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7a5a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7a60, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7a63, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7a66, 5); call(0x1007_6c30, -0x4_0e3b);           /* call 0x10076c30 */
            ii(0x100b_7a6b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7a6e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7a71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7a73, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7a74, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7a75, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7a76, 1); pop(edx);                               /* pop edx */
            ii(0x100b_7a77, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7a78, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7a79, 1); ret();                                  /* ret */
        }
    }
}
