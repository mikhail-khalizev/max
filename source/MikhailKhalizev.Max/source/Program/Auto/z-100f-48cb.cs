using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_48cb-70ca912c")]
        public void Method_100f_48cb()
        {
            ii(0x100f_48cb, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100f_48d0, 5);  call(Definitions.sys_check_available_stack_size, 0x7_147d);/* call 0x10165d52 */
            ii(0x100f_48d5, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_48d6, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_48d7, 1);  push(edx);                            /* push edx */
            ii(0x100f_48d8, 1);  push(esi);                            /* push esi */
            ii(0x100f_48d9, 1);  push(edi);                            /* push edi */
            ii(0x100f_48da, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_48db, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_48dd, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100f_48e3, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_48e6, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_48e9, 5);  mov(memb[ds, 0x101c_37ce], al);       /* mov [0x101c37ce], al */
            ii(0x100f_48ee, 5);  mov(al, memb[ds, 0x101c_37ce]);       /* mov al, [0x101c37ce] */
            ii(0x100f_48f3, 5);  mov(memb[ds, 0x101b_881b], al);       /* mov [0x101b881b], al */
            ii(0x100f_48f8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_48fa, 6);  mov(dl, memb[ds, 0x101c_37ce]);       /* mov dl, [0x101c37ce] */
            ii(0x100f_4900, 5);  mov(eax, memd[ds, 0x101b_8817]);      /* mov eax, [0x101b8817] */
            ii(0x100f_4905, 5);  call(0x100c_fb73, -0x2_4d97);         /* call 0x100cfb73 */
            ii(0x100f_490a, 5);  call(0x100f_f5c1, 0xacb2);            /* call 0x100ff5c1 */
            ii(0x100f_490f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_4911, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_4912, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_4913, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_4914, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_4915, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_4916, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_4917, 1);  ret();                                /* ret */
        }
    }
}
