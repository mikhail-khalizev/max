using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("75ac999d-950d-4d8c-aacb-732d871156fd")]
        public void Method_100e_39d6()
        {
            ii(0x100e_39d6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_39db, 5); calld(Definitions.sys_check_available_stack_size, 0x8_2372); /* call 0x10165d52 */
            ii(0x100e_39e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_39e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_39e2, 1); pushd(esi);                             /* push esi */
            ii(0x100e_39e3, 1); pushd(edi);                             /* push edi */
            ii(0x100e_39e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_39e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_39e7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_39ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_39f0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_39f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_39f6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_39f9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_39fc, 3); mov(edx, memd_a32[ds, eax + 0x24]);     /* mov edx, [eax+0x24] */
            ii(0x100e_39ff, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_3a02, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a05, 3); mov(eax, memd_a32[ds, eax + 0x26]);     /* mov eax, [eax+0x26] */
            ii(0x100e_3a08, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_3a0b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_3a0d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a10, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x100e_3a13, 5); calld(0x1007_6b90, -0x6_ce88);          /* call 0x10076b90 */
            ii(0x100e_3a18, 1); cwde();                                 /* cwde */
            ii(0x100e_3a19, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_3a1b, 2); if(jged(0x100e_3a38, 0x1b)) goto l_0x100e_3a38; /* jge 0x100e3a38 */
            ii(0x100e_3a1d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a20, 4); mov(dx, memw_a32[ds, eax + 0x28]);      /* mov dx, [eax+0x28] */
            ii(0x100e_3a24, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a27, 4); add(memw_a32[ds, eax + 0x26], dx);      /* add [eax+0x26], dx */
            ii(0x100e_3a2b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_3a30, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_3a33, 5); calld(0x100e_41e7, 0x7af);              /* call 0x100e41e7 */
        l_0x100e_3a38:
            ii(0x100e_3a38, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3a3a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_3a3b, 1); popd(edi);                              /* pop edi */
            ii(0x100e_3a3c, 1); popd(esi);                              /* pop esi */
            ii(0x100e_3a3d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_3a3e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_3a3f, 1); retd(); return;                         /* ret */
        }
    }
}