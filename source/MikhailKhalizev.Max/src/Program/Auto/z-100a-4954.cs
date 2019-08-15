using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a9c7d0a2-a3de-419b-b73d-f5ea322708ff")]
        public void Method_100a_4954()
        {
            ii(0x100a_4954, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_4959, 5); calld(Definitions.sys_check_available_stack_size, 0xc_13f4); /* call 0x10165d52 */
            ii(0x100a_495e, 1); pushd(esi);                             /* push esi */
            ii(0x100a_495f, 1); pushd(edi);                             /* push edi */
            ii(0x100a_4960, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_4961, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4963, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_4969, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_496c, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_496f, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_4972, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100a_4975, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100a_4978, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_497b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_497e, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_4981, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_4984, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100a_4987, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_498a, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_498e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100a_4992, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_4995, 5); calld(0x100a_4583, -0x417);             /* call 0x100a4583 */
            ii(0x100a_499a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_499c, 2); if(jzd(0x100a_49c8, 0x2a)) goto l_0x100a_49c8; /* jz 0x100a49c8 */
            ii(0x100a_499e, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x100a_49a1, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_49a4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_49a7, 5); calld(0x1007_5e64, -0x2_eb48);          /* call 0x10075e64 */
            ii(0x100a_49ac, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_49ae, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100a_49b2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_49b6, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x100a_49bc, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_49c1, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_49c3, 5); calld(0x100b_e5c2, 0x1_9bfa);           /* call 0x100be5c2 */
        l_0x100a_49c8:
            ii(0x100a_49c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_49ca, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_49cb, 1); popd(edi);                              /* pop edi */
            ii(0x100a_49cc, 1); popd(esi);                              /* pop esi */
            ii(0x100a_49cd, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
