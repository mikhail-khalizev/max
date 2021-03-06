using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5cbd-3c858149")]
        public void Method_100d_5cbd()
        {
            ii(0x100d_5cbd, 5);  push(0x80);                           /* push 0x80 */
            ii(0x100d_5cc2, 5);  call(Definitions.sys_check_available_stack_size, 0x9_008b);/* call 0x10165d52 */
            ii(0x100d_5cc7, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_5cc8, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_5cc9, 1);  push(edx);                            /* push edx */
            ii(0x100d_5cca, 1);  push(esi);                            /* push esi */
            ii(0x100d_5ccb, 1);  push(edi);                            /* push edi */
            ii(0x100d_5ccc, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_5ccd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_5ccf, 6);  sub(esp, 0x4c);                       /* sub esp, 0x4c */
            ii(0x100d_5cd5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_5cd8, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100d_5cdf, 2);  jmp(0x100d_5ce7, 6); goto l_0x100d_5ce7;/* jmp 0x100d5ce7 */
        l_0x100d_5ce1:
            ii(0x100d_5ce1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_5ce4, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100d_5ce7:
            ii(0x100d_5ce7, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_5ceb, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100d_5cee, 6);  if(jge(0x100d_5de7, 0xf3)) goto l_0x100d_5de7;/* jge 0x100d5de7 */
            ii(0x100d_5cf4, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_5cf8, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_5cfe, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100d_5d04, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100d_5d09, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x100d_5d0c, 6);  if(jnz(0x100d_5de2, 0xd0)) goto l_0x100d_5de2;/* jnz 0x100d5de2 */
            ii(0x100d_5d12, 5);  mov(ecx, 0x1e);                       /* mov ecx, 0x1e */
            ii(0x100d_5d17, 3);  lea(ebx, memd[ss, ebp - 44]);         /* lea ebx, [ebp-0x2c] */
            ii(0x100d_5d1a, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100d_5d1d, 2);  add(al, 0x63);                        /* add al, 0x63 */
            ii(0x100d_5d1f, 3);  movsx(edx, al);                       /* movsx edx, al */
            ii(0x100d_5d22, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x100d_5d27, 5);  call(0x1010_6281, 0x3_0555);          /* call 0x10106281 */
            ii(0x100d_5d2c, 5);  call(0x100d_531c, -0xa15);            /* call 0x100d531c */
            ii(0x100d_5d31, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100d_5d36, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_5d39, 3);  push(memd[ss, ebp - 48]);             /* push dword [ebp-0x30] */
            ii(0x100d_5d3c, 7);  mov(memd[ss, ebp - 52], 1);           /* mov dword [ebp-0x34], 0x1 */
            ii(0x100d_5d43, 3);  push(memd[ss, ebp - 52]);             /* push dword [ebp-0x34] */
            ii(0x100d_5d46, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_5d4a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_5d4d, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x100d_5d50, 3);  mov(eax, memd[ds, eax + 62]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_5d53, 5);  call(0x100d_5104, -0xc54);            /* call 0x100d5104 */
            ii(0x100d_5d58, 5);  call(/* sys */ 0x1016_8de8, 0x9_308b);/* call 0x10168de8 */
            ii(0x100d_5d5d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_5d5f, 2);  if(jz(0x100d_5d67, 6)) goto l_0x100d_5d67;/* jz 0x100d5d67 */
            ii(0x100d_5d61, 4);  mov(memb[ss, ebp - 12], 0xff);        /* mov byte [ebp-0xc], 0xff */
            ii(0x100d_5d65, 2);  jmp(0x100d_5d6b, 4); goto l_0x100d_5d6b;/* jmp 0x100d5d6b */
        l_0x100d_5d67:
            ii(0x100d_5d67, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
        l_0x100d_5d6b:
            ii(0x100d_5d6b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_5d6d, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100d_5d70, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_5d73, 3);  push(memd[ss, ebp - 56]);             /* push dword [ebp-0x38] */
            ii(0x100d_5d76, 7);  mov(memd[ss, ebp - 60], 0xa);         /* mov dword [ebp-0x3c], 0xa */
            ii(0x100d_5d7d, 3);  push(memd[ss, ebp - 60]);             /* push dword [ebp-0x3c] */
            ii(0x100d_5d80, 7);  mov(memd[ss, ebp - 64], 0x82);        /* mov dword [ebp-0x40], 0x82 */
            ii(0x100d_5d87, 3);  push(memd[ss, ebp - 64]);             /* push dword [ebp-0x40] */
            ii(0x100d_5d8a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_5d8e, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100d_5d91, 2);  if(jle(0x100d_5d9c, 9)) goto l_0x100d_5d9c;/* jle 0x100d5d9c */
            ii(0x100d_5d93, 7);  mov(memd[ss, ebp - 68], 0x39);        /* mov dword [ebp-0x44], 0x39 */
            ii(0x100d_5d9a, 2);  jmp(0x100d_5da3, 7); goto l_0x100d_5da3;/* jmp 0x100d5da3 */
        l_0x100d_5d9c:
            ii(0x100d_5d9c, 7);  mov(memd[ss, ebp - 68], 0x16);        /* mov dword [ebp-0x44], 0x16 */
        l_0x100d_5da3:
            ii(0x100d_5da3, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_5da6, 1);  cwde();                               /* cwde */
            ii(0x100d_5da7, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_5daa, 3);  push(memd[ss, ebp - 72]);             /* push dword [ebp-0x48] */
            ii(0x100d_5dad, 6);  test(memw[ss, ebp - 8], 1);           /* test word [ebp-0x8], 0x1 */
            ii(0x100d_5db3, 2);  if(jz(0x100d_5dbe, 9)) goto l_0x100d_5dbe;/* jz 0x100d5dbe */
            ii(0x100d_5db5, 7);  mov(memd[ss, ebp - 76], 0x106);       /* mov dword [ebp-0x4c], 0x106 */
            ii(0x100d_5dbc, 2);  jmp(0x100d_5dc5, 7); goto l_0x100d_5dc5;/* jmp 0x100d5dc5 */
        l_0x100d_5dbe:
            ii(0x100d_5dbe, 7);  mov(memd[ss, ebp - 76], 0x42);        /* mov dword [ebp-0x4c], 0x42 */
        l_0x100d_5dc5:
            ii(0x100d_5dc5, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_5dc8, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100d_5dcb, 3);  lea(ebx, memd[ss, ebp - 44]);         /* lea ebx, [ebp-0x2c] */
            ii(0x100d_5dce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5dd1, 3);  mov(edx, memd[ds, eax + 37]);         /* mov edx, [eax+0x25] */
            ii(0x100d_5dd4, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_5dd7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5dda, 3);  mov(eax, memd[ds, eax + 45]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_5ddd, 5);  call(0x100e_9ae5, 0x1_3d03);          /* call 0x100e9ae5 */
        l_0x100d_5de2:
            ii(0x100d_5de2, 5);  jmp(0x100d_5ce1, -0x106); goto l_0x100d_5ce1;/* jmp 0x100d5ce1 */
        l_0x100d_5de7:
            ii(0x100d_5de7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_5dea, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x100d_5ded, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5df0, 3);  mov(eax, memd[ds, eax + 41]);         /* mov eax, [eax+0x29] */
            ii(0x100d_5df3, 5);  call(Definitions.sys_display_draw_1, 0x9_16b0);/* call 0x101674a8 */
            ii(0x100d_5df8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_5dfa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_5dfb, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_5dfc, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_5dfd, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_5dfe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5dff, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5e00, 1);  ret();                                /* ret */
        }
    }
}
