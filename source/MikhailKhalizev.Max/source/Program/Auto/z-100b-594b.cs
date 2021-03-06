using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_594b-ed1e9e18")]
        public void Method_100b_594b()
        {
            ii(0x100b_594b, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_5950, 5);  call(Definitions.sys_check_available_stack_size, 0xb_03fd);/* call 0x10165d52 */
            ii(0x100b_5955, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_5956, 1);  push(esi);                            /* push esi */
            ii(0x100b_5957, 1);  push(edi);                            /* push edi */
            ii(0x100b_5958, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_5959, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_595b, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_5961, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_5964, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_5967, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100b_596a, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_596c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100b_596f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_5972, 5);  call(0x1015_2962, 0x9_cfeb);          /* call 0x10152962 */
            ii(0x100b_5977, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100b_597a, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100b_597f, 5);  call(0x100a_5e27, -0xfb5d);           /* call 0x100a5e27 */
            ii(0x100b_5984, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_5986, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_5987, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_5988, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_5989, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_598a, 1);  ret();                                /* ret */
        }
    }
}
