using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8144-61dc6620")]
        public void Method_100e_8144()
        {
            ii(0x100e_8144, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_8149, 5);  call(Definitions.sys_check_available_stack_size, 0x7_dc04);/* call 0x10165d52 */
            ii(0x100e_814e, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_814f, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_8150, 1);  push(esi);                            /* push esi */
            ii(0x100e_8151, 1);  push(edi);                            /* push edi */
            ii(0x100e_8152, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8153, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8155, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_815b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_815e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_8161, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100e_8166, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8169, 5);  call(0x100e_8104, -0x6a);             /* call 0x100e8104 */
            ii(0x100e_816e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8171, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8174, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_8177, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_817a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_817c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_817d, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_817e, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_817f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_8180, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_8181, 1);  ret();                                /* ret */
        }
    }
}
