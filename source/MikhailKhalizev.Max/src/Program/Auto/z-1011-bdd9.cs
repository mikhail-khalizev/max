using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("274639a2-9bbc-480c-84c4-1e02118b30f5")]
        public void Method_1011_bdd9()
        {
            ii(0x1011_bdd9, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1011_bdde, 5); calld(Definitions.sys_check_available_stack_size, 0x4_9f6f); /* call 0x10165d52 */
            ii(0x1011_bde3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_bde4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_bde5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_bde6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bde8, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1011_bdee, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_bdf1, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_bdf4, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_bdf7, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1011_bdfa, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x1011_bdff, 5); calld(0x100e_883d, -0x3_35c7);          /* call 0x100e883d */
            ii(0x1011_be04, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_be07, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_be0a, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1011_be0d, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1011_be12, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_be15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_be18, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1011_be1b, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1011_be20, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_be23, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_be27, 6); cmp(eax, memd_a32[ds, 0x101c_38f4]);    /* cmp eax, [0x101c38f4] */
            ii(0x1011_be2d, 2); if(jged(0x1011_be3b, 0xc)) goto l_0x1011_be3b; /* jge 0x1011be3b */
            ii(0x1011_be2f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_be33, 6); cmp(eax, memd_a32[ds, 0x101c_38ec]);    /* cmp eax, [0x101c38ec] */
            ii(0x1011_be39, 2); if(jgd(0x1011_be3d, 0x2)) goto l_0x1011_be3d; /* jg 0x1011be3d */
        l_0x1011_be3b:
            ii(0x1011_be3b, 2); jmpd(0x1011_be49, 0xc); goto l_0x1011_be49; /* jmp 0x1011be49 */
        l_0x1011_be3d:
            ii(0x1011_be3d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_be41, 6); cmp(eax, memd_a32[ds, 0x101c_38f8]);    /* cmp eax, [0x101c38f8] */
            ii(0x1011_be47, 2); if(jld(0x1011_be4b, 0x2)) goto l_0x1011_be4b; /* jl 0x1011be4b */
        l_0x1011_be49:
            ii(0x1011_be49, 2); jmpd(0x1011_be57, 0xc); goto l_0x1011_be57; /* jmp 0x1011be57 */
        l_0x1011_be4b:
            ii(0x1011_be4b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_be4f, 6); cmp(eax, memd_a32[ds, 0x101c_38f0]);    /* cmp eax, [0x101c38f0] */
            ii(0x1011_be55, 2); if(jgd(0x1011_be5c, 0x5)) goto l_0x1011_be5c; /* jg 0x1011be5c */
        l_0x1011_be57:
            ii(0x1011_be57, 5); jmpd(0x1011_bf0a, 0xae); goto l_0x1011_bf0a; /* jmp 0x1011bf0a */
        l_0x1011_be5c:
            ii(0x1011_be5c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_be60, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_be63, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_be65, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_be68, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1011_be6e, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x1011_be74, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_be77, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_be79, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_be7c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_be80, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_be83, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_be85, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_be88, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1011_be8e, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x1011_be94, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_be97, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_be99, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_be9c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_bea0, 1); pushd(eax);                             /* push eax */
            ii(0x1011_bea1, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x1011_bea5, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x1011_bea9, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_bead, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_beb0, 5); calld(0x1011_94ea, -0x29cb);            /* call 0x101194ea */
            ii(0x1011_beb5, 5); mov(eax, memd_a32[ds, 0x101c_38c0]);    /* mov eax, [0x101c38c0] */
            ii(0x1011_beba, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_bebc, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_bec0, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_bec2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_bec5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_bec7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_bec9, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_becc, 5); mov(eax, memd_a32[ds, 0x101c_38c0]);    /* mov eax, [0x101c38c0] */
            ii(0x1011_bed1, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_bed3, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_bed7, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_bed9, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_bedc, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_bedf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_bee1, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_bee4, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_bee7, 6); add(eax, memd_a32[ds, 0x101c_38c0]);    /* add eax, [0x101c38c0] */
            ii(0x1011_beed, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_bef0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_bef3, 6); add(eax, memd_a32[ds, 0x101c_38c0]);    /* add eax, [0x101c38c0] */
            ii(0x1011_bef9, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_befc, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x1011_beff, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_bf02, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1011_bf05, 5); calld(Definitions.sys_display_draw_1, 0x4_b59e); /* call 0x101674a8 */
        l_0x1011_bf0a:
            ii(0x1011_bf0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bf0c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_bf0d, 1); popd(edi);                              /* pop edi */
            ii(0x1011_bf0e, 1); popd(esi);                              /* pop esi */
            ii(0x1011_bf0f, 1); retd(); return;                         /* ret */
        }
    }
}
