using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ec715270-b1cc-481b-ab7f-71272ae42219")]
        public void Method_1014_018f()
        {
            ii(0x1014_018f, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_0194, 5); calld(Definitions.sys_check_available_stack_size, 0x25bb9); /* call 0x10165d52 */
            ii(0x1014_0199, 1); pushd(esi);                             /* push esi */
            ii(0x1014_019a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_019b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_019c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_019e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_01a4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_01a7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_01aa, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1014_01ad, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1014_01b0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_01b4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_01b8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_01be, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1014_01c4, 5); calld(0x100c_b6b0, -0x74b19);           /* call 0x100cb6b0 */
            ii(0x1014_01c9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_01cc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_01cf, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1014_01d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_01d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_01d7, 2); if(jled(0x1014_01f3, 0x1a)) goto l_0x1014_01f3; /* jle 0x101401f3 */
            ii(0x1014_01d9, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1014_01dd, 1); pushd(eax);                             /* push eax */
            ii(0x1014_01de, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1014_01e1, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1014_01e4, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_01e8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_01eb, 5); calld(0x1013_f8a4, -0x94c);             /* call 0x1013f8a4 */
            ii(0x1014_01f0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1014_01f3:
            ii(0x1014_01f3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_01f6, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1014_01f9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_01fc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_01fe, 2); if(jled(0x1014_0220, 0x20)) goto l_0x1014_0220; /* jle 0x10140220 */
            ii(0x1014_0200, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1014_0204, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0205, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1014_0208, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0209, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1014_020d, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_0211, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_0215, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_0218, 5); calld(0x1013_fa8c, -0x791);             /* call 0x1013fa8c */
            ii(0x1014_021d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1014_0220:
            ii(0x1014_0220, 4); movsx(ecx, memw_a32[ss, ebp + 0x14]);   /* movsx ecx, word [ebp+0x14] */
            ii(0x1014_0224, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_0228, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_022c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_022f, 5); calld(0x1013_fbfc, -0x638);             /* call 0x1013fbfc */
            ii(0x1014_0234, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_0237, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1014_023b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_023c, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1014_023f, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1014_0242, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_0246, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_0249, 5); calld(0x1013_feab, -0x3a3);             /* call 0x1013feab */
            ii(0x1014_024e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_0251, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_0254, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1014_0257, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_025a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_025c, 2); if(jled(0x1014_0278, 0x1a)) goto l_0x1014_0278; /* jle 0x10140278 */
            ii(0x1014_025e, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1014_0262, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0263, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1014_0266, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1014_0269, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_026d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_0270, 5); calld(0x1014_002d, -0x248);             /* call 0x1014002d */
            ii(0x1014_0275, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1014_0278:
            ii(0x1014_0278, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_027b, 5); cmp(memw_a32[ds, eax + 0x8], 0);        /* cmp word [eax+0x8], 0x0 */
            ii(0x1014_0280, 2); if(jzd(0x1014_02b4, 0x32)) goto l_0x1014_02b4; /* jz 0x101402b4 */
            ii(0x1014_0282, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1014_0286, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0287, 4); movsx(eax, memw_a32[ss, ebp + 0x1c]);   /* movsx eax, word [ebp+0x1c] */
            ii(0x1014_028b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_028c, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1014_0290, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0291, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1014_0294, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_0297, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_029a, 1); pushd(eax);                             /* push eax */
            ii(0x1014_029b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_029e, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x1014_02a1, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1014_02a4, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_02a8, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_02ac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_02af, 5); calld(0x1014_00c4, -0x1f0);             /* call 0x101400c4 */
        l_0x1014_02b4:
            ii(0x1014_02b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_02b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_02b7, 1); popd(edi);                              /* pop edi */
            ii(0x1014_02b8, 1); popd(esi);                              /* pop esi */
            ii(0x1014_02b9, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
