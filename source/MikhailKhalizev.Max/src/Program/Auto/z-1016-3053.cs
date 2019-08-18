using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3053-59d2a830")]
        public void Method_1016_3053()
        {
            ii(0x1016_3053, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_3058, 5); calld(Definitions.sys_check_available_stack_size, 0x2cf5); /* call 0x10165d52 */
            ii(0x1016_305d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_305e, 1); pushd(esi);                             /* push esi */
            ii(0x1016_305f, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3060, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3061, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3063, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_3069, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_306c, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x1016_306f, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1016_3072, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x1016_3076, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1016_307a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_307d, 5); calld(0x1016_2f96, -0xec);              /* call 0x10162f96 */
            ii(0x1016_3082, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1016_3089, 2); if(jzd(0x1016_3093, 0x8)) goto l_0x1016_3093; /* jz 0x10163093 */
            ii(0x1016_308b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_308e, 5); calld(0x1012_88e9, -0x3_a7aa);          /* call 0x101288e9 */
        l_0x1016_3093:
            ii(0x1016_3093, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3095, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3096, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3097, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3098, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3099, 1); retd(); return;                         /* ret */
        }
    }
}
