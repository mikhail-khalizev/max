using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_ad24-99b218a8")]
        public void Method_100e_ad24()
        {
            ii(0x100e_ad24, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_ad29, 5); call(Definitions.sys_check_available_stack_size, 0x7_b024); /* call 0x10165d52 */
            ii(0x100e_ad2e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_ad2f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_ad30, 1); push(edx);                              /* push edx */
            ii(0x100e_ad31, 1); push(esi);                              /* push esi */
            ii(0x100e_ad32, 1); push(edi);                              /* push edi */
            ii(0x100e_ad33, 1); push(ebp);                              /* push ebp */
            ii(0x100e_ad34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_ad36, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_ad3c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_ad3f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ad42, 1); inc(eax);                               /* inc eax */
            ii(0x100e_ad43, 5); call(Definitions.my_ctor_0x101b_4184, -0x7_4258); /* call 0x10076af0 */
            ii(0x100e_ad48, 1); dec(eax);                               /* dec eax */
            ii(0x100e_ad49, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_ad4c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ad4f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_ad52, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_ad55, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ad57, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_ad58, 1); pop(edi);                               /* pop edi */
            ii(0x100e_ad59, 1); pop(esi);                               /* pop esi */
            ii(0x100e_ad5a, 1); pop(edx);                               /* pop edx */
            ii(0x100e_ad5b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_ad5c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_ad5d, 1); ret();                                  /* ret */
        }
    }
}
