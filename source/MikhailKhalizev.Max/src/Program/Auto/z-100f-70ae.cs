using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eaf3c2ea-eb5e-4439-a5c1-b11f7009d365")]
        public void Method_100f_70ae()
        {
            ii(0x100f_70ae, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100f_70b3, 5); calld(Definitions.sys_check_available_stack_size, 0x6_ec9a); /* call 0x10165d52 */
            ii(0x100f_70b8, 1); pushd(esi);                             /* push esi */
            ii(0x100f_70b9, 1); pushd(edi);                             /* push edi */
            ii(0x100f_70ba, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_70bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_70bd, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100f_70c3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_70c6, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_70c9, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100f_70cc, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100f_70cf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_70d2, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_70d6, 2); if(jnzd(0x100f_7130, 0x58)) goto l_0x100f_7130; /* jnz 0x100f7130 */
            ii(0x100f_70d8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_70db, 5); calld(0x1007_611c, -0x8_0fc4);          /* call 0x1007611c */
            ii(0x100f_70e0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_70e3, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_70e7, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_70eb, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_70ee, 5); calld(0x100f_1f41, -0x51b2);            /* call 0x100f1f41 */
            ii(0x100f_70f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_70f5, 2); if(jzd(0x100f_712b, 0x34)) goto l_0x100f_712b; /* jz 0x100f712b */
            ii(0x100f_70f7, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_70fc, 1); pushd(eax);                             /* push eax */
            ii(0x100f_70fd, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x100f_7101, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100f_7105, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_7107, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_710c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_710f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7112, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_7115, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_7118, 5); calld(0x1007_02b9, -0x8_6e64);          /* call 0x100702b9 */
            ii(0x100f_711d, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100f_7120, 2); if(jzd(0x100f_712b, 0x9)) goto l_0x100f_712b; /* jz 0x100f712b */
            ii(0x100f_7122, 4); mov(memb_a32[ss, ebp - 0x14], 0x14);    /* mov byte [ebp-0x14], 0x14 */
            ii(0x100f_7126, 5); jmpd(0x100f_7309, 0x1de); goto l_0x100f_7309; /* jmp 0x100f7309 */
        l_0x100f_712b:
            ii(0x100f_712b, 5); jmpd(0x100f_72f3, 0x1c3); goto l_0x100f_72f3; /* jmp 0x100f72f3 */
        l_0x100f_7130:
            ii(0x100f_7130, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7133, 4); cmp(memb_a32[ds, eax + 0x3e], 0x19);    /* cmp byte [eax+0x3e], 0x19 */
            ii(0x100f_7137, 6); if(jnzd(0x100f_72f3, 0x1b6)) goto l_0x100f_72f3; /* jnz 0x100f72f3 */
            ii(0x100f_713d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7140, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100f_7144, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_7147, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_714a, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100f_714e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_7151, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7154, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x100f_7159, 2); if(jnzd(0x100f_716c, 0x11)) goto l_0x100f_716c; /* jnz 0x100f716c */
            ii(0x100f_715b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_715e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_7161, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_7164, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_7167, 5); jmpd(0x100f_71d4, 0x68); goto l_0x100f_71d4; /* jmp 0x100f71d4 */
        l_0x100f_716c:
            ii(0x100f_716c, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100f_7170, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_7173, 2); if(jled(0x100f_717e, 0x9)) goto l_0x100f_717e; /* jle 0x100f717e */
            ii(0x100f_7175, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_7178, 1); dec(eax);                               /* dec eax */
            ii(0x100f_7179, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_717c, 2); jmpd(0x100f_71a0, 0x22); goto l_0x100f_71a0; /* jmp 0x100f71a0 */
        l_0x100f_717e:
            ii(0x100f_717e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100f_7182, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_7185, 2); if(jged(0x100f_718f, 0x8)) goto l_0x100f_718f; /* jge 0x100f718f */
            ii(0x100f_7187, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_718a, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_718d, 2); jmpd(0x100f_71a0, 0x11); goto l_0x100f_71a0; /* jmp 0x100f71a0 */
        l_0x100f_718f:
            ii(0x100f_718f, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_7194, 5); calld(0x1007_6574, -0x8_0c25);          /* call 0x10076574 */
            ii(0x100f_7199, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100f_719d, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100f_71a0:
            ii(0x100f_71a0, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_71a4, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_71a7, 2); if(jled(0x100f_71b2, 0x9)) goto l_0x100f_71b2; /* jle 0x100f71b2 */
            ii(0x100f_71a9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_71ac, 1); dec(eax);                               /* dec eax */
            ii(0x100f_71ad, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_71b0, 2); jmpd(0x100f_71d4, 0x22); goto l_0x100f_71d4; /* jmp 0x100f71d4 */
        l_0x100f_71b2:
            ii(0x100f_71b2, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_71b6, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_71b9, 2); if(jged(0x100f_71c3, 0x8)) goto l_0x100f_71c3; /* jge 0x100f71c3 */
            ii(0x100f_71bb, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_71be, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_71c1, 2); jmpd(0x100f_71d4, 0x11); goto l_0x100f_71d4; /* jmp 0x100f71d4 */
        l_0x100f_71c3:
            ii(0x100f_71c3, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_71c8, 5); calld(0x1007_6574, -0x8_0c59);          /* call 0x10076574 */
            ii(0x100f_71cd, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100f_71d1, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100f_71d4:
            ii(0x100f_71d4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_71d7, 5); cmp(memw_a32[ds, eax + 0x8], 0x30);     /* cmp word [eax+0x8], 0x30 */
            ii(0x100f_71dc, 6); if(jnzd(0x100f_7247, 0x65)) goto l_0x100f_7247; /* jnz 0x100f7247 */
            ii(0x100f_71e2, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100f_71e6, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100f_71ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_71ed, 5); calld(0x1015_a86b, 0x6_3679);           /* call 0x1015a86b */
            ii(0x100f_71f2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_71f4, 2); if(jzd(0x100f_7242, 0x4c)) goto l_0x100f_7242; /* jz 0x100f7242 */
            ii(0x100f_71f6, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100f_71fa, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100f_71fe, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_7203, 5); calld(0x1008_abbc, -0x6_c64c);          /* call 0x1008abbc */
            ii(0x100f_7208, 5); calld(0x1016_309a, 0x6_be8d);           /* call 0x1016309a */
            ii(0x100f_720d, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100f_7211, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_7214, 2); if(jgd(0x100f_7220, 0xa)) goto l_0x100f_7220; /* jg 0x100f7220 */
            ii(0x100f_7216, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100f_721a, 1); inc(eax);                               /* inc eax */
            ii(0x100f_721b, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_721e, 2); if(jged(0x100f_7222, 0x2)) goto l_0x100f_7222; /* jge 0x100f7222 */
        l_0x100f_7220:
            ii(0x100f_7220, 2); jmpd(0x100f_722b, 0x9); goto l_0x100f_722b; /* jmp 0x100f722b */
        l_0x100f_7222:
            ii(0x100f_7222, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_7226, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_7229, 2); if(jled(0x100f_722d, 0x2)) goto l_0x100f_722d; /* jle 0x100f722d */
        l_0x100f_722b:
            ii(0x100f_722b, 2); jmpd(0x100f_7237, 0xa); goto l_0x100f_7237; /* jmp 0x100f7237 */
        l_0x100f_722d:
            ii(0x100f_722d, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_7231, 1); inc(eax);                               /* inc eax */
            ii(0x100f_7232, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_7235, 2); if(jged(0x100f_7239, 0x2)) goto l_0x100f_7239; /* jge 0x100f7239 */
        l_0x100f_7237:
            ii(0x100f_7237, 2); jmpd(0x100f_7242, 0x9); goto l_0x100f_7242; /* jmp 0x100f7242 */
        l_0x100f_7239:
            ii(0x100f_7239, 4); mov(memb_a32[ss, ebp - 0x14], 0x19);    /* mov byte [ebp-0x14], 0x19 */
            ii(0x100f_723d, 5); jmpd(0x100f_7309, 0xc7); goto l_0x100f_7309; /* jmp 0x100f7309 */
        l_0x100f_7242:
            ii(0x100f_7242, 5); jmpd(0x100f_72ed, 0xa6); goto l_0x100f_72ed; /* jmp 0x100f72ed */
        l_0x100f_7247:
            ii(0x100f_7247, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100f_724b, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100f_724f, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_7254, 5); calld(0x1008_abbc, -0x6_c69d);          /* call 0x1008abbc */
            ii(0x100f_7259, 5); calld(0x1016_30fa, 0x6_be9c);           /* call 0x101630fa */
            ii(0x100f_725e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7260, 6); if(jzd(0x100f_72ed, 0x87)) goto l_0x100f_72ed; /* jz 0x100f72ed */
            ii(0x100f_7266, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_7269, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x100f_726e, 2); if(jnzd(0x100f_72a4, 0x34)) goto l_0x100f_72a4; /* jnz 0x100f72a4 */
            ii(0x100f_7270, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100f_7274, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_7277, 2); if(jzd(0x100f_7282, 0x9)) goto l_0x100f_7282; /* jz 0x100f7282 */
            ii(0x100f_7279, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100f_727d, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_7280, 2); if(jnzd(0x100f_72a2, 0x20)) goto l_0x100f_72a2; /* jnz 0x100f72a2 */
        l_0x100f_7282:
            ii(0x100f_7282, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100f_7286, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100f_728a, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_728f, 5); calld(0x1008_abbc, -0x6_c6d8);          /* call 0x1008abbc */
            ii(0x100f_7294, 5); calld(0x1016_309a, 0x6_be01);           /* call 0x1016309a */
            ii(0x100f_7299, 4); mov(memb_a32[ss, ebp - 0x14], 0x19);    /* mov byte [ebp-0x14], 0x19 */
            ii(0x100f_729d, 5); jmpd(0x100f_7309, 0x67); goto l_0x100f_7309; /* jmp 0x100f7309 */
        l_0x100f_72a2:
            ii(0x100f_72a2, 2); jmpd(0x100f_72ed, 0x49); goto l_0x100f_72ed; /* jmp 0x100f72ed */
        l_0x100f_72a4:
            ii(0x100f_72a4, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100f_72a8, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100f_72ac, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_72b1, 5); calld(0x1008_abbc, -0x6_c6fa);          /* call 0x1008abbc */
            ii(0x100f_72b6, 5); calld(0x1016_309a, 0x6_bddf);           /* call 0x1016309a */
            ii(0x100f_72bb, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100f_72bf, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_72c2, 2); if(jgd(0x100f_72ce, 0xa)) goto l_0x100f_72ce; /* jg 0x100f72ce */
            ii(0x100f_72c4, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100f_72c8, 1); inc(eax);                               /* inc eax */
            ii(0x100f_72c9, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x100f_72cc, 2); if(jged(0x100f_72d0, 0x2)) goto l_0x100f_72d0; /* jge 0x100f72d0 */
        l_0x100f_72ce:
            ii(0x100f_72ce, 2); jmpd(0x100f_72d9, 0x9); goto l_0x100f_72d9; /* jmp 0x100f72d9 */
        l_0x100f_72d0:
            ii(0x100f_72d0, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_72d4, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_72d7, 2); if(jled(0x100f_72db, 0x2)) goto l_0x100f_72db; /* jle 0x100f72db */
        l_0x100f_72d9:
            ii(0x100f_72d9, 2); jmpd(0x100f_72e5, 0xa); goto l_0x100f_72e5; /* jmp 0x100f72e5 */
        l_0x100f_72db:
            ii(0x100f_72db, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_72df, 1); inc(eax);                               /* inc eax */
            ii(0x100f_72e0, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100f_72e3, 2); if(jged(0x100f_72e7, 0x2)) goto l_0x100f_72e7; /* jge 0x100f72e7 */
        l_0x100f_72e5:
            ii(0x100f_72e5, 2); jmpd(0x100f_72ed, 0x6); goto l_0x100f_72ed; /* jmp 0x100f72ed */
        l_0x100f_72e7:
            ii(0x100f_72e7, 4); mov(memb_a32[ss, ebp - 0x14], 0x19);    /* mov byte [ebp-0x14], 0x19 */
            ii(0x100f_72eb, 2); jmpd(0x100f_7309, 0x1c); goto l_0x100f_7309; /* jmp 0x100f7309 */
        l_0x100f_72ed:
            ii(0x100f_72ed, 4); mov(memb_a32[ss, ebp - 0x14], 0x15);    /* mov byte [ebp-0x14], 0x15 */
            ii(0x100f_72f1, 2); jmpd(0x100f_7309, 0x16); goto l_0x100f_7309; /* jmp 0x100f7309 */
        l_0x100f_72f3:
            ii(0x100f_72f3, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_72f7, 2); if(jzd(0x100f_72ff, 0x6)) goto l_0x100f_72ff; /* jz 0x100f72ff */
            ii(0x100f_72f9, 4); mov(memb_a32[ss, ebp - 0x2c], 0x11);    /* mov byte [ebp-0x2c], 0x11 */
            ii(0x100f_72fd, 2); jmpd(0x100f_7303, 0x4); goto l_0x100f_7303; /* jmp 0x100f7303 */
        l_0x100f_72ff:
            ii(0x100f_72ff, 4); mov(memb_a32[ss, ebp - 0x2c], 0x15);    /* mov byte [ebp-0x2c], 0x15 */
        l_0x100f_7303:
            ii(0x100f_7303, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x100f_7306, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
        l_0x100f_7309:
            ii(0x100f_7309, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_730c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_730e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_730f, 1); popd(edi);                              /* pop edi */
            ii(0x100f_7310, 1); popd(esi);                              /* pop esi */
            ii(0x100f_7311, 1); retd(); return;                         /* ret */
        }
    }
}
