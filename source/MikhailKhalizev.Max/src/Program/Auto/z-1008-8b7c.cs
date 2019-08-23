using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8b7c-49326dd2")]
        public void Method_1008_8b7c()
        {
            ii(0x1008_8b7c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8b81, 5); call(Definitions.sys_check_available_stack_size, 0xd_d1cc); /* call 0x10165d52 */
            ii(0x1008_8b86, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8b87, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8b88, 1); push(esi);                              /* push esi */
            ii(0x1008_8b89, 1); push(edi);                              /* push edi */
            ii(0x1008_8b8a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8b8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8b8d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8b93, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8b96, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_8b99, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8b9e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8ba1, 5); call(Definitions.my_dtor_0x101b_6edc, 0xb_209f); /* call 0x1013ac45 */
            ii(0x1008_8ba6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8ba9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8bac, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_8baf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_8bb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8bb4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8bb5, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8bb6, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8bb7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8bb8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8bb9, 1); ret();                                  /* ret */
        }
    }
}
