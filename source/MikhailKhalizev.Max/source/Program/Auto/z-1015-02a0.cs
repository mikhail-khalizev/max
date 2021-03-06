using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_02a0-798bf722")]
        public void Method_1015_02a0()
        {
            ii(0x1015_02a0, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1015_02a5, 5);  call(Definitions.sys_check_available_stack_size, 0x1_5aa8);/* call 0x10165d52 */
            ii(0x1015_02aa, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_02ab, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_02ac, 1);  push(edx);                            /* push edx */
            ii(0x1015_02ad, 1);  push(esi);                            /* push esi */
            ii(0x1015_02ae, 1);  push(edi);                            /* push edi */
            ii(0x1015_02af, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_02b0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_02b2, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1015_02b8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_02bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_02be, 4);  test(memb[ds, eax + 19], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x1015_02c2, 2);  if(jz(0x1015_02d9, 0x15)) goto l_0x1015_02d9;/* jz 0x101502d9 */
            ii(0x1015_02c4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_02c7, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1015_02ca, 5);  call(0x1007_6730, -0xd_9b9f);         /* call 0x10076730 */
            ii(0x1015_02cf, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x1015_02d2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_02d5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_02d7, 2);  if(jg(0x1015_02db, 2)) goto l_0x1015_02db;/* jg 0x101502db */
        l_0x1015_02d9:
            ii(0x1015_02d9, 2);  jmp(0x1015_02fb, 0x20); goto l_0x1015_02fb;/* jmp 0x101502fb */
        l_0x1015_02db:
            ii(0x1015_02db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_02de, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1015_02e1, 5);  call(0x1007_6730, -0xd_9bb6);         /* call 0x10076730 */
            ii(0x1015_02e6, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1015_02e9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_02ec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_02ef, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x1015_02f2, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_02f7, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1015_02f9, 2);  if(jg(0x1015_02fd, 2)) goto l_0x1015_02fd;/* jg 0x101502fd */
        l_0x1015_02fb:
            ii(0x1015_02fb, 2);  jmp(0x1015_0358, 0x5b); goto l_0x1015_0358;/* jmp 0x10150358 */
        l_0x1015_02fd:
            ii(0x1015_02fd, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_0300, 5);  call(0x1007_20b1, -0xd_e254);         /* call 0x100720b1 */
            ii(0x1015_0305, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_0308, 5);  call(0x1007_20b1, -0xd_e25c);         /* call 0x100720b1 */
            ii(0x1015_030d, 3);  lea(ebx, memd[ss, ebp - 28]);         /* lea ebx, [ebp-0x1c] */
            ii(0x1015_0310, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1015_0313, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0316, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x1015_0319, 5);  call(0x1007_68e0, -0xd_9a3e);         /* call 0x100768e0 */
            ii(0x1015_031e, 5);  call(0x1014_3616, -0xcd0d);           /* call 0x10143616 */
            ii(0x1015_0323, 4);  movsx(eax, memw[ss, ebp - 14]);       /* movsx eax, word [ebp-0xe] */
            ii(0x1015_0327, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_0329, 2);  if(jle(0x1015_0358, 0x2d)) goto l_0x1015_0358;/* jle 0x10150358 */
            ii(0x1015_032b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_032e, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1015_0331, 5);  call(0x1007_6730, -0xd_9c06);         /* call 0x10076730 */
            ii(0x1015_0336, 3);  mov(dl, memb[ds, eax + 27]);          /* mov dl, [eax+0x1b] */
            ii(0x1015_0339, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_033c, 3);  mov(memb[ds, eax + 84], dl);          /* mov [eax+0x54], dl */
            ii(0x1015_033f, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1015_0341, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1015_0343, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
            ii(0x1015_0348, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_034b, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x1015_034e, 5);  call(0x1007_68e0, -0xd_9a73);         /* call 0x100768e0 */
            ii(0x1015_0353, 5);  call(0x100d_7a9c, -0x7_88bc);         /* call 0x100d7a9c */
        l_0x1015_0358:
            ii(0x1015_0358, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_035b, 5);  call(0x1015_0d4c, 0x9ec);             /* call 0x10150d4c */
            ii(0x1015_0360, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_0362, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_0363, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_0364, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_0365, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_0366, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_0367, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_0368, 1);  ret();                                /* ret */
        }
    }
}
