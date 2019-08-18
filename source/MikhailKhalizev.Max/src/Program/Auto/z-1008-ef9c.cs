using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ef9c-9191b5f2")]
        public void Method_1008_ef9c()
        {
            ii(0x1008_ef9c, 5); pushd(0x90);                            /* push 0x90 */
            ii(0x1008_efa1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_6dac); /* call 0x10165d52 */
            ii(0x1008_efa6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_efa7, 1); pushd(esi);                             /* push esi */
            ii(0x1008_efa8, 1); pushd(edi);                             /* push edi */
            ii(0x1008_efa9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_efaa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_efac, 6); sub(esp, 0x74);                         /* sub esp, 0x74 */
            ii(0x1008_efb2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_efb5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_efb8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1008_efbb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_efbe, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_84d3); /* call 0x10076af0 */
            ii(0x1008_efc3, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x1008_efc7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_efca, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_84df); /* call 0x10076af0 */
            ii(0x1008_efcf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_efd2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_efd5, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_efd8, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_efdb, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1008_efde, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_efe1, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1008_efe4, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_efe7, 3); sub(eax, memd_a32[ss, ebp - 0x34]);     /* sub eax, [ebp-0x34] */
            ii(0x1008_efea, 1); inc(eax);                               /* inc eax */
            ii(0x1008_efeb, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_efee, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1008_eff1, 1); dec(eax);                               /* dec eax */
            ii(0x1008_eff2, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1008_eff6, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_eff9, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1008_effd, 7); mov(memd_a32[ss, ebp - 0x3c], 0x7d00);  /* mov dword [ebp-0x3c], 0x7d00 */
            ii(0x1008_f004, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
            ii(0x1008_f00b, 2); jmpd(0x1008_f011, 0x4); goto l_0x1008_f011; /* jmp 0x1008f011 */
        l_0x1008_f00d:
            ii(0x1008_f00d, 4); add(memd_a32[ss, ebp - 0x40], 0x2);     /* add dword [ebp-0x40], 0x2 */
        l_0x1008_f011:
            ii(0x1008_f011, 4); movsx(eax, memw_a32[ss, ebp - 0x40]);   /* movsx eax, word [ebp-0x40] */
            ii(0x1008_f015, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1008_f018, 6); if(jged(0x1008_f0e4, 0xc6)) goto l_0x1008_f0e4; /* jge 0x1008f0e4 */
            ii(0x1008_f01e, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
            ii(0x1008_f025, 2); jmpd(0x1008_f02d, 0x6); goto l_0x1008_f02d; /* jmp 0x1008f02d */
        l_0x1008_f027:
            ii(0x1008_f027, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1008_f02a, 3); inc(memd_a32[ss, ebp - 0x44]);          /* inc dword [ebp-0x44] */
        l_0x1008_f02d:
            ii(0x1008_f02d, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1008_f030, 4); cmp(ax, memw_a32[ss, ebp - 0x38]);      /* cmp ax, [ebp-0x38] */
            ii(0x1008_f034, 6); if(jged(0x1008_f0df, 0xa5)) goto l_0x1008_f0df; /* jge 0x1008f0df */
            ii(0x1008_f03a, 4); movsx(eax, memw_a32[ss, ebp - 0x40]);   /* movsx eax, word [ebp-0x40] */
            ii(0x1008_f03e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_f041, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1008_f046, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_f048, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_f04b, 5); calld(0x1008_b1a4, -0x3eac);            /* call 0x1008b1a4 */
            ii(0x1008_f050, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_f054, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f056, 2); if(jld(0x1008_f064, 0xc)) goto l_0x1008_f064; /* jl 0x1008f064 */
            ii(0x1008_f058, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_f05b, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1008_f062, 2); if(jld(0x1008_f066, 0x2)) goto l_0x1008_f066; /* jl 0x1008f066 */
        l_0x1008_f064:
            ii(0x1008_f064, 2); jmpd(0x1008_f06e, 0x8); goto l_0x1008_f06e; /* jmp 0x1008f06e */
        l_0x1008_f066:
            ii(0x1008_f066, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x1008_f06a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f06c, 2); if(jged(0x1008_f070, 0x2)) goto l_0x1008_f070; /* jge 0x1008f070 */
        l_0x1008_f06e:
            ii(0x1008_f06e, 2); jmpd(0x1008_f07c, 0xc); goto l_0x1008_f07c; /* jmp 0x1008f07c */
        l_0x1008_f070:
            ii(0x1008_f070, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1008_f073, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1008_f07a, 2); if(jld(0x1008_f07e, 0x2)) goto l_0x1008_f07e; /* jl 0x1008f07e */
        l_0x1008_f07c:
            ii(0x1008_f07c, 2); jmpd(0x1008_f0da, 0x5c); goto l_0x1008_f0da; /* jmp 0x1008f0da */
        l_0x1008_f07e:
            ii(0x1008_f07e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_f082, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_f085, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1008_f088, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x1008_f08c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_f08e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_f090, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f092, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1008_f094, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_f098, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_f09a, 2); if(jnzd(0x1008_f0a5, 0x9)) goto l_0x1008_f0a5; /* jnz 0x1008f0a5 */
            ii(0x1008_f09c, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_f0a0, 5); jmpd(0x1008_f293, 0x1ee); goto l_0x1008_f293; /* jmp 0x1008f293 */
        l_0x1008_f0a5:
            ii(0x1008_f0a5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_f0a9, 1); pushd(eax);                             /* push eax */
            ii(0x1008_f0aa, 3); lea(ecx, ebp - 0x3c);                   /* lea ecx, [ebp-0x3c] */
            ii(0x1008_f0ad, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1008_f0b0, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_f0b3, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1008_f0b6, 5); calld(0x1007_5e64, -0x1_9257);          /* call 0x10075e64 */
            ii(0x1008_f0bb, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x1008_f0be, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f0c0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_f0c2, 5); calld(0x1008_e55a, -0xb6d);             /* call 0x1008e55a */
            ii(0x1008_f0c7, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f0c9, 2); if(jzd(0x1008_f0da, 0xf)) goto l_0x1008_f0da; /* jz 0x1008f0da */
            ii(0x1008_f0cb, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_f0ce, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_f0d1, 5); calld(0x1008_8b44, -0x6592);            /* call 0x10088b44 */
            ii(0x1008_f0d6, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
        l_0x1008_f0da:
            ii(0x1008_f0da, 5); jmpd(0x1008_f027, -0xb8); goto l_0x1008_f027; /* jmp 0x1008f027 */
        l_0x1008_f0df:
            ii(0x1008_f0df, 5); jmpd(0x1008_f00d, -0xd7); goto l_0x1008_f00d; /* jmp 0x1008f00d */
        l_0x1008_f0e4:
            ii(0x1008_f0e4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f0e7, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1008_f0ea, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1008_f0ed, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_f0f0, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1008_f0f3, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1008_f0f6, 6); sub(eax, 0xc8);                         /* sub eax, 0xc8 */
            ii(0x1008_f0fc, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1008_f0ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f102, 5); cmp(memw_a32[ds, eax + 0x13], 0x18);    /* cmp word [eax+0x13], 0x18 */
            ii(0x1008_f107, 2); if(jzd(0x1008_f113, 0xa)) goto l_0x1008_f113; /* jz 0x1008f113 */
            ii(0x1008_f109, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f10c, 5); cmp(memw_a32[ds, eax + 0x13], 0x19);    /* cmp word [eax+0x13], 0x19 */
            ii(0x1008_f111, 2); if(jnzd(0x1008_f115, 0x2)) goto l_0x1008_f115; /* jnz 0x1008f115 */
        l_0x1008_f113:
            ii(0x1008_f113, 2); jmpd(0x1008_f11f, 0xa); goto l_0x1008_f11f; /* jmp 0x1008f11f */
        l_0x1008_f115:
            ii(0x1008_f115, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f118, 5); cmp(memw_a32[ds, eax + 0x13], 0x9);     /* cmp word [eax+0x13], 0x9 */
            ii(0x1008_f11d, 2); if(jnzd(0x1008_f121, 0x2)) goto l_0x1008_f121; /* jnz 0x1008f121 */
        l_0x1008_f11f:
            ii(0x1008_f11f, 2); jmpd(0x1008_f12b, 0xa); goto l_0x1008_f12b; /* jmp 0x1008f12b */
        l_0x1008_f121:
            ii(0x1008_f121, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f124, 5); cmp(memw_a32[ds, eax + 0x13], 0x20);    /* cmp word [eax+0x13], 0x20 */
            ii(0x1008_f129, 2); if(jnzd(0x1008_f12d, 0x2)) goto l_0x1008_f12d; /* jnz 0x1008f12d */
        l_0x1008_f12b:
            ii(0x1008_f12b, 2); jmpd(0x1008_f134, 0x7); goto l_0x1008_f134; /* jmp 0x1008f134 */
        l_0x1008_f12d:
            ii(0x1008_f12d, 7); mov(memd_a32[ss, ebp - 0x54], 0x1c00);  /* mov dword [ebp-0x54], 0x1c00 */
        l_0x1008_f134:
            ii(0x1008_f134, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1008_f138, 6); if(jzd(0x1008_f28d, 0x14f)) goto l_0x1008_f28d; /* jz 0x1008f28d */
            ii(0x1008_f13e, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1008_f142, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_f145, 5); calld(0x1009_c350, 0xd206);             /* call 0x1009c350 */
            ii(0x1008_f14a, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1008_f14d, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1008_f151, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1008_f154, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_f157, 5); calld(0x1008_8b44, -0x6618);            /* call 0x10088b44 */
        l_0x1008_f15c:
            ii(0x1008_f15c, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x1008_f160, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f162, 6); if(jled(0x1008_f283, 0x11b)) goto l_0x1008_f283; /* jle 0x1008f283 */
            ii(0x1008_f168, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_f16c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_f16f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1008_f172, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x1008_f176, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_f178, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_f17a, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_f17c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_f181, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1008_f184, 6); if(jnzd(0x1008_f248, 0xbe)) goto l_0x1008_f248; /* jnz 0x1008f248 */
            ii(0x1008_f18a, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1008_f18f, 5); calld(Definitions.sys_new, 0xd_6c6c);   /* call 0x10165e00 */
            ii(0x1008_f194, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1008_f197, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1008_f19a, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1008_f19d, 4); cmp(memd_a32[ss, ebp - 0x64], 0);       /* cmp dword [ebp-0x64], 0x0 */
            ii(0x1008_f1a1, 2); if(jzd(0x1008_f1df, 0x3c)) goto l_0x1008_f1df; /* jz 0x1008f1df */
            ii(0x1008_f1a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f1a6, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_f1a9, 5); calld(0x1008_af84, -0x422a);            /* call 0x1008af84 */
            ii(0x1008_f1ae, 1); pushd(eax);                             /* push eax */
            ii(0x1008_f1af, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_f1b2, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1008_f1b5, 5); calld(0x1007_5e64, -0x1_9356);          /* call 0x10075e64 */
            ii(0x1008_f1ba, 1); pushd(eax);                             /* push eax */
            ii(0x1008_f1bb, 5); mov(ecx, 0x27);                         /* mov ecx, 0x27 */
            ii(0x1008_f1c0, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1008_f1c3, 3); add(eax, memd_a32[ss, ebp - 0x3c]);     /* add eax, [ebp-0x3c] */
            ii(0x1008_f1c6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1008_f1c9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1008_f1cc, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1008_f1cf, 5); calld(0x1008_c999, -0x283b);            /* call 0x1008c999 */
            ii(0x1008_f1d4, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1008_f1d7, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1008_f1da, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x1008_f1dd, 2); jmpd(0x1008_f1e5, 0x6); goto l_0x1008_f1e5; /* jmp 0x1008f1e5 */
        l_0x1008_f1df:
            ii(0x1008_f1df, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1008_f1e2, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
        l_0x1008_f1e5:
            ii(0x1008_f1e5, 3); mov(edx, memd_a32[ss, ebp - 0x70]);     /* mov edx, [ebp-0x70] */
            ii(0x1008_f1e8, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_f1eb, 5); calld(0x1009_c2d4, 0xd0e4);             /* call 0x1009c2d4 */
            ii(0x1008_f1f0, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_f1f3, 5); calld(0x1009_c274, 0xd07c);             /* call 0x1009c274 */
            ii(0x1008_f1f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f1fa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f1fd, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_f200, 5); calld(0x1009_ca40, 0xd83b);             /* call 0x1009ca40 */
            ii(0x1008_f205, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f207, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f20a, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_f20d, 5); calld(0x1013_ad71, 0xa_bb5f);           /* call 0x1013ad71 */
            ii(0x1008_f212, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f214, 2); if(jzd(0x1008_f232, 0x1c)) goto l_0x1008_f232; /* jz 0x1008f232 */
            ii(0x1008_f216, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_f219, 5); calld(0x1009_c2a4, 0xd086);             /* call 0x1009c2a4 */
            ii(0x1008_f21e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f220, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f223, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_f226, 5); calld(0x1008_afb4, -0x4277);            /* call 0x1008afb4 */
            ii(0x1008_f22b, 5); calld(0x1009_350b, 0x42db);             /* call 0x1009350b */
            ii(0x1008_f230, 2); jmpd(0x1008_f248, 0x16); goto l_0x1008_f248; /* jmp 0x1008f248 */
        l_0x1008_f232:
            ii(0x1008_f232, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_f235, 5); calld(0x1009_c274, 0xd03a);             /* call 0x1009c274 */
            ii(0x1008_f23a, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x1008_f23f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f241, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_f243, 5); calld(0x100a_4d50, 0x1_5b08);           /* call 0x100a4d50 */
        l_0x1008_f248:
            ii(0x1008_f248, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1008_f24c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1008_f24f, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x1008_f254, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_f256, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_f259, 5); calld(0x1008_b1a4, -0x40ba);            /* call 0x1008b1a4 */
            ii(0x1008_f25e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_f262, 1); pushd(eax);                             /* push eax */
            ii(0x1008_f263, 3); lea(ecx, ebp - 0x3c);                   /* lea ecx, [ebp-0x3c] */
            ii(0x1008_f266, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1008_f269, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1008_f26c, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1008_f26f, 5); calld(0x1007_5e64, -0x1_9410);          /* call 0x10075e64 */
            ii(0x1008_f274, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f276, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_f279, 5); calld(0x1008_e55a, -0xd24);             /* call 0x1008e55a */
            ii(0x1008_f27e, 5); jmpd(0x1008_f15c, -0x127); goto l_0x1008_f15c; /* jmp 0x1008f15c */
        l_0x1008_f283:
            ii(0x1008_f283, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f285, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_f288, 5); calld(0x1009_c0a4, 0xce17);             /* call 0x1009c0a4 */
        l_0x1008_f28d:
            ii(0x1008_f28d, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1008_f290, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1008_f293:
            ii(0x1008_f293, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_f296, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_f298, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_f299, 1); popd(edi);                              /* pop edi */
            ii(0x1008_f29a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_f29b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_f29c, 1); retd(); return;                         /* ret */
        }
    }
}
