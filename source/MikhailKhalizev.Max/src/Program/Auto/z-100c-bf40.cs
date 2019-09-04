using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bf40-b428ca0a")]
        public void Method_100c_bf40()
        {
            ii(0x100c_bf40, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_bf45, 5); call(Definitions.sys_check_available_stack_size, 0x9_9e08); /* call 0x10165d52 */
            ii(0x100c_bf4a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_bf4b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_bf4c, 1); push(edx);                              /* push edx */
            ii(0x100c_bf4d, 1); push(esi);                              /* push esi */
            ii(0x100c_bf4e, 1); push(edi);                              /* push edi */
            ii(0x100c_bf4f, 1); push(ebp);                              /* push ebp */
            ii(0x100c_bf50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_bf52, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_bf58, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_bf5b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_bf5e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_bf61, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_bf64, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_bf67, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_bf6a, 3); call_abs(memd[ds, edx + 60]);           /* call dword [edx+0x3c] */
            ii(0x100c_bf6d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_bf6f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_bf70, 1); pop(edi);                               /* pop edi */
            ii(0x100c_bf71, 1); pop(esi);                               /* pop esi */
            ii(0x100c_bf72, 1); pop(edx);                               /* pop edx */
            ii(0x100c_bf73, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_bf74, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_bf75, 1); ret();                                  /* ret */
        }
    }
}
