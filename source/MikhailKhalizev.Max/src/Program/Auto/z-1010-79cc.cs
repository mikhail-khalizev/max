using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_79cc-e7dd25a3")]
        public void Method_1010_79cc()
        {
            ii(0x1010_79cc, 5); push(0x60);                             /* push 0x60 */
            ii(0x1010_79d1, 5); call(Definitions.sys_check_available_stack_size, 0x5_e37c); /* call 0x10165d52 */
            ii(0x1010_79d6, 1); push(ebx);                              /* push ebx */
            ii(0x1010_79d7, 1); push(ecx);                              /* push ecx */
            ii(0x1010_79d8, 1); push(edx);                              /* push edx */
            ii(0x1010_79d9, 1); push(esi);                              /* push esi */
            ii(0x1010_79da, 1); push(edi);                              /* push edi */
            ii(0x1010_79db, 1); push(ebp);                              /* push ebp */
            ii(0x1010_79dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_79de, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1010_79e4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_79e7, 5); mov(eax, 0x1010_7903);                  /* mov eax, 0x10107903 */
            ii(0x1010_79ec, 5); call(/* sys */ 0x1016_c6c8, 0x6_4cd7);  /* call 0x1016c6c8 */
            ii(0x1010_79f1, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_79f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_79f8, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1010_79fb, 5); call(Definitions.sys_memset, 0x5_e3e0); /* call 0x10165de0 */
            ii(0x1010_7a00, 7); mov(memd[ss, ebp - 0x24], 0x7a00);      /* mov dword [ebp-0x24], 0x7a00 */
            ii(0x1010_7a07, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1010_7a0a, 5); mov(eax, 0x2f);                         /* mov eax, 0x2f */
            ii(0x1010_7a0f, 5); call(0x100e_44ba, -0x2_355a);           /* call 0x100e44ba */
            ii(0x1010_7a14, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_7a17, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_7a1c, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1010_7a21, 2); if(jz(0x1010_7a2f, 0xc)) goto l_0x1010_7a2f; /* jz 0x10107a2f */
            ii(0x1010_7a23, 7); mov(memd[ss, ebp - 0x44], 0xffff_fffd); /* mov dword [ebp-0x44], 0xfffffffd */
            ii(0x1010_7a2a, 5); jmp(0x1010_7e5e, 0x42f); goto l_0x1010_7e5e; /* jmp 0x10107e5e */
        l_0x1010_7a2f:
            ii(0x1010_7a2f, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1010_7a32, 6); mov(memw[ds, 0x101c_4d9a], ax);         /* mov [0x101c4d9a], ax */
            ii(0x1010_7a38, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1010_7a3b, 6); mov(memw[ds, 0x101c_4d98], ax);         /* mov [0x101c4d98], ax */
            ii(0x1010_7a41, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_7a46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7a48, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1010_7a4b, 5); call(Definitions.sys_memset, 0x5_e390); /* call 0x10165de0 */
            ii(0x1010_7a50, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_7a55, 5); mov(edx, 0x101c_4d94);                  /* mov edx, 0x101c4d94 */
            ii(0x1010_7a5a, 3); lea(eax, memd[ss, ebp - 0x4]);          /* lea eax, [ebp-0x4] */
            ii(0x1010_7a5d, 5); call(/* sys */ 0x1017_92a2, 0x7_1840);  /* call 0x101792a2 */
            ii(0x1010_7a62, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7a64, 6); mov(ax, memw[ds, 0x101c_4d94]);         /* mov ax, [0x101c4d94] */
            ii(0x1010_7a6a, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_7a6d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7a6f, 5); mov(al, memb[ds, 0x101c_4d9c]);         /* mov al, [0x101c4d9c] */
            ii(0x1010_7a74, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_7a77, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x1010_7a7e, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1010_7a81, 5); mov(eax, 0x7a);                         /* mov eax, 0x7a */
            ii(0x1010_7a86, 5); call(0x100e_44ba, -0x2_35d1);           /* call 0x100e44ba */
            ii(0x1010_7a8b, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_7a8e, 6); mov(memw[ds, 0x101c_4d94], ax);         /* mov [0x101c4d94], ax */
            ii(0x1010_7a94, 7); test(memd[ss, ebp - 0x24], 0xff);       /* test dword [ebp-0x24], 0xff */
            ii(0x1010_7a9b, 2); if(jz(0x1010_7aa9, 0xc)) goto l_0x1010_7aa9; /* jz 0x10107aa9 */
            ii(0x1010_7a9d, 7); mov(memd[ss, ebp - 0x44], 0xffff_fffe); /* mov dword [ebp-0x44], 0xfffffffe */
            ii(0x1010_7aa4, 5); jmp(0x1010_7e5e, 0x3b5); goto l_0x1010_7e5e; /* jmp 0x10107e5e */
        l_0x1010_7aa9:
            ii(0x1010_7aa9, 7); mov(memb[ds, 0x101c_4d96], 0x1);        /* mov byte [0x101c4d96], 0x1 */
            ii(0x1010_7ab0, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_7ab5, 5); call(0x100e_4bdf, -0x2_2edb);           /* call 0x100e4bdf */
            ii(0x1010_7aba, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_7abd, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_7ac1, 2); if(jnz(0x1010_7acf, 0xc)) goto l_0x1010_7acf; /* jnz 0x10107acf */
            ii(0x1010_7ac3, 7); mov(memd[ss, ebp - 0x44], 0xffff_fffc); /* mov dword [ebp-0x44], 0xfffffffc */
            ii(0x1010_7aca, 5); jmp(0x1010_7e5e, 0x38f); goto l_0x1010_7e5e; /* jmp 0x10107e5e */
        l_0x1010_7acf:
            ii(0x1010_7acf, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_7ad4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7ad6, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1010_7ad9, 5); call(Definitions.sys_memset, 0x5_e302); /* call 0x10165de0 */
            ii(0x1010_7ade, 7); mov(memd[ss, ebp - 0x30], 0x9);         /* mov dword [ebp-0x30], 0x9 */
            ii(0x1010_7ae5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_7ae8, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1010_7aeb, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1010_7aee, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_7af1, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1010_7af4, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_7af9, 4); mov(memw[ss, ebp - 0x1e], ax);          /* mov [ebp-0x1e], ax */
            ii(0x1010_7afd, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1010_7b00, 5); mov(eax, 0x7a);                         /* mov eax, 0x7a */
            ii(0x1010_7b05, 5); call(0x100e_44ba, -0x2_3650);           /* call 0x100e44ba */
            ii(0x1010_7b0a, 7); test(memd[ss, ebp - 0x24], 0xff);       /* test dword [ebp-0x24], 0xff */
            ii(0x1010_7b11, 2); if(jz(0x1010_7b1f, 0xc)) goto l_0x1010_7b1f; /* jz 0x10107b1f */
            ii(0x1010_7b13, 7); mov(memd[ss, ebp - 0x44], 0xffff_fffe); /* mov dword [ebp-0x44], 0xfffffffe */
            ii(0x1010_7b1a, 5); jmp(0x1010_7e5e, 0x33f); goto l_0x1010_7e5e; /* jmp 0x10107e5e */
        l_0x1010_7b1f:
            ii(0x1010_7b1f, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1010_7b24, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_7b27, 5); mov(eax, 0x101c_4da0);                  /* mov eax, 0x101c4da0 */
            ii(0x1010_7b2c, 5); call(Definitions.sys_memcpy, 0x5_e31a); /* call 0x10165e4b */
            ii(0x1010_7b31, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_7b36, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_7b39, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1010_7b3c, 5); mov(eax, 0x101c_4da4);                  /* mov eax, 0x101c4da4 */
            ii(0x1010_7b41, 5); call(Definitions.sys_memcpy, 0x5_e305); /* call 0x10165e4b */
            ii(0x1010_7b46, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_7b4d, 2); jmp(0x1010_7b55, 0x6); goto l_0x1010_7b55; /* jmp 0x10107b55 */
        l_0x1010_7b4f:
            ii(0x1010_7b4f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7b52, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x1010_7b55:
            ii(0x1010_7b55, 4); cmp(memd[ss, ebp - 0x8], 0x4);          /* cmp dword [ebp-0x8], 0x4 */
            ii(0x1010_7b59, 6); if(jge(0x1010_7c1f, 0xc0)) goto l_0x1010_7c1f; /* jge 0x10107c1f */
            ii(0x1010_7b5f, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_7b64, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7b66, 4); imul(eax, memd[ss, ebp - 0x8], 0x6);    /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1010_7b6a, 5); mov(ecx, 0x101c_4090);                  /* mov ecx, 0x101c4090 */
            ii(0x1010_7b6f, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_7b71, 5); call(Definitions.sys_memset, 0x5_e26a); /* call 0x10165de0 */
            ii(0x1010_7b76, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7b79, 7); mov(memb[ds, eax + 0x101c_40b0], 0);    /* mov byte [eax+0x101c40b0], 0x0 */
            ii(0x1010_7b80, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7b83, 7); mov(memb[ds, eax + 0x101c_40b4], 0);    /* mov byte [eax+0x101c40b4], 0x0 */
            ii(0x1010_7b8a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7b8d, 7); mov(memb[ds, eax + 0x101c_40b8], 0);    /* mov byte [eax+0x101c40b8], 0x0 */
            ii(0x1010_7b94, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7b97, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_7b9a, 10); mov(memd[ds, eax + 0x101c_4130], 0);   /* mov dword [eax+0x101c4130], 0x0 */
            ii(0x1010_7ba4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7ba7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_7baa, 10); mov(memd[ds, eax + 0x101c_4770], 0);   /* mov dword [eax+0x101c4770], 0x0 */
            ii(0x1010_7bb4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7bb7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_7bba, 10); mov(memd[ds, eax + 0x101c_4160], 0);   /* mov dword [eax+0x101c4160], 0x0 */
            ii(0x1010_7bc4, 5); mov(ebx, 0x100);                        /* mov ebx, 0x100 */
            ii(0x1010_7bc9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7bcb, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1010_7bce, 3); shl(ecx, 0x8);                          /* shl ecx, 0x8 */
            ii(0x1010_7bd1, 5); mov(eax, 0x101c_4370);                  /* mov eax, 0x101c4370 */
            ii(0x1010_7bd6, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_7bd8, 5); call(Definitions.sys_memset, 0x5_e203); /* call 0x10165de0 */
            ii(0x1010_7bdd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7be0, 7); mov(memb[ds, eax + 0x101c_4d80], 0);    /* mov byte [eax+0x101c4d80], 0x0 */
            ii(0x1010_7be7, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_7bec, 5); call(Definitions.sys_malloc, 0x6_33ed); /* call 0x1016afde */
            ii(0x1010_7bf1, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_7bf4, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_7bf7, 6); mov(memd[ds, edx + 0x101c_4140], eax);  /* mov [edx+0x101c4140], eax */
            ii(0x1010_7bfd, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_7c02, 5); call(Definitions.sys_malloc, 0x6_33d7); /* call 0x1016afde */
            ii(0x1010_7c07, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_7c0a, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_7c0d, 6); mov(memd[ds, edx + 0x101c_4150], eax);  /* mov [edx+0x101c4150], eax */
            ii(0x1010_7c13, 7); mov(memb[ds, 0x101c_4d97], 0x1);        /* mov byte [0x101c4d97], 0x1 */
            ii(0x1010_7c1a, 5); jmp(0x1010_7b4f, -0xd0); goto l_0x1010_7b4f; /* jmp 0x10107b4f */
        l_0x1010_7c1f:
            ii(0x1010_7c1f, 5); mov(edx, 0x101c_4db4);                  /* mov edx, 0x101c4db4 */
            ii(0x1010_7c24, 5); mov(eax, 0x4ec0);                       /* mov eax, 0x4ec0 */
            ii(0x1010_7c29, 5); call(0x100e_43e1, -0x2_384d);           /* call 0x100e43e1 */
            ii(0x1010_7c2e, 5); mov(memd[ds, 0x101c_4dac], eax);        /* mov [0x101c4dac], eax */
            ii(0x1010_7c33, 7); cmp(memd[ds, 0x101c_4dac], 0);          /* cmp dword [0x101c4dac], 0x0 */
            ii(0x1010_7c3a, 2); if(jnz(0x1010_7c48, 0xc)) goto l_0x1010_7c48; /* jnz 0x10107c48 */
            ii(0x1010_7c3c, 7); mov(memd[ss, ebp - 0x44], 0xffff_fffc); /* mov dword [ebp-0x44], 0xfffffffc */
            ii(0x1010_7c43, 5); jmp(0x1010_7e5e, 0x216); goto l_0x1010_7e5e; /* jmp 0x10107e5e */
        l_0x1010_7c48:
            ii(0x1010_7c48, 5); mov(edx, 0x4ec0);                       /* mov edx, 0x4ec0 */
            ii(0x1010_7c4d, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7c52, 5); call(0x100e_46e6, -0x2_3571);           /* call 0x100e46e6 */
            ii(0x1010_7c57, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_7c59, 2); if(jnz(0x1010_7c67, 0xc)) goto l_0x1010_7c67; /* jnz 0x10107c67 */
            ii(0x1010_7c5b, 7); mov(memd[ss, ebp - 0x44], 0xffff_fffc); /* mov dword [ebp-0x44], 0xfffffffc */
            ii(0x1010_7c62, 5); jmp(0x1010_7e5e, 0x1f7); goto l_0x1010_7e5e; /* jmp 0x10107e5e */
        l_0x1010_7c67:
            ii(0x1010_7c67, 5); mov(ebx, 0x4ec0);                       /* mov ebx, 0x4ec0 */
            ii(0x1010_7c6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7c6e, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7c73, 5); call(Definitions.sys_memset, 0x5_e168); /* call 0x10165de0 */
            ii(0x1010_7c78, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_7c7f, 2); jmp(0x1010_7c87, 0x6); goto l_0x1010_7c87; /* jmp 0x10107c87 */
        l_0x1010_7c81:
            ii(0x1010_7c81, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7c84, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x1010_7c87:
            ii(0x1010_7c87, 4); cmp(memd[ss, ebp - 0x8], 0x4);          /* cmp dword [ebp-0x8], 0x4 */
            ii(0x1010_7c8b, 6); if(jge(0x1010_7d6d, 0xdc)) goto l_0x1010_7d6d; /* jge 0x10107d6d */
            ii(0x1010_7c91, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7c98, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7c9e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7ca0, 7); mov(dx, memw[ds, 0x101c_4d94]);         /* mov dx, [0x101c4d94] */
            ii(0x1010_7ca7, 4); mov(memw[ds, eax + 0xa], dx);           /* mov [eax+0xa], dx */
            ii(0x1010_7cab, 7); imul(edx, memd[ss, ebp - 0x8], 0x276);  /* imul edx, [ebp-0x8], 0x276 */
            ii(0x1010_7cb2, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7cb7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7cb9, 6); mov(memw[ds, eax + 0x22], 0x1);         /* mov word [eax+0x22], 0x1 */
            ii(0x1010_7cbf, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7cc6, 7); add(ax, memw[ds, 0x101c_4dac]);         /* add ax, [0x101c4dac] */
            ii(0x1010_7ccd, 5); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1010_7cd2, 5); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1010_7cd7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7cd9, 7); imul(ebx, memd[ss, ebp - 0x8], 0x276);  /* imul ebx, [ebp-0x8], 0x276 */
            ii(0x1010_7ce0, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7ce5, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_7ce7, 4); mov(memw[ds, eax + 0x24], dx);          /* mov [eax+0x24], dx */
            ii(0x1010_7ceb, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7cf2, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7cf8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7cfa, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1010_7cfd, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1010_7d00, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_7d05, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_7d07, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7d0e, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7d14, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7d16, 4); mov(memw[ds, eax + 0x26], bx);          /* mov [eax+0x26], bx */
            ii(0x1010_7d1a, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7d21, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7d27, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7d29, 4); mov(memb[ds, eax + 0x2f], 0x4);         /* mov byte [eax+0x2f], 0x4 */
            ii(0x1010_7d2d, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7d34, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7d3a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7d3c, 7); mov(dx, memw[ds, 0x101c_4d94]);         /* mov dx, [0x101c4d94] */
            ii(0x1010_7d43, 4); mov(memw[ds, eax + 0x3a], dx);          /* mov [eax+0x3a], dx */
            ii(0x1010_7d47, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1010_7d4c, 5); mov(edx, 0x101c_4da0);                  /* mov edx, 0x101c4da0 */
            ii(0x1010_7d51, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7d58, 6); mov(ecx, memd[ds, 0x101c_4dac]);        /* mov ecx, [0x101c4dac] */
            ii(0x1010_7d5e, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_7d60, 3); add(eax, 0x30);                         /* add eax, 0x30 */
            ii(0x1010_7d63, 5); call(Definitions.sys_memcpy, 0x5_e0e3); /* call 0x10165e4b */
            ii(0x1010_7d68, 5); jmp(0x1010_7c81, -0xec); goto l_0x1010_7c81; /* jmp 0x10107c81 */
        l_0x1010_7d6d:
            ii(0x1010_7d6d, 9); mov(memw[ds, 0x101c_4db6], 0);          /* mov word [0x101c4db6], 0x0 */
            ii(0x1010_7d76, 7); mov(memd[ss, ebp - 0x8], 0x4);          /* mov dword [ebp-0x8], 0x4 */
            ii(0x1010_7d7d, 2); jmp(0x1010_7d85, 0x6); goto l_0x1010_7d85; /* jmp 0x10107d85 */
        l_0x1010_7d7f:
            ii(0x1010_7d7f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7d82, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x1010_7d85:
            ii(0x1010_7d85, 4); cmp(memd[ss, ebp - 0x8], 0x20);         /* cmp dword [ebp-0x8], 0x20 */
            ii(0x1010_7d89, 6); if(jge(0x1010_7e57, 0xc8)) goto l_0x1010_7e57; /* jge 0x10107e57 */
            ii(0x1010_7d8f, 7); imul(edx, memd[ss, ebp - 0x8], 0x276);  /* imul edx, [ebp-0x8], 0x276 */
            ii(0x1010_7d96, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7d9b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7d9d, 4); mov(memb[ds, eax + 0x8], 0);            /* mov byte [eax+0x8], 0x0 */
            ii(0x1010_7da1, 7); imul(edx, memd[ss, ebp - 0x8], 0x276);  /* imul edx, [ebp-0x8], 0x276 */
            ii(0x1010_7da8, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7dad, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7daf, 7); mov(dx, memw[ds, 0x101c_4d94]);         /* mov dx, [0x101c4d94] */
            ii(0x1010_7db6, 4); mov(memw[ds, eax + 0xa], dx);           /* mov [eax+0xa], dx */
            ii(0x1010_7dba, 7); imul(edx, memd[ss, ebp - 0x8], 0x276);  /* imul edx, [ebp-0x8], 0x276 */
            ii(0x1010_7dc1, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7dc6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7dc8, 6); mov(memw[ds, eax + 0x22], 0x1);         /* mov word [eax+0x22], 0x1 */
            ii(0x1010_7dce, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7dd5, 7); add(ax, memw[ds, 0x101c_4dac]);         /* add ax, [0x101c4dac] */
            ii(0x1010_7ddc, 5); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1010_7de1, 5); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1010_7de6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7de8, 7); imul(ebx, memd[ss, ebp - 0x8], 0x276);  /* imul ebx, [ebp-0x8], 0x276 */
            ii(0x1010_7def, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7df4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_7df6, 4); mov(memw[ds, eax + 0x24], dx);          /* mov [eax+0x24], dx */
            ii(0x1010_7dfa, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7e01, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7e07, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7e09, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1010_7e0c, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1010_7e0f, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_7e14, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_7e16, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7e1d, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7e23, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7e25, 4); mov(memw[ds, eax + 0x26], bx);          /* mov [eax+0x26], bx */
            ii(0x1010_7e29, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7e30, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7e36, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7e38, 6); mov(memw[ds, eax + 0x28], 0x24c);       /* mov word [eax+0x28], 0x24c */
            ii(0x1010_7e3e, 7); imul(eax, memd[ss, ebp - 0x8], 0x276);  /* imul eax, [ebp-0x8], 0x276 */
            ii(0x1010_7e45, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_7e4b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7e4d, 5); call(0x1010_6ee0, -0xf72);              /* call 0x10106ee0 */
            ii(0x1010_7e52, 5); jmp(0x1010_7d7f, -0xd8); goto l_0x1010_7d7f; /* jmp 0x10107d7f */
        l_0x1010_7e57:
            ii(0x1010_7e57, 7); mov(memd[ss, ebp - 0x44], 0);           /* mov dword [ebp-0x44], 0x0 */
        l_0x1010_7e5e:
            ii(0x1010_7e5e, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1010_7e61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_7e63, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_7e64, 1); pop(edi);                               /* pop edi */
            ii(0x1010_7e65, 1); pop(esi);                               /* pop esi */
            ii(0x1010_7e66, 1); pop(edx);                               /* pop edx */
            ii(0x1010_7e67, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_7e68, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_7e69, 1); ret();                                  /* ret */
        }
    }
}
