using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3aef-e488c4cc")]
        public void Method_100a_3aef()
        {
            ii(0x100a_3aef, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_3af4, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2259);/* call 0x10165d52 */
            ii(0x100a_3af9, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3afa, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3afb, 1);  push(edx);                            /* push edx */
            ii(0x100a_3afc, 1);  push(esi);                            /* push esi */
            ii(0x100a_3afd, 1);  push(edi);                            /* push edi */
            ii(0x100a_3afe, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3aff, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3b01, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_3b07, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3b0a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3b0d, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_3b10, 5);  call(0x1007_6574, -0x2_d5a1);         /* call 0x10076574 */
            ii(0x100a_3b15, 5);  call(0x1015_26ac, 0xa_eb92);          /* call 0x101526ac */
            ii(0x100a_3b1a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_3b1c, 2);  if(jnz(0x100a_3b37, 0x19)) goto l_0x100a_3b37;/* jnz 0x100a3b37 */
            ii(0x100a_3b1e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3b21, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_3b24, 5);  call(0x1007_65d0, -0x2_d559);         /* call 0x100765d0 */
            ii(0x100a_3b29, 5);  mov(ebx, 0x101c_3180);                /* mov ebx, 0x101c3180 */
            ii(0x100a_3b2e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_3b30, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_3b32, 5);  call(0x100a_5466, 0x192f);            /* call 0x100a5466 */
        l_0x100a_3b37:
            ii(0x100a_3b37, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3b39, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3b3a, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3b3b, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_3b3c, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3b3d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3b3e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3b3f, 1);  ret();                                /* ret */
        }
    }
}
