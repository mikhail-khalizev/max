using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8794-a5e16af4")]
        public void Method_1010_8794()
        {
            ii(0x1010_8794, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_8799, 5); calld(Definitions.sys_check_available_stack_size, 0x5_d5b4); /* call 0x10165d52 */
            ii(0x1010_879e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_879f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_87a0, 1); pushd(esi);                             /* push esi */
            ii(0x1010_87a1, 1); pushd(edi);                             /* push edi */
            ii(0x1010_87a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_87a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_87a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_87ab, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_87ae, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_87b1, 5); calld(0x100d_533c, -0x3_347a);          /* call 0x100d533c */
            ii(0x1010_87b6, 1); cwde();                                 /* cwde */
            ii(0x1010_87b7, 1); pushd(eax);                             /* push eax */
            ii(0x1010_87b8, 5); calld(0x100d_5360, -0x3_345d);          /* call 0x100d5360 */
            ii(0x1010_87bd, 1); cwde();                                 /* cwde */
            ii(0x1010_87be, 1); pushd(eax);                             /* push eax */
            ii(0x1010_87bf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_87c1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_87c2, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_87c7, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1010_87cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_87ce, 5); calld(0x100e_883d, -0x1_ff96);          /* call 0x100e883d */
            ii(0x1010_87d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_87d5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_87d9, 5); calld(0x100e_8c51, -0x1_fb8d);          /* call 0x100e8c51 */
            ii(0x1010_87de, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1010_87e1, 2); if(jzd(0x1010_8836, 0x53)) goto l_0x1010_8836; /* jz 0x10108836 */
            ii(0x1010_87e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_87e5, 5); calld(0x1012_0d94, 0x1_85aa);           /* call 0x10120d94 */
            ii(0x1010_87ea, 5); calld(/* sys */ 0x1016_bcc4, 0x6_34d5); /* call 0x1016bcc4 */
            ii(0x1010_87ef, 5); mov(eax, memd_a32[ds, 0x101c_365c]);    /* mov eax, [0x101c365c] */
            ii(0x1010_87f4, 5); calld(Definitions.sys_display_apply_palette, 0x6_43c3); /* call 0x1016cbbc */
            ii(0x1010_87f9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_87fb, 5); calld(0x100e_883d, -0x1_ffc3);          /* call 0x100e883d */
            ii(0x1010_8800, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_8803, 5); calld(Definitions.sys_display_draw_0, 0x5_ec7c); /* call 0x10167484 */
            ii(0x1010_8808, 5); mov(eax, 0x1f4);                        /* mov eax, 0x1f4 */
            ii(0x1010_880d, 5); calld(0x100e_9399, -0x1_f479);          /* call 0x100e9399 */
            ii(0x1010_8812, 5); calld(0x1014_82f4, 0x3_fadd);           /* call 0x101482f4 */
            ii(0x1010_8817, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1010_881a:
            ii(0x1010_881a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_881d, 5); calld(0x1014_85ad, 0x3_fd8b);           /* call 0x101485ad */
            ii(0x1010_8822, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1010_8825, 2); if(jaed(0x1010_8831, 0xa)) goto l_0x1010_8831; /* jae 0x10108831 */
            ii(0x1010_8827, 5); calld(/* sys */ 0x1016_b208, 0x6_29dc); /* call 0x1016b208 */
            ii(0x1010_882c, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1010_882f, 2); if(jzd(0x1010_881a, -0x17)) goto l_0x1010_881a; /* jz 0x1010881a */
        l_0x1010_8831:
            ii(0x1010_8831, 5); calld(0x100e_88bd, -0x1_ff79);          /* call 0x100e88bd */
        l_0x1010_8836:
            ii(0x1010_8836, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8838, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8839, 1); popd(edi);                              /* pop edi */
            ii(0x1010_883a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_883b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_883c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_883d, 1); retd(); return;                         /* ret */
        }
    }
}
