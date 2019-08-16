using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("35df1f46-3be2-4370-9075-d409f6fc9c34")]
        public void Method_100d_8a62()
        {
            ii(0x100d_8a62, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_8a67, 5); calld(Definitions.sys_check_available_stack_size, 0x8_d2e6); /* call 0x10165d52 */
            ii(0x100d_8a6c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_8a6d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_8a6e, 1); pushd(edx);                             /* push edx */
            ii(0x100d_8a6f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_8a70, 1); pushd(edi);                             /* push edi */
            ii(0x100d_8a71, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_8a72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8a74, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_8a7a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_8a7d, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_8a82, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100d_8a87, 5); calld(0x1013_dc59, 0x6_51cd);           /* call 0x1013dc59 */
            ii(0x100d_8a8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a8f, 4); cmp(memb_a32[ds, eax + 0xe], 0x9);      /* cmp byte [eax+0xe], 0x9 */
            ii(0x100d_8a93, 2); if(jnzd(0x100d_8aa7, 0x12)) goto l_0x100d_8aa7; /* jnz 0x100d8aa7 */
            ii(0x100d_8a95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8a98, 5); calld(0x100d_85c2, -0x4db);             /* call 0x100d85c2 */
            ii(0x100d_8a9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8a9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8aa2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_8aa4, 3); sub(memw_a32[ds, eax], dx);             /* sub [eax], dx */
        l_0x100d_8aa7:
            ii(0x100d_8aa7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8aaa, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100d_8aad, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_8ab0, 4); mov(dx, memw_a32[ds, edx + 0x13]);      /* mov dx, [edx+0x13] */
            ii(0x100d_8ab4, 3); sub(memw_a32[ds, eax], dx);             /* sub [eax], dx */
            ii(0x100d_8ab7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8aba, 4); cmp(memd_a32[ds, eax + 0x1b], 0);       /* cmp dword [eax+0x1b], 0x0 */
            ii(0x100d_8abe, 2); if(jzd(0x100d_8adc, 0x1c)) goto l_0x100d_8adc; /* jz 0x100d8adc */
            ii(0x100d_8ac0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8ac3, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100d_8ac6, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100d_8ac9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8acc, 5); calld(0x100d_8528, -0x5a9);             /* call 0x100d8528 */
            ii(0x100d_8ad1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8ad3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8ad6, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x100d_8ad9, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
        l_0x100d_8adc:
            ii(0x100d_8adc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8adf, 4); cmp(memb_a32[ds, eax + 0xe], 0x9);      /* cmp byte [eax+0xe], 0x9 */
            ii(0x100d_8ae3, 2); if(jzd(0x100d_8af7, 0x12)) goto l_0x100d_8af7; /* jz 0x100d8af7 */
            ii(0x100d_8ae5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8ae8, 5); calld(0x100d_85c2, -0x52b);             /* call 0x100d85c2 */
            ii(0x100d_8aed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8aef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8af2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_8af4, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
        l_0x100d_8af7:
            ii(0x100d_8af7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8af9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8afa, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8afb, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8afc, 1); popd(edx);                              /* pop edx */
            ii(0x100d_8afd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8afe, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8aff, 1); retd(); return;                         /* ret */
        }
    }
}