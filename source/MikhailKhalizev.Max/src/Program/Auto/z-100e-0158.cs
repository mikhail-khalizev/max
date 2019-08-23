using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0158-72545019")]
        public void Method_100e_0158()
        {
            ii(0x100e_0158, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_015d, 5); call(Definitions.sys_check_available_stack_size, 0x8_5bf0); /* call 0x10165d52 */
            ii(0x100e_0162, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0163, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0164, 1); push(esi);                              /* push esi */
            ii(0x100e_0165, 1); push(edi);                              /* push edi */
            ii(0x100e_0166, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0167, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0169, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_016f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0172, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_0175, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_017a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_017d, 5); call(Definitions.my_dtor_0x101b_6edc, 0x5_aac3); /* call 0x1013ac45 */
            ii(0x100e_0182, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0185, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0188, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_018b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_018e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0190, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0191, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0192, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0193, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0194, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0195, 1); ret();                                  /* ret */
        }
    }
}
