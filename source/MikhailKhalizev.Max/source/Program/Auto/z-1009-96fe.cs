using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_96fe-3a0aac33")]
        public void Method_1009_96fe()
        {
            ii(0x1009_96fe, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_9703, 5);  call(Definitions.sys_check_available_stack_size, 0xc_c64a);/* call 0x10165d52 */
            ii(0x1009_9708, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_9709, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_970a, 1);  push(edx);                            /* push edx */
            ii(0x1009_970b, 1);  push(esi);                            /* push esi */
            ii(0x1009_970c, 1);  push(edi);                            /* push edi */
            ii(0x1009_970d, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_970e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_9710, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_9716, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_9719, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_971b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_971e, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1009_9721, 5);  call(0x1008_afe4, -0xe742);           /* call 0x1008afe4 */
            ii(0x1009_9726, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_9728, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_972b, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_972e, 5);  call(0x1009_c44c, 0x2d19);            /* call 0x1009c44c */
            ii(0x1009_9733, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_9736, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_973b, 5);  call(0x100a_5e27, 0xc6e7);            /* call 0x100a5e27 */
            ii(0x1009_9740, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9742, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_9743, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_9744, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_9745, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_9746, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_9747, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_9748, 1);  ret();                                /* ret */
        }
    }
}
