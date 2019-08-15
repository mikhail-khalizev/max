using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1ec699a8-4e09-4f4a-9afb-91cd9538100c")]
        public void Method_1008_076d()
        {
            ii(0x1008_076d, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1008_0772, 5); calld(Definitions.sys_check_available_stack_size, 0xe_55db); /* call 0x10165d52 */
            ii(0x1008_0777, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_0778, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_0779, 1); pushd(esi);                             /* push esi */
            ii(0x1008_077a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_077b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_077c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_077e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_0784, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_0787, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_078a, 5); mov(ecx, 0x1a00);                       /* mov ecx, 0x1a00 */
            ii(0x1008_078f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_0791, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1008_0795, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_0798, 5); calld(0x100a_26d1, 0x2_1f34);           /* call 0x100a26d1 */
            ii(0x1008_079d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_07a0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_07a3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_07a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_07a9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_07ac, 5); calld(Definitions.my_ctor_0x101b_56fc, 0x84cb); /* call 0x10088c7c */
            ii(0x1008_07b1, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_07b4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_07b7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_07ba, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_07bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_07c0, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_3cd0); /* mov dword [eax+0x2], 0x101b3cd0 */
            ii(0x1008_07c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_07ca, 6); mov(memw_a32[ds, eax + 0x1d], 0);       /* mov word [eax+0x1d], 0x0 */
            ii(0x1008_07d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_07d3, 6); mov(memw_a32[ds, eax + 0x1f], 0);       /* mov word [eax+0x1f], 0x0 */
            ii(0x1008_07d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_07dc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_07df, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_07e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_07e4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_07e5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_07e6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_07e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_07e8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_07e9, 1); retd(); return;                         /* ret */
        }
    }
}
