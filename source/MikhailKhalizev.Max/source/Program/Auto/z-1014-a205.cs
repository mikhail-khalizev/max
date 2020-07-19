using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_a205-6b6ee221")]
        public void Method_1014_a205()
        {
            ii(0x1014_a205, 5);  push(0x48);                           /* push 0x48 */
            ii(0x1014_a20a, 5);  call(Definitions.sys_check_available_stack_size, 0x1_bb43);/* call 0x10165d52 */
            ii(0x1014_a20f, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_a210, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_a211, 1);  push(esi);                            /* push esi */
            ii(0x1014_a212, 1);  push(edi);                            /* push edi */
            ii(0x1014_a213, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_a214, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_a216, 6);  sub(esp, 0x30);                       /* sub esp, 0x30 */
            ii(0x1014_a21c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_a21f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_a222, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_a225, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1014_a228, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_a22b, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_a22f, 2);  if(jz(0x1014_a237, 6)) goto l_0x1014_a237;/* jz 0x1014a237 */
            ii(0x1014_a231, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_a234, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1014_a237:
            ii(0x1014_a237, 7);  test(memd[ss, ebp - 16], 0x180);      /* test dword [ebp-0x10], 0x180 */
            ii(0x1014_a23e, 2);  if(jz(0x1014_a252, 0x12)) goto l_0x1014_a252;/* jz 0x1014a252 */
            ii(0x1014_a240, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_a243, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x1014_a248, 5);  call(0x1010_4890, -0x4_59bd);         /* call 0x10104890 */
            ii(0x1014_a24d, 5);  jmp(0x1014_a486, 0x234); goto l_0x1014_a486;/* jmp 0x1014a486 */
        l_0x1014_a252:
            ii(0x1014_a252, 7);  test(memd[ss, ebp - 16], 0x200);      /* test dword [ebp-0x10], 0x200 */
            ii(0x1014_a259, 6);  if(jz(0x1014_a36c, 0x10d)) goto l_0x1014_a36c;/* jz 0x1014a36c */
            ii(0x1014_a25f, 7);  test(memd[ss, ebp - 16], 1);          /* test dword [ebp-0x10], 0x1 */
            ii(0x1014_a266, 6);  if(jz(0x1014_a2e9, 0x7d)) goto l_0x1014_a2e9;/* jz 0x1014a2e9 */
            ii(0x1014_a26c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_a26f, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_a272, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_a275, 5);  call(0x1014_a0f1, -0x189);            /* call 0x1014a0f1 */
            ii(0x1014_a27a, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1014_a27d, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1014_a282, 5);  call(0x1007_6338, -0xd_3f4f);         /* call 0x10076338 */
            ii(0x1014_a287, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a289, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_a28c, 5);  call(0x1007_64b8, -0xd_3dd9);         /* call 0x100764b8 */
        l_0x1014_a291:
            ii(0x1014_a291, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a293, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_a296, 5);  call(0x1013_ad71, -0xf52a);           /* call 0x1013ad71 */
            ii(0x1014_a29b, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_a29d, 2);  if(jz(0x1014_a2b7, 0x18)) goto l_0x1014_a2b7;/* jz 0x1014a2b7 */
            ii(0x1014_a29f, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_a2a2, 5);  call(0x1007_63a0, -0xd_3f07);         /* call 0x100763a0 */
            ii(0x1014_a2a7, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_a2aa, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_a2ad, 5);  call(0x1014_a0f1, -0x1c1);            /* call 0x1014a0f1 */
            ii(0x1014_a2b2, 3);  cmp(al, memb[ss, ebp - 20]);          /* cmp al, [ebp-0x14] */
            ii(0x1014_a2b5, 2);  if(jb(0x1014_a2b9, 2)) goto l_0x1014_a2b9;/* jb 0x1014a2b9 */
        l_0x1014_a2b7:
            ii(0x1014_a2b7, 2);  jmp(0x1014_a2c3, 0xa); goto l_0x1014_a2c3;/* jmp 0x1014a2c3 */
        l_0x1014_a2b9:
            ii(0x1014_a2b9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_a2bc, 5);  call(0x1007_6bf8, -0xd_36c9);         /* call 0x10076bf8 */
            ii(0x1014_a2c1, 2);  jmp(0x1014_a291, -0x32); goto l_0x1014_a291;/* jmp 0x1014a291 */
        l_0x1014_a2c3:
            ii(0x1014_a2c3, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_a2c6, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_a2c9, 5);  call(0x1008_ab8c, -0xb_f742);         /* call 0x1008ab8c */
            ii(0x1014_a2ce, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a2d0, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1014_a2d5, 5);  call(0x1015_5110, 0xae36);            /* call 0x10155110 */
            ii(0x1014_a2da, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a2dc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_a2df, 5);  call(0x1007_5f6c, -0xd_4378);         /* call 0x10075f6c */
            ii(0x1014_a2e4, 5);  jmp(0x1014_a367, 0x7e); goto l_0x1014_a367;/* jmp 0x1014a367 */
        l_0x1014_a2e9:
            ii(0x1014_a2e9, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_a2ed, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a2f0, 5);  call(0x1007_64fc, -0xd_3df9);         /* call 0x100764fc */
            ii(0x1014_a2f5, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_a2f8, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1014_a2fc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_a2ff, 4);  mov(ax, memw[ds, eax + 24]);          /* mov ax, [eax+0x18] */
            ii(0x1014_a303, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_a306, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1014_a30b, 5);  call(0x1007_6338, -0xd_3fd8);         /* call 0x10076338 */
            ii(0x1014_a310, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a312, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a315, 5);  call(0x1007_643c, -0xd_3ede);         /* call 0x1007643c */
        l_0x1014_a31a:
            ii(0x1014_a31a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a31c, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a31f, 5);  call(0x1013_ad71, -0xf5b3);           /* call 0x1013ad71 */
            ii(0x1014_a324, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_a326, 2);  if(jz(0x1014_a33a, 0x12)) goto l_0x1014_a33a;/* jz 0x1014a33a */
            ii(0x1014_a328, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a32b, 5);  call(0x1007_63a0, -0xd_3f90);         /* call 0x100763a0 */
            ii(0x1014_a330, 4);  mov(ax, memw[ds, eax + 24]);          /* mov ax, [eax+0x18] */
            ii(0x1014_a334, 4);  cmp(ax, memw[ss, ebp - 36]);          /* cmp ax, [ebp-0x24] */
            ii(0x1014_a338, 2);  if(jl(0x1014_a33c, 2)) goto l_0x1014_a33c;/* jl 0x1014a33c */
        l_0x1014_a33a:
            ii(0x1014_a33a, 2);  jmp(0x1014_a346, 0xa); goto l_0x1014_a346;/* jmp 0x1014a346 */
        l_0x1014_a33c:
            ii(0x1014_a33c, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a33f, 5);  call(0x1007_6bf8, -0xd_374c);         /* call 0x10076bf8 */
            ii(0x1014_a344, 2);  jmp(0x1014_a31a, -0x2c); goto l_0x1014_a31a;/* jmp 0x1014a31a */
        l_0x1014_a346:
            ii(0x1014_a346, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_a349, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a34c, 5);  call(0x1008_ab8c, -0xb_f7c5);         /* call 0x1008ab8c */
            ii(0x1014_a351, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a353, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1014_a358, 5);  call(0x1015_5110, 0xadb3);            /* call 0x10155110 */
            ii(0x1014_a35d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a35f, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_a362, 5);  call(0x1007_5f6c, -0xd_43fb);         /* call 0x10075f6c */
        l_0x1014_a367:
            ii(0x1014_a367, 5);  jmp(0x1014_a486, 0x11a); goto l_0x1014_a486;/* jmp 0x1014a486 */
        l_0x1014_a36c:
            ii(0x1014_a36c, 7);  test(memd[ss, ebp - 16], 0x40);       /* test dword [ebp-0x10], 0x40 */
            ii(0x1014_a373, 6);  if(jz(0x1014_a3ee, 0x75)) goto l_0x1014_a3ee;/* jz 0x1014a3ee */
            ii(0x1014_a379, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_a37d, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a380, 5);  call(0x1007_64fc, -0xd_3e89);         /* call 0x100764fc */
            ii(0x1014_a385, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1014_a388, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1014_a38c, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1014_a391, 5);  call(0x1007_6338, -0xd_405e);         /* call 0x10076338 */
            ii(0x1014_a396, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a398, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a39b, 5);  call(0x1007_643c, -0xd_3f64);         /* call 0x1007643c */
        l_0x1014_a3a0:
            ii(0x1014_a3a0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a3a2, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a3a5, 5);  call(0x1013_ad71, -0xf639);           /* call 0x1013ad71 */
            ii(0x1014_a3aa, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_a3ac, 2);  if(jz(0x1014_a3bc, 0xe)) goto l_0x1014_a3bc;/* jz 0x1014a3bc */
            ii(0x1014_a3ae, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a3b1, 5);  call(0x1007_63a0, -0xd_4016);         /* call 0x100763a0 */
            ii(0x1014_a3b6, 4);  test(memb[ds, eax + 20], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x1014_a3ba, 2);  if(jz(0x1014_a3be, 2)) goto l_0x1014_a3be;/* jz 0x1014a3be */
        l_0x1014_a3bc:
            ii(0x1014_a3bc, 2);  jmp(0x1014_a3c8, 0xa); goto l_0x1014_a3c8;/* jmp 0x1014a3c8 */
        l_0x1014_a3be:
            ii(0x1014_a3be, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a3c1, 5);  call(0x1007_6bf8, -0xd_37ce);         /* call 0x10076bf8 */
            ii(0x1014_a3c6, 2);  jmp(0x1014_a3a0, -0x28); goto l_0x1014_a3a0;/* jmp 0x1014a3a0 */
        l_0x1014_a3c8:
            ii(0x1014_a3c8, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_a3cb, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a3ce, 5);  call(0x1008_ab8c, -0xb_f847);         /* call 0x1008ab8c */
            ii(0x1014_a3d3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a3d5, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1014_a3da, 5);  call(0x1015_5110, 0xad31);            /* call 0x10155110 */
            ii(0x1014_a3df, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a3e1, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1014_a3e4, 5);  call(0x1007_5f6c, -0xd_447d);         /* call 0x10075f6c */
            ii(0x1014_a3e9, 5);  jmp(0x1014_a486, 0x98); goto l_0x1014_a486;/* jmp 0x1014a486 */
        l_0x1014_a3ee:
            ii(0x1014_a3ee, 7);  test(memd[ss, ebp - 16], 0x20);       /* test dword [ebp-0x10], 0x20 */
            ii(0x1014_a3f5, 6);  if(jz(0x1014_a486, 0x8b)) goto l_0x1014_a486;/* jz 0x1014a486 */
            ii(0x1014_a3fb, 7);  test(memd[ss, ebp - 16], 1);          /* test dword [ebp-0x10], 0x1 */
            ii(0x1014_a402, 2);  if(jz(0x1014_a416, 0x12)) goto l_0x1014_a416;/* jz 0x1014a416 */
            ii(0x1014_a404, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_a407, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1014_a40c, 5);  call(0x1010_4890, -0x4_5b81);         /* call 0x10104890 */
            ii(0x1014_a411, 5);  jmp(0x1014_a486, 0x70); goto l_0x1014_a486;/* jmp 0x1014a486 */
        l_0x1014_a416:
            ii(0x1014_a416, 5);  mov(eax, 0x101c_8190);                /* mov eax, 0x101c8190 */
            ii(0x1014_a41b, 5);  call(0x1007_6338, -0xd_40e8);         /* call 0x10076338 */
            ii(0x1014_a420, 3);  lea(ebx, memd[ss, ebp - 48]);         /* lea ebx, [ebp-0x30] */
            ii(0x1014_a423, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a425, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1014_a427, 5);  call(0x1007_64b8, -0xd_3f74);         /* call 0x100764b8 */
        l_0x1014_a42c:
            ii(0x1014_a42c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a42e, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_a431, 5);  call(0x1013_ad71, -0xf6c5);           /* call 0x1013ad71 */
            ii(0x1014_a436, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_a438, 2);  if(jz(0x1014_a459, 0x1f)) goto l_0x1014_a459;/* jz 0x1014a459 */
            ii(0x1014_a43a, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_a43d, 5);  call(0x1007_63a0, -0xd_40a2);         /* call 0x100763a0 */
            ii(0x1014_a442, 4);  test(memb[ds, eax + 18], 2);          /* test byte [eax+0x12], 0x2 */
            ii(0x1014_a446, 2);  if(jz(0x1014_a457, 0xf)) goto l_0x1014_a457;/* jz 0x1014a457 */
            ii(0x1014_a448, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_a44b, 5);  call(0x1007_63a0, -0xd_40b0);         /* call 0x100763a0 */
            ii(0x1014_a450, 5);  cmp(memw[ds, eax + 8], 0x59);         /* cmp word [eax+0x8], 0x59 */
            ii(0x1014_a455, 2);  if(jnz(0x1014_a459, 2)) goto l_0x1014_a459;/* jnz 0x1014a459 */
        l_0x1014_a457:
            ii(0x1014_a457, 2);  jmp(0x1014_a45b, 2); goto l_0x1014_a45b;/* jmp 0x1014a45b */
        l_0x1014_a459:
            ii(0x1014_a459, 2);  jmp(0x1014_a465, 0xa); goto l_0x1014_a465;/* jmp 0x1014a465 */
        l_0x1014_a45b:
            ii(0x1014_a45b, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_a45e, 5);  call(0x1007_6bf8, -0xd_386b);         /* call 0x10076bf8 */
            ii(0x1014_a463, 2);  jmp(0x1014_a42c, -0x39); goto l_0x1014_a42c;/* jmp 0x1014a42c */
        l_0x1014_a465:
            ii(0x1014_a465, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_a468, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_a46b, 5);  call(0x1008_ab8c, -0xb_f8e4);         /* call 0x1008ab8c */
            ii(0x1014_a470, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_a472, 5);  mov(eax, 0x101c_8190);                /* mov eax, 0x101c8190 */
            ii(0x1014_a477, 5);  call(0x1015_5110, 0xac94);            /* call 0x10155110 */
            ii(0x1014_a47c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_a47e, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_a481, 5);  call(0x1007_5f6c, -0xd_451a);         /* call 0x10075f6c */
        l_0x1014_a486:
            ii(0x1014_a486, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_a488, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_a489, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_a48a, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_a48b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_a48c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_a48d, 1);  ret();                                /* ret */
        }
    }
}
