using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_a407-7c46b7b")]
        public void Method_100d_a407()
        {
            ii(0x100d_a407, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100d_a40c, 5);  call(Definitions.sys_check_available_stack_size, 0x8_b941);/* call 0x10165d52 */
            ii(0x100d_a411, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_a412, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_a413, 1);  push(esi);                            /* push esi */
            ii(0x100d_a414, 1);  push(edi);                            /* push edi */
            ii(0x100d_a415, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_a416, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_a418, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100d_a41e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_a421, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_a424, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_a428, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a42b, 3);  mov(eax, memd[ds, eax + 73]);         /* mov eax, [eax+0x49] */
            ii(0x100d_a42e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_a431, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_a437, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x100d_a43d, 5);  call(0x100c_b6b0, -0xed92);           /* call 0x100cb6b0 */
            ii(0x100d_a442, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_a445, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a449, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_a44c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a44f, 3);  add(edx, 0x5b);                       /* add edx, 0x5b */
            ii(0x100d_a452, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_a454, 5);  call(0x100c_b6f0, -0xed69);           /* call 0x100cb6f0 */
            ii(0x100d_a459, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_a45c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a460, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_a463, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_a465, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a468, 5);  add(eax, 0x1cf);                      /* add eax, 0x1cf */
            ii(0x100d_a46d, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_a46f, 5);  call(0x100c_b6f0, -0xed84);           /* call 0x100cb6f0 */
            ii(0x100d_a474, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_a477, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_a47a, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100d_a47e, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_a481, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_a484, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_a487, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_a48a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_a48c, 2);  if(jz(0x100d_a4cd, 0x3f)) goto l_0x100d_a4cd;/* jz 0x100da4cd */
            ii(0x100d_a48e, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a492, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x100d_a497, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a49a, 3);  mov(eax, memd[ds, eax + 73]);         /* mov eax, [eax+0x49] */
            ii(0x100d_a49d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_a4a0, 5);  call(0x1013_3743, 0x5_929e);          /* call 0x10133743 */
            ii(0x100d_a4a5, 1);  cwde();                               /* cwde */
            ii(0x100d_a4a6, 1);  push(eax);                            /* push eax */
            ii(0x100d_a4a7, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_a4aa, 3);  add(eax, 0x10);                       /* add eax, 0x10 */
            ii(0x100d_a4ad, 1);  push(eax);                            /* push eax */
            ii(0x100d_a4ae, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_a4b1, 3);  mov(ecx, memd[ds, eax + 14]);         /* mov ecx, [eax+0xe] */
            ii(0x100d_a4b4, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100d_a4b7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_a4ba, 3);  mov(ebx, memd[ds, eax + 14]);         /* mov ebx, [eax+0xe] */
            ii(0x100d_a4bd, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100d_a4c0, 5);  mov(edx, 8);                          /* mov edx, 0x8 */
            ii(0x100d_a4c5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a4c8, 5);  call(0x100d_9e3f, -0x68e);            /* call 0x100d9e3f */
        l_0x100d_a4cd:
            ii(0x100d_a4cd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_a4cf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_a4d0, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_a4d1, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_a4d2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_a4d3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_a4d4, 1);  ret();                                /* ret */
        }
    }
}
