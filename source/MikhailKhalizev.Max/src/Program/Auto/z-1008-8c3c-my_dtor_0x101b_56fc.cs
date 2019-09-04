using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8c3c-278c39ef")]
        public void my_dtor_0x101b_56fc()
        {
            ii(0x1008_8c3c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8c41, 5); call(Definitions.sys_check_available_stack_size, 0xd_d10c); /* call 0x10165d52 */
            ii(0x1008_8c46, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8c47, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8c48, 1); push(esi);                              /* push esi */
            ii(0x1008_8c49, 1); push(edi);                              /* push edi */
            ii(0x1008_8c4a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8c4b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8c4d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8c53, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8c56, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8c59, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_8c5e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8c61, 5); call(0x1008_8bfc, -0x6a);               /* call 0x10088bfc */
            ii(0x1008_8c66, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8c69, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8c6c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8c6f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8c72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8c74, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8c75, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8c76, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8c77, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8c78, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8c79, 1); ret();                                  /* ret */
        }
    }
}
