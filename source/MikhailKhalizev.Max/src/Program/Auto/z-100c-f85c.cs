using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f85c-61803c8b")]
        public void Method_100c_f85c()
        {
            ii(0x100c_f85c, 5); pushd(0x90);                            /* push 0x90 */
            ii(0x100c_f861, 5); calld(Definitions.sys_check_available_stack_size, 0x9_64ec); /* call 0x10165d52 */
            ii(0x100c_f866, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_f867, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_f868, 1); pushd(esi);                             /* push esi */
            ii(0x100c_f869, 1); pushd(edi);                             /* push edi */
            ii(0x100c_f86a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_f86b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f86d, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100c_f873, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_f876, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_f879, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f87c, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_f880, 2); if(jzd(0x100c_f8b0, 0x2e)) goto l_0x100c_f8b0; /* jz 0x100cf8b0 */
            ii(0x100c_f882, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f885, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_f888, 5); calld(0x100d_4f58, 0x56cb);             /* call 0x100d4f58 */
            ii(0x100c_f88d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_f88f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f892, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x100c_f896, 2); if(jnzd(0x100c_f8ae, 0x16)) goto l_0x100c_f8ae; /* jnz 0x100cf8ae */
            ii(0x100c_f898, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f89b, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_f89e, 5); calld(0x100d_4f24, 0x5681);             /* call 0x100d4f24 */
            ii(0x100c_f8a3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_f8a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f8a8, 4); cmp(dx, memw_a32[ds, eax + 0xa]);       /* cmp dx, [eax+0xa] */
            ii(0x100c_f8ac, 2); if(jzd(0x100c_f8b0, 0x2)) goto l_0x100c_f8b0; /* jz 0x100cf8b0 */
        l_0x100c_f8ae:
            ii(0x100c_f8ae, 2); jmpd(0x100c_f8b5, 0x5); goto l_0x100c_f8b5; /* jmp 0x100cf8b5 */
        l_0x100c_f8b0:
            ii(0x100c_f8b0, 5); jmpd(0x100c_f97b, 0xc6); goto l_0x100c_f97b; /* jmp 0x100cf97b */
        l_0x100c_f8b5:
            ii(0x100c_f8b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_f8b8, 3); mov(memd_a32[ss, ebp - 0x26], eax);     /* mov [ebp-0x26], eax */
            ii(0x100c_f8bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_f8be, 5); calld(/* sys */ 0x1016_7dd4, 0x9_8511); /* call 0x10167dd4 */
            ii(0x100c_f8c3, 3); mov(memd_a32[ss, ebp - 0x22], eax);     /* mov [ebp-0x22], eax */
            ii(0x100c_f8c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_f8c9, 5); calld(/* sys */ 0x1016_7e3c, 0x9_856e); /* call 0x10167e3c */
            ii(0x100c_f8ce, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x100c_f8d2, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f8d7, 5); calld(Definitions.sys_new, 0x9_6524);   /* call 0x10165e00 */
            ii(0x100c_f8dc, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100c_f8df, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100c_f8e2, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100c_f8e5, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100c_f8e9, 2); if(jzd(0x100c_f923, 0x38)) goto l_0x100c_f923; /* jz 0x100cf923 */
            ii(0x100c_f8eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f8ee, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_f8f1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f8f4, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f8f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f8f8, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x100c_f8fb, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f8fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f901, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x100c_f904, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f907, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f90a, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_f90d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_f910, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100c_f913, 5); calld(0x100d_7bdc, 0x82c4);             /* call 0x100d7bdc */
            ii(0x100c_f918, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100c_f91b, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100c_f91e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100c_f921, 2); jmpd(0x100c_f929, 0x6); goto l_0x100c_f929; /* jmp 0x100cf929 */
        l_0x100c_f923:
            ii(0x100c_f923, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100c_f926, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x100c_f929:
            ii(0x100c_f929, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100c_f92c, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100c_f92f, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x100c_f932, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100c_f935, 5); calld(0x100d_7d74, 0x843a);             /* call 0x100d7d74 */
            ii(0x100c_f93a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f93d, 3); mov(edx, memd_a32[ds, eax + 0x10]);     /* mov edx, [eax+0x10] */
            ii(0x100c_f940, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100c_f943, 5); calld(0x100d_7e01, 0x84b9);             /* call 0x100d7e01 */
            ii(0x100c_f948, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f94b, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_f94e, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100c_f951, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100c_f955, 2); if(jzd(0x100c_f96b, 0x14)) goto l_0x100c_f96b; /* jz 0x100cf96b */
            ii(0x100c_f957, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f959, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100c_f95c, 5); calld(Definitions.my_dtor_d3, 0x83d2);  /* call 0x100d7d33 */
            ii(0x100c_f961, 5); calld(Definitions.sys_delete, 0x9_65fe); /* call 0x10165f64 */
            ii(0x100c_f966, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100c_f969, 2); jmpd(0x100c_f972, 0x7); goto l_0x100c_f972; /* jmp 0x100cf972 */
        l_0x100c_f96b:
            ii(0x100c_f96b, 7); mov(memd_a32[ss, ebp - 0x54], 0);       /* mov dword [ebp-0x54], 0x0 */
        l_0x100c_f972:
            ii(0x100c_f972, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100c_f975, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_f978, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
        l_0x100c_f97b:
            ii(0x100c_f97b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f97e, 3); mov(eax, memd_a32[ds, eax + 0x24]);     /* mov eax, [eax+0x24] */
            ii(0x100c_f981, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_f984, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f987, 4); cmp(memb_a32[ds, eax + 0x28], 0);       /* cmp byte [eax+0x28], 0x0 */
            ii(0x100c_f98b, 2); if(jzd(0x100c_f9a5, 0x18)) goto l_0x100c_f9a5; /* jz 0x100cf9a5 */
            ii(0x100c_f98d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f990, 5); calld(0x100c_e809, -0x118c);            /* call 0x100ce809 */
            ii(0x100c_f995, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_f998, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f99b, 5); calld(0x100c_e850, -0x1150);            /* call 0x100ce850 */
            ii(0x100c_f9a0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_f9a3, 2); jmpd(0x100c_f9c2, 0x1d); goto l_0x100c_f9c2; /* jmp 0x100cf9c2 */
        l_0x100c_f9a5:
            ii(0x100c_f9a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9a8, 5); calld(0x100c_e897, -0x1116);            /* call 0x100ce897 */
            ii(0x100c_f9ad, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_f9b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9b3, 5); calld(0x100c_e8e2, -0x10d6);            /* call 0x100ce8e2 */
            ii(0x100c_f9b8, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_f9bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9be, 4); or(memb_a32[ds, eax + 0x24], 0x8);      /* or byte [eax+0x24], 0x8 */
        l_0x100c_f9c2:
            ii(0x100c_f9c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9c5, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100c_f9c8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f9cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9ce, 3); mov(eax, memd_a32[ds, eax + 0x20]);     /* mov eax, [eax+0x20] */
            ii(0x100c_f9d1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_f9d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9d7, 4); cmp(memd_a32[ds, eax + 0x29], 0);       /* cmp dword [eax+0x29], 0x0 */
            ii(0x100c_f9db, 2); if(jnzd(0x100c_f9e6, 0x9)) goto l_0x100c_f9e6; /* jnz 0x100cf9e6 */
            ii(0x100c_f9dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9e0, 4); cmp(memd_a32[ds, eax + 0x2d], 0);       /* cmp dword [eax+0x2d], 0x0 */
            ii(0x100c_f9e4, 2); if(jzd(0x100c_f9f2, 0xc)) goto l_0x100c_f9f2; /* jz 0x100cf9f2 */
        l_0x100c_f9e6:
            ii(0x100c_f9e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9e9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f9ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f9ef, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100c_f9f2:
            ii(0x100c_f9f2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f9f5, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f9f6, 2); pushd(0);                               /* push 0x0 */
            ii(0x100c_f9f8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_f9fb, 1); pushd(eax);                             /* push eax */
            ii(0x100c_f9fc, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_f9ff, 1); pushd(eax);                             /* push eax */
            ii(0x100c_fa00, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_fa03, 1); pushd(eax);                             /* push eax */
            ii(0x100c_fa04, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fa07, 1); pushd(eax);                             /* push eax */
            ii(0x100c_fa08, 2); pushd(-0x1 /* 0xff */);                 /* push 0xffffffff */
            ii(0x100c_fa0a, 2); pushd(-0x1 /* 0xff */);                 /* push 0xffffffff */
            ii(0x100c_fa0c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa0f, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_fa12, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_fa15, 1); pushd(eax);                             /* push eax */
            ii(0x100c_fa16, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa19, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x100c_fa1c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_fa1f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa22, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x100c_fa25, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_fa28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa2b, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_fa2e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_fa31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_fa34, 5); calld(/* sys */ 0x1016_86b0, 0x9_8c77); /* call 0x101686b0 */
            ii(0x100c_fa39, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_fa3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa3e, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100c_fa40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa43, 4); cmp(memd_a32[ds, eax + 0x29], 0);       /* cmp dword [eax+0x29], 0x0 */
            ii(0x100c_fa47, 2); if(jnzd(0x100c_fa52, 0x9)) goto l_0x100c_fa52; /* jnz 0x100cfa52 */
            ii(0x100c_fa49, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa4c, 4); cmp(memd_a32[ds, eax + 0x2d], 0);       /* cmp dword [eax+0x2d], 0x0 */
            ii(0x100c_fa50, 2); if(jzd(0x100c_fa6b, 0x19)) goto l_0x100c_fa6b; /* jz 0x100cfa6b */
        l_0x100c_fa52:
            ii(0x100c_fa52, 5); mov(eax, 0x100c_fc5e);                  /* mov eax, 0x100cfc5e */
            ii(0x100c_fa57, 1); pushd(eax);                             /* push eax */
            ii(0x100c_fa58, 5); mov(ecx, 0x100c_fbf5);                  /* mov ecx, 0x100cfbf5 */
            ii(0x100c_fa5d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_fa5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_fa61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fa64, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_fa66, 5); calld(/* sys */ 0x1016_8b98, 0x9_912d); /* call 0x10168b98 */
        l_0x100c_fa6b:
            ii(0x100c_fa6b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_fa6e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_fa71, 3); mov(memd_a32[ds, edx + 0x31], eax);     /* mov [edx+0x31], eax */
            ii(0x100c_fa74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fa76, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_fa77, 1); popd(edi);                              /* pop edi */
            ii(0x100c_fa78, 1); popd(esi);                              /* pop esi */
            ii(0x100c_fa79, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_fa7a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_fa7b, 1); retd(); return;                         /* ret */
        }
    }
}
