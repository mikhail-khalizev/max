using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_012d-3e73540e")]
        public void Method_1015_012d()
        {
            ii(0x1015_012d, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_0132, 5);  call(Definitions.sys_check_available_stack_size, 0x1_5c1b);/* call 0x10165d52 */
            ii(0x1015_0137, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_0138, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_0139, 1);  push(edx);                            /* push edx */
            ii(0x1015_013a, 1);  push(esi);                            /* push esi */
            ii(0x1015_013b, 1);  push(edi);                            /* push edi */
            ii(0x1015_013c, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_013d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_013f, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_0145, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_0148, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_014b, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1015_014e, 5);  call(0x1007_6730, -0xd_9a23);         /* call 0x10076730 */
            ii(0x1015_0153, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_0156, 3);  mov(dl, memb[ds, edx + 77]);          /* mov dl, [edx+0x4d] */
            ii(0x1015_0159, 2);  xor(dh, dh);                          /* xor dh, dh */
            ii(0x1015_015b, 4);  mov(ax, memw[ds, eax + 10]);          /* mov ax, [eax+0xa] */
            ii(0x1015_015f, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1015_0161, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_0164, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0167, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1015_016a, 5);  call(0x1007_6730, -0xd_9a3f);         /* call 0x10076730 */
            ii(0x1015_016f, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1015_0172, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_0175, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1015_0178, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_017b, 5);  call(0x1015_09a6, 0x826);             /* call 0x101509a6 */
            ii(0x1015_0180, 1);  cwde();                               /* cwde */
            ii(0x1015_0181, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_0185, 3);  imul(eax, ebx);                       /* imul eax, ebx */
            ii(0x1015_0188, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1015_018a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_018d, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1015_0190, 5);  call(0x1007_6730, -0xd_9a65);         /* call 0x10076730 */
            ii(0x1015_0195, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1015_0198, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_019b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1015_019e, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1015_01a0, 1);  dec(edx);                             /* dec edx */
            ii(0x1015_01a1, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1015_01a3, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1015_01a6, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1015_01a8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_01ab, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_01ae, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_01b0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_01b1, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_01b2, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_01b3, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_01b4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_01b5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_01b6, 1);  ret();                                /* ret */
        }
    }
}
