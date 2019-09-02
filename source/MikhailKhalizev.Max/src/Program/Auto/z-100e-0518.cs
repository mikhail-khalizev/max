using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0518-1a2aafe0")]
        public void Method_100e_0518()
        {
            ii(0x100e_0518, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_051d, 5); call(Definitions.sys_check_available_stack_size, 0x8_5830); /* call 0x10165d52 */
            ii(0x100e_0522, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0523, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0524, 1); push(edx);                              /* push edx */
            ii(0x100e_0525, 1); push(esi);                              /* push esi */
            ii(0x100e_0526, 1); push(edi);                              /* push edi */
            ii(0x100e_0527, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0528, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_052a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_0530, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0533, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0536, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_0538, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_053b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_053e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0540, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0541, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0542, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0543, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0544, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0545, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0546, 1); ret();                                  /* ret */
        }
    }
}
