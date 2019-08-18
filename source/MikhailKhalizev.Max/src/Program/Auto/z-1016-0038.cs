using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9e4ed075-cd7b-4859-929f-dfe0389a09e1")]
        public void Method_1016_0038()
        {
            ii(0x1016_0038, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x1016_003d, 5); calld(Definitions.sys_check_available_stack_size, 0x5d10); /* call 0x10165d52 */
            ii(0x1016_0042, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_0043, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_0044, 1); pushd(edx);                             /* push edx */
            ii(0x1016_0045, 1); pushd(esi);                             /* push esi */
            ii(0x1016_0046, 1); pushd(edi);                             /* push edi */
            ii(0x1016_0047, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_0048, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_004a, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1016_0050, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_0053, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_0056, 4); mov(ax, memw_a32[ds, eax + 0x41]);      /* mov ax, [eax+0x41] */
            ii(0x1016_005a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_005d, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x1016_0061, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_0064, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_0067, 4); mov(ax, memw_a32[ds, eax + 0x43]);      /* mov ax, [eax+0x43] */
            ii(0x1016_006b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_006e, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x1016_0072, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_0075, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1016_0079, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1016_007d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1016_0080, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_0082, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1016_0086, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1016_008a, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_008d, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_008f, 3); mov(memd_a32[ss, ebp - 0x24], ebx);     /* mov [ebp-0x24], ebx */
            ii(0x1016_0092, 3); fild(memd_a32[ss, ebp - 0x24]);         /* fild dword [ebp-0x24] */
            ii(0x1016_0095, 5); calld(Definitions.sys_sqrt, 0x5fac);    /* call 0x10166046 */
            ii(0x1016_009a, 6); fmul(memq_a32[ds, 0x101b_28d2]);        /* fmul qword [0x101b28d2] */
            ii(0x1016_00a0, 6); fadd(memq_a32[ds, 0x101b_28da]);        /* fadd qword [0x101b28da] */
            ii(0x1016_00a6, 5); calld(Definitions.sys_round, 0x5fd3);   /* call 0x1016607e */
            ii(0x1016_00ab, 3); fistp(memd_a32[ss, ebp - 0x24]);        /* fistp dword [ebp-0x24] */
            ii(0x1016_00ae, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1016_00b1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_00b4, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1016_00b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_00ba, 2); if(jgd(0x1016_00c5, 0x9)) goto l_0x1016_00c5; /* jg 0x101600c5 */
            ii(0x1016_00bc, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1016_00c3, 2); jmpd(0x1016_012f, 0x6a); goto l_0x1016_012f; /* jmp 0x1016012f */
        l_0x1016_00c5:
            ii(0x1016_00c5, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1016_00ca, 5); calld(Definitions.sys_new, 0x5d31);     /* call 0x10165e00 */
            ii(0x1016_00cf, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1016_00d2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1016_00d5, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1016_00d8, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1016_00dc, 2); if(jzd(0x1016_0123, 0x45)) goto l_0x1016_0123; /* jz 0x10160123 */
            ii(0x1016_00de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_00e1, 3); mov(eax, memd_a32[ds, eax + 0x41]);     /* mov eax, [eax+0x41] */
            ii(0x1016_00e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_00e7, 1); pushd(eax);                             /* push eax */
            ii(0x1016_00e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_00eb, 3); mov(eax, memd_a32[ds, eax + 0x3f]);     /* mov eax, [eax+0x3f] */
            ii(0x1016_00ee, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_00f1, 1); pushd(eax);                             /* push eax */
            ii(0x1016_00f2, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1016_00f6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_00f8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_00fb, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1016_00fe, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1016_0100, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1016_0103, 1); cwde();                                 /* cwde */
            ii(0x1016_0104, 1); pushd(eax);                             /* push eax */
            ii(0x1016_0105, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1016_0109, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1016_010d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_0110, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1016_0113, 5); calld(0x1011_833b, -0x4_7ddd);          /* call 0x1011833b */
            ii(0x1016_0118, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1016_011b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1016_011e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1016_0121, 2); jmpd(0x1016_0129, 0x6); goto l_0x1016_0129; /* jmp 0x10160129 */
        l_0x1016_0123:
            ii(0x1016_0123, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1016_0126, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1016_0129:
            ii(0x1016_0129, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1016_012c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1016_012f:
            ii(0x1016_012f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1016_0132, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_0134, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_0135, 1); popd(edi);                              /* pop edi */
            ii(0x1016_0136, 1); popd(esi);                              /* pop esi */
            ii(0x1016_0137, 1); popd(edx);                              /* pop edx */
            ii(0x1016_0138, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_0139, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_013a, 1); retd(); return;                         /* ret */
        }
    }
}
