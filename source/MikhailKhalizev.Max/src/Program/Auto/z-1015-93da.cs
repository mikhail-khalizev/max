using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_93da-3242ce32")]
        public void Method_1015_93da()
        {
            ii(0x1015_93da, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_93df, 5); calld(Definitions.sys_check_available_stack_size, 0xc96e); /* call 0x10165d52 */
            ii(0x1015_93e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_93e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_93e6, 1); pushd(esi);                             /* push esi */
            ii(0x1015_93e7, 1); pushd(edi);                             /* push edi */
            ii(0x1015_93e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_93e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_93eb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_93f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_93f4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_93f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_93fa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_93fd, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_9402, 5); calld(0x100f_448c, -0x6_4f7b);          /* call 0x100f448c */
            ii(0x1015_9407, 5); calld(0x100f_fc13, -0x5_97f9);          /* call 0x100ffc13 */
            ii(0x1015_940c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_940f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_9413, 2); if(jnzd(0x1015_9424, 0xf)) goto l_0x1015_9424; /* jnz 0x10159424 */
            ii(0x1015_9415, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9418, 5); calld(0x100f_3f62, -0x6_54bb);          /* call 0x100f3f62 */
            ii(0x1015_941d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_941f, 5); calld(0x1010_0efe, -0x5_8526);          /* call 0x10100efe */
        l_0x1015_9424:
            ii(0x1015_9424, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9427, 5); calld(0x100d_4a9e, -0x8_498e);          /* call 0x100d4a9e */
            ii(0x1015_942c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_942e, 2); if(jzd(0x1015_943a, 0xa)) goto l_0x1015_943a; /* jz 0x1015943a */
            ii(0x1015_9430, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_9433, 5); calld(0x1010_19b8, -0x5_7a80);          /* call 0x101019b8 */
            ii(0x1015_9438, 2); jmpd(0x1015_9442, 0x8); goto l_0x1015_9442; /* jmp 0x10159442 */
        l_0x1015_943a:
            ii(0x1015_943a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_943d, 5); calld(0x100f_fa70, -0x5_99d2);          /* call 0x100ffa70 */
        l_0x1015_9442:
            ii(0x1015_9442, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9444, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9445, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9446, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9447, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9448, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9449, 1); retd(); return;                         /* ret */
        }
    }
}
