using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_ae40-f02bcfd2")]
        public void Method_100e_ae40()
        {
            ii(0x100e_ae40, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_ae45, 5); call(Definitions.sys_check_available_stack_size, 0x7_af08); /* call 0x10165d52 */
            ii(0x100e_ae4a, 1); push(ecx);                              /* push ecx */
            ii(0x100e_ae4b, 1); push(esi);                              /* push esi */
            ii(0x100e_ae4c, 1); push(edi);                              /* push edi */
            ii(0x100e_ae4d, 1); push(ebp);                              /* push ebp */
            ii(0x100e_ae4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_ae50, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_ae56, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_ae59, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100e_ae5c, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100e_ae5f, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_ae63, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_ae66, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_ae69, 5); call(0x100c_d990, -0x1_d4de);           /* call 0x100cd990 */
            ii(0x100e_ae6e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ae70, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_ae71, 1); pop(edi);                               /* pop edi */
            ii(0x100e_ae72, 1); pop(esi);                               /* pop esi */
            ii(0x100e_ae73, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_ae74, 1); ret();                                  /* ret */
        }
    }
}
