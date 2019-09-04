using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2700-7b04efad")]
        public void Method_1008_2700()
        {
            ii(0x1008_2700, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1008_2705, 5);  call(Definitions.sys_check_available_stack_size, 0xe_3648);/* call 0x10165d52 */
            ii(0x1008_270a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_270b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_270c, 1);  push(esi);                            /* push esi */
            ii(0x1008_270d, 1);  push(edi);                            /* push edi */
            ii(0x1008_270e, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_270f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_2711, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1008_2717, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_271a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_271d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2720, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_2723, 5);  call(0x1007_6b90, -0xbb98);           /* call 0x10076b90 */
            ii(0x1008_2728, 1);  cwde();                               /* cwde */
            ii(0x1008_2729, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_272b, 2);  if(jnz(0x1008_275f, 0x32)) goto l_0x1008_275f;/* jnz 0x1008275f */
            ii(0x1008_272d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2730, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_2733, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_2736, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_2739, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_273c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_273f, 3);  call_abs(memd[ds, ebx + 84]);         /* call dword [ebx+0x54] */
            ii(0x1008_2742, 5);  call(0x1008_ac50, 0x8509);            /* call 0x1008ac50 */
            ii(0x1008_2747, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1008_2749, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1008_274b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_274e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2751, 5);  call(0x1015_2962, 0xd_020c);          /* call 0x10152962 */
            ii(0x1008_2756, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_275a, 5);  jmp(0x1008_287f, 0x120); goto l_0x1008_287f;/* jmp 0x1008287f */
        l_0x1008_275f:
            ii(0x1008_275f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2762, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1008_2765, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_276a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_276c, 2);  if(jle(0x1008_277d, 0xf)) goto l_0x1008_277d;/* jle 0x1008277d */
            ii(0x1008_276e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_2771, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2774, 5);  call(0x1015_2a52, 0xd_02d9);          /* call 0x10152a52 */
            ii(0x1008_2779, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_277b, 2);  if(jnz(0x1008_2782, 5)) goto l_0x1008_2782;/* jnz 0x10082782 */
        l_0x1008_277d:
            ii(0x1008_277d, 5);  jmp(0x1008_287b, 0xf9); goto l_0x1008_287b;/* jmp 0x1008287b */
        l_0x1008_2782:
            ii(0x1008_2782, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2785, 5);  call(0x1007_623c, -0xc54e);           /* call 0x1007623c */
            ii(0x1008_278a, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1008_278d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_2790, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1008_2792, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1008_2795, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1008_2798, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x1008_279a, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1008_279d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_279f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_27a2, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1008_27a5, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_27aa, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1008_27ac, 2);  if(jl(0x1008_27fc, 0x4e)) goto l_0x1008_27fc;/* jl 0x100827fc */
            ii(0x1008_27ae, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_27b1, 3);  add(edx, 0x32);                       /* add edx, 0x32 */
            ii(0x1008_27b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_27b7, 5);  call(0x1007_6d98, -0xba24);           /* call 0x10076d98 */
            ii(0x1008_27bc, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_27be, 2);  if(jnz(0x1008_27d2, 0x12)) goto l_0x1008_27d2;/* jnz 0x100827d2 */
            ii(0x1008_27c0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_27c3, 3);  add(edx, 0x3e);                       /* add edx, 0x3e */
            ii(0x1008_27c6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_27c9, 5);  call(0x1007_6d98, -0xba36);           /* call 0x10076d98 */
            ii(0x1008_27ce, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_27d0, 2);  if(jz(0x1008_27fa, 0x28)) goto l_0x1008_27fa;/* jz 0x100827fa */
        l_0x1008_27d2:
            ii(0x1008_27d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_27d5, 5);  call(0x1007_623c, -0xc59e);           /* call 0x1007623c */
            ii(0x1008_27da, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1008_27dd, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_27e0, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1008_27e2, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1008_27e5, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1008_27e7, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1008_27e9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_27eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_27ee, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1008_27f1, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_27f6, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1008_27f8, 2);  if(jl(0x1008_27fc, 2)) goto l_0x1008_27fc;/* jl 0x100827fc */
        l_0x1008_27fa:
            ii(0x1008_27fa, 2);  jmp(0x1008_2868, 0x6c); goto l_0x1008_2868;/* jmp 0x10082868 */
        l_0x1008_27fc:
            ii(0x1008_27fc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_27ff, 5);  call(0x1015_287d, 0xd_0079);          /* call 0x1015287d */
            ii(0x1008_2804, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x1008_2809, 5);  call(Definitions.sys_new, 0xe_35f2);  /* call 0x10165e00 */
            ii(0x1008_280e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_2811, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_2814, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_2817, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1008_281b, 2);  if(jz(0x1008_2833, 0x16)) goto l_0x1008_2833;/* jz 0x10082833 */
            ii(0x1008_281d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_2820, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_2823, 5);  call(Definitions.my_ctor_c15, 0x4_9060);/* call 0x100cb888 */
            ii(0x1008_2828, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_282b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_282e, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_2831, 2);  jmp(0x1008_2839, 6); goto l_0x1008_2839;/* jmp 0x10082839 */
        l_0x1008_2833:
            ii(0x1008_2833, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_2836, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_2839:
            ii(0x1008_2839, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1008_283c, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_283f, 5);  call(0x1008_b060, 0x881c);            /* call 0x1008b060 */
            ii(0x1008_2844, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_2847, 5);  call(0x1008_af84, 0x8738);            /* call 0x1008af84 */
            ii(0x1008_284c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_284e, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_2853, 5);  call(0x100a_4d50, 0x2_24f8);          /* call 0x100a4d50 */
            ii(0x1008_2858, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_285c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_285e, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_2861, 5);  call(0x1008_8b7c, 0x6316);            /* call 0x10088b7c */
            ii(0x1008_2866, 2);  jmp(0x1008_287f, 0x17); goto l_0x1008_287f;/* jmp 0x1008287f */
        l_0x1008_2868:
            ii(0x1008_2868, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_286b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_286e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2871, 5);  call(0x1008_58d6, 0x3060);            /* call 0x100858d6 */
            ii(0x1008_2876, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1008_2879, 2);  jmp(0x1008_287f, 4); goto l_0x1008_287f;/* jmp 0x1008287f */
        l_0x1008_287b:
            ii(0x1008_287b, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_287f:
            ii(0x1008_287f, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_2882, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_2884, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_2885, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_2886, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_2887, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_2888, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_2889, 1);  ret();                                /* ret */
        }
    }
}
