using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ad68-f124af73")]
        public void Method_100c_ad68()
        {
            ii(0x100c_ad68, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_ad6d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_afe0);/* call 0x10165d52 */
            ii(0x100c_ad72, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_ad73, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_ad74, 1);  push(esi);                            /* push esi */
            ii(0x100c_ad75, 1);  push(edi);                            /* push edi */
            ii(0x100c_ad76, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ad77, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ad79, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_ad7f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_ad82, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_ad85, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ad88, 5);  call(0x1008_b410, -0x3_f97d);         /* call 0x1008b410 */
            ii(0x100c_ad8d, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100c_ad90, 5);  call(Definitions.my_3_get_count, -0x3_f915);/* call 0x1008b480 */
            ii(0x100c_ad95, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100c_ad98, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_ad9b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ad9e, 5);  call(0x100c_adac, 9);                 /* call 0x100cadac */
            ii(0x100c_ada3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_ada5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_ada6, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_ada7, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_ada8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_ada9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_adaa, 1);  ret();                                /* ret */
        }
    }
}
