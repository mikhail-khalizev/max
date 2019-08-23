using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9918-da374c3f")]
        public void my_ctor_c5()
        {
            ii(0x1009_9918, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1009_991d, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c430); /* call 0x10165d52 */
            ii(0x1009_9922, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9923, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9924, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9925, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9926, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9927, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9929, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_992f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9932, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_9935, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9938, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_993b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_993e, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_9941, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_9944, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1009_9947, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_994a, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_994d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9950, 5); calld(0x1008_ad90, -0xebc5);            /* call 0x1008ad90 */
            ii(0x1009_9955, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_9958, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_995b, 5); calld(0x100a_26d1, 0x8d71);             /* call 0x100a26d1 */
            ii(0x1009_9960, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9963, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9966, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_9969, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_996c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_996f, 5); calld(0x1009_c484, 0x2b10);             /* call 0x1009c484 */
            ii(0x1009_9974, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_9977, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_997a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_997d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_9980, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_9983, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4490); /* mov dword [eax+0x2], 0x101b4490 */
            ii(0x1009_998a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_998d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_9990, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9993, 5); calld(0x1009_c44c, 0x2ab4);             /* call 0x1009c44c */
            ii(0x1009_9998, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_999b, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_999e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_99a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_99a3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_99a4, 1); popd(edi);                              /* pop edi */
            ii(0x1009_99a5, 1); popd(esi);                              /* pop esi */
            ii(0x1009_99a6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_99a7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_99a8, 1); retd();                                 /* ret */
        }
    }
}
