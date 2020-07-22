using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3297-588c9ed9")]
        public void Method_1015_3297()
        {
            ii(0x1015_3297, 5);  push(0x7c);                           /* push 0x7c */
            ii(0x1015_329c, 5);  call(Definitions.sys_check_available_stack_size, 0x1_2ab1);/* call 0x10165d52 */
            ii(0x1015_32a1, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_32a2, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_32a3, 1);  push(esi);                            /* push esi */
            ii(0x1015_32a4, 1);  push(edi);                            /* push edi */
            ii(0x1015_32a5, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_32a6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_32a8, 6);  sub(esp, 0x64);                       /* sub esp, 0x64 */
            ii(0x1015_32ae, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_32b1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_32b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_32b7, 4);  mov(ax, memw[ds, eax + 105]);         /* mov ax, [eax+0x69] */
            ii(0x1015_32bb, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_32be, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_32c1, 3);  mov(al, memb[ds, eax + 57]);          /* mov al, [eax+0x39] */
            ii(0x1015_32c4, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1015_32c7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_32ca, 3);  mov(ebx, memd[ds, eax + 22]);         /* mov ebx, [eax+0x16] */
            ii(0x1015_32cd, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_32d0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_32d3, 3);  mov(edx, memd[ds, eax + 20]);         /* mov edx, [eax+0x14] */
            ii(0x1015_32d6, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_32d9, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_32dc, 5);  call(0x1007_6aac, -0xd_c835);         /* call 0x10076aac */
            ii(0x1015_32e1, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_32e4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_32e7, 6);  mov(ebx, memd[ds, eax + 211]);        /* mov ebx, [eax+0xd3] */
            ii(0x1015_32ed, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_32f0, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_32f3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1015_32f6, 5);  call(0x1007_5e64, -0xd_d497);         /* call 0x10075e64 */
            ii(0x1015_32fb, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_32fe, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3300, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_3302, 5);  call(0x1015_2f21, -0x3e6);            /* call 0x10152f21 */
            ii(0x1015_3307, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_330a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_330d, 6);  mov(ebx, memd[ds, eax + 211]);        /* mov ebx, [eax+0xd3] */
            ii(0x1015_3313, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_3316, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3319, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_331c, 5);  call(0x1007_5e64, -0xd_d4bd);         /* call 0x10075e64 */
            ii(0x1015_3321, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3323, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3326, 5);  call(0x1015_3079, -0x2b2);            /* call 0x10153079 */
            ii(0x1015_332b, 5);  cmp(memw[ss, ebp - 16], 0);           /* cmp word [ebp-0x10], 0x0 */
            ii(0x1015_3330, 6);  if(jz(0x1015_35c2, 0x28c)) goto l_0x1015_35c2;/* jz 0x101535c2 */
            ii(0x1015_3336, 6);  test(memw[ss, ebp - 16], 1);          /* test word [ebp-0x10], 0x1 */
            ii(0x1015_333c, 2);  if(jz(0x1015_337e, 0x40)) goto l_0x1015_337e;/* jz 0x1015337e */
            ii(0x1015_333e, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3341, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3343, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_3346, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3349, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_334c, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1015_334f, 5);  call(0x1007_5e64, -0xd_d4f0);         /* call 0x10075e64 */
            ii(0x1015_3354, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3356, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3359, 5);  call(0x1015_2f21, -0x43d);            /* call 0x10152f21 */
            ii(0x1015_335e, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3361, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3363, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_3366, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3369, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_336c, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1015_336f, 5);  call(0x1007_5e64, -0xd_d510);         /* call 0x10075e64 */
            ii(0x1015_3374, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3376, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3379, 5);  call(0x1015_3079, -0x305);            /* call 0x10153079 */
        l_0x1015_337e:
            ii(0x1015_337e, 6);  test(memw[ss, ebp - 16], 2);          /* test word [ebp-0x10], 0x2 */
            ii(0x1015_3384, 2);  if(jz(0x1015_33d2, 0x4c)) goto l_0x1015_33d2;/* jz 0x101533d2 */
            ii(0x1015_3386, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3389, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_338b, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_338e, 5);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1015_3393, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3396, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3399, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1015_339c, 5);  call(0x1007_5e64, -0xd_d53d);         /* call 0x10075e64 */
            ii(0x1015_33a1, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_33a4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_33a6, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_33a8, 5);  call(0x1015_2f21, -0x48c);            /* call 0x10152f21 */
            ii(0x1015_33ad, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_33b0, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_33b2, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_33b5, 5);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1015_33ba, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_33bd, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_33c0, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1015_33c3, 5);  call(0x1007_5e64, -0xd_d564);         /* call 0x10075e64 */
            ii(0x1015_33c8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_33ca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_33cd, 5);  call(0x1015_3079, -0x359);            /* call 0x10153079 */
        l_0x1015_33d2:
            ii(0x1015_33d2, 6);  test(memw[ss, ebp - 16], 0x10);       /* test word [ebp-0x10], 0x10 */
            ii(0x1015_33d8, 2);  if(jz(0x1015_3426, 0x4c)) goto l_0x1015_3426;/* jz 0x10153426 */
            ii(0x1015_33da, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_33dd, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_33df, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_33e2, 5);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1015_33e7, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_33ea, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_33ed, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1015_33f0, 5);  call(0x1007_5e64, -0xd_d591);         /* call 0x10075e64 */
            ii(0x1015_33f5, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_33f8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_33fa, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_33fc, 5);  call(0x1015_2f21, -0x4e0);            /* call 0x10152f21 */
            ii(0x1015_3401, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3404, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3406, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_3409, 5);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1015_340e, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3411, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3414, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1015_3417, 5);  call(0x1007_5e64, -0xd_d5b8);         /* call 0x10075e64 */
            ii(0x1015_341c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_341e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3421, 5);  call(0x1015_3079, -0x3ad);            /* call 0x10153079 */
        l_0x1015_3426:
            ii(0x1015_3426, 6);  test(memw[ss, ebp - 16], 0x20);       /* test word [ebp-0x10], 0x20 */
            ii(0x1015_342c, 2);  if(jz(0x1015_347a, 0x4c)) goto l_0x1015_347a;/* jz 0x1015347a */
            ii(0x1015_342e, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3431, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3433, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_3436, 5);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1015_343b, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_343e, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3441, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1015_3444, 5);  call(0x1007_5e64, -0xd_d5e5);         /* call 0x10075e64 */
            ii(0x1015_3449, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_344c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_344e, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_3450, 5);  call(0x1015_2f21, -0x534);            /* call 0x10152f21 */
            ii(0x1015_3455, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3458, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_345a, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_345d, 5);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1015_3462, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3465, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3468, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1015_346b, 5);  call(0x1007_5e64, -0xd_d60c);         /* call 0x10075e64 */
            ii(0x1015_3470, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3472, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3475, 5);  call(0x1015_3079, -0x401);            /* call 0x10153079 */
        l_0x1015_347a:
            ii(0x1015_347a, 6);  test(memw[ss, ebp - 16], 4);          /* test word [ebp-0x10], 0x4 */
            ii(0x1015_3480, 2);  if(jz(0x1015_34c6, 0x44)) goto l_0x1015_34c6;/* jz 0x101534c6 */
            ii(0x1015_3482, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3485, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3487, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_348a, 1);  inc(eax);                             /* inc eax */
            ii(0x1015_348b, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_348e, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3491, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1015_3494, 5);  call(0x1007_5e64, -0xd_d635);         /* call 0x10075e64 */
            ii(0x1015_3499, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_349c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_349e, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_34a0, 5);  call(0x1015_2f21, -0x584);            /* call 0x10152f21 */
            ii(0x1015_34a5, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_34a8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_34aa, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_34ad, 1);  inc(eax);                             /* inc eax */
            ii(0x1015_34ae, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_34b1, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_34b4, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1015_34b7, 5);  call(0x1007_5e64, -0xd_d658);         /* call 0x10075e64 */
            ii(0x1015_34bc, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_34be, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_34c1, 5);  call(0x1015_3079, -0x44d);            /* call 0x10153079 */
        l_0x1015_34c6:
            ii(0x1015_34c6, 6);  test(memw[ss, ebp - 16], 8);          /* test word [ebp-0x10], 0x8 */
            ii(0x1015_34cc, 2);  if(jz(0x1015_351a, 0x4c)) goto l_0x1015_351a;/* jz 0x1015351a */
            ii(0x1015_34ce, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_34d1, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_34d3, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_34d6, 5);  add(eax, 5);                          /* add eax, 0x5 */
            ii(0x1015_34db, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_34de, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_34e1, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1015_34e4, 5);  call(0x1007_5e64, -0xd_d685);         /* call 0x10075e64 */
            ii(0x1015_34e9, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_34ec, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_34ee, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_34f0, 5);  call(0x1015_2f21, -0x5d4);            /* call 0x10152f21 */
            ii(0x1015_34f5, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_34f8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_34fa, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_34fd, 5);  add(eax, 5);                          /* add eax, 0x5 */
            ii(0x1015_3502, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3505, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3508, 3);  lea(eax, memd[ss, ebp - 76]);         /* lea eax, [ebp-0x4c] */
            ii(0x1015_350b, 5);  call(0x1007_5e64, -0xd_d6ac);         /* call 0x10075e64 */
            ii(0x1015_3510, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3512, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3515, 5);  call(0x1015_3079, -0x4a1);            /* call 0x10153079 */
        l_0x1015_351a:
            ii(0x1015_351a, 6);  test(memw[ss, ebp - 16], 0x40);       /* test word [ebp-0x10], 0x40 */
            ii(0x1015_3520, 2);  if(jz(0x1015_356e, 0x4c)) goto l_0x1015_356e;/* jz 0x1015356e */
            ii(0x1015_3522, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3525, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_3527, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_352a, 5);  add(eax, 3);                          /* add eax, 0x3 */
            ii(0x1015_352f, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3532, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3535, 3);  lea(eax, memd[ss, ebp - 80]);         /* lea eax, [ebp-0x50] */
            ii(0x1015_3538, 5);  call(0x1007_5e64, -0xd_d6d9);         /* call 0x10075e64 */
            ii(0x1015_353d, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_3540, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3542, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_3544, 5);  call(0x1015_2f21, -0x628);            /* call 0x10152f21 */
            ii(0x1015_3549, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_354c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_354e, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_3551, 5);  add(eax, 3);                          /* add eax, 0x3 */
            ii(0x1015_3556, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3559, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_355c, 3);  lea(eax, memd[ss, ebp - 84]);         /* lea eax, [ebp-0x54] */
            ii(0x1015_355f, 5);  call(0x1007_5e64, -0xd_d700);         /* call 0x10075e64 */
            ii(0x1015_3564, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3566, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3569, 5);  call(0x1015_3079, -0x4f5);            /* call 0x10153079 */
        l_0x1015_356e:
            ii(0x1015_356e, 6);  test(memw[ss, ebp - 16], 0x80);       /* test word [ebp-0x10], 0x80 */
            ii(0x1015_3574, 2);  if(jz(0x1015_35c2, 0x4c)) goto l_0x1015_35c2;/* jz 0x101535c2 */
            ii(0x1015_3576, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_3579, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_357b, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_357e, 5);  add(eax, 7);                          /* add eax, 0x7 */
            ii(0x1015_3583, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_3586, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3589, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1015_358c, 5);  call(0x1007_5e64, -0xd_d72d);         /* call 0x10075e64 */
            ii(0x1015_3591, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_3594, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3596, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_3598, 5);  call(0x1015_2f21, -0x67c);            /* call 0x10152f21 */
            ii(0x1015_359d, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_35a0, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_35a2, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_35a5, 5);  add(eax, 7);                          /* add eax, 0x7 */
            ii(0x1015_35aa, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1015_35ad, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_35b0, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x1015_35b3, 5);  call(0x1007_5e64, -0xd_d754);         /* call 0x10075e64 */
            ii(0x1015_35b8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_35ba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_35bd, 5);  call(0x1015_3079, -0x549);            /* call 0x10153079 */
        l_0x1015_35c2:
            ii(0x1015_35c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_35c5, 4);  test(memb[ds, eax + 21], 0xa);        /* test byte [eax+0x15], 0xa */
            ii(0x1015_35c9, 2);  if(jz(0x1015_362d, 0x62)) goto l_0x1015_362d;/* jz 0x1015362d */
            ii(0x1015_35cb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_35ce, 5);  movsx(ax, memb[ds, eax + 47]);        /* movsx ax, byte [eax+0x2f] */
            ii(0x1015_35d3, 4);  add(memw[ss, ebp - 28], ax);          /* add [ebp-0x1c], ax */
            ii(0x1015_35d7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_35da, 5);  movsx(ax, memb[ds, eax + 48]);        /* movsx ax, byte [eax+0x30] */
            ii(0x1015_35df, 4);  add(memw[ss, ebp - 26], ax);          /* add [ebp-0x1a], ax */
            ii(0x1015_35e3, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_35e6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_35e9, 6);  mov(ebx, memd[ds, eax + 213]);        /* mov ebx, [eax+0xd5] */
            ii(0x1015_35ef, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_35f2, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_35f5, 3);  lea(eax, memd[ss, ebp - 96]);         /* lea eax, [ebp-0x60] */
            ii(0x1015_35f8, 5);  call(0x1007_5e64, -0xd_d799);         /* call 0x10075e64 */
            ii(0x1015_35fd, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_35ff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3602, 5);  call(0x1015_2f21, -0x6e6);            /* call 0x10152f21 */
            ii(0x1015_3607, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1015_360a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_360d, 6);  mov(ebx, memd[ds, eax + 213]);        /* mov ebx, [eax+0xd5] */
            ii(0x1015_3613, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_3616, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_3619, 3);  lea(eax, memd[ss, ebp - 100]);        /* lea eax, [ebp-0x64] */
            ii(0x1015_361c, 5);  call(0x1007_5e64, -0xd_d7bd);         /* call 0x10075e64 */
            ii(0x1015_3621, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1015_3624, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_3626, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1015_3628, 5);  call(0x1015_3079, -0x5b4);            /* call 0x10153079 */
        l_0x1015_362d:
            ii(0x1015_362d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_362f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_3630, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_3631, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_3632, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_3633, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_3634, 1);  ret();                                /* ret */
        }
    }
}
