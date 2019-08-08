using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15d410d1-1740-422e-a724-305af9c6f1ce")]
        public void Method_1010_a26b()
        {
            ii(0x1010_a26b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_a270, 5); calld(Definitions.sys_check_available_stack_size, 0x5_badd); /* call 0x10165d52 */
            ii(0x1010_a275, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_a276, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_a277, 1); pushd(esi);                             /* push esi */
            ii(0x1010_a278, 1); pushd(edi);                             /* push edi */
            ii(0x1010_a279, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_a27a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a27c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_a282, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_a285, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_a288, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_a28b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_a28d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_a291, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_a294, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_a297, 6); mov(eax, memd_a32[ds, eax + 0x370]);    /* mov eax, [eax+0x370] */
            ii(0x1010_a29d, 5); calld(0x100d_7f6c, -0x3_2336);          /* call 0x100d7f6c */
            ii(0x1010_a2a2, 5); calld(0x1011_5318, 0xb071);             /* call 0x10115318 */
            ii(0x1010_a2a7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_a2ac, 1); pushd(eax);                             /* push eax */
            ii(0x1010_a2ad, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_a2b2, 5); mov(ebx, 0x1_0002);                     /* mov ebx, 0x10002 */
            ii(0x1010_a2b7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_a2bb, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_a2be, 5); mov(edx, 0x101b_a5ac);                  /* mov edx, 0x101ba5ac */
            ii(0x1010_a2c3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_a2c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_a2c8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a2ca, 5); calld(0x1010_8a05, -0x18ca);            /* call 0x10108a05 */
            ii(0x1010_a2cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_a2d1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_a2d2, 1); popd(edi);                              /* pop edi */
            ii(0x1010_a2d3, 1); popd(esi);                              /* pop esi */
            ii(0x1010_a2d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_a2d5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_a2d6, 1); retd(); return;                         /* ret */
        }
    }
}
