using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76a3ac6a-af7e-48a8-8f6d-46a0cac03bd9")]
        public void Method_1007_963b()
        {
            ii(0x1007_963b, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_9640, 5); calld(Definitions.sys_check_available_stack_size, 0xe_c70d); /* call 0x10165d52 */
            ii(0x1007_9645, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_9646, 1); pushd(esi);                             /* push esi */
            ii(0x1007_9647, 1); pushd(edi);                             /* push edi */
            ii(0x1007_9648, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_9649, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_964b, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_9651, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_9654, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_9657, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1007_965a, 5); mov(ecx, 0x2600);                       /* mov ecx, 0x2600 */
            ii(0x1007_965f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_9661, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_9665, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_9668, 5); calld(0x100a_26d1, 0x2_9064);           /* call 0x100a26d1 */
            ii(0x1007_966d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_9670, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_9673, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_9676, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_9679, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_967c, 5); calld(Definitions.my_ctor_0x101b56fc, 0xf5fb); /* call 0x10088c7c */
            ii(0x1007_9681, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1007_9684, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_9687, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_968a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_968d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_9690, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1007_9693, 5); calld(Definitions.my_ctor_0x101b4184, -0x2ba8); /* call 0x10076af0 */
            ii(0x1007_9698, 3); sub(eax, 0x1d);                         /* sub eax, 0x1d */
            ii(0x1007_969b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_969e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_96a1, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_3f70); /* mov dword [eax+0x2], 0x101b3f70 */
            ii(0x1007_96a8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_96ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_96ae, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1007_96b1, 5); calld(0x1008_8b44, 0xf48e);             /* call 0x10088b44 */
            ii(0x1007_96b6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_96b9, 6); mov(memw_a32[ds, eax + 0x21], 0);       /* mov word [eax+0x21], 0x0 */
            ii(0x1007_96bf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_96c2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_96c5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_96c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_96ca, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_96cb, 1); popd(edi);                              /* pop edi */
            ii(0x1007_96cc, 1); popd(esi);                              /* pop esi */
            ii(0x1007_96cd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_96ce, 1); retd(); return;                         /* ret */
        }
    }
}
