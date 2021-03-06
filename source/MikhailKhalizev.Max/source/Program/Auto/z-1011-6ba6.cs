using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_6ba6-c4c99a51")]
        public void Method_1011_6ba6()
        {
            ii(0x1011_6ba6, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x1011_6bab, 5);  call(Definitions.sys_check_available_stack_size, 0x4_f1a2);/* call 0x10165d52 */
            ii(0x1011_6bb0, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_6bb1, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_6bb2, 1);  push(edx);                            /* push edx */
            ii(0x1011_6bb3, 1);  push(esi);                            /* push esi */
            ii(0x1011_6bb4, 1);  push(edi);                            /* push edi */
            ii(0x1011_6bb5, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_6bb6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_6bb8, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x1011_6bbe, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_6bc5, 2);  if(jz(0x1011_6bdd, 0x16)) goto l_0x1011_6bdd;/* jz 0x10116bdd */
            ii(0x1011_6bc7, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_6bc9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_6bcb, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1011_6bd0, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_6bd3, 5);  mov(eax, 0x27);                       /* mov eax, 0x27 */
            ii(0x1011_6bd8, 5);  call(0x1012_8897, 0x1_1cba);          /* call 0x10128897 */
        l_0x1011_6bdd:
            ii(0x1011_6bdd, 5);  mov(eax, StringDefinitions.GamePausedClickOkToContinue);/* mov eax, 0x101a7af0 */
            ii(0x1011_6be2, 5);  call(0x1011_6b06, -0xe1);             /* call 0x10116b06 */
            ii(0x1011_6be7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_6be8, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_6be9, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_6bea, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_6beb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_6bec, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_6bed, 1);  ret();                                /* ret */
        }
    }
}
