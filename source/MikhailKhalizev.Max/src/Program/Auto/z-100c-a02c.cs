using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a02c-a9d59dcc")]
        public void Method_100c_a02c()
        {
            ii(0x100c_a02c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a031, 5); call(Definitions.sys_check_available_stack_size, 0x9_bd1c); /* call 0x10165d52 */
            ii(0x100c_a036, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a037, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a038, 1); push(edx);                              /* push edx */
            ii(0x100c_a039, 1); push(esi);                              /* push esi */
            ii(0x100c_a03a, 1); push(edi);                              /* push edi */
            ii(0x100c_a03b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a03c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a03e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_a044, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_a047, 5); call(0x1008_b3ec, -0x3_ec60);           /* call 0x1008b3ec */
            ii(0x100c_a04c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_a04f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_a052, 5); call(0x1008_b1e4, -0x3_ee73);           /* call 0x1008b1e4 */
            ii(0x100c_a057, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a05a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a05d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a05f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a060, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a061, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a062, 1); pop(edx);                               /* pop edx */
            ii(0x100c_a063, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a064, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a065, 1); ret();                                  /* ret */
        }
    }
}
