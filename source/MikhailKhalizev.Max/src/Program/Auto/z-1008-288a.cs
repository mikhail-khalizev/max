using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_288a-a23aa834")]
        public void Method_1008_288a()
        {
            ii(0x1008_288a, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1008_288f, 5);  call(Definitions.sys_check_available_stack_size, 0xe_34be);/* call 0x10165d52 */
            ii(0x1008_2894, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_2895, 1);  push(esi);                            /* push esi */
            ii(0x1008_2896, 1);  push(edi);                            /* push edi */
            ii(0x1008_2897, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_2898, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_289a, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1008_28a0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_28a3, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1008_28a6, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1008_28a9, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1008_28ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_28b0, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_28b3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_28b6, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1008_28bc, 5);  mov(ebx, 0x101c_a468);                /* mov ebx, 0x101ca468 */
            ii(0x1008_28c1, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1008_28c3, 5);  call(0x100d_fd2c, 0x5_d464);          /* call 0x100dfd2c */
            ii(0x1008_28c8, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1008_28cc, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1008_28d0, 2);  if(jge(0x1008_28db, 9)) goto l_0x1008_28db;/* jge 0x100828db */
            ii(0x1008_28d2, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_28d6, 5);  jmp(0x1008_2ab4, 0x1d9); goto l_0x1008_2ab4;/* jmp 0x10082ab4 */
        l_0x1008_28db:
            ii(0x1008_28db, 4);  or(memb[ss, ebp - 20], 1);            /* or byte [ebp-0x14], 0x1 */
            ii(0x1008_28df, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_28e2, 5);  call(0x1007_64fc, -0xc3eb);           /* call 0x100764fc */
            ii(0x1008_28e7, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_28ea, 4);  and(memb[ss, ebp - 20], -2 /* 0xfe */);/* and byte [ebp-0x14], 0xfe */
            ii(0x1008_28ee, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1008_28f5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_28f8, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_28fb, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_28fe, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_2901, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_2904, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x1008_2907, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1008_290a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1008_290e, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1008_2911, 7);  test(memb[ds, eax + 0x101c_81c0], 0x40);/* test byte [eax+0x101c81c0], 0x40 */
            ii(0x1008_2918, 2);  if(jz(0x1008_2932, 0x18)) goto l_0x1008_2932;/* jz 0x10082932 */
            ii(0x1008_291a, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1008_291f, 5);  call(0x1007_6338, -0xc5ec);           /* call 0x10076338 */
            ii(0x1008_2924, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_2927, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_2929, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_292b, 5);  call(0x1007_643c, -0xc4f4);           /* call 0x1007643c */
            ii(0x1008_2930, 2);  jmp(0x1008_2948, 0x16); goto l_0x1008_2948;/* jmp 0x10082948 */
        l_0x1008_2932:
            ii(0x1008_2932, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x1008_2937, 5);  call(0x1007_6338, -0xc604);           /* call 0x10076338 */
            ii(0x1008_293c, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_293f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_2941, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_2943, 5);  call(0x1007_643c, -0xc50c);           /* call 0x1007643c */
        l_0x1008_2948:
            ii(0x1008_2948, 2);  jmp(0x1008_2952, 8); goto l_0x1008_2952;/* jmp 0x10082952 */
        l_0x1008_294a:
            ii(0x1008_294a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_294d, 5);  call(0x1007_6bf8, -0xbd5a);           /* call 0x10076bf8 */
        l_0x1008_2952:
            ii(0x1008_2952, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_2954, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_2957, 5);  call(0x1013_ad71, 0xb_8415);          /* call 0x1013ad71 */
            ii(0x1008_295c, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_295e, 6);  if(jz(0x1008_2a0c, 0xa8)) goto l_0x1008_2a0c;/* jz 0x10082a0c */
            ii(0x1008_2964, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_2967, 5);  call(0x1007_63a0, -0xc5cc);           /* call 0x100763a0 */
            ii(0x1008_296c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_296e, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1008_2971, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_2974, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_2977, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_297a, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_297c, 2);  if(jnz(0x1008_2990, 0x12)) goto l_0x1008_2990;/* jnz 0x10082990 */
            ii(0x1008_297e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_2981, 5);  call(0x1007_63a0, -0xc5e6);           /* call 0x100763a0 */
            ii(0x1008_2986, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1008_298a, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1008_298e, 2);  if(jz(0x1008_2992, 2)) goto l_0x1008_2992;/* jz 0x10082992 */
        l_0x1008_2990:
            ii(0x1008_2990, 2);  jmp(0x1008_29a9, 0x17); goto l_0x1008_29a9;/* jmp 0x100829a9 */
        l_0x1008_2992:
            ii(0x1008_2992, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_2995, 5);  call(0x1007_63a0, -0xc5fa);           /* call 0x100763a0 */
            ii(0x1008_299a, 5);  call(0x1007_623c, -0xc763);           /* call 0x1007623c */
            ii(0x1008_299f, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1008_29a3, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1008_29a7, 2);  if(jge(0x1008_29ab, 2)) goto l_0x1008_29ab;/* jge 0x100829ab */
        l_0x1008_29a9:
            ii(0x1008_29a9, 2);  jmp(0x1008_2a07, 0x5c); goto l_0x1008_2a07;/* jmp 0x10082a07 */
        l_0x1008_29ab:
            ii(0x1008_29ab, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_29ae, 5);  call(0x1007_63a0, -0xc613);           /* call 0x100763a0 */
            ii(0x1008_29b3, 5);  call(0x1015_26ac, 0xc_fcf4);          /* call 0x101526ac */
            ii(0x1008_29b8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_29ba, 2);  if(jz(0x1008_29d7, 0x1b)) goto l_0x1008_29d7;/* jz 0x100829d7 */
            ii(0x1008_29bc, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1008_29c0, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_29c3, 5);  call(0x1007_63a0, -0xc628);           /* call 0x100763a0 */
            ii(0x1008_29c8, 5);  call(0x1015_26ac, 0xc_fcdf);          /* call 0x101526ac */
            ii(0x1008_29cd, 5);  call(0x100a_2bc4, 0x2_01f2);          /* call 0x100a2bc4 */
            ii(0x1008_29d2, 1);  cwde();                               /* cwde */
            ii(0x1008_29d3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_29d5, 2);  if(jle(0x1008_2a07, 0x30)) goto l_0x1008_2a07;/* jle 0x10082a07 */
        l_0x1008_29d7:
            ii(0x1008_29d7, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1008_29db, 2);  if(jz(0x1008_29fc, 0x1f)) goto l_0x1008_29fc;/* jz 0x100829fc */
            ii(0x1008_29dd, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_29e0, 5);  call(0x1015_26ac, 0xc_fcc7);          /* call 0x101526ac */
            ii(0x1008_29e5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_29e7, 2);  if(jz(0x1008_29fa, 0x11)) goto l_0x1008_29fa;/* jz 0x100829fa */
            ii(0x1008_29e9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_29ec, 5);  call(0x1007_63a0, -0xc651);           /* call 0x100763a0 */
            ii(0x1008_29f1, 5);  call(0x1015_26ac, 0xc_fcb6);          /* call 0x101526ac */
            ii(0x1008_29f6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_29f8, 2);  if(jz(0x1008_29fc, 2)) goto l_0x1008_29fc;/* jz 0x100829fc */
        l_0x1008_29fa:
            ii(0x1008_29fa, 2);  jmp(0x1008_2a07, 0xb); goto l_0x1008_2a07;/* jmp 0x10082a07 */
        l_0x1008_29fc:
            ii(0x1008_29fc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_29ff, 5);  call(0x1007_63d4, -0xc630);           /* call 0x100763d4 */
            ii(0x1008_2a04, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_2a07:
            ii(0x1008_2a07, 5);  jmp(0x1008_294a, -0xc2); goto l_0x1008_294a;/* jmp 0x1008294a */
        l_0x1008_2a0c:
            ii(0x1008_2a0c, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1008_2a10, 6);  if(jz(0x1008_2a9a, 0x84)) goto l_0x1008_2a9a;/* jz 0x10082a9a */
            ii(0x1008_2a16, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_2a18, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_2a1b, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x1008_2a1e, 5);  call(0x1013_ad71, 0xb_834e);          /* call 0x1013ad71 */
            ii(0x1008_2a23, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_2a25, 2);  if(jz(0x1008_2a47, 0x20)) goto l_0x1008_2a47;/* jz 0x10082a47 */
            ii(0x1008_2a27, 5);  call(0x1008_a79c, 0x7d70);            /* call 0x1008a79c */
            ii(0x1008_2a2c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1008_2a2e, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1008_2a30, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_2a33, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x1008_2a36, 5);  call(0x1007_65d0, -0xc46b);           /* call 0x100765d0 */
            ii(0x1008_2a3b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_2a3d, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_2a42, 5);  call(0x100a_53ac, 0x2_2965);          /* call 0x100a53ac */
        l_0x1008_2a47:
            ii(0x1008_2a47, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_2a4a, 5);  call(0x1015_287d, 0xc_fe2e);          /* call 0x1015287d */
            ii(0x1008_2a4f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_2a52, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_2a55, 5);  call(0x1015_27ed, 0xc_fd93);          /* call 0x101527ed */
            ii(0x1008_2a5a, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1008_2a5d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_2a60, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x1008_2a63, 5);  call(0x1007_6630, -0xc438);           /* call 0x10076630 */
            ii(0x1008_2a68, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_2a6b, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x1008_2a6e, 5);  call(0x1007_6574, -0xc4ff);           /* call 0x10076574 */
            ii(0x1008_2a73, 6);  mov(memw[ds, eax + 30], 0);           /* mov word [eax+0x1e], 0x0 */
            ii(0x1008_2a79, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_2a7c, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x1008_2a7f, 5);  call(0x1007_6574, -0xc510);           /* call 0x10076574 */
            ii(0x1008_2a84, 6);  mov(memw[ds, eax + 32], 0);           /* mov word [eax+0x20], 0x0 */
            ii(0x1008_2a8a, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_2a8e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_2a90, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_2a93, 5);  call(0x1007_5f6c, -0xcb2c);           /* call 0x10075f6c */
            ii(0x1008_2a98, 2);  jmp(0x1008_2ab4, 0x1a); goto l_0x1008_2ab4;/* jmp 0x10082ab4 */
        l_0x1008_2a9a:
            ii(0x1008_2a9a, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_2a9e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_2aa0, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_2aa3, 5);  call(0x1007_5f6c, -0xcb3c);           /* call 0x10075f6c */
            ii(0x1008_2aa8, 2);  jmp(0x1008_2ab4, 0xa); goto l_0x1008_2ab4;/* jmp 0x10082ab4 */
        //  ii(0x1008_2aaa, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1008_2aac, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1008_2aaf, 5);  call(0x1007_5f6c, -0xcb48);           /* call 0x10075f6c */
        l_0x1008_2ab4:
            ii(0x1008_2ab4, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1008_2ab7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_2ab9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_2aba, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_2abb, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_2abc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_2abd, 1);  ret();                                /* ret */
        }
    }
}
