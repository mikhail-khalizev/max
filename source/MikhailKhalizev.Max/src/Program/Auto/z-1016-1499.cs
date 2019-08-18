using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56a0cbbd-f8f8-436f-944c-7eca79ff6300")]
        public void Method_1016_1499()
        {
            ii(0x1016_1499, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1016_149e, 5); calld(Definitions.sys_check_available_stack_size, 0x48af); /* call 0x10165d52 */
            ii(0x1016_14a3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_14a4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_14a5, 1); pushd(edx);                             /* push edx */
            ii(0x1016_14a6, 1); pushd(esi);                             /* push esi */
            ii(0x1016_14a7, 1); pushd(edi);                             /* push edi */
            ii(0x1016_14a8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_14a9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_14ab, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1016_14b1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_14b4, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1016_14b9, 5); calld(0x1007_5fdc, -0xe_b4e2);          /* call 0x10075fdc */
            ii(0x1016_14be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_14c0, 6); if(jzd(0x1016_15c0, 0xfa)) goto l_0x1016_15c0; /* jz 0x101615c0 */
            ii(0x1016_14c6, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1016_14ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_14cd, 4); test(memb_a32[ds, eax + 0x14], 0x1);    /* test byte [eax+0x14], 0x1 */
            ii(0x1016_14d1, 2); if(jzd(0x1016_14de, 0xb)) goto l_0x1016_14de; /* jz 0x101614de */
            ii(0x1016_14d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_14d6, 5); calld(0x1015_3ef5, -0xd5e6);            /* call 0x10153ef5 */
            ii(0x1016_14db, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1016_14de:
            ii(0x1016_14de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_14e1, 4); test(memb_a32[ds, eax + 0x12], 0x80);   /* test byte [eax+0x12], 0x80 */
            ii(0x1016_14e5, 2); if(jnzd(0x1016_14f1, 0xa)) goto l_0x1016_14f1; /* jnz 0x101614f1 */
            ii(0x1016_14e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_14ea, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x1016_14ef, 2); if(jnzd(0x1016_151d, 0x2c)) goto l_0x1016_151d; /* jnz 0x1016151d */
        l_0x1016_14f1:
            ii(0x1016_14f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_14f4, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1016_14f7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_14fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_14fd, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1016_1500, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_1503, 5); calld(0x1007_3d48, -0xe_d7c0);          /* call 0x10073d48 */
            ii(0x1016_1508, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_150d, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1016_1510, 2); if(jnzd(0x1016_151d, 0xb)) goto l_0x1016_151d; /* jnz 0x1016151d */
            ii(0x1016_1512, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1515, 5); calld(0x1015_3d99, -0xd781);            /* call 0x10153d99 */
            ii(0x1016_151a, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1016_151d:
            ii(0x1016_151d, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1522, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1525, 5); calld(0x1007_6d98, -0xe_a792);          /* call 0x10076d98 */
            ii(0x1016_152a, 2); test(al, al);                           /* test al, al */
            ii(0x1016_152c, 2); if(jnzd(0x1016_1538, 0xa)) goto l_0x1016_1538; /* jnz 0x10161538 */
            ii(0x1016_152e, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1016_1532, 6); if(jzd(0x1016_15c0, 0x88)) goto l_0x1016_15c0; /* jz 0x101615c0 */
        l_0x1016_1538:
            ii(0x1016_1538, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_153b, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1016_153f, 2); if(jzd(0x1016_154a, 0x9)) goto l_0x1016_154a; /* jz 0x1016154a */
            ii(0x1016_1541, 7); mov(memd_a32[ss, ebp - 0xc], 0x3f);     /* mov dword [ebp-0xc], 0x3f */
            ii(0x1016_1548, 2); jmpd(0x1016_1551, 0x7); goto l_0x1016_1551; /* jmp 0x10161551 */
        l_0x1016_154a:
            ii(0x1016_154a, 7); mov(memd_a32[ss, ebp - 0xc], 0x1f);     /* mov dword [ebp-0xc], 0x1f */
        l_0x1016_1551:
            ii(0x1016_1551, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1554, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1016_1557, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_155a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_155e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_1560, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1016_1563, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1566, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x1016_1569, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_156c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_1570, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_1572, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1016_1575, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_1579, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_157b, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x1016_157e, 1); inc(eax);                               /* inc eax */
            ii(0x1016_157f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1016_1582, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_1586, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_1588, 3); add(eax, memd_a32[ss, ebp - 0x18]);     /* add eax, [ebp-0x18] */
            ii(0x1016_158b, 1); inc(eax);                               /* inc eax */
            ii(0x1016_158c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_158f, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1016_1593, 2); if(jzd(0x1016_15b8, 0x23)) goto l_0x1016_15b8; /* jz 0x101615b8 */
            ii(0x1016_1595, 4); add(memd_a32[ss, ebp - 0x1c], -0x3 /* 0xfd */); /* add dword [ebp-0x1c], 0xfffffffd */
            ii(0x1016_1599, 4); add(memd_a32[ss, ebp - 0x18], -0x3 /* 0xfd */); /* add dword [ebp-0x18], 0xfffffffd */
            ii(0x1016_159d, 4); add(memd_a32[ss, ebp - 0x14], 0x3);     /* add dword [ebp-0x14], 0x3 */
            ii(0x1016_15a1, 4); add(memd_a32[ss, ebp - 0x10], 0x3);     /* add dword [ebp-0x10], 0x3 */
            ii(0x1016_15a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_15a8, 5); calld(0x1010_1103, -0x6_04aa);          /* call 0x10101103 */
            ii(0x1016_15ad, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1016_15b0, 2); if(jzd(0x1016_15b8, 0x6)) goto l_0x1016_15b8; /* jz 0x101615b8 */
            ii(0x1016_15b2, 6); dec(memb_a32[ds, 0x101c_947c]);         /* dec byte [0x101c947c] */
        l_0x1016_15b8:
            ii(0x1016_15b8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1016_15bb, 5); calld(0x100f_f562, -0x6_205e);          /* call 0x100ff562 */
        l_0x1016_15c0:
            ii(0x1016_15c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_15c2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_15c3, 1); popd(edi);                              /* pop edi */
            ii(0x1016_15c4, 1); popd(esi);                              /* pop esi */
            ii(0x1016_15c5, 1); popd(edx);                              /* pop edx */
            ii(0x1016_15c6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_15c7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_15c8, 1); retd(); return;                         /* ret */
        }
    }
}
