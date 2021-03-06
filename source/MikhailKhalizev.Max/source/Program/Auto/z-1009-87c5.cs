using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_87c5-cfdbfb9c")]
        public void Method_1009_87c5()
        {
            ii(0x1009_87c5, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1009_87ca, 5);  call(Definitions.sys_check_available_stack_size, 0xc_d583);/* call 0x10165d52 */
            ii(0x1009_87cf, 1);  push(esi);                            /* push esi */
            ii(0x1009_87d0, 1);  push(edi);                            /* push edi */
            ii(0x1009_87d1, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_87d2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_87d4, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1009_87da, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_87dd, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_87e0, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_87e3, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x1009_87e6, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_87ea, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_87ed, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_87f0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_87f3, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_87f6, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_87f9, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x1009_87fc, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1009_87ff, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_8802, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8805, 5);  call(0x1008_c772, -0xc098);           /* call 0x1008c772 */
            ii(0x1009_880a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_880d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1009_8810, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_8813, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8816, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1009_8819, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_1d2e);/* call 0x10076af0 */
            ii(0x1009_881e, 3);  sub(eax, 0x19);                       /* sub eax, 0x19 */
            ii(0x1009_8821, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_8824, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8827, 7);  mov(memd[ds, eax + 2], 0x101b_4570);  /* mov dword [eax+0x2], 0x101b4570 */
            ii(0x1009_882e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_8831, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8834, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1009_8837, 5);  call(0x1008_8b44, -0xfcf8);           /* call 0x10088b44 */
            ii(0x1009_883c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_883f, 4);  mov(memb[ds, eax + 29], 0);           /* mov byte [eax+0x1d], 0x0 */
            ii(0x1009_8843, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8846, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_8849, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_884c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_884e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_884f, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_8850, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_8851, 1);  ret();                                /* ret */
        }
    }
}
