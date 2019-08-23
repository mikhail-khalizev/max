using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b520-f0a4e009")]
        public void Method_100c_b520()
        {
            ii(0x100c_b520, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_b525, 5); call(Definitions.sys_check_available_stack_size, 0x9_a828); /* call 0x10165d52 */
            ii(0x100c_b52a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b52b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b52c, 1); push(edx);                              /* push edx */
            ii(0x100c_b52d, 1); push(esi);                              /* push esi */
            ii(0x100c_b52e, 1); push(edi);                              /* push edi */
            ii(0x100c_b52f, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b530, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b532, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b538, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b53b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b53e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_b540, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b543, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b546, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b548, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b549, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b54a, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b54b, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b54c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b54d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b54e, 1); ret();                                  /* ret */
        }
    }
}
