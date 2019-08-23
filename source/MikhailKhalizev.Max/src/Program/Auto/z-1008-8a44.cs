using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8a44-1a6ef2f4")]
        public void Method_1008_8a44()
        {
            ii(0x1008_8a44, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8a49, 5); call(Definitions.sys_check_available_stack_size, 0xd_d304); /* call 0x10165d52 */
            ii(0x1008_8a4e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8a4f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8a50, 1); push(esi);                              /* push esi */
            ii(0x1008_8a51, 1); push(edi);                              /* push edi */
            ii(0x1008_8a52, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8a53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8a55, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8a5b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8a5e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_8a61, 5); mov(ebx, 0x101b_3acc);                  /* mov ebx, 0x101b3acc */
            ii(0x1008_8a66, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1008_8a6b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8a6e, 5); call(Definitions.sys_call_dtor_arr_v2, 0xd_d56d); /* call 0x10165fe0 */
            ii(0x1008_8a73, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_8a76, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_8a79, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8a7b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8a7c, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8a7d, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8a7e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8a7f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8a80, 1); ret();                                  /* ret */
        }
    }
}
