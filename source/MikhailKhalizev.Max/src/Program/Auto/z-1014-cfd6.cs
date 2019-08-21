using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_cfd6-51f78f36")]
        public void Method_1014_cfd6()
        {
            ii(0x1014_cfd6, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1014_cfdb, 5); calld(Definitions.sys_check_available_stack_size, 0x1_8d72); /* call 0x10165d52 */
            ii(0x1014_cfe0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_cfe1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_cfe2, 1); pushd(esi);                             /* push esi */
            ii(0x1014_cfe3, 1); pushd(edi);                             /* push edi */
            ii(0x1014_cfe4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_cfe5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_cfe7, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1014_cfed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_cff0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_cff3, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_cff7, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_cffa, 5); calld(0x100e_0720, -0x6_c8df);          /* call 0x100e0720 */
            ii(0x1014_cfff, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_d002, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1014_d006, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x1014_d00b, 5); mov(edx, StringDefinitions.UnitType);   /* mov edx, 0x101ad2e9 */
            ii(0x1014_d010, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d013, 5); calld(0x1014_5f53, -0x70c5);            /* call 0x10145f53 */
            ii(0x1014_d018, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d01b, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1014_d01f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d022, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_d025, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_d028, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_d02b, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c0]); /* mov eax, [eax+0x101c81c0] */
            ii(0x1014_d031, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1014_d034, 5); mov(edx, StringDefinitions.Id);         /* mov edx, 0x101ad2f3 */
            ii(0x1014_d039, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d03c, 5); calld(0x1014_60aa, -0x6f97);            /* call 0x101460aa */
            ii(0x1014_d041, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d044, 4); mov(memw_a32[ds, edx + 0x7c], ax);      /* mov [edx+0x7c], ax */
            ii(0x1014_d048, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d04b, 7); mov(memd_a32[ds, eax + 0x12], 0);       /* mov dword [eax+0x12], 0x0 */
            ii(0x1014_d052, 5); mov(ebx, StringDefinitions.Flags);      /* mov ebx, 0x101ad2f6 */
            ii(0x1014_d057, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1014_d05a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d05d, 5); calld(0x1014_625c, -0x6e06);            /* call 0x1014625c */
            ii(0x1014_d062, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d064, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d067, 5); calld(0x100e_06a4, -0x6_c9c8);          /* call 0x100e06a4 */
            ii(0x1014_d06c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_d06e, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1014_d071, 5); calld(0x100e_03fc, -0x6_cc7a);          /* call 0x100e03fc */
            ii(0x1014_d076, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1014_d079, 5); and(eax, 0xfffe_ffff);                  /* and eax, 0xfffeffff */
            ii(0x1014_d07e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d081, 3); mov(memd_a32[ds, edx + 0x12], eax);     /* mov [edx+0x12], eax */
            ii(0x1014_d084, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_d086, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d089, 5); calld(0x1013_ad71, -0x1_231d);          /* call 0x1013ad71 */
            ii(0x1014_d08e, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d090, 6); if(jzd(0x1014_d31d, 0x287)) goto l_0x1014_d31d; /* jz 0x1014d31d */
            ii(0x1014_d096, 5); mov(edx, StringDefinitions.SpinningTurret); /* mov edx, 0x101ad2fc */
            ii(0x1014_d09b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d09e, 5); calld(0x100e_0648, -0x6_ca5b);          /* call 0x100e0648 */
            ii(0x1014_d0a3, 5); calld(0x1014_5ff7, -0x70b1);            /* call 0x10145ff7 */
            ii(0x1014_d0a8, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d0aa, 2); if(jzd(0x1014_d0b3, 0x7)) goto l_0x1014_d0b3; /* jz 0x1014d0b3 */
            ii(0x1014_d0ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d0af, 4); or(memb_a32[ds, eax + 0x15], 0x8);      /* or byte [eax+0x15], 0x8 */
        l_0x1014_d0b3:
            ii(0x1014_d0b3, 5); mov(edx, StringDefinitions.SentryUnit); /* mov edx, 0x101ad30c */
            ii(0x1014_d0b8, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d0bb, 5); calld(0x100e_0648, -0x6_ca78);          /* call 0x100e0648 */
            ii(0x1014_d0c0, 5); calld(0x1014_5ff7, -0x70ce);            /* call 0x10145ff7 */
            ii(0x1014_d0c5, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d0c7, 2); if(jzd(0x1014_d0d0, 0x7)) goto l_0x1014_d0d0; /* jz 0x1014d0d0 */
            ii(0x1014_d0c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d0cc, 4); or(memb_a32[ds, eax + 0x15], 0x4);      /* or byte [eax+0x15], 0x4 */
        l_0x1014_d0d0:
            ii(0x1014_d0d0, 5); mov(edx, StringDefinitions.TurretSprite); /* mov edx, 0x101ad318 */
            ii(0x1014_d0d5, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d0d8, 5); calld(0x100e_0648, -0x6_ca95);          /* call 0x100e0648 */
            ii(0x1014_d0dd, 5); calld(0x1014_5ff7, -0x70eb);            /* call 0x10145ff7 */
            ii(0x1014_d0e2, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d0e4, 2); if(jzd(0x1014_d0ed, 0x7)) goto l_0x1014_d0ed; /* jz 0x1014d0ed */
            ii(0x1014_d0e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d0e9, 4); or(memb_a32[ds, eax + 0x15], 0x2);      /* or byte [eax+0x15], 0x2 */
        l_0x1014_d0ed:
            ii(0x1014_d0ed, 5); mov(edx, StringDefinitions.RequiresSlab); /* mov edx, 0x101ad326 */
            ii(0x1014_d0f2, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d0f5, 5); calld(0x100e_0648, -0x6_cab2);          /* call 0x100e0648 */
            ii(0x1014_d0fa, 5); calld(0x1014_5ff7, -0x7108);            /* call 0x10145ff7 */
            ii(0x1014_d0ff, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d101, 2); if(jzd(0x1014_d10a, 0x7)) goto l_0x1014_d10a; /* jz 0x1014d10a */
            ii(0x1014_d103, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d106, 4); or(memb_a32[ds, eax + 0x15], 0x1);      /* or byte [eax+0x15], 0x1 */
        l_0x1014_d10a:
            ii(0x1014_d10a, 5); mov(edx, StringDefinitions.Standalone); /* mov edx, 0x101ad334 */
            ii(0x1014_d10f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d112, 5); calld(0x100e_0648, -0x6_cacf);          /* call 0x100e0648 */
            ii(0x1014_d117, 5); calld(0x1014_5ff7, -0x7125);            /* call 0x10145ff7 */
            ii(0x1014_d11c, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d11e, 2); if(jzd(0x1014_d127, 0x7)) goto l_0x1014_d127; /* jz 0x1014d127 */
            ii(0x1014_d120, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d123, 4); or(memb_a32[ds, eax + 0x14], -0x80 /* 0x80 */); /* or byte [eax+0x14], 0x80 */
        l_0x1014_d127:
            ii(0x1014_d127, 5); mov(edx, StringDefinitions.Selectable); /* mov edx, 0x101ad33f */
            ii(0x1014_d12c, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d12f, 5); calld(0x100e_0648, -0x6_caec);          /* call 0x100e0648 */
            ii(0x1014_d134, 5); calld(0x1014_5ff7, -0x7142);            /* call 0x10145ff7 */
            ii(0x1014_d139, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d13b, 2); if(jzd(0x1014_d144, 0x7)) goto l_0x1014_d144; /* jz 0x1014d144 */
            ii(0x1014_d13d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d140, 4); or(memb_a32[ds, eax + 0x14], 0x40);     /* or byte [eax+0x14], 0x40 */
        l_0x1014_d144:
            ii(0x1014_d144, 5); mov(edx, StringDefinitions.ElectronicUnit); /* mov edx, 0x101ad34a */
            ii(0x1014_d149, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d14c, 5); calld(0x100e_0648, -0x6_cb09);          /* call 0x100e0648 */
            ii(0x1014_d151, 5); calld(0x1014_5ff7, -0x715f);            /* call 0x10145ff7 */
            ii(0x1014_d156, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d158, 2); if(jnzd(0x1014_d163, 0x9)) goto l_0x1014_d163; /* jnz 0x1014d163 */
            ii(0x1014_d15a, 7); test(memd_a32[ss, ebp - 0x2c], 0x20_0000); /* test dword [ebp-0x2c], 0x200000 */
            ii(0x1014_d161, 2); if(jzd(0x1014_d16a, 0x7)) goto l_0x1014_d16a; /* jz 0x1014d16a */
        l_0x1014_d163:
            ii(0x1014_d163, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d166, 4); or(memb_a32[ds, eax + 0x14], 0x20);     /* or byte [eax+0x14], 0x20 */
        l_0x1014_d16a:
            ii(0x1014_d16a, 5); mov(edx, StringDefinitions.ConstructorUnit); /* mov edx, 0x101ad35a */
            ii(0x1014_d16f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d172, 5); calld(0x100e_0648, -0x6_cb2f);          /* call 0x100e0648 */
            ii(0x1014_d177, 5); calld(0x1014_5ff7, -0x7185);            /* call 0x10145ff7 */
            ii(0x1014_d17c, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d17e, 2); if(jzd(0x1014_d187, 0x7)) goto l_0x1014_d187; /* jz 0x1014d187 */
            ii(0x1014_d180, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d183, 4); or(memb_a32[ds, eax + 0x14], 0x8);      /* or byte [eax+0x14], 0x8 */
        l_0x1014_d187:
            ii(0x1014_d187, 5); mov(edx, StringDefinitions.FiresMissiles); /* mov edx, 0x101ad36b */
            ii(0x1014_d18c, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d18f, 5); calld(0x100e_0648, -0x6_cb4c);          /* call 0x100e0648 */
            ii(0x1014_d194, 5); calld(0x1014_5ff7, -0x71a2);            /* call 0x10145ff7 */
            ii(0x1014_d199, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d19b, 2); if(jzd(0x1014_d1a4, 0x7)) goto l_0x1014_d1a4; /* jz 0x1014d1a4 */
            ii(0x1014_d19d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d1a0, 4); or(memb_a32[ds, eax + 0x14], 0x4);      /* or byte [eax+0x14], 0x4 */
        l_0x1014_d1a4:
            ii(0x1014_d1a4, 5); mov(edx, StringDefinitions.HasFiringSprite); /* mov edx, 0x101ad37a */
            ii(0x1014_d1a9, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d1ac, 5); calld(0x100e_0648, -0x6_cb69);          /* call 0x100e0648 */
            ii(0x1014_d1b1, 5); calld(0x1014_5ff7, -0x71bf);            /* call 0x10145ff7 */
            ii(0x1014_d1b6, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d1b8, 2); if(jzd(0x1014_d1c1, 0x7)) goto l_0x1014_d1c1; /* jz 0x1014d1c1 */
            ii(0x1014_d1ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d1bd, 4); or(memb_a32[ds, eax + 0x14], 0x2);      /* or byte [eax+0x14], 0x2 */
        l_0x1014_d1c1:
            ii(0x1014_d1c1, 5); mov(edx, StringDefinitions.Hovering);   /* mov edx, 0x101ad38c */
            ii(0x1014_d1c6, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d1c9, 5); calld(0x100e_0648, -0x6_cb86);          /* call 0x100e0648 */
            ii(0x1014_d1ce, 5); calld(0x1014_5ff7, -0x71dc);            /* call 0x10145ff7 */
            ii(0x1014_d1d3, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d1d5, 2); if(jzd(0x1014_d1de, 0x7)) goto l_0x1014_d1de; /* jz 0x1014d1de */
            ii(0x1014_d1d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d1da, 4); or(memb_a32[ds, eax + 0x14], 0x1);      /* or byte [eax+0x14], 0x1 */
        l_0x1014_d1de:
            ii(0x1014_d1de, 5); mov(edx, StringDefinitions.Upgradeable); /* mov edx, 0x101ad395 */
            ii(0x1014_d1e3, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d1e6, 5); calld(0x100e_0648, -0x6_cba3);          /* call 0x100e0648 */
            ii(0x1014_d1eb, 5); calld(0x1014_5ff7, -0x71f9);            /* call 0x10145ff7 */
            ii(0x1014_d1f0, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d1f2, 2); if(jzd(0x1014_d1fb, 0x7)) goto l_0x1014_d1fb; /* jz 0x1014d1fb */
            ii(0x1014_d1f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d1f7, 4); or(memb_a32[ds, eax + 0x13], 0x40);     /* or byte [eax+0x13], 0x40 */
        l_0x1014_d1fb:
            ii(0x1014_d1fb, 5); mov(edx, StringDefinitions.Stationary); /* mov edx, 0x101ad3a1 */
            ii(0x1014_d200, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d203, 5); calld(0x100e_0648, -0x6_cbc0);          /* call 0x100e0648 */
            ii(0x1014_d208, 5); calld(0x1014_5ff7, -0x7216);            /* call 0x10145ff7 */
            ii(0x1014_d20d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d20f, 2); if(jzd(0x1014_d218, 0x7)) goto l_0x1014_d218; /* jz 0x1014d218 */
            ii(0x1014_d211, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d214, 4); or(memb_a32[ds, eax + 0x13], 0x2);      /* or byte [eax+0x13], 0x2 */
        l_0x1014_d218:
            ii(0x1014_d218, 5); mov(edx, StringDefinitions.MobileLandUnit); /* mov edx, 0x101ad3ac */
            ii(0x1014_d21d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d220, 5); calld(0x100e_0648, -0x6_cbdd);          /* call 0x100e0648 */
            ii(0x1014_d225, 5); calld(0x1014_5ff7, -0x7233);            /* call 0x10145ff7 */
            ii(0x1014_d22a, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d22c, 2); if(jzd(0x1014_d235, 0x7)) goto l_0x1014_d235; /* jz 0x1014d235 */
            ii(0x1014_d22e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d231, 4); or(memb_a32[ds, eax + 0x13], 0x1);      /* or byte [eax+0x13], 0x1 */
        l_0x1014_d235:
            ii(0x1014_d235, 5); mov(edx, StringDefinitions.MobileSeaUnit); /* mov edx, 0x101ad3bd */
            ii(0x1014_d23a, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d23d, 5); calld(0x100e_0648, -0x6_cbfa);          /* call 0x100e0648 */
            ii(0x1014_d242, 5); calld(0x1014_5ff7, -0x7250);            /* call 0x10145ff7 */
            ii(0x1014_d247, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d249, 2); if(jzd(0x1014_d252, 0x7)) goto l_0x1014_d252; /* jz 0x1014d252 */
            ii(0x1014_d24b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d24e, 4); or(memb_a32[ds, eax + 0x12], -0x80 /* 0x80 */); /* or byte [eax+0x12], 0x80 */
        l_0x1014_d252:
            ii(0x1014_d252, 5); mov(edx, StringDefinitions.MobileAirUnit); /* mov edx, 0x101ad3cd */
            ii(0x1014_d257, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d25a, 5); calld(0x100e_0648, -0x6_cc17);          /* call 0x100e0648 */
            ii(0x1014_d25f, 5); calld(0x1014_5ff7, -0x726d);            /* call 0x10145ff7 */
            ii(0x1014_d264, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d266, 2); if(jzd(0x1014_d26f, 0x7)) goto l_0x1014_d26f; /* jz 0x1014d26f */
            ii(0x1014_d268, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d26b, 4); or(memb_a32[ds, eax + 0x12], 0x40);     /* or byte [eax+0x12], 0x40 */
        l_0x1014_d26f:
            ii(0x1014_d26f, 5); mov(edx, StringDefinitions.MissileUnit); /* mov edx, 0x101ad3dd */
            ii(0x1014_d274, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d277, 5); calld(0x100e_0648, -0x6_cc34);          /* call 0x100e0648 */
            ii(0x1014_d27c, 5); calld(0x1014_5ff7, -0x728a);            /* call 0x10145ff7 */
            ii(0x1014_d281, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d283, 2); if(jzd(0x1014_d28c, 0x7)) goto l_0x1014_d28c; /* jz 0x1014d28c */
            ii(0x1014_d285, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d288, 4); or(memb_a32[ds, eax + 0x12], 0x20);     /* or byte [eax+0x12], 0x20 */
        l_0x1014_d28c:
            ii(0x1014_d28c, 5); mov(edx, StringDefinitions.Building);   /* mov edx, 0x101ad3ea */
            ii(0x1014_d291, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d294, 5); calld(0x100e_0648, -0x6_cc51);          /* call 0x100e0648 */
            ii(0x1014_d299, 5); calld(0x1014_5ff7, -0x72a7);            /* call 0x10145ff7 */
            ii(0x1014_d29e, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d2a0, 2); if(jzd(0x1014_d2a9, 0x7)) goto l_0x1014_d2a9; /* jz 0x1014d2a9 */
            ii(0x1014_d2a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d2a5, 4); or(memb_a32[ds, eax + 0x12], 0x10);     /* or byte [eax+0x12], 0x10 */
        l_0x1014_d2a9:
            ii(0x1014_d2a9, 5); mov(edx, StringDefinitions.ConnectorUnit); /* mov edx, 0x101ad3f3 */
            ii(0x1014_d2ae, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d2b1, 5); calld(0x100e_0648, -0x6_cc6e);          /* call 0x100e0648 */
            ii(0x1014_d2b6, 5); calld(0x1014_5ff7, -0x72c4);            /* call 0x10145ff7 */
            ii(0x1014_d2bb, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d2bd, 2); if(jzd(0x1014_d2c6, 0x7)) goto l_0x1014_d2c6; /* jz 0x1014d2c6 */
            ii(0x1014_d2bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d2c2, 4); or(memb_a32[ds, eax + 0x12], 0x8);      /* or byte [eax+0x12], 0x8 */
        l_0x1014_d2c6:
            ii(0x1014_d2c6, 5); mov(edx, StringDefinitions.Animated);   /* mov edx, 0x101ad402 */
            ii(0x1014_d2cb, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d2ce, 5); calld(0x100e_0648, -0x6_cc8b);          /* call 0x100e0648 */
            ii(0x1014_d2d3, 5); calld(0x1014_5ff7, -0x72e1);            /* call 0x10145ff7 */
            ii(0x1014_d2d8, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d2da, 2); if(jzd(0x1014_d2e3, 0x7)) goto l_0x1014_d2e3; /* jz 0x1014d2e3 */
            ii(0x1014_d2dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d2df, 4); or(memb_a32[ds, eax + 0x12], 0x4);      /* or byte [eax+0x12], 0x4 */
        l_0x1014_d2e3:
            ii(0x1014_d2e3, 5); mov(edx, StringDefinitions.Exploding);  /* mov edx, 0x101ad40b */
            ii(0x1014_d2e8, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d2eb, 5); calld(0x100e_0648, -0x6_cca8);          /* call 0x100e0648 */
            ii(0x1014_d2f0, 5); calld(0x1014_5ff7, -0x72fe);            /* call 0x10145ff7 */
            ii(0x1014_d2f5, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d2f7, 2); if(jzd(0x1014_d300, 0x7)) goto l_0x1014_d300; /* jz 0x1014d300 */
            ii(0x1014_d2f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d2fc, 4); or(memb_a32[ds, eax + 0x12], 0x2);      /* or byte [eax+0x12], 0x2 */
        l_0x1014_d300:
            ii(0x1014_d300, 5); mov(edx, StringDefinitions.GroundCover); /* mov edx, 0x101ad415 */
            ii(0x1014_d305, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_d308, 5); calld(0x100e_0648, -0x6_ccc5);          /* call 0x100e0648 */
            ii(0x1014_d30d, 5); calld(0x1014_5ff7, -0x731b);            /* call 0x10145ff7 */
            ii(0x1014_d312, 2); test(al, al);                           /* test al, al */
            ii(0x1014_d314, 2); if(jzd(0x1014_d31d, 0x7)) goto l_0x1014_d31d; /* jz 0x1014d31d */
            ii(0x1014_d316, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d319, 4); or(memb_a32[ds, eax + 0x12], 0x1);      /* or byte [eax+0x12], 0x1 */
        l_0x1014_d31d:
            ii(0x1014_d31d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d320, 4); mov(memb_a32[ds, eax + 0x5b], 0);       /* mov byte [eax+0x5b], 0x0 */
            ii(0x1014_d324, 5); mov(edx, StringDefinitions.X9);         /* mov edx, 0x101ad422 */
            ii(0x1014_d329, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d32c, 5); calld(0x1014_60aa, -0x7287);            /* call 0x101460aa */
            ii(0x1014_d331, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d333, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d336, 4); mov(memw_a32[ds, eax + 0x16], dx);      /* mov [eax+0x16], dx */
            ii(0x1014_d33a, 5); mov(edx, StringDefinitions.Y7);         /* mov edx, 0x101ad424 */
            ii(0x1014_d33f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d342, 5); calld(0x1014_60aa, -0x729d);            /* call 0x101460aa */
            ii(0x1014_d347, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d349, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d34c, 4); mov(memw_a32[ds, eax + 0x18], dx);      /* mov [eax+0x18], dx */
            ii(0x1014_d350, 5); mov(edx, StringDefinitions.GridX);      /* mov edx, 0x101ad426 */
            ii(0x1014_d355, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d358, 5); calld(0x1014_60aa, -0x72b3);            /* call 0x101460aa */
            ii(0x1014_d35d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d35f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d362, 1); dec(edx);                               /* dec edx */
            ii(0x1014_d363, 4); mov(memw_a32[ds, eax + 0x1a], dx);      /* mov [eax+0x1a], dx */
            ii(0x1014_d367, 5); mov(edx, StringDefinitions.GridY);      /* mov edx, 0x101ad42d */
            ii(0x1014_d36c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d36f, 5); calld(0x1014_60aa, -0x72ca);            /* call 0x101460aa */
            ii(0x1014_d374, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d376, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d379, 1); dec(edx);                               /* dec edx */
            ii(0x1014_d37a, 4); mov(memw_a32[ds, eax + 0x1c], dx);      /* mov [eax+0x1c], dx */
            ii(0x1014_d37e, 5); mov(ebx, StringDefinitions.Name3);      /* mov ebx, 0x101ad434 */
            ii(0x1014_d383, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1014_d386, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d389, 5); calld(0x1014_60f3, -0x729b);            /* call 0x101460f3 */
            ii(0x1014_d38e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d391, 7); cmp(memd_a32[ds, eax + 0xa7], 0);       /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_d398, 2); if(jzd(0x1014_d3a8, 0xe)) goto l_0x1014_d3a8; /* jz 0x1014d3a8 */
            ii(0x1014_d39a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d39d, 6); mov(eax, memd_a32[ds, eax + 0xa7]);     /* mov eax, [eax+0xa7] */
            ii(0x1014_d3a3, 5); calld(Definitions.sys_delete, 0x1_8bbc); /* call 0x10165f64 */
        l_0x1014_d3a8:
            ii(0x1014_d3a8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_d3ab, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_3be8); /* call 0x100897c8 */
            ii(0x1014_d3b0, 5); calld(Definitions.sys_strlen, 0x2_4b12); /* call 0x10171ec7 */
            ii(0x1014_d3b5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_d3b7, 2); if(jnzd(0x1014_d3c8, 0xf)) goto l_0x1014_d3c8; /* jnz 0x1014d3c8 */
            ii(0x1014_d3b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d3bc, 10); mov(memd_a32[ds, eax + 0xa7], 0);      /* mov dword [eax+0xa7], 0x0 */
            ii(0x1014_d3c6, 2); jmpd(0x1014_d3fe, 0x36); goto l_0x1014_d3fe; /* jmp 0x1014d3fe */
        l_0x1014_d3c8:
            ii(0x1014_d3c8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_d3cb, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_3c08); /* call 0x100897c8 */
            ii(0x1014_d3d0, 5); calld(Definitions.sys_strlen, 0x2_4af2); /* call 0x10171ec7 */
            ii(0x1014_d3d5, 1); inc(eax);                               /* inc eax */
            ii(0x1014_d3d6, 5); calld(Definitions.sys_new_arr, 0x1_8c35); /* call 0x10166010 */
            ii(0x1014_d3db, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d3dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d3e0, 6); mov(memd_a32[ds, eax + 0xa7], edx);     /* mov [eax+0xa7], edx */
            ii(0x1014_d3e6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_d3e9, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_3c26); /* call 0x100897c8 */
            ii(0x1014_d3ee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d3f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d3f3, 6); mov(eax, memd_a32[ds, eax + 0xa7]);     /* mov eax, [eax+0xa7] */
            ii(0x1014_d3f9, 5); calld(Definitions.sys_strcpy, 0x1_8ad1); /* call 0x10165ecf */
        l_0x1014_d3fe:
            ii(0x1014_d3fe, 5); mov(edx, StringDefinitions.ShadowOffsetX); /* mov edx, 0x101ad439 */
            ii(0x1014_d403, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d406, 5); calld(0x1014_60aa, -0x7361);            /* call 0x101460aa */
            ii(0x1014_d40b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d40d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d410, 7); mov(memw_a32[ds, eax + 0xd9], dx);      /* mov [eax+0xd9], dx */
            ii(0x1014_d417, 5); mov(edx, StringDefinitions.ShadowOffsetY); /* mov edx, 0x101ad449 */
            ii(0x1014_d41c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d41f, 5); calld(0x1014_60aa, -0x737a);            /* call 0x101460aa */
            ii(0x1014_d424, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d426, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d429, 7); mov(memw_a32[ds, eax + 0xdb], dx);      /* mov [eax+0xdb], dx */
            ii(0x1014_d430, 5); mov(ebx, 0x101c_715c);                  /* mov ebx, 0x101c715c */
            ii(0x1014_d435, 5); mov(edx, StringDefinitions.Team);       /* mov edx, 0x101ad459 */
            ii(0x1014_d43a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d43d, 5); calld(0x1014_5f53, -0x74ef);            /* call 0x10145f53 */
            ii(0x1014_d442, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d444, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d447, 3); mov(memb_a32[ds, eax + 0x26], dl);      /* mov [eax+0x26], dl */
            ii(0x1014_d44a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d44d, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_d450, 3); mov(memb_a32[ss, ebp - 0x38], al);      /* mov [ebp-0x38], al */
            ii(0x1014_d453, 2); jmpd(0x1014_d498, 0x43); goto l_0x1014_d498; /* jmp 0x1014d498 */
        l_0x1014_d455:
            ii(0x1014_d455, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d458, 4); or(memb_a32[ds, eax + 0x13], 0x20);     /* or byte [eax+0x13], 0x20 */
            ii(0x1014_d45c, 2); jmpd(0x1014_d4b3, 0x55); goto l_0x1014_d4b3; /* jmp 0x1014d4b3 */
        l_0x1014_d45e:
            ii(0x1014_d45e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d461, 4); or(memb_a32[ds, eax + 0x13], 0x10);     /* or byte [eax+0x13], 0x10 */
            ii(0x1014_d465, 2); jmpd(0x1014_d4b3, 0x4c); goto l_0x1014_d4b3; /* jmp 0x1014d4b3 */
        l_0x1014_d467:
            ii(0x1014_d467, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d46a, 4); or(memb_a32[ds, eax + 0x13], 0x8);      /* or byte [eax+0x13], 0x8 */
            ii(0x1014_d46e, 2); jmpd(0x1014_d4b3, 0x43); goto l_0x1014_d4b3; /* jmp 0x1014d4b3 */
        l_0x1014_d470:
            ii(0x1014_d470, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d473, 4); or(memb_a32[ds, eax + 0x13], 0x4);      /* or byte [eax+0x13], 0x4 */
            ii(0x1014_d477, 2); jmpd(0x1014_d4b3, 0x3a); goto l_0x1014_d4b3; /* jmp 0x1014d4b3 */
        l_0x1014_d479:
            ii(0x1014_d479, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d47c, 4); or(memb_a32[ds, eax + 0x13], -0x80 /* 0x80 */); /* or byte [eax+0x13], 0x80 */
            ii(0x1014_d480, 2); jmpd(0x1014_d4b3, 0x31); goto l_0x1014_d4b3; /* jmp 0x1014d4b3 */
        l_0x1014_d482:
            ii(0x1014_d482, 2); jmpd(0x1014_d4b3, 0x2f); goto l_0x1014_d4b3; /* jmp 0x1014d4b3 */
        //  ii(0x1014_d484, 20); /* Служебная область с абсолютными адресами переходов. (0x1014_d455, 0x1014_d45e, 0x1014_d467, 0x1014_d470, 0x1014_d479). */
        l_0x1014_d498:
            ii(0x1014_d498, 3); mov(al, memb_a32[ss, ebp - 0x38]);      /* mov al, [ebp-0x38] */
            ii(0x1014_d49b, 3); mov(memb_a32[ss, ebp - 0x3c], al);      /* mov [ebp-0x3c], al */
            ii(0x1014_d49e, 4); cmp(memb_a32[ss, ebp - 0x3c], 0x4);     /* cmp byte [ebp-0x3c], 0x4 */
            ii(0x1014_d4a2, 2); if(jad(0x1014_d482, -0x22)) goto l_0x1014_d482; /* ja 0x1014d482 */
            ii(0x1014_d4a4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_d4a6, 3); mov(al, memb_a32[ss, ebp - 0x3c]);      /* mov al, [ebp-0x3c] */
            ii(0x1014_d4a9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1014_d4ac, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x1014_d484]))
            {
                case 0x1014_d455:
                    goto l_0x1014_d455;
                case 0x1014_d45e:
                    goto l_0x1014_d45e;
                case 0x1014_d467:
                    goto l_0x1014_d467;
                case 0x1014_d470:
                    goto l_0x1014_d470;
                case 0x1014_d479:
                    goto l_0x1014_d479;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x1014d484] */
        l_0x1014_d4b3:
            ii(0x1014_d4b3, 5); mov(edx, StringDefinitions.UnitId);     /* mov edx, 0x101ad45e */
            ii(0x1014_d4b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d4bb, 5); calld(0x1014_60aa, -0x7416);            /* call 0x101460aa */
            ii(0x1014_d4c0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d4c3, 3); mov(memb_a32[ds, edx + 0x27], al);      /* mov [edx+0x27], al */
            ii(0x1014_d4c6, 5); mov(edx, StringDefinitions.Brightness); /* mov edx, 0x101ad466 */
            ii(0x1014_d4cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d4ce, 5); calld(0x1014_60aa, -0x7429);            /* call 0x101460aa */
            ii(0x1014_d4d3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d4d6, 3); mov(memb_a32[ds, edx + 0x28], al);      /* mov [edx+0x28], al */
            ii(0x1014_d4d9, 5); mov(edx, StringDefinitions.Angle3);     /* mov edx, 0x101ad471 */
            ii(0x1014_d4de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d4e1, 5); calld(0x1014_60aa, -0x743c);            /* call 0x101460aa */
            ii(0x1014_d4e6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d4e9, 3); mov(memb_a32[ds, edx + 0x29], al);      /* mov [edx+0x29], al */
            ii(0x1014_d4ec, 5); mov(edx, StringDefinitions.VisibleToRed); /* mov edx, 0x101ad477 */
            ii(0x1014_d4f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d4f4, 5); calld(0x1014_5ff7, -0x7502);            /* call 0x10145ff7 */
            ii(0x1014_d4f9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d4fc, 6); mov(memb_a32[ds, edx + 0xab], al);      /* mov [edx+0xab], al */
            ii(0x1014_d502, 5); mov(edx, StringDefinitions.VisibleToGreen); /* mov edx, 0x101ad486 */
            ii(0x1014_d507, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d50a, 5); calld(0x1014_5ff7, -0x7518);            /* call 0x10145ff7 */
            ii(0x1014_d50f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d512, 6); mov(memb_a32[ds, edx + 0xac], al);      /* mov [edx+0xac], al */
            ii(0x1014_d518, 5); mov(edx, StringDefinitions.VisibleToBlue); /* mov edx, 0x101ad497 */
            ii(0x1014_d51d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d520, 5); calld(0x1014_5ff7, -0x752e);            /* call 0x10145ff7 */
            ii(0x1014_d525, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d528, 6); mov(memb_a32[ds, edx + 0xad], al);      /* mov [edx+0xad], al */
            ii(0x1014_d52e, 5); mov(edx, StringDefinitions.VisibleToGray); /* mov edx, 0x101ad4a7 */
            ii(0x1014_d533, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d536, 5); calld(0x1014_5ff7, -0x7544);            /* call 0x10145ff7 */
            ii(0x1014_d53b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d53e, 6); mov(memb_a32[ds, edx + 0xae], al);      /* mov [edx+0xae], al */
            ii(0x1014_d544, 5); mov(edx, StringDefinitions.SpottedByRed); /* mov edx, 0x101ad4b7 */
            ii(0x1014_d549, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d54c, 5); calld(0x1014_5ff7, -0x755a);            /* call 0x10145ff7 */
            ii(0x1014_d551, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d554, 6); mov(memb_a32[ds, edx + 0xb0], al);      /* mov [edx+0xb0], al */
            ii(0x1014_d55a, 5); mov(edx, StringDefinitions.SpottedByGreen); /* mov edx, 0x101ad4c6 */
            ii(0x1014_d55f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d562, 5); calld(0x1014_5ff7, -0x7570);            /* call 0x10145ff7 */
            ii(0x1014_d567, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d56a, 6); mov(memb_a32[ds, edx + 0xb1], al);      /* mov [edx+0xb1], al */
            ii(0x1014_d570, 5); mov(edx, StringDefinitions.SpottedByBlue); /* mov edx, 0x101ad4d7 */
            ii(0x1014_d575, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d578, 5); calld(0x1014_5ff7, -0x7586);            /* call 0x10145ff7 */
            ii(0x1014_d57d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d580, 6); mov(memb_a32[ds, edx + 0xb2], al);      /* mov [edx+0xb2], al */
            ii(0x1014_d586, 5); mov(edx, StringDefinitions.SpottedByGray); /* mov edx, 0x101ad4e7 */
            ii(0x1014_d58b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d58e, 5); calld(0x1014_5ff7, -0x759c);            /* call 0x10145ff7 */
            ii(0x1014_d593, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d596, 6); mov(memb_a32[ds, edx + 0xb3], al);      /* mov [edx+0xb3], al */
            ii(0x1014_d59c, 5); mov(edx, StringDefinitions.MaxVelocity); /* mov edx, 0x101ad4f7 */
            ii(0x1014_d5a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d5a4, 5); calld(0x1014_60aa, -0x74ff);            /* call 0x101460aa */
            ii(0x1014_d5a9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d5ac, 3); mov(memb_a32[ds, edx + 0x2a], al);      /* mov [edx+0x2a], al */
            ii(0x1014_d5af, 5); mov(edx, StringDefinitions.Velocity);   /* mov edx, 0x101ad504 */
            ii(0x1014_d5b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d5b7, 5); calld(0x1014_60aa, -0x7512);            /* call 0x101460aa */
            ii(0x1014_d5bc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d5bf, 3); mov(memb_a32[ds, edx + 0x2b], al);      /* mov [edx+0x2b], al */
            ii(0x1014_d5c2, 5); mov(ebx, 0x101c_71cc);                  /* mov ebx, 0x101c71cc */
            ii(0x1014_d5c7, 5); mov(edx, StringDefinitions.Sound);      /* mov edx, 0x101ad50d */
            ii(0x1014_d5cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d5cf, 5); calld(0x1014_5f53, -0x7681);            /* call 0x10145f53 */
            ii(0x1014_d5d4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d5d7, 3); mov(memb_a32[ds, edx + 0x2c], al);      /* mov [edx+0x2c], al */
            ii(0x1014_d5da, 5); mov(edx, StringDefinitions.ScalerAdjust); /* mov edx, 0x101ad513 */
            ii(0x1014_d5df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d5e2, 5); calld(0x1014_60aa, -0x753d);            /* call 0x101460aa */
            ii(0x1014_d5e7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d5ea, 3); mov(memb_a32[ds, edx + 0x2d], al);      /* mov [edx+0x2d], al */
            ii(0x1014_d5ed, 5); mov(edx, StringDefinitions.TurretAngle); /* mov edx, 0x101ad521 */
            ii(0x1014_d5f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d5f5, 5); calld(0x1014_60aa, -0x7550);            /* call 0x101460aa */
            ii(0x1014_d5fa, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d5fd, 3); mov(memb_a32[ds, edx + 0x2e], al);      /* mov [edx+0x2e], al */
            ii(0x1014_d600, 5); mov(edx, StringDefinitions.TurretOffsetX); /* mov edx, 0x101ad52e */
            ii(0x1014_d605, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d608, 5); calld(0x1014_60aa, -0x7563);            /* call 0x101460aa */
            ii(0x1014_d60d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d610, 3); mov(memb_a32[ds, edx + 0x2f], al);      /* mov [edx+0x2f], al */
            ii(0x1014_d613, 5); mov(edx, StringDefinitions.TurretOffsetY); /* mov edx, 0x101ad53e */
            ii(0x1014_d618, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d61b, 5); calld(0x1014_60aa, -0x7576);            /* call 0x101460aa */
            ii(0x1014_d620, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d623, 3); mov(memb_a32[ds, edx + 0x30], al);      /* mov [edx+0x30], al */
            ii(0x1014_d626, 5); mov(edx, StringDefinitions.TotalImages); /* mov edx, 0x101ad54e */
            ii(0x1014_d62b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d62e, 5); calld(0x1014_60aa, -0x7589);            /* call 0x101460aa */
            ii(0x1014_d633, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d636, 4); mov(memw_a32[ds, edx + 0x31], ax);      /* mov [edx+0x31], ax */
            ii(0x1014_d63a, 5); mov(edx, StringDefinitions.ImageBase);  /* mov edx, 0x101ad55b */
            ii(0x1014_d63f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d642, 5); calld(0x1014_60aa, -0x759d);            /* call 0x101460aa */
            ii(0x1014_d647, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d64a, 4); mov(memw_a32[ds, edx + 0x33], ax);      /* mov [edx+0x33], ax */
            ii(0x1014_d64e, 5); mov(edx, StringDefinitions.TurretImageBase); /* mov edx, 0x101ad566 */
            ii(0x1014_d653, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d656, 5); calld(0x1014_60aa, -0x75b1);            /* call 0x101460aa */
            ii(0x1014_d65b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d65e, 4); mov(memw_a32[ds, edx + 0x35], ax);      /* mov [edx+0x35], ax */
            ii(0x1014_d662, 5); mov(edx, StringDefinitions.FiringImageBase); /* mov edx, 0x101ad578 */
            ii(0x1014_d667, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d66a, 5); calld(0x1014_60aa, -0x75c5);            /* call 0x101460aa */
            ii(0x1014_d66f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d672, 4); mov(memw_a32[ds, edx + 0x37], ax);      /* mov [edx+0x37], ax */
            ii(0x1014_d676, 5); mov(edx, StringDefinitions.ConnectorImageBase); /* mov edx, 0x101ad58a */
            ii(0x1014_d67b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d67e, 5); calld(0x1014_60aa, -0x75d9);            /* call 0x101460aa */
            ii(0x1014_d683, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d686, 4); mov(memw_a32[ds, edx + 0x39], ax);      /* mov [edx+0x39], ax */
            ii(0x1014_d68a, 5); mov(edx, StringDefinitions.ImageIndex); /* mov edx, 0x101ad59f */
            ii(0x1014_d68f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d692, 5); calld(0x1014_60aa, -0x75ed);            /* call 0x101460aa */
            ii(0x1014_d697, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d69a, 7); mov(memw_a32[ds, edx + 0xd5], ax);      /* mov [edx+0xd5], ax */
            ii(0x1014_d6a1, 5); mov(edx, StringDefinitions.TurretImageIndex); /* mov edx, 0x101ad5ab */
            ii(0x1014_d6a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d6a9, 5); calld(0x1014_60aa, -0x7604);            /* call 0x101460aa */
            ii(0x1014_d6ae, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d6b1, 7); mov(memw_a32[ds, edx + 0xd7], ax);      /* mov [edx+0xd7], ax */
            ii(0x1014_d6b8, 5); mov(edx, StringDefinitions.ImageIndexMax); /* mov edx, 0x101ad5be */
            ii(0x1014_d6bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d6c0, 5); calld(0x1014_60aa, -0x761b);            /* call 0x101460aa */
            ii(0x1014_d6c5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d6c8, 4); mov(memw_a32[ds, edx + 0x3b], ax);      /* mov [edx+0x3b], ax */
            ii(0x1014_d6cc, 5); mov(ebx, 0x101c_71e8);                  /* mov ebx, 0x101c71e8 */
            ii(0x1014_d6d1, 5); mov(edx, StringDefinitions.Orders);     /* mov edx, 0x101ad5ce */
            ii(0x1014_d6d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d6d9, 5); calld(0x1014_5f53, -0x778b);            /* call 0x10145f53 */
            ii(0x1014_d6de, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d6e1, 3); mov(memb_a32[ds, edx + 0x3d], al);      /* mov [edx+0x3d], al */
            ii(0x1014_d6e4, 5); mov(ebx, 0x101c_7204);                  /* mov ebx, 0x101c7204 */
            ii(0x1014_d6e9, 5); mov(edx, StringDefinitions.State);      /* mov edx, 0x101ad5d5 */
            ii(0x1014_d6ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d6f1, 5); calld(0x1014_5f53, -0x77a3);            /* call 0x10145f53 */
            ii(0x1014_d6f6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d6f9, 3); mov(memb_a32[ds, edx + 0x3e], al);      /* mov [edx+0x3e], al */
            ii(0x1014_d6fc, 5); mov(ebx, 0x101c_71e8);                  /* mov ebx, 0x101c71e8 */
            ii(0x1014_d701, 5); mov(edx, StringDefinitions.PriorOrders); /* mov edx, 0x101ad5db */
            ii(0x1014_d706, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d709, 5); calld(0x1014_5f53, -0x77bb);            /* call 0x10145f53 */
            ii(0x1014_d70e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d711, 3); mov(memb_a32[ds, edx + 0x3f], al);      /* mov [edx+0x3f], al */
            ii(0x1014_d714, 5); mov(ebx, 0x101c_7204);                  /* mov ebx, 0x101c7204 */
            ii(0x1014_d719, 5); mov(edx, StringDefinitions.PriorState); /* mov edx, 0x101ad5e8 */
            ii(0x1014_d71e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d721, 5); calld(0x1014_5f53, -0x77d3);            /* call 0x10145f53 */
            ii(0x1014_d726, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d729, 3); mov(memb_a32[ds, edx + 0x40], al);      /* mov [edx+0x40], al */
            ii(0x1014_d72c, 5); mov(ebx, 0x101c_7220);                  /* mov ebx, 0x101c7220 */
            ii(0x1014_d731, 5); mov(edx, StringDefinitions.LayingState); /* mov edx, 0x101ad5f4 */
            ii(0x1014_d736, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d739, 5); calld(0x1014_5f53, -0x77eb);            /* call 0x10145f53 */
            ii(0x1014_d73e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d741, 6); mov(memb_a32[ds, edx + 0xa6], al);      /* mov [edx+0xa6], al */
            ii(0x1014_d747, 5); mov(edx, StringDefinitions.TargetGridX); /* mov edx, 0x101ad601 */
            ii(0x1014_d74c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d74f, 5); calld(0x1014_60aa, -0x76aa);            /* call 0x101460aa */
            ii(0x1014_d754, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d757, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
            ii(0x1014_d75b, 5); mov(edx, StringDefinitions.TargetGridY); /* mov edx, 0x101ad60f */
            ii(0x1014_d760, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d763, 5); calld(0x1014_60aa, -0x76be);            /* call 0x101460aa */
            ii(0x1014_d768, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d76b, 4); mov(memw_a32[ds, edx + 0x43], ax);      /* mov [edx+0x43], ax */
            ii(0x1014_d76f, 5); mov(edx, StringDefinitions.BuildTime);  /* mov edx, 0x101ad61d */
            ii(0x1014_d774, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d777, 5); calld(0x1014_60aa, -0x76d2);            /* call 0x101460aa */
            ii(0x1014_d77c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d77f, 3); mov(memb_a32[ds, edx + 0x45], al);      /* mov [edx+0x45], al */
            ii(0x1014_d782, 5); mov(edx, StringDefinitions.TotalMining); /* mov edx, 0x101ad628 */
            ii(0x1014_d787, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d78a, 5); calld(0x1014_60aa, -0x76e5);            /* call 0x101460aa */
            ii(0x1014_d78f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d792, 3); mov(memb_a32[ds, edx + 0x46], al);      /* mov [edx+0x46], al */
            ii(0x1014_d795, 5); mov(edx, StringDefinitions.RawMining);  /* mov edx, 0x101ad635 */
            ii(0x1014_d79a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d79d, 5); calld(0x1014_60aa, -0x76f8);            /* call 0x101460aa */
            ii(0x1014_d7a2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d7a5, 3); mov(memb_a32[ds, edx + 0x47], al);      /* mov [edx+0x47], al */
            ii(0x1014_d7a8, 5); mov(edx, StringDefinitions.FuelMining); /* mov edx, 0x101ad640 */
            ii(0x1014_d7ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d7b0, 5); calld(0x1014_60aa, -0x770b);            /* call 0x101460aa */
            ii(0x1014_d7b5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d7b8, 3); mov(memb_a32[ds, edx + 0x48], al);      /* mov [edx+0x48], al */
            ii(0x1014_d7bb, 5); mov(edx, StringDefinitions.GoldMining); /* mov edx, 0x101ad64c */
            ii(0x1014_d7c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d7c3, 5); calld(0x1014_60aa, -0x771e);            /* call 0x101460aa */
            ii(0x1014_d7c8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d7cb, 3); mov(memb_a32[ds, edx + 0x49], al);      /* mov [edx+0x49], al */
            ii(0x1014_d7ce, 5); mov(edx, StringDefinitions.RawMiningMax); /* mov edx, 0x101ad658 */
            ii(0x1014_d7d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d7d6, 5); calld(0x1014_60aa, -0x7731);            /* call 0x101460aa */
            ii(0x1014_d7db, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d7de, 3); mov(memb_a32[ds, edx + 0x4a], al);      /* mov [edx+0x4a], al */
            ii(0x1014_d7e1, 5); mov(edx, StringDefinitions.FuelMiningMax); /* mov edx, 0x101ad667 */
            ii(0x1014_d7e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d7e9, 5); calld(0x1014_60aa, -0x7744);            /* call 0x101460aa */
            ii(0x1014_d7ee, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d7f1, 3); mov(memb_a32[ds, edx + 0x4c], al);      /* mov [edx+0x4c], al */
            ii(0x1014_d7f4, 5); mov(edx, StringDefinitions.GoldMiningMax); /* mov edx, 0x101ad677 */
            ii(0x1014_d7f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d7fc, 5); calld(0x1014_60aa, -0x7757);            /* call 0x101460aa */
            ii(0x1014_d801, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d804, 3); mov(memb_a32[ds, edx + 0x4b], al);      /* mov [edx+0x4b], al */
            ii(0x1014_d807, 5); mov(edx, StringDefinitions.Hits5);      /* mov edx, 0x101ad687 */
            ii(0x1014_d80c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d80f, 5); calld(0x1014_60aa, -0x776a);            /* call 0x101460aa */
            ii(0x1014_d814, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d817, 3); mov(memb_a32[ds, edx + 0x4d], al);      /* mov [edx+0x4d], al */
            ii(0x1014_d81a, 5); mov(edx, StringDefinitions.Speed4);     /* mov edx, 0x101ad68c */
            ii(0x1014_d81f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d822, 5); calld(0x1014_60aa, -0x777d);            /* call 0x101460aa */
            ii(0x1014_d827, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d82a, 3); mov(memb_a32[ds, edx + 0x4e], al);      /* mov [edx+0x4e], al */
            ii(0x1014_d82d, 5); mov(edx, StringDefinitions.Shots4);     /* mov edx, 0x101ad692 */
            ii(0x1014_d832, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d835, 5); calld(0x1014_60aa, -0x7790);            /* call 0x101460aa */
            ii(0x1014_d83a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d83d, 3); mov(memb_a32[ds, edx + 0x50], al);      /* mov [edx+0x50], al */
            ii(0x1014_d840, 5); mov(edx, StringDefinitions.MoveAndFire); /* mov edx, 0x101ad698 */
            ii(0x1014_d845, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d848, 5); calld(0x1014_5ff7, -0x7856);            /* call 0x10145ff7 */
            ii(0x1014_d84d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d850, 3); mov(memb_a32[ds, edx + 0x51], al);      /* mov [edx+0x51], al */
            ii(0x1014_d853, 5); mov(edx, StringDefinitions.Storage);    /* mov edx, 0x101ad6a6 */
            ii(0x1014_d858, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d85b, 5); calld(0x1014_60aa, -0x77b6);            /* call 0x101460aa */
            ii(0x1014_d860, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d863, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
            ii(0x1014_d867, 5); mov(edx, StringDefinitions.Ammo5);      /* mov edx, 0x101ad6ae */
            ii(0x1014_d86c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d86f, 5); calld(0x1014_60aa, -0x77ca);            /* call 0x101460aa */
            ii(0x1014_d874, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d877, 3); mov(memb_a32[ds, edx + 0x54], al);      /* mov [edx+0x54], al */
            ii(0x1014_d87a, 5); mov(edx, StringDefinitions.TargetingMode); /* mov edx, 0x101ad6b3 */
            ii(0x1014_d87f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d882, 5); calld(0x1014_5ff7, -0x7890);            /* call 0x10145ff7 */
            ii(0x1014_d887, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d88a, 3); mov(memb_a32[ds, edx + 0x55], al);      /* mov [edx+0x55], al */
            ii(0x1014_d88d, 5); mov(edx, StringDefinitions.EnterMode);  /* mov edx, 0x101ad6c2 */
            ii(0x1014_d892, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d895, 5); calld(0x1014_5ff7, -0x78a3);            /* call 0x10145ff7 */
            ii(0x1014_d89a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d89d, 3); mov(memb_a32[ds, edx + 0x56], al);      /* mov [edx+0x56], al */
            ii(0x1014_d8a0, 5); mov(ebx, 0x101c_723c);                  /* mov ebx, 0x101c723c */
            ii(0x1014_d8a5, 5); mov(edx, StringDefinitions.Cursor);     /* mov edx, 0x101ad6cd */
            ii(0x1014_d8aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d8ad, 5); calld(0x1014_5f53, -0x795f);            /* call 0x10145f53 */
            ii(0x1014_d8b2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d8b5, 3); mov(memb_a32[ds, edx + 0x57], al);      /* mov [edx+0x57], al */
            ii(0x1014_d8b8, 5); mov(edx, StringDefinitions.RecoilDelay); /* mov edx, 0x101ad6d4 */
            ii(0x1014_d8bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d8c0, 5); calld(0x1014_60aa, -0x781b);            /* call 0x101460aa */
            ii(0x1014_d8c5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d8c8, 3); mov(memb_a32[ds, edx + 0x58], al);      /* mov [edx+0x58], al */
            ii(0x1014_d8cb, 5); mov(edx, StringDefinitions.DelayedReaction); /* mov edx, 0x101ad6e1 */
            ii(0x1014_d8d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d8d3, 5); calld(0x1014_5ff7, -0x78e1);            /* call 0x10145ff7 */
            ii(0x1014_d8d8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d8db, 3); mov(memb_a32[ds, edx + 0x59], al);      /* mov [edx+0x59], al */
            ii(0x1014_d8de, 5); mov(edx, StringDefinitions.DamagedThisTurn); /* mov edx, 0x101ad6f2 */
            ii(0x1014_d8e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d8e6, 5); calld(0x1014_5ff7, -0x78f4);            /* call 0x10145ff7 */
            ii(0x1014_d8eb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d8ee, 3); mov(memb_a32[ds, edx + 0x5a], al);      /* mov [edx+0x5a], al */
            ii(0x1014_d8f1, 5); mov(ebx, 0x101c_7194);                  /* mov ebx, 0x101c7194 */
            ii(0x1014_d8f6, 5); mov(edx, StringDefinitions.ResearchTopic); /* mov edx, 0x101ad704 */
            ii(0x1014_d8fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d8fe, 5); calld(0x1014_5f53, -0x79b0);            /* call 0x10145f53 */
            ii(0x1014_d903, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d906, 3); mov(memb_a32[ds, edx + 0x5d], al);      /* mov [edx+0x5d], al */
            ii(0x1014_d909, 5); mov(edx, StringDefinitions.Moved);      /* mov edx, 0x101ad713 */
            ii(0x1014_d90e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d911, 5); calld(0x1014_5ff7, -0x791f);            /* call 0x10145ff7 */
            ii(0x1014_d916, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d919, 3); mov(memb_a32[ds, edx + 0x5e], al);      /* mov [edx+0x5e], al */
            ii(0x1014_d91c, 5); mov(edx, StringDefinitions.Bobbed);     /* mov edx, 0x101ad719 */
            ii(0x1014_d921, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d924, 5); calld(0x1014_5ff7, -0x7932);            /* call 0x10145ff7 */
            ii(0x1014_d929, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d92c, 3); mov(memb_a32[ds, edx + 0x5f], al);      /* mov [edx+0x5f], al */
            ii(0x1014_d92f, 5); mov(ebx, 0x101c_7258);                  /* mov ebx, 0x101c7258 */
            ii(0x1014_d934, 5); mov(edx, StringDefinitions.Engine);     /* mov edx, 0x101ad720 */
            ii(0x1014_d939, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d93c, 5); calld(0x1014_5f53, -0x79ee);            /* call 0x10145f53 */
            ii(0x1014_d941, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d944, 3); mov(memb_a32[ds, edx + 0x60], al);      /* mov [edx+0x60], al */
            ii(0x1014_d947, 5); mov(ebx, 0x101c_7258);                  /* mov ebx, 0x101c7258 */
            ii(0x1014_d94c, 5); mov(edx, StringDefinitions.Weapon);     /* mov edx, 0x101ad727 */
            ii(0x1014_d951, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d954, 5); calld(0x1014_5f53, -0x7a06);            /* call 0x10145f53 */
            ii(0x1014_d959, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d95c, 3); mov(memb_a32[ds, edx + 0x61], al);      /* mov [edx+0x61], al */
            ii(0x1014_d95f, 5); mov(ebx, 0x101c_7258);                  /* mov ebx, 0x101c7258 */
            ii(0x1014_d964, 5); mov(edx, StringDefinitions.Comm);       /* mov edx, 0x101ad72e */
            ii(0x1014_d969, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d96c, 5); calld(0x1014_5f53, -0x7a1e);            /* call 0x10145f53 */
            ii(0x1014_d971, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d974, 3); mov(memb_a32[ds, edx + 0x62], al);      /* mov [edx+0x62], al */
            ii(0x1014_d977, 5); mov(edx, StringDefinitions.FuelDistance); /* mov edx, 0x101ad733 */
            ii(0x1014_d97c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d97f, 5); calld(0x1014_60aa, -0x78da);            /* call 0x101460aa */
            ii(0x1014_d984, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d987, 3); mov(memb_a32[ds, edx + 0x63], al);      /* mov [edx+0x63], al */
            ii(0x1014_d98a, 5); mov(edx, StringDefinitions.MoveFraction); /* mov edx, 0x101ad741 */
            ii(0x1014_d98f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d992, 5); calld(0x1014_60aa, -0x78ed);            /* call 0x101460aa */
            ii(0x1014_d997, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_d99a, 3); mov(memb_a32[ds, edx + 0x64], al);      /* mov [edx+0x64], al */
            ii(0x1014_d99d, 5); mov(edx, StringDefinitions.Energized);  /* mov edx, 0x101ad74f */
            ii(0x1014_d9a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d9a5, 5); calld(0x1014_5ff7, -0x79b3);            /* call 0x10145ff7 */
            ii(0x1014_d9aa, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1014_d9ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d9af, 3); mov(memb_a32[ds, eax + 0x7b], dl);      /* mov [eax+0x7b], dl */
            ii(0x1014_d9b2, 5); mov(edx, StringDefinitions.RepeatBuild); /* mov edx, 0x101ad759 */
            ii(0x1014_d9b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d9ba, 5); calld(0x1014_5ff7, -0x79c8);            /* call 0x10145ff7 */
            ii(0x1014_d9bf, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1014_d9c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d9c4, 3); mov(memb_a32[ds, eax + 0x7a], dl);      /* mov [eax+0x7a], dl */
            ii(0x1014_d9c7, 5); mov(edx, StringDefinitions.BuildRate);  /* mov edx, 0x101ad766 */
            ii(0x1014_d9cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d9cf, 5); calld(0x1014_60aa, -0x792a);            /* call 0x101460aa */
            ii(0x1014_d9d4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d9d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d9d9, 4); mov(memw_a32[ds, eax + 0x78], dx);      /* mov [eax+0x78], dx */
            ii(0x1014_d9dd, 5); mov(edx, StringDefinitions.AutoSurvey); /* mov edx, 0x101ad771 */
            ii(0x1014_d9e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_d9e5, 5); calld(0x1014_60aa, -0x7940);            /* call 0x101460aa */
            ii(0x1014_d9ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_d9ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d9ef, 3); mov(memb_a32[ds, eax + 0x5c], dl);      /* mov [eax+0x5c], dl */
            ii(0x1014_d9f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_d9f5, 3); mov(eax, memd_a32[ds, eax + 0x76]);     /* mov eax, [eax+0x76] */
            ii(0x1014_d9f8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_d9fb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_d9fd, 2); if(jnzd(0x1014_da06, 0x7)) goto l_0x1014_da06; /* jnz 0x1014da06 */
            ii(0x1014_d9ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_da02, 4); inc(memw_a32[ds, eax + 0x78]);          /* inc word [eax+0x78] */
        l_0x1014_da06:
            ii(0x1014_da06, 5); mov(ebx, StringDefinitions.Path2);      /* mov ebx, 0x101ad77d */
            ii(0x1014_da0b, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1014_da0e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_da11, 5); calld(0x1014_61ae, -0x7868);            /* call 0x101461ae */
            ii(0x1014_da16, 5); calld(0x100e_0d98, -0x6_cc83);          /* call 0x100e0d98 */
            ii(0x1014_da1b, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_da1e, 3); add(ebx, 0x65);                         /* add ebx, 0x65 */
            ii(0x1014_da21, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_da23, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_da25, 5); calld(0x1007_6a34, -0xd_6ff6);          /* call 0x10076a34 */
            ii(0x1014_da2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_da2c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_da2f, 5); calld(0x100e_0158, -0x6_d8dc);          /* call 0x100e0158 */
            ii(0x1014_da34, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_da37, 6); mov(memw_a32[ds, eax + 0x69], 0);       /* mov word [eax+0x69], 0x0 */
            ii(0x1014_da3d, 5); mov(ebx, StringDefinitions.Connectors2); /* mov ebx, 0x101ad782 */
            ii(0x1014_da42, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1014_da45, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_da48, 5); calld(0x1014_625c, -0x77f1);            /* call 0x1014625c */
            ii(0x1014_da4d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_da4f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_da52, 5); calld(0x100e_06a4, -0x6_d3b3);          /* call 0x100e06a4 */
            ii(0x1014_da57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_da59, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_da5c, 5); calld(0x100e_03fc, -0x6_d665);          /* call 0x100e03fc */
            ii(0x1014_da61, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_da63, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_da66, 5); calld(0x1013_ad71, -0x1_2cfa);          /* call 0x1013ad71 */
            ii(0x1014_da6b, 2); test(al, al);                           /* test al, al */
            ii(0x1014_da6d, 6); if(jzd(0x1014_db78, 0x105)) goto l_0x1014_db78; /* jz 0x1014db78 */
            ii(0x1014_da73, 5); mov(edx, StringDefinitions.ConnectNorthLeft); /* mov edx, 0x101ad78d */
            ii(0x1014_da78, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_da7b, 5); calld(0x100e_0648, -0x6_d438);          /* call 0x100e0648 */
            ii(0x1014_da80, 5); calld(0x1014_5ff7, -0x7a8e);            /* call 0x10145ff7 */
            ii(0x1014_da85, 2); test(al, al);                           /* test al, al */
            ii(0x1014_da87, 2); if(jzd(0x1014_da90, 0x7)) goto l_0x1014_da90; /* jz 0x1014da90 */
            ii(0x1014_da89, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_da8c, 4); or(memb_a32[ds, eax + 0x69], 0x1);      /* or byte [eax+0x69], 0x1 */
        l_0x1014_da90:
            ii(0x1014_da90, 5); mov(edx, StringDefinitions.ConnectNorthRight); /* mov edx, 0x101ad7a0 */
            ii(0x1014_da95, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_da98, 5); calld(0x100e_0648, -0x6_d455);          /* call 0x100e0648 */
            ii(0x1014_da9d, 5); calld(0x1014_5ff7, -0x7aab);            /* call 0x10145ff7 */
            ii(0x1014_daa2, 2); test(al, al);                           /* test al, al */
            ii(0x1014_daa4, 2); if(jzd(0x1014_daad, 0x7)) goto l_0x1014_daad; /* jz 0x1014daad */
            ii(0x1014_daa6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_daa9, 4); or(memb_a32[ds, eax + 0x69], 0x2);      /* or byte [eax+0x69], 0x2 */
        l_0x1014_daad:
            ii(0x1014_daad, 5); mov(edx, StringDefinitions.ConnectEastTop); /* mov edx, 0x101ad7b4 */
            ii(0x1014_dab2, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_dab5, 5); calld(0x100e_0648, -0x6_d472);          /* call 0x100e0648 */
            ii(0x1014_daba, 5); calld(0x1014_5ff7, -0x7ac8);            /* call 0x10145ff7 */
            ii(0x1014_dabf, 2); test(al, al);                           /* test al, al */
            ii(0x1014_dac1, 2); if(jzd(0x1014_daca, 0x7)) goto l_0x1014_daca; /* jz 0x1014daca */
            ii(0x1014_dac3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dac6, 4); or(memb_a32[ds, eax + 0x69], 0x4);      /* or byte [eax+0x69], 0x4 */
        l_0x1014_daca:
            ii(0x1014_daca, 5); mov(edx, StringDefinitions.ConnectEastBottom); /* mov edx, 0x101ad7c5 */
            ii(0x1014_dacf, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_dad2, 5); calld(0x100e_0648, -0x6_d48f);          /* call 0x100e0648 */
            ii(0x1014_dad7, 5); calld(0x1014_5ff7, -0x7ae5);            /* call 0x10145ff7 */
            ii(0x1014_dadc, 2); test(al, al);                           /* test al, al */
            ii(0x1014_dade, 2); if(jzd(0x1014_dae7, 0x7)) goto l_0x1014_dae7; /* jz 0x1014dae7 */
            ii(0x1014_dae0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dae3, 4); or(memb_a32[ds, eax + 0x69], 0x8);      /* or byte [eax+0x69], 0x8 */
        l_0x1014_dae7:
            ii(0x1014_dae7, 5); mov(edx, StringDefinitions.ConnectSouthLeft); /* mov edx, 0x101ad7d9 */
            ii(0x1014_daec, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_daef, 5); calld(0x100e_0648, -0x6_d4ac);          /* call 0x100e0648 */
            ii(0x1014_daf4, 5); calld(0x1014_5ff7, -0x7b02);            /* call 0x10145ff7 */
            ii(0x1014_daf9, 2); test(al, al);                           /* test al, al */
            ii(0x1014_dafb, 2); if(jzd(0x1014_db04, 0x7)) goto l_0x1014_db04; /* jz 0x1014db04 */
            ii(0x1014_dafd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_db00, 4); or(memb_a32[ds, eax + 0x69], 0x10);     /* or byte [eax+0x69], 0x10 */
        l_0x1014_db04:
            ii(0x1014_db04, 5); mov(edx, StringDefinitions.ConnectSouthRight); /* mov edx, 0x101ad7ec */
            ii(0x1014_db09, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_db0c, 5); calld(0x100e_0648, -0x6_d4c9);          /* call 0x100e0648 */
            ii(0x1014_db11, 5); calld(0x1014_5ff7, -0x7b1f);            /* call 0x10145ff7 */
            ii(0x1014_db16, 2); test(al, al);                           /* test al, al */
            ii(0x1014_db18, 2); if(jzd(0x1014_db21, 0x7)) goto l_0x1014_db21; /* jz 0x1014db21 */
            ii(0x1014_db1a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_db1d, 4); or(memb_a32[ds, eax + 0x69], 0x20);     /* or byte [eax+0x69], 0x20 */
        l_0x1014_db21:
            ii(0x1014_db21, 5); mov(edx, StringDefinitions.ConnectWestTop); /* mov edx, 0x101ad800 */
            ii(0x1014_db26, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_db29, 5); calld(0x100e_0648, -0x6_d4e6);          /* call 0x100e0648 */
            ii(0x1014_db2e, 5); calld(0x1014_5ff7, -0x7b3c);            /* call 0x10145ff7 */
            ii(0x1014_db33, 2); test(al, al);                           /* test al, al */
            ii(0x1014_db35, 2); if(jzd(0x1014_db3e, 0x7)) goto l_0x1014_db3e; /* jz 0x1014db3e */
            ii(0x1014_db37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_db3a, 4); or(memb_a32[ds, eax + 0x69], 0x40);     /* or byte [eax+0x69], 0x40 */
        l_0x1014_db3e:
            ii(0x1014_db3e, 5); mov(edx, StringDefinitions.ConnectWestBottom); /* mov edx, 0x101ad811 */
            ii(0x1014_db43, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_db46, 5); calld(0x100e_0648, -0x6_d503);          /* call 0x100e0648 */
            ii(0x1014_db4b, 5); calld(0x1014_5ff7, -0x7b59);            /* call 0x10145ff7 */
            ii(0x1014_db50, 2); test(al, al);                           /* test al, al */
            ii(0x1014_db52, 2); if(jzd(0x1014_db5b, 0x7)) goto l_0x1014_db5b; /* jz 0x1014db5b */
            ii(0x1014_db54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_db57, 4); or(memb_a32[ds, eax + 0x69], -0x80 /* 0x80 */); /* or byte [eax+0x69], 0x80 */
        l_0x1014_db5b:
            ii(0x1014_db5b, 5); mov(edx, StringDefinitions.ConnectionBeingTested); /* mov edx, 0x101ad825 */
            ii(0x1014_db60, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_db63, 5); calld(0x100e_0648, -0x6_d520);          /* call 0x100e0648 */
            ii(0x1014_db68, 5); calld(0x1014_5ff7, -0x7b76);            /* call 0x10145ff7 */
            ii(0x1014_db6d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_db6f, 2); if(jzd(0x1014_db78, 0x7)) goto l_0x1014_db78; /* jz 0x1014db78 */
            ii(0x1014_db71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_db74, 4); or(memb_a32[ds, eax + 0x6a], 0x4);      /* or byte [eax+0x6a], 0x4 */
        l_0x1014_db78:
            ii(0x1014_db78, 5); mov(ebx, StringDefinitions.BaseValues3); /* mov ebx, 0x101ad83d */
            ii(0x1014_db7d, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1014_db80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_db83, 5); calld(0x1014_61ae, -0x79da);            /* call 0x101461ae */
            ii(0x1014_db88, 5); calld(0x100e_0d98, -0x6_cdf5);          /* call 0x100e0d98 */
            ii(0x1014_db8d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_db8f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_db92, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_db95, 5); calld(0x100c_b77c, -0x8_241e);          /* call 0x100cb77c */
            ii(0x1014_db9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_db9c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_db9f, 5); calld(0x100e_0158, -0x6_da4c);          /* call 0x100e0158 */
            ii(0x1014_dba4, 5); mov(ebx, StringDefinitions.Complex4);   /* mov ebx, 0x101ad849 */
            ii(0x1014_dba9, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_dbac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dbaf, 5); calld(0x1014_61ae, -0x7a06);            /* call 0x101461ae */
            ii(0x1014_dbb4, 5); calld(0x100e_0d98, -0x6_ce21);          /* call 0x100e0d98 */
            ii(0x1014_dbb9, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_dbbc, 3); add(ebx, 0x70);                         /* add ebx, 0x70 */
            ii(0x1014_dbbf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_dbc1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_dbc3, 5); calld(0x100a_b2a8, -0xa_2920);          /* call 0x100ab2a8 */
            ii(0x1014_dbc8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_dbca, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_dbcd, 5); calld(0x100e_0158, -0x6_da7a);          /* call 0x100e0158 */
            ii(0x1014_dbd2, 5); mov(ebx, StringDefinitions.ParentUnit); /* mov ebx, 0x101ad851 */
            ii(0x1014_dbd7, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1014_dbda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_dbdd, 5); calld(0x1014_61ae, -0x7a34);            /* call 0x101461ae */
            ii(0x1014_dbe2, 5); calld(0x100e_0d98, -0x6_ce4f);          /* call 0x100e0d98 */
            ii(0x1014_dbe7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_dbe9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dbec, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_dbf1, 5); calld(0x1007_6630, -0xd_75c6);          /* call 0x10076630 */
            ii(0x1014_dbf6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_dbf8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_dbfb, 5); calld(0x100e_0158, -0x6_daa8);          /* call 0x100e0158 */
            ii(0x1014_dc00, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_dc03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc06, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_dc09, 5); calld(0x100c_fd84, -0x7_de8a);          /* call 0x100cfd84 */
            ii(0x1014_dc0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc11, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2a);    /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1014_dc15, 2); if(jzd(0x1014_dc20, 0x9)) goto l_0x1014_dc20; /* jz 0x1014dc20 */
            ii(0x1014_dc17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc1a, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1d);    /* cmp byte [eax+0x3e], 0x1d */
            ii(0x1014_dc1e, 2); if(jnzd(0x1014_dc27, 0x7)) goto l_0x1014_dc27; /* jnz 0x1014dc27 */
        l_0x1014_dc20:
            ii(0x1014_dc20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc23, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
        l_0x1014_dc27:
            ii(0x1014_dc27, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc2a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_dc2d, 5); calld(0x1007_6730, -0xd_7502);          /* call 0x10076730 */
            ii(0x1014_dc32, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1014_dc35, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_dc38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc3b, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_dc3e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_dc43, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1014_dc45, 2); if(jled(0x1014_dc5b, 0x14)) goto l_0x1014_dc5b; /* jle 0x1014dc5b */
            ii(0x1014_dc47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc4a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_dc4d, 5); calld(0x1007_6730, -0xd_7522);          /* call 0x10076730 */
            ii(0x1014_dc52, 3); mov(dl, memb_a32[ds, eax + 0xa]);       /* mov dl, [eax+0xa] */
            ii(0x1014_dc55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc58, 3); mov(memb_a32[ds, eax + 0x4d], dl);      /* mov [eax+0x4d], dl */
        l_0x1014_dc5b:
            ii(0x1014_dc5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc5e, 5); calld(0x1015_b336, 0xd6d3);             /* call 0x1015b336 */
            ii(0x1014_dc63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_dc66, 5); calld(0x1014_9cd1, -0x3f9a);            /* call 0x10149cd1 */
            ii(0x1014_dc6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_dc6d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_dc70, 5); calld(Definitions.my_string_dtor, -0xc14b); /* call 0x10141b2a */
            ii(0x1014_dc75, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_dc77, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_dc7a, 5); calld(0x100e_03fc, -0x6_d883);          /* call 0x100e03fc */
            ii(0x1014_dc7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_dc81, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_dc82, 1); popd(edi);                              /* pop edi */
            ii(0x1014_dc83, 1); popd(esi);                              /* pop esi */
            ii(0x1014_dc84, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_dc85, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_dc86, 1); retd(); return;                         /* ret */
        }
    }
}
