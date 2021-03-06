using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_26d1-673b2b70")]
        public void Method_100a_26d1()
        {
            ii(0x100a_26d1, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100a_26d6, 5);  call(Definitions.sys_check_available_stack_size, 0xc_3677);/* call 0x10165d52 */
            ii(0x100a_26db, 1);  push(esi);                            /* push esi */
            ii(0x100a_26dc, 1);  push(edi);                            /* push edi */
            ii(0x100a_26dd, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_26de, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_26e0, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100a_26e6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_26e9, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_26ec, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x100a_26ef, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100a_26f2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_26f5, 5);  call(0x1013_aaa8, 0x9_83ae);          /* call 0x1013aaa8 */
            ii(0x100a_26fa, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_26fd, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_2700, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_2703, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_2706, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_2709, 5);  call(Definitions.my_ctor_0x101b_3b58, -0x1_766a);/* call 0x1008b0a4 */
            ii(0x100a_270e, 3);  sub(eax, 0xf);                        /* sub eax, 0xf */
            ii(0x100a_2711, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_2714, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_2717, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_271a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_271d, 7);  mov(memd[ds, eax + 2], 0x101b_4f54);  /* mov dword [eax+0x2], 0x101b4f54 */
            ii(0x100a_2724, 7);  inc(memw[ds, 0x101c_31b4]);           /* inc word [0x101c31b4] */
            ii(0x100a_272b, 7);  mov(dx, memw[ds, 0x101c_31b4]);       /* mov dx, [0x101c31b4] */
            ii(0x100a_2732, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_2735, 4);  mov(memw[ds, eax + 11], dx);          /* mov [eax+0xb], dx */
            ii(0x100a_2739, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_273c, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_273f, 4);  mov(memw[ds, edx + 9], ax);           /* mov [edx+0x9], ax */
            ii(0x100a_2743, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100a_2746, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_2749, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_274c, 5);  call(0x1008_afe4, -0x1_776d);         /* call 0x1008afe4 */
            ii(0x100a_2751, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2754, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_2757, 4);  mov(memw[ds, edx + 13], ax);          /* mov [edx+0xd], ax */
            ii(0x100a_275b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_275e, 4);  mov(memb[ds, eax + 6], 1);            /* mov byte [eax+0x6], 0x1 */
            ii(0x100a_2762, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_2765, 4);  mov(memb[ds, eax + 7], 0);            /* mov byte [eax+0x7], 0x0 */
            ii(0x100a_2769, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_276c, 4);  mov(memb[ds, eax + 8], 0);            /* mov byte [eax+0x8], 0x0 */
            ii(0x100a_2770, 7);  inc(memw[ds, 0x101c_31b6]);           /* inc word [0x101c31b6] */
            ii(0x100a_2777, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_277a, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_277d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_2780, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2782, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2783, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2784, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2785, 1);  ret();                                /* ret */
        }
    }
}
