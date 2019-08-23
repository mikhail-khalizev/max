using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_adf8-75f5199b")]
        public void Method_1008_adf8()
        {
            ii(0x1008_adf8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_adfd, 5); call(Definitions.sys_check_available_stack_size, 0xd_af50); /* call 0x10165d52 */
            ii(0x1008_ae02, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ae03, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ae04, 1); push(edx);                              /* push edx */
            ii(0x1008_ae05, 1); push(esi);                              /* push esi */
            ii(0x1008_ae06, 1); push(edi);                              /* push edi */
            ii(0x1008_ae07, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ae08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ae0a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_ae10, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ae13, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ae16, 5); call(0x1007_6c30, -0x1_41eb);           /* call 0x10076c30 */
            ii(0x1008_ae1b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_ae1e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_ae21, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ae23, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ae24, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ae25, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ae26, 1); pop(edx);                               /* pop edx */
            ii(0x1008_ae27, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ae28, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ae29, 1); ret();                                  /* ret */
        }
    }
}
