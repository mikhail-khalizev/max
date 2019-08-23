using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_58d6-7c86b1cc")]
        public void Method_1008_58d6()
        {
            ii(0x1008_58d6, 5); push(0x80);                             /* push 0x80 */
            ii(0x1008_58db, 5); call(Definitions.sys_check_available_stack_size, 0xe_0472); /* call 0x10165d52 */
            ii(0x1008_58e0, 1); push(ecx);                              /* push ecx */
            ii(0x1008_58e1, 1); push(esi);                              /* push esi */
            ii(0x1008_58e2, 1); push(edi);                              /* push edi */
            ii(0x1008_58e3, 1); push(ebp);                              /* push ebp */
            ii(0x1008_58e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_58e6, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x1008_58ec, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_58ef, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1008_58f2, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1008_58f5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_58f8, 4); cmp(memb[ds, eax + 0x15], 0x2);         /* cmp byte [eax+0x15], 0x2 */
            ii(0x1008_58fc, 2); if(jle(0x1008_5904, 0x6)) goto l_0x1008_5904; /* jle 0x10085904 */
            ii(0x1008_58fe, 4); mov(memb[ss, ebp - 0x10], 0x2);         /* mov byte [ebp-0x10], 0x2 */
            ii(0x1008_5902, 2); jmp(0x1008_5908, 0x4); goto l_0x1008_5908; /* jmp 0x10085908 */
        l_0x1008_5904:
            ii(0x1008_5904, 4); mov(memb[ss, ebp - 0x10], 0x3);         /* mov byte [ebp-0x10], 0x3 */
        l_0x1008_5908:
            ii(0x1008_5908, 4); movsx(ebx, memb[ss, ebp - 0x10]);       /* movsx ebx, byte [ebp-0x10] */
            ii(0x1008_590c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_590f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_5912, 5); call(0x100a_3671, 0x1_dd5a);            /* call 0x100a3671 */
            ii(0x1008_5917, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5919, 2); if(jz(0x1008_5924, 0x9)) goto l_0x1008_5924; /* jz 0x10085924 */
            ii(0x1008_591b, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_591f, 5); jmp(0x1008_5cd1, 0x3ad); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5924:
            ii(0x1008_5924, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5927, 4); cmp(memb[ds, eax + 0x15], 0x7);         /* cmp byte [eax+0x15], 0x7 */
            ii(0x1008_592b, 2); if(jl(0x1008_593c, 0xf)) goto l_0x1008_593c; /* jl 0x1008593c */
            ii(0x1008_592d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5930, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1008_5933, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_5938, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_593a, 2); if(jg(0x1008_5941, 0x5)) goto l_0x1008_5941; /* jg 0x10085941 */
        l_0x1008_593c:
            ii(0x1008_593c, 5); jmp(0x1008_5b07, 0x1c6); goto l_0x1008_5b07; /* jmp 0x10085b07 */
        l_0x1008_5941:
            ii(0x1008_5941, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5943, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5946, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_5949, 5); call(0x1013_ad11, 0xb_53c3);            /* call 0x1013ad11 */
            ii(0x1008_594e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5950, 2); if(jnz(0x1008_5966, 0x14)) goto l_0x1008_5966; /* jnz 0x10085966 */
            ii(0x1008_5952, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5955, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_5958, 5); call(0x1008_9d7c, 0x441f);              /* call 0x10089d7c */
            ii(0x1008_595d, 5); call(0x1008_9f70, 0x460e);              /* call 0x10089f70 */
            ii(0x1008_5962, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_5964, 2); if(jnz(0x1008_596f, 0x9)) goto l_0x1008_596f; /* jnz 0x1008596f */
        l_0x1008_5966:
            ii(0x1008_5966, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_596a, 5); jmp(0x1008_5cd1, 0x362); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_596f:
            ii(0x1008_596f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5972, 5); call(Definitions.my_ctor_0x101b_4184, -0xee87); /* call 0x10076af0 */
            ii(0x1008_5977, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_597a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_597d, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_5980, 5); call(0x1008_9d7c, 0x43f7);              /* call 0x10089d7c */
            ii(0x1008_5985, 5); call(0x100a_2d3d, 0x1_d3b3);            /* call 0x100a2d3d */
            ii(0x1008_598a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_598d, 5); call(0x1007_623c, -0xf756);             /* call 0x1007623c */
            ii(0x1008_5992, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_5994, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5997, 5); call(0x1007_623c, -0xf760);             /* call 0x1007623c */
            ii(0x1008_599c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_599e, 4); mov(ax, memw[ds, ebx + 0x12]);          /* mov ax, [ebx+0x12] */
            ii(0x1008_59a2, 4); add(ax, memw[ds, edx + 0x10]);          /* add ax, [edx+0x10] */
            ii(0x1008_59a6, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_59a9, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1008_59ad, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_59b1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_59b4, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1008_59b6, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_59b9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_59bc, 5); call(0x1007_5e64, -0xfb5d);             /* call 0x10075e64 */
            ii(0x1008_59c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_59c3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_59c6, 5); call(0x1007_0ca1, -0x1_4d2a);           /* call 0x10070ca1 */
            ii(0x1008_59cb, 1); cwde();                                 /* cwde */
            ii(0x1008_59cc, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1008_59ce, 2); if(jg(0x1008_59df, 0xf)) goto l_0x1008_59df; /* jg 0x100859df */
            ii(0x1008_59d0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_59d3, 5); call(0x1007_623c, -0xf79c);             /* call 0x1007623c */
            ii(0x1008_59d8, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1008_59dc, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_59df:
            ii(0x1008_59df, 5); call(0x1008_9764, 0x3d80);              /* call 0x10089764 */
            ii(0x1008_59e4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_59e9, 1); push(eax);                              /* push eax */
            ii(0x1008_59ea, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_59ee, 1); push(eax);                              /* push eax */
            ii(0x1008_59ef, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1008_59f4, 1); push(eax);                              /* push eax */
            ii(0x1008_59f5, 3); lea(ecx, ebp - 0x28);                   /* lea ecx, [ebp-0x28] */
            ii(0x1008_59f8, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x1008_59fb, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_59fe, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1008_5a01, 5); call(0x1007_5e64, -0xfba2);             /* call 0x10075e64 */
            ii(0x1008_5a06, 3); mov(esi, memd[ss, ebp - 0x4]);          /* mov esi, [ebp-0x4] */
            ii(0x1008_5a09, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5a0b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_5a0d, 5); call(0x1007_7381, -0xe691);             /* call 0x10077381 */
            ii(0x1008_5a12, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5a14, 2); if(jnz(0x1008_5a35, 0x1f)) goto l_0x1008_5a35; /* jnz 0x10085a35 */
            ii(0x1008_5a16, 5); call(0x1008_a79c, 0x4d81);              /* call 0x1008a79c */
            ii(0x1008_5a1b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_5a1d, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_5a1f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5a22, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_5a27, 5); call(0x100a_53ac, 0x1_f980);            /* call 0x100a53ac */
            ii(0x1008_5a2c, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_5a30, 5); jmp(0x1008_5cd1, 0x29c); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5a35:
            ii(0x1008_5a35, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_5a38, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5a3b, 4); mov(memw[ds, edx + 0x1e], ax);          /* mov [edx+0x1e], ax */
            ii(0x1008_5a3f, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1008_5a42, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5a45, 4); mov(memw[ds, edx + 0x20], ax);          /* mov [edx+0x20], ax */
            ii(0x1008_5a49, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_5a4c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5a4f, 4); cmp(ax, memw[ds, edx + 0x1a]);          /* cmp ax, [edx+0x1a] */
            ii(0x1008_5a53, 2); if(jnz(0x1008_5a61, 0xc)) goto l_0x1008_5a61; /* jnz 0x10085a61 */
            ii(0x1008_5a55, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1008_5a58, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5a5b, 4); cmp(ax, memw[ds, edx + 0x1c]);          /* cmp ax, [edx+0x1c] */
            ii(0x1008_5a5f, 2); if(jz(0x1008_5a63, 0x2)) goto l_0x1008_5a63; /* jz 0x10085a63 */
        l_0x1008_5a61:
            ii(0x1008_5a61, 2); jmp(0x1008_5a6c, 0x9); goto l_0x1008_5a6c; /* jmp 0x10085a6c */
        l_0x1008_5a63:
            ii(0x1008_5a63, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_5a67, 5); jmp(0x1008_5cd1, 0x265); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5a6c:
            ii(0x1008_5a6c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5a6f, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1008_5a72, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_5a77, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1008_5a7b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_5a7d, 6); if(jge(0x1008_5b07, 0x84)) goto l_0x1008_5b07; /* jge 0x10085b07 */
            ii(0x1008_5a83, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1008_5a88, 5); call(Definitions.sys_new, 0xe_0373);    /* call 0x10165e00 */
            ii(0x1008_5a8d, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1008_5a90, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_5a93, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1008_5a96, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1008_5a9a, 2); if(jz(0x1008_5acf, 0x33)) goto l_0x1008_5acf; /* jz 0x10085acf */
            ii(0x1008_5a9c, 5); mov(eax, 0x100b_0ebb);                  /* mov eax, 0x100b0ebb */
            ii(0x1008_5aa1, 1); push(eax);                              /* push eax */
            ii(0x1008_5aa2, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1008_5aa5, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1008_5aa8, 5); call(0x1007_5e64, -0xfc49);             /* call 0x10075e64 */
            ii(0x1008_5aad, 1); push(eax);                              /* push eax */
            ii(0x1008_5aae, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1008_5ab3, 1); push(eax);                              /* push eax */
            ii(0x1008_5ab4, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_5ab6, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1008_5ab9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5abc, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_5abf, 5); call(0x100a_c220, 0x2_675c);            /* call 0x100ac220 */
            ii(0x1008_5ac4, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_5ac7, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_5aca, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_5acd, 2); jmp(0x1008_5ad5, 0x6); goto l_0x1008_5ad5; /* jmp 0x10085ad5 */
        l_0x1008_5acf:
            ii(0x1008_5acf, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_5ad2, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x1008_5ad5:
            ii(0x1008_5ad5, 3); mov(edx, memd[ss, ebp - 0x40]);         /* mov edx, [ebp-0x40] */
            ii(0x1008_5ad8, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_5adb, 5); call(0x1008_b060, 0x5580);              /* call 0x1008b060 */
            ii(0x1008_5ae0, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_5ae3, 5); call(0x1008_af84, 0x549c);              /* call 0x1008af84 */
            ii(0x1008_5ae8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5aea, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_5aef, 5); call(0x100a_4d50, 0x1_f25c);            /* call 0x100a4d50 */
            ii(0x1008_5af4, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_5af8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5afa, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1008_5afd, 5); call(0x1008_8b7c, 0x307a);              /* call 0x10088b7c */
            ii(0x1008_5b02, 5); jmp(0x1008_5cd1, 0x1ca); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5b07:
            ii(0x1008_5b07, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5b0a, 5); call(0x1008_4dd5, -0xd3a);              /* call 0x10084dd5 */
            ii(0x1008_5b0f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_5b11, 2); if(jnz(0x1008_5b1c, 0x9)) goto l_0x1008_5b1c; /* jnz 0x10085b1c */
            ii(0x1008_5b13, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_5b17, 5); jmp(0x1008_5cd1, 0x1b5); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5b1c:
            ii(0x1008_5b1c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5b1f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5b22, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5b25, 5); call(0x1007_6e00, -0xed2a);             /* call 0x10076e00 */
            ii(0x1008_5b2a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5b2c, 2); if(jz(0x1008_5b3e, 0x10)) goto l_0x1008_5b3e; /* jz 0x10085b3e */
            ii(0x1008_5b2e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5b31, 5); call(0x1008_4a18, -0x111e);             /* call 0x10084a18 */
            ii(0x1008_5b36, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1008_5b39, 5); jmp(0x1008_5cd1, 0x193); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5b3e:
            ii(0x1008_5b3e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5b41, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5b44, 5); call(0x1007_65d0, -0xf579);             /* call 0x100765d0 */
            ii(0x1008_5b49, 5); call(0x100a_2edb, 0x1_d38d);            /* call 0x100a2edb */
            ii(0x1008_5b4e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5b50, 2); if(jnz(0x1008_5b5b, 0x9)) goto l_0x1008_5b5b; /* jnz 0x10085b5b */
            ii(0x1008_5b52, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_5b56, 5); jmp(0x1008_5cd1, 0x176); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5b5b:
            ii(0x1008_5b5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5b5e, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1008_5b62, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5b65, 4); cmp(dx, memw[ds, eax + 0x1e]);          /* cmp dx, [eax+0x1e] */
            ii(0x1008_5b69, 2); if(jnz(0x1008_5b7b, 0x10)) goto l_0x1008_5b7b; /* jnz 0x10085b7b */
            ii(0x1008_5b6b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5b6e, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1008_5b72, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5b75, 4); cmp(dx, memw[ds, eax + 0x20]);          /* cmp dx, [eax+0x20] */
            ii(0x1008_5b79, 2); if(jz(0x1008_5b7d, 0x2)) goto l_0x1008_5b7d; /* jz 0x10085b7d */
        l_0x1008_5b7b:
            ii(0x1008_5b7b, 2); jmp(0x1008_5b86, 0x9); goto l_0x1008_5b86; /* jmp 0x10085b86 */
        l_0x1008_5b7d:
            ii(0x1008_5b7d, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_5b81, 5); jmp(0x1008_5cd1, 0x14b); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5b86:
            ii(0x1008_5b86, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5b89, 5); call(0x1007_623c, -0xf952);             /* call 0x1007623c */
            ii(0x1008_5b8e, 3); mov(ebx, memd[ds, eax + 0xe]);          /* mov ebx, [eax+0xe] */
            ii(0x1008_5b91, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_5b94, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5b97, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5b9a, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5b9d, 5); call(0x1008_abbc, 0x501a);              /* call 0x1008abbc */
            ii(0x1008_5ba2, 5); call(0x100a_601a, 0x2_0473);            /* call 0x100a601a */
            ii(0x1008_5ba7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_5baa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_5bac, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_5baf, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1008_5bb1, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1008_5bb3, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1008_5bb5, 2); if(jle(0x1008_5bf5, 0x3e)) goto l_0x1008_5bf5; /* jle 0x10085bf5 */
            ii(0x1008_5bb7, 4); movsx(eax, memb[ss, ebp - 0x10]);       /* movsx eax, byte [ebp-0x10] */
            ii(0x1008_5bbb, 1); push(eax);                              /* push eax */
            ii(0x1008_5bbc, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1008_5bbf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5bc2, 5); call(0x1008_527a, -0x94d);              /* call 0x1008527a */
            ii(0x1008_5bc7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_5bc9, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_5bcc, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_5bcf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5bd2, 5); call(0x1008_3755, -0x2482);             /* call 0x10083755 */
            ii(0x1008_5bd7, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5bd9, 2); if(jz(0x1008_5be4, 0x9)) goto l_0x1008_5be4; /* jz 0x10085be4 */
            ii(0x1008_5bdb, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_5bdf, 5); jmp(0x1008_5cd1, 0xed); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5be4:
            ii(0x1008_5be4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5be7, 5); call(0x1008_61ff, 0x613);               /* call 0x100861ff */
            ii(0x1008_5bec, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_5bf0, 5); jmp(0x1008_5cd1, 0xdc); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5bf5:
            ii(0x1008_5bf5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5bf8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5bfb, 5); call(0x1008_53e6, -0x81a);              /* call 0x100853e6 */
            ii(0x1008_5c00, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5c03, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1008_5c07, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5c0a, 4); cmp(dx, memw[ds, eax + 0x1e]);          /* cmp dx, [eax+0x1e] */
            ii(0x1008_5c0e, 2); if(jnz(0x1008_5c24, 0x14)) goto l_0x1008_5c24; /* jnz 0x10085c24 */
            ii(0x1008_5c10, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5c13, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1008_5c17, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5c1a, 4); cmp(dx, memw[ds, eax + 0x20]);          /* cmp dx, [eax+0x20] */
            ii(0x1008_5c1e, 6); if(jz(0x1008_5cc5, 0xa1)) goto l_0x1008_5cc5; /* jz 0x10085cc5 */
        l_0x1008_5c24:
            ii(0x1008_5c24, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1008_5c29, 5); call(Definitions.sys_new, 0xe_01d2);    /* call 0x10165e00 */
            ii(0x1008_5c2e, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1008_5c31, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1008_5c34, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1008_5c37, 4); cmp(memd[ss, ebp - 0x50], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1008_5c3b, 2); if(jz(0x1008_5c7e, 0x41)) goto l_0x1008_5c7e; /* jz 0x10085c7e */
            ii(0x1008_5c3d, 5); mov(eax, 0x100b_0ebb);                  /* mov eax, 0x100b0ebb */
            ii(0x1008_5c42, 1); push(eax);                              /* push eax */
            ii(0x1008_5c43, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5c46, 3); mov(ebx, memd[ds, eax + 0x1e]);         /* mov ebx, [eax+0x1e] */
            ii(0x1008_5c49, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_5c4c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5c4f, 3); mov(edx, memd[ds, eax + 0x1c]);         /* mov edx, [eax+0x1c] */
            ii(0x1008_5c52, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_5c55, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_5c58, 5); call(0x1007_6aac, -0xf1b1);             /* call 0x10076aac */
            ii(0x1008_5c5d, 1); push(eax);                              /* push eax */
            ii(0x1008_5c5e, 4); movsx(eax, memb[ss, ebp - 0x10]);       /* movsx eax, byte [ebp-0x10] */
            ii(0x1008_5c62, 1); push(eax);                              /* push eax */
            ii(0x1008_5c63, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_5c65, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1008_5c68, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5c6b, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1008_5c6e, 5); call(0x100a_c220, 0x2_65ad);            /* call 0x100ac220 */
            ii(0x1008_5c73, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1008_5c76, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1008_5c79, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1008_5c7c, 2); jmp(0x1008_5c84, 0x6); goto l_0x1008_5c84; /* jmp 0x10085c84 */
        l_0x1008_5c7e:
            ii(0x1008_5c7e, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1008_5c81, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
        l_0x1008_5c84:
            ii(0x1008_5c84, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1008_5c87, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1008_5c8a, 5); call(0x1008_a5f0, 0x4961);              /* call 0x1008a5f0 */
            ii(0x1008_5c8f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_5c94, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1008_5c97, 5); call(0x1008_a520, 0x4884);              /* call 0x1008a520 */
            ii(0x1008_5c9c, 5); call(0x1008_a6a4, 0x4a03);              /* call 0x1008a6a4 */
            ii(0x1008_5ca1, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1008_5ca4, 5); call(0x1008_a57c, 0x48d3);              /* call 0x1008a57c */
            ii(0x1008_5ca9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5cab, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_5cb0, 5); call(0x100a_4d50, 0x1_f09b);            /* call 0x100a4d50 */
            ii(0x1008_5cb5, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_5cb9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5cbb, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1008_5cbe, 5); call(0x1008_8d4c, 0x3089);              /* call 0x10088d4c */
            ii(0x1008_5cc3, 2); jmp(0x1008_5cd1, 0xc); goto l_0x1008_5cd1; /* jmp 0x10085cd1 */
        l_0x1008_5cc5:
            ii(0x1008_5cc5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_5cc8, 5); call(0x1008_61ff, 0x532);               /* call 0x100861ff */
            ii(0x1008_5ccd, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1008_5cd1:
            ii(0x1008_5cd1, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1008_5cd4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_5cd6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_5cd7, 1); pop(edi);                               /* pop edi */
            ii(0x1008_5cd8, 1); pop(esi);                               /* pop esi */
            ii(0x1008_5cd9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_5cda, 1); ret();                                  /* ret */
        }
    }
}
