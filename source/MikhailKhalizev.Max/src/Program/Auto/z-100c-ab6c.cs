using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ab6c-2d79344c")]
        public void Method_100c_ab6c()
        {
            ii(0x100c_ab6c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_ab71, 5); call(Definitions.sys_check_available_stack_size, 0x9_b1dc); /* call 0x10165d52 */
            ii(0x100c_ab76, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ab77, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ab78, 1); push(edx);                              /* push edx */
            ii(0x100c_ab79, 1); push(esi);                              /* push esi */
            ii(0x100c_ab7a, 1); push(edi);                              /* push edi */
            ii(0x100c_ab7b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ab7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ab7e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_ab84, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_ab87, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ab8a, 4); mov(ax, memw[ds, eax + 0xe]);           /* mov ax, [eax+0xe] */
            ii(0x100c_ab8e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_ab91, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ab94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ab96, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ab97, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ab98, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ab99, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ab9a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ab9b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ab9c, 1); ret();                                  /* ret */
        }
    }
}
