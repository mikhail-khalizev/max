using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8e0c-f5df8cd2")]
        public void Method_1008_8e0c()
        {
            ii(0x1008_8e0c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8e11, 5); call(Definitions.sys_check_available_stack_size, 0xd_cf3c); /* call 0x10165d52 */
            ii(0x1008_8e16, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8e17, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8e18, 1); push(esi);                              /* push esi */
            ii(0x1008_8e19, 1); push(edi);                              /* push edi */
            ii(0x1008_8e1a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8e1b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8e1d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8e23, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8e26, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8e29, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_8e2e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8e31, 5); call(Definitions.my_dtor_0x101b_6edc, 0xb_1e0f); /* call 0x1013ac45 */
            ii(0x1008_8e36, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8e39, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8e3c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8e3f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8e42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8e44, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8e45, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8e46, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8e47, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8e48, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8e49, 1); ret();                                  /* ret */
        }
    }
}
