using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d0f4-a9806bdb")]
        public void /* sys */ Method_1016_d0f4()
        {
            ii(0x1016_d0f4, 1); push(ebx);                              /* push ebx */
            ii(0x1016_d0f5, 1); push(ecx);                              /* push ecx */
            ii(0x1016_d0f6, 1); push(edx);                              /* push edx */
            ii(0x1016_d0f7, 1); push(esi);                              /* push esi */
            ii(0x1016_d0f8, 1); push(edi);                              /* push edi */
            ii(0x1016_d0f9, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_d0fc, 7); cmp(memd[ds, 0x101b_debc], 0);          /* cmp dword [0x101bdebc], 0x0 */
            ii(0x1016_d103, 2); if(jz(0x1016_d10b, 0x6)) goto l_0x1016_d10b; /* jz 0x1016d10b */
            ii(0x1016_d105, 6); call_abs(memd[ds, 0x101b_debc]);        /* call dword [0x101bdebc] */
        l_0x1016_d10b:
            ii(0x1016_d10b, 7); cmp(memd[ds, 0x1020_8580], 0);          /* cmp dword [0x10208580], 0x0 */
            ii(0x1016_d112, 2); if(jz(0x1016_d121, 0xd)) goto l_0x1016_d121; /* jz 0x1016d121 */
            ii(0x1016_d114, 5); mov(edx, 0x200);                        /* mov edx, 0x200 */
            ii(0x1016_d119, 6); call_abs(memd[ds, 0x1020_8580]);        /* call dword [0x10208580] */
            ii(0x1016_d11f, 2); jmp(0x1016_d126, 0x5); goto l_0x1016_d126; /* jmp 0x1016d126 */
        l_0x1016_d121:
            ii(0x1016_d121, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_d126:
            ii(0x1016_d126, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_d128, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_d12b, 2); if(jnz(0x1016_d13f, 0x12)) goto l_0x1016_d13f; /* jnz 0x1016d13f */
            ii(0x1016_d12d, 5); mov(ecx, StringDefinitions.ColorCColorTableNotFound); /* mov ecx, 0x101b2e4c */
            ii(0x1016_d132, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_d134, 6); mov(memd[ds, 0x101b_dea0], ecx);        /* mov [0x101bdea0], ecx */
            ii(0x1016_d13a, 5); jmp(0x1016_d2b8, 0x179); goto l_0x1016_d2b8; /* jmp 0x1016d2b8 */
        l_0x1016_d13f:
            ii(0x1016_d13f, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_d141, 2); xor(edi, edi);                          /* xor edi, edi */
        l_0x1016_d143:
            ii(0x1016_d143, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d14a, 2); if(jz(0x1016_d15d, 0x11)) goto l_0x1016_d15d; /* jz 0x1016d15d */
            ii(0x1016_d14c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_d151, 4); lea(edx, memd[ss, esp + 0x8]);          /* lea edx, [esp+0x8] */
            ii(0x1016_d155, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d157, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d15d:
            ii(0x1016_d15d, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d164, 2); if(jz(0x1016_d177, 0x11)) goto l_0x1016_d177; /* jz 0x1016d177 */
            ii(0x1016_d166, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_d16b, 4); lea(edx, memd[ss, esp + 0x4]);          /* lea edx, [esp+0x4] */
            ii(0x1016_d16f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d171, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d177:
            ii(0x1016_d177, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d17e, 2); if(jz(0x1016_d191, 0x11)) goto l_0x1016_d191; /* jz 0x1016d191 */
            ii(0x1016_d180, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_d185, 4); lea(edx, memd[ss, esp + 0xc]);          /* lea edx, [esp+0xc] */
            ii(0x1016_d189, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d18b, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d191:
            ii(0x1016_d191, 5); cmp(memb[ss, esp + 0x8], 0x3f);         /* cmp byte [esp+0x8], 0x3f */
            ii(0x1016_d196, 2); if(ja(0x1016_d1a6, 0xe)) goto l_0x1016_d1a6; /* ja 0x1016d1a6 */
            ii(0x1016_d198, 5); cmp(memb[ss, esp + 0x4], 0x3f);         /* cmp byte [esp+0x4], 0x3f */
            ii(0x1016_d19d, 2); if(ja(0x1016_d1a6, 0x7)) goto l_0x1016_d1a6; /* ja 0x1016d1a6 */
            ii(0x1016_d19f, 5); cmp(memb[ss, esp + 0xc], 0x3f);         /* cmp byte [esp+0xc], 0x3f */
            ii(0x1016_d1a4, 2); if(jbe(0x1016_d1bc, 0x16)) goto l_0x1016_d1bc; /* jbe 0x1016d1bc */
        l_0x1016_d1a6:
            ii(0x1016_d1a6, 2); xor(bh, bh);                            /* xor bh, bh */
            ii(0x1016_d1a8, 4); mov(memb[ss, esp + 0x8], bh);           /* mov [esp+0x8], bh */
            ii(0x1016_d1ac, 4); mov(memb[ss, esp + 0x4], bh);           /* mov [esp+0x4], bh */
            ii(0x1016_d1b0, 4); mov(memb[ss, esp + 0xc], bh);           /* mov [esp+0xc], bh */
            ii(0x1016_d1b4, 6); mov(memb[ds, esi + 0x101d_0420], bh);   /* mov [esi+0x101d0420], bh */
            ii(0x1016_d1ba, 2); jmp(0x1016_d1c3, 0x7); goto l_0x1016_d1c3; /* jmp 0x1016d1c3 */
        l_0x1016_d1bc:
            ii(0x1016_d1bc, 7); mov(memb[ds, esi + 0x101d_0420], 0x1);  /* mov byte [esi+0x101d0420], 0x1 */
        l_0x1016_d1c3:
            ii(0x1016_d1c3, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1016_d1c6, 4); mov(al, memb[ss, esp + 0x8]);           /* mov al, [esp+0x8] */
            ii(0x1016_d1ca, 6); mov(memb[ds, edi + 0x101b_debd], al);   /* mov [edi+0x101bdebd], al */
            ii(0x1016_d1d0, 4); mov(al, memb[ss, esp + 0x4]);           /* mov al, [esp+0x4] */
            ii(0x1016_d1d4, 6); mov(memb[ds, edi + 0x101b_debe], al);   /* mov [edi+0x101bdebe], al */
            ii(0x1016_d1da, 4); mov(al, memb[ss, esp + 0xc]);           /* mov al, [esp+0xc] */
            ii(0x1016_d1de, 1); inc(esi);                               /* inc esi */
            ii(0x1016_d1df, 6); mov(memb[ds, edi + 0x101b_debf], al);   /* mov [edi+0x101bdebf], al */
            ii(0x1016_d1e5, 6); cmp(esi, 0x100);                        /* cmp esi, 0x100 */
            ii(0x1016_d1eb, 6); if(jl(0x1016_d143, -0xae)) goto l_0x1016_d143; /* jl 0x1016d143 */
            ii(0x1016_d1f1, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d1f8, 2); if(jz(0x1016_d20c, 0x12)) goto l_0x1016_d20c; /* jz 0x1016d20c */
            ii(0x1016_d1fa, 5); mov(ebx, 0x8000);                       /* mov ebx, 0x8000 */
            ii(0x1016_d1ff, 5); mov(edx, 0x1020_0520);                  /* mov edx, 0x10200520 */
            ii(0x1016_d204, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d206, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d20c:
            ii(0x1016_d20c, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_d20e, 6); mov(edi, memd[ds, 0x1020_857c]);        /* mov edi, [0x1020857c] */
            ii(0x1016_d214, 3); mov(memd[ss, esp], esi);                /* mov [esp], esi */
            ii(0x1016_d217, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_d219, 2); if(jz(0x1016_d22a, 0xf)) goto l_0x1016_d22a; /* jz 0x1016d22a */
            ii(0x1016_d21b, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1016_d220, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_d222, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d224, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d22a:
            ii(0x1016_d22a, 7); cmp(memd[ss, esp], 0x4e45_5743);        /* cmp dword [esp], 0x4e455743 */
            ii(0x1016_d231, 2); if(jnz(0x1016_d286, 0x53)) goto l_0x1016_d286; /* jnz 0x1016d286 */
            ii(0x1016_d233, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d23a, 2); if(jz(0x1016_d24e, 0x12)) goto l_0x1016_d24e; /* jz 0x1016d24e */
            ii(0x1016_d23c, 5); mov(ebx, 0x1_0000);                     /* mov ebx, 0x10000 */
            ii(0x1016_d241, 5); mov(edx, 0x101e_0520);                  /* mov edx, 0x101e0520 */
            ii(0x1016_d246, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d248, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d24e:
            ii(0x1016_d24e, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d255, 2); if(jz(0x1016_d269, 0x12)) goto l_0x1016_d269; /* jz 0x1016d269 */
            ii(0x1016_d257, 5); mov(ebx, 0x1_0000);                     /* mov ebx, 0x10000 */
            ii(0x1016_d25c, 5); mov(edx, 0x101d_0520);                  /* mov edx, 0x101d0520 */
            ii(0x1016_d261, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d263, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
        l_0x1016_d269:
            ii(0x1016_d269, 7); cmp(memd[ds, 0x1020_857c], 0);          /* cmp dword [0x1020857c], 0x0 */
            ii(0x1016_d270, 2); if(jz(0x1016_d29d, 0x2b)) goto l_0x1016_d29d; /* jz 0x1016d29d */
            ii(0x1016_d272, 5); mov(ebx, 0x1_0000);                     /* mov ebx, 0x10000 */
            ii(0x1016_d277, 5); mov(edx, 0x101f_0520);                  /* mov edx, 0x101f0520 */
            ii(0x1016_d27c, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d27e, 6); call_abs(memd[ds, 0x1020_857c]);        /* call dword [0x1020857c] */
            ii(0x1016_d284, 2); jmp(0x1016_d29d, 0x17); goto l_0x1016_d29d; /* jmp 0x1016d29d */
        l_0x1016_d286:
            ii(0x1016_d286, 5); call(/* sys */ 0x1016_ce8c, -0x3ff);    /* call 0x1016ce8c */
            ii(0x1016_d28b, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_d28d:
            ii(0x1016_d28d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d28f, 1); inc(edx);                               /* inc edx */
            ii(0x1016_d290, 5); call(/* sys */ 0x1016_ced0, -0x3c5);    /* call 0x1016ced0 */
            ii(0x1016_d295, 6); cmp(edx, 0x100);                        /* cmp edx, 0x100 */
            ii(0x1016_d29b, 2); if(jl(0x1016_d28d, -0x10)) goto l_0x1016_d28d; /* jl 0x1016d28d */
        l_0x1016_d29d:
            ii(0x1016_d29d, 5); call(/* sys */ 0x1016_d5a0, 0x2fe);     /* call 0x1016d5a0 */
            ii(0x1016_d2a2, 7); cmp(memd[ds, 0x1020_8578], 0);          /* cmp dword [0x10208578], 0x0 */
            ii(0x1016_d2a9, 2); if(jz(0x1016_d2b3, 0x8)) goto l_0x1016_d2b3; /* jz 0x1016d2b3 */
            ii(0x1016_d2ab, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d2ad, 6); call_abs(memd[ds, 0x1020_8578]);        /* call dword [0x10208578] */
        l_0x1016_d2b3:
            ii(0x1016_d2b3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1016_d2b8:
            ii(0x1016_d2b8, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_d2bb, 1); pop(edi);                               /* pop edi */
            ii(0x1016_d2bc, 1); pop(esi);                               /* pop esi */
            ii(0x1016_d2bd, 1); pop(edx);                               /* pop edx */
            ii(0x1016_d2be, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_d2bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_d2c0, 1); ret();                                  /* ret */
        }
    }
}
