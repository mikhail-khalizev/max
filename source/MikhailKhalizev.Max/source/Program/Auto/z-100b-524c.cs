using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_524c-a63a42dc")]
        public void Method_100b_524c()
        {
            ii(0x100b_524c, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100b_5251, 5);  call(Definitions.sys_check_available_stack_size, 0xb_0afc);/* call 0x10165d52 */
            ii(0x100b_5256, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_5257, 1);  push(esi);                            /* push esi */
            ii(0x100b_5258, 1);  push(edi);                            /* push edi */
            ii(0x100b_5259, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_525a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_525c, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100b_5262, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_5265, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_5268, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100b_526b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_526e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_5271, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_5274, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_5277, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_527a, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100b_527d, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100b_5280, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100b_5283, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_5286, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100b_5289, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100b_528b, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100b_528e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_5291, 5);  call(0x100a_26d1, -0x1_2bc5);         /* call 0x100a26d1 */
            ii(0x100b_5296, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_5299, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100b_529c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_529f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_52a2, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_52a5, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x3_ebba);/* call 0x100766f0 */
            ii(0x100b_52aa, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x100b_52ad, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_52b0, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100b_52b3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_52b6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_52b9, 7);  mov(memd[ds, eax + 2], 0x101b_51f4);  /* mov dword [eax+0x2], 0x101b51f4 */
            ii(0x100b_52c0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_52c3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_52c6, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_52c9, 5);  call(0x1007_6630, -0x3_ec9e);         /* call 0x10076630 */
            ii(0x100b_52ce, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_52d1, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_52d4, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_52d7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_52d9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_52da, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_52db, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_52dc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_52dd, 1);  ret();                                /* ret */
        }
    }
}
