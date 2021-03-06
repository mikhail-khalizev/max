using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8c7c-d27dbecb")]
        public void my_ctor_0x101b_56fc()
        {
            ii(0x1008_8c7c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_8c81, 5);  call(Definitions.sys_check_available_stack_size, 0xd_d0cc);/* call 0x10165d52 */
            ii(0x1008_8c86, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_8c87, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_8c88, 1);  push(edx);                            /* push edx */
            ii(0x1008_8c89, 1);  push(esi);                            /* push esi */
            ii(0x1008_8c8a, 1);  push(edi);                            /* push edi */
            ii(0x1008_8c8b, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_8c8c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_8c8e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_8c94, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_8c97, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8c9a, 5);  call(0x1008_ab4c, 0x1ead);            /* call 0x1008ab4c */
            ii(0x1008_8c9f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_8ca2, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1008_8ca5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8ca8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_8cab, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_8cae, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_8cb1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_8cb3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_8cb4, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_8cb5, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_8cb6, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_8cb7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_8cb8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_8cb9, 1);  ret();                                /* ret */
        }
    }
}
