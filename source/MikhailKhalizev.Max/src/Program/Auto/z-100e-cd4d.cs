using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_cd4d-e543b89e")]
        public void Method_100e_cd4d()
        {
            ii(0x100e_cd4d, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100e_cd52, 5); calld(Definitions.sys_check_available_stack_size, 0x7_8ffb); /* call 0x10165d52 */
            ii(0x100e_cd57, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_cd58, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_cd59, 1); pushd(esi);                             /* push esi */
            ii(0x100e_cd5a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_cd5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_cd5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_cd5e, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100e_cd64, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_cd67, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_cd6a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cd6e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cd70, 2); if(jzd(0x100e_cd7b, 0x9)) goto l_0x100e_cd7b; /* jz 0x100ecd7b */
            ii(0x100e_cd72, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_cd76, 5); jmpd(0x100e_d760, 0x9e5); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cd7b:
            ii(0x100e_cd7b, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100e_cd80, 5); calld(0x1007_5fdc, -0x7_6da9);          /* call 0x10075fdc */
            ii(0x100e_cd85, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_cd88, 5); jmpd(0x100e_d734, 0x9a7); goto l_0x100e_d734; /* jmp 0x100ed734 */
        l_0x100e_cd8d:
            ii(0x100e_cd8d, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x100e_cd93, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_cd96, 5); jmpd(0x100e_d2dc, 0x541); goto l_0x100e_d2dc; /* jmp 0x100ed2dc */
        l_0x100e_cd9b:
            ii(0x100e_cd9b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_cda0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cda4, 5); calld(0x100e_bbf7, -0x11b2);            /* call 0x100ebbf7 */
            ii(0x100e_cda9, 1); cwde();                                 /* cwde */
            ii(0x100e_cdaa, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_cdad, 2); if(jld(0x100e_cdc3, 0x14)) goto l_0x100e_cdc3; /* jl 0x100ecdc3 */
            ii(0x100e_cdaf, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100e_cdb4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cdb8, 5); calld(0x100e_bbf7, -0x11c6);            /* call 0x100ebbf7 */
            ii(0x100e_cdbd, 1); cwde();                                 /* cwde */
            ii(0x100e_cdbe, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_cdc1, 2); if(jged(0x100e_cdc5, 0x2)) goto l_0x100e_cdc5; /* jge 0x100ecdc5 */
        l_0x100e_cdc3:
            ii(0x100e_cdc3, 2); jmpd(0x100e_cdd8, 0x13); goto l_0x100e_cdd8; /* jmp 0x100ecdd8 */
        l_0x100e_cdc5:
            ii(0x100e_cdc5, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x100e_cdca, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cdce, 5); calld(0x100e_c486, -0x94d);             /* call 0x100ec486 */
            ii(0x100e_cdd3, 1); cwde();                                 /* cwde */
            ii(0x100e_cdd4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cdd6, 2); if(jgd(0x100e_cdda, 0x2)) goto l_0x100e_cdda; /* jg 0x100ecdda */
        l_0x100e_cdd8:
            ii(0x100e_cdd8, 2); jmpd(0x100e_cde3, 0x9); goto l_0x100e_cde3; /* jmp 0x100ecde3 */
        l_0x100e_cdda:
            ii(0x100e_cdda, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_cdde, 5); jmpd(0x100e_d760, 0x97d); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cde3:
            ii(0x100e_cde3, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x100e_cde8, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cdec, 5); calld(0x100e_c486, -0x96b);             /* call 0x100ec486 */
            ii(0x100e_cdf1, 1); cwde();                                 /* cwde */
            ii(0x100e_cdf2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cdf4, 2); if(jzd(0x100e_ce09, 0x13)) goto l_0x100e_ce09; /* jz 0x100ece09 */
            ii(0x100e_cdf6, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100e_cdfb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cdff, 5); calld(0x100e_c486, -0x97e);             /* call 0x100ec486 */
            ii(0x100e_ce04, 1); cwde();                                 /* cwde */
            ii(0x100e_ce05, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ce07, 2); if(jnzd(0x100e_ce12, 0x9)) goto l_0x100e_ce12; /* jnz 0x100ece12 */
        l_0x100e_ce09:
            ii(0x100e_ce09, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_ce0d, 5); jmpd(0x100e_d760, 0x94e); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_ce12:
            ii(0x100e_ce12, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_ce16, 5); jmpd(0x100e_d760, 0x945); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_ce1b:
            ii(0x100e_ce1b, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x100e_ce20, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ce24, 5); calld(0x100e_c486, -0x9a3);             /* call 0x100ec486 */
            ii(0x100e_ce29, 1); cwde();                                 /* cwde */
            ii(0x100e_ce2a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_ce2d, 2); if(jld(0x100e_ce43, 0x14)) goto l_0x100e_ce43; /* jl 0x100ece43 */
            ii(0x100e_ce2f, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100e_ce34, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ce38, 5); calld(0x100e_c486, -0x9b7);             /* call 0x100ec486 */
            ii(0x100e_ce3d, 1); cwde();                                 /* cwde */
            ii(0x100e_ce3e, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_ce41, 2); if(jged(0x100e_ce45, 0x2)) goto l_0x100e_ce45; /* jge 0x100ece45 */
        l_0x100e_ce43:
            ii(0x100e_ce43, 2); jmpd(0x100e_ce4e, 0x9); goto l_0x100e_ce4e; /* jmp 0x100ece4e */
        l_0x100e_ce45:
            ii(0x100e_ce45, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_ce49, 5); jmpd(0x100e_d760, 0x912); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_ce4e:
            ii(0x100e_ce4e, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100e_ce53, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ce57, 5); calld(0x100e_c486, -0x9d6);             /* call 0x100ec486 */
            ii(0x100e_ce5c, 1); cwde();                                 /* cwde */
            ii(0x100e_ce5d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ce5f, 2); if(jnzd(0x100e_ce74, 0x13)) goto l_0x100e_ce74; /* jnz 0x100ece74 */
            ii(0x100e_ce61, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100e_ce66, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ce6a, 5); calld(0x100e_c486, -0x9e9);             /* call 0x100ec486 */
            ii(0x100e_ce6f, 1); cwde();                                 /* cwde */
            ii(0x100e_ce70, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ce72, 2); if(jzd(0x100e_ce9c, 0x28)) goto l_0x100e_ce9c; /* jz 0x100ece9c */
        l_0x100e_ce74:
            ii(0x100e_ce74, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100e_ce79, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ce7d, 5); calld(0x100e_c486, -0x9fc);             /* call 0x100ec486 */
            ii(0x100e_ce82, 1); cwde();                                 /* cwde */
            ii(0x100e_ce83, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ce85, 2); if(jnzd(0x100e_ce9a, 0x13)) goto l_0x100e_ce9a; /* jnz 0x100ece9a */
            ii(0x100e_ce87, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x100e_ce8c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ce90, 5); calld(0x100e_c486, -0xa0f);             /* call 0x100ec486 */
            ii(0x100e_ce95, 1); cwde();                                 /* cwde */
            ii(0x100e_ce96, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_ce98, 2); if(jzd(0x100e_ce9c, 0x2)) goto l_0x100e_ce9c; /* jz 0x100ece9c */
        l_0x100e_ce9a:
            ii(0x100e_ce9a, 2); jmpd(0x100e_cea5, 0x9); goto l_0x100e_cea5; /* jmp 0x100ecea5 */
        l_0x100e_ce9c:
            ii(0x100e_ce9c, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_cea0, 5); jmpd(0x100e_d760, 0x8bb); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cea5:
            ii(0x100e_cea5, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_cea9, 5); jmpd(0x100e_d760, 0x8b2); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_ceae:
            ii(0x100e_ceae, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x100e_ceb3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ceb7, 5); calld(0x100e_c486, -0xa36);             /* call 0x100ec486 */
            ii(0x100e_cebc, 1); cwde();                                 /* cwde */
            ii(0x100e_cebd, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_cec0, 2); if(jld(0x100e_ced6, 0x14)) goto l_0x100e_ced6; /* jl 0x100eced6 */
            ii(0x100e_cec2, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100e_cec7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cecb, 5); calld(0x100e_c486, -0xa4a);             /* call 0x100ec486 */
            ii(0x100e_ced0, 1); cwde();                                 /* cwde */
            ii(0x100e_ced1, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100e_ced4, 2); if(jged(0x100e_ced8, 0x2)) goto l_0x100e_ced8; /* jge 0x100eced8 */
        l_0x100e_ced6:
            ii(0x100e_ced6, 2); jmpd(0x100e_cee1, 0x9); goto l_0x100e_cee1; /* jmp 0x100ecee1 */
        l_0x100e_ced8:
            ii(0x100e_ced8, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_cedc, 5); jmpd(0x100e_d760, 0x87f); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cee1:
            ii(0x100e_cee1, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x100e_cee6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ceea, 5); calld(0x100e_c486, -0xa69);             /* call 0x100ec486 */
            ii(0x100e_ceef, 1); cwde();                                 /* cwde */
            ii(0x100e_cef0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cef2, 2); if(jnzd(0x100e_cf08, 0x14)) goto l_0x100e_cf08; /* jnz 0x100ecf08 */
            ii(0x100e_cef4, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100e_cef9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cefd, 5); calld(0x100e_c486, -0xa7c);             /* call 0x100ec486 */
            ii(0x100e_cf02, 1); cwde();                                 /* cwde */
            ii(0x100e_cf03, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100e_cf06, 2); if(jld(0x100e_cf1b, 0x13)) goto l_0x100e_cf1b; /* jl 0x100ecf1b */
        l_0x100e_cf08:
            ii(0x100e_cf08, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x100e_cf0d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cf11, 5); calld(0x100e_c486, -0xa90);             /* call 0x100ec486 */
            ii(0x100e_cf16, 1); cwde();                                 /* cwde */
            ii(0x100e_cf17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cf19, 2); if(jnzd(0x100e_cf1d, 0x2)) goto l_0x100e_cf1d; /* jnz 0x100ecf1d */
        l_0x100e_cf1b:
            ii(0x100e_cf1b, 2); jmpd(0x100e_cf45, 0x28); goto l_0x100e_cf45; /* jmp 0x100ecf45 */
        l_0x100e_cf1d:
            ii(0x100e_cf1d, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100e_cf22, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cf26, 5); calld(0x100e_c486, -0xaa5);             /* call 0x100ec486 */
            ii(0x100e_cf2b, 1); cwde();                                 /* cwde */
            ii(0x100e_cf2c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cf2e, 2); if(jnzd(0x100e_cf43, 0x13)) goto l_0x100e_cf43; /* jnz 0x100ecf43 */
            ii(0x100e_cf30, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x100e_cf35, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cf39, 5); calld(0x100e_c486, -0xab8);             /* call 0x100ec486 */
            ii(0x100e_cf3e, 1); cwde();                                 /* cwde */
            ii(0x100e_cf3f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cf41, 2); if(jzd(0x100e_cf45, 0x2)) goto l_0x100e_cf45; /* jz 0x100ecf45 */
        l_0x100e_cf43:
            ii(0x100e_cf43, 2); jmpd(0x100e_cf4e, 0x9); goto l_0x100e_cf4e; /* jmp 0x100ecf4e */
        l_0x100e_cf45:
            ii(0x100e_cf45, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_cf49, 5); jmpd(0x100e_d760, 0x812); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cf4e:
            ii(0x100e_cf4e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_cf52, 5); jmpd(0x100e_d760, 0x809); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cf57:
            ii(0x100e_cf57, 3); lea(ecx, ebp - 0x18);                   /* lea ecx, [ebp-0x18] */
            ii(0x100e_cf5a, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x100e_cf5d, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100e_cf60, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cf64, 5); calld(0x100e_c53d, -0xa2c);             /* call 0x100ec53d */
            ii(0x100e_cf69, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100e_cf6d, 3); cmp(eax, 0x16);                         /* cmp eax, 0x16 */
            ii(0x100e_cf70, 2); if(jld(0x100e_cf7b, 0x9)) goto l_0x100e_cf7b; /* jl 0x100ecf7b */
            ii(0x100e_cf72, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_cf76, 5); jmpd(0x100e_d760, 0x7e5); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cf7b:
            ii(0x100e_cf7b, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100e_cf80, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cf84, 5); calld(0x100e_c486, -0xb03);             /* call 0x100ec486 */
            ii(0x100e_cf89, 1); cwde();                                 /* cwde */
            ii(0x100e_cf8a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cf8c, 2); if(jzd(0x100e_cfa1, 0x13)) goto l_0x100e_cfa1; /* jz 0x100ecfa1 */
            ii(0x100e_cf8e, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x100e_cf93, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cf97, 5); calld(0x100e_c486, -0xb16);             /* call 0x100ec486 */
            ii(0x100e_cf9c, 1); cwde();                                 /* cwde */
            ii(0x100e_cf9d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cf9f, 2); if(jnzd(0x100e_cfaa, 0x9)) goto l_0x100e_cfaa; /* jnz 0x100ecfaa */
        l_0x100e_cfa1:
            ii(0x100e_cfa1, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_cfa5, 5); jmpd(0x100e_d760, 0x7b6); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cfaa:
            ii(0x100e_cfaa, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_cfae, 5); jmpd(0x100e_d760, 0x7ad); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cfb3:
            ii(0x100e_cfb3, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x100e_cfb8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_cfbd, 5); calld(0x100e_c486, -0xb3c);             /* call 0x100ec486 */
            ii(0x100e_cfc2, 1); cwde();                                 /* cwde */
            ii(0x100e_cfc3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cfc5, 2); if(jnzd(0x100e_cfd0, 0x9)) goto l_0x100e_cfd0; /* jnz 0x100ecfd0 */
            ii(0x100e_cfc7, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_cfcb, 5); jmpd(0x100e_d760, 0x790); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cfd0:
            ii(0x100e_cfd0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_cfd4, 5); jmpd(0x100e_d760, 0x787); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cfd9:
            ii(0x100e_cfd9, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100e_cfde, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cfe2, 5); calld(0x100e_c9f2, -0x5f5);             /* call 0x100ec9f2 */
            ii(0x100e_cfe7, 1); cwde();                                 /* cwde */
            ii(0x100e_cfe8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cfea, 2); if(jled(0x100e_cff5, 0x9)) goto l_0x100e_cff5; /* jle 0x100ecff5 */
            ii(0x100e_cfec, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_cff0, 5); jmpd(0x100e_d760, 0x76b); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cff5:
            ii(0x100e_cff5, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_cff9, 5); jmpd(0x100e_d760, 0x762); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_cffe:
            ii(0x100e_cffe, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x100e_d003, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d007, 5); calld(0x100e_c6eb, -0x921);             /* call 0x100ec6eb */
            ii(0x100e_d00c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d00f, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x100e_d014, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d018, 5); calld(0x100e_c6eb, -0x932);             /* call 0x100ec6eb */
            ii(0x100e_d01d, 1); cwde();                                 /* cwde */
            ii(0x100e_d01e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_d020, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_d023, 2); if(jld(0x100e_d04b, 0x26)) goto l_0x100e_d04b; /* jl 0x100ed04b */
            ii(0x100e_d025, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100e_d02a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d02e, 5); calld(0x100e_c7b5, -0x87e);             /* call 0x100ec7b5 */
            ii(0x100e_d033, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d036, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100e_d03b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d03f, 5); calld(0x100e_c8d7, -0x76d);             /* call 0x100ec8d7 */
            ii(0x100e_d044, 1); cwde();                                 /* cwde */
            ii(0x100e_d045, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100e_d047, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x100e_d049, 2); if(jgd(0x100e_d04d, 0x2)) goto l_0x100e_d04d; /* jg 0x100ed04d */
        l_0x100e_d04b:
            ii(0x100e_d04b, 2); jmpd(0x100e_d056, 0x9); goto l_0x100e_d056; /* jmp 0x100ed056 */
        l_0x100e_d04d:
            ii(0x100e_d04d, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d051, 5); jmpd(0x100e_d760, 0x70a); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d056:
            ii(0x100e_d056, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x100e_d05b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d05f, 5); calld(0x100e_c486, -0xbde);             /* call 0x100ec486 */
            ii(0x100e_d064, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d067, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x100e_d06c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d070, 5); calld(0x100e_c486, -0xbef);             /* call 0x100ec486 */
            ii(0x100e_d075, 1); cwde();                                 /* cwde */
            ii(0x100e_d076, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_d078, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_d07b, 2); if(jld(0x100e_d090, 0x13)) goto l_0x100e_d090; /* jl 0x100ed090 */
            ii(0x100e_d07d, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x100e_d082, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d086, 5); calld(0x100e_c486, -0xc05);             /* call 0x100ec486 */
            ii(0x100e_d08b, 1); cwde();                                 /* cwde */
            ii(0x100e_d08c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d08e, 2); if(jnzd(0x100e_d099, 0x9)) goto l_0x100e_d099; /* jnz 0x100ed099 */
        l_0x100e_d090:
            ii(0x100e_d090, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d094, 5); jmpd(0x100e_d760, 0x6c7); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d099:
            ii(0x100e_d099, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d09d, 5); jmpd(0x100e_d760, 0x6be); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d0a2:
            ii(0x100e_d0a2, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100e_d0a7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d0ab, 5); calld(0x100e_bbf7, -0x14b9);            /* call 0x100ebbf7 */
            ii(0x100e_d0b0, 1); cwde();                                 /* cwde */
            ii(0x100e_d0b1, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_d0b4, 2); if(jld(0x100e_d0bf, 0x9)) goto l_0x100e_d0bf; /* jl 0x100ed0bf */
            ii(0x100e_d0b6, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d0ba, 5); jmpd(0x100e_d760, 0x6a1); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d0bf:
            ii(0x100e_d0bf, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d0c3, 5); jmpd(0x100e_d760, 0x698); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d0c8:
            ii(0x100e_d0c8, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d0cc, 5); calld(0x100e_c62a, -0xaa7);             /* call 0x100ec62a */
            ii(0x100e_d0d1, 2); test(al, al);                           /* test al, al */
            ii(0x100e_d0d3, 2); if(jzd(0x100e_d0de, 0x9)) goto l_0x100e_d0de; /* jz 0x100ed0de */
            ii(0x100e_d0d5, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d0d9, 5); jmpd(0x100e_d760, 0x682); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d0de:
            ii(0x100e_d0de, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d0e2, 5); jmpd(0x100e_d760, 0x679); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d0e7:
            ii(0x100e_d0e7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d0eb, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d0f1, 7); cmp(memd_a32[ds, eax + 0x101c_a550], 0); /* cmp dword [eax+0x101ca550], 0x0 */
            ii(0x100e_d0f8, 2); if(jled(0x100e_d103, 0x9)) goto l_0x100e_d103; /* jle 0x100ed103 */
            ii(0x100e_d0fa, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d0fe, 5); jmpd(0x100e_d760, 0x65d); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d103:
            ii(0x100e_d103, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d107, 5); jmpd(0x100e_d760, 0x654); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d10c:
            ii(0x100e_d10c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d110, 5); calld(0x100e_caf8, -0x61d);             /* call 0x100ecaf8 */
            ii(0x100e_d115, 2); test(al, al);                           /* test al, al */
            ii(0x100e_d117, 2); if(jzd(0x100e_d122, 0x9)) goto l_0x100e_d122; /* jz 0x100ed122 */
            ii(0x100e_d119, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d11d, 5); jmpd(0x100e_d760, 0x63e); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d122:
            ii(0x100e_d122, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100e_d127, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d12b, 5); calld(0x100e_c486, -0xcaa);             /* call 0x100ec486 */
            ii(0x100e_d130, 1); cwde();                                 /* cwde */
            ii(0x100e_d131, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d133, 2); if(jzd(0x100e_d148, 0x13)) goto l_0x100e_d148; /* jz 0x100ed148 */
            ii(0x100e_d135, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x100e_d13a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d13e, 5); calld(0x100e_c486, -0xcbd);             /* call 0x100ec486 */
            ii(0x100e_d143, 1); cwde();                                 /* cwde */
            ii(0x100e_d144, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d146, 2); if(jnzd(0x100e_d14a, 0x2)) goto l_0x100e_d14a; /* jnz 0x100ed14a */
        l_0x100e_d148:
            ii(0x100e_d148, 2); jmpd(0x100e_d15d, 0x13); goto l_0x100e_d15d; /* jmp 0x100ed15d */
        l_0x100e_d14a:
            ii(0x100e_d14a, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x100e_d14f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d153, 5); calld(0x100e_c486, -0xcd2);             /* call 0x100ec486 */
            ii(0x100e_d158, 1); cwde();                                 /* cwde */
            ii(0x100e_d159, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d15b, 2); if(jnzd(0x100e_d166, 0x9)) goto l_0x100e_d166; /* jnz 0x100ed166 */
        l_0x100e_d15d:
            ii(0x100e_d15d, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d161, 5); jmpd(0x100e_d760, 0x5fa); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d166:
            ii(0x100e_d166, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d16a, 5); jmpd(0x100e_d760, 0x5f1); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d16f:
            ii(0x100e_d16f, 5); mov(edx, 0x29);                         /* mov edx, 0x29 */
            ii(0x100e_d174, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d178, 5); calld(0x100e_c486, -0xcf7);             /* call 0x100ec486 */
            ii(0x100e_d17d, 1); cwde();                                 /* cwde */
            ii(0x100e_d17e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d180, 2); if(jled(0x100e_d18e, 0xc)) goto l_0x100e_d18e; /* jle 0x100ed18e */
            ii(0x100e_d182, 5); mov(eax, memd_a32[ds, 0x101c_a880]);    /* mov eax, [0x101ca880] */
            ii(0x100e_d187, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d18a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d18c, 2); if(jgd(0x100e_d190, 0x2)) goto l_0x100e_d190; /* jg 0x100ed190 */
        l_0x100e_d18e:
            ii(0x100e_d18e, 2); jmpd(0x100e_d199, 0x9); goto l_0x100e_d199; /* jmp 0x100ed199 */
        l_0x100e_d190:
            ii(0x100e_d190, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d194, 5); jmpd(0x100e_d760, 0x5c7); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d199:
            ii(0x100e_d199, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d19d, 5); jmpd(0x100e_d760, 0x5be); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d1a2:
            ii(0x100e_d1a2, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100e_d1a7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d1ab, 5); calld(0x100e_c486, -0xd2a);             /* call 0x100ec486 */
            ii(0x100e_d1b0, 1); cwde();                                 /* cwde */
            ii(0x100e_d1b1, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100e_d1b4, 2); if(jld(0x100e_d1c9, 0x13)) goto l_0x100e_d1c9; /* jl 0x100ed1c9 */
            ii(0x100e_d1b6, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100e_d1bb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d1bf, 5); calld(0x100e_cbb3, -0x611);             /* call 0x100ecbb3 */
            ii(0x100e_d1c4, 1); cwde();                                 /* cwde */
            ii(0x100e_d1c5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d1c7, 2); if(jzd(0x100e_d1cb, 0x2)) goto l_0x100e_d1cb; /* jz 0x100ed1cb */
        l_0x100e_d1c9:
            ii(0x100e_d1c9, 2); jmpd(0x100e_d1d4, 0x9); goto l_0x100e_d1d4; /* jmp 0x100ed1d4 */
        l_0x100e_d1cb:
            ii(0x100e_d1cb, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d1cf, 5); jmpd(0x100e_d760, 0x58c); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d1d4:
            ii(0x100e_d1d4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d1d8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d1de, 6); mov(eax, memd_a32[ds, eax + 0x101c_a64d]); /* mov eax, [eax+0x101ca64d] */
            ii(0x100e_d1e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d1e7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d1e9, 2); if(jled(0x100e_d1f4, 0x9)) goto l_0x100e_d1f4; /* jle 0x100ed1f4 */
            ii(0x100e_d1eb, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d1ef, 5); jmpd(0x100e_d760, 0x56c); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d1f4:
            ii(0x100e_d1f4, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d1f8, 5); jmpd(0x100e_d760, 0x563); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d1fd:
            ii(0x100e_d1fd, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100e_d202, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d206, 5); calld(0x100e_c486, -0xd85);             /* call 0x100ec486 */
            ii(0x100e_d20b, 1); cwde();                                 /* cwde */
            ii(0x100e_d20c, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100e_d20f, 2); if(jld(0x100e_d228, 0x17)) goto l_0x100e_d228; /* jl 0x100ed228 */
            ii(0x100e_d211, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100e_d216, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d21a, 5); calld(0x100e_cc80, -0x59f);             /* call 0x100ecc80 */
            ii(0x100e_d21f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_d224, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d226, 2); if(jzd(0x100e_d22a, 0x2)) goto l_0x100e_d22a; /* jz 0x100ed22a */
        l_0x100e_d228:
            ii(0x100e_d228, 2); jmpd(0x100e_d233, 0x9); goto l_0x100e_d233; /* jmp 0x100ed233 */
        l_0x100e_d22a:
            ii(0x100e_d22a, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d22e, 5); jmpd(0x100e_d760, 0x52d); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d233:
            ii(0x100e_d233, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d237, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d23d, 6); mov(eax, memd_a32[ds, eax + 0x101c_a64d]); /* mov eax, [eax+0x101ca64d] */
            ii(0x100e_d243, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d246, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d248, 2); if(jled(0x100e_d253, 0x9)) goto l_0x100e_d253; /* jle 0x100ed253 */
            ii(0x100e_d24a, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d24e, 5); jmpd(0x100e_d760, 0x50d); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d253:
            ii(0x100e_d253, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d257, 5); jmpd(0x100e_d760, 0x504); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d25c:
            ii(0x100e_d25c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d260, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d266, 7); cmp(memd_a32[ds, eax + 0x101c_a514], 0); /* cmp dword [eax+0x101ca514], 0x0 */
            ii(0x100e_d26d, 2); if(jbed(0x100e_d278, 0x9)) goto l_0x100e_d278; /* jbe 0x100ed278 */
            ii(0x100e_d26f, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d273, 5); jmpd(0x100e_d760, 0x4e8); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d278:
            ii(0x100e_d278, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x100e_d27d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d281, 5); calld(0x100e_c486, -0xe00);             /* call 0x100ec486 */
            ii(0x100e_d286, 1); cwde();                                 /* cwde */
            ii(0x100e_d287, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d289, 2); if(jnzd(0x100e_d294, 0x9)) goto l_0x100e_d294; /* jnz 0x100ed294 */
            ii(0x100e_d28b, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d28f, 5); jmpd(0x100e_d760, 0x4cc); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d294:
            ii(0x100e_d294, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d298, 5); jmpd(0x100e_d760, 0x4c3); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d29d:
            ii(0x100e_d29d, 2); jmpd(0x100e_d2fa, 0x5b); goto l_0x100e_d2fa; /* jmp 0x100ed2fa */
        //  ii(0x100e_d29f, 1); nop();                                  /* nop */
        //  ii(0x100e_d2a0, 60); /* Служебная область с абсолютными адресами переходов. (0x100e_cd9b, 0x100e_ce1b, 0x100e_ceae, 0x100e_cf57, 0x100e_cfb3, 0x100e_cfd9, 0x100e_cffe, 0x100e_d0a2, 0x100e_d0c8, 0x100e_d0e7, 0x100e_d10c, 0x100e_d16f, 0x100e_d1a2, 0x100e_d1fd, 0x100e_d25c). */
        l_0x100e_d2dc:
            ii(0x100e_d2dc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_d2df, 1); dec(eax);                               /* dec eax */
            ii(0x100e_d2e0, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_d2e3, 5); cmp(memw_a32[ss, ebp - 0x24], 0xe);     /* cmp word [ebp-0x24], 0xe */
            ii(0x100e_d2e8, 2); if(jad(0x100e_d29d, -0x4d)) goto l_0x100e_d29d; /* ja 0x100ed29d */
            ii(0x100e_d2ea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_d2ec, 4); mov(ax, memw_a32[ss, ebp - 0x24]);      /* mov ax, [ebp-0x24] */
            ii(0x100e_d2f0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_d2f3, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x100e_d2a0]))
            {
                case 0x100e_cd9b:
                    goto l_0x100e_cd9b;
                case 0x100e_ce1b:
                    goto l_0x100e_ce1b;
                case 0x100e_ceae:
                    goto l_0x100e_ceae;
                case 0x100e_cf57:
                    goto l_0x100e_cf57;
                case 0x100e_cfb3:
                    goto l_0x100e_cfb3;
                case 0x100e_cfd9:
                    goto l_0x100e_cfd9;
                case 0x100e_cffe:
                    goto l_0x100e_cffe;
                case 0x100e_d0a2:
                    goto l_0x100e_d0a2;
                case 0x100e_d0c8:
                    goto l_0x100e_d0c8;
                case 0x100e_d0e7:
                    goto l_0x100e_d0e7;
                case 0x100e_d10c:
                    goto l_0x100e_d10c;
                case 0x100e_d16f:
                    goto l_0x100e_d16f;
                case 0x100e_d1a2:
                    goto l_0x100e_d1a2;
                case 0x100e_d1fd:
                    goto l_0x100e_d1fd;
                case 0x100e_d25c:
                    goto l_0x100e_d25c;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100ed2a0] */
        l_0x100e_d2fa:
            ii(0x100e_d2fa, 5); jmpd(0x100e_d75c, 0x45d); goto l_0x100e_d75c; /* jmp 0x100ed75c */
        l_0x100e_d2ff:
            ii(0x100e_d2ff, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x100e_d305, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_d308, 5); jmpd(0x100e_d3f0, 0xe3); goto l_0x100e_d3f0; /* jmp 0x100ed3f0 */
        l_0x100e_d30d:
            ii(0x100e_d30d, 5); mov(eax, memd_a32[ds, 0x101c_a550]);    /* mov eax, [0x101ca550] */
            ii(0x100e_d312, 6); cmp(eax, memd_a32[ds, 0x101c_a797]);    /* cmp eax, [0x101ca797] */
            ii(0x100e_d318, 2); if(jled(0x100e_d323, 0x9)) goto l_0x100e_d323; /* jle 0x100ed323 */
            ii(0x100e_d31a, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d31e, 5); jmpd(0x100e_d760, 0x43d); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d323:
            ii(0x100e_d323, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d327, 5); jmpd(0x100e_d760, 0x434); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d32c:
            ii(0x100e_d32c, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x100e_d331, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d336, 5); calld(0x100e_c486, -0xeb5);             /* call 0x100ec486 */
            ii(0x100e_d33b, 1); cwde();                                 /* cwde */
            ii(0x100e_d33c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d33e, 2); if(jnzd(0x100e_d349, 0x9)) goto l_0x100e_d349; /* jnz 0x100ed349 */
            ii(0x100e_d340, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d344, 5); jmpd(0x100e_d760, 0x417); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d349:
            ii(0x100e_d349, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d34d, 5); jmpd(0x100e_d760, 0x40e); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d352:
            ii(0x100e_d352, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100e_d357, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d35a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_d35e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_d360, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_d362, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d367, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d36b, 5); calld(0x100e_c486, -0xeea);             /* call 0x100ec486 */
            ii(0x100e_d370, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_d373, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x100e_d376, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d37a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d380, 6); mov(ecx, memd_a32[ds, eax + 0x101c_a550]); /* mov ecx, [eax+0x101ca550] */
            ii(0x100e_d386, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x100e_d388, 6); mov(edx, memd_a32[ds, 0x101c_3966]);    /* mov edx, [0x101c3966] */
            ii(0x100e_d38e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_d391, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_d395, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_d397, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_d399, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d39e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d3a3, 5); calld(0x100e_c486, -0xf22);             /* call 0x100ec486 */
            ii(0x100e_d3a8, 1); cwde();                                 /* cwde */
            ii(0x100e_d3a9, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100e_d3ac, 6); add(eax, memd_a32[ds, 0x101c_a797]);    /* add eax, [0x101ca797] */
            ii(0x100e_d3b2, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x100e_d3b4, 2); if(jged(0x100e_d3bf, 0x9)) goto l_0x100e_d3bf; /* jge 0x100ed3bf */
            ii(0x100e_d3b6, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d3ba, 5); jmpd(0x100e_d760, 0x3a1); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d3bf:
            ii(0x100e_d3bf, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_d3c3, 5); jmpd(0x100e_d760, 0x398); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d3c8:
            ii(0x100e_d3c8, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d3cd, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d3d2, 5); calld(0x100e_c486, -0xf51);             /* call 0x100ec486 */
            ii(0x100e_d3d7, 1); cwde();                                 /* cwde */
            ii(0x100e_d3d8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d3da, 2); if(jnzd(0x100e_d3e5, 0x9)) goto l_0x100e_d3e5; /* jnz 0x100ed3e5 */
            ii(0x100e_d3dc, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d3e0, 5); jmpd(0x100e_d760, 0x37b); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d3e5:
            ii(0x100e_d3e5, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d3e9, 5); jmpd(0x100e_d760, 0x372); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d3ee:
            ii(0x100e_d3ee, 2); jmpd(0x100e_d432, 0x42); goto l_0x100e_d432; /* jmp 0x100ed432 */
        l_0x100e_d3f0:
            ii(0x100e_d3f0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_d3f3, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_d3f6, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x12);    /* cmp word [ebp-0x2c], 0x12 */
            ii(0x100e_d3fb, 2); if(jbd(0x100e_d425, 0x28)) goto l_0x100e_d425; /* jb 0x100ed425 */
            ii(0x100e_d3fd, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x12);    /* cmp word [ebp-0x2c], 0x12 */
            ii(0x100e_d402, 6); if(jbed(0x100e_d32c, -0xdc)) goto l_0x100e_d32c; /* jbe 0x100ed32c */
            ii(0x100e_d408, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x14);    /* cmp word [ebp-0x2c], 0x14 */
            ii(0x100e_d40d, 2); if(jbd(0x100e_d423, 0x14)) goto l_0x100e_d423; /* jb 0x100ed423 */
            ii(0x100e_d40f, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x14);    /* cmp word [ebp-0x2c], 0x14 */
            ii(0x100e_d414, 6); if(jbed(0x100e_d352, -0xc8)) goto l_0x100e_d352; /* jbe 0x100ed352 */
            ii(0x100e_d41a, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x18);    /* cmp word [ebp-0x2c], 0x18 */
            ii(0x100e_d41f, 2); if(jzd(0x100e_d3c8, -0x59)) goto l_0x100e_d3c8; /* jz 0x100ed3c8 */
            ii(0x100e_d421, 2); jmpd(0x100e_d3ee, -0x35); goto l_0x100e_d3ee; /* jmp 0x100ed3ee */
        l_0x100e_d423:
            ii(0x100e_d423, 2); jmpd(0x100e_d3ee, -0x37); goto l_0x100e_d3ee; /* jmp 0x100ed3ee */
        l_0x100e_d425:
            ii(0x100e_d425, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x9);     /* cmp word [ebp-0x2c], 0x9 */
            ii(0x100e_d42a, 6); if(jzd(0x100e_d30d, -0x123)) goto l_0x100e_d30d; /* jz 0x100ed30d */
            ii(0x100e_d430, 2); jmpd(0x100e_d3ee, -0x44); goto l_0x100e_d3ee; /* jmp 0x100ed3ee */
        l_0x100e_d432:
            ii(0x100e_d432, 5); jmpd(0x100e_d75c, 0x325); goto l_0x100e_d75c; /* jmp 0x100ed75c */
        l_0x100e_d437:
            ii(0x100e_d437, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x100e_d43d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_d440, 5); jmpd(0x100e_d710, 0x2cb); goto l_0x100e_d710; /* jmp 0x100ed710 */
        l_0x100e_d445:
            ii(0x100e_d445, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x100e_d44a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d44f, 5); calld(0x100e_c486, -0xfce);             /* call 0x100ec486 */
            ii(0x100e_d454, 1); cwde();                                 /* cwde */
            ii(0x100e_d455, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d457, 2); if(jnzd(0x100e_d462, 0x9)) goto l_0x100e_d462; /* jnz 0x100ed462 */
            ii(0x100e_d459, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d45d, 5); jmpd(0x100e_d760, 0x2fe); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d462:
            ii(0x100e_d462, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d467, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d46c, 5); calld(0x100e_c486, -0xfeb);             /* call 0x100ec486 */
            ii(0x100e_d471, 1); cwde();                                 /* cwde */
            ii(0x100e_d472, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d474, 2); if(jnzd(0x100e_d47f, 0x9)) goto l_0x100e_d47f; /* jnz 0x100ed47f */
            ii(0x100e_d476, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d47a, 5); jmpd(0x100e_d760, 0x2e1); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d47f:
            ii(0x100e_d47f, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d483, 5); jmpd(0x100e_d760, 0x2d8); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d488:
            ii(0x100e_d488, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d48c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d492, 6); mov(eax, memd_a32[ds, eax + 0x101c_a621]); /* mov eax, [eax+0x101ca621] */
            ii(0x100e_d498, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d49b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d49d, 2); if(jled(0x100e_d4a8, 0x9)) goto l_0x100e_d4a8; /* jle 0x100ed4a8 */
            ii(0x100e_d49f, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d4a3, 5); jmpd(0x100e_d760, 0x2b8); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d4a8:
            ii(0x100e_d4a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_d4ab, 7); cmp(ax, memw_a32[ds, 0x101c_3968]);     /* cmp ax, [0x101c3968] */
            ii(0x100e_d4b2, 2); if(jld(0x100e_d4bd, 0x9)) goto l_0x100e_d4bd; /* jl 0x100ed4bd */
            ii(0x100e_d4b4, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d4b8, 5); jmpd(0x100e_d760, 0x2a3); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d4bd:
            ii(0x100e_d4bd, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d4c1, 5); jmpd(0x100e_d760, 0x29a); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d4c6:
            ii(0x100e_d4c6, 5); mov(edx, 0x3b);                         /* mov edx, 0x3b */
            ii(0x100e_d4cb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d4cf, 5); calld(0x100e_c486, -0x104e);            /* call 0x100ec486 */
            ii(0x100e_d4d4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d4d7, 5); mov(edx, 0x3b);                         /* mov edx, 0x3b */
            ii(0x100e_d4dc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d4e1, 5); calld(0x100e_c486, -0x1060);            /* call 0x100ec486 */
            ii(0x100e_d4e6, 1); cwde();                                 /* cwde */
            ii(0x100e_d4e7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_d4e9, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_d4ec, 2); if(jged(0x100e_d4f7, 0x9)) goto l_0x100e_d4f7; /* jge 0x100ed4f7 */
            ii(0x100e_d4ee, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d4f2, 5); jmpd(0x100e_d760, 0x269); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d4f7:
            ii(0x100e_d4f7, 5); mov(edx, 0x3b);                         /* mov edx, 0x3b */
            ii(0x100e_d4fc, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d500, 5); calld(0x100e_c486, -0x107f);            /* call 0x100ec486 */
            ii(0x100e_d505, 1); cwde();                                 /* cwde */
            ii(0x100e_d506, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_d509, 2); if(jld(0x100e_d514, 0x9)) goto l_0x100e_d514; /* jl 0x100ed514 */
            ii(0x100e_d50b, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d50f, 5); jmpd(0x100e_d760, 0x24c); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d514:
            ii(0x100e_d514, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100e_d519, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d51d, 5); calld(0x100e_c486, -0x109c);            /* call 0x100ec486 */
            ii(0x100e_d522, 1); cwde();                                 /* cwde */
            ii(0x100e_d523, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d525, 2); if(jnzd(0x100e_d530, 0x9)) goto l_0x100e_d530; /* jnz 0x100ed530 */
            ii(0x100e_d527, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d52b, 5); jmpd(0x100e_d760, 0x230); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d530:
            ii(0x100e_d530, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d534, 5); jmpd(0x100e_d760, 0x227); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d539:
            ii(0x100e_d539, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d53d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d543, 6); mov(eax, memd_a32[ds, eax + 0x101c_a621]); /* mov eax, [eax+0x101ca621] */
            ii(0x100e_d549, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d54c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d54e, 2); if(jled(0x100e_d559, 0x9)) goto l_0x100e_d559; /* jle 0x100ed559 */
            ii(0x100e_d550, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d554, 5); jmpd(0x100e_d760, 0x207); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d559:
            ii(0x100e_d559, 5); mov(edx, 0x53);                         /* mov edx, 0x53 */
            ii(0x100e_d55e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d562, 5); calld(0x100e_c486, -0x10e1);            /* call 0x100ec486 */
            ii(0x100e_d567, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d56a, 5); mov(edx, 0x51);                         /* mov edx, 0x51 */
            ii(0x100e_d56f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d573, 5); calld(0x100e_c486, -0x10f2);            /* call 0x100ec486 */
            ii(0x100e_d578, 1); cwde();                                 /* cwde */
            ii(0x100e_d579, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_d57b, 5); mov(edx, 0x52);                         /* mov edx, 0x52 */
            ii(0x100e_d580, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d584, 5); calld(0x100e_c486, -0x1103);            /* call 0x100ec486 */
            ii(0x100e_d589, 1); cwde();                                 /* cwde */
            ii(0x100e_d58a, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_d58c, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x100e_d591, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d595, 5); calld(0x100e_c486, -0x1114);            /* call 0x100ec486 */
            ii(0x100e_d59a, 1); cwde();                                 /* cwde */
            ii(0x100e_d59b, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_d59d, 5); mov(edx, 0x53);                         /* mov edx, 0x53 */
            ii(0x100e_d5a2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d5a7, 5); calld(0x100e_c486, -0x1126);            /* call 0x100ec486 */
            ii(0x100e_d5ac, 1); cwde();                                 /* cwde */
            ii(0x100e_d5ad, 3); lea(ecx, ebx + eax);                    /* lea ecx, [ebx+eax] */
            ii(0x100e_d5b0, 5); mov(edx, 0x51);                         /* mov edx, 0x51 */
            ii(0x100e_d5b5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d5ba, 5); calld(0x100e_c486, -0x1139);            /* call 0x100ec486 */
            ii(0x100e_d5bf, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d5c2, 2); add(ebx, ecx);                          /* add ebx, ecx */
            ii(0x100e_d5c4, 5); mov(edx, 0x52);                         /* mov edx, 0x52 */
            ii(0x100e_d5c9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d5ce, 5); calld(0x100e_c486, -0x114d);            /* call 0x100ec486 */
            ii(0x100e_d5d3, 1); cwde();                                 /* cwde */
            ii(0x100e_d5d4, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_d5d6, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x100e_d5db, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d5e0, 5); calld(0x100e_c486, -0x115f);            /* call 0x100ec486 */
            ii(0x100e_d5e5, 1); cwde();                                 /* cwde */
            ii(0x100e_d5e6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_d5e8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_d5eb, 2); if(jged(0x100e_d5f6, 0x9)) goto l_0x100e_d5f6; /* jge 0x100ed5f6 */
            ii(0x100e_d5ed, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d5f1, 5); jmpd(0x100e_d760, 0x16a); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d5f6:
            ii(0x100e_d5f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_d5f9, 7); cmp(ax, memw_a32[ds, 0x101c_3968]);     /* cmp ax, [0x101c3968] */
            ii(0x100e_d600, 2); if(jld(0x100e_d65d, 0x5b)) goto l_0x100e_d65d; /* jl 0x100ed65d */
            ii(0x100e_d602, 5); mov(edx, 0x53);                         /* mov edx, 0x53 */
            ii(0x100e_d607, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d60b, 5); calld(0x100e_c486, -0x118a);            /* call 0x100ec486 */
            ii(0x100e_d610, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_d613, 5); mov(edx, 0x51);                         /* mov edx, 0x51 */
            ii(0x100e_d618, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d61c, 5); calld(0x100e_c486, -0x119b);            /* call 0x100ec486 */
            ii(0x100e_d621, 1); cwde();                                 /* cwde */
            ii(0x100e_d622, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_d624, 5); mov(edx, 0x52);                         /* mov edx, 0x52 */
            ii(0x100e_d629, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d62d, 5); calld(0x100e_c486, -0x11ac);            /* call 0x100ec486 */
            ii(0x100e_d632, 1); cwde();                                 /* cwde */
            ii(0x100e_d633, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_d635, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x100e_d63a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d63e, 5); calld(0x100e_c486, -0x11bd);            /* call 0x100ec486 */
            ii(0x100e_d643, 1); cwde();                                 /* cwde */
            ii(0x100e_d644, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100e_d646, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_d649, 2); if(jld(0x100e_d654, 0x9)) goto l_0x100e_d654; /* jl 0x100ed654 */
            ii(0x100e_d64b, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d64f, 5); jmpd(0x100e_d760, 0x10c); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d654:
            ii(0x100e_d654, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d658, 5); jmpd(0x100e_d760, 0x103); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d65d:
            ii(0x100e_d65d, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d661, 5); jmpd(0x100e_d760, 0xfa); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d666:
            ii(0x100e_d666, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d66b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d670, 5); calld(0x100e_c486, -0x11ef);            /* call 0x100ec486 */
            ii(0x100e_d675, 1); cwde();                                 /* cwde */
            ii(0x100e_d676, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d678, 2); if(jnzd(0x100e_d683, 0x9)) goto l_0x100e_d683; /* jnz 0x100ed683 */
            ii(0x100e_d67a, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d67e, 5); jmpd(0x100e_d760, 0xdd); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d683:
            ii(0x100e_d683, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d687, 5); jmpd(0x100e_d760, 0xd4); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d68c:
            ii(0x100e_d68c, 5); mov(eax, memd_a32[ds, 0x101c_3964]);    /* mov eax, [0x101c3964] */
            ii(0x100e_d691, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d694, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d696, 2); if(jnzd(0x100e_d6af, 0x17)) goto l_0x100e_d6af; /* jnz 0x100ed6af */
            ii(0x100e_d698, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_d69b, 7); cmp(ax, memw_a32[ds, 0x101c_3968]);     /* cmp ax, [0x101c3968] */
            ii(0x100e_d6a2, 2); if(jld(0x100e_d6ad, 0x9)) goto l_0x100e_d6ad; /* jl 0x100ed6ad */
            ii(0x100e_d6a4, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d6a8, 5); jmpd(0x100e_d760, 0xb3); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d6ad:
            ii(0x100e_d6ad, 2); jmpd(0x100e_d6e1, 0x32); goto l_0x100e_d6e1; /* jmp 0x100ed6e1 */
        l_0x100e_d6af:
            ii(0x100e_d6af, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100e_d6b4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d6b7, 6); cmp(eax, memd_a32[ds, 0x101c_a550]);    /* cmp eax, [0x101ca550] */
            ii(0x100e_d6bd, 2); if(jgd(0x100e_d6c8, 0x9)) goto l_0x100e_d6c8; /* jg 0x100ed6c8 */
            ii(0x100e_d6bf, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d6c3, 5); jmpd(0x100e_d760, 0x98); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d6c8:
            ii(0x100e_d6c8, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100e_d6cd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d6d0, 6); cmp(eax, memd_a32[ds, 0x101c_a797]);    /* cmp eax, [0x101ca797] */
            ii(0x100e_d6d6, 2); if(jgd(0x100e_d6e1, 0x9)) goto l_0x100e_d6e1; /* jg 0x100ed6e1 */
            ii(0x100e_d6d8, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d6dc, 5); jmpd(0x100e_d760, 0x7f); goto l_0x100e_d760; /* jmp 0x100ed760 */
        l_0x100e_d6e1:
            ii(0x100e_d6e1, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d6e5, 5); jmpd(0x100e_d760, 0x76); goto l_0x100e_d760; /* jmp 0x100ed760 */
        //  ii(0x100e_d6ea, 2); mov(eax, eax);                          /* mov eax, eax */
        //  ii(0x100e_d6ec, 36); /* Служебная область с абсолютными адресами переходов. (0x100e_d445, 0x100e_d488, 0x100e_d4c6, 0x100e_d666, 0x100e_d666, 0x100e_d68c, 0x100e_d68c, 0x100e_d539, 0x100e_d666). */
        l_0x100e_d710:
            ii(0x100e_d710, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_d713, 1); dec(eax);                               /* dec eax */
            ii(0x100e_d714, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_d717, 5); cmp(memw_a32[ss, ebp - 0x34], 0x8);     /* cmp word [ebp-0x34], 0x8 */
            ii(0x100e_d71c, 6); if(jad(0x100e_d68c, -0x96)) goto l_0x100e_d68c; /* ja 0x100ed68c */
            ii(0x100e_d722, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_d724, 4); mov(ax, memw_a32[ss, ebp - 0x34]);      /* mov ax, [ebp-0x34] */
            ii(0x100e_d728, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_d72b, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x100e_d6ec]))
            {
                case 0x100e_d445:
                    goto l_0x100e_d445;
                case 0x100e_d488:
                    goto l_0x100e_d488;
                case 0x100e_d4c6:
                    goto l_0x100e_d4c6;
                case 0x100e_d539:
                    goto l_0x100e_d539;
                case 0x100e_d666:
                    goto l_0x100e_d666;
                case 0x100e_d68c:
                    goto l_0x100e_d68c;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100ed6ec] */
        l_0x100e_d732:
            ii(0x100e_d732, 2); jmpd(0x100e_d75c, 0x28); goto l_0x100e_d75c; /* jmp 0x100ed75c */
        l_0x100e_d734:
            ii(0x100e_d734, 4); cmp(memd_a32[ss, ebp - 0x10], 0x2);     /* cmp dword [ebp-0x10], 0x2 */
            ii(0x100e_d738, 2); if(jbd(0x100e_d750, 0x16)) goto l_0x100e_d750; /* jb 0x100ed750 */
            ii(0x100e_d73a, 4); cmp(memd_a32[ss, ebp - 0x10], 0x2);     /* cmp dword [ebp-0x10], 0x2 */
            ii(0x100e_d73e, 6); if(jbed(0x100e_d437, -0x30d)) goto l_0x100e_d437; /* jbe 0x100ed437 */
            ii(0x100e_d744, 4); cmp(memd_a32[ss, ebp - 0x10], 0x8);     /* cmp dword [ebp-0x10], 0x8 */
            ii(0x100e_d748, 6); if(jzd(0x100e_d2ff, -0x44f)) goto l_0x100e_d2ff; /* jz 0x100ed2ff */
            ii(0x100e_d74e, 2); jmpd(0x100e_d732, -0x1e); goto l_0x100e_d732; /* jmp 0x100ed732 */
        l_0x100e_d750:
            ii(0x100e_d750, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1);     /* cmp dword [ebp-0x10], 0x1 */
            ii(0x100e_d754, 6); if(jzd(0x100e_cd8d, -0x9cd)) goto l_0x100e_cd8d; /* jz 0x100ecd8d */
            ii(0x100e_d75a, 2); jmpd(0x100e_d732, -0x2a); goto l_0x100e_d732; /* jmp 0x100ed732 */
        l_0x100e_d75c:
            ii(0x100e_d75c, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100e_d760:
            ii(0x100e_d760, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_d763, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_d765, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_d766, 1); popd(edi);                              /* pop edi */
            ii(0x100e_d767, 1); popd(esi);                              /* pop esi */
            ii(0x100e_d768, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_d769, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_d76a, 1); retd();                                 /* ret */
        }
    }
}
