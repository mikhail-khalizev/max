using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b2f4-15513b50")]
        public void Method_100c_b2f4()
        {
            ii(0x100c_b2f4, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_b2f9, 5); call(Definitions.sys_check_available_stack_size, 0x9_aa54); /* call 0x10165d52 */
            ii(0x100c_b2fe, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b2ff, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b300, 1); push(edx);                              /* push edx */
            ii(0x100c_b301, 1); push(esi);                              /* push esi */
            ii(0x100c_b302, 1); push(edi);                              /* push edi */
            ii(0x100c_b303, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b304, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b306, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_b30c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b30f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b312, 3); mov(al, memb[ds, eax + 6]);             /* mov al, [eax+0x6] */
            ii(0x100c_b315, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100c_b318, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_b31b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b31d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b31e, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b31f, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b320, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b321, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b322, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b323, 1); ret();                                  /* ret */
        }
    }
}
