using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_2705-fbdbce4f")]
        public void Method_1013_2705()
        {
            ii(0x1013_2705, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_270a, 5);  call(Definitions.sys_check_available_stack_size, 0x3_3643);/* call 0x10165d52 */
            ii(0x1013_270f, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_2710, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_2711, 1);  push(esi);                            /* push esi */
            ii(0x1013_2712, 1);  push(edi);                            /* push edi */
            ii(0x1013_2713, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_2714, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_2716, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_271c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_271f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_2722, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_2726, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_2728, 2);  if(jge(0x1013_2731, 7)) goto l_0x1013_2731;/* jge 0x10132731 */
            ii(0x1013_272a, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1013_2731:
            ii(0x1013_2731, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2734, 3);  mov(edx, memd[ds, eax + 3]);          /* mov edx, [eax+0x3] */
            ii(0x1013_2737, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1013_273a, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_273e, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1013_2740, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_2742, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2745, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_2747, 5);  call(0x1013_3964, 0x1218);            /* call 0x10133964 */
            ii(0x1013_274c, 1);  cwde();                               /* cwde */
            ii(0x1013_274d, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1013_274f, 2);  if(jle(0x1013_2769, 0x18)) goto l_0x1013_2769;/* jle 0x10132769 */
            ii(0x1013_2751, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2754, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_2756, 5);  call(0x1013_3964, 0x1209);            /* call 0x10133964 */
            ii(0x1013_275b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_275d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2760, 4);  mov(ax, memw[ds, eax + 5]);           /* mov ax, [eax+0x5] */
            ii(0x1013_2764, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_2766, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1013_2769:
            ii(0x1013_2769, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_276c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_276f, 4);  cmp(ax, memw[ds, edx + 5]);           /* cmp ax, [edx+0x5] */
            ii(0x1013_2773, 2);  if(jz(0x1013_27a7, 0x32)) goto l_0x1013_27a7;/* jz 0x101327a7 */
            ii(0x1013_2775, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2778, 4);  mov(ax, memw[ds, eax + 5]);           /* mov ax, [eax+0x5] */
            ii(0x1013_277c, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1013_277f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_2782, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_2785, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_2788, 4);  mov(memw[ds, edx + 5], ax);           /* mov [edx+0x5], ax */
            ii(0x1013_278c, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_2791, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2794, 5);  call(0x1013_2489, -0x310);            /* call 0x10132489 */
            ii(0x1013_2799, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_279d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_27a0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_27a2, 5);  call(0x1013_2ebd, 0x716);             /* call 0x10132ebd */
        l_0x1013_27a7:
            ii(0x1013_27a7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_27a9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_27aa, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_27ab, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_27ac, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_27ad, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_27ae, 1);  ret();                                /* ret */
        }
    }
}
