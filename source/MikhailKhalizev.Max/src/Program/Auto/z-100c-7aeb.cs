using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7aeb-7606dddb")]
        public void Method_100c_7aeb()
        {
            ii(0x100c_7aeb, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_7af0, 5); call(Definitions.sys_check_available_stack_size, 0x9_e25d); /* call 0x10165d52 */
            ii(0x100c_7af5, 1); push(ebx);                              /* push ebx */
            ii(0x100c_7af6, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7af7, 1); push(edx);                              /* push edx */
            ii(0x100c_7af8, 1); push(esi);                              /* push esi */
            ii(0x100c_7af9, 1); push(edi);                              /* push edi */
            ii(0x100c_7afa, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7afb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7afd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_7b03, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_7b06, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_7b09, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x100c_7b0c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_7b0f, 6); mov(memw[ds, eax + 0x1], 0xffff);       /* mov word [eax+0x1], 0xffff */
            ii(0x100c_7b15, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_7b18, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_7b1b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7b1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7b20, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7b21, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7b22, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7b23, 1); pop(edx);                               /* pop edx */
            ii(0x100c_7b24, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_7b25, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_7b26, 1); ret();                                  /* ret */
        }
    }
}
