using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e2d3-ddc827e9")]
        public void Method_1007_e2d3()
        {
            ii(0x1007_e2d3, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_e2d8, 5);  call(Definitions.sys_check_available_stack_size, 0xe_7a75);/* call 0x10165d52 */
            ii(0x1007_e2dd, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_e2de, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_e2df, 1);  push(esi);                            /* push esi */
            ii(0x1007_e2e0, 1);  push(edi);                            /* push edi */
            ii(0x1007_e2e1, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_e2e2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_e2e4, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_e2ea, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_e2ed, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_e2f0, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_e2f7, 2);  jmp(0x1007_e2ff, 6); goto l_0x1007_e2ff;/* jmp 0x1007e2ff */
        l_0x1007_e2f9:
            ii(0x1007_e2f9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_e2fc, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1007_e2ff:
            ii(0x1007_e2ff, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_e303, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1007_e306, 2);  if(jge(0x1007_e33c, 0x34)) goto l_0x1007_e33c;/* jge 0x1007e33c */
            ii(0x1007_e308, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_e30b, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_e30f, 3);  imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
            ii(0x1007_e312, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_e315, 3);  add(ebx, 0x21);                       /* add ebx, 0x21 */
            ii(0x1007_e318, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1007_e31a, 5);  call(0x1007_d2c8, -0x1057);           /* call 0x1007d2c8 */
            ii(0x1007_e31f, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_e321, 2);  if(jz(0x1007_e33a, 0x17)) goto l_0x1007_e33a;/* jz 0x1007e33a */
            ii(0x1007_e323, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_e326, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e329, 5);  call(0x1015_27ed, 0xd_44bf);          /* call 0x101527ed */
            ii(0x1007_e32e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_e330, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e333, 5);  call(0x1015_2605, 0xd_42cd);          /* call 0x10152605 */
            ii(0x1007_e338, 2);  jmp(0x1007_e33c, 2); goto l_0x1007_e33c;/* jmp 0x1007e33c */
        l_0x1007_e33a:
            ii(0x1007_e33a, 2);  jmp(0x1007_e2f9, -0x43); goto l_0x1007_e2f9;/* jmp 0x1007e2f9 */
        l_0x1007_e33c:
            ii(0x1007_e33c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_e33e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_e33f, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_e340, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_e341, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_e342, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_e343, 1);  ret();                                /* ret */
        }
    }
}
