using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f76b-86da30e9")]
        public void Method_1007_f76b()
        {
            ii(0x1007_f76b, 5);  push(0xf4);                           /* push 0xf4 */
            ii(0x1007_f770, 5);  call(Definitions.sys_check_available_stack_size, 0xe_65dd);/* call 0x10165d52 */
            ii(0x1007_f775, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_f776, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_f777, 1);  push(edx);                            /* push edx */
            ii(0x1007_f778, 1);  push(esi);                            /* push esi */
            ii(0x1007_f779, 1);  push(edi);                            /* push edi */
            ii(0x1007_f77a, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_f77b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_f77d, 6);  sub(esp, 0xcc);                       /* sub esp, 0xcc */
            ii(0x1007_f783, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_f786, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_f78a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f78d, 5);  call(0x1007_64fc, -0x9296);           /* call 0x100764fc */
            ii(0x1007_f792, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_f795, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1007_f799, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f79c, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1007_f79f, 5);  call(0x1008_a228, 0xaa84);            /* call 0x1008a228 */
            ii(0x1007_f7a4, 5);  call(0x1008_a370, 0xabc7);            /* call 0x1008a370 */
            ii(0x1007_f7a9, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_f7ac, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_f7b3, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_f7b5, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1007_f7ba, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1007_f7bd, 2);  if(jz(0x1007_f7ce, 0xf)) goto l_0x1007_f7ce;/* jz 0x1007f7ce */
            ii(0x1007_f7bf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_f7c2, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1007_f7c5, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_f7ca, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f7cc, 2);  if(jg(0x1007_f7e5, 0x17)) goto l_0x1007_f7e5;/* jg 0x1007f7e5 */
        l_0x1007_f7ce:
            ii(0x1007_f7ce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f7d1, 5);  call(0x1007_f659, -0x17d);            /* call 0x1007f659 */
            ii(0x1007_f7d6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f7d8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f7db, 5);  call(0x1007_5f6c, -0x9874);           /* call 0x10075f6c */
            ii(0x1007_f7e0, 5);  jmp(0x1008_0399, 0xbb4); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1007_f7e5:
            ii(0x1007_f7e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f7e8, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f7eb, 5);  call(0x1007_6338, -0x94b8);           /* call 0x10076338 */
            ii(0x1007_f7f0, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_f7f3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f7f5, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_f7f7, 5);  call(0x1007_643c, -0x93c0);           /* call 0x1007643c */
            ii(0x1007_f7fc, 2);  jmp(0x1007_f806, 8); goto l_0x1007_f806;/* jmp 0x1007f806 */
        l_0x1007_f7fe:
            ii(0x1007_f7fe, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f801, 5);  call(0x1007_6bf8, -0x8c0e);           /* call 0x10076bf8 */
        l_0x1007_f806:
            ii(0x1007_f806, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f808, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f80b, 5);  call(0x1013_ad71, 0xb_b561);          /* call 0x1013ad71 */
            ii(0x1007_f810, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f812, 6);  if(jz(0x1007_f899, 0x81)) goto l_0x1007_f899;/* jz 0x1007f899 */
            ii(0x1007_f818, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f81b, 5);  call(0x1007_63a0, -0x9480);           /* call 0x100763a0 */
            ii(0x1007_f820, 3);  mov(al, memb[ds, eax + 80]);          /* mov al, [eax+0x50] */
            ii(0x1007_f823, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_f828, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f82a, 2);  if(jnz(0x1007_f894, 0x68)) goto l_0x1007_f894;/* jnz 0x1007f894 */
            ii(0x1007_f82c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f82f, 5);  call(0x1007_63a0, -0x9494);           /* call 0x100763a0 */
            ii(0x1007_f834, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_f837, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_f83c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f83e, 2);  if(jz(0x1007_f864, 0x24)) goto l_0x1007_f864;/* jz 0x1007f864 */
            ii(0x1007_f840, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f843, 5);  call(0x1007_63a0, -0x94a8);           /* call 0x100763a0 */
            ii(0x1007_f848, 5);  call(0x1007_623c, -0x9611);           /* call 0x1007623c */
            ii(0x1007_f84d, 4);  cmp(memb[ds, eax + 22], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_f851, 2);  if(jz(0x1007_f862, 0xf)) goto l_0x1007_f862;/* jz 0x1007f862 */
            ii(0x1007_f853, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1007_f858, 5);  call(0x1007_5fdc, -0x9881);           /* call 0x10075fdc */
            ii(0x1007_f85d, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1007_f860, 2);  if(jge(0x1007_f864, 2)) goto l_0x1007_f864;/* jge 0x1007f864 */
        l_0x1007_f862:
            ii(0x1007_f862, 2);  jmp(0x1007_f894, 0x30); goto l_0x1007_f894;/* jmp 0x1007f894 */
        l_0x1007_f864:
            ii(0x1007_f864, 5);  call(0x1008_ac50, 0xb3e7);            /* call 0x1008ac50 */
            ii(0x1007_f869, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_f86b, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1007_f86d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f870, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f873, 5);  call(0x1007_63a0, -0x94d8);           /* call 0x100763a0 */
            ii(0x1007_f878, 5);  call(0x1015_2962, 0xd_30e5);          /* call 0x10152962 */
            ii(0x1007_f87d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f880, 5);  call(0x1008_ab8c, 0xb307);            /* call 0x1008ab8c */
            ii(0x1007_f885, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_f888, 3);  add(ebx, 0x18);                       /* add ebx, 0x18 */
            ii(0x1007_f88b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f88d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_f88f, 5);  call(0x1008_aaec, 0xb258);            /* call 0x1008aaec */
        l_0x1007_f894:
            ii(0x1007_f894, 5);  jmp(0x1007_f7fe, -0x9b); goto l_0x1007_f7fe;/* jmp 0x1007f7fe */
        l_0x1007_f899:
            ii(0x1007_f899, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_f89b, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1007_f8a0, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f8a2, 2);  if(jnz(0x1007_f8bd, 0x19)) goto l_0x1007_f8bd;/* jnz 0x1007f8bd */
            ii(0x1007_f8a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f8a7, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1007_f8aa, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_f8ad, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f8af, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x1007_f8b5, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_f8b7, 6);  if(jnz(0x1007_fa31, 0x174)) goto l_0x1007_fa31;/* jnz 0x1007fa31 */
        l_0x1007_f8bd:
            ii(0x1007_f8bd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f8c0, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f8c3, 5);  call(0x1007_6338, -0x9590);           /* call 0x10076338 */
            ii(0x1007_f8c8, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_f8cb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f8cd, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_f8cf, 5);  call(0x1007_643c, -0x9498);           /* call 0x1007643c */
            ii(0x1007_f8d4, 2);  jmp(0x1007_f8de, 8); goto l_0x1007_f8de;/* jmp 0x1007f8de */
        l_0x1007_f8d6:
            ii(0x1007_f8d6, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f8d9, 5);  call(0x1007_6bf8, -0x8ce6);           /* call 0x10076bf8 */
        l_0x1007_f8de:
            ii(0x1007_f8de, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f8e0, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f8e3, 5);  call(0x1013_ad71, 0xb_b489);          /* call 0x1013ad71 */
            ii(0x1007_f8e8, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f8ea, 6);  if(jz(0x1007_fa31, 0x141)) goto l_0x1007_fa31;/* jz 0x1007fa31 */
            ii(0x1007_f8f0, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f8f3, 5);  call(0x1007_63d4, -0x9524);           /* call 0x100763d4 */
            ii(0x1007_f8f8, 5);  call(0x100a_2edb, 0x2_35de);          /* call 0x100a2edb */
            ii(0x1007_f8fd, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f8ff, 2);  if(jz(0x1007_f969, 0x68)) goto l_0x1007_f969;/* jz 0x1007f969 */
            ii(0x1007_f901, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f904, 5);  call(0x1007_63a0, -0x9569);           /* call 0x100763a0 */
            ii(0x1007_f909, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_f90c, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_f911, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f913, 2);  if(jz(0x1007_f967, 0x52)) goto l_0x1007_f967;/* jz 0x1007f967 */
            ii(0x1007_f915, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f918, 5);  call(0x1007_63a0, -0x957d);           /* call 0x100763a0 */
            ii(0x1007_f91d, 5);  call(0x1007_623c, -0x96e6);           /* call 0x1007623c */
            ii(0x1007_f922, 3);  mov(edx, memd[ds, eax + 16]);         /* mov edx, [eax+0x10] */
            ii(0x1007_f925, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_f928, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f92b, 5);  call(0x1007_63a0, -0x9590);           /* call 0x100763a0 */
            ii(0x1007_f930, 5);  call(0x1007_623c, -0x96f9);           /* call 0x1007623c */
            ii(0x1007_f935, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1007_f938, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_f93b, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_f93e, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1007_f940, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1007_f943, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f946, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1007_f949, 5);  call(0x1008_a228, 0xa8da);            /* call 0x1008a228 */
            ii(0x1007_f94e, 5);  call(0x100b_8e63, 0x3_9510);          /* call 0x100b8e63 */
            ii(0x1007_f953, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f955, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f958, 5);  call(0x1007_63d4, -0x9589);           /* call 0x100763d4 */
            ii(0x1007_f95d, 5);  call(0x1007_0ca1, -0xecc1);           /* call 0x10070ca1 */
            ii(0x1007_f962, 1);  cwde();                               /* cwde */
            ii(0x1007_f963, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1007_f965, 2);  if(jg(0x1007_f969, 2)) goto l_0x1007_f969;/* jg 0x1007f969 */
        l_0x1007_f967:
            ii(0x1007_f967, 2);  jmp(0x1007_f96e, 5); goto l_0x1007_f96e;/* jmp 0x1007f96e */
        l_0x1007_f969:
            ii(0x1007_f969, 5);  jmp(0x1007_fa2c, 0xbe); goto l_0x1007_fa2c;/* jmp 0x1007fa2c */
        l_0x1007_f96e:
            ii(0x1007_f96e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f970, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f973, 5);  call(0x1007_63d4, -0x95a4);           /* call 0x100763d4 */
            ii(0x1007_f978, 5);  call(0x1007_8840, -0x713d);           /* call 0x10078840 */
            ii(0x1007_f97d, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f97f, 2);  if(jnz(0x1007_f9ad, 0x2c)) goto l_0x1007_f9ad;/* jnz 0x1007f9ad */
            ii(0x1007_f981, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f984, 5);  call(0x1007_6408, -0x9581);           /* call 0x10076408 */
            ii(0x1007_f989, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f98b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f98e, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1007_f991, 5);  call(0x1008_ab1c, 0xb186);            /* call 0x1008ab1c */
            ii(0x1007_f996, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_f999, 5);  call(0x1008_ab8c, 0xb1ee);            /* call 0x1008ab8c */
            ii(0x1007_f99e, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_f9a1, 3);  add(ebx, 0x18);                       /* add ebx, 0x18 */
            ii(0x1007_f9a4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f9a6, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_f9a8, 5);  call(0x1008_aaec, 0xb13f);            /* call 0x1008aaec */
        l_0x1007_f9ad:
            ii(0x1007_f9ad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f9b0, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f9b3, 5);  call(0x1007_6b90, -0x8e28);           /* call 0x10076b90 */
            ii(0x1007_f9b8, 1);  cwde();                               /* cwde */
            ii(0x1007_f9b9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f9bb, 2);  if(jle(0x1007_f9c9, 0xc)) goto l_0x1007_f9c9;/* jle 0x1007f9c9 */
            ii(0x1007_f9bd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f9c0, 5);  call(0x1008_ad28, 0xb363);            /* call 0x1008ad28 */
            ii(0x1007_f9c5, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f9c7, 2);  if(jz(0x1007_f9cb, 2)) goto l_0x1007_f9cb;/* jz 0x1007f9cb */
        l_0x1007_f9c9:
            ii(0x1007_f9c9, 2);  jmp(0x1007_fa1d, 0x52); goto l_0x1007_fa1d;/* jmp 0x1007fa1d */
        l_0x1007_f9cb:
            ii(0x1007_f9cb, 5);  call(0x1008_a7bc, 0xadec);            /* call 0x1008a7bc */
            ii(0x1007_f9d0, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_f9d5, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_f9d8, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1007_f9dd, 5);  call(Definitions.sys_new, 0xe_641e);  /* call 0x10165e00 */
            ii(0x1007_f9e2, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_f9e5, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_f9e8, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_f9eb, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1007_f9ef, 2);  if(jz(0x1007_fa07, 0x16)) goto l_0x1007_fa07;/* jz 0x1007fa07 */
            ii(0x1007_f9f1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f9f4, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_f9f7, 5);  call(Definitions.my_ctor_c11, 0x2_3ecd);/* call 0x100a38c9 */
            ii(0x1007_f9fc, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_f9ff, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_fa02, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_fa05, 2);  jmp(0x1007_fa0d, 6); goto l_0x1007_fa0d;/* jmp 0x1007fa0d */
        l_0x1007_fa07:
            ii(0x1007_fa07, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_fa0a, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
        l_0x1007_fa0d:
            ii(0x1007_fa0d, 3);  mov(edx, memd[ss, ebp - 48]);         /* mov edx, [ebp-0x30] */
            ii(0x1007_fa10, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_fa15, 3);  mov(ebx, memd[ss, ebp - 32]);         /* mov ebx, [ebp-0x20] */
            ii(0x1007_fa18, 5);  call(0x100a_4db6, 0x2_5399);          /* call 0x100a4db6 */
        l_0x1007_fa1d:
            ii(0x1007_fa1d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fa1f, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fa22, 5);  call(0x1007_5f6c, -0x9abb);           /* call 0x10075f6c */
            ii(0x1007_fa27, 5);  jmp(0x1008_0399, 0x96d); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1007_fa2c:
            ii(0x1007_fa2c, 5);  jmp(0x1007_f8d6, -0x15b); goto l_0x1007_f8d6;/* jmp 0x1007f8d6 */
        l_0x1007_fa31:
            ii(0x1007_fa31, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fa34, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_fa37, 5);  call(0x1007_6338, -0x9704);           /* call 0x10076338 */
            ii(0x1007_fa3c, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_fa3f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fa41, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_fa43, 5);  call(0x1007_643c, -0x960c);           /* call 0x1007643c */
            ii(0x1007_fa48, 2);  jmp(0x1007_fa52, 8); goto l_0x1007_fa52;/* jmp 0x1007fa52 */
        l_0x1007_fa4a:
            ii(0x1007_fa4a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fa4d, 5);  call(0x1007_6bf8, -0x8e5a);           /* call 0x10076bf8 */
        l_0x1007_fa52:
            ii(0x1007_fa52, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fa54, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fa57, 5);  call(0x1013_ad71, 0xb_b315);          /* call 0x1013ad71 */
            ii(0x1007_fa5c, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fa5e, 2);  if(jz(0x1007_faa6, 0x46)) goto l_0x1007_faa6;/* jz 0x1007faa6 */
            ii(0x1007_fa60, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fa63, 5);  call(0x1007_63a0, -0x96c8);           /* call 0x100763a0 */
            ii(0x1007_fa68, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_fa6b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_fa70, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_fa72, 2);  if(jnz(0x1007_faa4, 0x30)) goto l_0x1007_faa4;/* jnz 0x1007faa4 */
            ii(0x1007_fa74, 5);  call(0x1008_ac50, 0xb1d7);            /* call 0x1008ac50 */
            ii(0x1007_fa79, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_fa7b, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1007_fa7d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fa80, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fa83, 5);  call(0x1007_63a0, -0x96e8);           /* call 0x100763a0 */
            ii(0x1007_fa88, 5);  call(0x1015_2962, 0xd_2ed5);          /* call 0x10152962 */
            ii(0x1007_fa8d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fa90, 5);  call(0x1008_ab8c, 0xb0f7);            /* call 0x1008ab8c */
            ii(0x1007_fa95, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_fa98, 3);  add(ebx, 0x18);                       /* add ebx, 0x18 */
            ii(0x1007_fa9b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fa9d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_fa9f, 5);  call(0x1008_aaec, 0xb048);            /* call 0x1008aaec */
        l_0x1007_faa4:
            ii(0x1007_faa4, 2);  jmp(0x1007_fa4a, -0x5c); goto l_0x1007_fa4a;/* jmp 0x1007fa4a */
        l_0x1007_faa6:
            ii(0x1007_faa6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_faa9, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_faac, 5);  call(0x1007_6b90, -0x8f21);           /* call 0x10076b90 */
            ii(0x1007_fab1, 1);  cwde();                               /* cwde */
            ii(0x1007_fab2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_fab4, 6);  if(jle(0x1008_038f, 0x8d5)) goto l_0x1008_038f;/* jle 0x1008038f */
            ii(0x1007_faba, 7);  mov(memd[ss, ebp - 64], 0);           /* mov dword [ebp-0x40], 0x0 */
            ii(0x1007_fac1, 4);  mov(memb[ss, ebp - 56], 0);           /* mov byte [ebp-0x38], 0x0 */
            ii(0x1007_fac5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fac8, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_facb, 5);  call(0x1007_6338, -0x9798);           /* call 0x10076338 */
            ii(0x1007_fad0, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_fad3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fad5, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_fad7, 5);  call(0x1007_643c, -0x96a0);           /* call 0x1007643c */
            ii(0x1007_fadc, 2);  jmp(0x1007_fae6, 8); goto l_0x1007_fae6;/* jmp 0x1007fae6 */
        l_0x1007_fade:
            ii(0x1007_fade, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fae1, 5);  call(0x1007_6bf8, -0x8eee);           /* call 0x10076bf8 */
        l_0x1007_fae6:
            ii(0x1007_fae6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fae8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_faeb, 5);  call(0x1013_ad71, 0xb_b281);          /* call 0x1013ad71 */
            ii(0x1007_faf0, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_faf2, 6);  if(jz(0x1007_fd1a, 0x222)) goto l_0x1007_fd1a;/* jz 0x1007fd1a */
            ii(0x1007_faf8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fafb, 5);  call(0x1007_63a0, -0x9760);           /* call 0x100763a0 */
            ii(0x1007_fb00, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_fb04, 2);  if(jz(0x1007_fb58, 0x52)) goto l_0x1007_fb58;/* jz 0x1007fb58 */
            ii(0x1007_fb06, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fb09, 5);  call(0x1007_63a0, -0x976e);           /* call 0x100763a0 */
            ii(0x1007_fb0e, 5);  call(0x1007_623c, -0x98d7);           /* call 0x1007623c */
            ii(0x1007_fb13, 3);  mov(edx, memd[ds, eax + 16]);         /* mov edx, [eax+0x10] */
            ii(0x1007_fb16, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_fb19, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fb1c, 5);  call(0x1007_63a0, -0x9781);           /* call 0x100763a0 */
            ii(0x1007_fb21, 5);  call(0x1007_623c, -0x98ea);           /* call 0x1007623c */
            ii(0x1007_fb26, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1007_fb29, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_fb2c, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_fb2f, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1007_fb31, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1007_fb34, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fb37, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1007_fb3a, 5);  call(0x1008_a228, 0xa6e9);            /* call 0x1008a228 */
            ii(0x1007_fb3f, 5);  call(0x100b_8e63, 0x3_931f);          /* call 0x100b8e63 */
            ii(0x1007_fb44, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fb46, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fb49, 5);  call(0x1007_63d4, -0x977a);           /* call 0x100763d4 */
            ii(0x1007_fb4e, 5);  call(0x1007_0ca1, -0xeeb2);           /* call 0x10070ca1 */
            ii(0x1007_fb53, 1);  cwde();                               /* cwde */
            ii(0x1007_fb54, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1007_fb56, 2);  if(jg(0x1007_fb61, 9)) goto l_0x1007_fb61;/* jg 0x1007fb61 */
        l_0x1007_fb58:
            ii(0x1007_fb58, 4);  mov(memb[ss, ebp - 56], 1);           /* mov byte [ebp-0x38], 0x1 */
            ii(0x1007_fb5c, 5);  jmp(0x1007_fd15, 0x1b4); goto l_0x1007_fd15;/* jmp 0x1007fd15 */
        l_0x1007_fb61:
            ii(0x1007_fb61, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fb64, 5);  call(0x1007_63a0, -0x97c9);           /* call 0x100763a0 */
            ii(0x1007_fb69, 5);  call(0x1015_26ac, 0xd_2b3e);          /* call 0x101526ac */
            ii(0x1007_fb6e, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1007_fb71, 2);  if(jz(0x1007_fb84, 0x11)) goto l_0x1007_fb84;/* jz 0x1007fb84 */
            ii(0x1007_fb73, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fb76, 5);  call(0x1007_63a0, -0x97db);           /* call 0x100763a0 */
            ii(0x1007_fb7b, 5);  call(0x1015_26ac, 0xd_2b2c);          /* call 0x101526ac */
            ii(0x1007_fb80, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_fb82, 2);  if(jnz(0x1007_fb86, 2)) goto l_0x1007_fb86;/* jnz 0x1007fb86 */
        l_0x1007_fb84:
            ii(0x1007_fb84, 2);  jmp(0x1007_fba6, 0x20); goto l_0x1007_fba6;/* jmp 0x1007fba6 */
        l_0x1007_fb86:
            ii(0x1007_fb86, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fb89, 5);  call(0x1007_63a0, -0x97ee);           /* call 0x100763a0 */
            ii(0x1007_fb8e, 5);  call(0x1015_26ac, 0xd_2b19);          /* call 0x101526ac */
            ii(0x1007_fb93, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1007_fb96, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_fb99, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1007_fb9c, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_fb9f, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x1007_fba2, 2);  cmp(al, 0x10);                        /* cmp al, 0x10 */
            ii(0x1007_fba4, 2);  if(jnz(0x1007_fba8, 2)) goto l_0x1007_fba8;/* jnz 0x1007fba8 */
        l_0x1007_fba6:
            ii(0x1007_fba6, 2);  jmp(0x1007_fbc8, 0x20); goto l_0x1007_fbc8;/* jmp 0x1007fbc8 */
        l_0x1007_fba8:
            ii(0x1007_fba8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fbab, 5);  call(0x1007_63a0, -0x9810);           /* call 0x100763a0 */
            ii(0x1007_fbb0, 5);  call(0x1015_26ac, 0xd_2af7);          /* call 0x101526ac */
            ii(0x1007_fbb5, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1007_fbb8, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1007_fbbb, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1007_fbbe, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1007_fbc1, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x1007_fbc4, 2);  cmp(al, 0x17);                        /* cmp al, 0x17 */
            ii(0x1007_fbc6, 2);  if(jnz(0x1007_fbca, 2)) goto l_0x1007_fbca;/* jnz 0x1007fbca */
        l_0x1007_fbc8:
            ii(0x1007_fbc8, 2);  jmp(0x1007_fbcf, 5); goto l_0x1007_fbcf;/* jmp 0x1007fbcf */
        l_0x1007_fbca:
            ii(0x1007_fbca, 5);  jmp(0x1007_fd15, 0x146); goto l_0x1007_fd15;/* jmp 0x1007fd15 */
        l_0x1007_fbcf:
            ii(0x1007_fbcf, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fbd2, 5);  call(0x1007_63a0, -0x9837);           /* call 0x100763a0 */
            ii(0x1007_fbd7, 5);  call(0x1007_623c, -0x99a0);           /* call 0x1007623c */
            ii(0x1007_fbdc, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1007_fbdf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fbe2, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_fbe5, 5);  call(0x1007_6b90, -0x905a);           /* call 0x10076b90 */
            ii(0x1007_fbea, 1);  cwde();                               /* cwde */
            ii(0x1007_fbeb, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1007_fbee, 2);  if(jz(0x1007_fc32, 0x42)) goto l_0x1007_fc32;/* jz 0x1007fc32 */
            ii(0x1007_fbf0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_fbf3, 3);  mov(edx, memd[ds, eax + 26]);         /* mov edx, [eax+0x1a] */
            ii(0x1007_fbf6, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_fbf9, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x1007_fbfe, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_fc01, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_fc04, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_fc07, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1007_fc0a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_fc0d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_fc0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fc12, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1007_fc15, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_fc18, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_fc1e, 6);  mov(eax, memd[ds, eax + 0x101c_a6a3]);/* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_fc24, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_fc26, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1007_fc28, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_fc2d, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1007_fc30, 2);  if(jz(0x1007_fc34, 2)) goto l_0x1007_fc34;/* jz 0x1007fc34 */
        l_0x1007_fc32:
            ii(0x1007_fc32, 2);  jmp(0x1007_fc64, 0x30); goto l_0x1007_fc64;/* jmp 0x1007fc64 */
        l_0x1007_fc34:
            ii(0x1007_fc34, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_fc37, 3);  mov(edx, memd[ds, eax + 21]);         /* mov edx, [eax+0x15] */
            ii(0x1007_fc3a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_fc3d, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_fc40, 3);  mov(eax, memd[ds, eax + 21]);         /* mov eax, [eax+0x15] */
            ii(0x1007_fc43, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_fc46, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_fc49, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1007_fc4b, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_fc4e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fc51, 5);  call(0x1007_63d4, -0x9882);           /* call 0x100763d4 */
            ii(0x1007_fc56, 5);  call(0x1007_0d01, -0xef5a);           /* call 0x10070d01 */
            ii(0x1007_fc5b, 1);  cwde();                               /* cwde */
            ii(0x1007_fc5c, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1007_fc5e, 6);  if(jle(0x1007_fd15, 0xb1)) goto l_0x1007_fd15;/* jle 0x1007fd15 */
        l_0x1007_fc64:
            ii(0x1007_fc64, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_fc67, 3);  mov(eax, memd[ds, eax + 10]);         /* mov eax, [eax+0xa] */
            ii(0x1007_fc6a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_fc6d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_fc70, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1007_fc72, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fc75, 5);  call(0x1007_63a0, -0x98da);           /* call 0x100763a0 */
            ii(0x1007_fc7a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fc7c, 3);  mov(dl, memb[ds, eax + 77]);          /* mov dl, [eax+0x4d] */
            ii(0x1007_fc7f, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1007_fc81, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1007_fc84, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_fc87, 3);  mov(ebx, memd[ds, eax + 6]);          /* mov ebx, [eax+0x6] */
            ii(0x1007_fc8a, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_fc8d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1007_fc8f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1007_fc92, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1007_fc94, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1007_fc97, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1007_fc9b, 2);  if(jz(0x1007_fca6, 9)) goto l_0x1007_fca6;/* jz 0x1007fca6 */
            ii(0x1007_fc9d, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1007_fca0, 4);  cmp(ax, memw[ss, ebp - 88]);          /* cmp ax, [ebp-0x58] */
            ii(0x1007_fca4, 2);  if(jl(0x1007_fca8, 2)) goto l_0x1007_fca8;/* jl 0x1007fca8 */
        l_0x1007_fca6:
            ii(0x1007_fca6, 2);  jmp(0x1007_fcb7, 0xf); goto l_0x1007_fcb7;/* jmp 0x1007fcb7 */
        l_0x1007_fca8:
            ii(0x1007_fca8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fcab, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_fcae, 5);  call(0x1015_2a52, 0xd_2d9f);          /* call 0x10152a52 */
            ii(0x1007_fcb3, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fcb5, 2);  if(jz(0x1007_fcb9, 2)) goto l_0x1007_fcb9;/* jz 0x1007fcb9 */
        l_0x1007_fcb7:
            ii(0x1007_fcb7, 2);  jmp(0x1007_fcbf, 6); goto l_0x1007_fcbf;/* jmp 0x1007fcbf */
        l_0x1007_fcb9:
            ii(0x1007_fcb9, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_fcbc, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
        l_0x1007_fcbf:
            ii(0x1007_fcbf, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fcc2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fcc5, 5);  call(0x1007_63a0, -0x992a);           /* call 0x100763a0 */
            ii(0x1007_fcca, 5);  call(0x1015_2a52, 0xd_2d83);          /* call 0x10152a52 */
            ii(0x1007_fccf, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fcd1, 2);  if(jz(0x1007_fcd9, 6)) goto l_0x1007_fcd9;/* jz 0x1007fcd9 */
            ii(0x1007_fcd3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_fcd6, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1007_fcd9:
            ii(0x1007_fcd9, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1007_fcdd, 2);  if(jz(0x1007_fce8, 9)) goto l_0x1007_fce8;/* jz 0x1007fce8 */
            ii(0x1007_fcdf, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1007_fce2, 4);  cmp(ax, memw[ss, ebp - 88]);          /* cmp ax, [ebp-0x58] */
            ii(0x1007_fce6, 2);  if(jle(0x1007_fcea, 2)) goto l_0x1007_fcea;/* jle 0x1007fcea */
        l_0x1007_fce8:
            ii(0x1007_fce8, 2);  jmp(0x1007_fd04, 0x1a); goto l_0x1007_fd04;/* jmp 0x1007fd04 */
        l_0x1007_fcea:
            ii(0x1007_fcea, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1007_fced, 4);  cmp(ax, memw[ss, ebp - 88]);          /* cmp ax, [ebp-0x58] */
            ii(0x1007_fcf1, 2);  if(jnz(0x1007_fd02, 0xf)) goto l_0x1007_fd02;/* jnz 0x1007fd02 */
            ii(0x1007_fcf3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fcf6, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_fcf9, 5);  call(0x1015_2a52, 0xd_2d54);          /* call 0x10152a52 */
            ii(0x1007_fcfe, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fd00, 2);  if(jz(0x1007_fd04, 2)) goto l_0x1007_fd04;/* jz 0x1007fd04 */
        l_0x1007_fd02:
            ii(0x1007_fd02, 2);  jmp(0x1007_fd15, 0x11); goto l_0x1007_fd15;/* jmp 0x1007fd15 */
        l_0x1007_fd04:
            ii(0x1007_fd04, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fd07, 5);  call(0x1007_63d4, -0x9938);           /* call 0x100763d4 */
            ii(0x1007_fd0c, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1007_fd0f, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1007_fd12, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
        l_0x1007_fd15:
            ii(0x1007_fd15, 5);  jmp(0x1007_fade, -0x23c); goto l_0x1007_fade;/* jmp 0x1007fade */
        l_0x1007_fd1a:
            ii(0x1007_fd1a, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1007_fd1e, 6);  if(jnz(0x1007_fec9, 0x1a5)) goto l_0x1007_fec9;/* jnz 0x1007fec9 */
            ii(0x1007_fd24, 4);  cmp(memb[ss, ebp - 56], 0);           /* cmp byte [ebp-0x38], 0x0 */
            ii(0x1007_fd28, 6);  if(jnz(0x1007_feb2, 0x184)) goto l_0x1007_feb2;/* jnz 0x1007feb2 */
            ii(0x1007_fd2e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fd31, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1007_fd34, 5);  call(0x1007_6338, -0x9a01);           /* call 0x10076338 */
            ii(0x1007_fd39, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_fd3c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fd3e, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_fd40, 5);  call(0x1007_643c, -0x9909);           /* call 0x1007643c */
            ii(0x1007_fd45, 2);  jmp(0x1007_fd4f, 8); goto l_0x1007_fd4f;/* jmp 0x1007fd4f */
        l_0x1007_fd47:
            ii(0x1007_fd47, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fd4a, 5);  call(0x1007_6bf8, -0x9157);           /* call 0x10076bf8 */
        l_0x1007_fd4f:
            ii(0x1007_fd4f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fd51, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fd54, 5);  call(0x1013_ad71, 0xb_b018);          /* call 0x1013ad71 */
            ii(0x1007_fd59, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fd5b, 6);  if(jz(0x1007_fdf0, 0x8f)) goto l_0x1007_fdf0;/* jz 0x1007fdf0 */
            ii(0x1007_fd61, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1007_fd66, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fd69, 5);  call(0x1007_63d4, -0x999a);           /* call 0x100763d4 */
            ii(0x1007_fd6e, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1007_fd71, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fd73, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1007_fd75, 5);  call(0x100a_346a, 0x2_36f0);          /* call 0x100a346a */
            ii(0x1007_fd7a, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fd7c, 2);  if(jz(0x1007_fdeb, 0x6d)) goto l_0x1007_fdeb;/* jz 0x1007fdeb */
            ii(0x1007_fd7e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fd81, 5);  call(0x1008_ad28, 0xafa2);            /* call 0x1008ad28 */
            ii(0x1007_fd86, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fd88, 2);  if(jnz(0x1007_fddc, 0x52)) goto l_0x1007_fddc;/* jnz 0x1007fddc */
            ii(0x1007_fd8a, 5);  call(0x1008_a7bc, 0xaa2d);            /* call 0x1008a7bc */
            ii(0x1007_fd8f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_fd94, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1007_fd97, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1007_fd9c, 5);  call(Definitions.sys_new, 0xe_605f);  /* call 0x10165e00 */
            ii(0x1007_fda1, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x1007_fda4, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_fda7, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1007_fdaa, 4);  cmp(memd[ss, ebp - 100], 0);          /* cmp dword [ebp-0x64], 0x0 */
            ii(0x1007_fdae, 2);  if(jz(0x1007_fdc6, 0x16)) goto l_0x1007_fdc6;/* jz 0x1007fdc6 */
            ii(0x1007_fdb0, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fdb3, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_fdb6, 5);  call(Definitions.my_ctor_c11, 0x2_3b0e);/* call 0x100a38c9 */
            ii(0x1007_fdbb, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x1007_fdbe, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x1007_fdc1, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1007_fdc4, 2);  jmp(0x1007_fdcc, 6); goto l_0x1007_fdcc;/* jmp 0x1007fdcc */
        l_0x1007_fdc6:
            ii(0x1007_fdc6, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x1007_fdc9, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
        l_0x1007_fdcc:
            ii(0x1007_fdcc, 3);  mov(edx, memd[ss, ebp - 108]);        /* mov edx, [ebp-0x6c] */
            ii(0x1007_fdcf, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_fdd4, 3);  mov(ebx, memd[ss, ebp - 92]);         /* mov ebx, [ebp-0x5c] */
            ii(0x1007_fdd7, 5);  call(0x100a_4db6, 0x2_4fda);          /* call 0x100a4db6 */
        l_0x1007_fddc:
            ii(0x1007_fddc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fdde, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fde1, 5);  call(0x1007_5f6c, -0x9e7a);           /* call 0x10075f6c */
            ii(0x1007_fde6, 5);  jmp(0x1008_0399, 0x5ae); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1007_fdeb:
            ii(0x1007_fdeb, 5);  jmp(0x1007_fd47, -0xa9); goto l_0x1007_fd47;/* jmp 0x1007fd47 */
        l_0x1007_fdf0:
            ii(0x1007_fdf0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fdf3, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_fdf6, 5);  call(0x1007_6338, -0x9ac3);           /* call 0x10076338 */
            ii(0x1007_fdfb, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_fdfe, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fe00, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_fe02, 5);  call(0x1007_643c, -0x99cb);           /* call 0x1007643c */
            ii(0x1007_fe07, 2);  jmp(0x1007_fe11, 8); goto l_0x1007_fe11;/* jmp 0x1007fe11 */
        l_0x1007_fe09:
            ii(0x1007_fe09, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fe0c, 5);  call(0x1007_6bf8, -0x9219);           /* call 0x10076bf8 */
        l_0x1007_fe11:
            ii(0x1007_fe11, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fe13, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fe16, 5);  call(0x1013_ad71, 0xb_af56);          /* call 0x1013ad71 */
            ii(0x1007_fe1b, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fe1d, 6);  if(jz(0x1007_feb2, 0x8f)) goto l_0x1007_feb2;/* jz 0x1007feb2 */
            ii(0x1007_fe23, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1007_fe28, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fe2b, 5);  call(0x1007_63d4, -0x9a5c);           /* call 0x100763d4 */
            ii(0x1007_fe30, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1007_fe33, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_fe35, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1007_fe37, 5);  call(0x100a_346a, 0x2_362e);          /* call 0x100a346a */
            ii(0x1007_fe3c, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fe3e, 2);  if(jz(0x1007_fead, 0x6d)) goto l_0x1007_fead;/* jz 0x1007fead */
            ii(0x1007_fe40, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_fe43, 5);  call(0x1008_ad28, 0xaee0);            /* call 0x1008ad28 */
            ii(0x1007_fe48, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fe4a, 2);  if(jnz(0x1007_fe9e, 0x52)) goto l_0x1007_fe9e;/* jnz 0x1007fe9e */
            ii(0x1007_fe4c, 5);  call(0x1008_a7bc, 0xa96b);            /* call 0x1008a7bc */
            ii(0x1007_fe51, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_fe56, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x1007_fe59, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1007_fe5e, 5);  call(Definitions.sys_new, 0xe_5f9d);  /* call 0x10165e00 */
            ii(0x1007_fe63, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x1007_fe66, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x1007_fe69, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x1007_fe6c, 4);  cmp(memd[ss, ebp - 120], 0);          /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1007_fe70, 2);  if(jz(0x1007_fe88, 0x16)) goto l_0x1007_fe88;/* jz 0x1007fe88 */
            ii(0x1007_fe72, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fe75, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x1007_fe78, 5);  call(Definitions.my_ctor_c11, 0x2_3a4c);/* call 0x100a38c9 */
            ii(0x1007_fe7d, 3);  mov(memd[ss, ebp - 124], eax);        /* mov [ebp-0x7c], eax */
            ii(0x1007_fe80, 3);  mov(eax, memd[ss, ebp - 124]);        /* mov eax, [ebp-0x7c] */
            ii(0x1007_fe83, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
            ii(0x1007_fe86, 2);  jmp(0x1007_fe8e, 6); goto l_0x1007_fe8e;/* jmp 0x1007fe8e */
        l_0x1007_fe88:
            ii(0x1007_fe88, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1007_fe8b, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
        l_0x1007_fe8e:
            ii(0x1007_fe8e, 3);  mov(edx, memd[ss, ebp - 128]);        /* mov edx, [ebp-0x80] */
            ii(0x1007_fe91, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_fe96, 3);  mov(ebx, memd[ss, ebp - 112]);        /* mov ebx, [ebp-0x70] */
            ii(0x1007_fe99, 5);  call(0x100a_4db6, 0x2_4f18);          /* call 0x100a4db6 */
        l_0x1007_fe9e:
            ii(0x1007_fe9e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_fea0, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fea3, 5);  call(0x1007_5f6c, -0x9f3c);           /* call 0x10075f6c */
            ii(0x1007_fea8, 5);  jmp(0x1008_0399, 0x4ec); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1007_fead:
            ii(0x1007_fead, 5);  jmp(0x1007_fe09, -0xa9); goto l_0x1007_fe09;/* jmp 0x1007fe09 */
        l_0x1007_feb2:
            ii(0x1007_feb2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_feb5, 5);  call(0x1007_f659, -0x861);            /* call 0x1007f659 */
            ii(0x1007_feba, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_febc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_febf, 5);  call(0x1007_5f6c, -0x9f58);           /* call 0x10075f6c */
            ii(0x1007_fec4, 5);  jmp(0x1008_0399, 0x4d0); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1007_fec9:
            ii(0x1007_fec9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_fecc, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_fecf, 5);  call(0x1015_2a52, 0xd_2b7e);          /* call 0x10152a52 */
            ii(0x1007_fed4, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fed6, 2);  if(jnz(0x1007_fee7, 0xf)) goto l_0x1007_fee7;/* jnz 0x1007fee7 */
            ii(0x1007_fed8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_feda, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_fedd, 5);  call(0x1007_5f6c, -0x9f76);           /* call 0x10075f6c */
            ii(0x1007_fee2, 5);  jmp(0x1008_0399, 0x4b2); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1007_fee7:
            ii(0x1007_fee7, 6);  lea(eax, memd[ss, ebp - 132]);        /* lea eax, [ebp-0x84] */
            ii(0x1007_feed, 5);  call(Definitions.my_ctor_0x101b_4184, -0x9402);/* call 0x10076af0 */
            ii(0x1007_fef2, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_fef5, 5);  call(0x1007_623c, -0x9cbe);           /* call 0x1007623c */
            ii(0x1007_fefa, 4);  cmp(memb[ds, eax + 22], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_fefe, 2);  if(jz(0x1007_ff0f, 0xf)) goto l_0x1007_ff0f;/* jz 0x1007ff0f */
            ii(0x1007_ff00, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1007_ff05, 5);  call(0x1007_5fdc, -0x9f2e);           /* call 0x10075fdc */
            ii(0x1007_ff0a, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1007_ff0d, 2);  if(jge(0x1007_ff11, 2)) goto l_0x1007_ff11;/* jge 0x1007ff11 */
        l_0x1007_ff0f:
            ii(0x1007_ff0f, 2);  jmp(0x1007_ff17, 6); goto l_0x1007_ff17;/* jmp 0x1007ff17 */
        l_0x1007_ff11:
            ii(0x1007_ff11, 4);  mov(memb[ss, ebp - 60], 1);           /* mov byte [ebp-0x3c], 0x1 */
            ii(0x1007_ff15, 2);  jmp(0x1007_ff1b, 4); goto l_0x1007_ff1b;/* jmp 0x1007ff1b */
        l_0x1007_ff17:
            ii(0x1007_ff17, 4);  mov(memb[ss, ebp - 60], 2);           /* mov byte [ebp-0x3c], 0x2 */
        l_0x1007_ff1b:
            ii(0x1007_ff1b, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_ff1e, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_ff21, 5);  call(0x1007_78a5, -0x8681);           /* call 0x100778a5 */
            ii(0x1007_ff26, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_ff28, 2);  if(jz(0x1007_ff4e, 0x24)) goto l_0x1007_ff4e;/* jz 0x1007ff4e */
            ii(0x1007_ff2a, 4);  movsx(eax, memb[ss, ebp - 60]);       /* movsx eax, byte [ebp-0x3c] */
            ii(0x1007_ff2e, 1);  push(eax);                            /* push eax */
            ii(0x1007_ff2f, 6);  lea(ecx, memd[ss, ebp - 136]);        /* lea ecx, [ebp-0x88] */
            ii(0x1007_ff35, 6);  lea(ebx, memd[ss, ebp - 132]);        /* lea ebx, [ebp-0x84] */
            ii(0x1007_ff3b, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_ff3e, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_ff41, 5);  call(0x1007_70e1, -0x8e65);           /* call 0x100770e1 */
            ii(0x1007_ff46, 3);  mov(memb[ss, ebp - 52], al);          /* mov [ebp-0x34], al */
            ii(0x1007_ff49, 5);  jmp(0x1007_ffe6, 0x98); goto l_0x1007_ffe6;/* jmp 0x1007ffe6 */
        l_0x1007_ff4e:
            ii(0x1007_ff4e, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_ff51, 5);  call(0x1007_623c, -0x9d1a);           /* call 0x1007623c */
            ii(0x1007_ff56, 4);  mov(ax, memw[ds, eax + 18]);          /* mov ax, [eax+0x12] */
            ii(0x1007_ff5a, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
            ii(0x1007_ff60, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ff63, 3);  mov(edx, memd[ds, eax + 7]);          /* mov edx, [eax+0x7] */
            ii(0x1007_ff66, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_ff69, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ff6c, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1007_ff6f, 5);  call(0x1008_a228, 0xa2b4);            /* call 0x1008a228 */
            ii(0x1007_ff74, 5);  call(0x1008_a370, 0xa3f7);            /* call 0x1008a370 */
            ii(0x1007_ff79, 5);  call(0x1007_6074, -0x9f0a);           /* call 0x10076074 */
            ii(0x1007_ff7e, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_ff80, 2);  if(jnz(0x1007_ffa2, 0x20)) goto l_0x1007_ffa2;/* jnz 0x1007ffa2 */
            ii(0x1007_ff82, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_ff85, 5);  call(0x1007_623c, -0x9d4e);           /* call 0x1007623c */
            ii(0x1007_ff8a, 3);  mov(edx, memd[ds, eax + 21]);         /* mov edx, [eax+0x15] */
            ii(0x1007_ff8d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_ff90, 7);  movsx(eax, memw[ss, ebp - 140]);      /* movsx eax, word [ebp-0x8c] */
            ii(0x1007_ff97, 5);  call(Definitions.my_min, 0x97e8);     /* call 0x10089784 */
            ii(0x1007_ff9c, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
        l_0x1007_ffa2:
            ii(0x1007_ffa2, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1007_ffa7, 1);  push(eax);                            /* push eax */
            ii(0x1007_ffa8, 7);  movsx(eax, memw[ss, ebp - 140]);      /* movsx eax, word [ebp-0x8c] */
            ii(0x1007_ffaf, 1);  push(eax);                            /* push eax */
            ii(0x1007_ffb0, 4);  movsx(eax, memb[ss, ebp - 60]);       /* movsx eax, byte [ebp-0x3c] */
            ii(0x1007_ffb4, 1);  push(eax);                            /* push eax */
            ii(0x1007_ffb5, 6);  lea(ecx, memd[ss, ebp - 136]);        /* lea ecx, [ebp-0x88] */
            ii(0x1007_ffbb, 6);  lea(ebx, memd[ss, ebp - 132]);        /* lea ebx, [ebp-0x84] */
            ii(0x1007_ffc1, 6);  lea(edx, memd[ss, ebp - 144]);        /* lea edx, [ebp-0x90] */
            ii(0x1007_ffc7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ffca, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1007_ffcd, 5);  call(0x1008_a228, 0xa256);            /* call 0x1008a228 */
            ii(0x1007_ffd2, 5);  call(0x100b_8e63, 0x3_8e8c);          /* call 0x100b8e63 */
            ii(0x1007_ffd7, 3);  mov(esi, memd[ss, ebp - 64]);         /* mov esi, [ebp-0x40] */
            ii(0x1007_ffda, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_ffdc, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1007_ffde, 5);  call(0x1007_7381, -0x8c62);           /* call 0x10077381 */
            ii(0x1007_ffe3, 3);  mov(memb[ss, ebp - 52], al);          /* mov [ebp-0x34], al */
        l_0x1007_ffe6:
            ii(0x1007_ffe6, 4);  cmp(memb[ss, ebp - 52], 0);           /* cmp byte [ebp-0x34], 0x0 */
            ii(0x1007_ffea, 2);  if(jz(0x1007_fffb, 0xf)) goto l_0x1007_fffb;/* jz 0x1007fffb */
            ii(0x1007_ffec, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_ffef, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_fff2, 5);  call(0x1007_6f5d, -0x909a);           /* call 0x10076f5d */
            ii(0x1007_fff7, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_fff9, 2);  if(jz(0x1008_0000, 5)) goto l_0x1008_0000;/* jz 0x10080000 */
        l_0x1007_fffb:
            ii(0x1007_fffb, 5);  jmp(0x1008_01ad, 0x1ad); goto l_0x1008_01ad;/* jmp 0x100801ad */
        l_0x1008_0000:
            ii(0x1008_0000, 10);  mov(memd[ss, ebp - 148], 0);         /* mov dword [ebp-0x94], 0x0 */
            ii(0x1008_000a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_000d, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1008_0010, 5);  call(0x1007_6338, -0x9cdd);           /* call 0x10076338 */
            ii(0x1008_0015, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_0018, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_001a, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_001c, 5);  call(0x1007_643c, -0x9be5);           /* call 0x1007643c */
            ii(0x1008_0021, 2);  jmp(0x1008_002b, 8); goto l_0x1008_002b;/* jmp 0x1008002b */
        l_0x1008_0023:
            ii(0x1008_0023, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0026, 5);  call(0x1007_6bf8, -0x9433);           /* call 0x10076bf8 */
        l_0x1008_002b:
            ii(0x1008_002b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_002d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0030, 5);  call(0x1013_ad71, 0xb_ad3c);          /* call 0x1013ad71 */
            ii(0x1008_0035, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_0037, 2);  if(jz(0x1008_0061, 0x28)) goto l_0x1008_0061;/* jz 0x10080061 */
            ii(0x1008_0039, 4);  movsx(ebx, memb[ss, ebp - 60]);       /* movsx ebx, byte [ebp-0x3c] */
            ii(0x1008_003d, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_0040, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0043, 5);  call(0x1007_63d4, -0x9c74);           /* call 0x100763d4 */
            ii(0x1008_0048, 5);  call(0x100c_0532, 0x4_04e5);          /* call 0x100c0532 */
            ii(0x1008_004d, 6);  mov(memd[ss, ebp - 152], eax);        /* mov [ebp-0x98], eax */
            ii(0x1008_0053, 6);  mov(eax, memd[ss, ebp - 152]);        /* mov eax, [ebp-0x98] */
            ii(0x1008_0059, 6);  add(memd[ss, ebp - 148], eax);        /* add [ebp-0x94], eax */
            ii(0x1008_005f, 2);  jmp(0x1008_0023, -0x3e); goto l_0x1008_0023;/* jmp 0x10080023 */
        l_0x1008_0061:
            ii(0x1008_0061, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1008_0066, 1);  push(eax);                            /* push eax */
            ii(0x1008_0067, 4);  movsx(ecx, memb[ss, ebp - 60]);       /* movsx ecx, byte [ebp-0x3c] */
            ii(0x1008_006b, 6);  lea(edx, memd[ss, ebp - 132]);        /* lea edx, [ebp-0x84] */
            ii(0x1008_0071, 6);  lea(eax, memd[ss, ebp - 156]);        /* lea eax, [ebp-0x9c] */
            ii(0x1008_0077, 5);  call(0x1007_5e64, -0xa218);           /* call 0x10075e64 */
            ii(0x1008_007c, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1008_007e, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_0081, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0084, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_0087, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_008a, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x1008_0090, 5);  mov(esi, 0x101c_31c4);                /* mov esi, 0x101c31c4 */
            ii(0x1008_0095, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1008_0097, 5);  call(0x100c_20df, 0x4_2043);          /* call 0x100c20df */
            ii(0x1008_009c, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x1008_00a2, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1008_00a7, 1);  push(eax);                            /* push eax */
            ii(0x1008_00a8, 7);  movsx(eax, memw[ss, ebp - 148]);      /* movsx eax, word [ebp-0x94] */
            ii(0x1008_00af, 1);  push(eax);                            /* push eax */
            ii(0x1008_00b0, 4);  movsx(ecx, memb[ss, ebp - 60]);       /* movsx ecx, byte [ebp-0x3c] */
            ii(0x1008_00b4, 7);  movsx(ebx, memw[ss, ebp - 136]);      /* movsx ebx, word [ebp-0x88] */
            ii(0x1008_00bb, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_00be, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_00c1, 5);  call(0x1007_7ff6, -0x80d0);           /* call 0x10077ff6 */
            ii(0x1008_00c6, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_00c8, 6);  if(jnz(0x1008_01ad, 0xdf)) goto l_0x1008_01ad;/* jnz 0x100801ad */
            ii(0x1008_00ce, 4);  mov(memb[ss, ebp - 52], 0);           /* mov byte [ebp-0x34], 0x0 */
            ii(0x1008_00d2, 4);  cmp(memb[ss, ebp - 60], 1);           /* cmp byte [ebp-0x3c], 0x1 */
            ii(0x1008_00d6, 6);  if(jnz(0x1008_01ad, 0xd1)) goto l_0x1008_01ad;/* jnz 0x100801ad */
            ii(0x1008_00dc, 10);  mov(memd[ss, ebp - 148], 0);         /* mov dword [ebp-0x94], 0x0 */
            ii(0x1008_00e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_00e9, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1008_00ec, 5);  call(0x1007_6338, -0x9db9);           /* call 0x10076338 */
            ii(0x1008_00f1, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_00f4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_00f6, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_00f8, 5);  call(0x1007_643c, -0x9cc1);           /* call 0x1007643c */
            ii(0x1008_00fd, 2);  jmp(0x1008_0107, 8); goto l_0x1008_0107;/* jmp 0x10080107 */
        l_0x1008_00ff:
            ii(0x1008_00ff, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0102, 5);  call(0x1007_6bf8, -0x950f);           /* call 0x10076bf8 */
        l_0x1008_0107:
            ii(0x1008_0107, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_0109, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_010c, 5);  call(0x1013_ad71, 0xb_ac60);          /* call 0x1013ad71 */
            ii(0x1008_0111, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_0113, 2);  if(jz(0x1008_013e, 0x29)) goto l_0x1008_013e;/* jz 0x1008013e */
            ii(0x1008_0115, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1008_011a, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_011d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0120, 5);  call(0x1007_63d4, -0x9d51);           /* call 0x100763d4 */
            ii(0x1008_0125, 5);  call(0x100c_0532, 0x4_0408);          /* call 0x100c0532 */
            ii(0x1008_012a, 6);  mov(memd[ss, ebp - 152], eax);        /* mov [ebp-0x98], eax */
            ii(0x1008_0130, 6);  mov(eax, memd[ss, ebp - 152]);        /* mov eax, [ebp-0x98] */
            ii(0x1008_0136, 6);  add(memd[ss, ebp - 148], eax);        /* add [ebp-0x94], eax */
            ii(0x1008_013c, 2);  jmp(0x1008_00ff, -0x3f); goto l_0x1008_00ff;/* jmp 0x100800ff */
        l_0x1008_013e:
            ii(0x1008_013e, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1008_0143, 1);  push(eax);                            /* push eax */
            ii(0x1008_0144, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1008_0149, 6);  lea(edx, memd[ss, ebp - 132]);        /* lea edx, [ebp-0x84] */
            ii(0x1008_014f, 6);  lea(eax, memd[ss, ebp - 160]);        /* lea eax, [ebp-0xa0] */
            ii(0x1008_0155, 5);  call(0x1007_5e64, -0xa2f6);           /* call 0x10075e64 */
            ii(0x1008_015a, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1008_015c, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_015f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0162, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_0165, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_0168, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x1008_016e, 5);  mov(esi, 0x101c_31c4);                /* mov esi, 0x101c31c4 */
            ii(0x1008_0173, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1008_0175, 5);  call(0x100c_20df, 0x4_1f65);          /* call 0x100c20df */
            ii(0x1008_017a, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x1008_0180, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1008_0185, 1);  push(eax);                            /* push eax */
            ii(0x1008_0186, 7);  movsx(eax, memw[ss, ebp - 148]);      /* movsx eax, word [ebp-0x94] */
            ii(0x1008_018d, 1);  push(eax);                            /* push eax */
            ii(0x1008_018e, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1008_0193, 7);  movsx(ebx, memw[ss, ebp - 136]);      /* movsx ebx, word [ebp-0x88] */
            ii(0x1008_019a, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_019d, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_01a0, 5);  call(0x1007_7ff6, -0x81af);           /* call 0x10077ff6 */
            ii(0x1008_01a5, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_01a7, 2);  if(jz(0x1008_01ad, 4)) goto l_0x1008_01ad;/* jz 0x100801ad */
            ii(0x1008_01a9, 4);  mov(memb[ss, ebp - 52], 1);           /* mov byte [ebp-0x34], 0x1 */
        l_0x1008_01ad:
            ii(0x1008_01ad, 4);  cmp(memb[ss, ebp - 52], 0);           /* cmp byte [ebp-0x34], 0x0 */
            ii(0x1008_01b1, 6);  if(jnz(0x1008_026b, 0xb4)) goto l_0x1008_026b;/* jnz 0x1008026b */
            ii(0x1008_01b7, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_01ba, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_01bd, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1008_01c0, 5);  call(0x1008_aab4, 0xa8ef);            /* call 0x1008aab4 */
            ii(0x1008_01c5, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_01c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_01cb, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1008_01ce, 5);  call(0x1008_ab1c, 0xa949);            /* call 0x1008ab1c */
            ii(0x1008_01d3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_01d6, 5);  call(0x1008_ad28, 0xab4d);            /* call 0x1008ad28 */
            ii(0x1008_01db, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_01dd, 6);  if(jnz(0x1008_025c, 0x79)) goto l_0x1008_025c;/* jnz 0x1008025c */
            ii(0x1008_01e3, 5);  call(0x1008_a7bc, 0xa5d4);            /* call 0x1008a7bc */
            ii(0x1008_01e8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_01ed, 6);  mov(memd[ss, ebp - 164], eax);        /* mov [ebp-0xa4], eax */
            ii(0x1008_01f3, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1008_01f8, 5);  call(Definitions.sys_new, 0xe_5c03);  /* call 0x10165e00 */
            ii(0x1008_01fd, 6);  mov(memd[ss, ebp - 168], eax);        /* mov [ebp-0xa8], eax */
            ii(0x1008_0203, 6);  mov(eax, memd[ss, ebp - 168]);        /* mov eax, [ebp-0xa8] */
            ii(0x1008_0209, 6);  mov(memd[ss, ebp - 172], eax);        /* mov [ebp-0xac], eax */
            ii(0x1008_020f, 7);  cmp(memd[ss, ebp - 172], 0);          /* cmp dword [ebp-0xac], 0x0 */
            ii(0x1008_0216, 2);  if(jz(0x1008_023a, 0x22)) goto l_0x1008_023a;/* jz 0x1008023a */
            ii(0x1008_0218, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_021b, 6);  mov(eax, memd[ss, ebp - 168]);        /* mov eax, [ebp-0xa8] */
            ii(0x1008_0221, 5);  call(Definitions.my_ctor_c11, 0x2_36a3);/* call 0x100a38c9 */
            ii(0x1008_0226, 6);  mov(memd[ss, ebp - 176], eax);        /* mov [ebp-0xb0], eax */
            ii(0x1008_022c, 6);  mov(eax, memd[ss, ebp - 176]);        /* mov eax, [ebp-0xb0] */
            ii(0x1008_0232, 6);  mov(memd[ss, ebp - 180], eax);        /* mov [ebp-0xb4], eax */
            ii(0x1008_0238, 2);  jmp(0x1008_0246, 0xc); goto l_0x1008_0246;/* jmp 0x10080246 */
        l_0x1008_023a:
            ii(0x1008_023a, 6);  mov(eax, memd[ss, ebp - 172]);        /* mov eax, [ebp-0xac] */
            ii(0x1008_0240, 6);  mov(memd[ss, ebp - 180], eax);        /* mov [ebp-0xb4], eax */
        l_0x1008_0246:
            ii(0x1008_0246, 6);  mov(edx, memd[ss, ebp - 180]);        /* mov edx, [ebp-0xb4] */
            ii(0x1008_024c, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_0251, 6);  mov(ebx, memd[ss, ebp - 164]);        /* mov ebx, [ebp-0xa4] */
            ii(0x1008_0257, 5);  call(0x100a_4db6, 0x2_4b5a);          /* call 0x100a4db6 */
        l_0x1008_025c:
            ii(0x1008_025c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_025e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0261, 5);  call(0x1007_5f6c, -0xa2fa);           /* call 0x10075f6c */
            ii(0x1008_0266, 5);  jmp(0x1008_0399, 0x12e); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1008_026b:
            ii(0x1008_026b, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_026e, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1008_0272, 7);  cmp(ax, memw[ss, ebp - 132]);         /* cmp ax, [ebp-0x84] */
            ii(0x1008_0279, 2);  if(jnz(0x1008_028f, 0x14)) goto l_0x1008_028f;/* jnz 0x1008028f */
            ii(0x1008_027b, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_027e, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1008_0282, 7);  cmp(ax, memw[ss, ebp - 130]);         /* cmp ax, [ebp-0x82] */
            ii(0x1008_0289, 6);  if(jz(0x1008_038a, 0xfb)) goto l_0x1008_038a;/* jz 0x1008038a */
        l_0x1008_028f:
            ii(0x1008_028f, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1008_0294, 5);  call(Definitions.sys_new, 0xe_5b67);  /* call 0x10165e00 */
            ii(0x1008_0299, 6);  mov(memd[ss, ebp - 184], eax);        /* mov [ebp-0xb8], eax */
            ii(0x1008_029f, 6);  mov(eax, memd[ss, ebp - 184]);        /* mov eax, [ebp-0xb8] */
            ii(0x1008_02a5, 6);  mov(memd[ss, ebp - 188], eax);        /* mov [ebp-0xbc], eax */
            ii(0x1008_02ab, 7);  cmp(memd[ss, ebp - 188], 0);          /* cmp dword [ebp-0xbc], 0x0 */
            ii(0x1008_02b2, 2);  if(jz(0x1008_02f6, 0x42)) goto l_0x1008_02f6;/* jz 0x100802f6 */
            ii(0x1008_02b4, 5);  mov(eax, 0x1007_f603);                /* mov eax, 0x1007f603 */
            ii(0x1008_02b9, 1);  push(eax);                            /* push eax */
            ii(0x1008_02ba, 6);  lea(edx, memd[ss, ebp - 132]);        /* lea edx, [ebp-0x84] */
            ii(0x1008_02c0, 6);  lea(eax, memd[ss, ebp - 192]);        /* lea eax, [ebp-0xc0] */
            ii(0x1008_02c6, 5);  call(0x1007_5e64, -0xa467);           /* call 0x10075e64 */
            ii(0x1008_02cb, 1);  push(eax);                            /* push eax */
            ii(0x1008_02cc, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_02ce, 1);  push(eax);                            /* push eax */
            ii(0x1008_02cf, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1008_02d1, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_02d4, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_02d7, 6);  mov(eax, memd[ss, ebp - 184]);        /* mov eax, [ebp-0xb8] */
            ii(0x1008_02dd, 5);  call(0x100a_c220, 0x2_bf3e);          /* call 0x100ac220 */
            ii(0x1008_02e2, 6);  mov(memd[ss, ebp - 196], eax);        /* mov [ebp-0xc4], eax */
            ii(0x1008_02e8, 6);  mov(eax, memd[ss, ebp - 196]);        /* mov eax, [ebp-0xc4] */
            ii(0x1008_02ee, 6);  mov(memd[ss, ebp - 200], eax);        /* mov [ebp-0xc8], eax */
            ii(0x1008_02f4, 2);  jmp(0x1008_0302, 0xc); goto l_0x1008_0302;/* jmp 0x10080302 */
        l_0x1008_02f6:
            ii(0x1008_02f6, 6);  mov(eax, memd[ss, ebp - 188]);        /* mov eax, [ebp-0xbc] */
            ii(0x1008_02fc, 6);  mov(memd[ss, ebp - 200], eax);        /* mov [ebp-0xc8], eax */
        l_0x1008_0302:
            ii(0x1008_0302, 6);  mov(edx, memd[ss, ebp - 200]);        /* mov edx, [ebp-0xc8] */
            ii(0x1008_0308, 6);  lea(eax, memd[ss, ebp - 204]);        /* lea eax, [ebp-0xcc] */
            ii(0x1008_030e, 5);  call(0x1008_a5f0, 0xa2dd);            /* call 0x1008a5f0 */
            ii(0x1008_0313, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_0318, 6);  lea(eax, memd[ss, ebp - 204]);        /* lea eax, [ebp-0xcc] */
            ii(0x1008_031e, 5);  call(0x1008_a520, 0xa1fd);            /* call 0x1008a520 */
            ii(0x1008_0323, 5);  call(0x1008_a674, 0xa34c);            /* call 0x1008a674 */
            ii(0x1008_0328, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_032d, 6);  lea(eax, memd[ss, ebp - 204]);        /* lea eax, [ebp-0xcc] */
            ii(0x1008_0333, 5);  call(0x1008_a520, 0xa1e8);            /* call 0x1008a520 */
            ii(0x1008_0338, 5);  call(0x1008_a6a4, 0xa367);            /* call 0x1008a6a4 */
            ii(0x1008_033d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0340, 4);  mov(memb[ds, eax + 19], 1);           /* mov byte [eax+0x13], 0x1 */
            ii(0x1008_0344, 6);  lea(eax, memd[ss, ebp - 204]);        /* lea eax, [ebp-0xcc] */
            ii(0x1008_034a, 5);  call(0x1008_a57c, 0xa22d);            /* call 0x1008a57c */
            ii(0x1008_034f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_0351, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_0356, 5);  call(0x100a_4d50, 0x2_49f5);          /* call 0x100a4d50 */
            ii(0x1008_035b, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1008_035f, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1008_0362, 2);  if(jle(0x1008_0371, 0xd)) goto l_0x1008_0371;/* jle 0x10080371 */
            ii(0x1008_0364, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_0369, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_036c, 5);  call(0x100a_28ff, 0x2_258e);          /* call 0x100a28ff */
        l_0x1008_0371:
            ii(0x1008_0371, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_0373, 6);  lea(eax, memd[ss, ebp - 204]);        /* lea eax, [ebp-0xcc] */
            ii(0x1008_0379, 5);  call(0x1008_8d4c, 0x89ce);            /* call 0x10088d4c */
            ii(0x1008_037e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_0380, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0383, 5);  call(0x1007_5f6c, -0xa41c);           /* call 0x10075f6c */
            ii(0x1008_0388, 2);  jmp(0x1008_0399, 0xf); goto l_0x1008_0399;/* jmp 0x10080399 */
        l_0x1008_038a:
            ii(0x1008_038a, 5);  jmp(0x1007_faa6, -0x8e9); goto l_0x1007_faa6;/* jmp 0x1007faa6 */
        l_0x1008_038f:
            ii(0x1008_038f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_0391, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_0394, 5);  call(0x1007_5f6c, -0xa42d);           /* call 0x10075f6c */
        l_0x1008_0399:
            ii(0x1008_0399, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_039b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_039c, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_039d, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_039e, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_039f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_03a0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_03a1, 1);  ret();                                /* ret */
        }
    }
}
