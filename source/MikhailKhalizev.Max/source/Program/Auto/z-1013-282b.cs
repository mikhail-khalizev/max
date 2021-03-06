using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_282b-1453fefc")]
        public void Method_1013_282b()
        {
            ii(0x1013_282b, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1013_2830, 5);  call(Definitions.sys_check_available_stack_size, 0x3_351d);/* call 0x10165d52 */
            ii(0x1013_2835, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_2836, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_2837, 1);  push(esi);                            /* push esi */
            ii(0x1013_2838, 1);  push(edi);                            /* push edi */
            ii(0x1013_2839, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_283a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_283c, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1013_2842, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_2845, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_2848, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_284b, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_284e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_2851, 3);  mov(eax, memd[ds, eax + 27]);         /* mov eax, [eax+0x1b] */
            ii(0x1013_2854, 5);  call(0x100d_4f58, -0x5_d901);         /* call 0x100d4f58 */
            ii(0x1013_2859, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_285c, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_285f, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_2861, 5);  call(0x1013_3930, 0x10ca);            /* call 0x10133930 */
            ii(0x1013_2866, 1);  cwde();                               /* cwde */
            ii(0x1013_2867, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_2869, 2);  if(jle(0x1013_28ca, 0x5f)) goto l_0x1013_28ca;/* jle 0x101328ca */
            ii(0x1013_286b, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x1013_286e, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x1013_2871, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_2874, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_2876, 5);  call(0x100d_6a92, -0x5_bde9);         /* call 0x100d6a92 */
            ii(0x1013_287b, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1013_287e, 3);  mov(eax, memd[ds, edx + 27]);         /* mov eax, [edx+0x1b] */
            ii(0x1013_2881, 5);  call(0x100d_4ef0, -0x5_d996);         /* call 0x100d4ef0 */
            ii(0x1013_2886, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1013_2889, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_288c, 2);  sub(eax, ecx);                        /* sub eax, ecx */
            ii(0x1013_288e, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1013_2890, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1013_2893, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1013_2895, 5);  call(0x1013_3930, 0x1096);            /* call 0x10133930 */
            ii(0x1013_289a, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_289d, 3);  imul(ebx, ecx);                       /* imul ebx, ecx */
            ii(0x1013_28a0, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_28a4, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_28a6, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_28a9, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1013_28ab, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1013_28ad, 3);  lea(edx, memd[ds, ebx + eax]);        /* lea edx, [ebx+eax] */
            ii(0x1013_28b0, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1013_28b4, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_28b6, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_28b9, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_28bb, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_28be, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_28c2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_28c5, 5);  call(0x1013_2705, -0x1c5);            /* call 0x10132705 */
        l_0x1013_28ca:
            ii(0x1013_28ca, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_28cc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_28cd, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_28ce, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_28cf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_28d0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_28d1, 1);  ret();                                /* ret */
        }
    }
}
