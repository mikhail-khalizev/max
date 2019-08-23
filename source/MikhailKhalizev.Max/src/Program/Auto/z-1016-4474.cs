using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4474-a318ddaa")]
        public void Method_1016_4474()
        {
            ii(0x1016_4474, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_4479, 5); call(Definitions.sys_check_available_stack_size, 0x18d4); /* call 0x10165d52 */
            ii(0x1016_447e, 1); push(ebx);                              /* push ebx */
            ii(0x1016_447f, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4480, 1); push(esi);                              /* push esi */
            ii(0x1016_4481, 1); push(edi);                              /* push edi */
            ii(0x1016_4482, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4483, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4485, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_448b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_448e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_4491, 5); mov(ebx, 0x101b_38f8);                  /* mov ebx, 0x101b38f8 */
            ii(0x1016_4496, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1016_449b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_449e, 5); call(Definitions.sys_call_dtor_arr_v2, 0x1b3d); /* call 0x10165fe0 */
            ii(0x1016_44a3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_44a6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_44a9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_44ab, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_44ac, 1); pop(edi);                               /* pop edi */
            ii(0x1016_44ad, 1); pop(esi);                               /* pop esi */
            ii(0x1016_44ae, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_44af, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_44b0, 1); ret();                                  /* ret */
        }
    }
}
