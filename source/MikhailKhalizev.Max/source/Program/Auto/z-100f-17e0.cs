using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_17e0-2013a538")]
        public void Method_100f_17e0()
        {
            ii(0x100f_17e0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_17e5, 5);  call(Definitions.sys_check_available_stack_size, 0x7_4568);/* call 0x10165d52 */
            ii(0x100f_17ea, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_17eb, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_17ec, 1);  push(esi);                            /* push esi */
            ii(0x100f_17ed, 1);  push(edi);                            /* push edi */
            ii(0x100f_17ee, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_17ef, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_17f1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100f_17f7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_17fa, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_17fd, 5);  call(0x1010_2b60, 0x1_135e);          /* call 0x10102b60 */
            ii(0x100f_1802, 1);  push(eax);                            /* push eax */
            ii(0x100f_1803, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100f_1808, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_180b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_180d, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_1811, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_1814, 2);  sub(eax, ebx);                        /* sub eax, ebx */
            ii(0x100f_1816, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100f_1818, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_181b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_181d, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_181f, 5);  mov(eax, 0x307);                      /* mov eax, 0x307 */
            ii(0x100f_1824, 5);  call(0x100e_8ef1, -0x8938);           /* call 0x100e8ef1 */
            ii(0x100f_1829, 5);  call(0x1010_2b60, 0x1_1332);          /* call 0x10102b60 */
            ii(0x100f_182e, 1);  push(eax);                            /* push eax */
            ii(0x100f_182f, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100f_1834, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1837, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_183a, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_183e, 3);  add(ebx, memd[ds, eax + 4]);          /* add ebx, [eax+0x4] */
            ii(0x100f_1841, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1844, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_1847, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1849, 5);  mov(eax, 0x308);                      /* mov eax, 0x308 */
            ii(0x100f_184e, 5);  call(0x100e_8ef1, -0x8962);           /* call 0x100e8ef1 */
            ii(0x100f_1853, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1856, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1858, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_185b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_185d, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_1860, 5);  call(Definitions.sys_display_draw_1, 0x7_5c43);/* call 0x101674a8 */
            ii(0x100f_1865, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1868, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_186b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_186e, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_1871, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_1874, 5);  call(Definitions.sys_display_draw_1, 0x7_5c2f);/* call 0x101674a8 */
            ii(0x100f_1879, 5);  call(/* sys */ 0x1016_b258, 0x7_99da);/* call 0x1016b258 */
        l_0x100f_187e:
            ii(0x100f_187e, 5);  call(0x1014_82f4, 0x5_6a71);          /* call 0x101482f4 */
            ii(0x100f_1883, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_1885, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1888, 3);  sub(edx, memd[ds, eax + 24]);         /* sub edx, [eax+0x18] */
            ii(0x100f_188b, 6);  cmp(edx, 0xc233);                     /* cmp edx, 0xc233 */
            ii(0x100f_1891, 2);  if(jb(0x100f_187e, -0x15)) goto l_0x100f_187e;/* jb 0x100f187e */
            ii(0x100f_1893, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_1895, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_1896, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_1897, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_1898, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_1899, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_189a, 1);  ret();                                /* ret */
        }
    }
}
