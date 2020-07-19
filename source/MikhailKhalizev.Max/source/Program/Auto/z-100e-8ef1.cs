using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8ef1-11fb0bc4")]
        public void Method_100e_8ef1()
        {
            ii(0x100e_8ef1, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_8ef6, 5);  call(Definitions.sys_check_available_stack_size, 0x7_ce57);/* call 0x10165d52 */
            ii(0x100e_8efb, 1);  push(esi);                            /* push esi */
            ii(0x100e_8efc, 1);  push(edi);                            /* push edi */
            ii(0x100e_8efd, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8efe, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8f00, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100e_8f06, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8f09, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100e_8f0c, 3);  mov(memd[ss, ebp - 16], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x100e_8f0f, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_8f12, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100e_8f15, 1);  push(eax);                            /* push eax */
            ii(0x100e_8f16, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100e_8f1a, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x100e_8f1e, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100e_8f22, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8f26, 5);  call(Definitions.my_get_res_data_by_id, 0x4_b0ad);/* call 0x10133fd8 */
            ii(0x100e_8f2b, 5);  call(0x100e_8d1e, -0x212);            /* call 0x100e8d1e */
            ii(0x100e_8f30, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_8f32, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_8f33, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_8f34, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_8f35, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
