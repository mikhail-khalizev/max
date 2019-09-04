using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ba16-3294a18b")]
        public void Method_100c_ba16()
        {
            ii(0x100c_ba16, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_ba1b, 5); call(Definitions.sys_check_available_stack_size, 0x9_a332); /* call 0x10165d52 */
            ii(0x100c_ba20, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ba21, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ba22, 1); push(edx);                              /* push edx */
            ii(0x100c_ba23, 1); push(esi);                              /* push esi */
            ii(0x100c_ba24, 1); push(edi);                              /* push edi */
            ii(0x100c_ba25, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ba26, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ba28, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_ba2e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_ba31, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_ba38, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ba3b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ba3d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ba3e, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ba3f, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ba40, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ba41, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ba42, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ba43, 1); ret();                                  /* ret */
        }
    }
}
