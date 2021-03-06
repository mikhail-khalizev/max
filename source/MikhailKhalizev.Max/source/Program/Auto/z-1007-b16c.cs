using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b16c-552b7825")]
        public void Method_1007_b16c()
        {
            ii(0x1007_b16c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_b171, 5);  call(Definitions.sys_check_available_stack_size, 0xe_abdc);/* call 0x10165d52 */
            ii(0x1007_b176, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_b177, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_b178, 1);  push(esi);                            /* push esi */
            ii(0x1007_b179, 1);  push(edi);                            /* push edi */
            ii(0x1007_b17a, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_b17b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_b17d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_b183, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_b186, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_b189, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b18b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b18e, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_b191, 5);  call(0x1013_ad11, 0xb_fb7b);          /* call 0x1013ad11 */
            ii(0x1007_b196, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_b198, 2);  if(jz(0x1007_b1aa, 0x10)) goto l_0x1007_b1aa;/* jz 0x1007b1aa */
            ii(0x1007_b19a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_b19d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b1a0, 5);  call(0x100a_2ce8, 0x2_7b43);          /* call 0x100a2ce8 */
            ii(0x1007_b1a5, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_b1a8, 2);  jmp(0x1007_b1f6, 0x4c); goto l_0x1007_b1f6;/* jmp 0x1007b1f6 */
        l_0x1007_b1aa:
            ii(0x1007_b1aa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b1ad, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_b1b0, 5);  call(0x1008_a228, 0xf073);            /* call 0x1008a228 */
            ii(0x1007_b1b5, 5);  call(0x100b_8ea1, 0x3_dce7);          /* call 0x100b8ea1 */
            ii(0x1007_b1ba, 1);  cwde();                               /* cwde */
            ii(0x1007_b1bb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_b1be, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1007_b1c0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b1c3, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_b1c6, 5);  call(0x1008_a228, 0xf05d);            /* call 0x1008a228 */
            ii(0x1007_b1cb, 5);  call(0x100b_8eda, 0x3_dd0a);          /* call 0x100b8eda */
            ii(0x1007_b1d0, 1);  cwde();                               /* cwde */
            ii(0x1007_b1d1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_b1d4, 3);  mov(memd[ds, edx + 4], eax);          /* mov [edx+0x4], eax */
            ii(0x1007_b1d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b1da, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_b1dc, 1);  inc(eax);                             /* inc eax */
            ii(0x1007_b1dd, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_b1e0, 3);  mov(memd[ds, edx + 8], eax);          /* mov [edx+0x8], eax */
            ii(0x1007_b1e3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b1e6, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1007_b1e9, 1);  inc(eax);                             /* inc eax */
            ii(0x1007_b1ea, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_b1ed, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x1007_b1f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b1f3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1007_b1f6:
            ii(0x1007_b1f6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_b1f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_b1fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_b1fc, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_b1fd, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_b1fe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_b1ff, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_b200, 1);  ret();                                /* ret */
        }
    }
}
