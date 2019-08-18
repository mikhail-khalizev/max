using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5bb95965-6aa9-4b0c-9d93-4690210cb073")]
        public void /* sys */ sys_display_draw_1()
        {
            ii(0x1016_74a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_74a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_74aa, 1); pushd(esi);                             /* push esi */
            ii(0x1016_74ab, 1); pushd(edi);                             /* push edi */
            ii(0x1016_74ac, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_74af, 5); calld(/* sys */ 0x1016_7dac, 0x8f8);    /* call 0x10167dac */
            ii(0x1016_74b4, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_74bb, 2); if(jzd(0x1016_74f6, 0x39)) goto l_0x1016_74f6; /* jz 0x101674f6 */
            ii(0x1016_74bd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_74bf, 2); if(jzd(0x1016_74f6, 0x35)) goto l_0x1016_74f6; /* jz 0x101674f6 */
            ii(0x1016_74c1, 2); mov(ebx, memd_a32[ds, edx]);            /* mov ebx, [edx] */
            ii(0x1016_74c3, 3); mov(ecx, memd_a32[ds, eax + 0x8]);      /* mov ecx, [eax+0x8] */
            ii(0x1016_74c6, 2); add(ebx, ecx);                          /* add ebx, ecx */
            ii(0x1016_74c8, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1016_74cb, 3); mov(ebx, memd_a32[ds, edx + 0x4]);      /* mov ebx, [edx+0x4] */
            ii(0x1016_74ce, 3); mov(esi, memd_a32[ds, eax + 0xc]);      /* mov esi, [eax+0xc] */
            ii(0x1016_74d1, 2); add(ebx, esi);                          /* add ebx, esi */
            ii(0x1016_74d3, 4); mov(memd_a32[ss, esp + 0x4], ebx);      /* mov [esp+0x4], ebx */
            ii(0x1016_74d7, 3); mov(ebx, memd_a32[ds, edx + 0x8]);      /* mov ebx, [edx+0x8] */
            ii(0x1016_74da, 3); mov(edi, memd_a32[ds, eax + 0x8]);      /* mov edi, [eax+0x8] */
            ii(0x1016_74dd, 2); add(ebx, edi);                          /* add ebx, edi */
            ii(0x1016_74df, 4); mov(memd_a32[ss, esp + 0x8], ebx);      /* mov [esp+0x8], ebx */
            ii(0x1016_74e3, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x1016_74e6, 3); add(edx, memd_a32[ds, eax + 0xc]);      /* add edx, [eax+0xc] */
            ii(0x1016_74e9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_74eb, 4); mov(memd_a32[ss, esp + 0xc], edx);      /* mov [esp+0xc], edx */
            ii(0x1016_74ef, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_74f1, 5); calld(/* sys */ 0x1016_7500, 0xa);      /* call 0x10167500 */
        l_0x1016_74f6:
            ii(0x1016_74f6, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_74f9, 1); popd(edi);                              /* pop edi */
            ii(0x1016_74fa, 1); popd(esi);                              /* pop esi */
            ii(0x1016_74fb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_74fc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_74fd, 1); retd(); return;                         /* ret */
        }
    }
}
