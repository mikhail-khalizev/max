using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_911b-1b71e058")]
        public void Method_100f_911b()
        {
            ii(0x100f_911b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_9120, 5); calld(Definitions.sys_check_available_stack_size, 0x6_cc2d); /* call 0x10165d52 */
            ii(0x100f_9125, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_9126, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_9127, 1); pushd(esi);                             /* push esi */
            ii(0x100f_9128, 1); pushd(edi);                             /* push edi */
            ii(0x100f_9129, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_912a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_912c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_9132, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_9135, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_9138, 5); calld(0x1007_6034, -0x8_3109);          /* call 0x10076034 */
            ii(0x100f_913d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_913f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_9141, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9144, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100f_9147, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_914a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_914d, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100f_9150, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9153, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_9156, 5); calld(0x1007_4c30, -0x8_452b);          /* call 0x10074c30 */
            ii(0x100f_915b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_915e, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_9162, 2); if(jzd(0x100f_91c3, 0x5f)) goto l_0x100f_91c3; /* jz 0x100f91c3 */
            ii(0x100f_9164, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_9167, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100f_916a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_916f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_9171, 2); if(jnzd(0x100f_9195, 0x22)) goto l_0x100f_9195; /* jnz 0x100f9195 */
            ii(0x100f_9173, 5); calld(0x100c_aa00, -0x2_e778);          /* call 0x100caa00 */
            ii(0x100f_9178, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_917d, 1); pushd(eax);                             /* push eax */
            ii(0x100f_917e, 5); calld(0x100c_aa20, -0x2_e763);          /* call 0x100caa20 */
            ii(0x100f_9183, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_9185, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9187, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9189, 5); mov(eax, StringDefinitions.InfiltratorHasAlreadyUsedHisActionThisTurnTryAgainNextTurn); /* mov eax, 0x101a27e7 */
            ii(0x100f_918e, 5); calld(0x1011_5d23, 0x1_cb90);           /* call 0x10115d23 */
            ii(0x100f_9193, 2); jmpd(0x100f_91c3, 0x2e); goto l_0x100f_91c3; /* jmp 0x100f91c3 */
        l_0x100f_9195:
            ii(0x100f_9195, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_9198, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_919b, 5); calld(0x1008_a998, -0x6_e808);          /* call 0x1008a998 */
            ii(0x100f_91a0, 5); calld(/* sys */ 0x1016_5e9b, 0x6_ccf6); /* call 0x10165e9b */
            ii(0x100f_91a5, 3); imul(eax, eax, 0x65);                   /* imul eax, eax, 0x65 */
            ii(0x100f_91a8, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_91ab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_91ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_91b0, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100f_91b4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_91b6, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x100f_91bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_91be, 5); calld(0x1016_3053, 0x6_9e90);           /* call 0x10163053 */
        l_0x100f_91c3:
            ii(0x100f_91c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_91c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_91c6, 1); popd(edi);                              /* pop edi */
            ii(0x100f_91c7, 1); popd(esi);                              /* pop esi */
            ii(0x100f_91c8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_91c9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_91ca, 1); retd(); return;                         /* ret */
        }
    }
}
