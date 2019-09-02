using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0548-bc1018f4")]
        public void Method_100e_0548()
        {
            ii(0x100e_0548, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_054d, 5); call(Definitions.sys_check_available_stack_size, 0x8_5800); /* call 0x10165d52 */
            ii(0x100e_0552, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0553, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0554, 1); push(esi);                              /* push esi */
            ii(0x100e_0555, 1); push(edi);                              /* push edi */
            ii(0x100e_0556, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0557, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0559, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_055f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0562, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_0565, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_0568, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_056b, 5); call(0x1007_6c98, -0x6_98d8);           /* call 0x10076c98 */
            ii(0x100e_0570, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_0573, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_0576, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0578, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0579, 1); pop(edi);                               /* pop edi */
            ii(0x100e_057a, 1); pop(esi);                               /* pop esi */
            ii(0x100e_057b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_057c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_057d, 1); ret();                                  /* ret */
        }
    }
}
