using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3649-c41e8745")]
        public void /* sys */ Method_1019_3649()
        {
            ii(0x1019_3649, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_364a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_364c, 3);  add(esp, -0x14 /* 0xec */);           /* add esp, 0xffffffec */
            ii(0x1019_364f, 1);  push(esi);                            /* push esi */
            ii(0x1019_3650, 1);  push(edi);                            /* push edi */
            ii(0x1019_3651, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_3652, 3);  mov(ax, ds);                          /* mov ax, ds */
            ii(0x1019_3655, 3);  mov(es, ax);                          /* mov es, ax */
            ii(0x1019_3658, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x1019_365b, 2);  shr(eax, 1);                          /* shr eax, 1 */
            ii(0x1019_365d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1019_3660, 3);  mov(eax, memd[ss, ebp + 12]);         /* mov eax, [ebp+0xc] */
            ii(0x1019_3663, 3);  sub(eax, memd[ss, ebp + 28]);         /* sub eax, [ebp+0x1c] */
            ii(0x1019_3666, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1019_3669, 5);  mov(eax, memd[ds, Definitions.video_bytes_per_line]);/* mov eax, [0x10209c98] */
            ii(0x1019_366e, 4);  cmp(memd[ss, ebp + 44], 0);           /* cmp dword [ebp+0x2c], 0x0 */
            ii(0x1019_3672, 2);  if(jz(0x1019_3676, 2)) goto l_0x1019_3676;/* jz 0x10193676 */
            ii(0x1019_3674, 2);  add(eax, eax);                        /* add eax, eax */
        l_0x1019_3676:
            ii(0x1019_3676, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_3679, 3);  sub(eax, memd[ss, ebp + 28]);         /* sub eax, [ebp+0x1c] */
            ii(0x1019_367c, 3);  sub(eax, memd[ss, ebp + 28]);         /* sub eax, [ebp+0x1c] */
            ii(0x1019_367f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1019_3682, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1019_3685, 3);  mul(memd[ss, ebp + 12]);              /* mul dword [ebp+0xc] */
            ii(0x1019_3688, 3);  add(eax, memd[ss, ebp + 20]);         /* add eax, [ebp+0x14] */
            ii(0x1019_368b, 3);  add(memd[ss, ebp + 8], eax);          /* add [ebp+0x8], eax */
            ii(0x1019_368e, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1019_3691, 3);  add(memd[ss, ebp + 36], eax);         /* add [ebp+0x24], eax */
            ii(0x1019_3694, 3);  mov(eax, memd[ss, ebp + 12]);         /* mov eax, [ebp+0xc] */
            ii(0x1019_3697, 2);  shr(eax, 1);                          /* shr eax, 1 */
            ii(0x1019_3699, 4);  cmp(memd[ss, ebp + 44], 0);           /* cmp dword [ebp+0x2c], 0x0 */
            ii(0x1019_369d, 2);  if(jz(0x1019_36a7, 8)) goto l_0x1019_36a7;/* jz 0x101936a7 */
            ii(0x1019_369f, 3);  cmp(memd[ss, ebp + 20], eax);         /* cmp [ebp+0x14], eax */
            ii(0x1019_36a2, 2);  if(jb(0x1019_36a7, 3)) goto l_0x1019_36a7;/* jb 0x101936a7 */
            ii(0x1019_36a4, 3);  sub(memd[ss, ebp + 36], eax);         /* sub [ebp+0x24], eax */
        l_0x1019_36a7:
            ii(0x1019_36a7, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1019_36aa, 3);  add(memd[ss, ebp + 40], eax);         /* add [ebp+0x28], eax */
            ii(0x1019_36ad, 7);  cmp(memd[ds, 0x1020_9c90], 0);        /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_36b4, 2);  if(jnz(0x1019_3718, 0x62)) goto l_0x1019_3718;/* jnz 0x10193718 */
            ii(0x1019_36b6, 6);  mov(edi, memd[ds, Definitions.video_win_start]);/* mov edi, [0x10209ca8] */
            ii(0x1019_36bc, 3);  mov(eax, memd[ss, ebp + 40]);         /* mov eax, [ebp+0x28] */
            ii(0x1019_36bf, 3);  mul(memd[ss, ebp - 16]);              /* mul dword [ebp-0x10] */
            ii(0x1019_36c2, 3);  add(eax, memd[ss, ebp + 36]);         /* add eax, [ebp+0x24] */
            ii(0x1019_36c5, 3);  add(eax, memd[ss, ebp + 36]);         /* add eax, [ebp+0x24] */
            ii(0x1019_36c8, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x1019_36ca, 7);  test(memd[ss, ebp + 44], 1);          /* test dword [ebp+0x2c], 0x1 */
            ii(0x1019_36d1, 2);  if(jz(0x1019_36d9, 6)) goto l_0x1019_36d9;/* jz 0x101936d9 */
            ii(0x1019_36d3, 6);  add(edi, memd[ds, Definitions.video_bytes_per_line]);/* add edi, [0x10209c98] */
        l_0x1019_36d9:
            ii(0x1019_36d9, 3);  mov(esi, memd[ss, ebp + 8]);          /* mov esi, [ebp+0x8] */
            ii(0x1019_36dc, 3);  mov(ebx, memd[ss, ebp + 32]);         /* mov ebx, [ebp+0x20] */
        l_0x1019_36df:
            ii(0x1019_36df, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1019_36e2, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_36e3, 6);  lea(ebx, memd[ds, 0x1020_9550]);      /* lea ebx, [0x10209550] */
            ii(0x1019_36e9, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1019_36eb:
            ii(0x1019_36eb, 2);  mov(al, memb[ds, esi]);               /* mov al, [esi] */
            ii(0x1019_36ed, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1019_36f0, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_36f4, 3);  mov(al, memb[ds, esi - 1]);           /* mov al, [esi-0x1] */
            ii(0x1019_36f7, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1019_36fa, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_36fe, 3);  rol(edx, 0x10);                       /* rol edx, 0x10 */
            ii(0x1019_3701, 2);  mov(memd[ds, edi], edx);              /* mov [edi], edx */
            ii(0x1019_3703, 3);  add(edi, 4);                          /* add edi, 0x4 */
            ii(0x1019_3706, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1019_3707, 2);  if(jnz(0x1019_36eb, -0x1e)) goto l_0x1019_36eb;/* jnz 0x101936eb */
            ii(0x1019_3709, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_370a, 3);  add(esi, memd[ss, ebp - 12]);         /* add esi, [ebp-0xc] */
            ii(0x1019_370d, 3);  add(edi, memd[ss, ebp - 20]);         /* add edi, [ebp-0x14] */
            ii(0x1019_3710, 1);  dec(ebx);                             /* dec ebx */
            ii(0x1019_3711, 2);  if(jnz(0x1019_36df, -0x34)) goto l_0x1019_36df;/* jnz 0x101936df */
            ii(0x1019_3713, 5);  jmp(0x1019_3856, 0x13e); goto l_0x1019_3856;/* jmp 0x10193856 */
        l_0x1019_3718:
            ii(0x1019_3718, 3);  mov(esi, memd[ss, ebp + 8]);          /* mov esi, [ebp+0x8] */
            ii(0x1019_371b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1019_371e, 3);  mul(memd[ss, ebp + 40]);              /* mul dword [ebp+0x28] */
            ii(0x1019_3721, 7);  test(memd[ss, ebp + 44], 1);          /* test dword [ebp+0x2c], 0x1 */
            ii(0x1019_3728, 2);  if(jz(0x1019_3730, 6)) goto l_0x1019_3730;/* jz 0x10193730 */
            ii(0x1019_372a, 6);  add(eax, memd[ds, Definitions.video_bytes_per_line]);/* add eax, [0x10209c98] */
        l_0x1019_3730:
            ii(0x1019_3730, 3);  add(eax, memd[ss, ebp + 36]);         /* add eax, [ebp+0x24] */
            ii(0x1019_3733, 3);  add(eax, memd[ss, ebp + 36]);         /* add eax, [ebp+0x24] */
            ii(0x1019_3736, 5);  mov(edx, 0);                          /* mov edx, 0x0 */
            ii(0x1019_373b, 6);  div(memd[ds, Definitions.video_win_granularity]);/* div dword [0x10209ca4] */
            ii(0x1019_3741, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1019_3744, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1019_3746, 6);  add(edi, memd[ds, Definitions.video_win_start]);/* add edi, [0x10209ca8] */
            ii(0x1019_374c, 2);  mov(bh, 0);                           /* mov bh, 0x0 */
            ii(0x1019_374e, 6);  mov(bl, memb[ds, 0x1020_9cb0]);       /* mov bl, [0x10209cb0] */
            ii(0x1019_3754, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1019_3757, 6);  call_abs(memd[ds, 0x1020_9c90]);      /* call dword [0x10209c90] */
        l_0x1019_375d:
            ii(0x1019_375d, 5);  mov(eax, memd[ds, Definitions.video_win_end]);/* mov eax, [0x10209cac] */
            ii(0x1019_3762, 2);  sub(eax, edi);                        /* sub eax, edi */
            ii(0x1019_3764, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x1019_3767, 5);  mov(edx, 0);                          /* mov edx, 0x0 */
            ii(0x1019_376c, 3);  div(memd[ss, ebp - 16]);              /* div dword [ebp-0x10] */
            ii(0x1019_376f, 3);  cmp(memd[ss, ebp + 32], eax);         /* cmp [ebp+0x20], eax */
            ii(0x1019_3772, 2);  if(jae(0x1019_3777, 3)) goto l_0x1019_3777;/* jae 0x10193777 */
            ii(0x1019_3774, 3);  mov(eax, memd[ss, ebp + 32]);         /* mov eax, [ebp+0x20] */
        l_0x1019_3777:
            ii(0x1019_3777, 2);  or(eax, eax);                         /* or eax, eax */
            ii(0x1019_3779, 2);  if(jz(0x1019_37b2, 0x37)) goto l_0x1019_37b2;/* jz 0x101937b2 */
            ii(0x1019_377b, 3);  sub(memd[ss, ebp + 32], eax);         /* sub [ebp+0x20], eax */
            ii(0x1019_377e, 6);  lea(ebx, memd[ds, 0x1020_9550]);      /* lea ebx, [0x10209550] */
        l_0x1019_3784:
            ii(0x1019_3784, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1019_3787, 1);  push(eax);                            /* push eax */
            ii(0x1019_3788, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1019_378a:
            ii(0x1019_378a, 2);  mov(al, memb[ds, esi]);               /* mov al, [esi] */
            ii(0x1019_378c, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1019_378f, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_3793, 3);  mov(al, memb[ds, esi - 1]);           /* mov al, [esi-0x1] */
            ii(0x1019_3796, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1019_3799, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_379d, 3);  rol(edx, 0x10);                       /* rol edx, 0x10 */
            ii(0x1019_37a0, 2);  mov(memd[ds, edi], edx);              /* mov [edi], edx */
            ii(0x1019_37a2, 3);  add(edi, 4);                          /* add edi, 0x4 */
            ii(0x1019_37a5, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1019_37a6, 2);  if(jnz(0x1019_378a, -0x1e)) goto l_0x1019_378a;/* jnz 0x1019378a */
            ii(0x1019_37a8, 1);  pop(eax);                             /* pop eax */
            ii(0x1019_37a9, 3);  add(esi, memd[ss, ebp - 12]);         /* add esi, [ebp-0xc] */
            ii(0x1019_37ac, 3);  add(edi, memd[ss, ebp - 20]);         /* add edi, [ebp-0x14] */
            ii(0x1019_37af, 1);  dec(eax);                             /* dec eax */
            ii(0x1019_37b0, 2);  if(jnz(0x1019_3784, -0x2e)) goto l_0x1019_3784;/* jnz 0x10193784 */
        l_0x1019_37b2:
            ii(0x1019_37b2, 3);  or(eax, memd[ss, ebp + 32]);          /* or eax, [ebp+0x20] */
            ii(0x1019_37b5, 6);  if(jz(0x1019_3856, 0x9b)) goto l_0x1019_3856;/* jz 0x10193856 */
            ii(0x1019_37bb, 6);  mov(ecx, memd[ds, Definitions.video_win_end]);/* mov ecx, [0x10209cac] */
            ii(0x1019_37c1, 2);  sub(ecx, edi);                        /* sub ecx, edi */
            ii(0x1019_37c3, 3);  sar(ecx, 2);                          /* sar ecx, 0x2 */
            ii(0x1019_37c6, 2);  if(jns(0x1019_37cd, 5)) goto l_0x1019_37cd;/* jns 0x101937cd */
            ii(0x1019_37c8, 5);  mov(ecx, 0);                          /* mov ecx, 0x0 */
        l_0x1019_37cd:
            ii(0x1019_37cd, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_37ce, 2);  or(ecx, ecx);                         /* or ecx, ecx */
            ii(0x1019_37d0, 2);  if(jz(0x1019_37f8, 0x26)) goto l_0x1019_37f8;/* jz 0x101937f8 */
            ii(0x1019_37d2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1019_37d4, 6);  lea(ebx, memd[ds, 0x1020_9550]);      /* lea ebx, [0x10209550] */
        l_0x1019_37da:
            ii(0x1019_37da, 2);  mov(al, memb[ds, esi]);               /* mov al, [esi] */
            ii(0x1019_37dc, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1019_37df, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_37e3, 3);  mov(al, memb[ds, esi - 1]);           /* mov al, [esi-0x1] */
            ii(0x1019_37e6, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1019_37e9, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_37ed, 3);  rol(edx, 0x10);                       /* rol edx, 0x10 */
            ii(0x1019_37f0, 2);  mov(memd[ds, edi], edx);              /* mov [edi], edx */
            ii(0x1019_37f2, 3);  add(edi, 4);                          /* add edi, 0x4 */
            ii(0x1019_37f5, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1019_37f6, 2);  if(jnz(0x1019_37da, -0x1e)) goto l_0x1019_37da;/* jnz 0x101937da */
        l_0x1019_37f8:
            ii(0x1019_37f8, 5);  mov(eax, memd[ds, Definitions.video_bank_count_in_win]);/* mov eax, [0x10209c9c] */
            ii(0x1019_37fd, 3);  add(memd[ss, ebp - 4], eax);          /* add [ebp-0x4], eax */
            ii(0x1019_3800, 6);  sub(edi, memd[ds, Definitions.video_win_len]);/* sub edi, [0x10209ca0] */
            ii(0x1019_3806, 2);  mov(bh, 0);                           /* mov bh, 0x0 */
            ii(0x1019_3808, 6);  mov(bl, memb[ds, 0x1020_9cb0]);       /* mov bl, [0x10209cb0] */
            ii(0x1019_380e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1019_3811, 6);  call_abs(memd[ds, 0x1020_9c90]);      /* call dword [0x10209c90] */
            ii(0x1019_3817, 1);  pop(eax);                             /* pop eax */
            ii(0x1019_3818, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1019_381b, 2);  sub(ecx, eax);                        /* sub ecx, eax */
            ii(0x1019_381d, 2);  or(ecx, ecx);                         /* or ecx, ecx */
            ii(0x1019_381f, 2);  if(jz(0x1019_3847, 0x26)) goto l_0x1019_3847;/* jz 0x10193847 */
            ii(0x1019_3821, 6);  lea(ebx, memd[ds, 0x1020_9550]);      /* lea ebx, [0x10209550] */
            ii(0x1019_3827, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1019_3829:
            ii(0x1019_3829, 2);  mov(al, memb[ds, esi]);               /* mov al, [esi] */
            ii(0x1019_382b, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1019_382e, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_3832, 3);  mov(al, memb[ds, esi - 1]);           /* mov al, [esi-0x1] */
            ii(0x1019_3835, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1019_3838, 4);  mov(dx, memw[ds, ebx + eax * 2]);     /* mov dx, [ebx+eax*2] */
            ii(0x1019_383c, 3);  rol(edx, 0x10);                       /* rol edx, 0x10 */
            ii(0x1019_383f, 2);  mov(memd[ds, edi], edx);              /* mov [edi], edx */
            ii(0x1019_3841, 3);  add(edi, 4);                          /* add edi, 0x4 */
            ii(0x1019_3844, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1019_3845, 2);  if(jnz(0x1019_3829, -0x1e)) goto l_0x1019_3829;/* jnz 0x10193829 */
        l_0x1019_3847:
            ii(0x1019_3847, 3);  add(esi, memd[ss, ebp - 12]);         /* add esi, [ebp-0xc] */
            ii(0x1019_384a, 3);  add(edi, memd[ss, ebp - 20]);         /* add edi, [ebp-0x14] */
            ii(0x1019_384d, 3);  dec(memd[ss, ebp + 32]);              /* dec dword [ebp+0x20] */
            ii(0x1019_3850, 6);  if(jnz(0x1019_375d, -0xf9)) goto l_0x1019_375d;/* jnz 0x1019375d */
        l_0x1019_3856:
            ii(0x1019_3856, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_3857, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_3858, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_3859, 1);  leave();                              /* leave */
            ii(0x1019_385a, 1);  ret();                                /* ret */
        }
    }
}
