using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b39c-23371662")]
        public void Method_100c_b39c()
        {
            ii(0x100c_b39c, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_b3a1, 5); call(Definitions.sys_check_available_stack_size, 0x9_a9ac); /* call 0x10165d52 */
            ii(0x100c_b3a6, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b3a7, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b3a8, 1); push(edx);                              /* push edx */
            ii(0x100c_b3a9, 1); push(esi);                              /* push esi */
            ii(0x100c_b3aa, 1); push(edi);                              /* push edi */
            ii(0x100c_b3ab, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b3ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b3ae, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_b3b4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b3b7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b3ba, 5); call(0x1008_b410, -0x3_ffaf);           /* call 0x1008b410 */
            ii(0x100c_b3bf, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_b3c2, 5); call(0x1009_cb94, -0x2_e833);           /* call 0x1009cb94 */
            ii(0x100c_b3c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b3c9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b3ca, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b3cb, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b3cc, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b3cd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b3ce, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b3cf, 1); ret();                                  /* ret */
        }
    }
}
