using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4b64-5684de3d")]
        public void Method_100d_4b64()
        {
            ii(0x100d_4b64, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100d_4b69, 5);  call(Definitions.sys_check_available_stack_size, 0x9_11e4);/* call 0x10165d52 */
            ii(0x100d_4b6e, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_4b6f, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_4b70, 1);  push(esi);                            /* push esi */
            ii(0x100d_4b71, 1);  push(edi);                            /* push edi */
            ii(0x100d_4b72, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_4b73, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_4b75, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100d_4b7b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_4b7e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_4b81, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x100d_4b86, 5);  call(0x1007_5fdc, -0x5_ebaf);         /* call 0x10075fdc */
            ii(0x100d_4b8b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_4b8d, 2);  if(jz(0x100d_4b9b, 0xc)) goto l_0x100d_4b9b;/* jz 0x100d4b9b */
            ii(0x100d_4b8f, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x100d_4b96, 5);  jmp(0x100d_4c5e, 0xc3); goto l_0x100d_4c5e;/* jmp 0x100d4c5e */
        l_0x100d_4b9b:
            ii(0x100d_4b9b, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_4b9f, 6);  imul(edx, eax, 0x247);                /* imul edx, eax, 0x247 */
            ii(0x100d_4ba5, 5);  mov(eax, 0x101c_a468);                /* mov eax, 0x101ca468 */
            ii(0x100d_4baa, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_4bac, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_4baf, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_4bb3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_4bb6, 5);  call(0x100d_fd2c, 0xb171);            /* call 0x100dfd2c */
            ii(0x100d_4bbb, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100d_4bbf, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_4bc2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_4bc5, 3);  mov(al, memb[ds, eax + 40]);          /* mov al, [eax+0x28] */
            ii(0x100d_4bc8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100d_4bcd, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100d_4bd0, 2);  if(jz(0x100d_4bdd, 0xb)) goto l_0x100d_4bdd;/* jz 0x100d4bdd */
            ii(0x100d_4bd2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_4bd5, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4bd8, 5);  jmp(0x100d_4c5e, 0x81); goto l_0x100d_4c5e;/* jmp 0x100d4c5e */
        l_0x100d_4bdd:
            ii(0x100d_4bdd, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100d_4be2, 5);  call(0x1007_5fdc, -0x5_ec0b);         /* call 0x10075fdc */
            ii(0x100d_4be7, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_4bea, 2);  jmp(0x100d_4c3c, 0x50); goto l_0x100d_4c3c;/* jmp 0x100d4c3c */
        l_0x100d_4bec:
            ii(0x100d_4bec, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_4bf0, 3);  lea(edx, memd[ds, edx + edx * 4]);    /* lea edx, [edx+edx*4] */
            ii(0x100d_4bf3, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_4bf5, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_4bf8, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100d_4bfb, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x100d_4bfd, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x100d_4c00, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4c03, 2);  jmp(0x100d_4c5e, 0x59); goto l_0x100d_4c5e;/* jmp 0x100d4c5e */
        l_0x100d_4c05:
            ii(0x100d_4c05, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_4c09, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_4c0c, 3);  lea(edx, memd[ds, eax + 2]);          /* lea edx, [eax+0x2] */
            ii(0x100d_4c0f, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100d_4c14, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_4c16, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_4c19, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_4c1b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4c1e, 2);  jmp(0x100d_4c5e, 0x3e); goto l_0x100d_4c5e;/* jmp 0x100d4c5e */
        l_0x100d_4c20:
            ii(0x100d_4c20, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_4c24, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_4c26, 3);  lea(edx, memd[ds, eax + 1]);          /* lea edx, [eax+0x1] */
            ii(0x100d_4c29, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100d_4c2e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_4c30, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_4c33, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_4c35, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4c38, 2);  jmp(0x100d_4c5e, 0x24); goto l_0x100d_4c5e;/* jmp 0x100d4c5e */
        l_0x100d_4c3a:
            ii(0x100d_4c3a, 2);  jmp(0x100d_4c58, 0x1c); goto l_0x100d_4c58;/* jmp 0x100d4c58 */
        l_0x100d_4c3c:
            ii(0x100d_4c3c, 4);  cmp(memd[ss, ebp - 24], 4);           /* cmp dword [ebp-0x18], 0x4 */
            ii(0x100d_4c40, 2);  if(jb(0x100d_4c50, 0xe)) goto l_0x100d_4c50;/* jb 0x100d4c50 */
            ii(0x100d_4c42, 4);  cmp(memd[ss, ebp - 24], 4);           /* cmp dword [ebp-0x18], 0x4 */
            ii(0x100d_4c46, 2);  if(jbe(0x100d_4c05, -0x43)) goto l_0x100d_4c05;/* jbe 0x100d4c05 */
            ii(0x100d_4c48, 4);  cmp(memd[ss, ebp - 24], 5);           /* cmp dword [ebp-0x18], 0x5 */
            ii(0x100d_4c4c, 2);  if(jz(0x100d_4c20, -0x2e)) goto l_0x100d_4c20;/* jz 0x100d4c20 */
            ii(0x100d_4c4e, 2);  jmp(0x100d_4c3a, -0x16); goto l_0x100d_4c3a;/* jmp 0x100d4c3a */
        l_0x100d_4c50:
            ii(0x100d_4c50, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_4c54, 2);  if(jz(0x100d_4bec, -0x6a)) goto l_0x100d_4bec;/* jz 0x100d4bec */
            ii(0x100d_4c56, 2);  jmp(0x100d_4c3a, -0x1e); goto l_0x100d_4c3a;/* jmp 0x100d4c3a */
        l_0x100d_4c58:
            ii(0x100d_4c58, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_4c5b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x100d_4c5e:
            ii(0x100d_4c5e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_4c61, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_4c63, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_4c64, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_4c65, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_4c66, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_4c67, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_4c68, 1);  ret();                                /* ret */
        }
    }
}
