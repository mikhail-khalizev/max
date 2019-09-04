using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a835-a9726946")]
        public void Method_100f_a835()
        {
            ii(0x100f_a835, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x100f_a83a, 5);  call(Definitions.sys_check_available_stack_size, 0x6_b513);/* call 0x10165d52 */
            ii(0x100f_a83f, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_a840, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_a841, 1);  push(edx);                            /* push edx */
            ii(0x100f_a842, 1);  push(esi);                            /* push esi */
            ii(0x100f_a843, 1);  push(edi);                            /* push edi */
            ii(0x100f_a844, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_a845, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_a847, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x100f_a84d, 7);  cmp(memd[ds, 0x101c_37e0], 0);        /* cmp dword [0x101c37e0], 0x0 */
            ii(0x100f_a854, 2);  if(jz(0x100f_a874, 0x1e)) goto l_0x100f_a874;/* jz 0x100fa874 */
            ii(0x100f_a856, 5);  mov(eax, memd[ds, 0x101c_37e0]);      /* mov eax, [0x101c37e0] */
            ii(0x100f_a85b, 5);  call(0x100f_0748, -0xa118);           /* call 0x100f0748 */
            ii(0x100f_a860, 5);  mov(eax, memd[ds, 0x101c_37e0]);      /* mov eax, [0x101c37e0] */
            ii(0x100f_a865, 5);  call(Definitions.sys_free, 0x7_0857); /* call 0x1016b0c1 */
            ii(0x100f_a86a, 10);  mov(memd[ds, 0x101c_37e0], 0);       /* mov dword [0x101c37e0], 0x0 */
        l_0x100f_a874:
            ii(0x100f_a874, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_a875, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_a876, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_a877, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_a878, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_a879, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_a87a, 1);  ret();                                /* ret */
        }
    }
}
