using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_adec-ebc8efc5")]
        public void Method_100c_adec()
        {
            ii(0x100c_adec, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_adf1, 5); call(Definitions.sys_check_available_stack_size, 0x9_af5c); /* call 0x10165d52 */
            ii(0x100c_adf6, 1); push(ebx);                              /* push ebx */
            ii(0x100c_adf7, 1); push(ecx);                              /* push ecx */
            ii(0x100c_adf8, 1); push(esi);                              /* push esi */
            ii(0x100c_adf9, 1); push(edi);                              /* push edi */
            ii(0x100c_adfa, 1); push(ebp);                              /* push ebp */
            ii(0x100c_adfb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_adfd, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_ae03, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_ae06, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_ae09, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100c_ae0d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ae10, 5); call(0x1008_b410, -0x3_fa05);           /* call 0x1008b410 */
            ii(0x100c_ae15, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100c_ae18, 5); call(0x100c_db14, 0x2cf7);              /* call 0x100cdb14 */
            ii(0x100c_ae1d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ae1f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ae20, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ae21, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ae22, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ae23, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ae24, 1); ret();                                  /* ret */
        }
    }
}
