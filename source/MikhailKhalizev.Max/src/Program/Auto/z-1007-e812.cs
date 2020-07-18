using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e812-11ced")]
        public void Method_1007_e812()
        {
            ii(0x1007_e812, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1007_e817, 5);  call(Definitions.sys_check_available_stack_size, 0xe_7536);/* call 0x10165d52 */
            ii(0x1007_e81c, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_e81d, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_e81e, 1);  push(esi);                            /* push esi */
            ii(0x1007_e81f, 1);  push(edi);                            /* push edi */
            ii(0x1007_e820, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_e821, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_e823, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1007_e829, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_e82c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_e82f, 5);  mov(ebx, 0x1800);                     /* mov ebx, 0x1800 */
            ii(0x1007_e834, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_e837, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_e83a, 5);  call(0x1007_a473, -0x43cc);           /* call 0x1007a473 */
            ii(0x1007_e83f, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_e841, 2);  if(jz(0x1007_e849, 6)) goto l_0x1007_e849;/* jz 0x1007e849 */
            ii(0x1007_e843, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_e847, 2);  jmp(0x1007_e8ba, 0x71); goto l_0x1007_e8ba;/* jmp 0x1007e8ba */
        l_0x1007_e849:
            ii(0x1007_e849, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1007_e84e, 5);  call(Definitions.sys_new, 0xe_75ad);  /* call 0x10165e00 */
            ii(0x1007_e853, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_e856, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_e859, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_e85c, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_e860, 2);  if(jz(0x1007_e87b, 0x19)) goto l_0x1007_e87b;/* jz 0x1007e87b */
            ii(0x1007_e862, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_e865, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_e868, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_e86b, 5);  call(0x100b_524c, 0x3_69dc);          /* call 0x100b524c */
            ii(0x1007_e870, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_e873, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_e876, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_e879, 2);  jmp(0x1007_e881, 6); goto l_0x1007_e881;/* jmp 0x1007e881 */
        l_0x1007_e87b:
            ii(0x1007_e87b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_e87e, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1007_e881:
            ii(0x1007_e881, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1007_e884, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_e887, 5);  call(0x1008_b060, 0xc7d4);            /* call 0x1008b060 */
            ii(0x1007_e88c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_e88f, 5);  call(0x1008_af84, 0xc6f0);            /* call 0x1008af84 */
            ii(0x1007_e894, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_e896, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_e89b, 5);  call(0x100a_4d50, 0x2_64b0);          /* call 0x100a4d50 */
            ii(0x1007_e8a0, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_e8a4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_e8a6, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_e8a9, 5);  call(0x1008_8b7c, 0xa2ce);            /* call 0x10088b7c */
            ii(0x1007_e8ae, 2);  jmp(0x1007_e8ba, 0xa); goto l_0x1007_e8ba;/* jmp 0x1007e8ba */
        //  ii(0x1007_e8b0, 10);  Недостижимый код.
        l_0x1007_e8ba:
            ii(0x1007_e8ba, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_e8bd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_e8bf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_e8c0, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_e8c1, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_e8c2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_e8c3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_e8c4, 1);  ret();                                /* ret */
        }
    }
}
