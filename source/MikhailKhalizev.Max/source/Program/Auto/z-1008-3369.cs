using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_3369-8c926a3e")]
        public void Method_1008_3369()
        {
            ii(0x1008_3369, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_336e, 5);  call(Definitions.sys_check_available_stack_size, 0xe_29df);/* call 0x10165d52 */
            ii(0x1008_3373, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_3374, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_3375, 1);  push(edx);                            /* push edx */
            ii(0x1008_3376, 1);  push(esi);                            /* push esi */
            ii(0x1008_3377, 1);  push(edi);                            /* push edi */
            ii(0x1008_3378, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_3379, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_337b, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_3381, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_3384, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3387, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_338a, 5);  call(0x1007_6b90, -0xc7ff);           /* call 0x10076b90 */
            ii(0x1008_338f, 1);  cwde();                               /* cwde */
            ii(0x1008_3390, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_3392, 6);  if(jz(0x1008_346d, 0xd5)) goto l_0x1008_346d;/* jz 0x1008346d */
            ii(0x1008_3398, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_339a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_339d, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_33a0, 5);  call(0x1008_9c68, 0x68c3);            /* call 0x10089c68 */
            ii(0x1008_33a5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_33a7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_33aa, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_33ad, 5);  call(0x1008_9e38, 0x6a86);            /* call 0x10089e38 */
            ii(0x1008_33b2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_33b5, 4);  cmp(memb[ds, eax + 70], 0);           /* cmp byte [eax+0x46], 0x0 */
            ii(0x1008_33b9, 2);  if(jz(0x1008_33cc, 0x11)) goto l_0x1008_33cc;/* jz 0x100833cc */
            ii(0x1008_33bb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_33bd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_33c0, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_33c3, 5);  call(0x1013_ad71, 0xb_79a9);          /* call 0x1013ad71 */
            ii(0x1008_33c8, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_33ca, 2);  if(jnz(0x1008_33ce, 2)) goto l_0x1008_33ce;/* jnz 0x100833ce */
        l_0x1008_33cc:
            ii(0x1008_33cc, 2);  jmp(0x1008_33f8, 0x2a); goto l_0x1008_33f8;/* jmp 0x100833f8 */
        l_0x1008_33ce:
            ii(0x1008_33ce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_33d1, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_33d4, 5);  call(0x1007_6574, -0xce65);           /* call 0x10076574 */
            ii(0x1008_33d9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_33db, 3);  mov(dl, memb[ds, eax + 78]);          /* mov dl, [eax+0x4e] */
            ii(0x1008_33de, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_33e1, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_33e4, 5);  call(0x1007_6574, -0xce75);           /* call 0x10076574 */
            ii(0x1008_33e9, 5);  call(0x1007_623c, -0xd1b2);           /* call 0x1007623c */
            ii(0x1008_33ee, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1008_33f1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_33f4, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_33f6, 2);  if(jz(0x1008_33fa, 2)) goto l_0x1008_33fa;/* jz 0x100833fa */
        l_0x1008_33f8:
            ii(0x1008_33f8, 2);  jmp(0x1008_346d, 0x73); goto l_0x1008_346d;/* jmp 0x1008346d */
        l_0x1008_33fa:
            ii(0x1008_33fa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_33fd, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_3400, 5);  call(0x1008_9dd8, 0x69d3);            /* call 0x10089dd8 */
            ii(0x1008_3405, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_3408, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_340b, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_340e, 5);  call(0x1008_9dd8, 0x69c5);            /* call 0x10089dd8 */
            ii(0x1008_3413, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_3416, 3);  add(ebx, 0x20);                       /* add ebx, 0x20 */
            ii(0x1008_3419, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_341b, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_341d, 5);  call(0x1008_9ca0, 0x687e);            /* call 0x10089ca0 */
            ii(0x1008_3422, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3425, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_3428, 5);  call(0x1008_9dd8, 0x69ab);            /* call 0x10089dd8 */
            ii(0x1008_342d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_342f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3432, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_3435, 5);  call(0x1008_9cd8, 0x689e);            /* call 0x10089cd8 */
            ii(0x1008_343a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_343c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_343f, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_3442, 5);  call(0x1008_9c68, 0x6821);            /* call 0x10089c68 */
            ii(0x1008_3447, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_3449, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_344c, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_344f, 5);  call(0x1008_9e38, 0x69e4);            /* call 0x10089e38 */
            ii(0x1008_3454, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3457, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_345a, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_345d, 5);  call(0x1008_b4ec, 0x808a);            /* call 0x1008b4ec */
            ii(0x1008_3462, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_3464, 2);  if(jz(0x1008_346d, 7)) goto l_0x1008_346d;/* jz 0x1008346d */
            ii(0x1008_3466, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3469, 4);  mov(memb[ds, eax + 70], 0);           /* mov byte [eax+0x46], 0x0 */
        l_0x1008_346d:
            ii(0x1008_346d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_346f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_3470, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_3471, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_3472, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_3473, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_3474, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_3475, 1);  ret();                                /* ret */
        }
    }
}
