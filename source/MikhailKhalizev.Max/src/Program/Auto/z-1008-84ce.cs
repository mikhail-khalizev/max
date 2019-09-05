using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_84ce-1181bcc2")]
        public void Method_1008_84ce()
        {
            ii(0x1008_84ce, 5);  push(0xb4);                           /* push 0xb4 */
            ii(0x1008_84d3, 5);  call(Definitions.sys_check_available_stack_size, 0xd_d87a);/* call 0x10165d52 */
            ii(0x1008_84d8, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_84d9, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_84da, 1);  push(esi);                            /* push esi */
            ii(0x1008_84db, 1);  push(edi);                            /* push edi */
            ii(0x1008_84dc, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_84dd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_84df, 6);  sub(esp, 0x90);                       /* sub esp, 0x90 */
            ii(0x1008_84e5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_84e8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_84eb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_84ee, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_84f1, 5);  call(0x1007_65d0, -0x1_1f26);         /* call 0x100765d0 */
            ii(0x1008_84f6, 5);  call(0x100a_2edb, 0x1_a9e0);          /* call 0x100a2edb */
            ii(0x1008_84fb, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_84fd, 2);  if(jnz(0x1008_8510, 0x11)) goto l_0x1008_8510;/* jnz 0x10088510 */
            ii(0x1008_84ff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8502, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_8505, 5);  call(0x1007_6574, -0x1_1f96);         /* call 0x10076574 */
            ii(0x1008_850a, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1008_850e, 2);  if(jnz(0x1008_8512, 2)) goto l_0x1008_8512;/* jnz 0x10088512 */
        l_0x1008_8510:
            ii(0x1008_8510, 2);  jmp(0x1008_851b, 9); goto l_0x1008_851b;/* jmp 0x1008851b */
        l_0x1008_8512:
            ii(0x1008_8512, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_8516, 5);  jmp(0x1008_89b7, 0x49c); goto l_0x1008_89b7;/* jmp 0x100889b7 */
        l_0x1008_851b:
            ii(0x1008_851b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_851e, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_8521, 5);  call(0x1007_6574, -0x1_1fb2);         /* call 0x10076574 */
            ii(0x1008_8526, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1008_8529, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1008_852c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_852f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_8532, 5);  call(0x1007_6574, -0x1_1fc3);         /* call 0x10076574 */
            ii(0x1008_8537, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1008_853a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_853d, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1008_8540, 5);  call(0x1007_6aac, -0x1_1a99);         /* call 0x10076aac */
            ii(0x1008_8545, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_8548, 3);  mov(ebx, memd[ds, ebx + 26]);         /* mov ebx, [ebx+0x1a] */
            ii(0x1008_854b, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1008_854e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_8551, 3);  mov(edx, memd[ds, edx + 24]);         /* mov edx, [edx+0x18] */
            ii(0x1008_8554, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_8557, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_855a, 5);  call(0x1007_6aac, -0x1_1ab3);         /* call 0x10076aac */
            ii(0x1008_855f, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_8562, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_1a77);/* call 0x10076af0 */
            ii(0x1008_8567, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_856a, 3);  mov(edx, memd[ds, edx + 7]);          /* mov edx, [edx+0x7] */
            ii(0x1008_856d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_8570, 6);  imul(edx, edx, 0xc5);                 /* imul edx, edx, 0xc5 */
            ii(0x1008_8576, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x1008_857b, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_857d, 5);  call(0x1008_a0c8, 0x1b46);            /* call 0x1008a0c8 */
            ii(0x1008_8582, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1008_8585, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1008_8587, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1008_858c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_858f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8592, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_8595, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_8598, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x1008_859e, 5);  mov(esi, 0x101c_31c4);                /* mov esi, 0x101c31c4 */
            ii(0x1008_85a3, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1008_85a5, 5);  call(0x100c_1fd4, 0x3_9a2a);          /* call 0x100c1fd4 */
            ii(0x1008_85aa, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1008_85ad, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1008_85b2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_85b5, 1);  push(eax);                            /* push eax */
            ii(0x1008_85b6, 6);  mov(ecx, memd[ds, 0x101c_8170]);      /* mov ecx, [0x101c8170] */
            ii(0x1008_85bc, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1008_85bf, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1008_85c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_85c3, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x1008_85c6, 5);  call(0x1008_b148, 0x2b7d);            /* call 0x1008b148 */
            ii(0x1008_85cb, 7);  mov(memd[ss, ebp - 28], 0xffff_ffff); /* mov dword [ebp-0x1c], 0xffffffff */
            ii(0x1008_85d2, 5);  mov(edx, 0x4e);                       /* mov edx, 0x4e */
            ii(0x1008_85d7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_85da, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_85dd, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_85e0, 5);  call(0x100b_71dc, 0x2_ebf7);          /* call 0x100b71dc */
            ii(0x1008_85e5, 1);  cwde();                               /* cwde */
            ii(0x1008_85e6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_85e8, 2);  if(jle(0x1008_85f6, 0xc)) goto l_0x1008_85f6;/* jle 0x100885f6 */
            ii(0x1008_85ea, 7);  mov(memd[ss, ebp - 28], 0x4e);        /* mov dword [ebp-0x1c], 0x4e */
            ii(0x1008_85f1, 5);  jmp(0x1008_8691, 0x9b); goto l_0x1008_8691;/* jmp 0x10088691 */
        l_0x1008_85f6:
            ii(0x1008_85f6, 5);  mov(edx, 0x48);                       /* mov edx, 0x48 */
            ii(0x1008_85fb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_85fe, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_8601, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_8604, 5);  call(0x100b_71dc, 0x2_ebd3);          /* call 0x100b71dc */
            ii(0x1008_8609, 1);  cwde();                               /* cwde */
            ii(0x1008_860a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_860c, 2);  if(jle(0x1008_861a, 0xc)) goto l_0x1008_861a;/* jle 0x1008861a */
            ii(0x1008_860e, 7);  mov(memd[ss, ebp - 28], 0x48);        /* mov dword [ebp-0x1c], 0x48 */
            ii(0x1008_8615, 5);  jmp(0x1008_8691, 0x77); goto l_0x1008_8691;/* jmp 0x10088691 */
        l_0x1008_861a:
            ii(0x1008_861a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_861d, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1008_8622, 2);  if(jz(0x1008_862e, 0xa)) goto l_0x1008_862e;/* jz 0x1008862e */
            ii(0x1008_8624, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8627, 5);  cmp(memw[ds, eax + 8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x1008_862c, 2);  if(jnz(0x1008_8646, 0x18)) goto l_0x1008_8646;/* jnz 0x10088646 */
        l_0x1008_862e:
            ii(0x1008_862e, 5);  mov(edx, 0x41);                       /* mov edx, 0x41 */
            ii(0x1008_8633, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8636, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_8639, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_863c, 5);  call(0x100b_71dc, 0x2_eb9b);          /* call 0x100b71dc */
            ii(0x1008_8641, 1);  cwde();                               /* cwde */
            ii(0x1008_8642, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_8644, 2);  if(jg(0x1008_8648, 2)) goto l_0x1008_8648;/* jg 0x10088648 */
        l_0x1008_8646:
            ii(0x1008_8646, 2);  jmp(0x1008_8651, 9); goto l_0x1008_8651;/* jmp 0x10088651 */
        l_0x1008_8648:
            ii(0x1008_8648, 7);  mov(memd[ss, ebp - 28], 0x41);        /* mov dword [ebp-0x1c], 0x41 */
            ii(0x1008_864f, 2);  jmp(0x1008_8691, 0x40); goto l_0x1008_8691;/* jmp 0x10088691 */
        l_0x1008_8651:
            ii(0x1008_8651, 5);  mov(edx, 0x1b);                       /* mov edx, 0x1b */
            ii(0x1008_8656, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8659, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_865c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_865f, 5);  call(0x100b_71dc, 0x2_eb78);          /* call 0x100b71dc */
            ii(0x1008_8664, 1);  cwde();                               /* cwde */
            ii(0x1008_8665, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_8667, 2);  if(jle(0x1008_8672, 9)) goto l_0x1008_8672;/* jle 0x10088672 */
            ii(0x1008_8669, 7);  mov(memd[ss, ebp - 28], 0x4e);        /* mov dword [ebp-0x1c], 0x4e */
            ii(0x1008_8670, 2);  jmp(0x1008_8691, 0x1f); goto l_0x1008_8691;/* jmp 0x10088691 */
        l_0x1008_8672:
            ii(0x1008_8672, 5);  mov(edx, 0x17);                       /* mov edx, 0x17 */
            ii(0x1008_8677, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_867a, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_867d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_8680, 5);  call(0x100b_71dc, 0x2_eb57);          /* call 0x100b71dc */
            ii(0x1008_8685, 1);  cwde();                               /* cwde */
            ii(0x1008_8686, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_8688, 2);  if(jle(0x1008_8691, 7)) goto l_0x1008_8691;/* jle 0x10088691 */
            ii(0x1008_868a, 7);  mov(memd[ss, ebp - 28], 0x48);        /* mov dword [ebp-0x1c], 0x48 */
        l_0x1008_8691:
            ii(0x1008_8691, 4);  or(memb[ss, ebp - 16], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x1008_8695, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_8699, 1);  push(eax);                            /* push eax */
            ii(0x1008_869a, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1008_869f, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1008_86a4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_86a7, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x1008_86aa, 5);  call(0x1011_fec1, 0x9_7812);          /* call 0x1011fec1 */
            ii(0x1008_86af, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x1008_86b2, 4);  and(memb[ss, ebp - 16], -2 /* 0xfe */);/* and byte [ebp-0x10], 0xfe */
            ii(0x1008_86b6, 4);  cmp(memd[ss, ebp - 76], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x1008_86ba, 2);  if(jnz(0x1008_86cf, 0x13)) goto l_0x1008_86cf;/* jnz 0x100886cf */
            ii(0x1008_86bc, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_86c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_86c2, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x1008_86c5, 5);  call(Definitions.my_dtor_d1, 0x632);  /* call 0x10088cfc */
            ii(0x1008_86ca, 5);  jmp(0x1008_89b7, 0x2e8); goto l_0x1008_89b7;/* jmp 0x100889b7 */
        l_0x1008_86cf:
            ii(0x1008_86cf, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x1008_86d2, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1008_86d5, 5);  call(0x1007_5e64, -0x1_2876);         /* call 0x10075e64 */
            ii(0x1008_86da, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1008_86dc, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1008_86df, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1008_86e2, 5);  call(0x1007_5e64, -0x1_2883);         /* call 0x10075e64 */
            ii(0x1008_86e7, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1008_86e9, 5);  call(0x100a_5fca, 0x1_d8dc);          /* call 0x100a5fca */
            ii(0x1008_86ee, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1008_86f1, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1008_86f3, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1008_86f6, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1008_86f8, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1008_86fa, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_86fd, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_86ff, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_8702, 3);  mov(al, memb[ds, edx + 77]);          /* mov al, [edx+0x4d] */
            ii(0x1008_8705, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1008_8708, 7);  mov(memd[ss, ebp - 36], 1);           /* mov dword [ebp-0x24], 0x1 */
            ii(0x1008_870f, 2);  jmp(0x1008_8717, 6); goto l_0x1008_8717;/* jmp 0x10088717 */
        l_0x1008_8711:
            ii(0x1008_8711, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_8714, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x1008_8717:
            ii(0x1008_8717, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_871a, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x1008_871e, 6);  if(jge(0x1008_88a4, 0x180)) goto l_0x1008_88a4;/* jge 0x100888a4 */
            ii(0x1008_8724, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_8727, 3);  sub(eax, memd[ss, ebp - 36]);         /* sub eax, [ebp-0x24] */
            ii(0x1008_872a, 4);  mov(memw[ss, ebp - 68], ax);          /* mov [ebp-0x44], ax */
            ii(0x1008_872e, 3);  mov(eax, memd[ss, ebp - 58]);         /* mov eax, [ebp-0x3a] */
            ii(0x1008_8731, 3);  add(eax, memd[ss, ebp - 36]);         /* add eax, [ebp-0x24] */
            ii(0x1008_8734, 4);  mov(memw[ss, ebp - 66], ax);          /* mov [ebp-0x42], ax */
            ii(0x1008_8738, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_873f, 2);  jmp(0x1008_8745, 4); goto l_0x1008_8745;/* jmp 0x10088745 */
        l_0x1008_8741:
            ii(0x1008_8741, 4);  add(memd[ss, ebp - 20], 2);           /* add dword [ebp-0x14], 0x2 */
        l_0x1008_8745:
            ii(0x1008_8745, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1008_8749, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1008_874c, 6);  if(jge(0x1008_889f, 0x14d)) goto l_0x1008_889f;/* jge 0x1008889f */
            ii(0x1008_8752, 7);  mov(memd[ss, ebp - 44], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1008_8759, 2);  jmp(0x1008_8761, 6); goto l_0x1008_8761;/* jmp 0x10088761 */
        l_0x1008_875b:
            ii(0x1008_875b, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_875e, 3);  inc(memd[ss, ebp - 44]);              /* inc dword [ebp-0x2c] */
        l_0x1008_8761:
            ii(0x1008_8761, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1008_8765, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1008_8767, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1008_876b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_876d, 6);  if(jge(0x1008_889a, 0x127)) goto l_0x1008_889a;/* jge 0x1008889a */
            ii(0x1008_8773, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1008_8777, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1008_877a, 5);  mov(eax, 0x101c_5348);                /* mov eax, 0x101c5348 */
            ii(0x1008_877f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_8781, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_8784, 5);  call(0x1008_b1a4, 0x2a1b);            /* call 0x1008b1a4 */
            ii(0x1008_8789, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1008_878c, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x1008_878f, 5);  call(0x1010_82ce, 0x7_fb3a);          /* call 0x101082ce */
            ii(0x1008_8794, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_8796, 2);  if(jz(0x1008_87b5, 0x1d)) goto l_0x1008_87b5;/* jz 0x100887b5 */
            ii(0x1008_8798, 4);  movsx(eax, memw[ss, ebp - 68]);       /* movsx eax, word [ebp-0x44] */
            ii(0x1008_879c, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_879f, 3);  add(eax, memd[ss, ebp - 76]);         /* add eax, [ebp-0x4c] */
            ii(0x1008_87a2, 4);  movsx(edx, memw[ss, ebp - 66]);       /* movsx edx, word [ebp-0x42] */
            ii(0x1008_87a6, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1008_87a8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_87aa, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_87ac, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1008_87af, 4);  cmp(ax, memw[ss, ebp - 40]);          /* cmp ax, [ebp-0x28] */
            ii(0x1008_87b3, 2);  if(jl(0x1008_87ba, 5)) goto l_0x1008_87ba;/* jl 0x100887ba */
        l_0x1008_87b5:
            ii(0x1008_87b5, 5);  jmp(0x1008_8895, 0xdb); goto l_0x1008_8895;/* jmp 0x10088895 */
        l_0x1008_87ba:
            ii(0x1008_87ba, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x1008_87bd, 3);  lea(eax, memd[ss, ebp - 120]);        /* lea eax, [ebp-0x78] */
            ii(0x1008_87c0, 5);  call(0x1007_5e64, -0x1_2961);         /* call 0x10075e64 */
            ii(0x1008_87c5, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1008_87c7, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1008_87ca, 3);  lea(eax, memd[ss, ebp - 124]);        /* lea eax, [ebp-0x7c] */
            ii(0x1008_87cd, 5);  call(0x1007_5e64, -0x1_296e);         /* call 0x10075e64 */
            ii(0x1008_87d2, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1008_87d4, 5);  call(0x100a_5fca, 0x1_d7f1);          /* call 0x100a5fca */
            ii(0x1008_87d9, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1008_87dc, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1008_87de, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1008_87e1, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1008_87e3, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1008_87e5, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1008_87e7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_87ea, 4);  mov(ax, memw[ds, edx + 28]);          /* mov ax, [edx+0x1c] */
            ii(0x1008_87ee, 3);  sub(eax, memd[ss, ebp - 66]);         /* sub eax, [ebp-0x42] */
            ii(0x1008_87f1, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1008_87f4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_87f7, 4);  mov(ax, memw[ds, edx + 26]);          /* mov ax, [edx+0x1a] */
            ii(0x1008_87fb, 3);  sub(eax, memd[ss, ebp - 68]);         /* sub eax, [ebp-0x44] */
            ii(0x1008_87fe, 1);  cwde();                               /* cwde */
            ii(0x1008_87ff, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1008_8801, 5);  call(0x100a_5f65, 0x1_d75f);          /* call 0x100a5f65 */
            ii(0x1008_8806, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1008_8809, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1008_880b, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1008_880e, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1008_8811, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x1008_8813, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1008_8816, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1008_8818, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_881b, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_881e, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x1008_8822, 2);  if(jge(0x1008_883b, 0x17)) goto l_0x1008_883b;/* jge 0x1008883b */
            ii(0x1008_8824, 4);  movsx(eax, memw[ss, ebp - 68]);       /* movsx eax, word [ebp-0x44] */
            ii(0x1008_8828, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_882b, 3);  add(eax, memd[ss, ebp - 72]);         /* add eax, [ebp-0x48] */
            ii(0x1008_882e, 4);  movsx(edx, memw[ss, ebp - 66]);       /* movsx edx, word [ebp-0x42] */
            ii(0x1008_8832, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_8834, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_8836, 3);  test(memb[ds, eax], 8);               /* test byte [eax], 0x8 */
            ii(0x1008_8839, 2);  if(jz(0x1008_883d, 2)) goto l_0x1008_883d;/* jz 0x1008883d */
        l_0x1008_883b:
            ii(0x1008_883b, 2);  jmp(0x1008_8856, 0x19); goto l_0x1008_8856;/* jmp 0x10088856 */
        l_0x1008_883d:
            ii(0x1008_883d, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1008_8840, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x1008_8843, 5);  call(0x1007_5e64, -0x1_29e4);         /* call 0x10075e64 */
            ii(0x1008_8848, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_884a, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x1008_884d, 5);  call(0x1011_ff4c, 0x9_76fa);          /* call 0x1011ff4c */
            ii(0x1008_8852, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_8854, 2);  if(jnz(0x1008_8858, 2)) goto l_0x1008_8858;/* jnz 0x10088858 */
        l_0x1008_8856:
            ii(0x1008_8856, 2);  jmp(0x1008_8882, 0x2a); goto l_0x1008_8882;/* jmp 0x10088882 */
        l_0x1008_8858:
            ii(0x1008_8858, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1008_885d, 1);  push(eax);                            /* push eax */
            ii(0x1008_885e, 4);  movsx(ecx, memw[ss, ebp - 66]);       /* movsx ecx, word [ebp-0x42] */
            ii(0x1008_8862, 4);  movsx(ebx, memw[ss, ebp - 68]);       /* movsx ebx, word [ebp-0x44] */
            ii(0x1008_8866, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8869, 3);  mov(edx, memd[ds, eax + 7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_886c, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_886f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8872, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_8875, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_8878, 5);  call(0x1007_02b9, -0x1_85c4);         /* call 0x100702b9 */
            ii(0x1008_887d, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1008_8880, 2);  if(jnz(0x1008_8884, 2)) goto l_0x1008_8884;/* jnz 0x10088884 */
        l_0x1008_8882:
            ii(0x1008_8882, 2);  jmp(0x1008_8895, 0x11); goto l_0x1008_8895;/* jmp 0x10088895 */
        l_0x1008_8884:
            ii(0x1008_8884, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1008_8887, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_888a, 5);  call(0x1008_8b44, 0x2b5);             /* call 0x10088b44 */
            ii(0x1008_888f, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_8892, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_8895:
            ii(0x1008_8895, 5);  jmp(0x1008_875b, -0x13f); goto l_0x1008_875b;/* jmp 0x1008875b */
        l_0x1008_889a:
            ii(0x1008_889a, 5);  jmp(0x1008_8741, -0x15e); goto l_0x1008_8741;/* jmp 0x10088741 */
        l_0x1008_889f:
            ii(0x1008_889f, 5);  jmp(0x1008_8711, -0x193); goto l_0x1008_8711;/* jmp 0x10088711 */
        l_0x1008_88a4:
            ii(0x1008_88a4, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_88a7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_88aa, 4);  cmp(ax, memw[ds, edx + 26]);          /* cmp ax, [edx+0x1a] */
            ii(0x1008_88ae, 2);  if(jnz(0x1008_88bc, 0xc)) goto l_0x1008_88bc;/* jnz 0x100888bc */
            ii(0x1008_88b0, 3);  mov(eax, memd[ss, ebp - 62]);         /* mov eax, [ebp-0x3e] */
            ii(0x1008_88b3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_88b6, 4);  cmp(ax, memw[ds, edx + 28]);          /* cmp ax, [edx+0x1c] */
            ii(0x1008_88ba, 2);  if(jz(0x1008_88be, 2)) goto l_0x1008_88be;/* jz 0x100888be */
        l_0x1008_88bc:
            ii(0x1008_88bc, 2);  jmp(0x1008_88d1, 0x13); goto l_0x1008_88d1;/* jmp 0x100888d1 */
        l_0x1008_88be:
            ii(0x1008_88be, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_88c2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_88c4, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x1008_88c7, 5);  call(Definitions.my_dtor_d1, 0x430);  /* call 0x10088cfc */
            ii(0x1008_88cc, 5);  jmp(0x1008_89b7, 0xe6); goto l_0x1008_89b7;/* jmp 0x100889b7 */
        l_0x1008_88d1:
            ii(0x1008_88d1, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_88d4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_88d7, 4);  mov(memw[ds, edx + 30], ax);          /* mov [edx+0x1e], ax */
            ii(0x1008_88db, 3);  mov(eax, memd[ss, ebp - 62]);         /* mov eax, [ebp-0x3e] */
            ii(0x1008_88de, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_88e1, 4);  mov(memw[ds, edx + 32], ax);          /* mov [edx+0x20], ax */
            ii(0x1008_88e5, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1008_88ea, 5);  call(Definitions.sys_new, 0xd_d511);  /* call 0x10165e00 */
            ii(0x1008_88ef, 6);  mov(memd[ss, ebp - 132], eax);        /* mov [ebp-0x84], eax */
            ii(0x1008_88f5, 6);  mov(eax, memd[ss, ebp - 132]);        /* mov eax, [ebp-0x84] */
            ii(0x1008_88fb, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x1008_8901, 7);  cmp(memd[ss, ebp - 136], 0);          /* cmp dword [ebp-0x88], 0x0 */
            ii(0x1008_8908, 2);  if(jz(0x1008_8949, 0x3f)) goto l_0x1008_8949;/* jz 0x10088949 */
            ii(0x1008_890a, 5);  mov(eax, 0x100b_0ebb);                /* mov eax, 0x100b0ebb */
            ii(0x1008_890f, 1);  push(eax);                            /* push eax */
            ii(0x1008_8910, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1008_8913, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1008_8916, 5);  call(0x1007_5e64, -0x1_2ab7);         /* call 0x10075e64 */
            ii(0x1008_891b, 1);  push(eax);                            /* push eax */
            ii(0x1008_891c, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1008_8921, 1);  push(eax);                            /* push eax */
            ii(0x1008_8922, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1008_8924, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1008_8927, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_892a, 6);  mov(eax, memd[ss, ebp - 132]);        /* mov eax, [ebp-0x84] */
            ii(0x1008_8930, 5);  call(0x100a_c220, 0x2_38eb);          /* call 0x100ac220 */
            ii(0x1008_8935, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
            ii(0x1008_893b, 6);  mov(eax, memd[ss, ebp - 140]);        /* mov eax, [ebp-0x8c] */
            ii(0x1008_8941, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
            ii(0x1008_8947, 2);  jmp(0x1008_8955, 0xc); goto l_0x1008_8955;/* jmp 0x10088955 */
        l_0x1008_8949:
            ii(0x1008_8949, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x1008_894f, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
        l_0x1008_8955:
            ii(0x1008_8955, 6);  mov(edx, memd[ss, ebp - 144]);        /* mov edx, [ebp-0x90] */
            ii(0x1008_895b, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_895e, 5);  call(0x1008_a5f0, 0x1c8d);            /* call 0x1008a5f0 */
            ii(0x1008_8963, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_8968, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_896b, 5);  call(0x1008_a520, 0x1bb0);            /* call 0x1008a520 */
            ii(0x1008_8970, 5);  call(0x1008_a6a4, 0x1d2f);            /* call 0x1008a6a4 */
            ii(0x1008_8975, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_8978, 5);  call(0x1008_a57c, 0x1bff);            /* call 0x1008a57c */
            ii(0x1008_897d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_897f, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_8984, 5);  call(0x100a_4d50, 0x1_c3c7);          /* call 0x100a4d50 */
            ii(0x1008_8989, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_898d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_898f, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_8992, 5);  call(0x1008_8d4c, 0x3b5);             /* call 0x10088d4c */
            ii(0x1008_8997, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_8999, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x1008_899c, 5);  call(Definitions.my_dtor_d1, 0x35b);  /* call 0x10088cfc */
            ii(0x1008_89a1, 2);  jmp(0x1008_89b7, 0x14); goto l_0x1008_89b7;/* jmp 0x100889b7 */
        //  ii(0x1008_89a3, 20);  Недостижимый код.
        l_0x1008_89b7:
            ii(0x1008_89b7, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_89ba, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_89bc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_89bd, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_89be, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_89bf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_89c0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_89c1, 1);  ret();                                /* ret */
        }
    }
}
