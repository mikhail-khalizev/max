using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_179c-a95ecfd4")]
        public void my_strobj_ctor_char_ptr()
        {
            ii(0x1014_179c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_17a1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_45ac); /* call 0x10165d52 */
            ii(0x1014_17a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_17a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_17a8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_17a9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_17aa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_17ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_17ad, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_17b3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_17b6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_17b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_17bc, 5); calld(Definitions.sys_strlen, 0x3_0706); /* call 0x10171ec7 */
            ii(0x1014_17c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_17c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17c6, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1014_17ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17cd, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x1014_17d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17d4, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
            ii(0x1014_17d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17db, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1014_17de, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_17e1, 1); inc(eax);                               /* inc eax */
            ii(0x1014_17e2, 5); calld(Definitions.sys_new_arr, 0x2_4829); /* call 0x10166010 */
            ii(0x1014_17e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_17e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17ec, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1014_17ee, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_17f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17f4, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_17f6, 5); calld(Definitions.sys_strcpy, 0x2_46d4); /* call 0x10165ecf */
            ii(0x1014_17fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_17fe, 7); mov(memd_a32[ds, eax + 0x8], 0x1);      /* mov dword [eax+0x8], 0x1 */
            ii(0x1014_1805, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1808, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_180b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_180e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1810, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1811, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1812, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1813, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1814, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1815, 1); retd();                                 /* ret */
        }
    }
}
