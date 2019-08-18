using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1733-724c6ae")]
        public void my_strobj_ctor_capaticy()
        {
            ii(0x1014_1733, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_1738, 5); calld(Definitions.sys_check_available_stack_size, 0x2_4615); /* call 0x10165d52 */
            ii(0x1014_173d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_173e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_173f, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1740, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1741, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1742, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1744, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_174a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_174d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_1750, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1753, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_1756, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x1014_175a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_175d, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1014_1760, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_1763, 1); inc(eax);                               /* inc eax */
            ii(0x1014_1764, 5); calld(Definitions.sys_new_arr, 0x2_48a7); /* call 0x10166010 */
            ii(0x1014_1769, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_176b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_176e, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1014_1770, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1773, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1775, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1014_1778, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_177b, 6); mov(memw_a32[ds, eax + 0x6], 0);        /* mov word [eax+0x6], 0x0 */
            ii(0x1014_1781, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1784, 7); mov(memd_a32[ds, eax + 0x8], 0x1);      /* mov dword [eax+0x8], 0x1 */
            ii(0x1014_178b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_178e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_1791, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1794, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1796, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1797, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1798, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1799, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_179a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_179b, 1); retd(); return;                         /* ret */
        }
    }
}
