using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_2ebd-583b10c9")]
        public void Method_1013_2ebd()
        {
            ii(0x1013_2ebd, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_2ec2, 5);  call(Definitions.sys_check_available_stack_size, 0x3_2e8b);/* call 0x10165d52 */
            ii(0x1013_2ec7, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_2ec8, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_2ec9, 1);  push(esi);                            /* push esi */
            ii(0x1013_2eca, 1);  push(edi);                            /* push edi */
            ii(0x1013_2ecb, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_2ecc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_2ece, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_2ed4, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_2ed7, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_2eda, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_2edd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_2ee0, 4);  add(memw[ds, edx + 25], ax);          /* add [edx+0x19], ax */
            ii(0x1013_2ee4, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_2eeb, 2);  jmp(0x1013_2ef3, 6); goto l_0x1013_2ef3;/* jmp 0x10132ef3 */
        l_0x1013_2eed:
            ii(0x1013_2eed, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_2ef0, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1013_2ef3:
            ii(0x1013_2ef3, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_2ef7, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1013_2efa, 2);  if(jge(0x1013_2f12, 0x16)) goto l_0x1013_2f12;/* jge 0x10132f12 */
            ii(0x1013_2efc, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_2f00, 3);  imul(edx, eax, 0x1f);                 /* imul edx, eax, 0x1f */
            ii(0x1013_2f03, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2f06, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1013_2f09, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_2f0b, 5);  call(0x1013_23f5, -0xb1b);            /* call 0x101323f5 */
            ii(0x1013_2f10, 2);  jmp(0x1013_2eed, -0x25); goto l_0x1013_2eed;/* jmp 0x10132eed */
        l_0x1013_2f12:
            ii(0x1013_2f12, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_2f14, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_2f15, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_2f16, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_2f17, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_2f18, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_2f19, 1);  ret();                                /* ret */
        }
    }
}
