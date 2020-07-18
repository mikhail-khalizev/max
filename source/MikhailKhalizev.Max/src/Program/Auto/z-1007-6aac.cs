using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6aac-8b0b98b9")]
        public void Method_1007_6aac()
        {
            ii(0x1007_6aac, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6ab1, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f29c);/* call 0x10165d52 */
            ii(0x1007_6ab6, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6ab7, 1);  push(esi);                            /* push esi */
            ii(0x1007_6ab8, 1);  push(edi);                            /* push edi */
            ii(0x1007_6ab9, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6aba, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6abc, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_6ac2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_6ac5, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_6ac8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1007_6acb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6ace, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_6ad1, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1007_6ad4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6ad7, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_6ada, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x1007_6ade, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_6ae1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_6ae4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_6ae7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6ae9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6aea, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6aeb, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6aec, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6aed, 1);  ret();                                /* ret */
        }
    }
}
