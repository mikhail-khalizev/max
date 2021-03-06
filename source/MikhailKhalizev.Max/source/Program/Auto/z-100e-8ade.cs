using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8ade-8db4e5c0")]
        public void Method_100e_8ade()
        {
            ii(0x100e_8ade, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_8ae3, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d26a);/* call 0x10165d52 */
            ii(0x100e_8ae8, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_8ae9, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_8aea, 1);  push(edx);                            /* push edx */
            ii(0x100e_8aeb, 1);  push(esi);                            /* push esi */
            ii(0x100e_8aec, 1);  push(edi);                            /* push edi */
            ii(0x100e_8aed, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8aee, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8af0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_8af6, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_8af9, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_8afd, 5);  call(Definitions.my_get_res_data_by_id_malloc, 0x4_b6e9);/* call 0x101341eb */
            ii(0x100e_8b02, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8b05, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_8b09, 2);  if(jz(0x100e_8b1b, 0x10)) goto l_0x100e_8b1b;/* jz 0x100e8b1b */
            ii(0x100e_8b0b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8b0e, 5);  call(0x100e_8a40, -0xd3);             /* call 0x100e8a40 */
            ii(0x100e_8b13, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8b16, 5);  call(Definitions.sys_delete, 0x7_d449);/* call 0x10165f64 */
        l_0x100e_8b1b:
            ii(0x100e_8b1b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_8b1d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_8b1e, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_8b1f, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_8b20, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_8b21, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_8b22, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_8b23, 1);  ret();                                /* ret */
        }
    }
}
