using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1816-99d6a791")]
        public void my_strobj_ctor_strobj()
        {
            ii(0x1014_1816, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_181b, 5); call(Definitions.sys_check_available_stack_size, 0x2_4532); /* call 0x10165d52 */
            ii(0x1014_1820, 1); push(ebx);                              /* push ebx */
            ii(0x1014_1821, 1); push(ecx);                              /* push ecx */
            ii(0x1014_1822, 1); push(esi);                              /* push esi */
            ii(0x1014_1823, 1); push(edi);                              /* push edi */
            ii(0x1014_1824, 1); push(ebp);                              /* push ebp */
            ii(0x1014_1825, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1827, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_182d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1830, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_1833, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1836, 5); call(Definitions.my_strobj_get_len, -0x5_6917); /* call 0x100eaf24 */
            ii(0x1014_183b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_183d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1840, 4); mov(memw[ds, eax + 6], dx);             /* mov [eax+0x6], dx */
            ii(0x1014_1844, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1847, 5); call(Definitions.my_strobj_get_size, 0xd10); /* call 0x1014255c */
            ii(0x1014_184c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_184e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1851, 4); mov(memw[ds, eax + 4], dx);             /* mov [eax+0x4], dx */
            ii(0x1014_1855, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1858, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x1014_185b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_185e, 1); inc(eax);                               /* inc eax */
            ii(0x1014_185f, 5); call(Definitions.sys_new_arr, 0x2_47ac); /* call 0x10166010 */
            ii(0x1014_1864, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_1866, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1869, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1014_186b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_186e, 5); call(Definitions.my_strobj_c_str, -0xb_8077); /* call 0x100897fc */
            ii(0x1014_1873, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_1875, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1878, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_187a, 5); call(Definitions.sys_strcpy, 0x2_4650); /* call 0x10165ecf */
            ii(0x1014_187f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1882, 7); mov(memd[ds, eax + 8], 1);              /* mov dword [eax+0x8], 0x1 */
            ii(0x1014_1889, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_188c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_188f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_1892, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1894, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_1895, 1); pop(edi);                               /* pop edi */
            ii(0x1014_1896, 1); pop(esi);                               /* pop esi */
            ii(0x1014_1897, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_1898, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_1899, 1); ret();                                  /* ret */
        }
    }
}
