using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9fc4-8cbb26a1")]
        public void Method_1008_9fc4()
        {
            ii(0x1008_9fc4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9fc9, 5); call(Definitions.sys_check_available_stack_size, 0xd_bd84); /* call 0x10165d52 */
            ii(0x1008_9fce, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9fcf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9fd0, 1); push(edx);                              /* push edx */
            ii(0x1008_9fd1, 1); push(esi);                              /* push esi */
            ii(0x1008_9fd2, 1); push(edi);                              /* push edi */
            ii(0x1008_9fd3, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9fd4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9fd6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9fdc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9fdf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9fe2, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_9fe5, 5); call(0x1007_6338, -0x1_3cb2);           /* call 0x10076338 */
            ii(0x1008_9fea, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9fed, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9ff0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9ff2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9ff3, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9ff4, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9ff5, 1); pop(edx);                               /* pop edx */
            ii(0x1008_9ff6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9ff7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9ff8, 1); ret();                                  /* ret */
        }
    }
}
