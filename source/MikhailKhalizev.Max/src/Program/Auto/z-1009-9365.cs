using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9365-979d663c")]
        public void Method_1009_9365()
        {
            ii(0x1009_9365, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_936a, 5);  call(Definitions.sys_check_available_stack_size, 0xc_c9e3);/* call 0x10165d52 */
            ii(0x1009_936f, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_9370, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_9371, 1);  push(edx);                            /* push edx */
            ii(0x1009_9372, 1);  push(esi);                            /* push esi */
            ii(0x1009_9373, 1);  push(edi);                            /* push edi */
            ii(0x1009_9374, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_9375, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_9377, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_937d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_9380, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_9382, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9385, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_9388, 5);  call(0x1013_ad71, 0xa_19e4);          /* call 0x1013ad71 */
            ii(0x1009_938d, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_938f, 2);  if(jz(0x1009_93a4, 0x13)) goto l_0x1009_93a4;/* jz 0x100993a4 */
            ii(0x1009_9391, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_9394, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9397, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_939a, 5);  call(0x1007_6574, -0x2_2e2b);         /* call 0x10076574 */
            ii(0x1009_939f, 5);  call(0x1015_27ed, 0xb_9449);          /* call 0x101527ed */
        l_0x1009_93a4:
            ii(0x1009_93a4, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_93a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_93ac, 5);  call(0x100a_2a04, 0x9653);            /* call 0x100a2a04 */
            ii(0x1009_93b1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_93b3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_93b4, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_93b5, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_93b6, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_93b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_93b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_93b9, 1);  ret();                                /* ret */
        }
    }
}
