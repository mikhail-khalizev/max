using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8978-f26d759")]
        public void Method_100c_8978()
        {
            ii(0x100c_8978, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_897d, 5); call(Definitions.sys_check_available_stack_size, 0x9_d3d0); /* call 0x10165d52 */
            ii(0x100c_8982, 1); push(ebx);                              /* push ebx */
            ii(0x100c_8983, 1); push(ecx);                              /* push ecx */
            ii(0x100c_8984, 1); push(edx);                              /* push edx */
            ii(0x100c_8985, 1); push(esi);                              /* push esi */
            ii(0x100c_8986, 1); push(edi);                              /* push edi */
            ii(0x100c_8987, 1); push(ebp);                              /* push ebp */
            ii(0x100c_8988, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_898a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_8990, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_8993, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_899a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_899d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_899f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_89a0, 1); pop(edi);                               /* pop edi */
            ii(0x100c_89a1, 1); pop(esi);                               /* pop esi */
            ii(0x100c_89a2, 1); pop(edx);                               /* pop edx */
            ii(0x100c_89a3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_89a4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_89a5, 1); ret();                                  /* ret */
        }
    }
}
