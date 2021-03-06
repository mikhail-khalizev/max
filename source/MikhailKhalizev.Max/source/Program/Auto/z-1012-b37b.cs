using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b37b-59851176")]
        public void Method_1012_b37b()
        {
            ii(0x1012_b37b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_b380, 5);  call(Definitions.sys_check_available_stack_size, 0x3_a9cd);/* call 0x10165d52 */
            ii(0x1012_b385, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_b386, 1);  push(esi);                            /* push esi */
            ii(0x1012_b387, 1);  push(edi);                            /* push edi */
            ii(0x1012_b388, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_b389, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_b38b, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1012_b391, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_b394, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1012_b397, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_b39a, 7);  mov(memb[ds, 0x101c_5c1c], 0x2d);     /* mov byte [0x101c5c1c], 0x2d */
            ii(0x1012_b3a1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_b3a4, 6);  mov(memw[ds, 0x101c_5c1d], ax);       /* mov [0x101c5c1d], ax */
            ii(0x1012_b3aa, 9);  mov(memw[ds, 0x101c_5c1f], 3);        /* mov word [0x101c5c1f], 0x3 */
            ii(0x1012_b3b3, 7);  mov(memd[ss, ebp - 16], 0x101c_5c21); /* mov dword [ebp-0x10], 0x101c5c21 */
            ii(0x1012_b3ba, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_b3bd, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_b3c0, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1012_b3c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_b3c5, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_b3c8, 4);  mov(memw[ds, edx + 1], ax);           /* mov [edx+0x1], ax */
            ii(0x1012_b3cc, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1012_b3d1, 5);  call(0x1012_5be9, -0x57ed);           /* call 0x10125be9 */
            ii(0x1012_b3d6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_b3d8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_b3d9, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_b3da, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_b3db, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_b3dc, 1);  ret();                                /* ret */
        }
    }
}
