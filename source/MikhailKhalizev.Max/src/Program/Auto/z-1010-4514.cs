using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4514-e08b1234")]
        public void Method_1010_4514()
        {
            ii(0x1010_4514, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_4519, 5); call(Definitions.sys_check_available_stack_size, 0x6_1834); /* call 0x10165d52 */
            ii(0x1010_451e, 1); push(ebx);                              /* push ebx */
            ii(0x1010_451f, 1); push(ecx);                              /* push ecx */
            ii(0x1010_4520, 1); push(esi);                              /* push esi */
            ii(0x1010_4521, 1); push(edi);                              /* push edi */
            ii(0x1010_4522, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4523, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4525, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_452b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_452e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_4531, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_4534, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_4537, 5); call(0x1007_6c98, -0x8_d8a4);           /* call 0x10076c98 */
            ii(0x1010_453c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_453f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_4542, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4544, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_4545, 1); pop(edi);                               /* pop edi */
            ii(0x1010_4546, 1); pop(esi);                               /* pop esi */
            ii(0x1010_4547, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_4548, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_4549, 1); ret();                                  /* ret */
        }
    }
}
