using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_649b-af168f07")]
        public void Method_100e_649b()
        {
            ii(0x100e_649b, 5);  push(0x40);                           /* push 0x40 */
            ii(0x100e_64a0, 5);  call(Definitions.sys_check_available_stack_size, 0x7_f8ad);/* call 0x10165d52 */
            ii(0x100e_64a5, 1);  push(esi);                            /* push esi */
            ii(0x100e_64a6, 1);  push(edi);                            /* push edi */
            ii(0x100e_64a7, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_64a8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_64aa, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x100e_64b0, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_64b3, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_64b6, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x100e_64b9, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_64bc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_64be, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_64c2, 5);  call(0x1007_6e7c, -0x6_f64b);         /* call 0x10076e7c */
            ii(0x100e_64c7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_64ca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_64cc, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100e_64d0, 5);  call(0x1007_6e7c, -0x6_f659);         /* call 0x10076e7c */
            ii(0x100e_64d5, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_64d8, 6);  mov(edx, memd[ds, 0x101b_8746]);      /* mov edx, [0x101b8746] */
            ii(0x100e_64de, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100e_64e1, 1);  dec(edx);                             /* dec edx */
            ii(0x100e_64e2, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_64e6, 5);  call(Definitions.my_min, -0x5_cd67);  /* call 0x10089784 */
            ii(0x100e_64eb, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_64ee, 5);  mov(eax, memd[ds, 0x101b_8748]);      /* mov eax, [0x101b8748] */
            ii(0x100e_64f3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_64f6, 3);  lea(edx, memd[ds, eax - 1]);          /* lea edx, [eax-0x1] */
            ii(0x100e_64f9, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100e_64fd, 5);  call(Definitions.my_min, -0x5_cd7e);  /* call 0x10089784 */
            ii(0x100e_6502, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_6505, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_6508, 3);  sub(eax, memd[ss, ebp - 20]);         /* sub eax, [ebp-0x14] */
            ii(0x100e_650b, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_650c, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_650f, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_6512, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100e_6515, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_6516, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_6519, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100e_651d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_651f, 2);  if(jle(0x100e_6529, 8)) goto l_0x100e_6529;/* jle 0x100e6529 */
            ii(0x100e_6521, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_6525, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_6527, 2);  if(jg(0x100e_652b, 2)) goto l_0x100e_652b;/* jg 0x100e652b */
        l_0x100e_6529:
            ii(0x100e_6529, 2);  jmp(0x100e_6560, 0x35); goto l_0x100e_6560;/* jmp 0x100e6560 */
        l_0x100e_652b:
            ii(0x100e_652b, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_652f, 6);  imul(edx, eax, 0x280);                /* imul edx, eax, 0x280 */
            ii(0x100e_6535, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_6538, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100e_653b, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_653d, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_6541, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_6543, 3);  mov(memd[ss, ebp - 44], edx);         /* mov [ebp-0x2c], edx */
            ii(0x100e_6546, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_654a, 1);  push(eax);                            /* push eax */
            ii(0x100e_654b, 5);  mov(ecx, 0x280);                      /* mov ecx, 0x280 */
            ii(0x100e_6550, 4);  movsx(ebx, memw[ss, ebp - 40]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x100e_6554, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100e_6558, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100e_655b, 5);  call(/* sys */ 0x1016_ad78, 0x8_4818);/* call 0x1016ad78 */
        l_0x100e_6560:
            ii(0x100e_6560, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_6562, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_6563, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_6564, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_6565, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}
