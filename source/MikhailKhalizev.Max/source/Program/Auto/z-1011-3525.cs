using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3525-c6248e85")]
        public void Method_1011_3525()
        {
            ii(0x1011_3525, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1011_352a, 5);  call(Definitions.sys_check_available_stack_size, 0x5_2823);/* call 0x10165d52 */
            ii(0x1011_352f, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_3530, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_3531, 1);  push(edx);                            /* push edx */
            ii(0x1011_3532, 1);  push(esi);                            /* push esi */
            ii(0x1011_3533, 1);  push(edi);                            /* push edi */
            ii(0x1011_3534, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_3535, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_3537, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1011_353d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_3540, 7);  mov(memd[ss, ebp - 8], 8);            /* mov dword [ebp-0x8], 0x8 */
            ii(0x1011_3547, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_354a, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1011_354c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_354f, 6);  mov(eax, memd[ds, eax + 1445]);       /* mov eax, [eax+0x5a5] */
            ii(0x1011_3555, 5);  call(0x100d_7f6c, -0x3_b5ee);         /* call 0x100d7f6c */
            ii(0x1011_355a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_355d, 3);  mov(al, memb[ds, eax + 16]);          /* mov al, [eax+0x10] */
            ii(0x1011_3560, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_3565, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_3567, 2);  if(jnz(0x1011_35b0, 0x47)) goto l_0x1011_35b0;/* jnz 0x101135b0 */
            ii(0x1011_3569, 5);  call(0x1011_5318, 0x1daa);            /* call 0x10115318 */
            ii(0x1011_356e, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_3573, 1);  push(eax);                            /* push eax */
            ii(0x1011_3574, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1011_3579, 5);  mov(ebx, 0xa2);                       /* mov ebx, 0xa2 */
            ii(0x1011_357e, 5);  mov(edx, 0x101b_9db4);                /* mov edx, 0x101b9db4 */
            ii(0x1011_3583, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_3586, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_3588, 5);  call(0x1010_8a05, -0xab88);           /* call 0x10108a05 */
        l_0x1011_358d:
            ii(0x1011_358d, 3);  dec(memd[ss, ebp - 8]);               /* dec dword [ebp-0x8] */
            ii(0x1011_3590, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_3595, 2);  if(jz(0x1011_35ab, 0x14)) goto l_0x1011_35ab;/* jz 0x101135ab */
            ii(0x1011_3597, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_3599, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_359c, 2);  add(al, 2);                           /* add al, 0x2 */
            ii(0x1011_359e, 3);  movsx(edx, al);                       /* movsx edx, al */
            ii(0x1011_35a1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_35a4, 5);  call(0x1011_285d, -0xd4c);            /* call 0x1011285d */
            ii(0x1011_35a9, 2);  jmp(0x1011_358d, -0x1e); goto l_0x1011_358d;/* jmp 0x1011358d */
        l_0x1011_35ab:
            ii(0x1011_35ab, 5);  jmp(0x1011_36b7, 0x107); goto l_0x1011_36b7;/* jmp 0x101136b7 */
        l_0x1011_35b0:
            ii(0x1011_35b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_35b3, 3);  mov(al, memb[ds, eax + 9]);           /* mov al, [eax+0x9] */
            ii(0x1011_35b6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_35bb, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1011_35be, 2);  if(jz(0x1011_35d0, 0x10)) goto l_0x1011_35d0;/* jz 0x101135d0 */
            ii(0x1011_35c0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_35c3, 3);  mov(al, memb[ds, eax + 9]);           /* mov al, [eax+0x9] */
            ii(0x1011_35c6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_35cb, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1011_35ce, 2);  if(jnz(0x1011_35e7, 0x17)) goto l_0x1011_35e7;/* jnz 0x101135e7 */
        l_0x1011_35d0:
            ii(0x1011_35d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_35d3, 7);  mov(memd[ds, eax + 4], 2);            /* mov dword [eax+0x4], 0x2 */
            ii(0x1011_35da, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_35dd, 5);  call(0x1011_4396, 0xdb4);             /* call 0x10114396 */
            ii(0x1011_35e2, 5);  jmp(0x1011_36b7, 0xd0); goto l_0x1011_36b7;/* jmp 0x101136b7 */
        l_0x1011_35e7:
            ii(0x1011_35e7, 4);  dec(memw[ss, ebp - 8]);               /* dec word [ebp-0x8] */
            ii(0x1011_35eb, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_35f0, 6);  if(jz(0x1011_36b7, 0xc1)) goto l_0x1011_36b7;/* jz 0x101136b7 */
            ii(0x1011_35f6, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_35f9, 2);  add(al, 2);                           /* add al, 0x2 */
            ii(0x1011_35fb, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1011_35fe, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_3600, 1);  push(eax);                            /* push eax */
            ii(0x1011_3601, 5);  mov(ecx, 0x14);                       /* mov ecx, 0x14 */
            ii(0x1011_3606, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_360a, 3);  imul(eax, eax, 0x1e);                 /* imul eax, eax, 0x1e */
            ii(0x1011_360d, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1011_3610, 6);  add(ebx, 0x238);                      /* add ebx, 0x238 */
            ii(0x1011_3616, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1011_3618, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_361c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_361f, 5);  call(0x1011_2c46, -0x9de);            /* call 0x10112c46 */
            ii(0x1011_3624, 5);  cmp(memw[ss, ebp - 8], 0);            /* cmp word [ebp-0x8], 0x0 */
            ii(0x1011_3629, 2);  if(jz(0x1011_3681, 0x56)) goto l_0x1011_3681;/* jz 0x10113681 */
            ii(0x1011_362b, 2);  push(2);                              /* push 0x2 */
            ii(0x1011_362d, 4);  movsx(eax, memb[ss, ebp - 12]);       /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3631, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1011_3634, 6);  mov(eax, memd[ds, eax + 0x101b_9ea4]);/* mov eax, [eax+0x101b9ea4] */
            ii(0x1011_363a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_363d, 1);  push(eax);                            /* push eax */
            ii(0x1011_363e, 4);  movsx(eax, memb[ss, ebp - 12]);       /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3642, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1011_3645, 6);  mov(eax, memd[ds, eax + 0x101b_9ea6]);/* mov eax, [eax+0x101b9ea6] */
            ii(0x1011_364b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_364e, 1);  push(eax);                            /* push eax */
            ii(0x1011_364f, 4);  movsx(ecx, memb[ss, ebp - 12]);       /* movsx ecx, byte [ebp-0xc] */
            ii(0x1011_3653, 3);  imul(ecx, ecx, 0x18);                 /* imul ecx, ecx, 0x18 */
            ii(0x1011_3656, 6);  mov(ecx, memd[ds, ecx + 0x101b_9ea4]);/* mov ecx, [ecx+0x101b9ea4] */
            ii(0x1011_365c, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1011_365f, 4);  movsx(eax, memb[ss, ebp - 12]);       /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3663, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1011_3666, 6);  mov(ebx, memd[ds, eax + 0x101b_9ea2]);/* mov ebx, [eax+0x101b9ea2] */
            ii(0x1011_366c, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_366f, 5);  mov(edx, 0x280);                      /* mov edx, 0x280 */
            ii(0x1011_3674, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_3677, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_3679, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1011_367c, 5);  call(/* sys */ 0x1016_a5a0, 0x5_6f1f);/* call 0x1016a5a0 */
        l_0x1011_3681:
            ii(0x1011_3681, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3685, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1011_3687, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_368a, 6);  mov(eax, memd[ds, eax + 806]);        /* mov eax, [eax+0x326] */
            ii(0x1011_3690, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_3693, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_3695, 2);  if(jz(0x1011_369d, 6)) goto l_0x1011_369d;/* jz 0x1011369d */
            ii(0x1011_3697, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1011_369b, 2);  jmp(0x1011_36a1, 4); goto l_0x1011_36a1;/* jmp 0x101136a1 */
        l_0x1011_369d:
            ii(0x1011_369d, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1011_36a1:
            ii(0x1011_36a1, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_36a3, 3);  mov(bl, memb[ss, ebp - 16]);          /* mov bl, [ebp-0x10] */
            ii(0x1011_36a6, 4);  movsx(edx, memb[ss, ebp - 12]);       /* movsx edx, byte [ebp-0xc] */
            ii(0x1011_36aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_36ad, 5);  call(0x1011_285d, -0xe55);            /* call 0x1011285d */
            ii(0x1011_36b2, 5);  jmp(0x1011_35e7, -0xd0); goto l_0x1011_35e7;/* jmp 0x101135e7 */
        l_0x1011_36b7:
            ii(0x1011_36b7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_36b9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_36ba, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_36bb, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_36bc, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_36bd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_36be, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_36bf, 1);  ret();                                /* ret */
        }
    }
}
