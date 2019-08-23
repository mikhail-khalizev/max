using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1814-772fcaa5")]
        public void Method_100b_1814()
        {
            ii(0x100b_1814, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_1819, 5); calld(Definitions.sys_check_available_stack_size, 0xb_4534); /* call 0x10165d52 */
            ii(0x100b_181e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_181f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_1820, 1); pushd(esi);                             /* push esi */
            ii(0x100b_1821, 1); pushd(edi);                             /* push edi */
            ii(0x100b_1822, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_1823, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1825, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_182b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_182e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_1831, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1834, 5); calld(0x100b_7d68, 0x652f);             /* call 0x100b7d68 */
            ii(0x100b_1839, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_183b, 2); if(jzd(0x100b_1865, 0x28)) goto l_0x100b_1865; /* jz 0x100b1865 */
            ii(0x100b_183d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1840, 5); calld(0x100b_7d68, 0x6523);             /* call 0x100b7d68 */
            ii(0x100b_1845, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_1849, 2); if(jzd(0x100b_1855, 0xa)) goto l_0x100b_1855; /* jz 0x100b1855 */
            ii(0x100b_184b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_184d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1850, 5); calld(0x100a_c66b, -0x51ea);            /* call 0x100ac66b */
        l_0x100b_1855:
            ii(0x100b_1855, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_1858, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_185b, 5); calld(0x100b_7d68, 0x6508);             /* call 0x100b7d68 */
            ii(0x100b_1860, 5); calld(0x1015_27b8, 0xa_0f53);           /* call 0x101527b8 */
        l_0x100b_1865:
            ii(0x100b_1865, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_1868, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_186b, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_186e, 5); calld(0x100b_7bac, 0x6339);             /* call 0x100b7bac */
            ii(0x100b_1873, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1875, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_1876, 1); popd(edi);                              /* pop edi */
            ii(0x100b_1877, 1); popd(esi);                              /* pop esi */
            ii(0x100b_1878, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_1879, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_187a, 1); retd();                                 /* ret */
        }
    }
}
