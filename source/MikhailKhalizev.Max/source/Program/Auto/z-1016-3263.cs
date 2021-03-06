using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3263-9b722c50")]
        public void Method_1016_3263()
        {
            ii(0x1016_3263, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1016_3268, 5);  call(Definitions.sys_check_available_stack_size, 0x2ae5);/* call 0x10165d52 */
            ii(0x1016_326d, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_326e, 1);  push(esi);                            /* push esi */
            ii(0x1016_326f, 1);  push(edi);                            /* push edi */
            ii(0x1016_3270, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_3271, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_3273, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1016_3279, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_327c, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1016_327f, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1016_3282, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_3285, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1016_3288, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1016_328a, 1);  cwde();                               /* cwde */
            ii(0x1016_328b, 1);  push(eax);                            /* push eax */
            ii(0x1016_328c, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1016_3291, 1);  push(eax);                            /* push eax */
            ii(0x1016_3292, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1016_3295, 1);  push(eax);                            /* push eax */
            ii(0x1016_3296, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_3299, 1);  push(eax);                            /* push eax */
            ii(0x1016_329a, 3);  lea(ecx, memd[ss, ebp - 16]);         /* lea ecx, [ebp-0x10] */
            ii(0x1016_329d, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1016_32a2, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1016_32a6, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1016_32aa, 5);  call(0x1014_2d0b, -0x2_05a4);         /* call 0x10142d0b */
            ii(0x1016_32af, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1016_32b2, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_32b5, 3);  mov(memb[ds, edx + 74], al);          /* mov [edx+0x4a], al */
            ii(0x1016_32b8, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1016_32bb, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_32be, 3);  mov(memb[ds, edx + 75], al);          /* mov [edx+0x4b], al */
            ii(0x1016_32c1, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1016_32c4, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_32c7, 3);  mov(memb[ds, edx + 76], al);          /* mov [edx+0x4c], al */
            ii(0x1016_32ca, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1016_32cf, 5);  call(0x1007_1ec5, -0xf_140f);         /* call 0x10071ec5 */
            ii(0x1016_32d4, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1016_32d7, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1016_32db, 5);  call(Definitions.my_min, -0xd_9b5c);  /* call 0x10089784 */
            ii(0x1016_32e0, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_32e3, 3);  mov(memb[ds, edx + 72], al);          /* mov [edx+0x48], al */
            ii(0x1016_32e6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_32e9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_32eb, 3);  mov(al, memb[ds, edx + 72]);          /* mov al, [edx+0x48] */
            ii(0x1016_32ee, 5);  mov(edx, 0x10);                       /* mov edx, 0x10 */
            ii(0x1016_32f3, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1016_32f5, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1016_32f8, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1016_32fc, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1016_3300, 5);  call(Definitions.my_min, -0xd_9b81);  /* call 0x10089784 */
            ii(0x1016_3305, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_3308, 3);  mov(memb[ds, edx + 71], al);          /* mov [edx+0x47], al */
            ii(0x1016_330b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_330e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_3310, 3);  mov(al, memb[ds, edx + 71]);          /* mov al, [edx+0x47] */
            ii(0x1016_3313, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
            ii(0x1016_3316, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1016_331a, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1016_331d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_331f, 3);  mov(al, memb[ds, ebx + 72]);          /* mov al, [ebx+0x48] */
            ii(0x1016_3322, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1016_3326, 2);  sub(ebx, eax);                        /* sub ebx, eax */
            ii(0x1016_3328, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1016_332a, 5);  call(Definitions.my_min, -0xd_9bab);  /* call 0x10089784 */
            ii(0x1016_332f, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1016_3333, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1016_3336, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_3339, 3);  add(memb[ds, edx + 72], al);          /* add [edx+0x48], al */
            ii(0x1016_333c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1016_333f, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
            ii(0x1016_3342, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1016_3346, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1016_334a, 5);  call(Definitions.my_min, -0xd_9bcb);  /* call 0x10089784 */
            ii(0x1016_334f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_3352, 3);  mov(memb[ds, edx + 73], al);          /* mov [edx+0x49], al */
            ii(0x1016_3355, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_3358, 3);  mov(al, memb[ds, eax + 71]);          /* mov al, [eax+0x47] */
            ii(0x1016_335b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_335e, 3);  add(al, memb[ds, edx + 73]);          /* add al, [edx+0x49] */
            ii(0x1016_3361, 2);  mov(ah, al);                          /* mov ah, al */
            ii(0x1016_3363, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_3366, 3);  mov(al, memb[ds, edx + 72]);          /* mov al, [edx+0x48] */
            ii(0x1016_3369, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1016_336c, 2);  add(ah, al);                          /* add ah, al */
            ii(0x1016_336e, 3);  mov(memb[ds, edx + 70], ah);          /* mov [edx+0x46], ah */
            ii(0x1016_3371, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_3373, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_3374, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_3375, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_3376, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_3377, 1);  ret();                                /* ret */
        }
    }
}
