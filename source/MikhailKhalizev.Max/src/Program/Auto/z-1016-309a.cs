using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("41c46c6a-e073-40bb-bedc-eee5da1418b6")]
        public void Method_1016_309a()
        {
            ii(0x1016_309a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_309f, 5); calld(Definitions.sys_check_available_stack_size, 0x2cae); /* call 0x10165d52 */
            ii(0x1016_30a4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_30a5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_30a6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_30a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_30a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_30aa, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_30b0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_30b3, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1016_30b6, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1016_30b9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_30bc, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1016_30c0, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1016_30c4, 2); if(jnzd(0x1016_30d3, 0xd)) goto l_0x1016_30d3; /* jnz 0x101630d3 */
            ii(0x1016_30c6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_30c9, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1016_30cd, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1016_30d1, 2); if(jzd(0x1016_30f3, 0x20)) goto l_0x1016_30f3; /* jz 0x101630f3 */
        l_0x1016_30d3:
            ii(0x1016_30d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_30d6, 5); calld(0x1014_9fa8, -0x1_9133);          /* call 0x10149fa8 */
            ii(0x1016_30db, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1016_30df, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1016_30e3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_30e6, 5); calld(0x1015_bd55, -0x7396);            /* call 0x1015bd55 */
            ii(0x1016_30eb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_30ee, 5); calld(0x1014_9fa8, -0x1_914b);          /* call 0x10149fa8 */
        l_0x1016_30f3:
            ii(0x1016_30f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_30f5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_30f6, 1); popd(edi);                              /* pop edi */
            ii(0x1016_30f7, 1); popd(esi);                              /* pop esi */
            ii(0x1016_30f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_30f9, 1); retd(); return;                         /* ret */
        }
    }
}
