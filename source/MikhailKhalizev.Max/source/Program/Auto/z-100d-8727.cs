using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8727-2422982")]
        public void Method_100d_8727()
        {
            ii(0x100d_8727, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_872c, 5);  call(Definitions.sys_check_available_stack_size, 0x8_d621);/* call 0x10165d52 */
            ii(0x100d_8731, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_8732, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_8733, 1);  push(edx);                            /* push edx */
            ii(0x100d_8734, 1);  push(esi);                            /* push esi */
            ii(0x100d_8735, 1);  push(edi);                            /* push edi */
            ii(0x100d_8736, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_8737, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_8739, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_873f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_8742, 5);  call(0x100d_51c4, -0x3583);           /* call 0x100d51c4 */
            ii(0x100d_8747, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_8749, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_874b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_874e, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_8751, 5);  call(0x100c_fb06, -0x8c50);           /* call 0x100cfb06 */
            ii(0x100d_8756, 5);  call(0x100d_51c4, -0x3597);           /* call 0x100d51c4 */
            ii(0x100d_875b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_875d, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_875f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_8762, 3);  mov(eax, memd[ds, eax + 10]);         /* mov eax, [eax+0xa] */
            ii(0x100d_8765, 5);  call(0x100c_fb06, -0x8c64);           /* call 0x100cfb06 */
            ii(0x100d_876a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_876d, 4);  mov(memb[ds, eax + 14], 0);           /* mov byte [eax+0xe], 0x0 */
            ii(0x100d_8771, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_8773, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_8774, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_8775, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_8776, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_8777, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_8778, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_8779, 1);  ret();                                /* ret */
        }
    }
}
