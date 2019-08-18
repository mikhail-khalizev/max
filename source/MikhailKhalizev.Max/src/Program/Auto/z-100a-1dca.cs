using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bef58308-ef6f-4f2c-8527-6746563668a5")]
        public void Method_100a_1dca()
        {
            ii(0x100a_1dca, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_1dcf, 5); calld(Definitions.sys_check_available_stack_size, 0xc_3f7e); /* call 0x10165d52 */
            ii(0x100a_1dd4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_1dd5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_1dd6, 1); pushd(edx);                             /* push edx */
            ii(0x100a_1dd7, 1); pushd(esi);                             /* push esi */
            ii(0x100a_1dd8, 1); pushd(edi);                             /* push edi */
            ii(0x100a_1dd9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_1dda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1ddc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_1de2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_1de5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1de8, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100a_1deb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_1df0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1df2, 2); if(jnzd(0x100a_1e04, 0x10)) goto l_0x100a_1e04; /* jnz 0x100a1e04 */
            ii(0x100a_1df4, 5); mov(edx, StringDefinitions.AdjustmentsMade2); /* mov edx, 0x101a0b46 */
            ii(0x100a_1df9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1dfc, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_1dff, 5); calld(Definitions.sys_strcpy, 0xc_40cb); /* call 0x10165ecf */
        l_0x100a_1e04:
            ii(0x100a_1e04, 5); mov(eax, StringDefinitions.RawMaterialMiningIncreasedToI); /* mov eax, 0x101a0b59 */
            ii(0x100a_1e09, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1e0a, 5); mov(ecx, StringDefinitions.RawMaterialMiningReducedToI); /* mov ecx, 0x101a0b7f */
            ii(0x100a_1e0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e12, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x100a_1e15, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_1e18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e1b, 3); mov(edx, memd_a32[ds, eax + 0x1e]);     /* mov edx, [eax+0x1e] */
            ii(0x100a_1e1e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_1e21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e24, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_1e27, 5); calld(0x100a_1d41, -0xeb);              /* call 0x100a1d41 */
            ii(0x100a_1e2c, 5); mov(eax, StringDefinitions.FuelMiningIncreasedToI); /* mov eax, 0x101a0ba3 */
            ii(0x100a_1e31, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1e32, 5); mov(ecx, StringDefinitions.FuelMiningReducedToI); /* mov ecx, 0x101a0bc1 */
            ii(0x100a_1e37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e3a, 3); mov(ebx, memd_a32[ds, eax + 0x8]);      /* mov ebx, [eax+0x8] */
            ii(0x100a_1e3d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_1e40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e43, 3); mov(edx, memd_a32[ds, eax + 0x20]);     /* mov edx, [eax+0x20] */
            ii(0x100a_1e46, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_1e49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e4c, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_1e4f, 5); calld(0x100a_1d41, -0x113);             /* call 0x100a1d41 */
            ii(0x100a_1e54, 5); mov(eax, StringDefinitions.GoldMiningIncreasedToI); /* mov eax, 0x101a0bdd */
            ii(0x100a_1e59, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1e5a, 5); mov(eax, StringDefinitions.GoldMiningReducedToI); /* mov eax, 0x101a0bfb */
            ii(0x100a_1e5f, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100a_1e62, 3); mov(ebx, memd_a32[ds, ecx + 0x4]);      /* mov ebx, [ecx+0x4] */
            ii(0x100a_1e65, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_1e68, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_1e6b, 3); mov(edx, memd_a32[ds, edx + 0x1c]);     /* mov edx, [edx+0x1c] */
            ii(0x100a_1e6e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_1e71, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100a_1e74, 3); add(esi, 0x4d);                         /* add esi, 0x4d */
            ii(0x100a_1e77, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_1e79, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_1e7b, 5); calld(0x100a_1d41, -0x13f);             /* call 0x100a1d41 */
            ii(0x100a_1e80, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100a_1e85, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1e86, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_1e88, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_1e8a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_1e8f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1e92, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_1e95, 5); calld(0x1011_5d23, 0x7_3e89);           /* call 0x10115d23 */
            ii(0x100a_1e9a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_1e9c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_1e9d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_1e9e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_1e9f, 1); popd(edx);                              /* pop edx */
            ii(0x100a_1ea0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_1ea1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_1ea2, 1); retd(); return;                         /* ret */
        }
    }
}
