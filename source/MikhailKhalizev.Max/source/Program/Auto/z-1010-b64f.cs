using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b64f-ba5d1583")]
        public void Method_1010_b64f()
        {
            ii(0x1010_b64f, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_b654, 5);  call(Definitions.sys_check_available_stack_size, 0x5_a6f9);/* call 0x10165d52 */
            ii(0x1010_b659, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_b65a, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_b65b, 1);  push(edx);                            /* push edx */
            ii(0x1010_b65c, 1);  push(esi);                            /* push esi */
            ii(0x1010_b65d, 1);  push(edi);                            /* push edi */
            ii(0x1010_b65e, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_b65f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_b661, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_b667, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b66a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b66d, 3);  mov(eax, memd[ds, eax + 13]);         /* mov eax, [eax+0xd] */
            ii(0x1010_b670, 3);  add(eax, 9);                          /* add eax, 0x9 */
            ii(0x1010_b673, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_b676, 4);  imul(eax, memd[ss, ebp - 8], 0x14);   /* imul eax, [ebp-0x8], 0x14 */
            ii(0x1010_b67a, 6);  mov(eax, memd[ds, eax + 0x101b_a5bc]);/* mov eax, [eax+0x101ba5bc] */
            ii(0x1010_b680, 5);  call(/* sys */ 0x1017_90ce, 0x6_da49);/* call 0x101790ce */
            ii(0x1010_b685, 5);  mov(ebx, 0x46);                       /* mov ebx, 0x46 */
            ii(0x1010_b68a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_b68c, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1010_b68e, 5);  call(0x100c_aafc, -0x4_0b97);         /* call 0x100caafc */
            ii(0x1010_b693, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b696, 5);  call(0x1010_a8f7, -0xda4);            /* call 0x1010a8f7 */
            ii(0x1010_b69b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b69e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_b6a0, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b6a3, 5);  call(Definitions.sys_display_draw_0, 0x5_bddc);/* call 0x10167484 */
            ii(0x1010_b6a8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_b6aa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_b6ab, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_b6ac, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_b6ad, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_b6ae, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_b6af, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_b6b0, 1);  ret();                                /* ret */
        }
    }
}
