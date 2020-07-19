using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d3e6-95d18647")]
        public void Method_1007_d3e6()
        {
            ii(0x1007_d3e6, 5);  push(0x60);                           /* push 0x60 */
            ii(0x1007_d3eb, 5);  call(Definitions.sys_check_available_stack_size, 0xe_8962);/* call 0x10165d52 */
            ii(0x1007_d3f0, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_d3f1, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_d3f2, 1);  push(esi);                            /* push esi */
            ii(0x1007_d3f3, 1);  push(edi);                            /* push edi */
            ii(0x1007_d3f4, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_d3f5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_d3f7, 6);  sub(esp, 0x48);                       /* sub esp, 0x48 */
            ii(0x1007_d3fd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_d400, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_d403, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_d406, 5);  call(0x1007_6338, -0x70d3);           /* call 0x10076338 */
            ii(0x1007_d40b, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_d40e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d410, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_d412, 5);  call(0x1007_64b8, -0x6f5f);           /* call 0x100764b8 */
            ii(0x1007_d417, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_d41b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d41e, 5);  call(Definitions.my_ctor_0x101b_3b58, 0xdc81);/* call 0x1008b0a4 */
            ii(0x1007_d423, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_d426, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1007_d42a, 2);  jmp(0x1007_d434, 8); goto l_0x1007_d434;/* jmp 0x1007d434 */
        l_0x1007_d42c:
            ii(0x1007_d42c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d42f, 5);  call(0x1007_6bf8, -0x683c);           /* call 0x10076bf8 */
        l_0x1007_d434:
            ii(0x1007_d434, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_d436, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d439, 5);  call(0x1013_ad71, 0xb_d933);          /* call 0x1013ad71 */
            ii(0x1007_d43e, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_d440, 6);  if(jz(0x1007_d622, 0x1dc)) goto l_0x1007_d622;/* jz 0x1007d622 */
            ii(0x1007_d446, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_d449, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d44c, 5);  call(0x1007_63a0, -0x70b1);           /* call 0x100763a0 */
            ii(0x1007_d451, 5);  call(0x1015_2a52, 0xd_55fc);          /* call 0x10152a52 */
            ii(0x1007_d456, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_d458, 6);  if(jz(0x1007_d61d, 0x1bf)) goto l_0x1007_d61d;/* jz 0x1007d61d */
            ii(0x1007_d45e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_d460, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d463, 5);  call(0x1008_afe4, 0xdb7c);            /* call 0x1008afe4 */
            ii(0x1007_d468, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d46b, 5);  call(0x1007_63a0, -0x70d0);           /* call 0x100763a0 */
            ii(0x1007_d470, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_d472, 3);  mov(dl, memb[ds, eax + 77]);          /* mov dl, [eax+0x4d] */
            ii(0x1007_d475, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d478, 5);  call(0x1007_63a0, -0x70dd);           /* call 0x100763a0 */
            ii(0x1007_d47d, 5);  call(0x1007_623c, -0x7246);           /* call 0x1007623c */
            ii(0x1007_d482, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1007_d485, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_d488, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_d48a, 2);  if(jz(0x1007_d49b, 0xf)) goto l_0x1007_d49b;/* jz 0x1007d49b */
            ii(0x1007_d48c, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1007_d491, 5);  call(0x1007_5fdc, -0x74ba);           /* call 0x10075fdc */
            ii(0x1007_d496, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1007_d499, 2);  if(jge(0x1007_d49d, 2)) goto l_0x1007_d49d;/* jge 0x1007d49d */
        l_0x1007_d49b:
            ii(0x1007_d49b, 2);  jmp(0x1007_d4e9, 0x4c); goto l_0x1007_d4e9;/* jmp 0x1007d4e9 */
        l_0x1007_d49d:
            ii(0x1007_d49d, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x1007_d4a2, 5);  call(Definitions.sys_new, 0xe_8959);  /* call 0x10165e00 */
            ii(0x1007_d4a7, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_d4aa, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_d4ad, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_d4b0, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1007_d4b4, 2);  if(jz(0x1007_d4d3, 0x1d)) goto l_0x1007_d4d3;/* jz 0x1007d4d3 */
            ii(0x1007_d4b6, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d4b9, 5);  call(0x1007_63d4, -0x70ea);           /* call 0x100763d4 */
            ii(0x1007_d4be, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d4c0, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_d4c3, 5);  call(Definitions.my_ctor_c15, 0x4_e3c0);/* call 0x100cb888 */
            ii(0x1007_d4c8, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_d4cb, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_d4ce, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_d4d1, 2);  jmp(0x1007_d4d9, 6); goto l_0x1007_d4d9;/* jmp 0x1007d4d9 */
        l_0x1007_d4d3:
            ii(0x1007_d4d3, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_d4d6, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
        l_0x1007_d4d9:
            ii(0x1007_d4d9, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1007_d4dc, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d4df, 5);  call(0x1008_afe4, 0xdb00);            /* call 0x1008afe4 */
            ii(0x1007_d4e4, 5);  jmp(0x1007_d5f9, 0x110); goto l_0x1007_d5f9;/* jmp 0x1007d5f9 */
        l_0x1007_d4e9:
            ii(0x1007_d4e9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d4ec, 5);  call(0x1007_63a0, -0x7151);           /* call 0x100763a0 */
            ii(0x1007_d4f1, 5);  call(0x1007_623c, -0x72ba);           /* call 0x1007623c */
            ii(0x1007_d4f6, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1007_d4f9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_d4fc, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1007_d4fe, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d500, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d503, 5);  call(0x1007_63a0, -0x7168);           /* call 0x100763a0 */
            ii(0x1007_d508, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x1007_d50b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_d510, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1007_d512, 2);  if(jge(0x1007_d560, 0x4c)) goto l_0x1007_d560;/* jge 0x1007d560 */
            ii(0x1007_d514, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x1007_d519, 5);  call(Definitions.sys_new, 0xe_88e2);  /* call 0x10165e00 */
            ii(0x1007_d51e, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_d521, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_d524, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_d527, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1007_d52b, 2);  if(jz(0x1007_d54a, 0x1d)) goto l_0x1007_d54a;/* jz 0x1007d54a */
            ii(0x1007_d52d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d530, 5);  call(0x1007_63d4, -0x7161);           /* call 0x100763d4 */
            ii(0x1007_d535, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d537, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_d53a, 5);  call(Definitions.my_ctor_c16, 0x4_f8eb);/* call 0x100cce2a */
            ii(0x1007_d53f, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_d542, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1007_d545, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1007_d548, 2);  jmp(0x1007_d550, 6); goto l_0x1007_d550;/* jmp 0x1007d550 */
        l_0x1007_d54a:
            ii(0x1007_d54a, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_d54d, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
        l_0x1007_d550:
            ii(0x1007_d550, 3);  mov(edx, memd[ss, ebp - 56]);         /* mov edx, [ebp-0x38] */
            ii(0x1007_d553, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d556, 5);  call(0x1008_afe4, 0xda89);            /* call 0x1008afe4 */
            ii(0x1007_d55b, 5);  jmp(0x1007_d5f9, 0x99); goto l_0x1007_d5f9;/* jmp 0x1007d5f9 */
        l_0x1007_d560:
            ii(0x1007_d560, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d563, 5);  call(0x1007_63a0, -0x71c8);           /* call 0x100763a0 */
            ii(0x1007_d568, 6);  test(memw[ds, eax + 18], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x1007_d56e, 2);  if(jz(0x1007_d57e, 0xe)) goto l_0x1007_d57e;/* jz 0x1007d57e */
            ii(0x1007_d570, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d573, 5);  call(0x1007_63a0, -0x71d8);           /* call 0x100763a0 */
            ii(0x1007_d578, 4);  test(memb[ds, eax + 21], 0x10);       /* test byte [eax+0x15], 0x10 */
            ii(0x1007_d57c, 2);  if(jz(0x1007_d580, 2)) goto l_0x1007_d580;/* jz 0x1007d580 */
        l_0x1007_d57e:
            ii(0x1007_d57e, 2);  jmp(0x1007_d5b0, 0x30); goto l_0x1007_d5b0;/* jmp 0x1007d5b0 */
        l_0x1007_d580:
            ii(0x1007_d580, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d583, 5);  call(0x1007_63d4, -0x71b4);           /* call 0x100763d4 */
            ii(0x1007_d588, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d58a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d58d, 5);  call(0x1007_63a0, -0x71f2);           /* call 0x100763a0 */
            ii(0x1007_d592, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_d595, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_d59a, 6);  imul(ebx, eax, 0xc5);                 /* imul ebx, eax, 0xc5 */
            ii(0x1007_d5a0, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x1007_d5a5, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1007_d5a7, 5);  call(0x100c_343a, 0x4_5e8e);          /* call 0x100c343a */
            ii(0x1007_d5ac, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_d5ae, 2);  if(jnz(0x1007_d5b2, 2)) goto l_0x1007_d5b2;/* jnz 0x1007d5b2 */
        l_0x1007_d5b0:
            ii(0x1007_d5b0, 2);  jmp(0x1007_d5f9, 0x47); goto l_0x1007_d5f9;/* jmp 0x1007d5f9 */
        l_0x1007_d5b2:
            ii(0x1007_d5b2, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x1007_d5b7, 5);  call(Definitions.sys_new, 0xe_8844);  /* call 0x10165e00 */
            ii(0x1007_d5bc, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_d5bf, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_d5c2, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1007_d5c5, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1007_d5c9, 2);  if(jz(0x1007_d5e8, 0x1d)) goto l_0x1007_d5e8;/* jz 0x1007d5e8 */
            ii(0x1007_d5cb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d5ce, 5);  call(0x1007_63d4, -0x71ff);           /* call 0x100763d4 */
            ii(0x1007_d5d3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d5d5, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_d5d8, 5);  call(Definitions.my_ctor_c18, 0x4_fd80);/* call 0x100cd35d */
            ii(0x1007_d5dd, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1007_d5e0, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_d5e3, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1007_d5e6, 2);  jmp(0x1007_d5ee, 6); goto l_0x1007_d5ee;/* jmp 0x1007d5ee */
        l_0x1007_d5e8:
            ii(0x1007_d5e8, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_d5eb, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
        l_0x1007_d5ee:
            ii(0x1007_d5ee, 3);  mov(edx, memd[ss, ebp - 72]);         /* mov edx, [ebp-0x48] */
            ii(0x1007_d5f1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d5f4, 5);  call(0x1008_afe4, 0xd9eb);            /* call 0x1008afe4 */
        l_0x1007_d5f9:
            ii(0x1007_d5f9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_d5fb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d5fe, 5);  call(0x1013_ad71, 0xb_d76e);          /* call 0x1013ad71 */
            ii(0x1007_d603, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_d605, 2);  if(jz(0x1007_d61d, 0x16)) goto l_0x1007_d61d;/* jz 0x1007d61d */
            ii(0x1007_d607, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d60a, 5);  call(0x1008_af84, 0xd975);            /* call 0x1008af84 */
            ii(0x1007_d60f, 5);  mov(ebx, 0x101c_3180);                /* mov ebx, 0x101c3180 */
            ii(0x1007_d614, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d616, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_d618, 5);  call(0x100a_4d50, 0x2_7733);          /* call 0x100a4d50 */
        l_0x1007_d61d:
            ii(0x1007_d61d, 5);  jmp(0x1007_d42c, -0x1f6); goto l_0x1007_d42c;/* jmp 0x1007d42c */
        l_0x1007_d622:
            ii(0x1007_d622, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_d624, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d627, 5);  call(0x1008_8b7c, 0xb550);            /* call 0x10088b7c */
            ii(0x1007_d62c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_d62e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_d631, 5);  call(0x1007_5f6c, -0x76ca);           /* call 0x10075f6c */
            ii(0x1007_d636, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_d638, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_d639, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_d63a, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_d63b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_d63c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_d63d, 1);  ret();                                /* ret */
        }
    }
}
