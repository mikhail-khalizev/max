using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cf2c-1cc5ee4e")]
        public void Method_1008_cf2c()
        {
            ii(0x1008_cf2c, 5); push(0x44);                             /* push 0x44 */
            ii(0x1008_cf31, 5); call(Definitions.sys_check_available_stack_size, 0xd_8e1c); /* call 0x10165d52 */
            ii(0x1008_cf36, 1); push(ebx);                              /* push ebx */
            ii(0x1008_cf37, 1); push(ecx);                              /* push ecx */
            ii(0x1008_cf38, 1); push(esi);                              /* push esi */
            ii(0x1008_cf39, 1); push(edi);                              /* push edi */
            ii(0x1008_cf3a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_cf3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_cf3d, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1008_cf43, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_cf46, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_cf49, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cf4c, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1008_cf50, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cf53, 4); cmp(dx, memw[ds, eax + 19]);            /* cmp dx, [eax+0x13] */
            ii(0x1008_cf57, 2); if(jnz(0x1008_cf69, 0x10)) goto l_0x1008_cf69; /* jnz 0x1008cf69 */
            ii(0x1008_cf59, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cf5c, 4); mov(dx, memw[ds, eax + 26]);            /* mov dx, [eax+0x1a] */
            ii(0x1008_cf60, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cf63, 4); cmp(dx, memw[ds, eax + 33]);            /* cmp dx, [eax+0x21] */
            ii(0x1008_cf67, 2); if(jz(0x1008_cf6b, 2)) goto l_0x1008_cf6b; /* jz 0x1008cf6b */
        l_0x1008_cf69:
            ii(0x1008_cf69, 2); jmp(0x1008_cf7b, 0x10); goto l_0x1008_cf7b; /* jmp 0x1008cf7b */
        l_0x1008_cf6b:
            ii(0x1008_cf6b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cf6e, 4); mov(dx, memw[ds, eax + 28]);            /* mov dx, [eax+0x1c] */
            ii(0x1008_cf72, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cf75, 4); cmp(dx, memw[ds, eax + 35]);            /* cmp dx, [eax+0x23] */
            ii(0x1008_cf79, 2); if(jz(0x1008_cf7d, 2)) goto l_0x1008_cf7d; /* jz 0x1008cf7d */
        l_0x1008_cf7b:
            ii(0x1008_cf7b, 2); jmp(0x1008_cf86, 9); goto l_0x1008_cf86; /* jmp 0x1008cf86 */
        l_0x1008_cf7d:
            ii(0x1008_cf7d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cf80, 4); cmp(memb[ds, eax + 61], 0x10);          /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1008_cf84, 2); if(jnz(0x1008_cf8b, 5)) goto l_0x1008_cf8b; /* jnz 0x1008cf8b */
        l_0x1008_cf86:
            ii(0x1008_cf86, 5); jmp(0x1008_d1b6, 0x22b); goto l_0x1008_d1b6; /* jmp 0x1008d1b6 */
        l_0x1008_cf8b:
            ii(0x1008_cf8b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_cf8e, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1008_cf91, 5); call(0x1008_b060, -0x1f36);             /* call 0x1008b060 */
            ii(0x1008_cf96, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cf99, 4); mov(memb[ds, eax + 37], 0xb);           /* mov byte [eax+0x25], 0xb */
            ii(0x1008_cf9d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_cfa0, 5); call(0x1015_287d, 0xc_58d8);            /* call 0x1015287d */
            ii(0x1008_cfa5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_cfa7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cfaa, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_cfad, 5); call(0x1013_ad71, 0xa_ddbf);            /* call 0x1013ad71 */
            ii(0x1008_cfb2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_cfb4, 2); if(jz(0x1008_cff0, 0x3a)) goto l_0x1008_cff0; /* jz 0x1008cff0 */
            ii(0x1008_cfb6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cfb9, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_cfbc, 5); call(0x1008_af28, -0x2099);             /* call 0x1008af28 */
            ii(0x1008_cfc1, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1008_cfc4, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_cfc7, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_cfca, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_cfcd, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_cfd0, 3); call_abs(memd[ds, ebx + 56]);           /* call dword [ebx+0x38] */
            ii(0x1008_cfd3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cfd6, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_cfd9, 5); call(0x1008_af28, -0x20b6);             /* call 0x1008af28 */
            ii(0x1008_cfde, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1008_cfe1, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_cfe4, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_cfe7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_cfea, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_cfed, 3); call_abs(memd[ds, ebx + 44]);           /* call dword [ebx+0x2c] */
        l_0x1008_cff0:
            ii(0x1008_cff0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cff3, 5); cmp(memw[ds, eax + 19], 0x21);          /* cmp word [eax+0x13], 0x21 */
            ii(0x1008_cff8, 2); if(jz(0x1008_d004, 0xa)) goto l_0x1008_d004; /* jz 0x1008d004 */
            ii(0x1008_cffa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_cffd, 5); cmp(memw[ds, eax + 19], 0x27);          /* cmp word [eax+0x13], 0x27 */
            ii(0x1008_d002, 2); if(jnz(0x1008_d038, 0x34)) goto l_0x1008_d038; /* jnz 0x1008d038 */
        l_0x1008_d004:
            ii(0x1008_d004, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_d007, 3); add(edx, 0x1d);                         /* add edx, 0x1d */
            ii(0x1008_d00a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d00d, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d010, 5); call(0x1009_cbc4, 0xfbaf);              /* call 0x1009cbc4 */
            ii(0x1008_d015, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d017, 2); if(jz(0x1008_d036, 0x1d)) goto l_0x1008_d036; /* jz 0x1008d036 */
            ii(0x1008_d019, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d01c, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d01f, 5); call(0x1008_af28, -0x20fc);             /* call 0x1008af28 */
            ii(0x1008_d024, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1008_d027, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1008_d02a, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_d02d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_d030, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1008_d033, 3); call_abs(memd[ds, ebx + 44]);           /* call dword [ebx+0x2c] */
        l_0x1008_d036:
            ii(0x1008_d036, 2); jmp(0x1008_d04e, 0x16); goto l_0x1008_d04e; /* jmp 0x1008d04e */
        l_0x1008_d038:
            ii(0x1008_d038, 5); call(0x1008_a79c, -0x28a1);             /* call 0x1008a79c */
            ii(0x1008_d03d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_d03f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_d041, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_d044, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_d049, 5); call(0x100a_53ac, 0x1_835e);            /* call 0x100a53ac */
        l_0x1008_d04e:
            ii(0x1008_d04e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_d051, 3); add(edx, 0x1d);                         /* add edx, 0x1d */
            ii(0x1008_d054, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d057, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d05a, 5); call(0x1009_cbc4, 0xfb65);              /* call 0x1009cbc4 */
            ii(0x1008_d05f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d061, 2); if(jz(0x1008_d080, 0x1d)) goto l_0x1008_d080; /* jz 0x1008d080 */
            ii(0x1008_d063, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d066, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d069, 5); call(0x1008_af28, -0x2146);             /* call 0x1008af28 */
            ii(0x1008_d06e, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1008_d071, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1008_d074, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_d077, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_d07a, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1008_d07d, 3); call_abs(memd[ds, ebx + 56]);           /* call dword [ebx+0x38] */
        l_0x1008_d080:
            ii(0x1008_d080, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d082, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d085, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d088, 5); call(0x1013_ad71, 0xa_dce4);            /* call 0x1013ad71 */
            ii(0x1008_d08d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d08f, 2); if(jz(0x1008_d0a6, 0x15)) goto l_0x1008_d0a6; /* jz 0x1008d0a6 */
            ii(0x1008_d091, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d094, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d097, 5); call(0x1007_6574, -0x1_6b28);           /* call 0x10076574 */
            ii(0x1008_d09c, 5); call(0x1015_26ac, 0xc_560b);            /* call 0x101526ac */
            ii(0x1008_d0a1, 3); cmp(eax, memd[ss, ebp - 8]);            /* cmp eax, [ebp-0x8] */
            ii(0x1008_d0a4, 2); if(jz(0x1008_d0a8, 2)) goto l_0x1008_d0a8; /* jz 0x1008d0a8 */
        l_0x1008_d0a6:
            ii(0x1008_d0a6, 2); jmp(0x1008_d0b9, 0x11); goto l_0x1008_d0b9; /* jmp 0x1008d0b9 */
        l_0x1008_d0a8:
            ii(0x1008_d0a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d0aa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d0ad, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d0b0, 5); call(0x1013_ad71, 0xa_dcbc);            /* call 0x1013ad71 */
            ii(0x1008_d0b5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d0b7, 2); if(jnz(0x1008_d0bb, 2)) goto l_0x1008_d0bb; /* jnz 0x1008d0bb */
        l_0x1008_d0b9:
            ii(0x1008_d0b9, 2); jmp(0x1008_d0c5, 0xa); goto l_0x1008_d0c5; /* jmp 0x1008d0c5 */
        l_0x1008_d0bb:
            ii(0x1008_d0bb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d0be, 5); cmp(memw[ds, eax + 19], 0x21);          /* cmp word [eax+0x13], 0x21 */
            ii(0x1008_d0c3, 2); if(jz(0x1008_d0c7, 2)) goto l_0x1008_d0c7; /* jz 0x1008d0c7 */
        l_0x1008_d0c5:
            ii(0x1008_d0c5, 2); jmp(0x1008_d0e5, 0x1e); goto l_0x1008_d0e5; /* jmp 0x1008d0e5 */
        l_0x1008_d0c7:
            ii(0x1008_d0c7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d0ca, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d0cd, 5); call(0x1008_af28, -0x21aa);             /* call 0x1008af28 */
            ii(0x1008_d0d2, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_d0d5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_d0d8, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1008_d0db, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_d0de, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x1008_d0e1, 2); cmp(al, 9);                             /* cmp al, 0x9 */
            ii(0x1008_d0e3, 2); if(jz(0x1008_d0ea, 5)) goto l_0x1008_d0ea; /* jz 0x1008d0ea */
        l_0x1008_d0e5:
            ii(0x1008_d0e5, 5); jmp(0x1008_d16d, 0x83); goto l_0x1008_d16d; /* jmp 0x1008d16d */
        l_0x1008_d0ea:
            ii(0x1008_d0ea, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d0ed, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d0f0, 5); call(0x1008_afb4, -0x2141);             /* call 0x1008afb4 */
            ii(0x1008_d0f5, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1008_d0f8, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1008_d0fb, 4); cmp(memb[ds, eax + 37], 1);             /* cmp byte [eax+0x25], 0x1 */
            ii(0x1008_d0ff, 2); if(jnz(0x1008_d122, 0x21)) goto l_0x1008_d122; /* jnz 0x1008d122 */
            ii(0x1008_d101, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d104, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d107, 5); call(0x1007_6574, -0x1_6b98);           /* call 0x10076574 */
            ii(0x1008_d10c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d10e, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1008_d111, 5); call(0x1009_c4c4, 0xf3ae);              /* call 0x1009c4c4 */
            ii(0x1008_d116, 1); cwde();                                 /* cwde */
            ii(0x1008_d117, 5); call(0x100c_defa, 0x4_0dde);            /* call 0x100cdefa */
            ii(0x1008_d11c, 4); cmp(ax, memw[ds, edx + 8]);             /* cmp ax, [edx+0x8] */
            ii(0x1008_d120, 2); if(jz(0x1008_d124, 2)) goto l_0x1008_d124; /* jz 0x1008d124 */
        l_0x1008_d122:
            ii(0x1008_d122, 2); jmp(0x1008_d16d, 0x49); goto l_0x1008_d16d; /* jmp 0x1008d16d */
        l_0x1008_d124:
            ii(0x1008_d124, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_d127, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x1008_d12a, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_d12d, 5); call(0x1007_6668, -0x1_6aca);           /* call 0x10076668 */
            ii(0x1008_d132, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_d135, 5); call(0x1007_6574, -0x1_6bc6);           /* call 0x10076574 */
            ii(0x1008_d13a, 5); call(0x1015_287d, 0xc_573e);            /* call 0x1015287d */
            ii(0x1008_d13f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d142, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d145, 5); call(0x1008_af28, -0x2222);             /* call 0x1008af28 */
            ii(0x1008_d14a, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1008_d14d, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1008_d150, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_d153, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_d156, 5); call(0x1007_65d0, -0x1_6b8b);           /* call 0x100765d0 */
            ii(0x1008_d15b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d15d, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1008_d160, 3); call_abs(memd[ds, ebx + 44]);           /* call dword [ebx+0x2c] */
            ii(0x1008_d163, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d165, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_d168, 5); call(0x1007_5f2c, -0x1_7241);           /* call 0x10075f2c */
        l_0x1008_d16d:
            ii(0x1008_d16d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d16f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d172, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d175, 5); call(0x1008_afe4, -0x2196);             /* call 0x1008afe4 */
            ii(0x1008_d17a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d17c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d17f, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_d182, 5); call(0x1008_afe4, -0x21a3);             /* call 0x1008afe4 */
            ii(0x1008_d187, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d189, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d18c, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_d18f, 5); call(0x1007_6630, -0x1_6b64);           /* call 0x10076630 */
            ii(0x1008_d194, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d197, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_d19a, 5); call(0x1013_a6f4, 0xa_d555);            /* call 0x1013a6f4 */
            ii(0x1008_d19f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d1a2, 5); call(0x1008_e07b, 0xed4);               /* call 0x1008e07b */
            ii(0x1008_d1a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d1a9, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1008_d1ac, 5); call(0x1008_8b7c, -0x4635);             /* call 0x10088b7c */
            ii(0x1008_d1b1, 5); jmp(0x1008_d22a, 0x74); goto l_0x1008_d22a; /* jmp 0x1008d22a */
        l_0x1008_d1b6:
            ii(0x1008_d1b6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d1b9, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_d1bc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_d1bf, 5); call(0x100c_defa, 0x4_0d36);            /* call 0x100cdefa */
            ii(0x1008_d1c4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d1c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_d1c9, 4); cmp(dx, memw[ds, eax + 8]);             /* cmp dx, [eax+0x8] */
            ii(0x1008_d1cd, 2); if(jnz(0x1008_d22a, 0x5b)) goto l_0x1008_d22a; /* jnz 0x1008d22a */
            ii(0x1008_d1cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d1d1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d1d4, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d1d7, 5); call(0x1013_ad71, 0xa_db95);            /* call 0x1013ad71 */
            ii(0x1008_d1dc, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d1de, 2); if(jnz(0x1008_d22a, 0x4a)) goto l_0x1008_d22a; /* jnz 0x1008d22a */
            ii(0x1008_d1e0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d1e3, 4); cmp(memb[ds, eax + 37], 9);             /* cmp byte [eax+0x25], 0x9 */
            ii(0x1008_d1e7, 2); if(jge(0x1008_d22a, 0x41)) goto l_0x1008_d22a; /* jge 0x1008d22a */
            ii(0x1008_d1e9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d1ec, 4); mov(memb[ds, eax + 37], 4);             /* mov byte [eax+0x25], 0x4 */
            ii(0x1008_d1f0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_d1f3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d1f6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d1f9, 5); call(0x1007_6630, -0x1_6bce);           /* call 0x10076630 */
            ii(0x1008_d1fe, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_d201, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d204, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d207, 5); call(0x1007_6574, -0x1_6c98);           /* call 0x10076574 */
            ii(0x1008_d20c, 5); call(0x1015_27ed, 0xc_55dc);            /* call 0x101527ed */
            ii(0x1008_d211, 5); call(0x1008_b0e4, -0x2132);             /* call 0x1008b0e4 */
            ii(0x1008_d216, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d218, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1008_d21a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_d21d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d220, 5); call(0x1007_65d0, -0x1_6c55);           /* call 0x100765d0 */
            ii(0x1008_d225, 5); call(0x100a_297d, 0x1_5753);            /* call 0x100a297d */
        l_0x1008_d22a:
            ii(0x1008_d22a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d22c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_d22d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_d22e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_d22f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_d230, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_d231, 1); ret();                                  /* ret */
        }
    }
}
