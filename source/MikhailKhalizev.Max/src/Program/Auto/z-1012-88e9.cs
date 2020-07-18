using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_88e9-71d3ced7")]
        public void Method_1012_88e9()
        {
            ii(0x1012_88e9, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_88ee, 5);  call(Definitions.sys_check_available_stack_size, 0x3_d45f);/* call 0x10165d52 */
            ii(0x1012_88f3, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_88f4, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_88f5, 1);  push(edx);                            /* push edx */
            ii(0x1012_88f6, 1);  push(esi);                            /* push esi */
            ii(0x1012_88f7, 1);  push(edi);                            /* push edi */
            ii(0x1012_88f8, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_88f9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_88fb, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_8901, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_8904, 7);  mov(memb[ds, 0x101c_5c1c], 8);        /* mov byte [0x101c5c1c], 0x8 */
            ii(0x1012_890b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_890e, 5);  call(0x1007_6154, -0xb_27bf);         /* call 0x10076154 */
            ii(0x1012_8913, 6);  mov(memw[ds, 0x101c_5c1d], ax);       /* mov [0x101c5c1d], ax */
            ii(0x1012_8919, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_891c, 3);  mov(ebx, memd[ds, eax + 58]);         /* mov ebx, [eax+0x3a] */
            ii(0x1012_891f, 3);  sar(ebx, 0x18);                       /* sar ebx, 0x18 */
            ii(0x1012_8922, 3);  shl(ebx, 3);                          /* shl ebx, 0x3 */
            ii(0x1012_8925, 5);  mov(edx, 0x101c_5c21);                /* mov edx, 0x101c5c21 */
            ii(0x1012_892a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_892d, 6);  call_abs(memd[ds, ebx + 0x101c_60a0]);/* call dword [ebx+0x101c60a0] */
            ii(0x1012_8933, 6);  mov(memw[ds, 0x101c_5c1f], ax);       /* mov [0x101c5c1f], ax */
            ii(0x1012_8939, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1012_893e, 5);  call(0x1012_5be9, -0x2d5a);           /* call 0x10125be9 */
            ii(0x1012_8943, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_8945, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_8946, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_8947, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_8948, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_8949, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_894a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_894b, 1);  ret();                                /* ret */
        }
    }
}
