using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_07fa-880cad82")]
        public void Method_1009_07fa()
        {
            ii(0x1009_07fa, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1009_07ff, 5); calld(Definitions.sys_check_available_stack_size, 0xd_554e); /* call 0x10165d52 */
            ii(0x1009_0804, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_0805, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_0806, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0807, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0808, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0809, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_080b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_0811, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_0814, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_0817, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_0819, 1); pushd(eax);                             /* push eax */
            ii(0x1009_081a, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_081f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0822, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0823, 6); mov(ecx, memd_a32[ds, 0x101c_8170]);    /* mov ecx, [0x101c8170] */
            ii(0x1009_0829, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_082c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_082e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0830, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_0833, 5); calld(0x1008_b148, -0x56f0);            /* call 0x1008b148 */
            ii(0x1009_0838, 3); pushd(memd_a32[ds, eax + 0xc]);         /* push dword [eax+0xc] */
            ii(0x1009_083b, 3); pushd(memd_a32[ds, eax + 0x8]);         /* push dword [eax+0x8] */
            ii(0x1009_083e, 3); pushd(memd_a32[ds, eax + 0x4]);         /* push dword [eax+0x4] */
            ii(0x1009_0841, 2); pushd(memd_a32[ds, eax]);               /* push dword [eax] */
            ii(0x1009_0843, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0846, 5); calld(0x1009_02f8, -0x553);             /* call 0x100902f8 */
            ii(0x1009_084b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_084e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0851, 7); mov(memd_a32[ds, eax + 0x23], 0x101b_4658); /* mov dword [eax+0x23], 0x101b4658 */
            ii(0x1009_0858, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_085b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_085e, 3); mov(memd_a32[ds, edx + 0x27], eax);     /* mov [edx+0x27], eax */
            ii(0x1009_0861, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0864, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_0867, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_086a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_086c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_086d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_086e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_086f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_0870, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_0871, 1); retd(); return;                         /* ret */
        }
    }
}
