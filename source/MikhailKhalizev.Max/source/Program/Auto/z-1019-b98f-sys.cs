using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b98f-e17d7f95")]
        public void /* sys */ Method_1019_b98f()
        {
            ii(0x1019_b98f, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_b990, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_b992, 1);  push(esi);                            /* push esi */
            ii(0x1019_b993, 1);  push(edi);                            /* push edi */
            ii(0x1019_b994, 3);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1019_b997, 3);  mov(edi, memd[ss, ebp + 8]);          /* mov edi, [ebp+0x8] */
            ii(0x1019_b99a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1019_b99d, 2);  mov(ch, cl);                          /* mov ch, cl */
            ii(0x1019_b99f, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1019_b9a2, 1);  push(eax);                            /* push eax */
            ii(0x1019_b9a3, 3);  mov(esi, memd[ds, edx + 4]);          /* mov esi, [edx+0x4] */
            ii(0x1019_b9a6, 1);  push(esi);                            /* push esi */
            ii(0x1019_b9a7, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1019_b9a9, 1);  push(eax);                            /* push eax */
            ii(0x1019_b9aa, 5);  call(0x1019_c548, 0xb99);             /* call 0x1019c548 */
            ii(0x1019_b9af, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1019_b9b1, 2);  if(jz(0x1019_b9cf, 0x1c)) goto l_0x1019_b9cf;/* jz 0x1019b9cf */
            ii(0x1019_b9b3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1019_b9b6, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1019_b9b8, 2);  jmp(0x1019_b9c2, 8); goto l_0x1019_b9c2;/* jmp 0x1019b9c2 */
        l_0x1019_b9ba:
            ii(0x1019_b9ba, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1019_b9bc, 2);  if(jge(0x1019_b9c0, 2)) goto l_0x1019_b9c0;/* jge 0x1019b9c0 */
            ii(0x1019_b9be, 2);  mov(memb[ds, eax], dh);               /* mov [eax], dh */
        l_0x1019_b9c0:
            ii(0x1019_b9c0, 1);  inc(eax);                             /* inc eax */
            ii(0x1019_b9c1, 1);  inc(esi);                             /* inc esi */
        l_0x1019_b9c2:
            ii(0x1019_b9c2, 4);  mov(dh, memb[ds, esi + ebp - 64]);    /* mov dh, [esi+ebp-0x40] */
            ii(0x1019_b9c6, 2);  test(dh, dh);                         /* test dh, dh */
            ii(0x1019_b9c8, 2);  if(jnz(0x1019_b9ba, -0x10)) goto l_0x1019_b9ba;/* jnz 0x1019b9ba */
            ii(0x1019_b9ca, 5);  jmp(0x1019_bbac, 0x1dd); goto l_0x1019_bbac;/* jmp 0x1019bbac */
        l_0x1019_b9cf:
            ii(0x1019_b9cf, 3);  mov(cl, memb[ss, ebp + 24]);          /* mov cl, [ebp+0x18] */
            ii(0x1019_b9d2, 2);  mov(al, cl);                          /* mov al, cl */
            ii(0x1019_b9d4, 3);  cmp(eax, 0x47);                       /* cmp eax, 0x47 */
            ii(0x1019_b9d7, 6);  if(jnz(0x1019_ba44, 0x67)) goto l_0x1019_ba44;/* jnz 0x1019ba44 */
            ii(0x1019_b9dd, 2);  fld(memq[ds, edx]);                   /* fld qword [edx] */
            ii(0x1019_b9df, 2);  fabs();                               /* fabs */
            ii(0x1019_b9e1, 3);  fstp(memq[ss, ebp - 44]);             /* fstp qword [ebp-0x2c] */
            ii(0x1019_b9e4, 3);  mov(esi, memd[ss, ebp - 40]);         /* mov esi, [ebp-0x28] */
            ii(0x1019_b9e7, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1019_b9ea, 6);  test(esi, 0x7fff_ffff);               /* test esi, 0x7fffffff */
            ii(0x1019_b9f0, 2);  if(jnz(0x1019_b9f6, 4)) goto l_0x1019_b9f6;/* jnz 0x1019b9f6 */
            ii(0x1019_b9f2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1019_b9f4, 2);  if(jz(0x1019_ba3d, 0x47)) goto l_0x1019_ba3d;/* jz 0x1019ba3d */
        l_0x1019_b9f6:
            ii(0x1019_b9f6, 3);  fld(memq[ss, ebp - 44]);              /* fld qword [ebp-0x2c] */
            ii(0x1019_b9f9, 5);  call(0x1019_c621, 0xc23);             /* call 0x1019c621 */
            ii(0x1019_b9fe, 3);  fstp(memq[ss, ebp - 44]);             /* fstp qword [ebp-0x2c] */
            ii(0x1019_ba01, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1019_ba04, 1);  push(eax);                            /* push eax */
            ii(0x1019_ba05, 3);  mov(esi, memd[ss, ebp - 44]);         /* mov esi, [ebp-0x2c] */
            ii(0x1019_ba08, 1);  push(esi);                            /* push esi */
            ii(0x1019_ba09, 5);  call(0x1019_c649, 0xc3b);             /* call 0x1019c649 */
            ii(0x1019_ba0e, 5);  call(Definitions.sys_round, -0x3_5995);/* call 0x1016607e */
            ii(0x1019_ba13, 3);  fistp(memd[ss, ebp - 20]);            /* fistp dword [ebp-0x14] */
            ii(0x1019_ba16, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1019_ba19, 3);  cmp(eax, -4 /* 0xfc */);              /* cmp eax, 0xfffffffc */
            ii(0x1019_ba1c, 2);  if(jl(0x1019_ba22, 4)) goto l_0x1019_ba22;/* jl 0x1019ba22 */
            ii(0x1019_ba1e, 2);  cmp(ebx, eax);                        /* cmp ebx, eax */
            ii(0x1019_ba20, 2);  if(jg(0x1019_ba26, 4)) goto l_0x1019_ba26;/* jg 0x1019ba26 */
        l_0x1019_ba22:
            ii(0x1019_ba22, 2);  mov(cl, 0x45);                        /* mov cl, 0x45 */
            ii(0x1019_ba24, 2);  jmp(0x1019_ba44, 0x1e); goto l_0x1019_ba44;/* jmp 0x1019ba44 */
        l_0x1019_ba26:
            ii(0x1019_ba26, 2);  fldz();                               /* fldz */
            ii(0x1019_ba28, 3);  fcomp(memq[ss, ebp - 44]);            /* fcomp qword [ebp-0x2c] */
            ii(0x1019_ba2b, 2);  fnstsw(ax);                           /* fnstsw ax */
            ii(0x1019_ba2d, 1);  sahf();                               /* sahf */
            ii(0x1019_ba2e, 2);  if(ja(0x1019_ba33, 3)) goto l_0x1019_ba33;/* ja 0x1019ba33 */
            ii(0x1019_ba30, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1019_ba33:
            ii(0x1019_ba33, 3);  mov(esi, memd[ss, ebp - 20]);         /* mov esi, [ebp-0x14] */
            ii(0x1019_ba36, 2);  sub(ebx, esi);                        /* sub ebx, esi */
            ii(0x1019_ba38, 2);  test(esi, esi);                       /* test esi, esi */
            ii(0x1019_ba3a, 2);  if(jge(0x1019_ba3d, 1)) goto l_0x1019_ba3d;/* jge 0x1019ba3d */
            ii(0x1019_ba3c, 1);  dec(ebx);                             /* dec ebx */
        l_0x1019_ba3d:
            ii(0x1019_ba3d, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1019_ba3f, 2);  mov(cl, 0x46);                        /* mov cl, 0x46 */
            ii(0x1019_ba41, 3);  mov(memd[ss, ebp + 12], esi);         /* mov [ebp+0xc], esi */
        l_0x1019_ba44:
            ii(0x1019_ba44, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1019_ba46, 2);  mov(al, cl);                          /* mov al, cl */
            ii(0x1019_ba48, 3);  cmp(eax, 0x45);                       /* cmp eax, 0x45 */
            ii(0x1019_ba4b, 2);  if(jnz(0x1019_ba73, 0x26)) goto l_0x1019_ba73;/* jnz 0x1019ba73 */
            ii(0x1019_ba4d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1019_ba4f, 3);  mov(esi, memd[ss, ebp + 12]);         /* mov esi, [ebp+0xc] */
            ii(0x1019_ba52, 2);  neg(eax);                             /* neg eax */
            ii(0x1019_ba54, 2);  cmp(eax, esi);                        /* cmp eax, esi */
            ii(0x1019_ba56, 2);  if(jge(0x1019_ba5f, 7)) goto l_0x1019_ba5f;/* jge 0x1019ba5f */
            ii(0x1019_ba58, 3);  lea(eax, memd[ds, ebx + 2]);          /* lea eax, [ebx+0x2] */
            ii(0x1019_ba5b, 2);  cmp(eax, esi);                        /* cmp eax, esi */
            ii(0x1019_ba5d, 2);  if(jg(0x1019_ba73, 0x14)) goto l_0x1019_ba73;/* jg 0x1019ba73 */
        l_0x1019_ba5f:
            ii(0x1019_ba5f, 5);  mov(edx, 0x2a);                       /* mov edx, 0x2a */
            ii(0x1019_ba64, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1019_ba67, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1019_ba69, 5);  call(Definitions.sys_memset, -0x3_5c8e);/* call 0x10165de0 */
            ii(0x1019_ba6e, 5);  jmp(0x1019_bbc0, 0x14d); goto l_0x1019_bbc0;/* jmp 0x1019bbc0 */
        l_0x1019_ba73:
            ii(0x1019_ba73, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1019_ba75, 3);  mov(al, memb[ss, ebp + 24]);          /* mov al, [ebp+0x18] */
            ii(0x1019_ba78, 2);  mov(esi, ebx);                        /* mov esi, ebx */
            ii(0x1019_ba7a, 3);  cmp(eax, 0x45);                       /* cmp eax, 0x45 */
            ii(0x1019_ba7d, 2);  if(jnz(0x1019_ba90, 0x11)) goto l_0x1019_ba90;/* jnz 0x1019ba90 */
            ii(0x1019_ba7f, 3);  mov(eax, memd[ss, ebp + 12]);         /* mov eax, [ebp+0xc] */
            ii(0x1019_ba82, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1019_ba84, 2);  if(jle(0x1019_ba8b, 5)) goto l_0x1019_ba8b;/* jle 0x1019ba8b */
            ii(0x1019_ba86, 3);  lea(esi, memd[ds, ebx + 1]);          /* lea esi, [ebx+0x1] */
            ii(0x1019_ba89, 2);  jmp(0x1019_ba90, 5); goto l_0x1019_ba90;/* jmp 0x1019ba90 */
        l_0x1019_ba8b:
            ii(0x1019_ba8b, 2);  if(jge(0x1019_ba90, 3)) goto l_0x1019_ba90;/* jge 0x1019ba90 */
            ii(0x1019_ba8d, 3);  lea(esi, memd[ds, eax + ebx]);        /* lea esi, [eax+ebx] */
        l_0x1019_ba90:
            ii(0x1019_ba90, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1019_ba92, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1019_ba95, 3);  mov(eax, memd[ds, edx + 4]);          /* mov eax, [edx+0x4] */
            ii(0x1019_ba98, 3);  mov(ebx, memd[ss, ebp - 36]);         /* mov ebx, [ebp-0x24] */
            ii(0x1019_ba9b, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1019_ba9e, 5);  test(eax, 0x7fff_ffff);               /* test eax, 0x7fffffff */
            ii(0x1019_baa3, 2);  if(jnz(0x1019_baa9, 4)) goto l_0x1019_baa9;/* jnz 0x1019baa9 */
            ii(0x1019_baa5, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1019_baa7, 2);  if(jz(0x1019_baca, 0x21)) goto l_0x1019_baca;/* jz 0x1019baca */
        l_0x1019_baa9:
            ii(0x1019_baa9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1019_baab, 2);  mov(al, cl);                          /* mov al, cl */
            ii(0x1019_baad, 3);  cmp(eax, 0x45);                       /* cmp eax, 0x45 */
            ii(0x1019_bab0, 2);  if(jz(0x1019_baca, 0x18)) goto l_0x1019_baca;/* jz 0x1019baca */
            ii(0x1019_bab2, 3);  mov(eax, memd[ss, ebp + 12]);         /* mov eax, [ebp+0xc] */
            ii(0x1019_bab5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1019_bab7, 2);  if(jz(0x1019_baca, 0x11)) goto l_0x1019_baca;/* jz 0x1019baca */
            ii(0x1019_bab9, 1);  push(eax);                            /* push eax */
            ii(0x1019_baba, 3);  mov(ebx, memd[ss, ebp - 32]);         /* mov ebx, [ebp-0x20] */
            ii(0x1019_babd, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_babe, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1019_bac1, 1);  push(eax);                            /* push eax */
            ii(0x1019_bac2, 5);  call(0x1019_c6c6, 0xbff);             /* call 0x1019c6c6 */
            ii(0x1019_bac7, 3);  fstp(memq[ss, ebp - 36]);             /* fstp qword [ebp-0x24] */
        l_0x1019_baca:
            ii(0x1019_baca, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1019_bacd, 1);  push(eax);                            /* push eax */
            ii(0x1019_bace, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1019_bad0, 2);  mov(al, cl);                          /* mov al, cl */
            ii(0x1019_bad2, 1);  push(eax);                            /* push eax */
            ii(0x1019_bad3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1019_bad6, 1);  push(eax);                            /* push eax */
            ii(0x1019_bad7, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1019_bada, 1);  push(eax);                            /* push eax */
            ii(0x1019_badb, 1);  push(esi);                            /* push esi */
            ii(0x1019_badc, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1019_badf, 1);  push(edx);                            /* push edx */
            ii(0x1019_bae0, 3);  mov(ebx, memd[ss, ebp - 36]);         /* mov ebx, [ebp-0x24] */
            ii(0x1019_bae3, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_bae4, 5);  call(0x1019_c7e3, 0xcfa);             /* call 0x1019c7e3 */
            ii(0x1019_bae9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1019_baec, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1019_baef, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_baf2, 1);  inc(eax);                             /* inc eax */
            ii(0x1019_baf3, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1019_baf5, 2);  if(jz(0x1019_bb02, 0xb)) goto l_0x1019_bb02;/* jz 0x1019bb02 */
            ii(0x1019_baf7, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1019_bafa, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_bafd, 3);  mov(memb[ds, edx], 0x2d);             /* mov byte [edx], 0x2d */
            ii(0x1019_bb00, 2);  jmp(0x1019_bb0f, 0xd); goto l_0x1019_bb0f;/* jmp 0x1019bb0f */
        l_0x1019_bb02:
            ii(0x1019_bb02, 2);  test(ch, ch);                         /* test ch, ch */
            ii(0x1019_bb04, 2);  if(jz(0x1019_bb0f, 9)) goto l_0x1019_bb0f;/* jz 0x1019bb0f */
            ii(0x1019_bb06, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1019_bb09, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_bb0c, 3);  mov(memb[ds, edx], 0x2b);             /* mov byte [edx], 0x2b */
        l_0x1019_bb0f:
            ii(0x1019_bb0f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1019_bb11, 2);  mov(dl, cl);                          /* mov dl, cl */
            ii(0x1019_bb13, 3);  lea(eax, memd[ds, edi + 1]);          /* lea eax, [edi+0x1] */
            ii(0x1019_bb16, 3);  cmp(edx, 0x45);                       /* cmp edx, 0x45 */
            ii(0x1019_bb19, 2);  if(jnz(0x1019_bb81, 0x66)) goto l_0x1019_bb81;/* jnz 0x1019bb81 */
            ii(0x1019_bb1b, 3);  mov(edx, memd[ss, ebp + 12]);         /* mov edx, [ebp+0xc] */
            ii(0x1019_bb1e, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x1019_bb20, 2);  sub(ecx, edx);                        /* sub ecx, edx */
            ii(0x1019_bb22, 2);  cmp(edi, ecx);                        /* cmp edi, ecx */
            ii(0x1019_bb24, 6);  if(jl(0x1019_bbaa, 0x80)) goto l_0x1019_bbaa;/* jl 0x1019bbaa */
            ii(0x1019_bb2a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1019_bb2d, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1019_bb2f, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1019_bb32, 5);  call(/* sys */ 0x1019_b8bb, -0x27c);  /* call 0x1019b8bb */
            ii(0x1019_bb37, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1019_bb3a, 3);  mov(dl, memb[ss, ebp + 20]);          /* mov dl, [ebp+0x14] */
            ii(0x1019_bb3d, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1019_bb3f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_bb42, 2);  sub(esi, ebx);                        /* sub esi, ebx */
            ii(0x1019_bb44, 2);  test(dl, dl);                         /* test dl, dl */
            ii(0x1019_bb46, 2);  if(jz(0x1019_bb53, 0xb)) goto l_0x1019_bb53;/* jz 0x1019bb53 */
            ii(0x1019_bb48, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1019_bb4a, 2);  if(jge(0x1019_bb53, 7)) goto l_0x1019_bb53;/* jge 0x1019bb53 */
            ii(0x1019_bb4c, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1019_bb4e, 1);  inc(eax);                             /* inc eax */
            ii(0x1019_bb4f, 1);  inc(esi);                             /* inc esi */
            ii(0x1019_bb50, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1019_bb53:
            ii(0x1019_bb53, 3);  mov(ecx, memd[ss, ebp - 32]);         /* mov ecx, [ebp-0x20] */
            ii(0x1019_bb56, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1019_bb59, 6);  test(ecx, 0x7fff_ffff);               /* test ecx, 0x7fffffff */
            ii(0x1019_bb5f, 2);  if(jnz(0x1019_bb65, 4)) goto l_0x1019_bb65;/* jnz 0x1019bb65 */
            ii(0x1019_bb61, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1019_bb63, 2);  if(jz(0x1019_bb6b, 6)) goto l_0x1019_bb6b;/* jz 0x1019bb6b */
        l_0x1019_bb65:
            ii(0x1019_bb65, 3);  mov(eax, memd[ss, ebp + 12]);         /* mov eax, [ebp+0xc] */
            ii(0x1019_bb68, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
        l_0x1019_bb6b:
            ii(0x1019_bb6b, 3);  mov(ebx, memd[ss, ebp + 16]);         /* mov ebx, [ebp+0x10] */
            ii(0x1019_bb6e, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x1019_bb71, 2);  mov(ecx, edi);                        /* mov ecx, edi */
            ii(0x1019_bb73, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1019_bb76, 2);  sub(ecx, esi);                        /* sub ecx, esi */
            ii(0x1019_bb78, 5);  call(/* sys */ 0x1019_b818, -0x365);  /* call 0x1019b818 */
            ii(0x1019_bb7d, 2);  add(esi, eax);                        /* add esi, eax */
            ii(0x1019_bb7f, 2);  jmp(0x1019_bbac, 0x2b); goto l_0x1019_bbac;/* jmp 0x1019bbac */
        l_0x1019_bb81:
            ii(0x1019_bb81, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x1019_bb84, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x1019_bb87, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x1019_bb8a, 1);  inc(edx);                             /* inc edx */
            ii(0x1019_bb8b, 2);  sub(ebx, ecx);                        /* sub ebx, ecx */
            ii(0x1019_bb8d, 2);  add(edx, esi);                        /* add edx, esi */
            ii(0x1019_bb8f, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1019_bb91, 2);  cmp(edi, edx);                        /* cmp edi, edx */
            ii(0x1019_bb93, 2);  if(jl(0x1019_bbaa, 0x15)) goto l_0x1019_bbaa;/* jl 0x1019bbaa */
            ii(0x1019_bb95, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1019_bb98, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1019_bb9b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1019_bb9e, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x1019_bba0, 3);  mov(esi, memd[ss, ebp - 12]);         /* mov esi, [ebp-0xc] */
            ii(0x1019_bba3, 5);  call(/* sys */ 0x1019_b8bb, -0x2ed);  /* call 0x1019b8bb */
            ii(0x1019_bba8, 2);  sub(eax, esi);                        /* sub eax, esi */
        l_0x1019_bbaa:
            ii(0x1019_bbaa, 2);  mov(esi, eax);                        /* mov esi, eax */
        l_0x1019_bbac:
            ii(0x1019_bbac, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1019_bbae, 6);  if(jg(0x1019_ba5f, -0x155)) goto l_0x1019_ba5f;/* jg 0x1019ba5f */
            ii(0x1019_bbb4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1019_bbb7, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1019_bbb9, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1019_bbbb, 5);  call(/* sys */ 0x1019_b91e, -0x2a2);  /* call 0x1019b91e */
        l_0x1019_bbc0:
            ii(0x1019_bbc0, 3);  lea(esp, memd[ss, ebp - 8]);          /* lea esp, [ebp-0x8] */
            ii(0x1019_bbc3, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_bbc4, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_bbc5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_bbc6, 3);  ret(0x14);                            /* ret 0x14 */
        }
    }
}
