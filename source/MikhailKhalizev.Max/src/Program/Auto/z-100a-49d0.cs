using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d04e981-20e9-4d63-ad58-cab551ae1c3c")]
        public void Method_100a_49d0()
        {
            ii(0x100a_49d0, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100a_49d5, 5); calld(Definitions.sys_check_available_stack_size, 0xc_1378); /* call 0x10165d52 */
            ii(0x100a_49da, 1); pushd(esi);                             /* push esi */
            ii(0x100a_49db, 1); pushd(edi);                             /* push edi */
            ii(0x100a_49dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_49dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_49df, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100a_49e5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_49e8, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_49eb, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_49ee, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100a_49f1, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100a_49f4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_49f7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_49fa, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_49fd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_4a00, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100a_4a03, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_4a06, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_4a0a, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100a_4a0e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_4a11, 5); calld(0x100a_4583, -0x493);             /* call 0x100a4583 */
            ii(0x100a_4a16, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4a18, 2); if(jzd(0x100a_4a6b, 0x51)) goto l_0x100a_4a6b; /* jz 0x100a4a6b */
            ii(0x100a_4a1a, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100a_4a1f, 5); calld(Definitions.sys_new, 0xc_13dc);   /* call 0x10165e00 */
            ii(0x100a_4a24, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_4a27, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_4a2a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_4a2d, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100a_4a31, 2); if(jzd(0x100a_4a5a, 0x27)) goto l_0x100a_4a5a; /* jz 0x100a4a5a */
            ii(0x100a_4a33, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_4a36, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_4a39, 5); calld(0x1007_5e64, -0x2_ebda);          /* call 0x10075e64 */
            ii(0x100a_4a3e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_4a40, 3); mov(ebx, memd_a32[ss, ebp + 0x10]);     /* mov ebx, [ebp+0x10] */
            ii(0x100a_4a43, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100a_4a47, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_4a4a, 5); calld(0x1009_87c5, -0xc28a);            /* call 0x100987c5 */
            ii(0x100a_4a4f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_4a52, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_4a55, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_4a58, 2); jmpd(0x100a_4a60, 0x6); goto l_0x100a_4a60; /* jmp 0x100a4a60 */
        l_0x100a_4a5a:
            ii(0x100a_4a5a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_4a5d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100a_4a60:
            ii(0x100a_4a60, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100a_4a63, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_4a66, 5); calld(0x100a_4d50, 0x2e5);              /* call 0x100a4d50 */
        l_0x100a_4a6b:
            ii(0x100a_4a6b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_4a6d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_4a6e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_4a6f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_4a70, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
