using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_d879-9042800a")]
        public void Method_1015_d879()
        {
            ii(0x1015_d879, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_d87e, 5);  call(Definitions.sys_check_available_stack_size, 0x84cf);/* call 0x10165d52 */
            ii(0x1015_d883, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_d884, 1);  push(esi);                            /* push esi */
            ii(0x1015_d885, 1);  push(edi);                            /* push edi */
            ii(0x1015_d886, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_d887, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_d889, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1015_d88f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_d892, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1015_d895, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1015_d898, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_d89b, 5);  call(0x1007_6338, -0xe_7568);         /* call 0x10076338 */
            ii(0x1015_d8a0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_d8a2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d8a5, 5);  call(0x1007_64b8, -0xe_73f2);         /* call 0x100764b8 */
        l_0x1015_d8aa:
            ii(0x1015_d8aa, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d8ac, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d8af, 5);  call(0x1013_ad71, -0x2_2b43);         /* call 0x1013ad71 */
            ii(0x1015_d8b4, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_d8b6, 2);  if(jz(0x1015_d8fd, 0x45)) goto l_0x1015_d8fd;/* jz 0x1015d8fd */
            ii(0x1015_d8b8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d8bb, 5);  call(0x1007_63a0, -0xe_7520);         /* call 0x100763a0 */
            ii(0x1015_d8c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d8c2, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1015_d8c5, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_d8c9, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1015_d8cb, 2);  if(jnz(0x1015_d8e1, 0x14)) goto l_0x1015_d8e1;/* jnz 0x1015d8e1 */
            ii(0x1015_d8cd, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1015_d8d0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d8d3, 5);  call(0x1007_6408, -0xe_74d0);         /* call 0x10076408 */
            ii(0x1015_d8d8, 5);  call(0x1015_d68c, -0x251);            /* call 0x1015d68c */
            ii(0x1015_d8dd, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_d8df, 2);  if(jnz(0x1015_d8e3, 2)) goto l_0x1015_d8e3;/* jnz 0x1015d8e3 */
        l_0x1015_d8e1:
            ii(0x1015_d8e1, 2);  jmp(0x1015_d8f3, 0x10); goto l_0x1015_d8f3;/* jmp 0x1015d8f3 */
        l_0x1015_d8e3:
            ii(0x1015_d8e3, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_d8e7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d8e9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d8ec, 5);  call(0x1007_5f6c, -0xe_7985);         /* call 0x10075f6c */
            ii(0x1015_d8f1, 2);  jmp(0x1015_d917, 0x24); goto l_0x1015_d917;/* jmp 0x1015d917 */
        l_0x1015_d8f3:
            ii(0x1015_d8f3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d8f6, 5);  call(0x1007_6bf8, -0xe_6d03);         /* call 0x10076bf8 */
            ii(0x1015_d8fb, 2);  jmp(0x1015_d8aa, -0x53); goto l_0x1015_d8aa;/* jmp 0x1015d8aa */
        l_0x1015_d8fd:
            ii(0x1015_d8fd, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1015_d901, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d903, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_d906, 5);  call(0x1007_5f6c, -0xe_799f);         /* call 0x10075f6c */
            ii(0x1015_d90b, 2);  jmp(0x1015_d917, 0xa); goto l_0x1015_d917;/* jmp 0x1015d917 */
        //  ii(0x1015_d90d, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1015_d90f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x1015_d912, 5);  call(0x1007_5f6c, -0xe_79ab);         /* call 0x10075f6c */
        l_0x1015_d917:
            ii(0x1015_d917, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1015_d91a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_d91c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_d91d, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_d91e, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_d91f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_d920, 1);  ret();                                /* ret */
        }
    }
}
