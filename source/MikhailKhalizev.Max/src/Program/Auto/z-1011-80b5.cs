using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_80b5-f0ce3cd")]
        public void Method_1011_80b5()
        {
            ii(0x1011_80b5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_80ba, 5); calld(Definitions.sys_check_available_stack_size, 0x4_dc93); /* call 0x10165d52 */
            ii(0x1011_80bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_80c0, 1); pushd(esi);                             /* push esi */
            ii(0x1011_80c1, 1); pushd(edi);                             /* push edi */
            ii(0x1011_80c2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_80c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_80c5, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_80cb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_80ce, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_80d1, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_80d4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_80d7, 5); calld(0x1014_4ef4, 0x2_ce18);           /* call 0x10144ef4 */
            ii(0x1011_80dc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_80df, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_80e2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_80e5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_80e8, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_69b4); /* mov dword [eax+0x2], 0x101b69b4 */
            ii(0x1011_80ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_80f2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_80f5, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1011_80f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_80fc, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_80ff, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x1011_8103, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_8106, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_8109, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_810c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_810e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_810f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_8110, 1); popd(esi);                              /* pop esi */
            ii(0x1011_8111, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_8112, 1); retd();                                 /* ret */
        }
    }
}
