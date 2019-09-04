using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_44b4-21b5c56f")]
        public void Method_1016_44b4()
        {
            ii(0x1016_44b4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_44b9, 5); call(Definitions.sys_check_available_stack_size, 0x1894); /* call 0x10165d52 */
            ii(0x1016_44be, 1); push(ebx);                              /* push ebx */
            ii(0x1016_44bf, 1); push(ecx);                              /* push ecx */
            ii(0x1016_44c0, 1); push(esi);                              /* push esi */
            ii(0x1016_44c1, 1); push(edi);                              /* push edi */
            ii(0x1016_44c2, 1); push(ebp);                              /* push ebp */
            ii(0x1016_44c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_44c5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_44cb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_44ce, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_44d1, 5); mov(ebx, 0x101b_74f0);                  /* mov ebx, 0x101b74f0 */
            ii(0x1016_44d6, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1016_44db, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_44de, 5); call(Definitions.sys_call_dtor_arr_v2, 0x1afd); /* call 0x10165fe0 */
            ii(0x1016_44e3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1016_44e6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1016_44e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_44eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_44ec, 1); pop(edi);                               /* pop edi */
            ii(0x1016_44ed, 1); pop(esi);                               /* pop esi */
            ii(0x1016_44ee, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_44ef, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_44f0, 1); ret();                                  /* ret */
        }
    }
}
