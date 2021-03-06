using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a7e8-bdb4986c")]
        public void Method_100f_a7e8()
        {
            ii(0x100f_a7e8, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100f_a7ed, 5);  call(Definitions.sys_check_available_stack_size, 0x6_b560);/* call 0x10165d52 */
            ii(0x100f_a7f2, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_a7f3, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_a7f4, 1);  push(edx);                            /* push edx */
            ii(0x100f_a7f5, 1);  push(esi);                            /* push esi */
            ii(0x100f_a7f6, 1);  push(edi);                            /* push edi */
            ii(0x100f_a7f7, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_a7f8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_a7fa, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100f_a800, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_a803, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_a806, 5);  mov(memb[ds, 0x101c_388e], al);       /* mov [0x101c388e], al */
            ii(0x100f_a80b, 5);  mov(al, memb[ds, 0x101c_388e]);       /* mov al, [0x101c388e] */
            ii(0x100f_a810, 5);  mov(memb[ds, 0x101b_87f1], al);       /* mov [0x101b87f1], al */
            ii(0x100f_a815, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_a817, 6);  mov(dl, memb[ds, 0x101c_388e]);       /* mov dl, [0x101c388e] */
            ii(0x100f_a81d, 5);  mov(eax, memd[ds, 0x101b_87ed]);      /* mov eax, [0x101b87ed] */
            ii(0x100f_a822, 5);  call(0x100c_fb73, -0x2_acb4);         /* call 0x100cfb73 */
            ii(0x100f_a827, 5);  call(0x100f_f5c1, 0x4d95);            /* call 0x100ff5c1 */
            ii(0x100f_a82c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_a82e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_a82f, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_a830, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_a831, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_a832, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_a833, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_a834, 1);  ret();                                /* ret */
        }
    }
}
