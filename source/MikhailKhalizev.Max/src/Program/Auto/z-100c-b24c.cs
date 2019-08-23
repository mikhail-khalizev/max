using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b24c-11eac508")]
        public void Method_100c_b24c()
        {
            ii(0x100c_b24c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_b251, 5); call(Definitions.sys_check_available_stack_size, 0x9_aafc); /* call 0x10165d52 */
            ii(0x100c_b256, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b257, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b258, 1); push(edx);                              /* push edx */
            ii(0x100c_b259, 1); push(esi);                              /* push esi */
            ii(0x100c_b25a, 1); push(edi);                              /* push edi */
            ii(0x100c_b25b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b25c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b25e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b264, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b267, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b26a, 5); call(0x1007_6b58, -0x5_4717);           /* call 0x10076b58 */
            ii(0x100c_b26f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b272, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b275, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b277, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b278, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b279, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b27a, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b27b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b27c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b27d, 1); ret();                                  /* ret */
        }
    }
}
