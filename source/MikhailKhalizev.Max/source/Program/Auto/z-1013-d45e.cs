using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d45e-216e0226")]
        public void Method_1013_d45e()
        {
            ii(0x1013_d45e, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_d463, 5);  call(Definitions.sys_check_available_stack_size, 0x2_88ea);/* call 0x10165d52 */
            ii(0x1013_d468, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_d469, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_d46a, 1);  push(esi);                            /* push esi */
            ii(0x1013_d46b, 1);  push(edi);                            /* push edi */
            ii(0x1013_d46c, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_d46d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_d46f, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_d475, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_d478, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1013_d47b, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_d47f, 3);  cmp(eax, 0x1c);                       /* cmp eax, 0x1c */
            ii(0x1013_d482, 2);  if(jle(0x1013_d48b, 7)) goto l_0x1013_d48b;/* jle 0x1013d48b */
            ii(0x1013_d484, 7);  mov(memd[ss, ebp - 8], 0x1c);         /* mov dword [ebp-0x8], 0x1c */
        l_0x1013_d48b:
            ii(0x1013_d48b, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_d48f, 2);  if(jz(0x1013_d494, 3)) goto l_0x1013_d494;/* jz 0x1013d494 */
            ii(0x1013_d491, 3);  neg(memd[ss, ebp - 8]);               /* neg dword [ebp-0x8] */
        l_0x1013_d494:
            ii(0x1013_d494, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_d498, 3);  add(eax, 0x38);                       /* add eax, 0x38 */
            ii(0x1013_d49b, 6);  imul(edx, eax, 0xffff);               /* imul edx, eax, 0xffff */
            ii(0x1013_d4a1, 5);  mov(ebx, 0x70);                       /* mov ebx, 0x70 */
            ii(0x1013_d4a6, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_d4a8, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_d4ab, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_d4ad, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_d4b0, 5);  mov(eax, 0x75);                       /* mov eax, 0x75 */
            ii(0x1013_d4b5, 5);  call(0x1007_5fdc, -0xc_74de);         /* call 0x10075fdc */
            ii(0x1013_d4ba, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_d4bc, 2);  if(jz(0x1013_d4c9, 0xb)) goto l_0x1013_d4c9;/* jz 0x1013d4c9 */
            ii(0x1013_d4be, 5);  mov(eax, 0xffff);                     /* mov eax, 0xffff */
            ii(0x1013_d4c3, 3);  sub(eax, memd[ss, ebp - 12]);         /* sub eax, [ebp-0xc] */
            ii(0x1013_d4c6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1013_d4c9:
            ii(0x1013_d4c9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_d4cc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_d4cf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d4d2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_d4d4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_d4d5, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_d4d6, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_d4d7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_d4d8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_d4d9, 1);  ret();                                /* ret */
        }
    }
}
