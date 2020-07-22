using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9239-d799004b")]
        public void Method_100a_9239()
        {
            ii(0x100a_9239, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_923e, 5);  call(Definitions.sys_check_available_stack_size, 0xb_cb0f);/* call 0x10165d52 */
            ii(0x100a_9243, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_9244, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_9245, 1);  push(esi);                            /* push esi */
            ii(0x100a_9246, 1);  push(edi);                            /* push edi */
            ii(0x100a_9247, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_9248, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_924a, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_9250, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_9253, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_9256, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_925a, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_9260, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_9266, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_926b, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_926e, 2);  if(jnz(0x100a_9293, 0x23)) goto l_0x100a_9293;/* jnz 0x100a9293 */
            ii(0x100a_9270, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_9273, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_9276, 5);  call(0x1007_5e64, -0x3_3417);         /* call 0x10075e64 */
            ii(0x100a_927b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_927d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_9281, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x100a_9287, 5);  mov(ebx, 0x101c_31c4);                /* mov ebx, 0x101c31c4 */
            ii(0x100a_928c, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100a_928e, 5);  call(0x100c_2b35, 0x1_98a2);          /* call 0x100c2b35 */
        l_0x100a_9293:
            ii(0x100a_9293, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_9295, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_9296, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_9297, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_9298, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_9299, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_929a, 1);  ret();                                /* ret */
        }
    }
}
