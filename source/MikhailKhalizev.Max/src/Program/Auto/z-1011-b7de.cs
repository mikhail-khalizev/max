using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b7de-99cdbe9d")]
        public void Method_1011_b7de()
        {
            ii(0x1011_b7de, 5); push(0x44);                             /* push 0x44 */
            ii(0x1011_b7e3, 5); call(Definitions.sys_check_available_stack_size, 0x4_a56a); /* call 0x10165d52 */
            ii(0x1011_b7e8, 1); push(ebx);                              /* push ebx */
            ii(0x1011_b7e9, 1); push(ecx);                              /* push ecx */
            ii(0x1011_b7ea, 1); push(esi);                              /* push esi */
            ii(0x1011_b7eb, 1); push(edi);                              /* push edi */
            ii(0x1011_b7ec, 1); push(ebp);                              /* push ebp */
            ii(0x1011_b7ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b7ef, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1011_b7f5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_b7f8, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1011_b7fb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b7fe, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_b802, 2); if(jnz(0x1011_b810, 0xc)) goto l_0x1011_b810; /* jnz 0x1011b810 */
            ii(0x1011_b804, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b807, 5); call(0x1007_60e4, -0xa_5728);           /* call 0x100760e4 */
            ii(0x1011_b80c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b80e, 2); if(jnz(0x1011_b812, 0x2)) goto l_0x1011_b812; /* jnz 0x1011b812 */
        l_0x1011_b810:
            ii(0x1011_b810, 2); jmp(0x1011_b838, 0x26); goto l_0x1011_b838; /* jmp 0x1011b838 */
        l_0x1011_b812:
            ii(0x1011_b812, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b815, 5); call(0x1007_60e4, -0xa_5736);           /* call 0x100760e4 */
            ii(0x1011_b81a, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1011_b81e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b821, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x1011_b825, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b828, 5); call(0x1007_60e4, -0xa_5749);           /* call 0x100760e4 */
            ii(0x1011_b82d, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1011_b831, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b834, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
        l_0x1011_b838:
            ii(0x1011_b838, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b83b, 3); mov(eax, memd[ds, eax + 0x3f]);         /* mov eax, [eax+0x3f] */
            ii(0x1011_b83e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_b841, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b843, 2); if(jl(0x1011_b855, 0x10)) goto l_0x1011_b855; /* jl 0x1011b855 */
            ii(0x1011_b845, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b848, 4); mov(ax, memw[ds, eax + 0x41]);          /* mov ax, [eax+0x41] */
            ii(0x1011_b84c, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_b853, 2); if(jl(0x1011_b857, 0x2)) goto l_0x1011_b857; /* jl 0x1011b857 */
        l_0x1011_b855:
            ii(0x1011_b855, 2); jmp(0x1011_b864, 0xd); goto l_0x1011_b864; /* jmp 0x1011b864 */
        l_0x1011_b857:
            ii(0x1011_b857, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b85a, 3); mov(eax, memd[ds, eax + 0x41]);         /* mov eax, [eax+0x41] */
            ii(0x1011_b85d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_b860, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_b862, 2); if(jge(0x1011_b866, 0x2)) goto l_0x1011_b866; /* jge 0x1011b866 */
        l_0x1011_b864:
            ii(0x1011_b864, 2); jmp(0x1011_b876, 0x10); goto l_0x1011_b876; /* jmp 0x1011b876 */
        l_0x1011_b866:
            ii(0x1011_b866, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b869, 4); mov(ax, memw[ds, eax + 0x43]);          /* mov ax, [eax+0x43] */
            ii(0x1011_b86d, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1011_b874, 2); if(jl(0x1011_b89d, 0x27)) goto l_0x1011_b89d; /* jl 0x1011b89d */
        l_0x1011_b876:
            ii(0x1011_b876, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_b878, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b87b, 5); call(0x1014_f017, 0x3_3797);            /* call 0x1014f017 */
            ii(0x1011_b880, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_b887, 2); if(jz(0x1011_b891, 0x8)) goto l_0x1011_b891; /* jz 0x1011b891 */
            ii(0x1011_b889, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b88c, 5); call(0x1012_b020, 0xf78f);              /* call 0x1012b020 */
        l_0x1011_b891:
            ii(0x1011_b891, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_b898, 5); jmp(0x1011_b9d6, 0x139); goto l_0x1011_b9d6; /* jmp 0x1011b9d6 */
        l_0x1011_b89d:
            ii(0x1011_b89d, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1011_b8a2, 5); call(Definitions.sys_new, 0x4_a559);    /* call 0x10165e00 */
            ii(0x1011_b8a7, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_b8aa, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_b8ad, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_b8b0, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_b8b4, 2); if(jz(0x1011_b8ee, 0x38)) goto l_0x1011_b8ee; /* jz 0x1011b8ee */
            ii(0x1011_b8b6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b8b9, 3); mov(ebx, memd[ds, eax + 0x41]);         /* mov ebx, [eax+0x41] */
            ii(0x1011_b8bc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_b8bf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b8c2, 3); mov(edx, memd[ds, eax + 0x3f]);         /* mov edx, [eax+0x3f] */
            ii(0x1011_b8c5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_b8c8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_b8cb, 5); call(0x1007_6aac, -0xa_4e24);           /* call 0x10076aac */
            ii(0x1011_b8d0, 4); movsx(ebx, memb[ss, ebp - 0x4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x1011_b8d4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_b8d7, 3); mov(esi, memd[ss, ebp - 0x10]);         /* mov esi, [ebp-0x10] */
            ii(0x1011_b8da, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_b8dc, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1011_b8de, 5); call(0x1011_d0ea, 0x1807);              /* call 0x1011d0ea */
            ii(0x1011_b8e3, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_b8e6, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_b8e9, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_b8ec, 2); jmp(0x1011_b8f4, 0x6); goto l_0x1011_b8f4; /* jmp 0x1011b8f4 */
        l_0x1011_b8ee:
            ii(0x1011_b8ee, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_b8f1, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1011_b8f4:
            ii(0x1011_b8f4, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1011_b8f7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b8fa, 5); call(0x1012_0984, 0x5085);              /* call 0x10120984 */
            ii(0x1011_b8ff, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b902, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1011_b906, 2); if(jnz(0x1011_b90e, 0x6)) goto l_0x1011_b90e; /* jnz 0x1011b90e */
            ii(0x1011_b908, 4); mov(memb[ss, ebp - 0x28], 0x1);         /* mov byte [ebp-0x28], 0x1 */
            ii(0x1011_b90c, 2); jmp(0x1011_b912, 0x4); goto l_0x1011_b912; /* jmp 0x1011b912 */
        l_0x1011_b90e:
            ii(0x1011_b90e, 4); mov(memb[ss, ebp - 0x28], 0);           /* mov byte [ebp-0x28], 0x0 */
        l_0x1011_b912:
            ii(0x1011_b912, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_b914, 3); mov(dl, memb[ss, ebp - 0x28]);          /* mov dl, [ebp-0x28] */
            ii(0x1011_b917, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b91a, 5); call(0x100b_7f18, -0x6_3a07);           /* call 0x100b7f18 */
            ii(0x1011_b91f, 5); call(0x1011_d82f, 0x1f0b);              /* call 0x1011d82f */
            ii(0x1011_b924, 4); test(memb[ss, ebp - 0x4], 0x1);         /* test byte [ebp-0x4], 0x1 */
            ii(0x1011_b928, 2); if(jz(0x1011_b93c, 0x12)) goto l_0x1011_b93c; /* jz 0x1011b93c */
            ii(0x1011_b92a, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1011_b92f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b932, 5); call(0x100b_7f18, -0x6_3a1f);           /* call 0x100b7f18 */
            ii(0x1011_b937, 5); call(0x1011_d85d, 0x1f21);              /* call 0x1011d85d */
        l_0x1011_b93c:
            ii(0x1011_b93c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b93f, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_b943, 2); if(jnz(0x1011_b96b, 0x26)) goto l_0x1011_b96b; /* jnz 0x1011b96b */
            ii(0x1011_b945, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b948, 5); call(0x1007_623c, -0xa_5711);           /* call 0x1007623c */
            ii(0x1011_b94d, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1011_b951, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_b954, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_b957, 4); imul(eax, memd[ss, ebp - 0x2c]);        /* imul eax, [ebp-0x2c] */
            ii(0x1011_b95b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_b95e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b961, 5); call(0x100b_7f18, -0x6_3a4e);           /* call 0x100b7f18 */
            ii(0x1011_b966, 5); call(0x1011_d85d, 0x1ef2);              /* call 0x1011d85d */
        l_0x1011_b96b:
            ii(0x1011_b96b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b96e, 4); cmp(memb[ds, eax + 0x3e], 0x2a);        /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1011_b972, 2); if(jnz(0x1011_b97c, 0x8)) goto l_0x1011_b97c; /* jnz 0x1011b97c */
            ii(0x1011_b974, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b977, 5); call(0x1011_fe27, 0x44ab);              /* call 0x1011fe27 */
        l_0x1011_b97c:
            ii(0x1011_b97c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b97f, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1011_b982, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_b987, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1011_b98d, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1011_b993, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_b998, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_b99b, 2); if(jnz(0x1011_b9ac, 0xf)) goto l_0x1011_b9ac; /* jnz 0x1011b9ac */
            ii(0x1011_b99d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b9a0, 5); call(0x100b_7f74, -0x6_3a31);           /* call 0x100b7f74 */
            ii(0x1011_b9a5, 5); call(0x1011_fcb2, 0x4308);              /* call 0x1011fcb2 */
            ii(0x1011_b9aa, 2); jmp(0x1011_b9b9, 0xd); goto l_0x1011_b9b9; /* jmp 0x1011b9b9 */
        l_0x1011_b9ac:
            ii(0x1011_b9ac, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b9af, 5); call(0x100b_7f74, -0x6_3a40);           /* call 0x100b7f74 */
            ii(0x1011_b9b4, 5); call(0x1011_fe58, 0x449f);              /* call 0x1011fe58 */
        l_0x1011_b9b9:
            ii(0x1011_b9b9, 7); mov(memd[ss, ebp - 0xc], 0x1);          /* mov dword [ebp-0xc], 0x1 */
            ii(0x1011_b9c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_b9c2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_b9c5, 5); call(0x100b_7368, -0x6_4662);           /* call 0x100b7368 */
            ii(0x1011_b9ca, 2); jmp(0x1011_b9d6, 0xa); goto l_0x1011_b9d6; /* jmp 0x1011b9d6 */
        //  ii(0x1011_b9cc, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1011_b9ce, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x1011_b9d1, 5); call(0x100b_7368, -0x6_466e);           /* call 0x100b7368 */
        l_0x1011_b9d6:
            ii(0x1011_b9d6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_b9d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b9db, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_b9dc, 1); pop(edi);                               /* pop edi */
            ii(0x1011_b9dd, 1); pop(esi);                               /* pop esi */
            ii(0x1011_b9de, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_b9df, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_b9e0, 1); ret();                                  /* ret */
        }
    }
}
