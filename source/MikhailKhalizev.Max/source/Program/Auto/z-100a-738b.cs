using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_738b-4f045c44")]
        public void Method_100a_738b()
        {
            ii(0x100a_738b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_7390, 5);  call(Definitions.sys_check_available_stack_size, 0xb_e9bd);/* call 0x10165d52 */
            ii(0x100a_7395, 1);  push(esi);                            /* push esi */
            ii(0x100a_7396, 1);  push(edi);                            /* push edi */
            ii(0x100a_7397, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_7398, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_739a, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100a_73a0, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_73a3, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_73a6, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100a_73a9, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x100a_73ac, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100a_73b0, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_73b4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_73b7, 5);  call(0x1007_6aac, -0x3_0910);         /* call 0x10076aac */
            ii(0x100a_73bc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_73bf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_73c2, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_73c5, 3);  mov(memd[ds, edx + 4], eax);          /* mov [edx+0x4], eax */
            ii(0x100a_73c8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_73cb, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_73ce, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_73d1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_73d3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_73d4, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_73d5, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_73d6, 1);  ret();                                /* ret */
        }
    }
}
