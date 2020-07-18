using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_82bc-72a5315a")]
        public void Method_100b_82bc()
        {
            ii(0x100b_82bc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_82c1, 5);  call(Definitions.sys_check_available_stack_size, 0xa_da8c);/* call 0x10165d52 */
            ii(0x100b_82c6, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_82c7, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_82c8, 1);  push(edx);                            /* push edx */
            ii(0x100b_82c9, 1);  push(esi);                            /* push esi */
            ii(0x100b_82ca, 1);  push(edi);                            /* push edi */
            ii(0x100b_82cb, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_82cc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_82ce, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_82d4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_82d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_82da, 5);  call(0x1008_b410, -0x2_cecf);         /* call 0x1008b410 */
            ii(0x100b_82df, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100b_82e2, 5);  call(Definitions.my_3_get_count, -0x2_ce67);/* call 0x1008b480 */
            ii(0x100b_82e7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_82ea, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_82ed, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_82ef, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_82f0, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_82f1, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_82f2, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_82f3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_82f4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_82f5, 1);  ret();                                /* ret */
        }
    }
}
