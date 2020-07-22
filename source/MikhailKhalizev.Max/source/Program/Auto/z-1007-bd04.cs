using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_bd04-91a0e80")]
        public void Method_1007_bd04()
        {
            ii(0x1007_bd04, 5);  push(0xd4);                           /* push 0xd4 */
            ii(0x1007_bd09, 5);  call(Definitions.sys_check_available_stack_size, 0xe_a044);/* call 0x10165d52 */
            ii(0x1007_bd0e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_bd0f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_bd10, 1);  push(edx);                            /* push edx */
            ii(0x1007_bd11, 1);  push(esi);                            /* push esi */
            ii(0x1007_bd12, 1);  push(edi);                            /* push edi */
            ii(0x1007_bd13, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_bd14, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_bd16, 6);  sub(esp, 0xb4);                       /* sub esp, 0xb4 */
            ii(0x1007_bd1c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_bd1f, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_bd23, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_bd25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bd28, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_bd2b, 5);  call(0x1013_ad11, 0xb_efe1);          /* call 0x1013ad11 */
            ii(0x1007_bd30, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_bd32, 2);  if(jz(0x1007_bd3d, 9)) goto l_0x1007_bd3d;/* jz 0x1007bd3d */
            ii(0x1007_bd34, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_bd38, 5);  jmp(0x1007_c443, 0x706); goto l_0x1007_c443;/* jmp 0x1007c443 */
        l_0x1007_bd3d:
            ii(0x1007_bd3d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bd40, 3);  add(eax, 0x2d);                       /* add eax, 0x2d */
            ii(0x1007_bd43, 5);  call(0x1008_a4a0, 0xe758);            /* call 0x1008a4a0 */
            ii(0x1007_bd48, 1);  cwde();                               /* cwde */
            ii(0x1007_bd49, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_bd4b, 2);  if(jnz(0x1007_bd59, 0xc)) goto l_0x1007_bd59;/* jnz 0x1007bd59 */
            ii(0x1007_bd4d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bd50, 5);  call(0x1007_b638, -0x71d);            /* call 0x1007b638 */
            ii(0x1007_bd55, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
        l_0x1007_bd59:
            ii(0x1007_bd59, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bd5c, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1007_bd5f, 5);  call(0x1007_6338, -0x5a2c);           /* call 0x10076338 */
            ii(0x1007_bd64, 3);  lea(ebx, memd[ss, ebp - 52]);         /* lea ebx, [ebp-0x34] */
            ii(0x1007_bd67, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_bd69, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_bd6b, 5);  call(0x1007_64b8, -0x58b8);           /* call 0x100764b8 */
            ii(0x1007_bd70, 2);  jmp(0x1007_bd7a, 8); goto l_0x1007_bd7a;/* jmp 0x1007bd7a */
        l_0x1007_bd72:
            ii(0x1007_bd72, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_bd75, 5);  call(0x1007_6bf8, -0x5182);           /* call 0x10076bf8 */
        l_0x1007_bd7a:
            ii(0x1007_bd7a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_bd7c, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_bd7f, 5);  call(0x1013_ad71, 0xb_efed);          /* call 0x1013ad71 */
            ii(0x1007_bd84, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_bd86, 2);  if(jz(0x1007_bdc5, 0x3d)) goto l_0x1007_bdc5;/* jz 0x1007bdc5 */
            ii(0x1007_bd88, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_bd8b, 5);  call(0x1007_63a0, -0x59f0);           /* call 0x100763a0 */
            ii(0x1007_bd90, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x1007_bd93, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_bd96, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bd99, 3);  add(eax, 0x2d);                       /* add eax, 0x2d */
            ii(0x1007_bd9c, 5);  call(0x100b_87da, 0x3_ca39);          /* call 0x100b87da */
            ii(0x1007_bda1, 1);  cwde();                               /* cwde */
            ii(0x1007_bda2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_bda4, 2);  if(jnz(0x1007_bdc3, 0x1d)) goto l_0x1007_bdc3;/* jnz 0x1007bdc3 */
            ii(0x1007_bda6, 5);  call(0x1008_a79c, 0xe9f1);            /* call 0x1008a79c */
            ii(0x1007_bdab, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_bdad, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1007_bdaf, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_bdb2, 5);  call(0x1007_63d4, -0x59e3);           /* call 0x100763d4 */
            ii(0x1007_bdb7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_bdb9, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_bdbe, 5);  call(0x100a_53ac, 0x2_95e9);          /* call 0x100a53ac */
        l_0x1007_bdc3:
            ii(0x1007_bdc3, 2);  jmp(0x1007_bd72, -0x53); goto l_0x1007_bd72;/* jmp 0x1007bd72 */
        l_0x1007_bdc5:
            ii(0x1007_bdc5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bdc8, 4);  mov(dx, memw[ds, eax + 39]);          /* mov dx, [eax+0x27] */
            ii(0x1007_bdcc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bdcf, 4);  cmp(dx, memw[ds, eax + 37]);          /* cmp dx, [eax+0x25] */
            ii(0x1007_bdd3, 2);  if(jg(0x1007_bde8, 0x13)) goto l_0x1007_bde8;/* jg 0x1007bde8 */
            ii(0x1007_bdd5, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_bdd9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_bddb, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_bdde, 5);  call(0x1007_5f6c, -0x5e77);           /* call 0x10075f6c */
            ii(0x1007_bde3, 5);  jmp(0x1007_c443, 0x65b); goto l_0x1007_c443;/* jmp 0x1007c443 */
        l_0x1007_bde8:
            ii(0x1007_bde8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bdeb, 4);  cmp(memb[ds, eax + 49], 0);           /* cmp byte [eax+0x31], 0x0 */
            ii(0x1007_bdef, 6);  if(jz(0x1007_c151, 0x35c)) goto l_0x1007_c151;/* jz 0x1007c151 */
            ii(0x1007_bdf5, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_bdf9, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bdfc, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x5711);/* call 0x100766f0 */
            ii(0x1007_be01, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1007_be04, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1007_be08, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_be0c, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_be0f, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x5724);/* call 0x100766f0 */
            ii(0x1007_be14, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1007_be17, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1007_be1b, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1007_be1f, 2);  if(jnz(0x1007_be2d, 0xc)) goto l_0x1007_be2d;/* jnz 0x1007be2d */
            ii(0x1007_be21, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_be24, 5);  call(0x1007_b638, -0x7f1);            /* call 0x1007b638 */
            ii(0x1007_be29, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
        l_0x1007_be2d:
            ii(0x1007_be2d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_be2f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_be32, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_be35, 5);  call(0x1013_ad11, 0xb_eed7);          /* call 0x1013ad11 */
            ii(0x1007_be3a, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_be3c, 2);  if(jz(0x1007_be4a, 0xc)) goto l_0x1007_be4a;/* jz 0x1007be4a */
            ii(0x1007_be3e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_be40, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_be43, 5);  call(0x1007_6630, -0x5818);           /* call 0x10076630 */
            ii(0x1007_be48, 2);  jmp(0x1007_be64, 0x1a); goto l_0x1007_be64;/* jmp 0x1007be64 */
        l_0x1007_be4a:
            ii(0x1007_be4a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_be4d, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_be50, 5);  call(0x1008_afb4, 0xf15f);            /* call 0x1008afb4 */
            ii(0x1007_be55, 5);  call(0x1008_4dd5, 0x8f7b);            /* call 0x10084dd5 */
            ii(0x1007_be5a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_be5c, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_be5f, 5);  call(0x1007_6630, -0x5834);           /* call 0x10076630 */
        l_0x1007_be64:
            ii(0x1007_be64, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_be66, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_be69, 5);  call(0x1013_ad11, 0xb_eea3);          /* call 0x1013ad11 */
            ii(0x1007_be6e, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_be70, 2);  if(jnz(0x1007_be8f, 0x1d)) goto l_0x1007_be8f;/* jnz 0x1007be8f */
            ii(0x1007_be72, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_be75, 5);  call(0x1007_6574, -0x5906);           /* call 0x10076574 */
            ii(0x1007_be7a, 4);  test(memb[ds, eax + 18], 0xc0);       /* test byte [eax+0x12], 0xc0 */
            ii(0x1007_be7e, 2);  if(jnz(0x1007_be8f, 0xf)) goto l_0x1007_be8f;/* jnz 0x1007be8f */
            ii(0x1007_be80, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_be83, 5);  call(0x1007_6574, -0x5914);           /* call 0x10076574 */
            ii(0x1007_be88, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_be8d, 2);  if(jnz(0x1007_be9b, 0xc)) goto l_0x1007_be9b;/* jnz 0x1007be9b */
        l_0x1007_be8f:
            ii(0x1007_be8f, 7);  mov(memd[ss, ebp - 80], 0);           /* mov dword [ebp-0x50], 0x0 */
            ii(0x1007_be96, 5);  jmp(0x1007_bf35, 0x9a); goto l_0x1007_bf35;/* jmp 0x1007bf35 */
        l_0x1007_be9b:
            ii(0x1007_be9b, 7);  mov(memd[ss, ebp - 84], 0xffff_ffff); /* mov dword [ebp-0x54], 0xffffffff */
            ii(0x1007_bea2, 5);  mov(edx, 0x4e);                       /* mov edx, 0x4e */
            ii(0x1007_bea7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_beaa, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1007_bead, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_beb0, 5);  call(0x100b_71dc, 0x3_b327);          /* call 0x100b71dc */
            ii(0x1007_beb5, 1);  cwde();                               /* cwde */
            ii(0x1007_beb6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_beb8, 2);  if(jle(0x1007_bec3, 9)) goto l_0x1007_bec3;/* jle 0x1007bec3 */
            ii(0x1007_beba, 7);  mov(memd[ss, ebp - 84], 0x4e);        /* mov dword [ebp-0x54], 0x4e */
            ii(0x1007_bec1, 2);  jmp(0x1007_bee2, 0x1f); goto l_0x1007_bee2;/* jmp 0x1007bee2 */
        l_0x1007_bec3:
            ii(0x1007_bec3, 5);  mov(edx, 0x48);                       /* mov edx, 0x48 */
            ii(0x1007_bec8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_becb, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1007_bece, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_bed1, 5);  call(0x100b_71dc, 0x3_b306);          /* call 0x100b71dc */
            ii(0x1007_bed6, 1);  cwde();                               /* cwde */
            ii(0x1007_bed7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_bed9, 2);  if(jle(0x1007_bee2, 7)) goto l_0x1007_bee2;/* jle 0x1007bee2 */
            ii(0x1007_bedb, 7);  mov(memd[ss, ebp - 84], 0x48);        /* mov dword [ebp-0x54], 0x48 */
        l_0x1007_bee2:
            ii(0x1007_bee2, 5);  mov(eax, 0xf);                        /* mov eax, 0xf */
            ii(0x1007_bee7, 5);  call(Definitions.sys_new, 0xe_9f14);  /* call 0x10165e00 */
            ii(0x1007_beec, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x1007_beef, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_bef2, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1007_bef5, 4);  cmp(memd[ss, ebp - 92], 0);           /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x1007_bef9, 2);  if(jz(0x1007_bf29, 0x2e)) goto l_0x1007_bf29;/* jz 0x1007bf29 */
            ii(0x1007_befb, 4);  movsx(eax, memw[ss, ebp - 84]);       /* movsx eax, word [ebp-0x54] */
            ii(0x1007_beff, 1);  push(eax);                            /* push eax */
            ii(0x1007_bf00, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1007_bf05, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1007_bf0a, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_bf0d, 5);  call(0x1007_65d0, -0x5942);           /* call 0x100765d0 */
            ii(0x1007_bf12, 3);  mov(esi, memd[ss, ebp - 88]);         /* mov esi, [ebp-0x58] */
            ii(0x1007_bf15, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_bf17, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1007_bf19, 5);  call(0x1011_fec1, 0xa_3fa3);          /* call 0x1011fec1 */
            ii(0x1007_bf1e, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x1007_bf21, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_bf24, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1007_bf27, 2);  jmp(0x1007_bf2f, 6); goto l_0x1007_bf2f;/* jmp 0x1007bf2f */
        l_0x1007_bf29:
            ii(0x1007_bf29, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_bf2c, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
        l_0x1007_bf2f:
            ii(0x1007_bf2f, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x1007_bf32, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
        l_0x1007_bf35:
            ii(0x1007_bf35, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_bf37, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bf3a, 5);  call(0x1007_6630, -0x590f);           /* call 0x10076630 */
            ii(0x1007_bf3f, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_bf42, 1);  push(eax);                            /* push eax */
            ii(0x1007_bf43, 3);  lea(ecx, memd[ss, ebp - 104]);        /* lea ecx, [ebp-0x68] */
            ii(0x1007_bf46, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_bf48, 5);  mov(edx, 0x101c_8184);                /* mov edx, 0x101c8184 */
            ii(0x1007_bf4d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bf50, 5);  call(0x1007_bad5, -0x480);            /* call 0x1007bad5 */
            ii(0x1007_bf55, 3);  lea(ebx, memd[ss, ebp - 64]);         /* lea ebx, [ebp-0x40] */
            ii(0x1007_bf58, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_bf5a, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_bf5c, 5);  call(0x1007_6630, -0x5931);           /* call 0x10076630 */
            ii(0x1007_bf61, 2);  push(0);                              /* push 0x0 */
            ii(0x1007_bf63, 3);  lea(ecx, memd[ss, ebp - 104]);        /* lea ecx, [ebp-0x68] */
            ii(0x1007_bf66, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bf69, 5);  call(0x1007_65d0, -0x599e);           /* call 0x100765d0 */
            ii(0x1007_bf6e, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1007_bf70, 5);  mov(edx, 0x101c_81a8);                /* mov edx, 0x101c81a8 */
            ii(0x1007_bf75, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bf78, 5);  call(0x1007_bad5, -0x4a8);            /* call 0x1007bad5 */
            ii(0x1007_bf7d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_bf7f, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bf82, 5);  call(0x1007_6630, -0x5957);           /* call 0x10076630 */
            ii(0x1007_bf87, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_bf89, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bf8c, 5);  call(0x1013_ad71, 0xb_ede0);          /* call 0x1013ad71 */
            ii(0x1007_bf91, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_bf93, 6);  if(jz(0x1007_c0d5, 0x13c)) goto l_0x1007_c0d5;/* jz 0x1007c0d5 */
            ii(0x1007_bf99, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bf9c, 5);  call(0x1007_6574, -0x5a2d);           /* call 0x10076574 */
            ii(0x1007_bfa1, 5);  call(0x1015_287d, 0xd_68d7);          /* call 0x1015287d */
            ii(0x1007_bfa6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bfa9, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1007_bfac, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1007_bfaf, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1007_bfb2, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_bfb5, 5);  call(0x1007_65d0, -0x59ea);           /* call 0x100765d0 */
            ii(0x1007_bfba, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_bfbc, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1007_bfbf, 3);  call_abs(memd[ds, ebx + 44]);         /* call dword [ebx+0x2c] */
            ii(0x1007_bfc2, 5);  call(0x1014_82f4, 0xc_c32d);          /* call 0x101482f4 */
            ii(0x1007_bfc7, 6);  sub(eax, memd[ds, 0x101c_3974]);      /* sub eax, [0x101c3974] */
            ii(0x1007_bfcd, 6);  cmp(eax, memd[ds, 0x101b_dd84]);      /* cmp eax, [0x101bdd84] */
            ii(0x1007_bfd3, 6);  if(jb(0x1007_c09a, 0xc1)) goto l_0x1007_c09a;/* jb 0x1007c09a */
            ii(0x1007_bfd9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_bfdc, 5);  call(0x1008_acf8, 0xed17);            /* call 0x1008acf8 */
            ii(0x1007_bfe1, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_bfe3, 2);  if(jnz(0x1007_c037, 0x52)) goto l_0x1007_c037;/* jnz 0x1007c037 */
            ii(0x1007_bfe5, 5);  call(0x1008_a7bc, 0xe7d2);            /* call 0x1008a7bc */
            ii(0x1007_bfea, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_bfef, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x1007_bff2, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1007_bff7, 5);  call(Definitions.sys_new, 0xe_9e04);  /* call 0x10165e00 */
            ii(0x1007_bffc, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x1007_bfff, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x1007_c002, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x1007_c005, 4);  cmp(memd[ss, ebp - 120], 0);          /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1007_c009, 2);  if(jz(0x1007_c021, 0x16)) goto l_0x1007_c021;/* jz 0x1007c021 */
            ii(0x1007_c00b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c00e, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x1007_c011, 5);  call(0x100a_3711, 0x2_76fb);          /* call 0x100a3711 */
            ii(0x1007_c016, 3);  mov(memd[ss, ebp - 124], eax);        /* mov [ebp-0x7c], eax */
            ii(0x1007_c019, 3);  mov(eax, memd[ss, ebp - 124]);        /* mov eax, [ebp-0x7c] */
            ii(0x1007_c01c, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
            ii(0x1007_c01f, 2);  jmp(0x1007_c027, 6); goto l_0x1007_c027;/* jmp 0x1007c027 */
        l_0x1007_c021:
            ii(0x1007_c021, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1007_c024, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
        l_0x1007_c027:
            ii(0x1007_c027, 3);  mov(edx, memd[ss, ebp - 128]);        /* mov edx, [ebp-0x80] */
            ii(0x1007_c02a, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_c02f, 3);  mov(ebx, memd[ss, ebp - 112]);        /* mov ebx, [ebp-0x70] */
            ii(0x1007_c032, 5);  call(0x100a_4db6, 0x2_8d7f);          /* call 0x100a4db6 */
        l_0x1007_c037:
            ii(0x1007_c037, 4);  cmp(memd[ss, ebp - 80], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1007_c03b, 2);  if(jz(0x1007_c073, 0x36)) goto l_0x1007_c073;/* jz 0x1007c073 */
            ii(0x1007_c03d, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_c040, 6);  mov(memd[ss, ebp - 132], eax);        /* mov [ebp-0x84], eax */
            ii(0x1007_c046, 7);  cmp(memd[ss, ebp - 132], 0);          /* cmp dword [ebp-0x84], 0x0 */
            ii(0x1007_c04d, 2);  if(jz(0x1007_c069, 0x1a)) goto l_0x1007_c069;/* jz 0x1007c069 */
            ii(0x1007_c04f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c051, 6);  mov(eax, memd[ss, ebp - 132]);        /* mov eax, [ebp-0x84] */
            ii(0x1007_c057, 5);  call(Definitions.my_dtor_d1, 0xcca0); /* call 0x10088cfc */
            ii(0x1007_c05c, 5);  call(Definitions.sys_delete, 0xe_9f03);/* call 0x10165f64 */
            ii(0x1007_c061, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x1007_c067, 2);  jmp(0x1007_c073, 0xa); goto l_0x1007_c073;/* jmp 0x1007c073 */
        l_0x1007_c069:
            ii(0x1007_c069, 10);  mov(memd[ss, ebp - 136], 0);         /* mov dword [ebp-0x88], 0x0 */
        l_0x1007_c073:
            ii(0x1007_c073, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_c077, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c079, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_c07c, 5);  call(0x1007_5f2c, -0x6155);           /* call 0x10075f2c */
            ii(0x1007_c081, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c083, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_c086, 5);  call(0x1007_5f2c, -0x615f);           /* call 0x10075f2c */
            ii(0x1007_c08b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c08d, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_c090, 5);  call(0x1007_5f6c, -0x6129);           /* call 0x10075f6c */
            ii(0x1007_c095, 5);  jmp(0x1007_c443, 0x3a9); goto l_0x1007_c443;/* jmp 0x1007c443 */
        l_0x1007_c09a:
            ii(0x1007_c09a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c09c, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_c09f, 5);  call(0x1013_ad11, 0xb_ec6d);          /* call 0x1013ad11 */
            ii(0x1007_c0a4, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c0a6, 2);  if(jz(0x1007_c0b9, 0x11)) goto l_0x1007_c0b9;/* jz 0x1007c0b9 */
            ii(0x1007_c0a8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c0aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c0ad, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_c0b0, 5);  call(0x1013_ad71, 0xb_ecbc);          /* call 0x1013ad71 */
            ii(0x1007_c0b5, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c0b7, 2);  if(jnz(0x1007_c0bb, 2)) goto l_0x1007_c0bb;/* jnz 0x1007c0bb */
        l_0x1007_c0b9:
            ii(0x1007_c0b9, 2);  jmp(0x1007_c0d5, 0x1a); goto l_0x1007_c0d5;/* jmp 0x1007c0d5 */
        l_0x1007_c0bb:
            ii(0x1007_c0bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c0be, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_c0c1, 5);  call(0x1008_afb4, 0xeeee);            /* call 0x1008afb4 */
            ii(0x1007_c0c6, 5);  call(0x1008_4dd5, 0x8d0a);            /* call 0x10084dd5 */
            ii(0x1007_c0cb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c0cd, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_c0d0, 5);  call(0x1007_6630, -0x5aa5);           /* call 0x10076630 */
        l_0x1007_c0d5:
            ii(0x1007_c0d5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c0d7, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_c0da, 5);  call(0x1013_ad71, 0xb_ec92);          /* call 0x1013ad71 */
            ii(0x1007_c0df, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c0e1, 2);  if(jz(0x1007_c0f3, 0x10)) goto l_0x1007_c0f3;/* jz 0x1007c0f3 */
            ii(0x1007_c0e3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c0e6, 4);  mov(dx, memw[ds, eax + 39]);          /* mov dx, [eax+0x27] */
            ii(0x1007_c0ea, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c0ed, 4);  cmp(dx, memw[ds, eax + 37]);          /* cmp dx, [eax+0x25] */
            ii(0x1007_c0f1, 2);  if(jg(0x1007_c0f5, 2)) goto l_0x1007_c0f5;/* jg 0x1007c0f5 */
        l_0x1007_c0f3:
            ii(0x1007_c0f3, 2);  jmp(0x1007_c0fa, 5); goto l_0x1007_c0fa;/* jmp 0x1007c0fa */
        l_0x1007_c0f5:
            ii(0x1007_c0f5, 5);  jmp(0x1007_bf35, -0x1c5); goto l_0x1007_bf35;/* jmp 0x1007bf35 */
        l_0x1007_c0fa:
            ii(0x1007_c0fa, 4);  cmp(memd[ss, ebp - 80], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1007_c0fe, 2);  if(jz(0x1007_c136, 0x36)) goto l_0x1007_c136;/* jz 0x1007c136 */
            ii(0x1007_c100, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_c103, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
            ii(0x1007_c109, 7);  cmp(memd[ss, ebp - 140], 0);          /* cmp dword [ebp-0x8c], 0x0 */
            ii(0x1007_c110, 2);  if(jz(0x1007_c12c, 0x1a)) goto l_0x1007_c12c;/* jz 0x1007c12c */
            ii(0x1007_c112, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c114, 6);  mov(eax, memd[ss, ebp - 140]);        /* mov eax, [ebp-0x8c] */
            ii(0x1007_c11a, 5);  call(Definitions.my_dtor_d1, 0xcbdd); /* call 0x10088cfc */
            ii(0x1007_c11f, 5);  call(Definitions.sys_delete, 0xe_9e40);/* call 0x10165f64 */
            ii(0x1007_c124, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
            ii(0x1007_c12a, 2);  jmp(0x1007_c136, 0xa); goto l_0x1007_c136;/* jmp 0x1007c136 */
        l_0x1007_c12c:
            ii(0x1007_c12c, 10);  mov(memd[ss, ebp - 144], 0);         /* mov dword [ebp-0x90], 0x0 */
        l_0x1007_c136:
            ii(0x1007_c136, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c139, 4);  mov(memb[ds, eax + 49], 0);           /* mov byte [eax+0x31], 0x0 */
            ii(0x1007_c13d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c13f, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1007_c142, 5);  call(0x1007_5f2c, -0x621b);           /* call 0x10075f2c */
            ii(0x1007_c147, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c149, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_c14c, 5);  call(0x1007_5f2c, -0x6225);           /* call 0x10075f2c */
        l_0x1007_c151:
            ii(0x1007_c151, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c154, 4);  mov(dx, memw[ds, eax + 39]);          /* mov dx, [eax+0x27] */
            ii(0x1007_c158, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c15b, 4);  cmp(dx, memw[ds, eax + 37]);          /* cmp dx, [eax+0x25] */
            ii(0x1007_c15f, 2);  if(jg(0x1007_c174, 0x13)) goto l_0x1007_c174;/* jg 0x1007c174 */
            ii(0x1007_c161, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_c165, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c167, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_c16a, 5);  call(0x1007_5f6c, -0x6203);           /* call 0x10075f6c */
            ii(0x1007_c16f, 5);  jmp(0x1007_c443, 0x2cf); goto l_0x1007_c443;/* jmp 0x1007c443 */
        l_0x1007_c174:
            ii(0x1007_c174, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c177, 5);  cmp(memw[ds, eax + 19], 0);           /* cmp word [eax+0x13], 0x0 */
            ii(0x1007_c17c, 2);  if(jz(0x1007_c191, 0x13)) goto l_0x1007_c191;/* jz 0x1007c191 */
            ii(0x1007_c17e, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_c182, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c184, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_c187, 5);  call(0x1007_5f6c, -0x6220);           /* call 0x10075f6c */
            ii(0x1007_c18c, 5);  jmp(0x1007_c443, 0x2b2); goto l_0x1007_c443;/* jmp 0x1007c443 */
        l_0x1007_c191:
            ii(0x1007_c191, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1007_c195, 2);  if(jnz(0x1007_c1a3, 0xc)) goto l_0x1007_c1a3;/* jnz 0x1007c1a3 */
            ii(0x1007_c197, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c19a, 5);  call(0x1007_b638, -0xb67);            /* call 0x1007b638 */
            ii(0x1007_c19f, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
        l_0x1007_c1a3:
            ii(0x1007_c1a3, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_c1a7, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1007_c1aa, 5);  call(0x1008_a958, 0xe7a9);            /* call 0x1008a958 */
            ii(0x1007_c1af, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_c1b2, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1007_c1b6, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_c1ba, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_c1bd, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x5ad2);/* call 0x100766f0 */
            ii(0x1007_c1c2, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_c1c5, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1007_c1c9, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_c1cd, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1007_c1d2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c1d5, 3);  add(edx, 0x2d);                       /* add edx, 0x2d */
            ii(0x1007_c1d8, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_c1db, 5);  call(0x100b_8505, 0x3_c325);          /* call 0x100b8505 */
            ii(0x1007_c1e0, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_c1e3, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1007_c1e7, 5);  call(0x100a_314c, 0x2_6f60);          /* call 0x100a314c */
            ii(0x1007_c1ec, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_c1ef, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_c1f6, 2);  jmp(0x1007_c1fe, 6); goto l_0x1007_c1fe;/* jmp 0x1007c1fe */
        l_0x1007_c1f8:
            ii(0x1007_c1f8, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_c1fb, 3);  inc(memd[ss, ebp - 32]);              /* inc dword [ebp-0x20] */
        l_0x1007_c1fe:
            ii(0x1007_c1fe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c201, 3);  add(eax, 0x2d);                       /* add eax, 0x2d */
            ii(0x1007_c204, 5);  call(0x1008_a4a0, 0xe297);            /* call 0x1008a4a0 */
            ii(0x1007_c209, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x1007_c20d, 2);  if(jle(0x1007_c272, 0x63)) goto l_0x1007_c272;/* jle 0x1007c272 */
            ii(0x1007_c20f, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_c213, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_c216, 5);  call(0x1008_a3dc, 0xe1c1);            /* call 0x1008a3dc */
            ii(0x1007_c21b, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1007_c21e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c221, 3);  mov(ebx, memd[ds, eax + 7]);          /* mov ebx, [eax+0x7] */
            ii(0x1007_c224, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_c227, 6);  imul(ebx, ebx, 0x247);                /* imul ebx, ebx, 0x247 */
            ii(0x1007_c22d, 5);  mov(eax, 0x101c_a468);                /* mov eax, 0x101ca468 */
            ii(0x1007_c232, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1007_c234, 5);  call(0x100d_fd2c, 0x6_3af3);          /* call 0x100dfd2c */
            ii(0x1007_c239, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1007_c23d, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1007_c241, 2);  if(jg(0x1007_c25e, 0x1b)) goto l_0x1007_c25e;/* jg 0x1007c25e */
            ii(0x1007_c243, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_c247, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_c24a, 5);  call(0x1008_a3dc, 0xe18d);            /* call 0x1008a3dc */
            ii(0x1007_c24f, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1007_c252, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1007_c255, 7);  test(memb[ds, eax + 0x101c_81c3], 0x10);/* test byte [eax+0x101c81c3], 0x10 */
            ii(0x1007_c25c, 2);  if(jz(0x1007_c270, 0x12)) goto l_0x1007_c270;/* jz 0x1007c270 */
        l_0x1007_c25e:
            ii(0x1007_c25e, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_c262, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_c265, 5);  call(0x1008_a3dc, 0xe172);            /* call 0x1008a3dc */
            ii(0x1007_c26a, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
        l_0x1007_c270:
            ii(0x1007_c270, 2);  jmp(0x1007_c1f8, -0x7a); goto l_0x1007_c1f8;/* jmp 0x1007c1f8 */
        l_0x1007_c272:
            ii(0x1007_c272, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c275, 4);  mov(ax, memw[ds, eax + 39]);          /* mov ax, [eax+0x27] */
            ii(0x1007_c279, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c27c, 4);  sub(ax, memw[ds, edx + 37]);          /* sub ax, [edx+0x25] */
            ii(0x1007_c280, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1007_c283:
            ii(0x1007_c283, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_c286, 5);  call(0x100b_870a, 0x3_c47f);          /* call 0x100b870a */
            ii(0x1007_c28b, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_c28e, 5);  cmp(memw[ss, ebp - 24], -1 /* 0xff */);/* cmp word [ebp-0x18], 0xffff */
            ii(0x1007_c293, 2);  if(jnz(0x1007_c2a1, 0xc)) goto l_0x1007_c2a1;/* jnz 0x1007c2a1 */
            ii(0x1007_c295, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_c29c, 5);  jmp(0x1007_c3e1, 0x140); goto l_0x1007_c3e1;/* jmp 0x1007c3e1 */
        l_0x1007_c2a1:
            ii(0x1007_c2a1, 5);  mov(eax, 0xe1);                       /* mov eax, 0xe1 */
            ii(0x1007_c2a6, 5);  call(Definitions.sys_new, 0xe_9b55);  /* call 0x10165e00 */
            ii(0x1007_c2ab, 6);  mov(memd[ss, ebp - 148], eax);        /* mov [ebp-0x94], eax */
            ii(0x1007_c2b1, 6);  mov(eax, memd[ss, ebp - 148]);        /* mov eax, [ebp-0x94] */
            ii(0x1007_c2b7, 6);  mov(memd[ss, ebp - 152], eax);        /* mov [ebp-0x98], eax */
            ii(0x1007_c2bd, 7);  cmp(memd[ss, ebp - 152], 0);          /* cmp dword [ebp-0x98], 0x0 */
            ii(0x1007_c2c4, 2);  if(jz(0x1007_c2fe, 0x38)) goto l_0x1007_c2fe;/* jz 0x1007c2fe */
            ii(0x1007_c2c6, 5);  call(0x1008_ac70, 0xe9a5);            /* call 0x1008ac70 */
            ii(0x1007_c2cb, 1);  cwde();                               /* cwde */
            ii(0x1007_c2cc, 1);  push(eax);                            /* push eax */
            ii(0x1007_c2cd, 5);  mov(ecx, 0xffff);                     /* mov ecx, 0xffff */
            ii(0x1007_c2d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c2d5, 3);  mov(ebx, memd[ds, eax + 7]);          /* mov ebx, [eax+0x7] */
            ii(0x1007_c2d8, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_c2db, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1007_c2df, 6);  mov(eax, memd[ss, ebp - 148]);        /* mov eax, [ebp-0x94] */
            ii(0x1007_c2e5, 5);  call(0x1014_9237, 0xc_cf4d);          /* call 0x10149237 */
            ii(0x1007_c2ea, 6);  mov(memd[ss, ebp - 156], eax);        /* mov [ebp-0x9c], eax */
            ii(0x1007_c2f0, 6);  mov(eax, memd[ss, ebp - 156]);        /* mov eax, [ebp-0x9c] */
            ii(0x1007_c2f6, 6);  mov(memd[ss, ebp - 160], eax);        /* mov [ebp-0xa0], eax */
            ii(0x1007_c2fc, 2);  jmp(0x1007_c30a, 0xc); goto l_0x1007_c30a;/* jmp 0x1007c30a */
        l_0x1007_c2fe:
            ii(0x1007_c2fe, 6);  mov(eax, memd[ss, ebp - 152]);        /* mov eax, [ebp-0x98] */
            ii(0x1007_c304, 6);  mov(memd[ss, ebp - 160], eax);        /* mov [ebp-0xa0], eax */
        l_0x1007_c30a:
            ii(0x1007_c30a, 6);  mov(edx, memd[ss, ebp - 160]);        /* mov edx, [ebp-0xa0] */
            ii(0x1007_c310, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_c313, 5);  call(0x1007_6630, -0x5ce8);           /* call 0x10076630 */
            ii(0x1007_c318, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c31b, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_c31e, 5);  call(0x1008_a228, 0xdf05);            /* call 0x1008a228 */
            ii(0x1007_c323, 5);  call(0x1008_a370, 0xe048);            /* call 0x1008a370 */
            ii(0x1007_c328, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c32a, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_c32d, 5);  call(0x1007_65d0, -0x5d62);           /* call 0x100765d0 */
            ii(0x1007_c332, 5);  call(0x1007_af7a, -0x13bd);           /* call 0x1007af7a */
            ii(0x1007_c337, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
            ii(0x1007_c33a, 5);  mov(eax, 0x1d);                       /* mov eax, 0x1d */
            ii(0x1007_c33f, 5);  call(Definitions.sys_new, 0xe_9abc);  /* call 0x10165e00 */
            ii(0x1007_c344, 6);  mov(memd[ss, ebp - 164], eax);        /* mov [ebp-0xa4], eax */
            ii(0x1007_c34a, 6);  mov(eax, memd[ss, ebp - 164]);        /* mov eax, [ebp-0xa4] */
            ii(0x1007_c350, 6);  mov(memd[ss, ebp - 168], eax);        /* mov [ebp-0xa8], eax */
            ii(0x1007_c356, 7);  cmp(memd[ss, ebp - 168], 0);          /* cmp dword [ebp-0xa8], 0x0 */
            ii(0x1007_c35d, 2);  if(jz(0x1007_c399, 0x3a)) goto l_0x1007_c399;/* jz 0x1007c399 */
            ii(0x1007_c35f, 6);  lea(edx, memd[ss, ebp - 172]);        /* lea edx, [ebp-0xac] */
            ii(0x1007_c365, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c368, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_c36b, 5);  call(0x1008_a228, 0xdeb8);            /* call 0x1008a228 */
            ii(0x1007_c370, 5);  call(0x100b_8e63, 0x3_caee);          /* call 0x100b8e63 */
            ii(0x1007_c375, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1007_c377, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c37a, 6);  mov(eax, memd[ss, ebp - 164]);        /* mov eax, [ebp-0xa4] */
            ii(0x1007_c380, 5);  call(Definitions.my_ctor_c12, 0x2_9ce7);/* call 0x100a606c */
            ii(0x1007_c385, 6);  mov(memd[ss, ebp - 176], eax);        /* mov [ebp-0xb0], eax */
            ii(0x1007_c38b, 6);  mov(eax, memd[ss, ebp - 176]);        /* mov eax, [ebp-0xb0] */
            ii(0x1007_c391, 6);  mov(memd[ss, ebp - 180], eax);        /* mov [ebp-0xb4], eax */
            ii(0x1007_c397, 2);  jmp(0x1007_c3a5, 0xc); goto l_0x1007_c3a5;/* jmp 0x1007c3a5 */
        l_0x1007_c399:
            ii(0x1007_c399, 6);  mov(eax, memd[ss, ebp - 168]);        /* mov eax, [ebp-0xa8] */
            ii(0x1007_c39f, 6);  mov(memd[ss, ebp - 180], eax);        /* mov [ebp-0xb4], eax */
        l_0x1007_c3a5:
            ii(0x1007_c3a5, 6);  mov(edx, memd[ss, ebp - 180]);        /* mov edx, [ebp-0xb4] */
            ii(0x1007_c3ab, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1007_c3ae, 5);  call(0x1008_a898, 0xe4e5);            /* call 0x1008a898 */
            ii(0x1007_c3b3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c3b6, 4);  inc(memw[ds, eax + 19]);              /* inc word [eax+0x13] */
            ii(0x1007_c3ba, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1007_c3be, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1007_c3c1, 5);  call(0x1008_a7dc, 0xe416);            /* call 0x1008a7dc */
            ii(0x1007_c3c6, 5);  call(0x100a_63bc, 0x2_9ff1);          /* call 0x100a63bc */
            ii(0x1007_c3cb, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1007_c3ce, 5);  call(0x1008_a838, 0xe465);            /* call 0x1008a838 */
            ii(0x1007_c3d3, 5);  mov(ebx, 0x101c_3180);                /* mov ebx, 0x101c3180 */
            ii(0x1007_c3d8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c3da, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_c3dc, 5);  call(0x100a_4d50, 0x2_896f);          /* call 0x100a4d50 */
        l_0x1007_c3e1:
            ii(0x1007_c3e1, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_c3e5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_c3e7, 6);  if(jg(0x1007_c283, -0x16a)) goto l_0x1007_c283;/* jg 0x1007c283 */
            ii(0x1007_c3ed, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_c3f1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c3f3, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_c3f6, 5);  call(0x1008_8dcc, 0xc9d1);            /* call 0x10088dcc */
            ii(0x1007_c3fb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c3fd, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_c400, 5);  call(0x1007_5f2c, -0x64d9);           /* call 0x10075f2c */
            ii(0x1007_c405, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c407, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1007_c40a, 5);  call(0x1008_8cbc, 0xc8ad);            /* call 0x10088cbc */
            ii(0x1007_c40f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c411, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_c414, 5);  call(0x1007_5f6c, -0x64ad);           /* call 0x10075f6c */
            ii(0x1007_c419, 2);  jmp(0x1007_c443, 0x28); goto l_0x1007_c443;/* jmp 0x1007c443 */
        //  ii(0x1007_c41b, 40);  Недостижимый код.
        l_0x1007_c443:
            ii(0x1007_c443, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1007_c446, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_c448, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_c449, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_c44a, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_c44b, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_c44c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_c44d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_c44e, 1);  ret();                                /* ret */
        }
    }
}
