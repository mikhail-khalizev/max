using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d59243e-f64a-453f-8749-515413c3289a")]
        public void Method_100b_8505()
        {
            ii(0x100b_8505, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_850a, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d843); /* call 0x10165d52 */
            ii(0x100b_850f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8510, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8511, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8512, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8513, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8515, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_851b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_851e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_8521, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_8524, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_8526, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100b_8529, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_852c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_852f, 5); calld(0x100c_b3d0, 0x1_2e9c);           /* call 0x100cb3d0 */
            ii(0x100b_8534, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8537, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_853a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_853d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8540, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_8543, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_8546, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8548, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8549, 1); popd(edi);                              /* pop edi */
            ii(0x100b_854a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_854b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_854c, 1); retd(); return;                         /* ret */
        }
    }
}
