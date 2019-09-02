using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a0f8-f744ceb0")]
        public void Method_100a_a0f8()
        {
            ii(0x100a_a0f8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a0fd, 5); call(Definitions.sys_check_available_stack_size, 0xb_bc50); /* call 0x10165d52 */
            ii(0x100a_a102, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a103, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a104, 1); push(esi);                              /* push esi */
            ii(0x100a_a105, 1); push(edi);                              /* push edi */
            ii(0x100a_a106, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a107, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a109, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a10f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a112, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a115, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_a11a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a11d, 5); call(Definitions.my_dtor_0x101b_6edc, 0x9_0b23); /* call 0x1013ac45 */
            ii(0x100a_a122, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a125, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a128, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a12b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a12e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a130, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a131, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a132, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a133, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a134, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a135, 1); ret();                                  /* ret */
        }
    }
}
