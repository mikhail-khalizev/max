using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8cbc-99fcceac")]
        public void Method_1008_8cbc()
        {
            ii(0x1008_8cbc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8cc1, 5); call(Definitions.sys_check_available_stack_size, 0xd_d08c); /* call 0x10165d52 */
            ii(0x1008_8cc6, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8cc7, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8cc8, 1); push(esi);                              /* push esi */
            ii(0x1008_8cc9, 1); push(edi);                              /* push edi */
            ii(0x1008_8cca, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8ccb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8ccd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8cd3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8cd6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8cd9, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_8cde, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8ce1, 5); call(Definitions.my_dtor_0x101b_6edc, 0xb_1f5f); /* call 0x1013ac45 */
            ii(0x1008_8ce6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8ce9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8cec, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8cef, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8cf2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8cf4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8cf5, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8cf6, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8cf7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8cf8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8cf9, 1); ret();                                  /* ret */
        }
    }
}
