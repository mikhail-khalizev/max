using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("525d843c-843c-4c02-b884-6d5abca5a878")]
        public void my_ctor_c11()
        {
            ii(0x100a_38c9, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_38ce, 5); calld(Definitions.sys_check_available_stack_size, 0xc_247f); /* call 0x10165d52 */
            ii(0x100a_38d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_38d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_38d5, 1); pushd(esi);                             /* push esi */
            ii(0x100a_38d6, 1); pushd(edi);                             /* push edi */
            ii(0x100a_38d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_38d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_38da, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_38e0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_38e3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_38e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_38e9, 5); calld(0x100a_a0b0, 0x67c2);             /* call 0x100aa0b0 */
            ii(0x100a_38ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_38f1, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_38f4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_38f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_38fa, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_38fd, 5); calld(Definitions.my_ctor_0x101b3b58, -0x1_885e); /* call 0x1008b0a4 */
            ii(0x100a_3902, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_3905, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3908, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_390b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_390e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3911, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f24); /* mov dword [eax+0x2], 0x101b4f24 */
            ii(0x100a_3918, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_391b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_391e, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3921, 5); calld(0x1008_afe4, -0x1_8942);          /* call 0x1008afe4 */
            ii(0x100a_3926, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_392b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_392e, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3931, 5); calld(0x1008_af28, -0x1_8a0e);          /* call 0x1008af28 */
            ii(0x100a_3936, 5); calld(0x100a_b1c8, 0x788d);             /* call 0x100ab1c8 */
            ii(0x100a_393b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_393e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_3941, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_3944, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3946, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3947, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3948, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3949, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_394a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_394b, 1); retd(); return;                         /* ret */
        }
    }
}
