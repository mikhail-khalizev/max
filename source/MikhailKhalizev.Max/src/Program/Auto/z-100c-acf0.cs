using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_acf0-17cbca73")]
        public void Method_100c_acf0()
        {
            ii(0x100c_acf0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_acf5, 5); call(Definitions.sys_check_available_stack_size, 0x9_b058); /* call 0x10165d52 */
            ii(0x100c_acfa, 1); push(ebx);                              /* push ebx */
            ii(0x100c_acfb, 1); push(ecx);                              /* push ecx */
            ii(0x100c_acfc, 1); push(esi);                              /* push esi */
            ii(0x100c_acfd, 1); push(edi);                              /* push edi */
            ii(0x100c_acfe, 1); push(ebp);                              /* push ebp */
            ii(0x100c_acff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ad01, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_ad07, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_ad0a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_ad0d, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100c_ad11, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ad14, 5); call(0x1008_b410, -0x3_f909);           /* call 0x1008b410 */
            ii(0x100c_ad19, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100c_ad1c, 5); call(0x1008_b440, -0x3_f8e1);           /* call 0x1008b440 */
            ii(0x100c_ad21, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_ad24, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_ad27, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ad29, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ad2a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ad2b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ad2c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ad2d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ad2e, 1); ret();                                  /* ret */
        }
    }
}
