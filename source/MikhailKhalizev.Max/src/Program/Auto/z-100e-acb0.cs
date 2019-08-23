using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_acb0-eb45c7e5")]
        public void Method_100e_acb0()
        {
            ii(0x100e_acb0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_acb5, 5); call(Definitions.sys_check_available_stack_size, 0x7_b098); /* call 0x10165d52 */
            ii(0x100e_acba, 1); push(ebx);                              /* push ebx */
            ii(0x100e_acbb, 1); push(ecx);                              /* push ecx */
            ii(0x100e_acbc, 1); push(edx);                              /* push edx */
            ii(0x100e_acbd, 1); push(esi);                              /* push esi */
            ii(0x100e_acbe, 1); push(edi);                              /* push edi */
            ii(0x100e_acbf, 1); push(ebp);                              /* push ebp */
            ii(0x100e_acc0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_acc2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_acc8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_accb, 5); call(0x100e_aecc, 0x1fc);               /* call 0x100eaecc */
            ii(0x100e_acd0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_acd3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_acd6, 5); call(0x100e_ae78, 0x19d);               /* call 0x100eae78 */
            ii(0x100e_acdb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_acde, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_ace1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ace3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_ace4, 1); pop(edi);                               /* pop edi */
            ii(0x100e_ace5, 1); pop(esi);                               /* pop esi */
            ii(0x100e_ace6, 1); pop(edx);                               /* pop edx */
            ii(0x100e_ace7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_ace8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_ace9, 1); ret();                                  /* ret */
        }
    }
}
