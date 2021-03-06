using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_e3e9-7bb49a60")]
        public void Method_100d_e3e9()
        {
            ii(0x100d_e3e9, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100d_e3ee, 5);  call(Definitions.sys_check_available_stack_size, 0x8_795f);/* call 0x10165d52 */
            ii(0x100d_e3f3, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_e3f4, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_e3f5, 1);  push(esi);                            /* push esi */
            ii(0x100d_e3f6, 1);  push(edi);                            /* push edi */
            ii(0x100d_e3f7, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_e3f8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_e3fa, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_e400, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_e403, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_e406, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e409, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e40f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_e412, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_e415, 3);  mov(edx, memd[ds, eax + 64]);         /* mov edx, [eax+0x40] */
            ii(0x100d_e418, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_e41b, 3);  call_abs(memd[ds, edx + 16]);         /* call dword [edx+0x10] */
            ii(0x100d_e41e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e421, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e427, 5);  call(0x100d_5018, -0x9414);           /* call 0x100d5018 */
            ii(0x100d_e42c, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_e42f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e432, 5);  add(eax, 0x3b7);                      /* add eax, 0x3b7 */
            ii(0x100d_e437, 5);  call(0x100e_08bc, 0x2480);            /* call 0x100e08bc */
            ii(0x100d_e43c, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100d_e43f, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100d_e444, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_e446, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_e449, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_e44b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_e44e, 3);  mov(edx, memd[ds, edx + 77]);         /* mov edx, [edx+0x4d] */
            ii(0x100d_e451, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_e454, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_e456, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_e459, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e45c, 6);  mov(eax, memd[ds, eax + 991]);        /* mov eax, [eax+0x3df] */
            ii(0x100d_e462, 5);  call(0x100d_778a, -0x6cdd);           /* call 0x100d778a */
            ii(0x100d_e467, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e46a, 6);  mov(eax, memd[ds, eax + 991]);        /* mov eax, [eax+0x3df] */
            ii(0x100d_e470, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_e473, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_e476, 3);  mov(edx, memd[ds, eax + 39]);         /* mov edx, [eax+0x27] */
            ii(0x100d_e479, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_e47c, 3);  call_abs(memd[ds, edx + 8]);          /* call dword [edx+0x8] */
            ii(0x100d_e47f, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_e483, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e486, 5);  call(0x100d_a4d5, -0x3fb6);           /* call 0x100da4d5 */
            ii(0x100d_e48b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_e48d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_e48e, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_e48f, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_e490, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_e491, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_e492, 1);  ret();                                /* ret */
        }
    }
}
