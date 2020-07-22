using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5287-71d8bf3e")]
        public void Method_100a_5287()
        {
            ii(0x100a_5287, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_528c, 5);  call(Definitions.sys_check_available_stack_size, 0xc_0ac1);/* call 0x10165d52 */
            ii(0x100a_5291, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_5292, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_5293, 1);  push(esi);                            /* push esi */
            ii(0x100a_5294, 1);  push(edi);                            /* push edi */
            ii(0x100a_5295, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_5296, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_5298, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_529e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_52a1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_52a4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_52a7, 5);  call(0x1008_aef4, -0x1_a3b8);         /* call 0x1008aef4 */
            ii(0x100a_52ac, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_52ae, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_52b1, 5);  call(0x1008_ae70, -0x1_a446);         /* call 0x1008ae70 */
            ii(0x100a_52b6, 2);  jmp(0x100a_52c0, 8); goto l_0x100a_52c0;/* jmp 0x100a52c0 */
        l_0x100a_52b8:
            ii(0x100a_52b8, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_52bb, 5);  call(0x1007_6bf8, -0x2_e6c8);         /* call 0x10076bf8 */
        l_0x100a_52c0:
            ii(0x100a_52c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_52c2, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_52c5, 5);  call(0x1013_ad71, 0x9_5aa7);          /* call 0x1013ad71 */
            ii(0x100a_52ca, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_52cc, 2);  if(jz(0x100a_52f5, 0x27)) goto l_0x100a_52f5;/* jz 0x100a52f5 */
            ii(0x100a_52ce, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_52d1, 5);  call(0x1008_adc4, -0x1_a512);         /* call 0x1008adc4 */
            ii(0x100a_52d6, 5);  call(0x1008_ad90, -0x1_a54b);         /* call 0x1008ad90 */
            ii(0x100a_52db, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100a_52df, 2);  if(jnz(0x100a_52f3, 0x12)) goto l_0x100a_52f3;/* jnz 0x100a52f3 */
            ii(0x100a_52e1, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_52e6, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_52e9, 5);  call(0x1008_adc4, -0x1_a52a);         /* call 0x1008adc4 */
            ii(0x100a_52ee, 5);  call(0x100a_b168, 0x5e75);            /* call 0x100ab168 */
        l_0x100a_52f3:
            ii(0x100a_52f3, 2);  jmp(0x100a_52b8, -0x3d); goto l_0x100a_52b8;/* jmp 0x100a52b8 */
        l_0x100a_52f5:
            ii(0x100a_52f5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_52f7, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_52fa, 5);  call(0x1008_8bbc, -0x1_c743);         /* call 0x10088bbc */
            ii(0x100a_52ff, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_5301, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_5302, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_5303, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_5304, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_5305, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_5306, 1);  ret();                                /* ret */
        }
    }
}
