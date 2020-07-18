using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6ee0-827c9374")]
        public void Method_1010_6ee0()
        {
            ii(0x1010_6ee0, 5);  push(0x54);                           /* push 0x54 */
            ii(0x1010_6ee5, 5);  call(Definitions.sys_check_available_stack_size, 0x5_ee68);/* call 0x10165d52 */
            ii(0x1010_6eea, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_6eeb, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6eec, 1);  push(edx);                            /* push edx */
            ii(0x1010_6eed, 1);  push(esi);                            /* push esi */
            ii(0x1010_6eee, 1);  push(edi);                            /* push edi */
            ii(0x1010_6eef, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6ef0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6ef2, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1010_6ef8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_6efb, 5);  mov(ebx, 0x32);                       /* mov ebx, 0x32 */
            ii(0x1010_6f00, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_6f02, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1010_6f05, 5);  call(Definitions.sys_memset, 0x5_eed6);/* call 0x10165de0 */
            ii(0x1010_6f0a, 7);  mov(memd[ss, ebp - 40], 4);           /* mov dword [ebp-0x28], 0x4 */
            ii(0x1010_6f11, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6f14, 3);  and(eax, 0xf);                        /* and eax, 0xf */
            ii(0x1010_6f17, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_6f1a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6f1d, 3);  shr(eax, 4);                          /* shr eax, 0x4 */
            ii(0x1010_6f20, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1010_6f25, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1010_6f29, 3);  lea(edx, memd[ss, ebp - 56]);         /* lea edx, [ebp-0x38] */
            ii(0x1010_6f2c, 5);  mov(eax, 0x7a);                       /* mov eax, 0x7a */
            ii(0x1010_6f31, 5);  call(0x100e_44ba, -0x2_2a7c);         /* call 0x100e44ba */
            ii(0x1010_6f36, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_6f38, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_6f39, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_6f3a, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6f3b, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_6f3c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6f3d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_6f3e, 1);  ret();                                /* ret */
        }
    }
}
