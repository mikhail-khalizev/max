using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cb67-99316851")]
        public void Method_1007_cb67()
        {
            ii(0x1007_cb67, 5); push(0x20);                             /* push 0x20 */
            ii(0x1007_cb6c, 5); call(Definitions.sys_check_available_stack_size, 0xe_91e1); /* call 0x10165d52 */
            ii(0x1007_cb71, 1); push(ebx);                              /* push ebx */
            ii(0x1007_cb72, 1); push(ecx);                              /* push ecx */
            ii(0x1007_cb73, 1); push(edx);                              /* push edx */
            ii(0x1007_cb74, 1); push(esi);                              /* push esi */
            ii(0x1007_cb75, 1); push(edi);                              /* push edi */
            ii(0x1007_cb76, 1); push(ebp);                              /* push ebp */
            ii(0x1007_cb77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cb79, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1007_cb7f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_cb82, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_cb85, 5); call(0x1007_cbd0, 0x46);                /* call 0x1007cbd0 */
            ii(0x1007_cb8a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cb8c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_cb8d, 1); pop(edi);                               /* pop edi */
            ii(0x1007_cb8e, 1); pop(esi);                               /* pop esi */
            ii(0x1007_cb8f, 1); pop(edx);                               /* pop edx */
            ii(0x1007_cb90, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_cb91, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_cb92, 1); ret();                                  /* ret */
        }
    }
}
