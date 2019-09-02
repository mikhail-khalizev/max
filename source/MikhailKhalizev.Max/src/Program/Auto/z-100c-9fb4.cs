using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_9fb4-464372a7")]
        public void Method_100c_9fb4()
        {
            ii(0x100c_9fb4, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_9fb9, 5); call(Definitions.sys_check_available_stack_size, 0x9_bd94); /* call 0x10165d52 */
            ii(0x100c_9fbe, 1); push(ebx);                              /* push ebx */
            ii(0x100c_9fbf, 1); push(ecx);                              /* push ecx */
            ii(0x100c_9fc0, 1); push(edx);                              /* push edx */
            ii(0x100c_9fc1, 1); push(esi);                              /* push esi */
            ii(0x100c_9fc2, 1); push(edi);                              /* push edi */
            ii(0x100c_9fc3, 1); push(ebp);                              /* push ebp */
            ii(0x100c_9fc4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_9fc6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_9fcc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_9fcf, 5); call(0x100c_af14, 0xf40);               /* call 0x100caf14 */
            ii(0x100c_9fd4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_9fd7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_9fda, 5); call(0x100c_aeac, 0xecd);               /* call 0x100caeac */
            ii(0x100c_9fdf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_9fe2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9fe5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9fe7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_9fe8, 1); pop(edi);                               /* pop edi */
            ii(0x100c_9fe9, 1); pop(esi);                               /* pop esi */
            ii(0x100c_9fea, 1); pop(edx);                               /* pop edx */
            ii(0x100c_9feb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_9fec, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_9fed, 1); ret();                                  /* ret */
        }
    }
}
