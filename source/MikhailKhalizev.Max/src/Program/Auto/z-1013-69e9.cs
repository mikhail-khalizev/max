using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("729ad387-f85e-4ad3-8267-68e8ebda0ef9")]
        public void Method_1013_69e9()
        {
            ii(0x1013_69e9, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1013_69ee, 5); calld(Definitions.sys_check_available_stack_size, 0x2_f35f); /* call 0x10165d52 */
            ii(0x1013_69f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_69f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_69f5, 1); pushd(esi);                             /* push esi */
            ii(0x1013_69f6, 1); pushd(edi);                             /* push edi */
            ii(0x1013_69f7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_69f8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_69fa, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_6a00, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_6a03, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_6a06, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_6a0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6a0d, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_6a10, 5); calld(0x100d_6f2d, -0x5_fae8);          /* call 0x100d6f2d */
            ii(0x1013_6a15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6a18, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_6a1b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_6a1e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_6a21, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x1013_6a24, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_6a27, 3); calld_abs(memd_a32[ds, edx + 0x8]);     /* call dword [edx+0x8] */
            ii(0x1013_6a2a, 4); imul(edx, memd_a32[ss, ebp - 0x4], 0x70); /* imul edx, [ebp-0x4], 0x70 */
            ii(0x1013_6a2e, 5); mov(ebx, 0x4b);                         /* mov ebx, 0x4b */
            ii(0x1013_6a33, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_6a35, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_6a38, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_6a3a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_6a3d, 4); cmp(memd_a32[ss, ebp - 0xc], 0x70);     /* cmp dword [ebp-0xc], 0x70 */
            ii(0x1013_6a41, 2); if(jled(0x1013_6a4a, 0x7)) goto l_0x1013_6a4a; /* jle 0x10136a4a */
            ii(0x1013_6a43, 7); mov(memd_a32[ss, ebp - 0xc], 0x70);     /* mov dword [ebp-0xc], 0x70 */
        l_0x1013_6a4a:
            ii(0x1013_6a4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6a4d, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x1013_6a50, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_6a53, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6a54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6a57, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x1013_6a5a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_6a5d, 3); imul(edx, eax, 0x15);                   /* imul edx, eax, 0x15 */
            ii(0x1013_6a60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6a63, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1013_6a66, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_6a68, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x1013_6a6b, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6a6c, 2); pushd(0x70);                            /* push 0x70 */
            ii(0x1013_6a6e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_6a71, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6a72, 2); pushd(0x70);                            /* push 0x70 */
            ii(0x1013_6a74, 6); pushd(memd_a32[ds, 0x101c_70e0]);       /* push dword [0x101c70e0] */
            ii(0x1013_6a7a, 5); calld(/* sys */ 0x1016_abbc, 0x3_413d); /* call 0x1016abbc */
            ii(0x1013_6a7f, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1013_6a82, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6a85, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1013_6a88, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6a8b, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1013_6a8e, 5); calld(Definitions.sys_display_draw_1, 0x3_0a15); /* call 0x101674a8 */
            ii(0x1013_6a93, 5); calld(/* sys */ 0x1016_b258, 0x3_47c0); /* call 0x1016b258 */
            ii(0x1013_6a98, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6a9a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6a9b, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6a9c, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6a9d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6a9e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6a9f, 1); retd(); return;                         /* ret */
        }
    }
}
