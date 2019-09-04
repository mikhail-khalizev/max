using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_ce16-42f114a4")]
        public void Method_1007_ce16()
        {
            ii(0x1007_ce16, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_ce1b, 5); call(Definitions.sys_check_available_stack_size, 0xe_8f32); /* call 0x10165d52 */
            ii(0x1007_ce20, 1); push(ebx);                              /* push ebx */
            ii(0x1007_ce21, 1); push(ecx);                              /* push ecx */
            ii(0x1007_ce22, 1); push(edx);                              /* push edx */
            ii(0x1007_ce23, 1); push(esi);                              /* push esi */
            ii(0x1007_ce24, 1); push(edi);                              /* push edi */
            ii(0x1007_ce25, 1); push(ebp);                              /* push ebp */
            ii(0x1007_ce26, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ce28, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_ce2e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_ce31, 5); mov(ebx, 0x1007_cf16);                  /* mov ebx, 0x1007cf16 */
            ii(0x1007_ce36, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_ce39, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ce3c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ce3f, 5); call(0x1007_63d4, -0x6a70);             /* call 0x100763d4 */
            ii(0x1007_ce44, 5); call(0x1007_8d4a, -0x40ff);             /* call 0x10078d4a */
            ii(0x1007_ce49, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1007_ce4c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1007_ce4f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ce51, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_ce52, 1); pop(edi);                               /* pop edi */
            ii(0x1007_ce53, 1); pop(esi);                               /* pop esi */
            ii(0x1007_ce54, 1); pop(edx);                               /* pop edx */
            ii(0x1007_ce55, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_ce56, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_ce57, 1); ret();                                  /* ret */
        }
    }
}
