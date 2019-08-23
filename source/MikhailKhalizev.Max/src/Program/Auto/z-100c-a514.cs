using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a514-5febd4c9")]
        public void Method_100c_a514()
        {
            ii(0x100c_a514, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a519, 5); call(Definitions.sys_check_available_stack_size, 0x9_b834); /* call 0x10165d52 */
            ii(0x100c_a51e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a51f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a520, 1); push(esi);                              /* push esi */
            ii(0x100c_a521, 1); push(edi);                              /* push edi */
            ii(0x100c_a522, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a523, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a525, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a52b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a52e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a531, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a536, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a539, 5); call(0x1013_a1be, 0x6_fc80);            /* call 0x1013a1be */
            ii(0x100c_a53e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a541, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a544, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a547, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_a54a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a54c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a54d, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a54e, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a54f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a550, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a551, 1); ret();                                  /* ret */
        }
    }
}
