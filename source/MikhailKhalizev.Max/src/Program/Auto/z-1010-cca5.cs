using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_cca5-2e4f4c02")]
        public void Method_1010_cca5()
        {
            ii(0x1010_cca5, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x1010_ccaa, 5); calld(Definitions.sys_check_available_stack_size, 0x5_90a3); /* call 0x10165d52 */
            ii(0x1010_ccaf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_ccb0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_ccb1, 1); pushd(edx);                             /* push edx */
            ii(0x1010_ccb2, 1); pushd(esi);                             /* push esi */
            ii(0x1010_ccb3, 1); pushd(edi);                             /* push edi */
            ii(0x1010_ccb4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_ccb5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_ccb7, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1010_ccbd, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_ccc0, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_ccc5, 5); calld(/* sys */ 0x1016_a24c, 0x5_d582); /* call 0x1016a24c */
            ii(0x1010_ccca, 5); calld(0x1011_5318, 0x8649);             /* call 0x10115318 */
            ii(0x1010_cccf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_ccd4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ccd5, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_ccda, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_ccdf, 5); mov(edx, 0x101b_97f4);                  /* mov edx, 0x101b97f4 */
            ii(0x1010_cce4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cce7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cce9, 5); calld(0x1010_8a05, -0x42e9);            /* call 0x10108a05 */
            ii(0x1010_ccee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ccf1, 4); cmp(memd_a32[ds, eax + 0x14], 0);       /* cmp dword [eax+0x14], 0x0 */
            ii(0x1010_ccf5, 6); if(jnzd(0x1010_cd7e, 0x83)) goto l_0x1010_cd7e; /* jnz 0x1010cd7e */
            ii(0x1010_ccfb, 7); mov(memd_a32[ss, ebp - 0x28], 0x101b_9808); /* mov dword [ebp-0x28], 0x101b9808 */
            ii(0x1010_cd02, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_cd07, 5); calld(Definitions.sys_new, 0x5_90f4);   /* call 0x10165e00 */
            ii(0x1010_cd0c, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_cd0f, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_cd12, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_cd15, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1010_cd19, 2); if(jzd(0x1010_cd5f, 0x44)) goto l_0x1010_cd5f; /* jz 0x1010cd5f */
            ii(0x1010_cd1b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_cd1e, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1010_cd22, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1010_cd25, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1010_cd29, 1); inc(eax);                               /* inc eax */
            ii(0x1010_cd2a, 1); cwde();                                 /* cwde */
            ii(0x1010_cd2b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cd2c, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_cd2f, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_cd33, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1010_cd36, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1010_cd39, 1); inc(eax);                               /* inc eax */
            ii(0x1010_cd3a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_cd3d, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_cd40, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1010_cd43, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_cd46, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_cd49, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1010_cd4c, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_cd4f, 5); calld(0x100d_7bdc, -0x3_5178);          /* call 0x100d7bdc */
            ii(0x1010_cd54, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_cd57, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_cd5a, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1010_cd5d, 2); jmpd(0x1010_cd65, 0x6); goto l_0x1010_cd65; /* jmp 0x1010cd65 */
        l_0x1010_cd5f:
            ii(0x1010_cd5f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_cd62, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1010_cd65:
            ii(0x1010_cd65, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_cd68, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_cd6b, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x1010_cd6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cd71, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_cd73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cd76, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_cd79, 5); calld(0x100d_7d74, -0x3_500a);          /* call 0x100d7d74 */
        l_0x1010_cd7e:
            ii(0x1010_cd7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cd81, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_cd83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cd86, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_cd89, 5); calld(0x100d_7f6c, -0x3_4e22);          /* call 0x100d7f6c */
            ii(0x1010_cd8e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cd91, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1010_cd94, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cd97, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_cd9a, 6); mov(eax, memd_a32[ds, eax + 0x101b_9794]); /* mov eax, [eax+0x101b9794] */
            ii(0x1010_cda0, 5); mov(memd_a32[ds, 0x101b_9818], eax);    /* mov [0x101b9818], eax */
            ii(0x1010_cda5, 5); calld(0x1011_5318, 0x856e);             /* call 0x10115318 */
            ii(0x1010_cdaa, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_cdaf, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cdb0, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_cdb5, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_cdba, 5); mov(edx, 0x101b_9808);                  /* mov edx, 0x101b9808 */
            ii(0x1010_cdbf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cdc2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cdc4, 5); calld(0x1010_8a05, -0x43c4);            /* call 0x10108a05 */
            ii(0x1010_cdc9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cdcc, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_cdce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cdd1, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1010_cdd4, 5); calld(0x100d_7f6c, -0x3_4e6d);          /* call 0x100d7f6c */
            ii(0x1010_cdd9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cddc, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1010_cddf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cde2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_cde5, 6); mov(eax, memd_a32[ds, eax + 0x101b_9734]); /* mov eax, [eax+0x101b9734] */
            ii(0x1010_cdeb, 5); mov(memd_a32[ds, 0x101b_982c], eax);    /* mov [0x101b982c], eax */
            ii(0x1010_cdf0, 5); calld(0x1011_5318, 0x8523);             /* call 0x10115318 */
            ii(0x1010_cdf5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_cdfa, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cdfb, 5); calld(0x1011_5338, 0x8538);             /* call 0x10115338 */
            ii(0x1010_ce00, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_ce02, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1010_ce04, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_ce09, 5); mov(edx, 0x101b_981c);                  /* mov edx, 0x101b981c */
            ii(0x1010_ce0e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ce11, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ce13, 5); calld(0x1010_8a05, -0x4413);            /* call 0x10108a05 */
            ii(0x1010_ce18, 7); mov(memd_a32[ss, ebp - 0x18], 0xc);     /* mov dword [ebp-0x18], 0xc */
        l_0x1010_ce1f:
            ii(0x1010_ce1f, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x1010_ce22, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x1010_ce27, 2); if(jzd(0x1010_ce4f, 0x26)) goto l_0x1010_ce4f; /* jz 0x1010ce4f */
            ii(0x1010_ce29, 5); calld(0x100d_51e4, -0x3_7c4a);          /* call 0x100d51e4 */
            ii(0x1010_ce2e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_ce30, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_ce32, 5); calld(0x100d_5204, -0x3_7c33);          /* call 0x100d5204 */
            ii(0x1010_ce37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_ce39, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_ce3b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ce3f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_ce42, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_ce45, 3); mov(eax, memd_a32[ds, eax + 0x20]);     /* mov eax, [eax+0x20] */
            ii(0x1010_ce48, 5); calld(0x100c_fa7c, -0x3_d3d1);          /* call 0x100cfa7c */
            ii(0x1010_ce4d, 2); jmpd(0x1010_ce1f, -0x30); goto l_0x1010_ce1f; /* jmp 0x1010ce1f */
        l_0x1010_ce4f:
            ii(0x1010_ce4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ce52, 4); cmp(memd_a32[ds, eax + 0x18], 0);       /* cmp dword [eax+0x18], 0x0 */
            ii(0x1010_ce56, 2); if(jzd(0x1010_ce9c, 0x44)) goto l_0x1010_ce9c; /* jz 0x1010ce9c */
            ii(0x1010_ce58, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ce5b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_ce5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ce60, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1010_ce63, 5); calld(0x100d_7f6c, -0x3_4efc);          /* call 0x100d7f6c */
            ii(0x1010_ce68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ce6b, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1010_ce6e, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_ce71, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_ce75, 2); if(jzd(0x1010_ce8b, 0x14)) goto l_0x1010_ce8b; /* jz 0x1010ce8b */
            ii(0x1010_ce77, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_ce79, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_ce7c, 5); calld(Definitions.my_dtor_d3, -0x3_514e); /* call 0x100d7d33 */
            ii(0x1010_ce81, 5); calld(Definitions.sys_delete, 0x5_90de); /* call 0x10165f64 */
            ii(0x1010_ce86, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_ce89, 2); jmpd(0x1010_ce92, 0x7); goto l_0x1010_ce92; /* jmp 0x1010ce92 */
        l_0x1010_ce8b:
            ii(0x1010_ce8b, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
        l_0x1010_ce92:
            ii(0x1010_ce92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ce95, 7); mov(memd_a32[ds, eax + 0x18], 0);       /* mov dword [eax+0x18], 0x0 */
        l_0x1010_ce9c:
            ii(0x1010_ce9c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_ce9f, 3); mov(edx, memd_a32[ds, edx + 0xa]);      /* mov edx, [edx+0xa] */
            ii(0x1010_cea2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cea5, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_ceaa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_ceac, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_ceaf, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_ceb1, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1010_ceb4, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ceb8, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cebb, 7); mov(ax, memw_a32[ds, eax + 0x101b_9830]); /* mov ax, [eax+0x101b9830] */
            ii(0x1010_cec2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_cec5, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cec9, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cecc, 7); mov(ax, memw_a32[ds, eax + 0x101b_9832]); /* mov ax, [eax+0x101b9832] */
            ii(0x1010_ced3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_ced6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ceda, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cedd, 7); mov(ax, memw_a32[ds, eax + 0x101b_9834]); /* mov ax, [eax+0x101b9834] */
            ii(0x1010_cee4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_cee7, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ceeb, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_ceee, 7); mov(ax, memw_a32[ds, eax + 0x101b_9836]); /* mov ax, [eax+0x101b9836] */
            ii(0x1010_cef5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_cef8, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_cefd, 5); calld(Definitions.sys_new, 0x5_8efe);   /* call 0x10165e00 */
            ii(0x1010_cf02, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_cf05, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_cf08, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_cf0b, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_cf0f, 2); if(jzd(0x1010_cf3f, 0x2e)) goto l_0x1010_cf3f; /* jz 0x1010cf3f */
            ii(0x1010_cf11, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_cf14, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1010_cf17, 1); inc(eax);                               /* inc eax */
            ii(0x1010_cf18, 1); cwde();                                 /* cwde */
            ii(0x1010_cf19, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cf1a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_cf1d, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1010_cf20, 1); inc(eax);                               /* inc eax */
            ii(0x1010_cf21, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_cf24, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_cf28, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_cf2c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_cf2f, 5); calld(0x100d_7bdc, -0x3_5358);          /* call 0x100d7bdc */
            ii(0x1010_cf34, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_cf37, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_cf3a, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_cf3d, 2); jmpd(0x1010_cf45, 0x6); goto l_0x1010_cf45; /* jmp 0x1010cf45 */
        l_0x1010_cf3f:
            ii(0x1010_cf3f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_cf42, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1010_cf45:
            ii(0x1010_cf45, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_cf48, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_cf4b, 3); mov(memd_a32[ds, edx + 0x18], eax);     /* mov [edx+0x18], eax */
            ii(0x1010_cf4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cf51, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_cf53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cf56, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1010_cf59, 5); calld(0x100d_7d74, -0x3_51ea);          /* call 0x100d7d74 */
            ii(0x1010_cf5e, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1010_cf60, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_cf64, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cf65, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_cf69, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cf6a, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1010_cf6e, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_cf72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cf75, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cf77, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1010_cf7a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cf7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cf80, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cf82, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_cf85, 5); calld(/* sys */ 0x1016_a68c, 0x5_d702); /* call 0x1016a68c */
            ii(0x1010_cf8a, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1010_cf8c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1010_cf90, 1); dec(eax);                               /* dec eax */
            ii(0x1010_cf91, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cf92, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_cf96, 1); dec(eax);                               /* dec eax */
            ii(0x1010_cf97, 1); pushd(eax);                             /* push eax */
            ii(0x1010_cf98, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_cf9c, 3); lea(ecx, eax + 0x1);                    /* lea ecx, [eax+0x1] */
            ii(0x1010_cf9f, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_cfa3, 1); inc(ebx);                               /* inc ebx */
            ii(0x1010_cfa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cfa7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cfa9, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1010_cfac, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cfaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cfb2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cfb4, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_cfb7, 5); calld(/* sys */ 0x1016_a68c, 0x5_d6d0); /* call 0x1016a68c */
            ii(0x1010_cfbc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_cfbf, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_cfc1, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_cfc4, 5); calld(Definitions.sys_display_draw_0, 0x5_a4bb); /* call 0x10167484 */
            ii(0x1010_cfc9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_cfcb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_cfcc, 1); popd(edi);                              /* pop edi */
            ii(0x1010_cfcd, 1); popd(esi);                              /* pop esi */
            ii(0x1010_cfce, 1); popd(edx);                              /* pop edx */
            ii(0x1010_cfcf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_cfd0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_cfd1, 1); retd();                                 /* ret */
        }
    }
}
