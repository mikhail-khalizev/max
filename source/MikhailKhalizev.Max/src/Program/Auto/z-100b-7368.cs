using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7368-3814f4f6")]
        public void Method_100b_7368()
        {
            ii(0x100b_7368, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_736d, 5); call(Definitions.sys_check_available_stack_size, 0xa_e9e0); /* call 0x10165d52 */
            ii(0x100b_7372, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7373, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7374, 1); push(esi);                              /* push esi */
            ii(0x100b_7375, 1); push(edi);                              /* push edi */
            ii(0x100b_7376, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7377, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7379, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_737f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7382, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7385, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_738a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_738d, 5); call(Definitions.my_dtor_0x101b_6edc, 0x8_38b3); /* call 0x1013ac45 */
            ii(0x100b_7392, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7395, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7398, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_739b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_739e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_73a0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_73a1, 1); pop(edi);                               /* pop edi */
            ii(0x100b_73a2, 1); pop(esi);                               /* pop esi */
            ii(0x100b_73a3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_73a4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_73a5, 1); ret();                                  /* ret */
        }
    }
}
