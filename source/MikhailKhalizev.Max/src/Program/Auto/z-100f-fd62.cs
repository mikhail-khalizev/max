using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7d3821b5-3850-4274-953f-2b44f4a489f1")]
        public void Method_100f_fd62()
        {
            ii(0x100f_fd62, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x100f_fd67, 5); calld(Definitions.sys_check_available_stack_size, 0x6_5fe6); /* call 0x10165d52 */
            ii(0x100f_fd6c, 1); pushd(esi);                             /* push esi */
            ii(0x100f_fd6d, 1); pushd(edi);                             /* push edi */
            ii(0x100f_fd6e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_fd6f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_fd71, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x100f_fd77, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_fd7a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100f_fd7d, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100f_fd80, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100f_fd83, 5); cmp(memw_a32[ss, ebp + 0x14], 0);       /* cmp word [ebp+0x14], 0x0 */
            ii(0x100f_fd88, 2); if(jzd(0x100f_fd98, 0xe)) goto l_0x100f_fd98; /* jz 0x100ffd98 */
            ii(0x100f_fd8a, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100f_fd8e, 5); calld(Definitions.my_get_res_data_by_id, 0x3_4245); /* call 0x10133fd8 */
            ii(0x100f_fd93, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100f_fd96, 2); jmpd(0x100f_fda5, 0xd); goto l_0x100f_fda5; /* jmp 0x100ffda5 */
        l_0x100f_fd98:
            ii(0x100f_fd98, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100f_fd9b, 1); inc(eax);                               /* inc eax */
            ii(0x100f_fd9c, 1); cwde();                                 /* cwde */
            ii(0x100f_fd9d, 5); calld(Definitions.my_get_res_data_by_id, 0x3_4236); /* call 0x10133fd8 */
            ii(0x100f_fda2, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100f_fda5:
            ii(0x100f_fda5, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100f_fda9, 6); if(jzd(0x100f_ff8d, 0x1de)) goto l_0x100f_ff8d; /* jz 0x100fff8d */
            ii(0x100f_fdaf, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100f_fdb3, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x100f_fdb6, 2); if(jged(0x100f_fdc1, 0x9)) goto l_0x100f_fdc1; /* jge 0x100ffdc1 */
            ii(0x100f_fdb8, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100f_fdbf, 2); jmpd(0x100f_fde0, 0x1f); goto l_0x100f_fde0; /* jmp 0x100ffde0 */
        l_0x100f_fdc1:
            ii(0x100f_fdc1, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x100f_fdc4, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x100f_fdc6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_fdc9, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_fdcd, 1); dec(edx);                               /* dec edx */
            ii(0x100f_fdce, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_fdd0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_fdd2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_fdd5, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_fdd8, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100f_fdda, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x100f_fddd, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100f_fde0:
            ii(0x100f_fde0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fde4, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x100f_fde8, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_fdeb, 1); dec(eax);                               /* dec eax */
            ii(0x100f_fdec, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_fdee, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x100f_fdf1, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100f_fdf3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_fdf6, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_fdf8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_fdfa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_fdfc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_fdff, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_fe01, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_fe03, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_fe07, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_fe0a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_fe0d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_fe0f, 3); mov(memd_a32[ss, ebp - 0x44], edx);     /* mov [ebp-0x44], edx */
            ii(0x100f_fe12, 4); movsx(edx, memw_a32[ss, ebp + 0x18]);   /* movsx edx, word [ebp+0x18] */
            ii(0x100f_fe16, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x100f_fe19, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_fe1e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_fe20, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_fe23, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_fe25, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100f_fe28, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100f_fe2b, 1); dec(eax);                               /* dec eax */
            ii(0x100f_fe2c, 3); imul(eax, eax, 0x5);                    /* imul eax, eax, 0x5 */
            ii(0x100f_fe2f, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x100f_fe32, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_fe34, 3); mov(memd_a32[ss, ebp - 0x38], edx);     /* mov [ebp-0x38], edx */
            ii(0x100f_fe37, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_fe3a, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_fe3d, 4); imul(eax, memd_a32[ss, ebp - 0x3c]);    /* imul eax, [ebp-0x3c] */
            ii(0x100f_fe41, 3); sub(memd_a32[ss, ebp - 0x4], eax);      /* sub [ebp-0x4], eax */
            ii(0x100f_fe44, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x100f_fe47, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_fe4a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100f_fe4f, 3); sub(eax, memd_a32[ss, ebp - 0x38]);     /* sub eax, [ebp-0x38] */
            ii(0x100f_fe52, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_fe54, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100f_fe57, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_fe5b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_fe5d, 2); if(jnzd(0x100f_fe71, 0x12)) goto l_0x100f_fe71; /* jnz 0x100ffe71 */
            ii(0x100f_fe5f, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_fe62, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_fe65, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100f_fe68, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100f_fe6f, 2); jmpd(0x100f_fed4, 0x63); goto l_0x100f_fed4; /* jmp 0x100ffed4 */
        l_0x100f_fe71:
            ii(0x100f_fe71, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_fe74, 4); cmp(ax, memw_a32[ss, ebp - 0x28]);      /* cmp ax, [ebp-0x28] */
            ii(0x100f_fe78, 2); if(jld(0x100f_fea9, 0x2f)) goto l_0x100f_fea9; /* jl 0x100ffea9 */
            ii(0x100f_fe7a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_fe7e, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100f_fe82, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_fe84, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_fe87, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_fe89, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100f_fe8c, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100f_fe8f, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x100f_fe92, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100f_fe95, 2); if(jled(0x100f_fea0, 0x9)) goto l_0x100f_fea0; /* jle 0x100ffea0 */
            ii(0x100f_fe97, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_fe9a, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_fe9d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x100f_fea0:
            ii(0x100f_fea0, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100f_fea7, 2); jmpd(0x100f_fed4, 0x2b); goto l_0x100f_fed4; /* jmp 0x100ffed4 */
        l_0x100f_fea9:
            ii(0x100f_fea9, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
            ii(0x100f_feb0, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_feb4, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_feb8, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_feba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_febc, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100f_fec0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_fec2, 4); movsx(ebx, memw_a32[ss, ebp - 0x3c]);   /* movsx ebx, word [ebp-0x3c] */
            ii(0x100f_fec6, 1); dec(ebx);                               /* dec ebx */
            ii(0x100f_fec7, 3); lea(edx, eax - 0x2);                    /* lea edx, [eax-0x2] */
            ii(0x100f_feca, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_fecc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_fecf, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_fed1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100f_fed4:
            ii(0x100f_fed4, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x100f_fed7, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_feda, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_fedd, 3); add(dx, memw_a32[ds, eax]);             /* add dx, [eax] */
            ii(0x100f_fee0, 3); sub(edx, memd_a32[ss, ebp - 0x24]);     /* sub edx, [ebp-0x24] */
            ii(0x100f_fee3, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x100f_fee6, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100f_feed, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100f_fef4, 2); jmpd(0x100f_fefc, 0x6); goto l_0x100f_fefc; /* jmp 0x100ffefc */
        l_0x100f_fef6:
            ii(0x100f_fef6, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_fef9, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x100f_fefc:
            ii(0x100f_fefc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_feff, 4); cmp(ax, memw_a32[ss, ebp + 0x18]);      /* cmp ax, [ebp+0x18] */
            ii(0x100f_ff03, 6); if(jged(0x100f_ff8d, 0x84)) goto l_0x100f_ff8d; /* jge 0x100fff8d */
            ii(0x100f_ff09, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100f_ff0d, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_ff12, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_ff14, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_ff17, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_ff19, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x100f_ff1c, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100f_ff20, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100f_ff25, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_ff27, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_ff2a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_ff2c, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x100f_ff30, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100f_ff33, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100f_ff37, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100f_ff3b, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100f_ff3e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_ff40, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_ff43, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_ff46, 4); imul(eax, memd_a32[ss, ebp - 0x34]);    /* imul eax, [ebp-0x34] */
            ii(0x100f_ff4a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_ff4d, 3); mov(ebx, memd_a32[ss, ebp - 0x40]);     /* mov ebx, [ebp-0x40] */
            ii(0x100f_ff50, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_ff54, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x100f_ff58, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_ff5c, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x100f_ff5f, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100f_ff63, 3); add(eax, memd_a32[ss, ebp - 0x44]);     /* add eax, [ebp-0x44] */
            ii(0x100f_ff66, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100f_ff68, 5); calld(0x1013_f410, 0x3_f4a3);           /* call 0x1013f410 */
            ii(0x100f_ff6d, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x100f_ff70, 3); dec(memd_a32[ss, ebp + 0x14]);          /* dec dword [ebp+0x14] */
            ii(0x100f_ff73, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100f_ff77, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_ff79, 2); if(jnzd(0x100f_ff88, 0xd)) goto l_0x100f_ff88; /* jnz 0x100fff88 */
            ii(0x100f_ff7b, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100f_ff7e, 1); inc(eax);                               /* inc eax */
            ii(0x100f_ff7f, 1); cwde();                                 /* cwde */
            ii(0x100f_ff80, 5); calld(Definitions.my_get_res_data_by_id, 0x3_4053); /* call 0x10133fd8 */
            ii(0x100f_ff85, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100f_ff88:
            ii(0x100f_ff88, 5); jmpd(0x100f_fef6, -0x97); goto l_0x100f_fef6; /* jmp 0x100ffef6 */
        l_0x100f_ff8d:
            ii(0x100f_ff8d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ff8f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_ff90, 1); popd(edi);                              /* pop edi */
            ii(0x100f_ff91, 1); popd(esi);                              /* pop esi */
            ii(0x100f_ff92, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
