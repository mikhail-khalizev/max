using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_c75a-6016e9c1")]
        public void Method_1015_c75a()
        {
            ii(0x1015_c75a, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1015_c75f, 5);  call(Definitions.sys_check_available_stack_size, 0x95ee);/* call 0x10165d52 */
            ii(0x1015_c764, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_c765, 1);  push(esi);                            /* push esi */
            ii(0x1015_c766, 1);  push(edi);                            /* push edi */
            ii(0x1015_c767, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_c768, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_c76a, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1015_c770, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_c773, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1015_c776, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1015_c779, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_c77c, 3);  mov(edx, memd[ds, edx + 6]);          /* mov edx, [edx+0x6] */
            ii(0x1015_c77f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_c782, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_c785, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1015_c788, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_c78d, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1015_c793, 5);  mov(ebx, 0x101c_a468);                /* mov ebx, 0x101ca468 */
            ii(0x1015_c798, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1015_c79a, 5);  call(0x100d_fd2c, -0x7_ca73);         /* call 0x100dfd2c */
            ii(0x1015_c79f, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1015_c7a3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_c7a6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_c7a9, 5);  call(0x1015_0369, -0xc445);           /* call 0x10150369 */
            ii(0x1015_c7ae, 1);  cwde();                               /* cwde */
            ii(0x1015_c7af, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1015_c7b2, 3);  shl(eax, 3);                          /* shl eax, 0x3 */
            ii(0x1015_c7b5, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1015_c7b9, 6);  lea(edx, memd[ds, eax + 640]);        /* lea edx, [eax+0x280] */
            ii(0x1015_c7bf, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1015_c7c1, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1015_c7c4, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1015_c7c6, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_c7c9, 4);  cmp(memb[ss, ebp - 4], 0x18);         /* cmp byte [ebp-0x4], 0x18 */
            ii(0x1015_c7cd, 2);  if(jnz(0x1015_c7e2, 0x13)) goto l_0x1015_c7e2;/* jnz 0x1015c7e2 */
            ii(0x1015_c7cf, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_c7d2, 2);  cwd();                                /* cwd */
            ii(0x1015_c7d4, 4);  shl(dx, 2);                           /* shl dx, 0x2 */
            ii(0x1015_c7d8, 3);  sbb(ax, dx);                          /* sbb ax, dx */
            ii(0x1015_c7db, 4);  sar(ax, 2);                           /* sar ax, 0x2 */
            ii(0x1015_c7df, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1015_c7e2:
            ii(0x1015_c7e2, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1015_c7e6, 3);  cmp(eax, 0x5a);                       /* cmp eax, 0x5a */
            ii(0x1015_c7e9, 2);  if(jle(0x1015_c7f2, 7)) goto l_0x1015_c7f2;/* jle 0x1015c7f2 */
            ii(0x1015_c7eb, 7);  mov(memd[ss, ebp - 20], 0x5a);        /* mov dword [ebp-0x14], 0x5a */
        l_0x1015_c7f2:
            ii(0x1015_c7f2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_c7f5, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_c7f8, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_c7fb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_c7fd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_c7fe, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_c7ff, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_c800, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_c801, 1);  ret();                                /* ret */
        }
    }
}
