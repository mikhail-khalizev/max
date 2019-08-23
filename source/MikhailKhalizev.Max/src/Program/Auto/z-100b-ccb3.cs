using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_ccb3-1ab422ff")]
        public void Method_100b_ccb3()
        {
            ii(0x100b_ccb3, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100b_ccb8, 5); calld(Definitions.sys_check_available_stack_size, 0xa_9095); /* call 0x10165d52 */
            ii(0x100b_ccbd, 1); pushd(esi);                             /* push esi */
            ii(0x100b_ccbe, 1); pushd(edi);                             /* push edi */
            ii(0x100b_ccbf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_ccc0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_ccc2, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_ccc8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_cccb, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100b_ccce, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100b_ccd1, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100b_ccd4, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_ccd7, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_ccda, 5); calld(0x1007_5e64, -0x4_6e7b);          /* call 0x10075e64 */
            ii(0x100b_ccdf, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_cce2, 5); calld(Definitions.my_ctor_0x101b_4184, -0x4_61f7); /* call 0x10076af0 */
            ii(0x100b_cce7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_ccea, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100b_ccec, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_ccef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_ccf2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_ccf5, 5); calld(0x1007_3cfd, -0x4_8ffd);          /* call 0x10073cfd */
            ii(0x100b_ccfa, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_ccfd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_cd00, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_cd03, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_cd06, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_cd09, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100b_cd0b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_cd0d, 5); calld(/* sys */ 0x1016_5df8, 0xa_90e6); /* call 0x10165df8 */
            ii(0x100b_cd12, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x100b_cd16, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_cd19, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100b_cd1b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_cd1e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_cd21, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_cd23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_cd26, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100b_cd28, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_cd2a, 5); calld(/* sys */ 0x1016_5df8, 0xa_90c9); /* call 0x10165df8 */
            ii(0x100b_cd2f, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
            ii(0x100b_cd33, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_cd36, 4); cmp(ax, memw_a32[ss, ebp - 0x22]);      /* cmp ax, [ebp-0x22] */
            ii(0x100b_cd3a, 6); if(jled(0x100b_ce28, 0xe8)) goto l_0x100b_ce28; /* jle 0x100bce28 */
            ii(0x100b_cd40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_cd43, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100b_cd47, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_cd4a, 4); cmp(dx, memw_a32[ds, eax + 0x2]);       /* cmp dx, [eax+0x2] */
            ii(0x100b_cd4e, 2); if(jged(0x100b_cd59, 0x9)) goto l_0x100b_cd59; /* jge 0x100bcd59 */
            ii(0x100b_cd50, 7); mov(memd_a32[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x100b_cd57, 2); jmpd(0x100b_cd60, 0x7); goto l_0x100b_cd60; /* jmp 0x100bcd60 */
        l_0x100b_cd59:
            ii(0x100b_cd59, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
        l_0x100b_cd60:
            ii(0x100b_cd60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_cd63, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100b_cd66, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_cd69, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100b_cd6c, 2); if(jged(0x100b_cd7c, 0xe)) goto l_0x100b_cd7c; /* jge 0x100bcd7c */
            ii(0x100b_cd6e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_cd71, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_cd74, 5); calld(0x1008_8b44, -0x3_4235);          /* call 0x10088b44 */
            ii(0x100b_cd79, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
        l_0x100b_cd7c:
            ii(0x100b_cd7c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_cd7f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_cd82, 4); movsx(edx, memw_a32[ss, ebp - 0x22]);   /* movsx edx, word [ebp-0x22] */
            ii(0x100b_cd86, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_cd88, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_cd8b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_cd8d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_cd8f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100b_cd92:
            ii(0x100b_cd92, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x100b_cd95, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x100b_cd9a, 6); if(jzd(0x100b_ce23, 0x83)) goto l_0x100b_ce23; /* jz 0x100bce23 */
            ii(0x100b_cda0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_cda3, 4); inc(memw_a32[ss, ebp - 0x28]);          /* inc word [ebp-0x28] */
            ii(0x100b_cda7, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x100b_cdaa, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
            ii(0x100b_cdad, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_cdb0, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x100b_cdb4, 2); if(jld(0x100b_cdc3, 0xd)) goto l_0x100b_cdc3; /* jl 0x100bcdc3 */
            ii(0x100b_cdb6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_cdb9, 4); add(memw_a32[ss, ebp - 0x26], ax);      /* add [ebp-0x26], ax */
            ii(0x100b_cdbd, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_cdc0, 3); sub(memd_a32[ss, ebp - 0x1c], eax);     /* sub [ebp-0x1c], eax */
        l_0x100b_cdc3:
            ii(0x100b_cdc3, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_cdc7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_cdca, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100b_cdcd, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_cdd1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_cdd3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_cdd5, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100b_cdd8, 2); if(jnzd(0x100b_cdea, 0x10)) goto l_0x100b_cdea; /* jnz 0x100bcdea */
            ii(0x100b_cdda, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_cdde, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_cde2, 5); calld(0x1007_3cfd, -0x4_90ea);          /* call 0x10073cfd */
            ii(0x100b_cde7, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100b_cdea:
            ii(0x100b_cdea, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_cdee, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_cdf2, 5); calld(0x1007_3cfd, -0x4_90fa);          /* call 0x10073cfd */
            ii(0x100b_cdf7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cdf9, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x100b_cdfc, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100b_ce00, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_ce02, 2); if(jnzd(0x100b_ce1e, 0x1a)) goto l_0x100b_ce1e; /* jnz 0x100bce1e */
            ii(0x100b_ce04, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_ce08, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_ce0b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_ce0e, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_ce11, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_ce13, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_ce17, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_ce19, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_ce1b, 3); or(memb_a32[ds, eax], 0x4);             /* or byte [eax], 0x4 */
        l_0x100b_ce1e:
            ii(0x100b_ce1e, 5); jmpd(0x100b_cd92, -0x91); goto l_0x100b_cd92; /* jmp 0x100bcd92 */
        l_0x100b_ce23:
            ii(0x100b_ce23, 5); jmpd(0x100b_cf0b, 0xe3); goto l_0x100b_cf0b; /* jmp 0x100bcf0b */
        l_0x100b_ce28:
            ii(0x100b_ce28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_ce2b, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100b_ce2e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_ce31, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100b_ce34, 2); if(jged(0x100b_ce3f, 0x9)) goto l_0x100b_ce3f; /* jge 0x100bce3f */
            ii(0x100b_ce36, 7); mov(memd_a32[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x100b_ce3d, 2); jmpd(0x100b_ce46, 0x7); goto l_0x100b_ce46; /* jmp 0x100bce46 */
        l_0x100b_ce3f:
            ii(0x100b_ce3f, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
        l_0x100b_ce46:
            ii(0x100b_ce46, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_ce49, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100b_ce4d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_ce50, 4); cmp(dx, memw_a32[ds, eax + 0x2]);       /* cmp dx, [eax+0x2] */
            ii(0x100b_ce54, 2); if(jged(0x100b_ce64, 0xe)) goto l_0x100b_ce64; /* jge 0x100bce64 */
            ii(0x100b_ce56, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_ce59, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_ce5c, 5); calld(0x1008_8b44, -0x3_431d);          /* call 0x10088b44 */
            ii(0x100b_ce61, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
        l_0x100b_ce64:
            ii(0x100b_ce64, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x100b_ce67, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_ce6a, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100b_ce6e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_ce70, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_ce73, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_ce75, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_ce77, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100b_ce7a:
            ii(0x100b_ce7a, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x100b_ce7d, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x100b_ce82, 6); if(jzd(0x100b_cf0b, 0x83)) goto l_0x100b_cf0b; /* jz 0x100bcf0b */
            ii(0x100b_ce88, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x100b_ce8b, 4); inc(memw_a32[ss, ebp - 0x26]);          /* inc word [ebp-0x26] */
            ii(0x100b_ce8f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_ce92, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
            ii(0x100b_ce95, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_ce98, 4); cmp(ax, memw_a32[ss, ebp - 0x22]);      /* cmp ax, [ebp-0x22] */
            ii(0x100b_ce9c, 2); if(jld(0x100b_ceab, 0xd)) goto l_0x100b_ceab; /* jl 0x100bceab */
            ii(0x100b_ce9e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_cea1, 4); add(memw_a32[ss, ebp - 0x28], ax);      /* add [ebp-0x28], ax */
            ii(0x100b_cea5, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x100b_cea8, 3); sub(memd_a32[ss, ebp - 0x1c], eax);     /* sub [ebp-0x1c], eax */
        l_0x100b_ceab:
            ii(0x100b_ceab, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_ceaf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_ceb2, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100b_ceb5, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_ceb9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_cebb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_cebd, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100b_cec0, 2); if(jnzd(0x100b_ced2, 0x10)) goto l_0x100b_ced2; /* jnz 0x100bced2 */
            ii(0x100b_cec2, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_cec6, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_ceca, 5); calld(0x1007_3cfd, -0x4_91d2);          /* call 0x10073cfd */
            ii(0x100b_cecf, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100b_ced2:
            ii(0x100b_ced2, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_ced6, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100b_ceda, 5); calld(0x1007_3cfd, -0x4_91e2);          /* call 0x10073cfd */
            ii(0x100b_cedf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cee1, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x100b_cee4, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100b_cee8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_ceea, 2); if(jnzd(0x100b_cf06, 0x1a)) goto l_0x100b_cf06; /* jnz 0x100bcf06 */
            ii(0x100b_ceec, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100b_cef0, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_cef3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_cef6, 3); mov(eax, memd_a32[ds, eax + 0x63]);     /* mov eax, [eax+0x63] */
            ii(0x100b_cef9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_cefb, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100b_ceff, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_cf01, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_cf03, 3); or(memb_a32[ds, eax], 0x4);             /* or byte [eax], 0x4 */
        l_0x100b_cf06:
            ii(0x100b_cf06, 5); jmpd(0x100b_ce7a, -0x91); goto l_0x100b_ce7a; /* jmp 0x100bce7a */
        l_0x100b_cf0b:
            ii(0x100b_cf0b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_cf0d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_cf0e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_cf0f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_cf10, 1); retd();                                 /* ret */
        }
    }
}
