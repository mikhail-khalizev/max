using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("df9157e0-56bf-412e-b533-e21d5a2e087f")]
        public void Method_1010_d3a0()
        {
            ii(0x1010_d3a0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_d3a5, 5); calld(Definitions.sys_check_available_stack_size, 0x5_89a8); /* call 0x10165d52 */
            ii(0x1010_d3aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_d3ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_d3ac, 1); pushd(edx);                             /* push edx */
            ii(0x1010_d3ad, 1); pushd(esi);                             /* push esi */
            ii(0x1010_d3ae, 1); pushd(edi);                             /* push edi */
            ii(0x1010_d3af, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_d3b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d3b2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_d3b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_d3bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d3be, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1010_d3c2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_d3c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_d3c8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_d3cb, 4); cmp(ax, memw_a32[ds, edx + 0xe]);       /* cmp ax, [edx+0xe] */
            ii(0x1010_d3cf, 2); if(jged(0x1010_d3fe, 0x2d)) goto l_0x1010_d3fe; /* jge 0x1010d3fe */
            ii(0x1010_d3d1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_d3d4, 3); mov(edx, memd_a32[ds, edx + 0xa]);      /* mov edx, [edx+0xa] */
            ii(0x1010_d3d7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_d3da, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_d3df, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_d3e1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_d3e4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_d3e6, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1010_d3e9, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_d3ed, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_d3ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d3f2, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1010_d3f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_d3f9, 5); calld(0x1010_cca5, -0x759);             /* call 0x1010cca5 */
        l_0x1010_d3fe:
            ii(0x1010_d3fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d400, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_d401, 1); popd(edi);                              /* pop edi */
            ii(0x1010_d402, 1); popd(esi);                              /* pop esi */
            ii(0x1010_d403, 1); popd(edx);                              /* pop edx */
            ii(0x1010_d404, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_d405, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_d406, 1); retd(); return;                         /* ret */
        }
    }
}
