using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d145-3ce7d88b")]
        public void my_ctor_0x101b_3acc()
        {
            ii(0x1007_d145, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1007_d14a, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8c03); /* call 0x10165d52 */
            ii(0x1007_d14f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_d150, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_d151, 1); pushd(edx);                             /* push edx */
            ii(0x1007_d152, 1); pushd(esi);                             /* push esi */
            ii(0x1007_d153, 1); pushd(edi);                             /* push edi */
            ii(0x1007_d154, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_d155, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d157, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_d15d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_d160, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d163, 5); calld(Definitions.my_ctor_0x101b_56fc, 0xbb14); /* call 0x10088c7c */
            ii(0x1007_d168, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_d16b, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1007_d16e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_d171, 5); calld(0x1008_a4fc, 0xd386);             /* call 0x1008a4fc */
            ii(0x1007_d176, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_d179, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d17c, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1007_d17f, 5); calld(0x100b_84c2, 0x3_b33e);           /* call 0x100b84c2 */
            ii(0x1007_d184, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1007_d187, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_d18a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1007_d18d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_d190, 5); calld(0x1008_b3ec, 0xe257);             /* call 0x1008b3ec */
            ii(0x1007_d195, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_d198, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d19b, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d19e, 5); calld(0x1008_b1e4, 0xe041);             /* call 0x1008b1e4 */
            ii(0x1007_d1a3, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1007_d1a6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_d1a9, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1007_d1ac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_d1af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d1b2, 6); mov(memw_a32[ds, eax + 0x14], 0x1);     /* mov word [eax+0x14], 0x1 */
            ii(0x1007_d1b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d1bb, 6); mov(memw_a32[ds, eax + 0x12], 0);       /* mov word [eax+0x12], 0x0 */
            ii(0x1007_d1c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d1c4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_d1c7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_d1ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d1cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d1cd, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d1ce, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d1cf, 1); popd(edx);                              /* pop edx */
            ii(0x1007_d1d0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d1d1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_d1d2, 1); retd();                                 /* ret */
        }
    }
}
