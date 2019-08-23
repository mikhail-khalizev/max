using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_689d-4e2a67d9")]
        public void Method_100b_689d()
        {
            ii(0x100b_689d, 5); pushd(0xbc);                            /* push 0xbc */
            ii(0x100b_68a2, 5); calld(Definitions.sys_check_available_stack_size, 0xa_f4ab); /* call 0x10165d52 */
            ii(0x100b_68a7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_68a8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_68a9, 1); pushd(esi);                             /* push esi */
            ii(0x100b_68aa, 1); pushd(edi);                             /* push edi */
            ii(0x100b_68ab, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_68ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_68ae, 6); sub(esp, 0x98);                         /* sub esp, 0x98 */
            ii(0x100b_68b4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_68b7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_68ba, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_68bf, 5); calld(0x1007_6338, -0x4_058c);          /* call 0x10076338 */
            ii(0x100b_68c4, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100b_68c7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_68c9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_68cb, 5); calld(0x1007_64b8, -0x4_0418);          /* call 0x100764b8 */
            ii(0x100b_68d0, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100b_68d7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_68da, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_fdef); /* call 0x10076af0 */
            ii(0x100b_68df, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_68e2, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_fdf7); /* call 0x10076af0 */
            ii(0x100b_68e7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_68ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_68ed, 5); calld(0x1015_2a52, 0x9_c160);           /* call 0x10152a52 */
            ii(0x100b_68f2, 2); test(al, al);                           /* test al, al */
            ii(0x100b_68f4, 2); if(jnzd(0x100b_6909, 0x13)) goto l_0x100b_6909; /* jnz 0x100b6909 */
            ii(0x100b_68f6, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_68fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_68fc, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_68ff, 5); calld(0x1007_5f6c, -0x4_0998);          /* call 0x10075f6c */
            ii(0x100b_6904, 5); jmpd(0x100b_6e2c, 0x523); goto l_0x100b_6e2c; /* jmp 0x100b6e2c */
        l_0x100b_6909:
            ii(0x100b_6909, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_690c, 5); calld(0x1007_623c, -0x4_06d5);          /* call 0x1007623c */
            ii(0x100b_6911, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6914, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x100b_6918, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x100b_691c, 2); if(jged(0x100b_692d, 0xf)) goto l_0x100b_692d; /* jge 0x100b692d */
            ii(0x100b_691e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6921, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_6924, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_6929, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_692b, 2); if(jgd(0x100b_6932, 0x5)) goto l_0x100b_6932; /* jg 0x100b6932 */
        l_0x100b_692d:
            ii(0x100b_692d, 5); jmpd(0x100b_6b2a, 0x1f8); goto l_0x100b_6b2a; /* jmp 0x100b6b2a */
        l_0x100b_6932:
            ii(0x100b_6932, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100b_6936, 5); calld(0x1008_a6d4, -0x2_c267);          /* call 0x1008a6d4 */
            ii(0x100b_693b, 1); cwde();                                 /* cwde */
            ii(0x100b_693c, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100b_693f, 3); pushd(memd_a32[ss, ebp - 0x30]);        /* push dword [ebp-0x30] */
            ii(0x100b_6942, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6945, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_694a, 2); if(jnzd(0x100b_6952, 0x6)) goto l_0x100b_6952; /* jnz 0x100b6952 */
            ii(0x100b_694c, 4); mov(memb_a32[ss, ebp - 0x2c], 0x2);     /* mov byte [ebp-0x2c], 0x2 */
            ii(0x100b_6950, 2); jmpd(0x100b_6956, 0x4); goto l_0x100b_6956; /* jmp 0x100b6956 */
        l_0x100b_6952:
            ii(0x100b_6952, 4); mov(memb_a32[ss, ebp - 0x2c], 0x3);     /* mov byte [ebp-0x2c], 0x3 */
        l_0x100b_6956:
            ii(0x100b_6956, 3); mov(ecx, memd_a32[ss, ebp - 0x2f]);     /* mov ecx, [ebp-0x2f] */
            ii(0x100b_6959, 3); sar(ecx, 0x18);                         /* sar ecx, 0x18 */
            ii(0x100b_695c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_6961, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6964, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_6967, 5); calld(0x1011_fec1, 0x6_9555);           /* call 0x1011fec1 */
            ii(0x100b_696c, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_696f, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100b_6973, 2); jmpd(0x100b_697d, 0x8); goto l_0x100b_697d; /* jmp 0x100b697d */
        l_0x100b_6975:
            ii(0x100b_6975, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6978, 5); calld(0x1007_6bf8, -0x3_fd85);          /* call 0x10076bf8 */
        l_0x100b_697d:
            ii(0x100b_697d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_697f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6982, 5); calld(0x1013_ad71, 0x8_43ea);           /* call 0x1013ad71 */
            ii(0x100b_6987, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6989, 6); if(jzd(0x100b_6ab8, 0x129)) goto l_0x100b_6ab8; /* jz 0x100b6ab8 */
            ii(0x100b_698f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6992, 5); calld(0x1007_63a0, -0x4_05f7);          /* call 0x100763a0 */
            ii(0x100b_6997, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6999, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_699c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_699f, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_69a2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_69a5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_69a7, 2); if(jnzd(0x100b_69b7, 0xe)) goto l_0x100b_69b7; /* jnz 0x100b69b7 */
            ii(0x100b_69a9, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_69ac, 5); calld(0x1007_63a0, -0x4_0611);          /* call 0x100763a0 */
            ii(0x100b_69b1, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x100b_69b5, 2); if(jnzd(0x100b_69b9, 0x2)) goto l_0x100b_69b9; /* jnz 0x100b69b9 */
        l_0x100b_69b7:
            ii(0x100b_69b7, 2); jmpd(0x100b_69c8, 0xf); goto l_0x100b_69c8; /* jmp 0x100b69c8 */
        l_0x100b_69b9:
            ii(0x100b_69b9, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_69bc, 5); calld(0x1007_63a0, -0x4_0621);          /* call 0x100763a0 */
            ii(0x100b_69c1, 5); cmp(memw_a32[ds, eax + 0x8], 0x39);     /* cmp word [eax+0x8], 0x39 */
            ii(0x100b_69c6, 2); if(jnzd(0x100b_69ca, 0x2)) goto l_0x100b_69ca; /* jnz 0x100b69ca */
        l_0x100b_69c8:
            ii(0x100b_69c8, 2); jmpd(0x100b_69db, 0x11); goto l_0x100b_69db; /* jmp 0x100b69db */
        l_0x100b_69ca:
            ii(0x100b_69ca, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_69cd, 5); calld(0x1007_63a0, -0x4_0632);          /* call 0x100763a0 */
            ii(0x100b_69d2, 5); calld(0x1015_26ac, 0x9_bcd5);           /* call 0x101526ac */
            ii(0x100b_69d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_69d9, 2); if(jnzd(0x100b_69dd, 0x2)) goto l_0x100b_69dd; /* jnz 0x100b69dd */
        l_0x100b_69db:
            ii(0x100b_69db, 2); jmpd(0x100b_69fd, 0x20); goto l_0x100b_69fd; /* jmp 0x100b69fd */
        l_0x100b_69dd:
            ii(0x100b_69dd, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_69e0, 5); calld(0x1007_63a0, -0x4_0645);          /* call 0x100763a0 */
            ii(0x100b_69e5, 5); calld(0x1015_26ac, 0x9_bcc2);           /* call 0x101526ac */
            ii(0x100b_69ea, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100b_69ed, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_69f0, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_69f3, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_69f6, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_69f9, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_69fb, 2); if(jzd(0x100b_69ff, 0x2)) goto l_0x100b_69ff; /* jz 0x100b69ff */
        l_0x100b_69fd:
            ii(0x100b_69fd, 2); jmpd(0x100b_6a10, 0x11); goto l_0x100b_6a10; /* jmp 0x100b6a10 */
        l_0x100b_69ff:
            ii(0x100b_69ff, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a02, 5); calld(0x1007_63d4, -0x4_0633);          /* call 0x100763d4 */
            ii(0x100b_6a07, 5); calld(0x100a_2edb, -0x1_3b31);          /* call 0x100a2edb */
            ii(0x100b_6a0c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6a0e, 2); if(jnzd(0x100b_6a15, 0x5)) goto l_0x100b_6a15; /* jnz 0x100b6a15 */
        l_0x100b_6a10:
            ii(0x100b_6a10, 5); jmpd(0x100b_6ab3, 0x9e); goto l_0x100b_6ab3; /* jmp 0x100b6ab3 */
        l_0x100b_6a15:
            ii(0x100b_6a15, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a18, 5); calld(0x1007_63a0, -0x4_067d);          /* call 0x100763a0 */
            ii(0x100b_6a1d, 5); calld(0x1015_26ac, 0x9_bc8a);           /* call 0x101526ac */
            ii(0x100b_6a22, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100b_6a25, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100b_6a28, 5); calld(0x100a_d247, -0x97e6);            /* call 0x100ad247 */
            ii(0x100b_6a2d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6a2f, 2); if(jnzd(0x100b_6a45, 0x14)) goto l_0x100b_6a45; /* jnz 0x100b6a45 */
            ii(0x100b_6a31, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a34, 5); calld(0x1007_63a0, -0x4_0699);          /* call 0x100763a0 */
            ii(0x100b_6a39, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_6a3c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_6a41, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6a43, 2); if(jnzd(0x100b_6ab3, 0x6e)) goto l_0x100b_6ab3; /* jnz 0x100b6ab3 */
        l_0x100b_6a45:
            ii(0x100b_6a45, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6a48, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a4b, 5); calld(0x1007_63d4, -0x4_067c);          /* call 0x100763d4 */
            ii(0x100b_6a50, 5); calld(0x1007_0d01, -0x4_5d54);          /* call 0x10070d01 */
            ii(0x100b_6a55, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_6a58, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100b_6a5c, 2); if(jzd(0x100b_6a67, 0x9)) goto l_0x100b_6a67; /* jz 0x100b6a67 */
            ii(0x100b_6a5e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_6a61, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_6a65, 2); if(jged(0x100b_6a80, 0x19)) goto l_0x100b_6a80; /* jge 0x100b6a80 */
        l_0x100b_6a67:
            ii(0x100b_6a67, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x100b_6a6a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a6d, 5); calld(0x1007_63d4, -0x4_069e);          /* call 0x100763d4 */
            ii(0x100b_6a72, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6a74, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6a77, 5); calld(0x100b_1bf2, -0x4e8a);            /* call 0x100b1bf2 */
            ii(0x100b_6a7c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6a7e, 2); if(jnzd(0x100b_6a82, 0x2)) goto l_0x100b_6a82; /* jnz 0x100b6a82 */
        l_0x100b_6a80:
            ii(0x100b_6a80, 2); jmpd(0x100b_6ab3, 0x31); goto l_0x100b_6ab3; /* jmp 0x100b6ab3 */
        l_0x100b_6a82:
            ii(0x100b_6a82, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a85, 5); calld(0x1007_63d4, -0x4_06b6);          /* call 0x100763d4 */
            ii(0x100b_6a8a, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_6a8d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_6a90, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_6a93, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6a96, 5); calld(0x1007_63a0, -0x4_06fb);          /* call 0x100763a0 */
            ii(0x100b_6a9b, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_6a9f, 4); mov(memw_a32[ss, ebp - 0x20], ax);      /* mov [ebp-0x20], ax */
            ii(0x100b_6aa3, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6aa6, 5); calld(0x1007_63a0, -0x4_070b);          /* call 0x100763a0 */
            ii(0x100b_6aab, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_6aaf, 4); mov(memw_a32[ss, ebp - 0x1e], ax);      /* mov [ebp-0x1e], ax */
        l_0x100b_6ab3:
            ii(0x100b_6ab3, 5); jmpd(0x100b_6975, -0x143); goto l_0x100b_6975; /* jmp 0x100b6975 */
        l_0x100b_6ab8:
            ii(0x100b_6ab8, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100b_6abc, 2); if(jzd(0x100b_6b20, 0x62)) goto l_0x100b_6b20; /* jz 0x100b6b20 */
            ii(0x100b_6abe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6ac1, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_6ac6, 2); if(jnzd(0x100b_6ad1, 0x9)) goto l_0x100b_6ad1; /* jnz 0x100b6ad1 */
            ii(0x100b_6ac8, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_6acf, 2); jmpd(0x100b_6ad8, 0x7); goto l_0x100b_6ad8; /* jmp 0x100b6ad8 */
        l_0x100b_6ad1:
            ii(0x100b_6ad1, 7); mov(memd_a32[ss, ebp - 0x18], 0x3);     /* mov dword [ebp-0x18], 0x3 */
        l_0x100b_6ad8:
            ii(0x100b_6ad8, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100b_6adb, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100b_6ade, 5); calld(0x1007_5e64, -0x4_0c7f);          /* call 0x10075e64 */
            ii(0x100b_6ae3, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_6ae6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6ae8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6aea, 5); calld(0x1007_0ca1, -0x4_5e4e);          /* call 0x10070ca1 */
            ii(0x100b_6aef, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100b_6af3, 2); if(jgd(0x100b_6b20, 0x2b)) goto l_0x100b_6b20; /* jg 0x100b6b20 */
            ii(0x100b_6af5, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x100b_6af8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6afb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_6afe, 5); calld(0x100b_6599, -0x56a);             /* call 0x100b6599 */
            ii(0x100b_6b03, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_6b07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6b09, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_6b0c, 5); calld(Definitions.my_dtor_d1, -0x2_de15); /* call 0x10088cfc */
            ii(0x100b_6b11, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6b13, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6b16, 5); calld(0x1007_5f6c, -0x4_0baf);          /* call 0x10075f6c */
            ii(0x100b_6b1b, 5); jmpd(0x100b_6e2c, 0x30c); goto l_0x100b_6e2c; /* jmp 0x100b6e2c */
        l_0x100b_6b20:
            ii(0x100b_6b20, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6b22, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_6b25, 5); calld(Definitions.my_dtor_d1, -0x2_de2e); /* call 0x10088cfc */
        l_0x100b_6b2a:
            ii(0x100b_6b2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6b2d, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100b_6b30, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_6b33, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6b35, 6); if(jled(0x100b_6ce0, 0x1a5)) goto l_0x100b_6ce0; /* jle 0x100b6ce0 */
            ii(0x100b_6b3b, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_6b40, 5); calld(0x1007_6338, -0x4_080d);          /* call 0x10076338 */
            ii(0x100b_6b45, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100b_6b48, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6b4a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6b4c, 5); calld(0x1007_643c, -0x4_0715);          /* call 0x1007643c */
            ii(0x100b_6b51, 2); jmpd(0x100b_6b5b, 0x8); goto l_0x100b_6b5b; /* jmp 0x100b6b5b */
        l_0x100b_6b53:
            ii(0x100b_6b53, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6b56, 5); calld(0x1007_6bf8, -0x3_ff63);          /* call 0x10076bf8 */
        l_0x100b_6b5b:
            ii(0x100b_6b5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6b5d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6b60, 5); calld(0x1013_ad71, 0x8_420c);           /* call 0x1013ad71 */
            ii(0x100b_6b65, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6b67, 6); if(jzd(0x100b_6ce0, 0x173)) goto l_0x100b_6ce0; /* jz 0x100b6ce0 */
            ii(0x100b_6b6d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6b70, 5); calld(0x1007_63a0, -0x4_07d5);          /* call 0x100763a0 */
            ii(0x100b_6b75, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_6b79, 2); if(jnzd(0x100b_6b8d, 0x12)) goto l_0x100b_6b8d; /* jnz 0x100b6b8d */
            ii(0x100b_6b7b, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6b7e, 5); calld(0x1007_63a0, -0x4_07e3);          /* call 0x100763a0 */
            ii(0x100b_6b83, 5); calld(0x1007_611c, -0x4_0a6c);          /* call 0x1007611c */
            ii(0x100b_6b88, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x100b_6b8b, 2); if(jzd(0x100b_6b8f, 0x2)) goto l_0x100b_6b8f; /* jz 0x100b6b8f */
        l_0x100b_6b8d:
            ii(0x100b_6b8d, 2); jmpd(0x100b_6ba9, 0x1a); goto l_0x100b_6ba9; /* jmp 0x100b6ba9 */
        l_0x100b_6b8f:
            ii(0x100b_6b8f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6b92, 5); calld(0x1007_63a0, -0x4_07f7);          /* call 0x100763a0 */
            ii(0x100b_6b97, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6b99, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_6b9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_6b9f, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_6ba2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_6ba5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6ba7, 2); if(jzd(0x100b_6bae, 0x5)) goto l_0x100b_6bae; /* jz 0x100b6bae */
        l_0x100b_6ba9:
            ii(0x100b_6ba9, 5); jmpd(0x100b_6cdb, 0x12d); goto l_0x100b_6cdb; /* jmp 0x100b6cdb */
        l_0x100b_6bae:
            ii(0x100b_6bae, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6bb1, 5); calld(0x1007_63a0, -0x4_0816);          /* call 0x100763a0 */
            ii(0x100b_6bb6, 5); calld(0x1015_26ac, 0x9_baf1);           /* call 0x101526ac */
            ii(0x100b_6bbb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6bbd, 2); if(jzd(0x100b_6bdf, 0x20)) goto l_0x100b_6bdf; /* jz 0x100b6bdf */
            ii(0x100b_6bbf, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6bc2, 5); calld(0x1007_63a0, -0x4_0827);          /* call 0x100763a0 */
            ii(0x100b_6bc7, 5); calld(0x1015_26ac, 0x9_bae0);           /* call 0x101526ac */
            ii(0x100b_6bcc, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100b_6bcf, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100b_6bd2, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_6bd5, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100b_6bd8, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_6bdb, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_6bdd, 2); if(jzd(0x100b_6c2d, 0x4e)) goto l_0x100b_6c2d; /* jz 0x100b6c2d */
        l_0x100b_6bdf:
            ii(0x100b_6bdf, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_6be4, 5); calld(Definitions.sys_new, 0xa_f217);   /* call 0x10165e00 */
            ii(0x100b_6be9, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100b_6bec, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100b_6bef, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100b_6bf2, 4); cmp(memd_a32[ss, ebp - 0x5c], 0);       /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x100b_6bf6, 2); if(jzd(0x100b_6c1a, 0x22)) goto l_0x100b_6c1a; /* jz 0x100b6c1a */
            ii(0x100b_6bf8, 5); mov(ebx, 0x100b_0ebb);                  /* mov ebx, 0x100b0ebb */
            ii(0x100b_6bfd, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6c00, 5); calld(0x1007_63d4, -0x4_0831);          /* call 0x100763d4 */
            ii(0x100b_6c05, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6c07, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100b_6c0a, 5); calld(0x100a_c45d, -0xa7b2);            /* call 0x100ac45d */
            ii(0x100b_6c0f, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100b_6c12, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100b_6c15, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100b_6c18, 2); jmpd(0x100b_6c20, 0x6); goto l_0x100b_6c20; /* jmp 0x100b6c20 */
        l_0x100b_6c1a:
            ii(0x100b_6c1a, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100b_6c1d, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
        l_0x100b_6c20:
            ii(0x100b_6c20, 3); mov(edx, memd_a32[ss, ebp - 0x64]);     /* mov edx, [ebp-0x64] */
            ii(0x100b_6c23, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_6c28, 5); calld(0x100a_4d50, -0x1_1edd);          /* call 0x100a4d50 */
        l_0x100b_6c2d:
            ii(0x100b_6c2d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6c30, 5); calld(0x1007_63a0, -0x4_0895);          /* call 0x100763a0 */
            ii(0x100b_6c35, 5); calld(0x1015_26ac, 0x9_ba72);           /* call 0x101526ac */
            ii(0x100b_6c3a, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100b_6c3d, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100b_6c40, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_6c43, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100b_6c46, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_6c49, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_6c4b, 2); if(jnzd(0x100b_6c56, 0x9)) goto l_0x100b_6c56; /* jnz 0x100b6c56 */
            ii(0x100b_6c4d, 7); mov(memd_a32[ss, ebp - 0x6c], 0);       /* mov dword [ebp-0x6c], 0x0 */
            ii(0x100b_6c54, 2); jmpd(0x100b_6c6f, 0x19); goto l_0x100b_6c6f; /* jmp 0x100b6c6f */
        l_0x100b_6c56:
            ii(0x100b_6c56, 5); mov(ecx, 0x1120);                       /* mov ecx, 0x1120 */
            ii(0x100b_6c5b, 5); mov(ebx, StringDefinitions.AiMoveCpp12); /* mov ebx, 0x101a1191 */
            ii(0x100b_6c60, 5); mov(edx, StringDefinitions.ClientGettaskGettypeEqualTaskMove); /* mov edx, 0x101a119d */
            ii(0x100b_6c65, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_6c67, 5); calld(Definitions.sys_assert, 0xa_f126); /* call 0x10165d92 */
            ii(0x100b_6c6c, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
        l_0x100b_6c6f:
            ii(0x100b_6c6f, 3); lea(edx, ebp - 0x70);                   /* lea edx, [ebp-0x70] */
            ii(0x100b_6c72, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6c75, 5); calld(0x1007_63a0, -0x4_08da);          /* call 0x100763a0 */
            ii(0x100b_6c7a, 5); calld(0x1015_26ac, 0x9_ba2d);           /* call 0x101526ac */
            ii(0x100b_6c7f, 5); calld(0x100b_7da0, 0x111c);             /* call 0x100b7da0 */
            ii(0x100b_6c84, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6c86, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_6c89, 5); calld(0x1008_8b44, -0x2_e14a);          /* call 0x10088b44 */
            ii(0x100b_6c8e, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100b_6c91, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100b_6c94, 5); calld(0x1007_5e64, -0x4_0e35);          /* call 0x10075e64 */
            ii(0x100b_6c99, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_6c9c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6c9e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6ca0, 5); calld(0x1007_0ca1, -0x4_6004);          /* call 0x10070ca1 */
            ii(0x100b_6ca5, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_6ca8, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_6cac, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6cae, 2); if(jld(0x100b_6cdb, 0x2b)) goto l_0x100b_6cdb; /* jl 0x100b6cdb */
            ii(0x100b_6cb0, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100b_6cb4, 2); if(jzd(0x100b_6cbf, 0x9)) goto l_0x100b_6cbf; /* jz 0x100b6cbf */
            ii(0x100b_6cb6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_6cb9, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_6cbd, 2); if(jged(0x100b_6cdb, 0x1c)) goto l_0x100b_6cdb; /* jge 0x100b6cdb */
        l_0x100b_6cbf:
            ii(0x100b_6cbf, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6cc2, 5); calld(0x1007_63d4, -0x4_08f3);          /* call 0x100763d4 */
            ii(0x100b_6cc7, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_6cca, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_6ccd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_6cd0, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100b_6cd3, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_6cd6, 5); calld(0x1008_8b44, -0x2_e197);          /* call 0x10088b44 */
        l_0x100b_6cdb:
            ii(0x100b_6cdb, 5); jmpd(0x100b_6b53, -0x18d); goto l_0x100b_6b53; /* jmp 0x100b6b53 */
        l_0x100b_6ce0:
            ii(0x100b_6ce0, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100b_6ce4, 6); if(jzd(0x100b_6e12, 0x128)) goto l_0x100b_6e12; /* jz 0x100b6e12 */
            ii(0x100b_6cea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6ced, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_6cf2, 2); if(jnzd(0x100b_6cfd, 0x9)) goto l_0x100b_6cfd; /* jnz 0x100b6cfd */
            ii(0x100b_6cf4, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_6cfb, 2); jmpd(0x100b_6d04, 0x7); goto l_0x100b_6d04; /* jmp 0x100b6d04 */
        l_0x100b_6cfd:
            ii(0x100b_6cfd, 7); mov(memd_a32[ss, ebp - 0x18], 0x3);     /* mov dword [ebp-0x18], 0x3 */
        l_0x100b_6d04:
            ii(0x100b_6d04, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100b_6d07, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x100b_6d0a, 5); calld(0x1007_5e64, -0x4_0eab);          /* call 0x10075e64 */
            ii(0x100b_6d0f, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_6d12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6d14, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6d16, 5); calld(0x1007_0ca1, -0x4_607a);          /* call 0x10070ca1 */
            ii(0x100b_6d1b, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100b_6d1f, 2); if(jgd(0x100b_6d43, 0x22)) goto l_0x100b_6d43; /* jg 0x100b6d43 */
            ii(0x100b_6d21, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100b_6d24, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x100b_6d27, 5); calld(0x1007_5e64, -0x4_0ec8);          /* call 0x10075e64 */
            ii(0x100b_6d2c, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x100b_6d2f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6d32, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100b_6d35, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_6d37, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100b_6d39, 5); calld(0x100b_670a, -0x634);             /* call 0x100b670a */
            ii(0x100b_6d3e, 5); jmpd(0x100b_6e02, 0xbf); goto l_0x100b_6e02; /* jmp 0x100b6e02 */
        l_0x100b_6d43:
            ii(0x100b_6d43, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_6d48, 5); calld(Definitions.sys_new, 0xa_f0b3);   /* call 0x10165e00 */
            ii(0x100b_6d4d, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100b_6d50, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100b_6d53, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x100b_6d59, 7); cmp(memd_a32[ss, ebp - 0x84], 0);       /* cmp dword [ebp-0x84], 0x0 */
            ii(0x100b_6d60, 2); if(jzd(0x100b_6dc1, 0x5f)) goto l_0x100b_6dc1; /* jz 0x100b6dc1 */
            ii(0x100b_6d62, 5); mov(eax, 0x100b_0ebb);                  /* mov eax, 0x100b0ebb */
            ii(0x100b_6d67, 1); pushd(eax);                             /* push eax */
            ii(0x100b_6d68, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100b_6d6b, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100b_6d71, 5); calld(0x1007_5e64, -0x4_0f12);          /* call 0x10075e64 */
            ii(0x100b_6d76, 1); pushd(eax);                             /* push eax */
            ii(0x100b_6d77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6d7a, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_6d7f, 2); if(jnzd(0x100b_6d8a, 0x9)) goto l_0x100b_6d8a; /* jnz 0x100b6d8a */
            ii(0x100b_6d81, 7); mov(memb_a32[ss, ebp - 0x8c], 0x2);     /* mov byte [ebp-0x8c], 0x2 */
            ii(0x100b_6d88, 2); jmpd(0x100b_6d91, 0x7); goto l_0x100b_6d91; /* jmp 0x100b6d91 */
        l_0x100b_6d8a:
            ii(0x100b_6d8a, 7); mov(memb_a32[ss, ebp - 0x8c], 0x3);     /* mov byte [ebp-0x8c], 0x3 */
        l_0x100b_6d91:
            ii(0x100b_6d91, 6); mov(eax, memd_a32[ss, ebp - 0x8f]);     /* mov eax, [ebp-0x8f] */
            ii(0x100b_6d97, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100b_6d9a, 1); pushd(eax);                             /* push eax */
            ii(0x100b_6d9b, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x100b_6d9f, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100b_6da2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_6da5, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100b_6da8, 5); calld(0x100a_c220, -0xab8d);            /* call 0x100ac220 */
            ii(0x100b_6dad, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x100b_6db3, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100b_6db9, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x100b_6dbf, 2); jmpd(0x100b_6dcd, 0xc); goto l_0x100b_6dcd; /* jmp 0x100b6dcd */
        l_0x100b_6dc1:
            ii(0x100b_6dc1, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100b_6dc7, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
        l_0x100b_6dcd:
            ii(0x100b_6dcd, 6); mov(edx, memd_a32[ss, ebp - 0x94]);     /* mov edx, [ebp-0x94] */
            ii(0x100b_6dd3, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x100b_6dd9, 5); calld(0x1008_b060, -0x2_bd7e);          /* call 0x1008b060 */
            ii(0x100b_6dde, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x100b_6de4, 5); calld(0x1008_af84, -0x2_be65);          /* call 0x1008af84 */
            ii(0x100b_6de9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6deb, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_6df0, 5); calld(0x100a_4d50, -0x1_20a5);          /* call 0x100a4d50 */
            ii(0x100b_6df5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6df7, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x100b_6dfd, 5); calld(0x1008_8b7c, -0x2_e286);          /* call 0x10088b7c */
        l_0x100b_6e02:
            ii(0x100b_6e02, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_6e06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6e08, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6e0b, 5); calld(0x1007_5f6c, -0x4_0ea4);          /* call 0x10075f6c */
            ii(0x100b_6e10, 2); jmpd(0x100b_6e2c, 0x1a); goto l_0x100b_6e2c; /* jmp 0x100b6e2c */
        l_0x100b_6e12:
            ii(0x100b_6e12, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_6e16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6e18, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_6e1b, 5); calld(0x1007_5f6c, -0x4_0eb4);          /* call 0x10075f6c */
            ii(0x100b_6e20, 2); jmpd(0x100b_6e2c, 0xa); goto l_0x100b_6e2c; /* jmp 0x100b6e2c */
        //  ii(0x100b_6e22, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_6e24, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
        //  ii(0x100b_6e27, 5); calld(0x1007_5f6c, -0x4_0ec0);          /* call 0x10075f6c */
        l_0x100b_6e2c:
            ii(0x100b_6e2c, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_6e2f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6e31, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_6e32, 1); popd(edi);                              /* pop edi */
            ii(0x100b_6e33, 1); popd(esi);                              /* pop esi */
            ii(0x100b_6e34, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_6e35, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_6e36, 1); retd();                                 /* ret */
        }
    }
}
