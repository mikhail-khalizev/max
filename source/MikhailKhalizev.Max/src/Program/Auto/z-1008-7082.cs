using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7082-4d9bfcf6")]
        public void Method_1008_7082()
        {
            ii(0x1008_7082, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1008_7087, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ecc6); /* call 0x10165d52 */
            ii(0x1008_708c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_708d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_708e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_708f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7090, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7091, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7093, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1008_7099, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_709c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_709f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_70a2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_70a5, 5); calld(0x1007_6338, -0x1_0d72);          /* call 0x10076338 */
            ii(0x1008_70aa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_70ac, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_70af, 5); calld(0x1007_64b8, -0x1_0bfc);          /* call 0x100764b8 */
            ii(0x1008_70b4, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_70b8, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_70bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_70bf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_70c2, 3); mov(memd_a32[ds, edx + 0x21], eax);     /* mov [edx+0x21], eax */
            ii(0x1008_70c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_70c8, 4); test(memb_a32[ds, eax + 0x22], 0x1);    /* test byte [eax+0x22], 0x1 */
            ii(0x1008_70cc, 2); if(jzd(0x1008_70d6, 0x8)) goto l_0x1008_70d6; /* jz 0x100870d6 */
            ii(0x1008_70ce, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_70d2, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1008_70d6:
            ii(0x1008_70d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_70d9, 4); test(memb_a32[ds, eax + 0x21], 0x80);   /* test byte [eax+0x21], 0x80 */
            ii(0x1008_70dd, 2); if(jzd(0x1008_70e3, 0x4)) goto l_0x1008_70e3; /* jz 0x100870e3 */
            ii(0x1008_70df, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_70e3:
            ii(0x1008_70e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_70e6, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_70e9, 5); calld(0x1008_afb4, 0x3ec6);             /* call 0x1008afb4 */
            ii(0x1008_70ee, 5); calld(0x1008_60dd, -0x1016);            /* call 0x100860dd */
            ii(0x1008_70f3, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_70f6, 2); jmpd(0x1008_7100, 0x8); goto l_0x1008_7100; /* jmp 0x10087100 */
        l_0x1008_70f8:
            ii(0x1008_70f8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_70fb, 5); calld(0x1007_6bf8, -0x1_0508);          /* call 0x10076bf8 */
        l_0x1008_7100:
            ii(0x1008_7100, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7102, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7105, 5); calld(0x1013_ad71, 0xb_3c67);           /* call 0x1013ad71 */
            ii(0x1008_710a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_710c, 6); if(jzd(0x1008_7222, 0x110)) goto l_0x1008_7222; /* jz 0x10087222 */
            ii(0x1008_7112, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7115, 5); calld(0x1007_63a0, -0x1_0d7a);          /* call 0x100763a0 */
            ii(0x1008_711a, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1008_711d, 3); test(memd_a32[ss, ebp - 0x4], eax);     /* test [ebp-0x4], eax */
            ii(0x1008_7120, 2); if(jzd(0x1008_7135, 0x13)) goto l_0x1008_7135; /* jz 0x10087135 */
            ii(0x1008_7122, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7125, 5); calld(0x1007_63d4, -0x1_0d56);          /* call 0x100763d4 */
            ii(0x1008_712a, 5); calld(0x1007_6ec0, -0x1_026f);          /* call 0x10076ec0 */
            ii(0x1008_712f, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1008_7133, 2); if(jled(0x1008_7157, 0x22)) goto l_0x1008_7157; /* jle 0x10087157 */
        l_0x1008_7135:
            ii(0x1008_7135, 5); calld(0x1008_a79c, 0x3662);             /* call 0x1008a79c */
            ii(0x1008_713a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_713c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_713e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7141, 5); calld(0x1007_63d4, -0x1_0d72);          /* call 0x100763d4 */
            ii(0x1008_7146, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_7148, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_714d, 5); calld(0x100a_53ac, 0x1_e25a);           /* call 0x100a53ac */
            ii(0x1008_7152, 5); jmpd(0x1008_721d, 0xc6); goto l_0x1008_721d; /* jmp 0x1008721d */
        l_0x1008_7157:
            ii(0x1008_7157, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_715a, 5); calld(0x1007_63a0, -0x1_0dbf);          /* call 0x100763a0 */
            ii(0x1008_715f, 5); cmp(memw_a32[ds, eax + 0x8], 0x4b);     /* cmp word [eax+0x8], 0x4b */
            ii(0x1008_7164, 2); if(jzd(0x1008_7175, 0xf)) goto l_0x1008_7175; /* jz 0x10087175 */
            ii(0x1008_7166, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7169, 5); calld(0x1007_63a0, -0x1_0dce);          /* call 0x100763a0 */
            ii(0x1008_716e, 5); cmp(memw_a32[ds, eax + 0x8], 0x3b);     /* cmp word [eax+0x8], 0x3b */
            ii(0x1008_7173, 2); if(jnzd(0x1008_7177, 0x2)) goto l_0x1008_7177; /* jnz 0x10087177 */
        l_0x1008_7175:
            ii(0x1008_7175, 2); jmpd(0x1008_718a, 0x13); goto l_0x1008_718a; /* jmp 0x1008718a */
        l_0x1008_7177:
            ii(0x1008_7177, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_717a, 5); calld(0x1007_63a0, -0x1_0ddf);          /* call 0x100763a0 */
            ii(0x1008_717f, 5); cmp(memw_a32[ds, eax + 0x8], 0x3f);     /* cmp word [eax+0x8], 0x3f */
            ii(0x1008_7184, 6); if(jnzd(0x1008_721d, 0x93)) goto l_0x1008_721d; /* jnz 0x1008721d */
        l_0x1008_718a:
            ii(0x1008_718a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_718d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7190, 5); calld(0x1007_63a0, -0x1_0df5);          /* call 0x100763a0 */
            ii(0x1008_7195, 5); calld(0x1015_2a52, 0xc_b8b8);           /* call 0x10152a52 */
            ii(0x1008_719a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_719c, 2); if(jzd(0x1008_71b1, 0x13)) goto l_0x1008_71b1; /* jz 0x100871b1 */
            ii(0x1008_719e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_71a1, 5); calld(0x1007_63a0, -0x1_0e06);          /* call 0x100763a0 */
            ii(0x1008_71a6, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1008_71a9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_71ac, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1008_71af, 2); if(jld(0x1008_71b3, 0x2)) goto l_0x1008_71b3; /* jl 0x100871b3 */
        l_0x1008_71b1:
            ii(0x1008_71b1, 2); jmpd(0x1008_7204, 0x51); goto l_0x1008_7204; /* jmp 0x10087204 */
        l_0x1008_71b3:
            ii(0x1008_71b3, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1008_71b8, 5); calld(Definitions.sys_new, 0xd_ec43);   /* call 0x10165e00 */
            ii(0x1008_71bd, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_71c0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_71c3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_71c6, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1008_71ca, 2); if(jzd(0x1008_71f1, 0x25)) goto l_0x1008_71f1; /* jz 0x100871f1 */
            ii(0x1008_71cc, 5); mov(ecx, 0x5);                          /* mov ecx, 0x5 */
            ii(0x1008_71d1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_71d4, 5); calld(0x1007_63d4, -0x1_0e05);          /* call 0x100763d4 */
            ii(0x1008_71d9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_71db, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_71de, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_71e1, 5); calld(0x1008_bd0b, 0x4b25);             /* call 0x1008bd0b */
            ii(0x1008_71e6, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_71e9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_71ec, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1008_71ef, 2); jmpd(0x1008_71f7, 0x6); goto l_0x1008_71f7; /* jmp 0x100871f7 */
        l_0x1008_71f1:
            ii(0x1008_71f1, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_71f4, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1008_71f7:
            ii(0x1008_71f7, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1008_71fa, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_71ff, 5); calld(0x100a_4d50, 0x1_db4c);           /* call 0x100a4d50 */
        l_0x1008_7204:
            ii(0x1008_7204, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7207, 5); calld(0x1007_63a0, -0x1_0e6c);          /* call 0x100763a0 */
            ii(0x1008_720c, 5); cmp(memw_a32[ds, eax + 0x8], 0x3f);     /* cmp word [eax+0x8], 0x3f */
            ii(0x1008_7211, 2); if(jnzd(0x1008_7219, 0x6)) goto l_0x1008_7219; /* jnz 0x10087219 */
            ii(0x1008_7213, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_7217, 2); jmpd(0x1008_721d, 0x4); goto l_0x1008_721d; /* jmp 0x1008721d */
        l_0x1008_7219:
            ii(0x1008_7219, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1008_721d:
            ii(0x1008_721d, 5); jmpd(0x1008_70f8, -0x12a); goto l_0x1008_70f8; /* jmp 0x100870f8 */
        l_0x1008_7222:
            ii(0x1008_7222, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1008_7226, 2); if(jnzd(0x1008_7232, 0xa)) goto l_0x1008_7232; /* jnz 0x10087232 */
            ii(0x1008_7228, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_722b, 5); cmp(memw_a32[ds, eax + 0x1d], -0x1 /* 0xff */); /* cmp word [eax+0x1d], 0xffff */
            ii(0x1008_7230, 2); if(jzd(0x1008_7247, 0x15)) goto l_0x1008_7247; /* jz 0x10087247 */
        l_0x1008_7232:
            ii(0x1008_7232, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1008_7236, 2); if(jnzd(0x1008_7242, 0xa)) goto l_0x1008_7242; /* jnz 0x10087242 */
            ii(0x1008_7238, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_723b, 5); cmp(memw_a32[ds, eax + 0x1f], -0x1 /* 0xff */); /* cmp word [eax+0x1f], 0xffff */
            ii(0x1008_7240, 2); if(jzd(0x1008_7247, 0x5)) goto l_0x1008_7247; /* jz 0x10087247 */
        l_0x1008_7242:
            ii(0x1008_7242, 5); jmpd(0x1008_732f, 0xe8); goto l_0x1008_732f; /* jmp 0x1008732f */
        l_0x1008_7247:
            ii(0x1008_7247, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1008_724c, 5); calld(Definitions.sys_new, 0xd_ebaf);   /* call 0x10165e00 */
            ii(0x1008_7251, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1008_7254, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_7257, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_725a, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1008_725e, 2); if(jzd(0x1008_7283, 0x23)) goto l_0x1008_7283; /* jz 0x10087283 */
            ii(0x1008_7260, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1008_7263, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7266, 5); calld(0x100a_2d3d, 0x1_bad2);           /* call 0x100a2d3d */
            ii(0x1008_726b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_726d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_7270, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_7273, 5); calld(Definitions.my_ctor_c12, 0x1_edf4); /* call 0x100a606c */
            ii(0x1008_7278, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_727b, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1008_727e, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1008_7281, 2); jmpd(0x1008_7289, 0x6); goto l_0x1008_7289; /* jmp 0x10087289 */
        l_0x1008_7283:
            ii(0x1008_7283, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_7286, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x1008_7289:
            ii(0x1008_7289, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1008_728c, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_728f, 5); calld(0x1008_a914, 0x3680);             /* call 0x1008a914 */
            ii(0x1008_7294, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1008_7298, 2); if(jnzd(0x1008_72a4, 0xa)) goto l_0x1008_72a4; /* jnz 0x100872a4 */
            ii(0x1008_729a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_729d, 5); cmp(memw_a32[ds, eax + 0x1d], -0x1 /* 0xff */); /* cmp word [eax+0x1d], 0xffff */
            ii(0x1008_72a2, 2); if(jzd(0x1008_72a6, 0x2)) goto l_0x1008_72a6; /* jz 0x100872a6 */
        l_0x1008_72a4:
            ii(0x1008_72a4, 2); jmpd(0x1008_72d9, 0x33); goto l_0x1008_72d9; /* jmp 0x100872d9 */
        l_0x1008_72a6:
            ii(0x1008_72a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_72a9, 4); test(memb_a32[ds, eax + 0x21], 0x80);   /* test byte [eax+0x21], 0x80 */
            ii(0x1008_72ad, 2); if(jzd(0x1008_72ba, 0xb)) goto l_0x1008_72ba; /* jz 0x100872ba */
            ii(0x1008_72af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_72b2, 6); mov(memw_a32[ds, eax + 0x1d], 0x4b);    /* mov word [eax+0x1d], 0x4b */
            ii(0x1008_72b8, 2); jmpd(0x1008_72c3, 0x9); goto l_0x1008_72c3; /* jmp 0x100872c3 */
        l_0x1008_72ba:
            ii(0x1008_72ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_72bd, 6); mov(memw_a32[ds, eax + 0x1d], 0x3b);    /* mov word [eax+0x1d], 0x3b */
        l_0x1008_72c3:
            ii(0x1008_72c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_72c6, 3); mov(edx, memd_a32[ds, eax + 0x1b]);     /* mov edx, [eax+0x1b] */
            ii(0x1008_72c9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_72cc, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_72cf, 5); calld(0x1008_a7dc, 0x3508);             /* call 0x1008a7dc */
            ii(0x1008_72d4, 5); calld(0x100a_63bc, 0x1_f0e3);           /* call 0x100a63bc */
        l_0x1008_72d9:
            ii(0x1008_72d9, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1008_72dd, 2); if(jnzd(0x1008_72e8, 0x9)) goto l_0x1008_72e8; /* jnz 0x100872e8 */
            ii(0x1008_72df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_72e2, 4); test(memb_a32[ds, eax + 0x22], 0x1);    /* test byte [eax+0x22], 0x1 */
            ii(0x1008_72e6, 2); if(jnzd(0x1008_72ea, 0x2)) goto l_0x1008_72ea; /* jnz 0x100872ea */
        l_0x1008_72e8:
            ii(0x1008_72e8, 2); jmpd(0x1008_72f4, 0xa); goto l_0x1008_72f4; /* jmp 0x100872f4 */
        l_0x1008_72ea:
            ii(0x1008_72ea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_72ed, 5); cmp(memw_a32[ds, eax + 0x1f], -0x1 /* 0xff */); /* cmp word [eax+0x1f], 0xffff */
            ii(0x1008_72f2, 2); if(jzd(0x1008_72f6, 0x2)) goto l_0x1008_72f6; /* jz 0x100872f6 */
        l_0x1008_72f4:
            ii(0x1008_72f4, 2); jmpd(0x1008_7311, 0x1b); goto l_0x1008_7311; /* jmp 0x10087311 */
        l_0x1008_72f6:
            ii(0x1008_72f6, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x1008_72fb, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_72fe, 5); calld(0x1008_a7dc, 0x34d9);             /* call 0x1008a7dc */
            ii(0x1008_7303, 5); calld(0x100a_63bc, 0x1_f0b4);           /* call 0x100a63bc */
            ii(0x1008_7308, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_730b, 6); mov(memw_a32[ds, eax + 0x1f], 0x3f);    /* mov word [eax+0x1f], 0x3f */
        l_0x1008_7311:
            ii(0x1008_7311, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_7314, 5); calld(0x1008_a838, 0x351f);             /* call 0x1008a838 */
            ii(0x1008_7319, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_731b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_7320, 5); calld(0x100a_4d50, 0x1_da2b);           /* call 0x100a4d50 */
            ii(0x1008_7325, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7327, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_732a, 5); calld(0x1008_8cbc, 0x198d);             /* call 0x10088cbc */
        l_0x1008_732f:
            ii(0x1008_732f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7331, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7334, 5); calld(0x1007_5f6c, -0x1_13cd);          /* call 0x10075f6c */
            ii(0x1008_7339, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_733b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_733c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_733d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_733e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_733f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_7340, 1); retd(); return;                         /* ret */
        }
    }
}
