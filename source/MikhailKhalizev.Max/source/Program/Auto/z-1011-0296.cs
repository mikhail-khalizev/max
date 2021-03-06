using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0296-13a57c38")]
        public void Method_1011_0296()
        {
            ii(0x1011_0296, 5);  push(0x64);                           /* push 0x64 */
            ii(0x1011_029b, 5);  call(Definitions.sys_check_available_stack_size, 0x5_5ab2);/* call 0x10165d52 */
            ii(0x1011_02a0, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_02a1, 1);  push(esi);                            /* push esi */
            ii(0x1011_02a2, 1);  push(edi);                            /* push edi */
            ii(0x1011_02a3, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_02a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_02a6, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1011_02ac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_02af, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_02b2, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1011_02b5, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_02b9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_02bc, 6);  push(memd[ds, eax + 0x101c_4df4]);    /* push dword [eax+0x101c4df4] */
            ii(0x1011_02c2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_02c5, 6);  mov(al, memb[ds, eax + 320]);         /* mov al, [eax+0x140] */
            ii(0x1011_02cb, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_02d0, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1011_02d4, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_02d6, 1);  push(eax);                            /* push eax */
            ii(0x1011_02d7, 5);  mov(eax, StringDefinitions.IS2);      /* mov eax, 0x101a466b */
            ii(0x1011_02dc, 1);  push(eax);                            /* push eax */
            ii(0x1011_02dd, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_02e0, 1);  push(eax);                            /* push eax */
            ii(0x1011_02e1, 5);  call(Definitions.sys_sprintf, 0x5_5c1b);/* call 0x10165f01 */
            ii(0x1011_02e6, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1011_02e9, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_02ed, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1011_02f0, 5);  mov(edx, 0x101b_ad94);                /* mov edx, 0x101bad94 */
            ii(0x1011_02f5, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_02f7, 3);  mov(memd[ss, ebp - 56], edx);         /* mov [ebp-0x38], edx */
            ii(0x1011_02fa, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1011_02ff, 1);  push(eax);                            /* push eax */
            ii(0x1011_0300, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_0302, 1);  push(eax);                            /* push eax */
            ii(0x1011_0303, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0306, 1);  push(eax);                            /* push eax */
            ii(0x1011_0307, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_030a, 4);  mov(ax, memw[ds, eax + 6]);           /* mov ax, [eax+0x6] */
            ii(0x1011_030e, 3);  mov(edx, memd[ss, ebp - 56]);         /* mov edx, [ebp-0x38] */
            ii(0x1011_0311, 4);  sub(ax, memw[ds, edx + 2]);           /* sub ax, [edx+0x2] */
            ii(0x1011_0315, 1);  cwde();                               /* cwde */
            ii(0x1011_0316, 1);  push(eax);                            /* push eax */
            ii(0x1011_0317, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_031a, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x1011_031e, 3);  mov(edx, memd[ss, ebp - 56]);         /* mov edx, [ebp-0x38] */
            ii(0x1011_0321, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x1011_0324, 1);  cwde();                               /* cwde */
            ii(0x1011_0325, 1);  push(eax);                            /* push eax */
            ii(0x1011_0326, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_0329, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_032b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_032e, 1);  push(eax);                            /* push eax */
            ii(0x1011_032f, 3);  mov(ecx, memd[ss, ebp - 56]);         /* mov ecx, [ebp-0x38] */
            ii(0x1011_0332, 3);  movsx(ecx, memw[ds, ecx]);            /* movsx ecx, word [ecx] */
            ii(0x1011_0335, 3);  lea(ebx, memd[ss, ebp - 52]);         /* lea ebx, [ebp-0x34] */
            ii(0x1011_0338, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_033b, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_033d, 3);  mov(edx, memd[ds, edx + 14]);         /* mov edx, [edx+0xe] */
            ii(0x1011_0340, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_0343, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_0346, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_0348, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1011_034b, 5);  call(0x100e_9ae5, -0x2_686b);         /* call 0x100e9ae5 */
            ii(0x1011_0350, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_0352, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_0353, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_0354, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_0355, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_0356, 1);  ret();                                /* ret */
        }
    }
}
