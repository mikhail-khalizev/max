using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_66b4-c0859af1")]
        public void Method_100d_66b4()
        {
            ii(0x100d_66b4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_66b9, 5);  call(Definitions.sys_check_available_stack_size, 0x8_f694);/* call 0x10165d52 */
            ii(0x100d_66be, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_66bf, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_66c0, 1);  push(edx);                            /* push edx */
            ii(0x100d_66c1, 1);  push(esi);                            /* push esi */
            ii(0x100d_66c2, 1);  push(edi);                            /* push edi */
            ii(0x100d_66c3, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_66c4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_66c6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_66cc, 5);  mov(eax, 0x101b_7eac);                /* mov eax, 0x101b7eac */
            ii(0x100d_66d1, 5);  call(/* sys */ 0x1016_611f, 0x8_fa49);/* call 0x1016611f */
            ii(0x100d_66d6, 5);  mov(ebx, 0x101b_5ec8);                /* mov ebx, 0x101b5ec8 */
            ii(0x100d_66db, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x100d_66e0, 5);  mov(eax, 0x101c_35b4);                /* mov eax, 0x101c35b4 */
            ii(0x100d_66e5, 5);  call(Definitions.sys_call_ctor_arr_v2, 0x8_f886);/* call 0x10165f70 */
            ii(0x100d_66ea, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_66ed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_66f0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_66f3, 10);  mov(memd[ds, 0x101b_7eb4], 1);       /* mov dword [0x101b7eb4], 0x1 */
            ii(0x100d_66fd, 5);  mov(eax, 0x101c_3602);                /* mov eax, 0x101c3602 */
            ii(0x100d_6702, 5);  call(0x100d_6710, 9);                 /* call 0x100d6710 */
            ii(0x100d_6707, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_6709, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_670a, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_670b, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_670c, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_670d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_670e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_670f, 1);  ret();                                /* ret */
        }
    }
}
