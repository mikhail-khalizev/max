using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_27f0-58bb8852")]
        public void Method_100c_27f0()
        {
            ii(0x100c_27f0, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100c_27f5, 5);  call(Definitions.sys_check_available_stack_size, 0xa_3558);/* call 0x10165d52 */
            ii(0x100c_27fa, 1);  push(esi);                            /* push esi */
            ii(0x100c_27fb, 1);  push(edi);                            /* push edi */
            ii(0x100c_27fc, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_27fd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_27ff, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100c_2805, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_2808, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100c_280b, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_280e, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_2811, 4);  or(memb[ss, ebp - 20], 1);            /* or byte [ebp-0x14], 0x1 */
            ii(0x100c_2815, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100c_281a, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_281e, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x100c_2821, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_2824, 5);  call(0x100c_22fd, -0x52c);            /* call 0x100c22fd */
            ii(0x100c_2829, 3);  lea(esi, memd[ss, ebp - 28]);         /* lea esi, [ebp-0x1c] */
            ii(0x100c_282c, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x100c_282e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_2830, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x100c_2832, 5);  call(0x100b_8505, -0xa332);           /* call 0x100b8505 */
            ii(0x100c_2837, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_283a, 4);  and(memb[ss, ebp - 20], -2 /* 0xfe */);/* and byte [ebp-0x14], 0xfe */
            ii(0x100c_283e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_2840, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_2843, 5);  call(0x1008_8dcc, -0x3_9a7c);         /* call 0x10088dcc */
            ii(0x100c_2848, 6);  test(memw[ss, ebp - 4], 1);           /* test word [ebp-0x4], 0x1 */
            ii(0x100c_284e, 2);  if(jz(0x100c_289c, 0x4c)) goto l_0x100c_289c;/* jz 0x100c289c */
            ii(0x100c_2850, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100c_2857, 2);  jmp(0x100c_285f, 6); goto l_0x100c_285f;/* jmp 0x100c285f */
        l_0x100c_2859:
            ii(0x100c_2859, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_285c, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x100c_285f:
            ii(0x100c_285f, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_2862, 5);  call(0x1008_a4a0, -0x3_83c7);         /* call 0x1008a4a0 */
            ii(0x100c_2867, 4);  cmp(ax, memw[ss, ebp - 36]);          /* cmp ax, [ebp-0x24] */
            ii(0x100c_286b, 2);  if(jle(0x100c_289c, 0x2f)) goto l_0x100c_289c;/* jle 0x100c289c */
            ii(0x100c_286d, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_2871, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_2874, 5);  call(0x1008_a3dc, -0x3_849d);         /* call 0x1008a3dc */
            ii(0x100c_2879, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_287c, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100c_287f, 7);  test(memb[ds, eax + 0x101c_81c1], 2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100c_2886, 2);  if(jz(0x100c_289a, 0x12)) goto l_0x100c_289a;/* jz 0x100c289a */
            ii(0x100c_2888, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_288c, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_288f, 5);  call(0x1008_a3dc, -0x3_84b8);         /* call 0x1008a3dc */
            ii(0x100c_2894, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
        l_0x100c_289a:
            ii(0x100c_289a, 2);  jmp(0x100c_2859, -0x43); goto l_0x100c_2859;/* jmp 0x100c2859 */
        l_0x100c_289c:
            ii(0x100c_289c, 6);  test(memw[ss, ebp - 4], 2);           /* test word [ebp-0x4], 0x2 */
            ii(0x100c_28a2, 2);  if(jz(0x100c_28f0, 0x4c)) goto l_0x100c_28f0;/* jz 0x100c28f0 */
            ii(0x100c_28a4, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100c_28ab, 2);  jmp(0x100c_28b3, 6); goto l_0x100c_28b3;/* jmp 0x100c28b3 */
        l_0x100c_28ad:
            ii(0x100c_28ad, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_28b0, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x100c_28b3:
            ii(0x100c_28b3, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_28b6, 5);  call(0x1008_a4a0, -0x3_841b);         /* call 0x1008a4a0 */
            ii(0x100c_28bb, 4);  cmp(ax, memw[ss, ebp - 36]);          /* cmp ax, [ebp-0x24] */
            ii(0x100c_28bf, 2);  if(jle(0x100c_28f0, 0x2f)) goto l_0x100c_28f0;/* jle 0x100c28f0 */
            ii(0x100c_28c1, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_28c5, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_28c8, 5);  call(0x1008_a3dc, -0x3_84f1);         /* call 0x1008a3dc */
            ii(0x100c_28cd, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_28d0, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100c_28d3, 7);  test(memb[ds, eax + 0x101c_81c3], 0x10);/* test byte [eax+0x101c81c3], 0x10 */
            ii(0x100c_28da, 2);  if(jz(0x100c_28ee, 0x12)) goto l_0x100c_28ee;/* jz 0x100c28ee */
            ii(0x100c_28dc, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_28e0, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_28e3, 5);  call(0x1008_a3dc, -0x3_850c);         /* call 0x1008a3dc */
            ii(0x100c_28e8, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
        l_0x100c_28ee:
            ii(0x100c_28ee, 2);  jmp(0x100c_28ad, -0x43); goto l_0x100c_28ad;/* jmp 0x100c28ad */
        l_0x100c_28f0:
            ii(0x100c_28f0, 5);  call(0x1008_a4dc, -0x3_8419);         /* call 0x1008a4dc */
            ii(0x100c_28f5, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_28f7, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100c_28f9, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x100c_28fc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_28ff, 5);  call(0x100b_8505, -0xa3ff);           /* call 0x100b8505 */
            ii(0x100c_2904, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_2906, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100c_2909, 5);  call(0x1008_8dcc, -0x3_9b42);         /* call 0x10088dcc */
            ii(0x100c_290e, 2);  jmp(0x100c_291a, 0xa); goto l_0x100c_291a;/* jmp 0x100c291a */
        //  ii(0x100c_2910, 10);  Недостижимый код.
        l_0x100c_291a:
            ii(0x100c_291a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_291d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_291f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_2920, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_2921, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_2922, 1);  ret();                                /* ret */
        }
    }
}
