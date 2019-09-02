using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8a84-8e932b90")]
        public void Method_1008_8a84()
        {
            ii(0x1008_8a84, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8a89, 5); call(Definitions.sys_check_available_stack_size, 0xd_d2c4); /* call 0x10165d52 */
            ii(0x1008_8a8e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8a8f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8a90, 1); push(esi);                              /* push esi */
            ii(0x1008_8a91, 1); push(edi);                              /* push edi */
            ii(0x1008_8a92, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8a93, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8a95, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8a9b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8a9e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8aa1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_8aa6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8aa9, 5); call(Definitions.my_dtor_0x101b_6edc, 0xb_2197); /* call 0x1013ac45 */
            ii(0x1008_8aae, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8ab1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8ab4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8ab7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8aba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8abc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8abd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8abe, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8abf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8ac0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8ac1, 1); ret();                                  /* ret */
        }
    }
}
