using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_04e4-e1832a3f")]
        public void Method_100e_04e4()
        {
            ii(0x100e_04e4, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_04e9, 5); call(Definitions.sys_check_available_stack_size, 0x8_5864); /* call 0x10165d52 */
            ii(0x100e_04ee, 1); push(ebx);                              /* push ebx */
            ii(0x100e_04ef, 1); push(ecx);                              /* push ecx */
            ii(0x100e_04f0, 1); push(edx);                              /* push edx */
            ii(0x100e_04f1, 1); push(esi);                              /* push esi */
            ii(0x100e_04f2, 1); push(edi);                              /* push edi */
            ii(0x100e_04f3, 1); push(ebp);                              /* push ebp */
            ii(0x100e_04f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_04f6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_04fc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_04ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0502, 5); call(0x1007_6c30, -0x6_98d7);           /* call 0x10076c30 */
            ii(0x100e_0507, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_050a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_050d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_050f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0510, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0511, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0512, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0513, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0514, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0515, 1); ret();                                  /* ret */
        }
    }
}
