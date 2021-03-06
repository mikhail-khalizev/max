using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b104-76d2d8bc")]
        public void Method_1008_b104()
        {
            ii(0x1008_b104, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_b109, 5);  call(Definitions.sys_check_available_stack_size, 0xd_ac44);/* call 0x10165d52 */
            ii(0x1008_b10e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b10f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b110, 1);  push(esi);                            /* push esi */
            ii(0x1008_b111, 1);  push(edi);                            /* push edi */
            ii(0x1008_b112, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b113, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b115, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_b11b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_b11e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_b121, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1008_b125, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_b128, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_b12b, 6);  add(edx, 0x17c);                      /* add edx, 0x17c */
            ii(0x1008_b131, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_b133, 5);  call(0x1007_678c, -0x1_49ac);         /* call 0x1007678c */
            ii(0x1008_b138, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_b13b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_b13e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b140, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b141, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b142, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b143, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b144, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b145, 1);  ret();                                /* ret */
        }
    }
}
