using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_65a2-dea805c6")]
        public void Method_1010_65a2()
        {
            ii(0x1010_65a2, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_65a7, 5);  call(Definitions.sys_check_available_stack_size, 0x5_f7a6);/* call 0x10165d52 */
            ii(0x1010_65ac, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_65ad, 1);  push(esi);                            /* push esi */
            ii(0x1010_65ae, 1);  push(edi);                            /* push edi */
            ii(0x1010_65af, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_65b0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_65b2, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_65b8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_65bb, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_65be, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_65c1, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_65c5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_65c8, 6);  push(memd[ds, eax + 0x101b_8fdc]);    /* push dword [eax+0x101b8fdc] */
            ii(0x1010_65ce, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_65d1, 1);  push(eax);                            /* push eax */
            ii(0x1010_65d2, 5);  call(0x1012_36fa, 0x1_d123);          /* call 0x101236fa */
            ii(0x1010_65d7, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1010_65da, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_65dc, 2);  if(jz(0x1010_6604, 0x26)) goto l_0x1010_6604;/* jz 0x10106604 */
            ii(0x1010_65de, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_65e2, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1010_65e5, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x1010_65eb, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_65ee, 1);  push(eax);                            /* push eax */
            ii(0x1010_65ef, 5);  call(0x1012_3850, 0x1_d25c);          /* call 0x10123850 */
            ii(0x1010_65f4, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1010_65f7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_65f9, 2);  if(jz(0x1010_6604, 9)) goto l_0x1010_6604;/* jz 0x10106604 */
            ii(0x1010_65fb, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_6602, 2);  jmp(0x1010_660b, 7); goto l_0x1010_660b;/* jmp 0x1010660b */
        l_0x1010_6604:
            ii(0x1010_6604, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_660b:
            ii(0x1010_660b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_660e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_6610, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_6611, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_6612, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6613, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6614, 1);  ret();                                /* ret */
        }
    }
}
