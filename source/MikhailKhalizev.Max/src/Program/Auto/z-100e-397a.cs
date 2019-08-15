using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c0d9e788-af83-4f2a-bdf9-bb789312ed6b")]
        public void Method_100e_397a()
        {
            ii(0x100e_397a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_397f, 5); calld(Definitions.sys_check_available_stack_size, 0x8_23ce); /* call 0x10165d52 */
            ii(0x100e_3984, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_3985, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_3986, 1); pushd(esi);                             /* push esi */
            ii(0x100e_3987, 1); pushd(edi);                             /* push edi */
            ii(0x100e_3988, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_3989, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_398b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_3991, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_3994, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_3997, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_399a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_399d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_39a0, 4); mov(dx, memw_a32[ds, eax + 0x28]);      /* mov dx, [eax+0x28] */
            ii(0x100e_39a4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_39a7, 4); sub(memw_a32[ds, eax + 0x26], dx);      /* sub [eax+0x26], dx */
            ii(0x100e_39ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_39ae, 3); mov(eax, memd_a32[ds, eax + 0x24]);     /* mov eax, [eax+0x24] */
            ii(0x100e_39b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_39b4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_39b6, 2); if(jged(0x100e_39c1, 0x9)) goto l_0x100e_39c1; /* jge 0x100e39c1 */
            ii(0x100e_39b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_39bb, 6); mov(memw_a32[ds, eax + 0x26], 0);       /* mov word [eax+0x26], 0x0 */
        l_0x100e_39c1:
            ii(0x100e_39c1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_39c6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_39c9, 5); calld(0x100e_41e7, 0x819);              /* call 0x100e41e7 */
            ii(0x100e_39ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_39d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_39d1, 1); popd(edi);                              /* pop edi */
            ii(0x100e_39d2, 1); popd(esi);                              /* pop esi */
            ii(0x100e_39d3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_39d4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_39d5, 1); retd(); return;                         /* ret */
        }
    }
}
