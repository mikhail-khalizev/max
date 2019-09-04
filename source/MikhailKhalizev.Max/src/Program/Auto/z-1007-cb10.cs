using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cb10-def08033")]
        public void Method_1007_cb10()
        {
            ii(0x1007_cb10, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_cb15, 5); call(Definitions.sys_check_available_stack_size, 0xe_9238); /* call 0x10165d52 */
            ii(0x1007_cb1a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_cb1b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_cb1c, 1); push(edx);                              /* push edx */
            ii(0x1007_cb1d, 1); push(esi);                              /* push esi */
            ii(0x1007_cb1e, 1); push(edi);                              /* push edi */
            ii(0x1007_cb1f, 1); push(ebp);                              /* push ebp */
            ii(0x1007_cb20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cb22, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_cb28, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_cb2b, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_cb2f, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1007_cb32, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cb34, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_cb35, 1); pop(edi);                               /* pop edi */
            ii(0x1007_cb36, 1); pop(esi);                               /* pop esi */
            ii(0x1007_cb37, 1); pop(edx);                               /* pop edx */
            ii(0x1007_cb38, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_cb39, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_cb3a, 1); ret();                                  /* ret */
        }
    }
}
