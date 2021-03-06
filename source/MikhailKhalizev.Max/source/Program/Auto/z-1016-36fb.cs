using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_36fb-bf2496b0")]
        public void Method_1016_36fb()
        {
            ii(0x1016_36fb, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1016_3700, 5);  call(Definitions.sys_check_available_stack_size, 0x264d);/* call 0x10165d52 */
            ii(0x1016_3705, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_3706, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_3707, 1);  push(esi);                            /* push esi */
            ii(0x1016_3708, 1);  push(edi);                            /* push edi */
            ii(0x1016_3709, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_370a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_370c, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1016_3712, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_3715, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_3718, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_371b, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x1016_371e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3721, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3724, 5);  call(0x1013_c0fa, -0x2_762f);         /* call 0x1013c0fa */
            ii(0x1016_3729, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_372c, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1016_372f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3732, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3735, 5);  call(0x1013_c0fa, -0x2_7640);         /* call 0x1013c0fa */
            ii(0x1016_373a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_373d, 3);  mov(edx, memd[ds, edx + 10]);         /* mov edx, [edx+0xa] */
            ii(0x1016_3740, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3743, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3746, 5);  call(0x1013_c0fa, -0x2_7651);         /* call 0x1013c0fa */
            ii(0x1016_374b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_374e, 3);  mov(edx, memd[ds, edx + 12]);         /* mov edx, [edx+0xc] */
            ii(0x1016_3751, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3754, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3757, 5);  call(0x1013_c0fa, -0x2_7662);         /* call 0x1013c0fa */
            ii(0x1016_375c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_375f, 3);  mov(edx, memd[ds, edx + 14]);         /* mov edx, [edx+0xe] */
            ii(0x1016_3762, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3765, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3768, 5);  call(0x1013_c0fa, -0x2_7673);         /* call 0x1013c0fa */
            ii(0x1016_376d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3770, 3);  mov(edx, memd[ds, edx + 16]);         /* mov edx, [edx+0x10] */
            ii(0x1016_3773, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3776, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3779, 5);  call(0x1013_c0fa, -0x2_7684);         /* call 0x1013c0fa */
            ii(0x1016_377e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3781, 3);  mov(edx, memd[ds, edx + 18]);         /* mov edx, [edx+0x12] */
            ii(0x1016_3784, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_3787, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_378a, 5);  call(0x1013_c0fa, -0x2_7695);         /* call 0x1013c0fa */
            ii(0x1016_378f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3792, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_3794, 3);  mov(dl, memb[ds, eax + 22]);          /* mov dl, [eax+0x16] */
            ii(0x1016_3797, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_379a, 5);  call(0x100c_b818, -0x9_7f87);         /* call 0x100cb818 */
            ii(0x1016_379f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_37a2, 3);  mov(edx, memd[ds, edx + 21]);         /* mov edx, [edx+0x15] */
            ii(0x1016_37a5, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_37a8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_37ab, 5);  call(0x1013_c0fa, -0x2_76b6);         /* call 0x1013c0fa */
            ii(0x1016_37b0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_37b3, 3);  mov(edx, memd[ds, edx + 23]);         /* mov edx, [edx+0x17] */
            ii(0x1016_37b6, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_37b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_37bc, 5);  call(0x1013_c0fa, -0x2_76c7);         /* call 0x1013c0fa */
            ii(0x1016_37c1, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_37c4, 3);  mov(edx, memd[ds, edx + 25]);         /* mov edx, [edx+0x19] */
            ii(0x1016_37c7, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_37ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_37cd, 5);  call(0x1013_c0fa, -0x2_76d8);         /* call 0x1013c0fa */
            ii(0x1016_37d2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_37d5, 3);  mov(edx, memd[ds, edx + 27]);         /* mov edx, [edx+0x1b] */
            ii(0x1016_37d8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_37db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_37de, 5);  call(0x1013_c0fa, -0x2_76e9);         /* call 0x1013c0fa */
            ii(0x1016_37e3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_37e6, 3);  mov(edx, memd[ds, edx + 29]);         /* mov edx, [edx+0x1d] */
            ii(0x1016_37e9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_37ec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_37ef, 5);  call(0x1013_c0fa, -0x2_76fa);         /* call 0x1013c0fa */
            ii(0x1016_37f4, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_37f7, 3);  mov(edx, memd[ds, edx + 31]);         /* mov edx, [edx+0x1f] */
            ii(0x1016_37fa, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1016_37fd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3800, 5);  call(0x1013_c0fa, -0x2_770b);         /* call 0x1013c0fa */
            ii(0x1016_3805, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3808, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_380a, 3);  mov(dl, memb[ds, eax + 35]);          /* mov dl, [eax+0x23] */
            ii(0x1016_380d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3810, 5);  call(0x100c_b818, -0x9_7ffd);         /* call 0x100cb818 */
            ii(0x1016_3815, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_3817, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_3818, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_3819, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_381a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_381b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_381c, 1);  ret();                                /* ret */
        }
    }
}
