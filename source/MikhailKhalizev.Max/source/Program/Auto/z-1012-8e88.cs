using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8e88-c594779a")]
        public void Method_1012_8e88()
        {
            ii(0x1012_8e88, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_8e8d, 5);  call(Definitions.sys_check_available_stack_size, 0x3_cec0);/* call 0x10165d52 */
            ii(0x1012_8e92, 1);  push(esi);                            /* push esi */
            ii(0x1012_8e93, 1);  push(edi);                            /* push edi */
            ii(0x1012_8e94, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_8e95, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_8e97, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1012_8e9d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_8ea0, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1012_8ea3, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1012_8ea6, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1012_8ea9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_8eac, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1012_8eb0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_8eb3, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1012_8eb7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8eba, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1012_8ebe, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1012_8ec1, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1012_8ec5, 7);  mov(memb[ds, 0x101c_5c1c], 0x15);     /* mov byte [0x101c5c1c], 0x15 */
            ii(0x1012_8ecc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_8ecf, 6);  mov(memw[ds, 0x101c_5c1d], ax);       /* mov [0x101c5c1d], ax */
            ii(0x1012_8ed5, 9);  mov(memw[ds, 0x101c_5c1f], 8);        /* mov word [0x101c5c1f], 0x8 */
            ii(0x1012_8ede, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x1012_8ee3, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1012_8ee6, 5);  mov(eax, 0x101c_5c21);                /* mov eax, 0x101c5c21 */
            ii(0x1012_8eeb, 5);  call(Definitions.sys_memcpy, 0x3_cf5b);/* call 0x10165e4b */
            ii(0x1012_8ef0, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1012_8ef5, 5);  call(0x1012_5be9, -0x3311);           /* call 0x10125be9 */
            ii(0x1012_8efa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_8efc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_8efd, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_8efe, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_8eff, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
